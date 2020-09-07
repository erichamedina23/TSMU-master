Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class FrmTravelTicketInvoice
    Dim isUpdate As Boolean
    Dim fs_Code As String
    Dim FrmParent As Form
    Dim Value As Boolean = False
    Dim ObjTravelTicket As New TravelTicketModel
    Dim ObjTravelTicketDetail As New TravelTicketDetailModel
    Dim clsGlobal As GlobalService

    Dim dtInvoiceHeader As New DataTable
    Dim dtInvoiceDetail As New DataTable
    Dim dtTicketCheck As New DataTable
    Dim dtTicketUncheck As New DataTable
    Dim VendorID As String = "T0001"
    Dim NoVoucher As String
    Dim Tanggal As Date

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByRef strCode As String, ByRef dtHeader As DataTable, ByVal dtDetail As DataTable, ByVal lf_FormParent As Form)
        Me.New()
        If strCode <> "" Then
            fs_Code = strCode
            isUpdate = True
        End If
        FrmParent = lf_FormParent
        dtInvoiceHeader = dtHeader
        dtInvoiceDetail = dtDetail
    End Sub

    ReadOnly Property Proses() As Boolean
        Get
            Return value
        End Get
    End Property

    Private Sub FrmTravelTicketInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fs_Code = "" Then
            isUpdate = False
        End If

        Dim filterRow As DataRow()
        Dim dtTemp As New DataTable
        filterRow = dtInvoiceDetail.Select("CheckList = true And Seq <> 1", "NoRequest Asc, Seq Desc")
        If filterRow.Count > 0 Then
            dtTemp = filterRow.CopyToDataTable
        End If
        dtTicketCheck = dtInvoiceDetail.Select("CheckList = true").CopyToDataTable
        Dim noRequest As String = String.Empty
        For Each row_ As DataRow In dtTemp.Rows
            Dim amount As Double
            Dim TicketNumber As String = String.Empty
            If row_("NoRequest") <> noRequest AndAlso row_("Seq") > 1 Then
                If isUpdate Then
                    Dim dtTSC As New DataTable
                    dtTSC = ObjTravelTicket.GetTravelTicketTSC(fs_Code, row_("NoRequest"), row_("Seq") + 1)
                    If dtTSC.Rows.Count > 0 Then
                        amount = dtTSC(0).Item("Amount")
                        TicketNumber = dtTSC(0).Item("TicketNumber")
                    End If
                End If
                Dim row As DataRow = dtTicketCheck.NewRow
                row("NoRequest") = row_("NoRequest")
                row("Seq") = row_("Seq") + 1
                row("Nama") = row_("Nama")
                row("DeptID") = row_("DeptID")
                row("Purpose") = row_("Purpose")
                row("TravelType") = row_("TravelType")
                row("Destination") = "TSC"
                row("DepartureDate") = row_("ArrivalDate")
                row("ArrivalDate") = row_("ArrivalDate")
                row("TicketNumber") = row_("TicketNumber")
                row("CuryID") = row_("CuryID")
                row("Amount") = amount
                row("StatusTicket") = row_("StatusTicket")
                row("Invoice") = row_("Invoice")
                row("CheckList") = True
                dtTicketCheck.Rows.Add(row)
                noRequest = row_("NoRequest")
            End If
        Next
        dtTicketCheck = dtTicketCheck.Select("", "NoRequest ASC, Seq Asc").CopyToDataTable
        GridInvoice.DataSource = dtTicketCheck

        filterRow = dtInvoiceDetail.Select("CheckList = false AND StatusTicket = 'INVOICE'")
        If filterRow.Count > 0 Then
            dtTicketUncheck = filterRow.CopyToDataTable
        End If

        LoadTxtBox()
    End Sub

    Private Sub LoadTxtBox()
        Try
            If isUpdate Then
                For Each rows As DataRow In dtInvoiceHeader.Rows
                    NoVoucher = rows("NoVoucher")
                    Tanggal = rows("Tanggal")
                    txtVendor.Text = rows("Vendor")
                    txtNoInvoice.Text = rows("NoInvoice")
                    dtDate.EditValue = rows("DateInvoice")
                    dtDueDate.EditValue = IIf(rows("DueDateInvoice") = Nothing, DBNull.Value, rows("DueDateInvoice"))
                    txtCuryID.Text = rows("CurryID")
                    txtTotAmount.Text = rows("TotAmount")
                Next
            Else
                NoVoucher = ""
                Tanggal = Date.Today
                txtVendor.Text = "TARA TOUR"
                txtCuryID.Text = "IDR"
                dtDueDate.EditValue = Nothing
                txtTotAmount.Text = Format(0, gs_FormatDecimal)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtVendor_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtVendor.ButtonClick
        Try
            ObjTravelTicket = New TravelTicketModel
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""

            dtSearch = ObjTravelTicket.GetTravelVendor
            dtSearch.Rows.Add("T0001", "TARA TOUR")
            ls_OldKode = txtVendor.Text
            ls_Judul = "Vendor"

            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select Data " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim Vendor As String = ""

            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then
                VendorID = lF_SearchData.Values.Item(0).ToString.Trim
                Vendor = lF_SearchData.Values.Item(1).ToString.Trim
                txtVendor.Text = Vendor
            End If
            lF_SearchData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub txtTotAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotAmount.EditValueChanged
        If String.IsNullOrEmpty(txtTotAmount.Text) Then
            txtTotAmount.Text = 0
        End If
        txtTotAmount.Text = Format(Convert.ToDecimal(txtTotAmount.Text), gs_FormatDecimal)
        txtBalance.Text = Format(txtTotAmount.Text - GridViewInvoice.Columns("Amount").SummaryItem.SummaryValue, gs_FormatDecimal)
        If txtBalance.Text = 0 Then
            chkBalance.Checked = True
        Else
            chkBalance.Checked = False
        End If
    End Sub

    Private Sub CAmount_EditValueChanged(sender As Object, e As EventArgs) Handles CAmount.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        txtBalance.Text = Format(txtTotAmount.Text - GridViewInvoice.Columns("Amount").SummaryItem.SummaryValue, gs_FormatDecimal)
        If txtBalance.Text = 0 Then
            chkBalance.Checked = True
        Else
            chkBalance.Checked = False
        End If
    End Sub

    Private Sub btnSaveInvoice_Click(sender As Object, e As EventArgs) Handles btnSaveInvoice.Click
        If CekValidasi() Then
            Try
                If isUpdate = False Then
                    ObjTravelTicket.InsertData(FrmParent)
                    Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                Else
                    ObjTravelTicket.NoVoucher = NoVoucher
                    ObjTravelTicket.UpdateData()
                    Call ShowMessage("Data Updated", MessageTypeEnum.NormalMessage)
                End If

                Value = True
                Me.Close()
            Catch ex As Exception
                ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            End Try

        End If
    End Sub

    Function CekValidasi() As Boolean
        Dim validasi As Boolean = True
        Try
            If txtNoInvoice.Text = "" Or txtVendor.Text = "" Or dtDate.EditValue = Nothing Then
                Err.Raise(ErrNumber, , GetMessage(MessageEnum.PropertyKosong))
            ElseIf txtBalance.Text <> 0 Then
                Err.Raise(ErrNumber, , "Amount detail tidak balance dengan summary !")
            End If

            If isUpdate = True Then
                ObjTravelTicket.NoVoucher = fs_Code
                If ObjTravelTicket.CheckRequestSettle Then
                    Err.Raise(ErrNumber, , "No Voucher " & fs_Code & " sudah proses settlement !")
                End If
            End If

            If validasi Then
                If isUpdate = False Then
                    clsGlobal = New GlobalService
                    NoVoucher = clsGlobal.GetAutoNumber(FrmParent)
                End If

                With ObjTravelTicket
                    .NoVoucher = NoVoucher
                    .Tanggal = Tanggal
                    .Vendor = txtVendor.Text.ToUpper
                    .NoInvoice = txtNoInvoice.Text.ToUpper
                    .DateInvoice = dtDate.EditValue
                    .DueDateInvoice = IIf(dtDueDate.EditValue Is DBNull.Value, Nothing, dtDueDate.EditValue)
                    .CurryID = txtCuryID.Text.ToUpper
                    .TotAmount = Convert.ToDouble(txtTotAmount.Text)
                End With

                ObjTravelTicket.ObjTravelTicketDetail.Clear()
                For Each rows As DataRow In dtTicketCheck.Rows
                    ObjTravelTicketDetail = New TravelTicketDetailModel
                    With ObjTravelTicketDetail
                        .NoVoucher = NoVoucher
                        .NoRequest = rows("NoRequest").ToString()
                        .Seq = Convert.ToInt16(rows("Seq"))
                        .TicketNumber = rows("TicketNumber").ToString()
                        .CuryID = rows("CuryID").ToString()
                        .Amount = Convert.ToDouble(rows("Amount"))
                    End With
                    ObjTravelTicket.ObjTravelTicketDetail.Add(ObjTravelTicketDetail)
                Next

                ObjTravelTicket.ObjTravelTicketUncheck.Clear()
                For Each rows As DataRow In dtTicketUncheck.Rows
                    ObjTravelTicketDetail = New TravelTicketDetailModel
                    With ObjTravelTicketDetail
                        .NoVoucher = NoVoucher
                        .NoRequest = rows("NoRequest").ToString()
                        .Seq = Convert.ToInt16(rows("Seq"))
                    End With
                    ObjTravelTicket.ObjTravelTicketUncheck.Add(ObjTravelTicketDetail)
                Next
            End If

        Catch ex As Exception
            validasi = False
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
        Return validasi
    End Function

    Private Sub txtCuryID_EditValueChanged(sender As Object, e As EventArgs) Handles txtCuryID.EditValueChanged
        For Each rows As DataRow In dtTicketCheck.Rows
            rows("CuryID") = txtCuryID.Text
        Next
    End Sub

End Class