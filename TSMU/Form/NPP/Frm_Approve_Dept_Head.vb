Imports System.Globalization

Public Class Frm_Approve_Dept_Head

    Dim ff_Detail As Frm_NPP_Detail
    Dim dtGrid As DataTable
    Dim DtDelete As DataTable
    Dim fc_Class As New Cls_NPP_Header

    Dim Active_Form As Integer = 0

    Private Sub Frm_Approve_Dept_Head_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtUser As New DataTable
        dtUser = fc_Class.GetDataUSer(gh_Common.Username, Me.Name)
        Active_Form = dtUser.Rows(0).Item("levelApprove")

        dtGrid = New DataTable
        dtGrid.Columns.AddRange(New DataColumn(7) {New DataColumn("NPP", GetType(String)),
                                                            New DataColumn("Issue Date", GetType(String)),
                                                            New DataColumn("Model", GetType(String)),
                                                            New DataColumn("Customer", GetType(String)),
                                                            New DataColumn("Status", GetType(String)),
                                                            New DataColumn("Order Of Month", GetType(String)),
                                                            New DataColumn("Approve", GetType(Boolean)),
                                                            New DataColumn("Rev", GetType(Int32))})
        Grid.DataSource = dtGrid

        bb_SetDisplayChangeConfirmation = False
        NPP_Approve_LoadGrid()
        Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False)

    End Sub

    Public Sub NPP_Approve_LoadGrid()
        Try

            Dim dt As New DataTable
            Dim dt1 As New DataTable
            If Active_Form = 2 Then
                dt = fc_Class.Get_NPP_DeptHead()
                dt1 = fc_Class.Get_NPP_DeptHead2()
                Grid.DataSource = dt
                Grid1.DataSource = dt1
            ElseIf Active_Form = 3 Then
                dt = fc_Class.Get_NPP_DivHead()
                dt1 = fc_Class.Get_NPP_DivHead2()
                Grid.DataSource = dt
                Grid1.DataSource = dt1
            End If

            Cursor.Current = Cursors.WaitCursor

            'Call Proc_EnableButtons(True, False, True, True, True, False, False, False, False, False, False)
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try
    End Sub



    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New Frm_NPP_Detail(ls_Code, ls_Code2, Me, li_Row, Grid, Active_Form, Me.Name)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub

    Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick
        Try
            Dim provider As CultureInfo = CultureInfo.InvariantCulture
            Dim NoNpwo As String = ""
            'fc_ClassCRUD = New ClsCR_CreateUser
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoNpwo = GridView1.GetRowCellValue(rowHandle, "NPP")
                End If
            Next rowHandle

            If GridView1.GetSelectedRows.Length > 0 Then
                Call CallFrm(NoNpwo, "",
                            GridView1.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
        Try
            Dim provider As CultureInfo = CultureInfo.InvariantCulture
            Dim NoNpwo As String = ""
            'fc_ClassCRUD = New ClsCR_CreateUser
            Dim selectedRows() As Integer = GridView2.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoNpwo = GridView2.GetRowCellValue(rowHandle, "NPP")
                End If
            Next rowHandle

            If GridView2.GetSelectedRows.Length > 0 Then
                Call CallFrm(NoNpwo, "",
                            GridView2.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        bs_Filter = ""
        Call NPP_Approve_LoadGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
