Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class FrmTravelTicket
    Dim dtGrid As DataTable
    Dim fc_Class As New TravelTicketModel
    Dim ff_Detail As FrmTravelTicketDetail
    Dim ff_RequestDetail As FrmTravelRequestDetail

    Dim TabPage As String
    Dim dtTempStatus As New DataTable

    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New FrmTravelTicketDetail(ls_Code, ls_Code2, Me, li_Row, GridTicket)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub

    Private Sub CallFrmRequest(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_RequestDetail IsNot Nothing AndAlso ff_RequestDetail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_RequestDetail.Close()
        End If
        ff_RequestDetail = New FrmTravelRequestDetail(ls_Code, ls_Code2, Me, li_Row, GridRequest, 0)
        ff_RequestDetail.MdiParent = FrmMain
        ff_RequestDetail.StartPosition = FormStartPosition.CenterScreen
        ff_RequestDetail.Show()
    End Sub

    Private Sub FrmTravelTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False
        Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, False, False)
        XtraTabControl1.SelectedTabPage = TabPageRequest
        TabPage = XtraTabControl1.SelectedTabPage.Name
        Call LoadGridRequest()
        dtTempStatus.Columns.Add("NoRequest", GetType(String))
        dtTempStatus.Columns.Add("Status", GetType(String))
        dtTempStatus.Columns.Add("StatusTicket", GetType(String))
    End Sub

    Private Sub LoadGridRequest()
        Try
            dtTempStatus.Clear()
            dtGrid = fc_Class.GetTravelRequest()
            GridRequest.DataSource = dtGrid
            GridCellFormat(GridViewRequest)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub LoadGridTicket()
        Try
            dtGrid = fc_Class.GetTravelTicket()
            GridTicket.DataSource = dtGrid
            'GridCellFormat(GridViewTicket)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        If TabPage = "TabPageRequest" Then
            LoadGridRequest()
        Else
            LoadGridTicket()
        End If
    End Sub

    Public Overrides Sub Proc_InputNewData()
        CallFrm()
    End Sub

    Public Overrides Sub Proc_SaveData()
        Try
            If dtTempStatus.Rows.Count > 0 Then
                fc_Class.UpdateRequestStatusTicket(dtTempStatus)
                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                LoadGridRequest()
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_DeleteData()
        Dim NoVoucher As String = String.Empty
        Try
            Dim selectedRows() As Integer = GridViewTicket.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoVoucher = GridViewTicket.GetRowCellValue(rowHandle, "NoVoucher")
                End If

                fc_Class.NoVoucher = NoVoucher
                Dim dtCheckSettle As Boolean
                dtCheckSettle = fc_Class.CheckRequestSettle()
                If dtCheckSettle Then
                    Err.Raise(ErrNumber, , "No Voucher " & NoVoucher & " sudah proses settlement !")
                Else
                    fc_Class.DeleteData()
                    Call ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
                    tsBtn_refresh.PerformClick()
                End If
            Next rowHandle

        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Search()

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TabPage = XtraTabControl1.SelectedTabPage.Name()
        If TabPage = "TabPageRequest" Then
            Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, False, False)
            LoadGridRequest()
        Else
            Call Proc_EnableButtons(True, False, True, True, False, False, False, False, False, False, False, True)
            LoadGridTicket()
        End If
    End Sub

    Private Sub GridTicket_DoubleClick(sender As Object, e As EventArgs) Handles GridTicket.DoubleClick
        Try
            Dim NoVoucher = String.Empty
            Dim selectedRows() As Integer = GridViewTicket.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoVoucher = GridViewTicket.GetRowCellValue(rowHandle, "NoVoucher")
                End If
            Next rowHandle

            If GridViewTicket.GetSelectedRows.Length > 0 Then
                Call CallFrm(NoVoucher,
                         GridViewTicket.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub CStatus_EditValueChanged(sender As Object, e As EventArgs) Handles CStatusTicket.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
        Dim noRequest As String = GridViewRequest.GetRowCellValue(GridViewRequest.FocusedRowHandle, "NoRequest")
        Dim status As String = GridViewRequest.GetRowCellValue(GridViewRequest.FocusedRowHandle, "Status")
        Dim statusTicket As String = GridViewRequest.GetRowCellValue(GridViewRequest.FocusedRowHandle, "StatusTicket")
        If statusTicket = "CLOSE" Or statusTicket = "CANCEL" Then
            status = "CLOSE"
        End If
        For i As Integer = 0 To GridViewRequest.RowCount - 1
            If GridViewRequest.GetRowCellValue(i, "NoRequest") = noRequest Then
                GridViewRequest.SetRowCellValue(i, "StatusTicket", statusTicket)
            End If
        Next

        Dim myRow() As Data.DataRow
        myRow = dtTempStatus.Select("NoRequest = " & QVal(noRequest) & "")
        If myRow.Count > 0 Then
            myRow(0)("StatusTicket") = statusTicket
        Else
            dtTempStatus.Rows.Add(noRequest, status, statusTicket)
        End If
    End Sub

    Private Sub GridRequest_DoubleClick(sender As Object, e As EventArgs) Handles GridRequest.DoubleClick
        Try
            Dim NoRequest = String.Empty
            Dim selectedRows() As Integer = GridViewRequest.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoRequest = GridViewRequest.GetRowCellValue(rowHandle, "NoRequest")
                End If
            Next rowHandle

            If GridViewRequest.GetSelectedRows.Length > 0 Then
                Call CallFrmRequest(NoRequest,
                         GridViewRequest.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

End Class
