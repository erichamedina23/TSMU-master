Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmTravelerDetail
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim _Tag = New TagModel

    Dim fc_Class As New ClsTraveller
    Dim GridDtl As GridControl
    Dim ObjTravelerVisa As New ClsTravelerVisa
    Dim ObjTravelerPaspor As New ClsTravelerPaspor
    Dim dtGrid As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form,
                   ByVal li_GridRow As Integer,
                   ByRef _Grid As GridControl)
        ' this call is required by the windows form designer
        Me.New()
        If strCode <> "" Then
            fs_Code = strCode
            fs_Code2 = strCode2
            bi_GridParentRow = li_GridRow
        End If
        GridDtl = _Grid
        FrmParent = lf_FormParent
        _Tag = New TagModel
        _Tag.PageIndex = lf_FormParent.Tag.PageIndex
        Tag = _Tag
    End Sub

    Private Sub FrmTravelerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, False)
        Call InitialSetForm()
    End Sub

    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "" Then
                fc_Class.getDataByID(fs_Code)
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                Me.Text = "TRAVELER DETAIL"
            Else
                Me.Text = "NEW TRAVELER"
            End If
            Call LoadTxtBox()
            LoadGridDetail()
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = "FrmTraveler"
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub LoadTxtBox()
        Try
            Dim dt = New DataTable
            dt = fc_Class.GetListNegara()
            Dim itemsCollection As ComboBoxItemCollection = CNegara.Items
            itemsCollection.BeginUpdate()
            Try
                For Each r As DataRow In dt.Rows
                    itemsCollection.Add(r.Item(1))
                Next
            Finally
                itemsCollection.EndUpdate()
            End Try

            itemsCollection = CKodeNegara.Items
            itemsCollection.BeginUpdate()
            Try
                For Each r As DataRow In dt.Rows
                    itemsCollection.Add(r.Item(0))
                Next
            Finally
                itemsCollection.EndUpdate()
            End Try

            If fs_Code <> "" Then
                With fc_Class
                    TxtNIK.Text = .NIK
                    TxtNama.Text = .Nama
                    TxtDeptID.Text = .DeptID
                    txtGolongan.Text = .Golongan
                    TxtNIK.Enabled = False
                End With
            Else
                TxtNIK.Text = ""
                TxtNama.Text = ""
                TxtDeptID.Text = ""
                TxtNIK.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub LoadGridDetail()
        Try
            Dim dtGridVisa = New DataTable
            Dim dtGridPaspor = New DataTable
            ObjTravelerVisa.NIK = TxtNIK.Text
            dtGridVisa = ObjTravelerVisa.GetTravelerVisa()
                GridVisa.DataSource = dtGridVisa

                ObjTravelerPaspor.NIK = TxtNIK.Text
                dtGridPaspor = ObjTravelerPaspor.GetTravelerPaspor()
                GridPaspor.DataSource = dtGridPaspor
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        Call LoadTxtBox()
    End Sub

    Public Overrides Function ValidateSave() As Boolean
        Dim lb_Validated As Boolean = False
        Try
            Dim success As Boolean = True

            If DxValidationProvider1.Validate Then
                lb_Validated = True
            Else
                Err.Raise(ErrNumber, , "Data yang anda input tidak valid, silahkan cek inputan anda !")
            End If

            If TxtNIK.Text = "" OrElse TxtNama.Text = "" OrElse txtGolongan.Text = "" Then
                Err.Raise(ErrNumber, , GetMessage(MessageEnum.PropertyKosong))
            End If

            fc_Class.ObjVisa.Clear()
            For i As Integer = 0 To GridViewVisa.RowCount - 1
                ObjTravelerVisa = New ClsTravelerVisa
                With ObjTravelerVisa
                    .NIK = TxtNIK.Text
                    If String.IsNullOrEmpty(IIf(GridViewVisa.GetRowCellValue(i, "NoVisa") Is DBNull.Value, "", GridViewVisa.GetRowCellValue(i, "NoVisa"))) Then
                        Err.Raise(ErrNumber, , "No Visa tidak boleh kosong !")
                    End If
                    .NoVisa = If(IsDBNull(GridViewVisa.GetRowCellValue(i, "NoVisa")), Nothing, GridViewVisa.GetRowCellValue(i, "NoVisa"))
                    If String.IsNullOrEmpty(IIf(GridViewVisa.GetRowCellValue(i, "Negara") Is DBNull.Value, "", GridViewVisa.GetRowCellValue(i, "Negara"))) Then
                        Err.Raise(ErrNumber, , "Negara Visa tidak boleh kosong !")
                    End If
                    .Negara = If(IsDBNull(GridViewVisa.GetRowCellValue(i, "Negara")), Nothing, GridViewVisa.GetRowCellValue(i, "Negara"))
                    .Category = If(IsDBNull(GridViewVisa.GetRowCellValue(i, "Entries")), Nothing, GridViewVisa.GetRowCellValue(i, "Entries"))
                    .DateIssued = If(IsDBNull(GridViewVisa.GetRowCellValue(i, "DateIssued")), Nothing, GridViewVisa.GetRowCellValue(i, "DateIssued"))
                    If String.IsNullOrEmpty(IIf(GridViewVisa.GetRowCellValue(i, "DateExpired") Is DBNull.Value, "", GridViewVisa.GetRowCellValue(i, "DateExpired"))) Then
                        Err.Raise(ErrNumber, , "Expired Date tidak boleh kosong !")
                    End If
                    .DateExpired = If(IsDBNull(GridViewVisa.GetRowCellValue(i, "DateExpired")), Nothing, GridViewVisa.GetRowCellValue(i, "DateExpired"))
                End With
                fc_Class.ObjVisa.Add(ObjTravelerVisa)
            Next

            fc_Class.ObjPaspor.Clear()
            For i As Integer = 0 To GridViewPaspor.RowCount - 1
                ObjTravelerPaspor = New ClsTravelerPaspor
                With ObjTravelerPaspor
                    .NIK = TxtNIK.Text
                    If String.IsNullOrEmpty(IIf(GridViewPaspor.GetRowCellValue(i, "NoPaspor") Is DBNull.Value, "", GridViewPaspor.GetRowCellValue(i, "NoPaspor"))) Then
                        Err.Raise(ErrNumber, , "No Paspor tidak boleh kosong !")
                    End If
                    .NoPaspor = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "NoPaspor")), Nothing, GridViewPaspor.GetRowCellValue(i, "NoPaspor"))
                    .Nama = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "Nama")), Nothing, GridViewPaspor.GetRowCellValue(i, "Nama").ToString.ToUpper)
                    .KodeNegara = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "KodeNegara")), "", GridViewPaspor.GetRowCellValue(i, "KodeNegara"))
                    .TanggalLahir = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "TanggalLahir")), Nothing, GridViewPaspor.GetRowCellValue(i, "TanggalLahir"))
                    .JenisKelamin = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "JenisKelamin")), "", GridViewPaspor.GetRowCellValue(i, "JenisKelamin"))
                    .TanggalKeluar = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "TanggalKeluar")), Nothing, GridViewPaspor.GetRowCellValue(i, "TanggalKeluar"))
                    If String.IsNullOrEmpty(IIf(GridViewPaspor.GetRowCellValue(i, "ExpiredDate") Is DBNull.Value, "", GridViewPaspor.GetRowCellValue(i, "ExpiredDate"))) Then
                        Err.Raise(ErrNumber, , "Expired Date tidak boleh kosong !")
                    End If
                    .ExpiredDate = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "ExpiredDate")), Nothing, GridViewPaspor.GetRowCellValue(i, "ExpiredDate"))
                    .TempatKeluar = If(IsDBNull(GridViewPaspor.GetRowCellValue(i, "TempatKeluar")), "", GridViewPaspor.GetRowCellValue(i, "TempatKeluar").ToString.ToUpper)
                End With
                fc_Class.ObjPaspor.Add(ObjTravelerPaspor)
            Next

            If lb_Validated Then
                With fc_Class
                    .NIK = TxtNIK.Text.Trim.ToUpper
                    .Nama = TxtNama.Text.Trim.ToUpper
                    .DeptID = TxtDeptID.Text.Trim.ToUpper
                    .Golongan = txtGolongan.Text
                    If isUpdate = False Then
                        .ValidateInsert()
                    End If
                End With

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
            If isUpdate = False Then
                fc_Class.Insert()
            Else
                fc_Class.NIK = fs_Code
                fc_Class.Update()
            End If

            GridDtl.DataSource = fc_Class.GetAllDataTable(bs_Filter)
            IsClosed = True
            Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            Me.Hide()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        Dim ignoreCancel As Boolean = False
        TxtNIK.DoValidate()
        TxtNama.DoValidate()

        If DxValidationProvider1.GetInvalidControls().Contains(TxtNIK) _
            OrElse DxValidationProvider1.GetInvalidControls().Contains(TxtNama) Then
            ignoreCancel = True
        Else
            ignoreCancel = True
        End If

        MyBase.OnFormClosing(e)
        e.Cancel = Not ignoreCancel
    End Sub

    Private Sub TxtDeptID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtDeptID.ButtonClick
        Try
            fc_Class = New ClsTraveller
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""

            dtSearch = fc_Class.GetDept
            ls_OldKode = TxtDeptID.Text
            ls_Judul = "Departement"


            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select Data " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim Value1 As String = ""
            Dim Value2 As String = ""

            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then
                Value1 = lF_SearchData.Values.Item(0).ToString.Trim
                Value2 = lF_SearchData.Values.Item(1).ToString.Trim
                TxtDeptID.Text = Value1
            End If
            lF_SearchData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub GridViewPaspor_KeyDown(sender As Object, e As KeyEventArgs) Handles GridViewPaspor.KeyDown
        If e.KeyData = Keys.Delete Then
            GridViewPaspor.DeleteRow(GridViewPaspor.FocusedRowHandle)
            GridViewPaspor.RefreshData()
        End If
        If e.KeyData = Keys.Insert Then
            GridViewPaspor.AddNewRow()
        End If
    End Sub

    Private Sub GridViewVisa_KeyDown(sender As Object, e As KeyEventArgs) Handles GridViewVisa.KeyDown
        If e.KeyData = Keys.Delete Then
            GridViewVisa.DeleteRow(GridViewVisa.FocusedRowHandle)
            GridViewVisa.RefreshData()
        End If
        If e.KeyData = Keys.Insert Then
            GridViewVisa.AddNewRow()
        End If
    End Sub

    Private Sub CNoVisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CNoVisa.KeyPress
        'Dim tombol As Integer

        'tombol = Asc(e.KeyChar)

        'If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 13)) Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub GridViewPaspor_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridViewPaspor.CellValueChanged
        GridPaspor.Refresh()
        GridViewPaspor.RefreshData()
        GridViewPaspor.RefreshEditor(True)
    End Sub

    Private Sub CExpiredDatePaspor_EditValueChanged(sender As Object, e As EventArgs) Handles CExpiredDatePaspor.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CTempatKeluar_EditValueChanged(sender As Object, e As EventArgs) Handles CTempatKeluar.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CDateExpired_EditValueChanged(sender As Object, e As EventArgs) Handles CDateExpired.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CJenisKelamin_EditValueChanged(sender As Object, e As EventArgs) Handles CJenisKelamin.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CKodeNegara_EditValueChanged(sender As Object, e As EventArgs) Handles CKodeNegara.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub TanggalKeluarPaspor_EditValueChanged(sender As Object, e As EventArgs) Handles TanggalKeluarPaspor.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CTanggalLahirPaspor_EditValueChanged(sender As Object, e As EventArgs) Handles CTanggalLahirPaspor.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CNegara_EditValueChanged(sender As Object, e As EventArgs) Handles CNegara.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CNoVisa_EditValueChanged(sender As Object, e As EventArgs) Handles CNoVisa.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CEntries_EditValueChanged(sender As Object, e As EventArgs) Handles CEntries.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CDateIssued_EditValueChanged(sender As Object, e As EventArgs) Handles CDateIssued.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub txtGolongan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGolongan.KeyPress
        'Dim tombol As Integer

        'tombol = Asc(e.KeyChar)

        'If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 13)) Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub btnPaspor_Click(sender As Object, e As EventArgs) Handles btnPaspor.Click
        GridViewPaspor.AddNewRow()
        GridViewPaspor.OptionsNavigation.AutoFocusNewRow = True
        GridViewPaspor.SetRowCellValue(GridViewPaspor.FocusedRowHandle, "Nama", TxtNama.Text)
    End Sub

    Private Sub btnVisa_Click(sender As Object, e As EventArgs) Handles btnVisa.Click
        GridViewVisa.AddNewRow()
        GridViewVisa.OptionsNavigation.AutoFocusNewRow = True
    End Sub

End Class
