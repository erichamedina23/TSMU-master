Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmTravelSettle
    Dim ff_Detail As FrmTravelSettleDetail
    Dim ff_Detail1 As FrmSuspendSettleDetailDirect
    Dim cls_SettHeader As TravelSettleHeaderModel
    Dim cls_SettDetail As New TravelSettleDetailModel
    Dim cls_SettCost As New TravelSettleCostModel

    Dim dtGrid As DataTable
    Dim TabPage As String

    Private Sub FrmTravelSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False
        XtraTabControl1.SelectedTabPage = TabPageReq
        TabPage = XtraTabControl1.SelectedTabPage.Name
    End Sub

    Private Sub LoadGridRequest()
        Try
            cls_SettHeader = New TravelSettleHeaderModel
            dtGrid = cls_SettHeader.GetDataGridRequest()
            GridRequest.DataSource = dtGrid
            'GridCellFormat(GridViewRequest)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub LoadGridSettle()
        Try
            cls_SettHeader = New TravelSettleHeaderModel
            dtGrid = cls_SettHeader.GetTravelSettHeader()
            GridSettle.DataSource = dtGrid
            GridCellFormat(GridViewSettle)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    'Public Overrides Sub Proc_InputNewData()
    '    If TabPage = "TabPageReq" Then
    '        If GridViewRequest.SelectedRowsCount > 0 Then
    '            CallFrm()
    '        Else
    '            MessageBox.Show("Harap pilih dulu travelnya", "Warning",
    '                                MessageBoxButtons.OK,
    '                                MessageBoxIcon.Exclamation,
    '                                MessageBoxDefaultButton.Button1)
    '        End If
    '    End If

    'End Sub

    Public Overrides Sub Proc_Refresh()
        bs_Filter = ""
        If TabPage = "TabPageReq" Then
            LoadGridRequest()
        ElseIf TabPage = "TabPageSett" Then
            LoadGridSettle()
        End If
    End Sub

    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New FrmTravelSettleDetail(ls_Code, ls_Code2, Me, li_Row, GridViewRequest, GridRequest)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub

    Public Overrides Sub Proc_DeleteData()
        Try
            Dim TravelSettleID As String = String.Empty
            Dim selectedRows() As Integer = GridViewSettle.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    TravelSettleID = GridViewSettle.GetRowCellValue(rowHandle, "TravelSettleID").ToString()
                    cls_SettHeader.TravelSettleID = TravelSettleID
                End If

                cls_SettHeader.TravelSettleID = TravelSettleID
                If cls_SettHeader.CheckSettleAccrued Then
                    Err.Raise(ErrNumber, , "No Settlement " & TravelSettleID & " sudah dilakukan proses Accrued !")
                End If

                Dim dtSettleDetail As New DataTable
                cls_SettDetail.TravelSettleID = TravelSettleID
                dtSettleDetail = cls_SettDetail.GetTravelSettDetailByID

                cls_SettHeader.ObjSettleDetail.Clear()
                If dtSettleDetail.Rows.Count > 0 Then
                    For i As Integer = 0 To dtSettleDetail.Rows.Count - 1
                        cls_SettDetail = New TravelSettleDetailModel
                        With cls_SettDetail
                            .TravelSettleID = TravelSettleID
                            .NoRequest = dtSettleDetail.Rows(i).Item(0)
                            .Nama = dtSettleDetail.Rows(i).Item(1)
                        End With
                        cls_SettHeader.ObjSettleDetail.Add(cls_SettDetail)
                    Next
                End If

                Dim dtSettleCost As New DataTable
                cls_SettCost.TravelSettleID = TravelSettleID
                Dim filterRows As DataRow()
                filterRows = cls_SettCost.GetTravelSettleCostByID.Select("ID = 4")
                If filterRows.Count > 0 Then
                    dtSettleCost = filterRows.CopyToDataTable
                End If

                cls_SettHeader.ObjSettleCost.Clear()
                If dtSettleCost.Rows.Count > 0 Then
                    For i As Integer = 0 To dtSettleCost.Rows.Count - 1
                        cls_SettHeader.TravelSettleID = dtSettleCost.Rows(i).Item(5)
                        If cls_SettHeader.CheckSettleAccrued Then
                            Err.Raise(ErrNumber, , "No Entertain ID " & dtSettleCost.Rows(i).Item(5) & " sudah dilakukan proses Accrued !")
                        End If
                        cls_SettCost = New TravelSettleCostModel
                        With cls_SettCost
                            .EntertainID = dtSettleCost.Rows(i).Item(5)
                        End With
                        cls_SettHeader.ObjSettleCost.Add(cls_SettCost)
                    Next
                End If

                cls_SettHeader.DeleteDataTravelSettle()
                Call ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
                tsBtn_refresh.PerformClick()
            Next rowHandle

        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub GridSettle_DoubleClick(sender As Object, e As EventArgs) Handles GridSettle.DoubleClick
        Try
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As BaseView = GridSettle.GetViewAt(ea.Location)
            If view Is Nothing Then
                Return
            End If
            Dim baseHI As BaseHitInfo = view.CalcHitInfo(ea.Location)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then

                Dim TravelSettID As String = String.Empty
                Dim selectedRows() As Integer = GridViewSettle.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        TravelSettID = GridViewSettle.GetRowCellValue(rowHandle, "TravelSettleID")
                    End If
                Next rowHandle

                If GridViewSettle.GetSelectedRows.Length > 0 Then
                    'Dim objGrid As DataGridView = sender
                    Call CallFrm(TravelSettID,
                         GridViewSettle.RowCount)
                End If
            End If

        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TabPage = XtraTabControl1.SelectedTabPage.Name()
        If TabPage = "TabPageReq" Then
            Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False, False)
            LoadGridRequest()
        ElseIf TabPage = "TabPageSett" Then
            Call Proc_EnableButtons(False, False, True, True, False, False, False, False, False, False, False, True)
            LoadGridSettle()
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If GridViewRequest.SelectedRowsCount > 0 Then
            Dim result As DialogResult = XtraMessageBox.Show("Confirmation Travel ?", "Confirmation", MessageBoxButtons.YesNoCancel)
            If result = System.Windows.Forms.DialogResult.Yes Then
                CallFrm()
            ElseIf result = System.Windows.Forms.DialogResult.No Then
                Dim Refund As DialogResult = XtraMessageBox.Show("Ada Refund ?", "Confirmation", MessageBoxButtons.YesNoCancel)
                If Refund = System.Windows.Forms.DialogResult.Yes Then
                    MessageBox.Show("Kondisi settlement NO & refund tiket YES")
                Else
                    MessageBox.Show("Kondisi settlement NO & refund tiket NO")
                End If
                cls_SettHeader.ObjSettleDetail.Clear()
                For i As Integer = 0 To GridViewRequest.SelectedRowsCount() - 1
                    If (GridViewRequest.GetSelectedRows()(i) >= 0) Then
                        cls_SettDetail = New TravelSettleDetailModel
                        With cls_SettDetail
                            .NoRequest = GridViewRequest.GetRowCellValue(GridViewRequest.GetSelectedRows()(i), "NoRequest")
                        End With
                        cls_SettHeader.ObjSettleDetail.Add(cls_SettDetail)
                    End If
                Next
                cls_SettHeader.UpdateTravelSettleNoRefund()
                Call ShowMessage("Data Updated", MessageTypeEnum.NormalMessage)
                tsBtn_refresh.PerformClick()
            End If
        Else
            MessageBox.Show("Tidak ada request travel yang dipilih", "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
        End If
    End Sub

End Class
