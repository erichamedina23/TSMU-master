Imports System.Collections.ObjectModel
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraSplashScreen

Public Class frmDRR
    Dim ff_Detail As frmDRR_details
    Dim dtGrid As DataTable
    Dim _Service As DRRService
    Dim _ServiceGlobal As GlobalService
    Dim ObjHeader As DRRModel
    Dim ObjDetail As DRRDetail

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _Service = New DRRService

    End Sub

    Private Sub frmDRR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False

        Call Proc_EnableButtons(True, If(gh_Common.Level = "1", False, True), True, True, True, False, False, False, False, False, False, True)

    End Sub
    Private Sub SaveToExcel(_Grid As GridControl)
        Dim save As New SaveFileDialog
        save.Filter = "Excel File|*.xlsx"
        save.Title = "Save an Excel File"
        If save.ShowDialog = DialogResult.OK Then
            _Grid.ExportToXlsx(save.FileName)
        End If
    End Sub
    Private Sub LoadGrid()
        Try

            SplashScreenManager.ShowForm(GetType(FrmWait))
            _Service = New DRRService
            dtGrid = New DataTable
            dtGrid = _Service.GetData(Me, GetLevel)
            Grid.DataSource = dtGrid

            If GridView1.RowCount > 0 Then

                With GridView1
                    .BestFitColumns()
                    .Columns(0).Visible = False
                    '.FixedLineWidth = 2
                    '.Columns(1).Fixed = Columns.FixedStyle.Left
                    '.Columns(2).Fixed = Columns.FixedStyle.Left
                    '.Columns(3).Fixed = Columns.FixedStyle.Left
                End With
                GridCellFormat(GridView1)
            End If
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_InputNewData()
        CallFrm()
    End Sub
    Public Overrides Sub Proc_Refresh()
        bs_Filter = ""
        LoadGrid()
    End Sub
    Public Overrides Sub Proc_SaveData()
        Try
            Dim Id As Integer = 0
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    Id = GridView1.GetRowCellValue(rowHandle, "Id")
                End If
            Next rowHandle
            _Service = New DRRService
            Dim _isRelease As Boolean = _Service.IsRelease(Id)
            If Not _isRelease Then
                Throw New Exception("NPP '[ " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NoNPP") & " ]' & sudah di Unrelease, Pilih NPP yang lain !")
            End If
            _Service.Unrelease(Id)
            LoadGrid()
            ShowMessage(GetMessage(MessageEnum.ReleaseBerhasil), MessageTypeEnum.NormalMessage)
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
    Public Overrides Sub Proc_Search()
        Try
            Dim Status As List(Of String) = New List(Of String)({"ALL", "Created", "Submited", "Checked", "Completed"})

            Dim fSearch As New frmAdvanceSearch(Status)
            With fSearch
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
                Dim _Status As String = String.Empty
                Select Case .Status.ToLower
                    Case "all"
                        _Status = "ALL"
                    Case "created"
                        _Status = "0"
                    Case "submited"
                        _Status = "1"
                    Case "checked"
                        _Status = "2"
                    Case "completed"
                        _Status = "3"
                End Select
                Dim dt As New DataTable
                _Service = New DRRService
                dt = _Service.GetDataByDate(If(IsDBNull(.TglDari), Format(Date.Today, gs_FormatSQLDate), .TglDari), If(IsDBNull(.TglSampai), Format(Date.Today, gs_FormatSQLDate), .TglSampai), _Status, Me)
                Grid.DataSource = dt
                With GridView1
                    .BestFitColumns()
                    .Columns(0).Visible = False
                End With
                GridCellFormat(GridView1)
            End With
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Function GetLevel() As Integer
        Dim _level As Integer = 0
        Try
            _ServiceGlobal = New GlobalService
            _level = _ServiceGlobal.GetLevel(Me)
            Return _level
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
        Return _level
    End Function
    Private Sub CallFrm(Optional ByVal ls_Code As String = "0", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0, Optional ByVal Status As String = "Submited")
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New frmDRR_details(ls_Code, ls_Code2, Me, li_Row, Grid, GetLevel, Status)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub
    'Dim _path As String = "\\10.10.1.12\e$\DRR Sketch\"
    'Dim _path As String = "D:\TOOLS\Sketch\"
    Dim _path As String = "\\10.10.3.6\d$\TESTING\DRR Sktech\"
    Public Overrides Sub Proc_DeleteData()
        Try
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    ID = GridView1.GetRowCellValue(rowHandle, "Id")
                End If
            Next rowHandle
            _Service = New DRRService

            Dim _isRelease As Integer = _Service.IsRelease(ID)
            If _isRelease <> 0 OrElse _isRelease <> 1 Then
                Throw New Exception("DRR sudah di completed, tidak bisa di hapus !")
            End If
            'Hapus Gambar di Folder
            Dim ObjHeader As New DRRModel
            ObjHeader = _Service.GetById(ID)
            Dim images As New List(Of String)
            With ObjHeader
                images = New List(Of String)({ .Gambar1, .Gambar2, .Gambar3, .Gambar4, .Gambar5})
            End With
            For Each gambar In images
                Dim fileName = gambar.Split(","c)
                'Dim fileName = pathParts(pathParts.Count() - 1).Split("."c)
                'Dim _index = pathParts(pathParts.Count() - 1).Split(","c)
                If fileName(0).ToString = "" Then
                    Exit For
                End If
                Dim _File As String = String.Empty
                If Directory.Exists(_path) Then
                    _File = Path.Combine(_path, fileName(0))
                    If File.Exists(_File) Then
                        File.Delete(_File)
                    End If
                End If
            Next
            _Service.Delete(ID, Me)

            ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
            tsBtn_refresh.PerformClick()
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Dim NoNPP As String
    Dim Status As String
    Dim ID As String
    Private Sub frmDRR_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                NoNPP = String.Empty
                ID = "0"
                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        ID = GridView1.GetRowCellValue(rowHandle, "Id")
                        NoNPP = GridView1.GetRowCellValue(rowHandle, "NoNPP")
                        Status = GridView1.GetRowCellValue(rowHandle, "Status")
                    End If
                Next rowHandle

                If GridView1.GetSelectedRows.Length > 0 Then
                    'Dim objGrid As DataGridView = sender
                    Call CallFrm(ID,
                             NoNPP,
                             GridView1.RowCount, Status)
                End If
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick
        Try
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            'Dim view As GridView = TryCast(sender, GridView)
            Dim view As BaseView = Grid.GetViewAt(ea.Location)
            If view Is Nothing Then
                Return
            End If
            Dim baseHI As BaseHitInfo = view.CalcHitInfo(ea.Location)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then
                'Dim colCaption As String = If(info.Column Is Nothing, "N/A", info.Column.GetCaption())
                'MessageBox.Show(String.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption))

                ID = "0"
                NoNPP = String.Empty
                Status = String.Empty
                For Each rowHandle As Integer In GridView1.GetSelectedRows()
                    If rowHandle >= 0 Then
                        ID = GridView1.GetRowCellValue(rowHandle, "Id")
                        NoNPP = GridView1.GetRowCellValue(rowHandle, "NoNPP")
                        Status = GridView1.GetRowCellValue(rowHandle, "Status")
                    End If
                Next rowHandle

                If GridView1.GetSelectedRows.Length > 0 Then
                    'Dim objGrid As DataGridView = sender
                    Call CallFrm(ID,
                             NoNPP,
                             GridView1.RowCount, Status)
                End If
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub frmDRR_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadGrid()
    End Sub

    Private Sub GridView1_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        Dim view As GridView = sender
        If view Is Nothing Then
            Return
        End If
        If view.IsFilterRow(e.RowHandle) Then
            Return
        End If
        If e.Column.FieldName.ToLower = "status" Then
            If Convert.ToString(e.CellValue).ToLower = "completed" Then
                e.Appearance.BackColor = Color.GreenYellow
            Else
                e.Appearance.BackColor = Color.Salmon
            End If
        End If

    End Sub

    'Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle
    '    Dim view As GridView = TryCast(sender, GridView)
    '    If view.FocusedRowHandle >= 0 Then
    '        Dim _Status As String = view.GetRowCellDisplayText(e.RowHandle, "Status")

    '        If _Status.ToLower = "completed" Then

    '            e.Appearance.BackColor = Color.GreenYellow
    '            e.HighPriority = True
    '            'End If
    '        End If
    '    End If
    'End Sub
End Class
