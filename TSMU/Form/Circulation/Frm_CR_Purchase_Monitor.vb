Imports System.Globalization

Public Class Frm_CR_Purchase_Monitor
    Dim ff_Detail As Frm_CR_UserCreateDetail
    Dim dtGrid As DataTable
    Dim fc_Class As New clsCR_Accounting
    Dim IdTrans As String
    Dim Dept As String
    Dim DeptHeadID As String
    Dim Tanggal As Date
    Dim Active_Form As Integer = 7

    Private Sub Frm_CR_Purchase_Monitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim d As DateTime = Date.Today
        Dim TA As DateTime = d.AddDays(-d.Day)
        Dim TangalAwal As DateTime = TA.AddDays(-(TA.Day - 1))
        'Stop
        Dim TangalAkhir As DateTime = Date.Now
        'Stop


        bb_SetDisplayChangeConfirmation = False
        Dept = gh_Common.GroupID
        DeptHeadID = gh_Common.Username
        LoadGrid(TangalAwal, TangalAkhir)
        Dim dtGrid As New DataTable
        Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False, True)
        'Call Grid_Properties()
    End Sub
    Public Overrides Sub Proc_Search()
        Try
            Dim fSearch As New frmSearch
            With fSearch
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()

                Dim dt As New DataTable
                '               Call LoadGrid(If(IsDBNull(.TglDari), Date.Today, .TglDari), If(IsDBNull(.TglSampai), Date.Today, .TglSampai))
                Call LoadGrid(.TglDari, .TglSampai)

                'fc_Class = New clsCR_Accounting
                'dt = _Service.GetDataByDate(If(IsDBNull(.TglDari), Date.Today, .TglDari), If(IsDBNull(.TglSampai), Date.Today, .TglSampai))
                'Grid.DataSource = dt
            End With
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Public Sub LoadGrid(pAwal As Date, pAkhir As Date)
        Try
            Cursor.Current = Cursors.WaitCursor

            Dim dt As New DataTable
            dt = fc_Class.Get_Purchase_Monitor_Proses(pAwal, pAkhir)
            Grid.DataSource = dt

            Dim dt2 As New DataTable
            dt2 = fc_Class.Get_Purchase_Monitor_Approve(pAwal, pAkhir)
            Grid2.DataSource = dt2

            Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False, True)

            ' Call Proc_EnableButtons(False, False, False, True, True, False, False, False)
            'Cursor.Current = Cursors.Default
        Catch ex As Exception
            ' Cursor.Current = Cursors.Default
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick
        Try
            Dim provider As CultureInfo = CultureInfo.InvariantCulture
            IdTrans = String.Empty

            'fc_ClassCRUD = New ClsCR_CreateUser
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    IdTrans = GridView1.GetRowCellValue(rowHandle, "Circulation")
                End If
            Next rowHandle

            If GridView1.GetSelectedRows.Length > 0 Then
                Call CallFrm(IdTrans,
                            Format(Tanggal, gs_FormatSQLDate),
                            GridView1.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub

    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)

        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New Frm_CR_UserCreateDetail(ls_Code, ls_Code2, Me, li_Row, Grid, Active_Form)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()

    End Sub

    Private Sub Grid2_DoubleClick(sender As Object, e As EventArgs) Handles Grid2.DoubleClick

        Try
            Dim provider As CultureInfo = CultureInfo.InvariantCulture
            IdTrans = String.Empty

            'fc_ClassCRUD = New ClsCR_CreateUser
            Dim selectedRows() As Integer = GridView2.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    IdTrans = GridView2.GetRowCellValue(rowHandle, "Circulation")
                End If
            Next rowHandle

            If GridView2.GetSelectedRows.Length > 0 Then
                Call CallFrm(IdTrans,
                            Format(Tanggal, gs_FormatSQLDate),
                            GridView2.RowCount)
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub

    Public Overrides Sub Proc_Refresh()
        Dim d As DateTime = Date.Today
        Dim TA As DateTime = d.AddDays(-d.Day)
        Dim TangalAwal As DateTime = TA.AddDays(-(TA.Day - 1))
        'Stop
        Dim TangalAkhir As DateTime = Date.Now
        'Stop
        Call LoadGrid(TangalAwal, TangalAkhir)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim d As DateTime = Date.Today
        Dim TA As DateTime = d.AddDays(-d.Day)
        Dim TangalAwal As DateTime = TA.AddDays(-(TA.Day - 1))

        Stop
        Dim TangalAkhir As DateTime = Date.Now
        Stop


        'Dim d As DateTime = #3/4/2008#
        'Dim ldom As DateTime = d.AddDays(-d.Day)
        'Dim fdom As DateTime = ldom.AddDays(-(ldom.Day - 1))
        'Stop
        'd = #2/2/2008#
        'ldom = d.AddDays(-d.Day)
        'fdom = ldom.AddDays(-(ldom.Day - 1))
        'Stop


    End Sub
End Class
