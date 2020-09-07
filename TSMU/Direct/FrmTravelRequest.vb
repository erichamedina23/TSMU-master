Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmTravelRequest
    Dim ff_Detail As FrmTravelRequestDetail
    Dim dtGrid As DataTable
    Dim fc_Class As New TravelRequestModel
    Dim _ServiceGlobal As GlobalService
    Dim _level As Integer = 0

    Public Overrides Sub Proc_InputNewData()
        CallFrm()
    End Sub

    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If

        ff_Detail = New FrmTravelRequestDetail(ls_Code, ls_Code2, Me, li_Row, GridRequest, _level)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub

    Private Sub FrmTravelRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False
        levelApprove()
        aksesData()
    End Sub

    Private Sub levelApprove()
        Try
            _ServiceGlobal = New GlobalService
            _level = _ServiceGlobal.GetLevel(Me)
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub aksesData()
        If _level = 1 Then
            Call Proc_EnableButtons(True, False, True, True, False, False, False, False, False, False, False, True)
        ElseIf _level > 1 Then
            Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False, True)
        Else
            Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, False, False)
        End If
        LoadGridRequest()
    End Sub

    Private Sub LoadGridRequest()
        Try
            dtGrid = New DataTable
            dtGrid = fc_Class.GetTravelRequest(Me.Name, _level)
            GridRequest.DataSource = dtGrid
            GridViewRequest.BestFitColumns()
            GridCellFormat(GridViewRequest)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_DeleteData()
        Dim noRequest As String = String.Empty
        Dim status As String = String.Empty
        Dim approved As String = String.Empty
        Try
            Dim selectedRows() As Integer = GridViewRequest.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    noRequest = GridViewRequest.GetRowCellValue(rowHandle, "NoRequest")
                    status = GridViewRequest.GetRowCellValue(rowHandle, "Status")
                    approved = GridViewRequest.GetRowCellValue(rowHandle, "Approved")
                End If
            Next rowHandle

            If status = "OPEN" Then
                MessageBox.Show("No Request " & noRequest & " sudah dilakukan Invoice Ticket !", "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            ElseIf status = "CLOSE" AndAlso approved <> "CANCEL" Then
                MessageBox.Show("No Request " & noRequest & " sudah dilakukan proses Settlement !", "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1)
            Else
                Dim ObjApprove = New ApproveHistoryModel With {
                .MenuCode = Me.Name,
                .NoTransaksi = noRequest,
                .IsActive = 0
                }
                fc_Class.NoRequest = noRequest
                fc_Class.Delete(ObjApprove)
                Call ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
                tsBtn_refresh.PerformClick()
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        LoadGridRequest()
    End Sub

    Public Overrides Sub Proc_Search()
        Try
            Dim Status As List(Of String) = New List(Of String)({"ALL", "CREATE", "PROGRESS", "OPEN", "CLOSE"})
            Dim fSearch As New frmAdvanceSearch(Status)
            With fSearch
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()

                dtGrid = fc_Class.GetTravelRequestAll(Me.Name, If(IsDBNull(.TglDari), Format(Date.Today, gs_FormatSQLDate), .TglDari), If(IsDBNull(.TglSampai), Format(Date.Today, gs_FormatSQLDate), .TglSampai), .Status)
                GridRequest.DataSource = dtGrid
                GridViewRequest.BestFitColumns()
                GridCellFormat(GridViewRequest)
            End With
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub GridRequest_DoubleClick(sender As Object, e As EventArgs) Handles GridRequest.DoubleClick
        Try
            Dim NoRequest = String.Empty
            Dim status As String = String.Empty
            Dim selectedRows() As Integer = GridViewRequest.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoRequest = GridViewRequest.GetRowCellValue(rowHandle, "NoRequest")
                    status = GridViewRequest.GetRowCellValue(rowHandle, "Status")
                End If
            Next rowHandle

            If GridViewRequest.GetSelectedRows.Length > 0 Then
                Call CallFrm(NoRequest, status, GridViewRequest.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

End Class
