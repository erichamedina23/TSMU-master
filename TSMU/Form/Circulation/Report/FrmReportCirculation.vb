Public Class FrmReportCirculation

    Dim Laporan As New RptCirculationHead
    Dim Rpt_OtherDept As New RptCirculation_OtherDept
    Dim LaporanTotal As New RptCirculationTotal
    Dim Report As New ClsCR_CreateUser
    Dim dt As DataTable

    Public Circulation As String = ""



    Private Sub FrmReportCirculation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call loadreport()

    End Sub


    Sub loadreport()

        Dim _User As Boolean = True
        Dim _Dept As Boolean = True
        Dim _Div As Boolean = True
        Dim _ODept As Boolean = True

        dt = New DataTable
        dt = Report.Cek_CR_Report(Circulation)

        For i As Integer = 0 To dt.Rows.Count - 1
            _User = _User And dt.Rows(i).Item("UserSubmition")
            _Dept = _Dept And dt.Rows(i).Item("DeptHead_Approve")
            _Div = _Div And dt.Rows(i).Item("DivHead_Approve")
            _ODept = _ODept And dt.Rows(i).Item("Approve")
        Next

        If _User = True And _Dept = True And _Div = True And _ODept = True Then
            Dim ds As New DataSet
            Dim dsOtherDept As New DataSet
            Dim dsApprove As New DataSet
            Dim dsTotal As New DataSet

            ds = Report.RptCirculation(Circulation)
            dsTotal = Report.RptCirculationTotalDOC(Circulation)

            Laporan.SetDataSource(ds)

            dsOtherDept = Report.RptCirculation_OtherDept(Circulation)
            dsApprove = Report.RptCirculation_Approve(Circulation)
            dsTotal = Report.RptCirculationTotalDOC(Circulation)

            Laporan.Subreports("RptCirculation_OtherDept.rpt").SetDataSource(dsOtherDept)
            Laporan.Subreports("RptCirculationApprove.rpt").SetDataSource(dsApprove)
            Laporan.Subreports("RptCirculationTotal.rpt").SetDataSource(dsTotal)

            With CrystalReportViewer1
                .ReportSource = (Laporan)
                .RefreshReport()
                .Zoom(90)
            End With
        Else
            MessageBox.Show("Circulation can not be printed",
                               "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1)
            Me.Close()
        End If

    End Sub

End Class