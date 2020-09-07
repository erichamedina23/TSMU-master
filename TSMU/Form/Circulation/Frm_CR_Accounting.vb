Imports System.Globalization

Public Class Frm_CR_Accounting

    Dim ff_Detail As Frm_CR_UserCreateDetail
    Dim dtGrid As DataTable
    Dim fc_Class As New clsCR_Accounting
    Dim IdTrans As String
    Dim Dept As String
    Dim DeptHeadID As String
    Dim Tanggal As Date
    Dim Active_Form As Integer = 5


    Private Sub Frm_CR_Accounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bb_SetDisplayChangeConfirmation = False
        Dept = gh_Common.GroupID
        DeptHeadID = gh_Common.Username
        LoadGrid()
        Dim dtGrid As New DataTable
        Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False)
        Call Grid_Properties()
    End Sub
    Public Sub LoadGrid()
        Try
            Cursor.Current = Cursors.WaitCursor

            Dim dt As New DataTable
            dt = fc_Class.Get_Approve_Accounting()
            Grid.DataSource = dt

            Dim dt2 As New DataTable
            dt2 = fc_Class.Get_Approve_Accounting2()
            Grid2.DataSource = dt2

            Call Proc_EnableButtons(False, False, False, True, True, False, False, False)
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

    Private Sub Grid_Properties()
        Try
            With GridView1

                '.BestFitColumns()
                '.Columns("Term").Width = 2
                .Columns("Circulation").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Circulation").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Circulation").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                '.Columns("Term").DisplayFormat.FormatString = "c2"
                '.Columns("Date").Width = 20
                .Columns("Tgl").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Tgl").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Tgl").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                '.Columns("%").Width = 2
                .Columns("Dept").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Dept").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Dept").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

                .Columns("Status").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Status").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Status").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

                .Columns("Approved").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Approved").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("Approved").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

                .Columns("IDR").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("IDR").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
                .Columns("IDR").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                .Columns("IDR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("IDR").DisplayFormat.FormatString = "{0:N2}"
                .Columns("IDR").Width = 100

                '.Columns("Amount").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                '.Columns("IDR").SummaryItem.DisplayFormat = "{0:N2}"

                .Columns("USD").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("USD").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .Columns("USD").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                .Columns("USD").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("USD").DisplayFormat.FormatString = "{0:N2}"
                '.Columns("Amount").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                '.Columns("USD").SummaryItem.DisplayFormat = "{0:N2}"


                'For b As Integer = 0 To GridView3.RowCount - 1
                '    Dim Header As String = GridView3.GetRowCellValue(b, "Curr")
                '    .Columns(Header).Width = 200 / GridView3.RowCount
                '    .Columns(Header).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                '    .Columns(Header).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default


                '    .Columns(Header).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                '    .Columns(Header).DisplayFormat.FormatString = "N2"
                '    .Columns(Header).OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

                '    .Columns(Header).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                '    .Columns(Header).SummaryItem.DisplayFormat = "{0:N2}"
                'Next

                '.OptionsView.ShowFooter = True
                '.OptionsBehavior.Editable = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        bs_Filter = ""
        Call LoadGrid()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Call LoadGrid()
    End Sub

    Private Sub Grid2_DoubleClick(sender As Object, e As EventArgs) Handles Grid2.DoubleClick

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
End Class
