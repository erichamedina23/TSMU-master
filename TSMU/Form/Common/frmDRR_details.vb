Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDRR_details
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim GridDtl As GridControl
    Dim dtGrid As New DataTable
    Dim id As Globalization.CultureInfo
    Dim _Tag As TagModel
    Dim _service As DRRService
    Dim ObjHeader As DRRModel
    Dim ObjDetail As DRRDetail
    Private dragDropHelper As DragDropHelper
    Dim IsTrue As Boolean

    Dim CmbLevel As RepositoryItemComboBox = New RepositoryItemComboBox()
    Dim CmbReference As RepositoryItemComboBox = New RepositoryItemComboBox()
    Dim CmbSurface As RepositoryItemComboBox = New RepositoryItemComboBox()
    Dim LookPartName As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
    Dim CmnProses As RepositoryItemComboBox = New RepositoryItemComboBox()
    Dim TxtQty As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
    Dim TxtCavity As RepositoryItemTextEdit = New RepositoryItemTextEdit()
    Dim TxtTonase As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
    Dim TxtPartName As RepositoryItemTextEdit = New RepositoryItemTextEdit()
    Dim BtnPartName As RepositoryItemButtonEdit = New RepositoryItemButtonEdit()
    Dim _inplaceEditors As RepositoryItem()
    'Dim _path As String = "\\10.10.1.12\e$\DRR Sketch\" 'D:\TOOLS\Sketch
    'Dim _path As String = "D:\TOOLS\Sketch\"
    Dim _path As String = "\\10.10.3.6\d$\TESTING\DRR Sktech\"
    Dim images As List(Of String)
    Private Initializing As Boolean = False
    Dim ImgList As List(Of ImageModel)
    Dim ImgToDelete As List(Of ImageModel)
    Dim bott As Telegram.Bot.TelegramBotClient
    Dim _Level As Integer
    Dim ObjApprove As ApproveHistoryModel
    Dim _serviceGlobal As GlobalService
    Dim _Status As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form,
                   ByVal li_GridRow As Integer,
                   ByRef _Grid As GridControl, Level As Integer, Optional Status As String = "Submited")
        ' this call is required by the windows form designer
        Me.New()
        If strCode <> "" Then
            fs_Code = strCode
            fs_Code2 = strCode2
            bi_GridParentRow = li_GridRow
            _Status = Status
        End If
        GridDtl = _Grid
        FrmParent = lf_FormParent
        _Tag = New TagModel
        _Tag.PageIndex = lf_FormParent.Tag.PageIndex
        Tag = _Tag
        dragDropHelper = New DragDropHelper(GalleryControl1)
        dragDropHelper.EnableDragDrop()
        IsTrue = True
        Initializing = True
        _Level = Level
    End Sub

    Private Sub frmDRR_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, If(_Level = 1, False, True), False)
        Call Proc_EnableButtons(False, If(_Level = 0, False, True), False, True, False, False, False, False, False, False, True, False)
        Call InitialSetForm()
        AddHandler CmbLevel.EditValueChanged, AddressOf OnEditValueChanged
        AddHandler LookPartName.EditValueChanged, AddressOf OnEditValueChanged
        AddHandler CmnProses.EditValueChanged, AddressOf OnEditValueChanged
        AddHandler CmbReference.EditValueChanged, AddressOf OnEditValueChanged
        AddHandler CmbSurface.EditValueChanged, AddressOf OnEditValueChanged
        AddHandler TxtPartName.EditValueChanged, AddressOf OnEditValueChanged
        'AddHandler BtnPartName.EditValueChanged, AddressOf OnEditValueChanged
        'AddHandler BtnPartName.EditValueChanged, AddressOf OnEditValueChanged
        AddHandler BtnPartName.ButtonClick, AddressOf BtnClick
    End Sub

    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "0" Then
                _service = New DRRService
                ObjHeader = New DRRModel
                ObjHeader = _service.GetById(Convert.ToInt32(fs_Code))
                images = Nothing
                'LoadDetail(True)
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
            End If
            Text = "DRR DETAIL"
            'PopulateCustomer()
            'PopulateNPP()
            LoadTxtBox()
            LoadDetail()

            SetEditColumnGrid()

            'End If
            InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = FrmParent.Name
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub LoadTxtBox()
        Try
            If fs_Code <> "0" Then

                With ObjHeader
                    TxtNoNpp.Text = .No_NPP
                    TxtCustomer.Text = .Customer
                    TxtProject.Text = .Project
                    TxtMaspro.EditValue = .DueDateMaspro
                    TxtDate.EditValue = .Tanggal
                    TxtTime.EditValue = .Time
                    TxtNoDokumen.Text = .NoDokumen
                    TxtForecast.Text = .ForecastOrder
                    images = New List(Of String)
                    images = New List(Of String)({ .Gambar1, .Gambar2, .Gambar3, .Gambar4, .Gambar5})

                    GenerateImageGallery()
                    TxtNoNpp.Properties.ReadOnly = True
                End With
            Else
                TxtNoNpp.Text = ""
                TxtCustomer.Text = ""
                TxtProject.Text = ""
                TxtNoDokumen.Text = ""
                TxtMaspro.EditValue = Date.Today
                TxtDate.EditValue = Date.Today
                TxtTime.EditValue = Date.Now

                TxtForecast.Text = ""
                TxtNoNpp.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub GenerateImageGallery()
        Dim _NPP As String = String.Empty
        For Each gambar In images
            Dim pathParts = gambar.Split("_"c)
            Dim fileName = pathParts(pathParts.Count() - 1).Split("."c)
            Dim _index = pathParts(pathParts.Count() - 1).Split(","c)


            If fileName(0).ToString = "" Then
                Exit For
            End If
            _NPP = pathParts(0)
            Dim img As Image
            If Directory.Exists(_path) Then
                img = New Bitmap(Image.FromFile(Path.Combine(_path, pathParts(0) & "_" & _index(0))))
                If img IsNot Nothing Then
                    GalleryControl1.Gallery.Groups(0).Items.Add(New GalleryItem(img, img, _index(0), "", CInt(_index(1)), CInt(_index(1)), Nothing, ""))
                End If
                'img = New Image.FromFile(Path.Combine(_path, pathParts(0) & "_" & _index(0)))
                'img = New Bitmap(Path.Combine(_path, pathParts(0) & "_" & _index(0)))
                'GalleryControl1.Gallery.Groups(0).Items.Add(New GalleryItem(img, img, _index(0), "", CInt(_index(1)), CInt(_index(1)), Nothing, ""))
            End If
        Next

        images = New List(Of String)

        Dim _files As String()
        _files = Directory.GetFiles(_path, "*.png")
        For Each file In _files
            Dim separtor = file.Split("_"c)
            If separtor.Length > 2 Then
                If separtor(0) = Path.Combine(_path, _NPP) AndAlso separtor(2).Contains("Attach") Then
                    images.Add(file)
                End If
            End If

        Next
    End Sub
    Private Sub LoadDetail()
        Try
            'bandCreated = False
            Dim dt As New DataTable
            _service = New DRRService
            'Grid.DataSource = Nothing
            'BandedGridView1.Bands.Clear()
            'BandedGridView1.Columns.Clear()
            dt = _service.DetailGetById(CInt(fs_Code))

            Grid.DataSource = dt
            With BandedGridView1
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(3).Visible = False
                .BestFitColumns()
                For Each col As GridColumn In .Columns
                    If col.Name.ToLower = "colseq" Then
                        col.OptionsColumn.AllowEdit = False
                    Else
                        col.OptionsColumn.AllowEdit = True
                    End If
                Next
            End With

            If IsTrue Then
                BandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
            End If
            BandedGridView1.OptionsView.ColumnAutoWidth = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub PopulateNPP()
    '    Dim dtNpp As New DataTable
    '    _service = New DRRService
    '    dtNpp = _service.GetNPP
    '    TxtNoNpp.Properties.DataSource = Nothing
    '    TxtNoNpp.Properties.DataSource = dtNpp
    '    TxtNoNpp.Properties.ValueMember = "No_NPP"
    '    TxtNoNpp.Properties.DisplayMember = "No_NPP"
    '    TxtNoNpp.Properties.PopulateColumns()
    'End Sub

    Private Function GetBandedGridView() As BandedGridView
        Dim bandedView As BandedGridView = New BandedGridView()
        SetGridBand(bandedView, "Mass/Weight (gr)", New String(1) {"colPart", "colRunner"})
        SetGridBand(bandedView, "Dimension", New String(2) {"colLong", "colWidth", "colHeight"})
        Return bandedView
    End Function
    Private Sub SetGridBand(ByVal bandedView As BandedGridView, ByVal gridBandCaption As String, ByVal columnNames As String())
        Dim gridBand = New GridBand()
        gridBand.Caption = gridBandCaption
        Dim nrOfColumns As Integer = columnNames.Length
        Dim bandedColumns As BandedGridColumn() = New BandedGridColumn(nrOfColumns - 1) {}

        For i As Integer = 0 To nrOfColumns - 1
            bandedColumns(i) = CType(bandedView.Columns.AddField(columnNames(i)), BandedGridColumn)
            bandedColumns(i).OwnerBand = gridBand
            bandedColumns(i).Visible = True
        Next
    End Sub
    Private Sub CreateBand(ByVal caption As String, ByVal columns As BandedGridColumn(), index As Integer, name As String)


        Dim band As GridBand = BandedGridView1.Bands.AddBand(caption)
        band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        band.VisibleIndex = index
        band.Name = name
        For Each column As BandedGridColumn In columns
            band.Columns.Remove(column)
            band.Columns.Add(column)
        Next

        bandCreated = True
    End Sub
    Private bandCreated As Boolean = False
    Private Sub SetEditColumnGrid()
        Try
            'Grid.MainView = GetBandedGridView()
            'GetBandedGridView()

            'AddHandler TxtTonase.EditValueChanged, AddressOf OnEditValueChanged
            _inplaceEditors = New RepositoryItem() {LookPartName, TxtPartName}
            _service = New DRRService

            'Dim dtPart As New DataTable
            'dtPart = _service.GetPartName(TxtNoNpp.EditValue)
            'LookPartName.NullText = "Pilih Part"
            'LookPartName.PopupWidth = 500
            'LookPartName.DataSource = Nothing
            'LookPartName.DataSource = dtPart
            'LookPartName.ValueMember = "Seq"
            'LookPartName.DisplayMember = "Seq"
            'LookPartName.PopulateColumns()


            CmbLevel.Items.Clear()
            CmbLevel.Items.AddRange(New String() {"1", "2", "3", "4"})
            CmnProses.Items.Clear()
            CmnProses.Items.AddRange(New String() {"Inj", "Painting", "Chrome", "Assy", "Ultrasonic", "Vibration"})
            CmbReference.Items.Clear()
            CmbReference.Items.AddRange(New String() {"DRAWING", "CAD DATA", "SKETCH", "SAMPLE"})
            CmbSurface.Items.Clear()
            CmbSurface.Items.AddRange(New String() {"GRAIN", "PAINTING", "RAW MATERIAL", "CHROME/PLATING"})


            With BandedGridView1

                .Columns("Level").ColumnEdit = CmbLevel
                .Columns("PartName").ColumnEdit = BtnPartName
                '.Columns("Qty").ColumnEdit = TxtQty
                '.Columns("Tonage").ColumnEdit = TxtTonase
                .Columns("Proses").ColumnEdit = CmnProses
                .Columns("Reference").ColumnEdit = CmbReference
                .Columns("SurfaceTreatment").ColumnEdit = CmbSurface
            End With
            With Grid.RepositoryItems
                .Add(CmbLevel)
                .Add(BtnPartName)
                '.Add(TxtQty)
                .Add(CmbSurface)
                .Add(CmnProses)
                .Add(CmbReference)
            End With
            If Not bandCreated Then
                CreateBand("Mass/Weight (gr)", New BandedGridColumn() {BandedGridView1.Columns("Part"), BandedGridView1.Columns("Runner")}, 11, "BandMass")
                CreateBand("Dimension", New BandedGridColumn() {BandedGridView1.Columns("Long"), BandedGridView1.Columns("Width"), BandedGridView1.Columns("Height")}, 12, "BandDimension")
            End If
            'AddHandler GridView1.CustomColumnDisplayText, AddressOf GridView1_CustomColumnDisplayText
            'AddHandler GridView1.ShowingEditor, AddressOf GridView1_ShowingEditor
            'AddHandler GridView1.RowCellStyle, AddressOf GridView1_RowCellStyle
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub SetGridValue(ByVal sender As Object)
        Try
            If BandedGridView1.FocusedColumn.Name.ToLower = "collevel" Then
                With BandedGridView1
                    .SetFocusedRowCellValue("PartName", "")
                    .SetFocusedRowCellValue("Seq", 0)
                    .SetFocusedRowCellValue("PartNo", "")
                    .SetFocusedRowCellValue("Proses", "Inj")
                    .SetFocusedRowCellValue("Qty", 0)
                    .SetFocusedRowCellValue("Cavity", "")
                    .SetFocusedRowCellValue("Tonage", "0")
                    .SetFocusedRowCellValue("Material", "")
                    .SetFocusedRowCellValue("Part", 0)
                    .SetFocusedRowCellValue("Runner", 0)
                    .SetFocusedRowCellValue("Long", 0)
                    .SetFocusedRowCellValue("Width", 0)
                    .SetFocusedRowCellValue("Height", 0)
                    .SetFocusedRowCellValue("SurfaceTreatment", "GRAIN")
                    .SetFocusedRowCellValue("C/T", 0)
                    .SetFocusedRowCellValue("Thickn", 0)
                    .SetFocusedRowCellValue("Reference", "DRAWING")
                    .SetFocusedRowCellValue("Remark", "")
                    .FocusedColumn = .VisibleColumns(1)

                End With
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BtnClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""
            _service = New DRRService
            dtSearch = _service.GetPartName(TxtNoNpp.EditValue)
            ls_OldKode = If(String.IsNullOrEmpty(BandedGridView1.GetRowCellDisplayText(BandedGridView1.FocusedRowHandle, "PartName")), "", BandedGridView1.GetRowCellDisplayText(BandedGridView1.FocusedRowHandle, "PartName"))

            ls_Judul = "Part Name"


            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim Value1 As String = ""
            Dim Value2 As String = ""
            Dim Value3 As String = ""

            'Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As BandedGridView = TryCast(Grid.FocusedView, BandedGridView)
            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> "" Then
                Value1 = lF_SearchData.Values.Item(0).ToString.Trim
                Value2 = lF_SearchData.Values.Item(1).ToString.Trim
                Value3 = lF_SearchData.Values.Item(2).ToString.Trim
                view.SetRowCellValue(view.FocusedRowHandle, "PartName", Value1)
                view.SetRowCellValue(view.FocusedRowHandle, "PartNo", Value2)
                view.SetRowCellValue(view.FocusedRowHandle, "Seq", Value3)
            End If
            BandedGridView1.BestFitColumns()
            FormatBandedGridView(BandedGridView1)
            lF_SearchData.Close()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
    Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If BandedGridView1.FocusedRowHandle = GridControl.NewItemRowHandle Then
                SetGridValue(sender)

                BandedGridView1.CloseEditor()
                BandedGridView1.UpdateCurrentRow()
                BandedGridView1.ShowEditor()
                Dim edit As TextEdit = TryCast(sender, TextEdit)
                If edit Is Nothing Then Return
                edit.SelectionStart = 1
                edit.SelectionLength = 0

            Else
                SetGridValue(sender)

                BandedGridView1.PostEditor()
                BandedGridView1.UpdateCurrentRow()
                'GridView1.ShowEditor()

            End If
            FormatBandedGridView(BandedGridView1)
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try

    End Sub

    Public Overrides Sub Proc_Refresh()
        Initializing = True
        GalleryControl1.Gallery.Groups(0).Items.Clear()
        Call LoadTxtBox()
        LoadDetail()
        Initializing = False
    End Sub
    Public Overrides Sub Proc_Approve()
        Try
            _serviceGlobal = New GlobalService
            _service = New DRRService

            Dim result As DialogResult = XtraMessageBox.Show("Approve DRR untuk NPP " & "'" & TxtNoNpp.EditValue & "'" & " ?", "Confirmation", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                ObjApprove = New ApproveHistoryModel With {
                .UserName = gh_Common.Username,
                .MenuCode = FrmParent.Name,
                .DeptID = gh_Common.GroupID,
                .NoTransaksi = fs_Code,
                .LevelApproved = _Level,
                .ApprovedBy = gh_Common.Username,
                .IsActive = 1
                }
                If _Level = 2 Then
                    Select Case _Status.ToLower
                        Case "created"
                            Throw New Exception("DRR belum di submit oleh pembuat DRR!")
                        Case "checked"
                            Throw New Exception("DRR sudah pernah di cek !")
                        Case "completed"
                            Throw New Exception("DRR sudah di approve/completed!")
                    End Select
                ElseIf _Level = _serviceGlobal.GetMaxLevel(FrmParent) Then
                    Select Case _Status.ToLower
                        Case "created"
                            Throw New Exception("DRR belum di submit oleh pembuat DRR!")
                        Case "submited"
                            Throw New Exception("DRR sudah pernah di cek !")
                        Case "completed"
                            Throw New Exception("DRR sudah di approve/completed! !")
                    End Select
                End If
                _service.Approve(ObjApprove, FrmParent, _Level, fs_Code, TxtNoNpp.EditValue, BandedGridView1.GetRowCellValue(0, "PartName"))
                FrmParent.tsBtn_refresh.PerformClick()
                IsClosed = True

                ShowMessage(GetMessage(MessageEnum.ApproveBerhasil), MessageTypeEnum.NormalMessage)
                Hide()

            ElseIf result = DialogResult.No Then
                ObjApprove = New ApproveHistoryModel With {
                .UserName = gh_Common.Username,
                .MenuCode = FrmParent.Name,
                .DeptID = gh_Common.GroupID,
                .NoTransaksi = fs_Code,
                .LevelApproved = _Level,
                .ApprovedBy = gh_Common.Username,
                .IsActive = 0
                }
                If _Level = 2 Then
                    If _Status.ToLower = "completed" Then
                        Throw New Exception("DRR sudah di approve, hanya bisa di reject oleh level paling atas !")
                    End If
                End If
                _service.Reject(ObjApprove, _Level)
                FrmParent.tsBtn_refresh.PerformClick()

                IsClosed = True
                ShowMessage(GetMessage(MessageEnum.RejectBerhasil), MessageTypeEnum.NormalMessage)
                Hide()

            End If

        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
    Public Overrides Function ValidateSave() As Boolean
        Dim lb_Validated As Boolean = False
        Try

            If _Level = 1 Then
                If _Status.ToLower <> "created" OrElse _Status <> "submited" Then
                    If _Status.ToLower = "checked" Then
                        Throw New Exception("DRR sudah di cek gak bisa di ubah !")
                    ElseIf _Status.ToLower = "completed" Then
                        Throw New Exception("DRR sudah di approve/complete gak bisa di ubah !")
                    End If
                End If
            ElseIf _Level = 2 Then
                If _Status.ToLower = "completed" Then
                    Throw New Exception("DRR sudah di approve/complete gak bisa di ubah !")
                End If
            End If

            If DxValidationProvider1.Validate Then
                lb_Validated = True
            Else
                Err.Raise(ErrNumber, , "Data yang anda input tidak valid, lengkapi data !")
            End If

            If lb_Validated Then
                ObjHeader = New DRRModel With {
                    .IdDRR = CInt(fs_Code),
                    .No_NPP = TxtNoNpp.EditValue,
                    .Customer = TxtCustomer.Text,
                    .Project = TxtProject.Text,
                    .ForecastOrder = TxtForecast.Text,
                    .DueDateMaspro = TxtMaspro.EditValue,
                    .Tanggal = TxtDate.EditValue,
                    .Time = TimeSpan.Parse(TxtTime.Text),
                    .NoDokumen = TxtNoDokumen.Text
                    }
                Dim _File As String = String.Empty
                Dim _Index As Integer = -1
                'For i As Integer = -1 To GalleryControl1.Gallery.Groups(0).Items.Count - 1

                'Next
                For Each item As GalleryItem In GalleryControl1.Gallery.Groups(0).Items
                    _File = Replace(TxtNoNpp.Text, "/", " ") & "_" & Replace(Replace(item.Caption, ".png", ""), "_", " ") & ".png"
                    With ObjHeader
                        If _Index = -1 Then
                            .Gambar1 = _File & "," & CStr(_Index)
                        ElseIf _Index = 0 Then
                            .Gambar2 = _File & "," & CStr(_Index)
                        ElseIf _Index = 1 Then
                            .Gambar3 = _File & "," & CStr(_Index)
                        ElseIf _Index = 2 Then
                            .Gambar4 = _File & "," & CStr(_Index)
                        ElseIf _Index = 3 Then
                            .Gambar5 = _File & "," & CStr(_Index)
                        End If
                    End With
                    _Index += 1
                Next item
            End If
        Catch ex As Exception
            lb_Validated = False
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
        Return lb_Validated
    End Function

    Public Overrides Sub Proc_SaveData()
        Try
            _service = New DRRService
            _service.DetailModel.Clear()
            For i As Integer = 0 To BandedGridView1.RowCount - 2
                If Not String.IsNullOrEmpty(BandedGridView1.GetRowCellValue(i, "Seq").ToString()) Then
                    Dim ObjDetails As New DRRDetail
                    With ObjDetails
                        .Npp_Seq = Integer.Parse(BandedGridView1.GetRowCellValue(i, "Seq").ToString())
                        .Level = Integer.Parse(BandedGridView1.GetRowCellValue(i, "Level").ToString().TrimEnd)
                        .Part_Name = BandedGridView1.GetRowCellValue(i, "PartName").ToString()
                        .Part_No = BandedGridView1.GetRowCellValue(i, "PartNo").ToString()
                        .Proses = BandedGridView1.GetRowCellValue(i, "Proses").ToString()
                        .Qty = Integer.Parse(BandedGridView1.GetRowCellValue(i, "Qty").ToString())
                        .Cavity = BandedGridView1.GetRowCellValue(i, "Cavity").ToString()
                        .Tonage = BandedGridView1.GetRowCellValue(i, "Tonage").ToString()
                        .Material = BandedGridView1.GetRowCellValue(i, "Material").ToString().TrimEnd
                        .Part = Double.Parse(BandedGridView1.GetRowCellValue(i, "Part").ToString())
                        .Runner = Double.Parse(BandedGridView1.GetRowCellValue(i, "Runner").ToString())
                        .Loong = Double.Parse(BandedGridView1.GetRowCellValue(i, "Long").ToString())
                        .Width = Double.Parse(BandedGridView1.GetRowCellValue(i, "Width").ToString())
                        .Height = Double.Parse(BandedGridView1.GetRowCellValue(i, "Height").ToString())
                        .SurfaceTreatment = BandedGridView1.GetRowCellValue(i, "SurfaceTreatment").ToString().TrimEnd
                        .CT = Double.Parse(BandedGridView1.GetRowCellValue(i, "C/T").ToString())
                        .Thickn = Double.Parse(BandedGridView1.GetRowCellValue(i, "Thickn").ToString())
                        .Reference = BandedGridView1.GetRowCellValue(i, "Reference").ToString().TrimEnd
                        .Remark = BandedGridView1.GetRowCellValue(i, "Remark").ToString().TrimEnd
                    End With
                    _service.DetailModel.Add(ObjDetails)
                End If
            Next
            If GalleryControl1.Gallery.Groups(0).Items.Count = 0 Then
                Throw New Exception("Belum ada Sketch DRR !")
            End If
            If _service.DetailModel.Count = 0 Then
                Throw New Exception("Silahkan isi detail DRR !")
            End If

            If Not isUpdate Then
                _service.Insert(ObjHeader, FrmParent)
                SaveDeleteImage()
                'GridDtl.DataSource = _service.GetAll()
                FrmParent.tsBtn_refresh.PerformClick()
                IsClosed = True
                ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)

                Hide()
            Else
                _service.Update(ObjHeader)
                SaveDeleteImage()

                'GridDtl.DataSource = _service.GetAll()
                FrmParent.tsBtn_refresh.PerformClick()
                IsClosed = True
                ShowMessage(GetMessage(MessageEnum.UpdateBerhasil), MessageTypeEnum.NormalMessage)

                Hide()
            End If
        Catch ex As Exception
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub SaveDeleteImage()
        Try
            Dim files As String()
            Dim _File As String = String.Empty
            If Not Directory.Exists(_path) Then
                Directory.CreateDirectory(_path)
            End If
            files = Directory.GetFiles(_path, "*.png")
            For Each item As GalleryItem In GalleryControl1.Gallery.Groups(0).Items
                _File = Path.Combine(_path, Replace(TxtNoNpp.Text, "/", " ") & "_" & Replace(Replace(item.Caption, ".png", ""), "_", " ") & ".png")
                If Not File.Exists(_File) Then
                    item.Image.Save(_File, Imaging.ImageFormat.Png)
                    'File.Delete(_File)
                End If
            Next item

            If ImgToDelete IsNot Nothing Then
                For Each imgTodeleted In ImgToDelete
                    Dim _fileToDelete As String = String.Empty
                    _fileToDelete = Path.Combine(_path, imgTodeleted.ImageTitle & ".png")
                    If File.Exists(_fileToDelete) Then
                        File.Delete(_fileToDelete)
                    End If
                Next
            End If
            If ImgList IsNot Nothing Then
                For Each ImgFile In ImgList
                    _File = Path.Combine(_path, Replace(Replace(ImgFile.ImageTitle, ".png", ""), "_", " ") & ".png")

                    If Not File.Exists(_File) Then
                        ImgFile.Img.Save(_File, Imaging.ImageFormat.Png)
                    End If

                Next
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Private Sub TxtNoNpp_EditValueChanged(sender As Object, e As EventArgs) Handles TxtNoNpp.EditValueChanged
    '    If Initializing Then
    '        Exit Sub
    '    End If
    '    TxtCustomer.EditValue = TxtNoNpp.GetColumnValue("Customer").ToString
    '    TxtProject.Text = TxtNoNpp.GetColumnValue("Model_Name").ToString
    '    TxtMaspro.EditValue = TxtNoNpp.GetColumnValue("MP")
    '    LoadDetail()
    '    SetEditColumnGrid()
    '    Initializing = False
    'End Sub

    Private Sub GalleryControl1_DragEnter(sender As Object, e As DragEventArgs) Handles GalleryControl1.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                e.Effect = DragDropEffects.Copy
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub frmDRR_details_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
            Else
                If e.KeyCode = Keys.Delete Then
                    Dim item As GalleryItem = GalleryControl1.Gallery.GetCheckedItem()
                    If item IsNot Nothing Then GalleryControl1.Gallery.Groups(0).Items.Remove(item)
                End If
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        Dim ignoreCancel As Boolean = False
        TxtNoNpp.DoValidate()
        TxtDate.DoValidate()
        TxtTime.DoValidate()
        TxtMaspro.DoValidate()

        If DxValidationProvider1.GetInvalidControls().Contains(TxtNoNpp) _
            OrElse DxValidationProvider1.GetInvalidControls().Contains(TxtDate) _
            OrElse DxValidationProvider1.GetInvalidControls().Contains(TxtMaspro) _
            OrElse DxValidationProvider1.GetInvalidControls().Contains(TxtTime) Then
            ignoreCancel = True
        Else
            ignoreCancel = True
        End If

        RemoveHandler CmbLevel.EditValueChanged, AddressOf OnEditValueChanged
        RemoveHandler LookPartName.EditValueChanged, AddressOf OnEditValueChanged
        RemoveHandler CmnProses.EditValueChanged, AddressOf OnEditValueChanged
        RemoveHandler TxtPartName.EditValueChanged, AddressOf OnEditValueChanged
        'RemoveHandler TxtCavity.EditValueChanged, AddressOf OnEditValueChanged
        'RemoveHandler TxtTonase.EditValueChanged, AddressOf OnEditValueChanged
        MyBase.OnFormClosing(e)
        e.Cancel = Not ignoreCancel

        dragDropHelper.DisableDragDrop()
        'GalleryControl1.Gallery.Groups.Clear()
        'GridDtl.DataSource = _service.GetAll()
    End Sub

    Private Sub frmDRR_details_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Initializing = False
    End Sub

    Private Sub BandedGridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles BandedGridView1.RowClick
        If e.RowHandle = 0 Then

        End If
    End Sub

    Private Sub BandedGridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles BandedGridView1.CustomRowCellEdit
        Dim view As BandedGridView = CType(sender, BandedGridView)

        Select Case e.Column.FieldName
            Case "PartName"
                If e.RowHandle = 0 Then
                    e.RepositoryItem = BtnPartName
                Else
                    e.RepositoryItem = TxtPartName
                End If
        End Select
    End Sub

    Private Sub Grid_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles Grid.ProcessGridKey
        Try
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As GridView = TryCast(grid.FocusedView, GridView)
            If e.KeyData = Keys.Delete Then
                If view.FocusedRowHandle <> 0 Then
                    view.DeleteSelectedRows()
                    e.Handled = True
                End If
            End If

        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub SuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuToolStripMenuItem.Click
        Try
            If XtraMessageBox.Show("Release ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                _service = New DRRService
                _serviceGlobal = New GlobalService

                ObjApprove = New ApproveHistoryModel With {
                   .UserName = gh_Common.Username,
                   .MenuCode = FrmParent.Name,
                   .DeptID = gh_Common.GroupID,
                   .NoTransaksi = fs_Code,
                   .LevelApproved = _Level,
                   .ApprovedBy = gh_Common.Username,
                   .IsActive = 1
                }

                Dim _isRelease As Integer = _service.IsRelease(fs_Code)
                If _isRelease > 0 Then
                    Throw New Exception("DRR sudah di release !")
                End If
                _service.Release(fs_Code, 1)
                _serviceGlobal.Approve(ObjApprove, "Submited")
                FrmParent.tsBtn_refresh.PerformClick()
                IsClosed = True

                ShowMessage(GetMessage(MessageEnum.ReleaseBerhasil), MessageTypeEnum.NormalMessage)
                Hide()
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub


    Private Sub AttachImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachImageToolStripMenuItem.Click
        Try
            If TxtNoNpp.EditValue = "" Then
                Throw New Exception("No NPP tidak boleh kosong !")
            End If
            Dim f As New frmDRRAttach(TxtNoNpp.EditValue, _path, If(fs_Code = "0", True, False), images)
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
            ImgList = New List(Of ImageModel)
            ImgList = f.ImgList
            ImgToDelete = New List(Of ImageModel)
            ImgToDelete = f.ImagesToDelete
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub BandedGridView1_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles BandedGridView1.ValidatingEditor
        Try
            Dim view As BandedGridView = TryCast(sender, BandedGridView)
            'If view.FocusedColumn.FieldName.ToLower = "qty" Then
            '    Dim requiredDate? As Date = CType(e.Value, Date?)
            '    Dim orderDate? As Date = CType(view.GetRowCellValue(view.FocusedRowHandle, colOrderDate), Date?)
            '    If requiredDate < orderDate Then
            '        e.Valid = False
            '        e.ErrorText = "Required Date is earlier than the order date"
            '    End If
            'End If
            If view.FocusedColumn.ColumnType = GetType(Integer) OrElse view.FocusedColumn.ColumnType = GetType(Double) Then
                Dim ressult As Integer
                If Not Integer.TryParse(e.Value.ToString(), ressult) Then
                    e.Valid = False
                    e.ErrorText = "Input hanya angka !"
                    'Else
                    '    If Integer.Parse(e.Value.ToString()) <= 0 Then
                    '        e.Valid = False
                    '        e.ErrorText = Replace(view.FocusedColumn.Name, "col", "").ToUpper & " harus lebih besar dari 0(Nol) !"
                    '    End If
                End If
            End If

        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub TxtNoNpp_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtNoNpp.ButtonClick
        Try
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""
            _service = New DRRService
            dtSearch = _service.GetNPP()
            ls_OldKode = TxtNoNpp.Text

            ls_Judul = "NPP"


            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim _noNpp As String = ""
            Dim _model As String = ""
            Dim _customer As String = ""
            Dim _masPro As Date

            'Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As BandedGridView = TryCast(Grid.FocusedView, BandedGridView)
            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> "" Then
                _noNpp = lF_SearchData.Values.Item(0).ToString.Trim
                _model = lF_SearchData.Values.Item(1).ToString.Trim
                _customer = lF_SearchData.Values.Item(2).ToString.Trim
                _masPro = lF_SearchData.Values.Item(3)
                TxtNoNpp.EditValue = _noNpp
                TxtProject.Text = _model
                TxtCustomer.Text = _customer
                TxtMaspro.EditValue = _masPro
            End If
            TxtNoDokumen.Text = _service.GenerateDocNo(FrmParent, TxtProject.Text, TxtCustomer.Text)

            lF_SearchData.Close()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub BtnFunction_Click(sender As Object, e As EventArgs) Handles BtnFunction.Click

    End Sub
End Class
