Public Class FrmTravelCreditCard
    Dim ff_Detail As FrmTravelCreditCardDetail
    Dim dtGrid As DataTable
    Dim fc_Class As New TravelCreditCardModel

    Private Sub GridCreditCard_Load(sender As Object, e As EventArgs) Handles GridCreditCard.Load
        bb_SetDisplayChangeConfirmation = False
        Call LoadGrid()
        Call Proc_EnableButtons(True, False, True, True, True, False, False, False)
    End Sub

    Private Sub LoadGrid()
        Try
            dtGrid = fc_Class.GetAllDataTable(bs_Filter)
            GridCreditCard.DataSource = dtGrid
            GridCellFormat(GridViewCreditCard)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

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
        ff_Detail = New FrmTravelCreditCardDetail(ls_Code, ls_Code2, Me, li_Row, GridCreditCard)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub

    Public Overrides Sub Proc_Refresh()
        LoadGrid()
    End Sub

    Public Overrides Sub Proc_DeleteData()
        Dim CreditCardID As String = String.Empty

        Try
            Dim selectedRows() As Integer = GridViewCreditCard.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    CreditCardID = GridViewCreditCard.GetRowCellValue(rowHandle, "CreditCardID")
                End If
            Next rowHandle

            fc_Class.CreditCardID = CreditCardID
            fc_Class.DeleteData()

            tsBtn_refresh.PerformClick()
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub GridCreditCard_DoubleClick(sender As Object, e As EventArgs) Handles GridCreditCard.DoubleClick
        Try
            Dim CreditCardID As String = String.Empty

            Dim selectedRows() As Integer = GridViewCreditCard.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    CreditCardID = GridViewCreditCard.GetRowCellValue(rowHandle, "CreditCardID")
                End If
            Next rowHandle

            If GridViewCreditCard.GetSelectedRows.Length > 0 Then
                'Dim objGrid As DataGridView = sender
                Call CallFrm(CreditCardID,
                         GridViewCreditCard.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

End Class
