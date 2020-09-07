Imports System.Collections.ObjectModel
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraSplashScreen
Public Class frmM_Approval
    Dim FrmDetail As frmM_ApprovalDetail
    Dim dtGrid As DataTable
    Dim _Service As MApproveService
    Dim ObjHeader As MApproveModel
    Private Sub frmM_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False
        Call Proc_EnableButtons(True, False, True, True, True, False, False, False, False, False, False, False)
        'LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Try
            SplashScreenManager.ShowForm(GetType(FrmWait))
            _Service = New MApproveService
            dtGrid = New DataTable
            dtGrid = _Service.GetAll()
            Grid.DataSource = dtGrid

            If GridView1.RowCount > 0 Then

                With GridView1
                    .BestFitColumns()
                    .Columns(0).Visible = False
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
        LoadGrid()
    End Sub

    Private Sub CallFrm(Optional ByVal ls_Code As String = "0", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If FrmDetail IsNot Nothing AndAlso FrmDetail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            FrmDetail.Close()
        End If
        FrmDetail = New frmM_ApprovalDetail(ls_Code, ls_Code2, Me, li_Row, Grid)
        FrmDetail.MdiParent = FrmMain
        FrmDetail.StartPosition = FormStartPosition.CenterScreen
        FrmDetail.Show()
    End Sub
    Public Overrides Sub Proc_DeleteData()
        Try
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    ID = GridView1.GetRowCellValue(rowHandle, "Id")
                End If
            Next rowHandle
            _Service = New MApproveService
            _Service.DeleteHeader(ID)

            ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
            tsBtn_refresh.PerformClick()
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Dim UserName As String
    Dim ID As String
    Private Sub frmDRR_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                UserName = String.Empty
                ID = "0"
                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        ID = GridView1.GetRowCellValue(rowHandle, "Id")
                        UserName = GridView1.GetRowCellValue(rowHandle, "UserName")
                    End If
                Next rowHandle

                If GridView1.GetSelectedRows.Length > 0 Then
                    'Dim objGrid As DataGridView = sender
                    Call CallFrm(ID,
                             UserName,
                             GridView1.RowCount)
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
                UserName = String.Empty
                For Each rowHandle As Integer In GridView1.GetSelectedRows()
                    If rowHandle >= 0 Then
                        ID = GridView1.GetRowCellValue(rowHandle, "Id")
                        UserName = GridView1.GetRowCellValue(rowHandle, "UserName")
                    End If
                Next rowHandle

                If GridView1.GetSelectedRows.Length > 0 Then
                    'Dim objGrid As DataGridView = sender
                    Call CallFrm(ID,
                             UserName,
                             GridView1.RowCount)
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
End Class
