Public Class FrmReportTravelSett
    Dim laporan As New CRTravelSettlement
    Dim report As New TravelSettleHeaderModel

    Sub loadreport()
        Dim dtHeader As New DataTable
        Dim dtDetail As New DataTable
        Dim dtDetailSum As New DataTable
        Dim dtAllowanceAdvance As New DataTable
        Dim dtAllowanceSettle As New DataTable
        Dim dtExpense As New DataTable
        Dim dtExpenseSum As New DataTable
        Dim FilteredRows As DataRow()
        Dim FilteredRowsTicket As DataRow()
        report.TravelSettleID = txtTravelSettleID.Text

        Dim AdvanceUSD As Double = 0
        Dim AdvanceYEN As Double = 0
        Dim AdvanceIDR As Double = 0
        Dim ExpenseUSD As Double = 0
        Dim ExpenseYEN As Double = 0
        Dim ExpenseIDR As Double = 0
        Dim TicketUSD As Double = 0
        Dim TicketYEN As Double = 0
        Dim TicketIDR As Double = 0
        Dim AllowanceUSDA As Double = 0
        Dim AllowanceYENA As Double = 0
        Dim AllowanceIDRA As Double = 0
        Dim AllowanceUSDS As Double = 0
        Dim AllowanceYENS As Double = 0
        Dim AllowanceIDRS As Double = 0

        dtDetail = report.LoadReportSettleDetail()
        dtDetailSum = report.LoadReportSettleDetailSum()
        FilteredRowsTicket = dtDetail.[Select]("ID = 1")
        If FilteredRowsTicket.Count > 0 Then
            laporan.Subreports("CRTravelDetailTicketSett.rpt").SetDataSource(FilteredRowsTicket.CopyToDataTable)
            laporan.Subreports("CRTravelDetailTicketSettRight.rpt").SetDataSource(FilteredRowsTicket.CopyToDataTable)
        End If

        FilteredRows = dtDetail.[Select]("ID = 2")
        If FilteredRows.Count > 0 Then
            laporan.Subreports("CRTravelDetailTransportSett.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            laporan.Subreports("CRTravelDetailTransportSettRight.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            FilteredRows = dtDetailSum.[Select]("ID = 2")
            laporan.Subreports("CRTravelDetailTransportSettRightSum.rpt").SetDataSource(FilteredRows.CopyToDataTable)
        End If

        FilteredRows = dtDetail.[Select]("ID = 3")
        If FilteredRows.Count > 0 Then
            laporan.Subreports("CRTravelDetailStayingSett.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            laporan.Subreports("CRTravelDetailStayingSettRight.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            FilteredRows = dtDetailSum.[Select]("ID = 3")
            laporan.Subreports("CRTravelDetailStayingSettRightSum.rpt").SetDataSource(FilteredRows.CopyToDataTable)
        End If

        FilteredRows = dtDetail.[Select]("ID = 4")
        If FilteredRows.Count > 0 Then
            laporan.Subreports("CRTravelDetailEntertainSett.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            laporan.Subreports("CRTravelDetailEntertainSettRight.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            FilteredRows = dtDetailSum.[Select]("ID = 4")
            laporan.Subreports("CRTravelDetailEntertainSettRightSum.rpt").SetDataSource(FilteredRows.CopyToDataTable)
        End If

        FilteredRows = dtDetail.[Select]("ID = 7")
        If FilteredRows.Count > 0 Then
            laporan.Subreports("CRTravelDetailSafetyMoneySett.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            laporan.Subreports("CRTravelDetailSafetyMoneySettRight.rpt").SetDataSource(FilteredRows.CopyToDataTable)
            FilteredRows = dtDetailSum.[Select]("ID = 7")
            laporan.Subreports("CRTravelDetailSafetyMoneySettRightSum.rpt").SetDataSource(FilteredRows.CopyToDataTable)
        End If

        dtExpense = report.LoadReportSettleExpense()
        laporan.Subreports("CRTravelTotalExpenseSettRight.rpt").SetDataSource(dtExpense)
        dtExpenseSum = report.LoadReportSumExpense()
        laporan.Subreports("CRTravelTotalExpenseSettRightSum.rpt").SetDataSource(dtExpenseSum)

        dtAllowanceAdvance = report.LoadReportAllowanceAdvance()
        dtAllowanceSettle = report.LoadReportAllowanceSettle()

        AllowanceUSDA = Convert.ToDouble(dtAllowanceAdvance.Compute("SUM(USD)", String.Empty))
        AllowanceYENA = Convert.ToDouble(dtAllowanceAdvance.Compute("SUM(YEN)", String.Empty))
        AllowanceIDRA = Convert.ToDouble(dtAllowanceAdvance.Compute("SUM(IDR)", String.Empty))

        AllowanceUSDS = Convert.ToDouble(dtAllowanceSettle.Compute("SUM(USD)", String.Empty))
        AllowanceYENS = Convert.ToDouble(dtAllowanceSettle.Compute("SUM(YEN)", String.Empty))
        AllowanceIDRS = Convert.ToDouble(dtAllowanceSettle.Compute("SUM(IDR)", String.Empty))

        laporan.Subreports("CRTravelDetailAllowanceSett.rpt").SetDataSource(dtAllowanceAdvance)
        laporan.Subreports("CRTravelDetailAllowanceSettRight.rpt").SetDataSource(dtAllowanceSettle)

        FilteredRows = dtExpenseSum.[Select]("SumDesc like '%CASH%'")
        If FilteredRows.Count > 0 Then
            ExpenseUSD = Convert.ToDouble(FilteredRows(0).Item("USD"))
            ExpenseYEN = Convert.ToDouble(FilteredRows(0).Item("YEN"))
            ExpenseIDR = Convert.ToDouble(FilteredRows(0).Item("IDR"))
        End If

        For Each row As DataRow In FilteredRowsTicket.CopyToDataTable.Rows
            If row("CurryID") = "USD" Then
                TicketUSD = Convert.ToDouble(row("Amount"))
            ElseIf row("CurryID") = "YEN" Then
                TicketYEN = Convert.ToDouble(row("Amount"))
            Else
                TicketIDR = Convert.ToDouble(row("Amount"))
            End If
        Next
        ExpenseUSD = ExpenseUSD + TicketUSD + AllowanceUSDS
        ExpenseYEN = ExpenseYEN + TicketYEN + AllowanceYENS
        ExpenseIDR = ExpenseIDR + TicketIDR + AllowanceIDRS

        dtExpenseSum.Clear()
        dtExpenseSum.Rows.Add("", "", ExpenseUSD, ExpenseYEN, ExpenseIDR)

        laporan.Subreports("CRTravelTotalSuspenseSettRight.rpt").SetDataSource(dtExpenseSum)

        dtHeader = report.LoadReportSettleHeader()
        dtHeader.Rows(0)("TotalAdvanceUSD") = dtHeader.Rows(0)("TotalAdvanceUSD") + TicketUSD
        dtHeader.Rows(0)("TotalAdvanceYEN") = dtHeader.Rows(0)("TotalAdvanceYEN") + TicketYEN
        dtHeader.Rows(0)("TotalAdvanceIDR") = dtHeader.Rows(0)("TotalAdvanceIDR") + TicketIDR
        AdvanceUSD = dtHeader.Rows(0)("TotalAdvanceUSD") + AllowanceUSDA
        AdvanceYEN = dtHeader.Rows(0)("TotalAdvanceYEN") + AllowanceYENA
        AdvanceIDR = dtHeader.Rows(0)("TotalAdvanceIDR") + AllowanceIDRA
        dtHeader.Rows(0)("Penanggung") = txtPersonInCharge.Text
        dtHeader.Rows(0)("TotalUSD") = AdvanceUSD
        dtHeader.Rows(0)("TotalYEN") = AdvanceYEN
        dtHeader.Rows(0)("TotalIDR") = AdvanceIDR
        dtHeader.Rows(0)("SettleUSD") = ExpenseUSD
        dtHeader.Rows(0)("SettleYEN") = ExpenseYEN
        dtHeader.Rows(0)("SettleIDR") = ExpenseIDR
        laporan.SetDataSource(dtHeader)

        With CrystalReportViewer1
            .ReportSource = laporan
            .RefreshReport()
        End With
    End Sub

    Private Sub FrmReportTravelSett_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadreport()
    End Sub
End Class