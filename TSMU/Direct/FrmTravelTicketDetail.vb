Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class FrmTravelTicketDetail
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim _Tag As TagModel

    Dim ObjTravelTicket As New TravelTicketModel
    Dim ObjTravelTicketDetail As New TravelTicketDetailModel

    Dim GridDtl As GridControl
    Dim dtGrid As New DataTable
    Dim dtRequest As New DataTable
    Dim dtInvoiceHeader As New DataTable
    Dim dtInvoiceDetail As New DataTable
    Dim row As Integer

    Public NoVoucher As String
    Dim VendorID As String = "T0001"

    Public Sub New()

        ' This call is required by the designer. 
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form,
                   ByVal li_GridRow As Integer,
                   ByRef _Grid As GridControl)
        ' this call is required by the windows form designer
        Me.New()
        If strCode <> "" Then
            fs_Code = strCode
            fs_Code2 = strCode2
            bi_GridParentRow = li_GridRow
        End If
        row = li_GridRow
        GridDtl = _Grid
        FrmParent = lf_FormParent
        _Tag = New TagModel
        _Tag.PageIndex = lf_FormParent.Tag.PageIndex
        Tag = _Tag
    End Sub

    Private Sub FrmTravelTicketDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Proc_EnableButtons(False, False, False, True, False, False, False, False, False, False, False)
        Call InitialSetForm()
    End Sub

    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "" Then
                ObjTravelTicket.NoVoucher = fs_Code
                ObjTravelTicket.GetTravelTicketByID()
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                Me.Text = "TICKET DETAIL"
            Else
                Me.Text = "NEW TICKET"
            End If
            Call LoadTxtBox()
            LoadGridDetail()
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = "FrmTravelTicket"
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Sub LoadGridDetail()
        Try
            If fs_Code <> "" Then
                dtGrid = New DataTable
                ObjTravelTicket.NoVoucher = fs_Code
                dtGrid = ObjTravelTicket.GetTravelTicketDetail()
                dtRequest = dtGrid.Copy
                GridTicket.DataSource = dtRequest
            Else
                GridViewTicket.Columns("TicketNumber").Visible = False
                GridViewTicket.Columns("CuryID").Visible = False
                GridViewTicket.Columns("Amount").Visible = False
                GridViewTicket.Columns("Invoice").Visible = False
                dtGrid = New DataTable
                dtGrid = ObjTravelTicket.GetTravelTicketDetail()
                dtRequest = dtGrid.Copy
                GridTicket.DataSource = dtRequest
                'GridCellFormat(GridViewTicket)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadTxtBox()
        Try
            If fs_Code <> "" Then
                With ObjTravelTicket
                    txtNoVoucher.Text = .NoVoucher
                    dtTanggal.EditValue = .Tanggal
                    dtInvoiceHeader = New DataTable
                    dtInvoiceHeader.Columns.Add("NoVoucher", GetType(String))
                    dtInvoiceHeader.Columns.Add("Tanggal", GetType(Date))
                    dtInvoiceHeader.Columns.Add("Vendor", GetType(String))
                    dtInvoiceHeader.Columns.Add("NoInvoice", GetType(String))
                    dtInvoiceHeader.Columns.Add("DateInvoice", GetType(Date))
                    dtInvoiceHeader.Columns.Add("DueDateInvoice", GetType(Date))
                    dtInvoiceHeader.Columns.Add("CurryID", GetType(String))
                    dtInvoiceHeader.Columns.Add("TotAmount", GetType(String))

                    Dim rowHeader As DataRow = dtInvoiceHeader.NewRow
                    rowHeader("NoVoucher") = .NoVoucher
                    rowHeader("Tanggal") = .Tanggal
                    rowHeader("Vendor") = .Vendor
                    rowHeader("NoInvoice") = .NoInvoice
                    rowHeader("DateInvoice") = .DateInvoice
                    rowHeader("DueDateInvoice") = .DueDateInvoice
                    rowHeader("CurryID") = .CurryID
                    rowHeader("TotAmount") = .TotAmount
                    dtInvoiceHeader.Rows.Add(rowHeader)
                End With
            Else
                txtNoVoucher.Text = ""
                dtTanggal.EditValue = DateTime.Today
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CCheck_EditValueChanged(sender As Object, e As EventArgs) Handles CCheck.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim checkList As Boolean
        Dim noRequest As String

        checkList = GridViewTicket.GetRowCellValue(GridViewTicket.FocusedRowHandle, "CheckList")
        noRequest = GridViewTicket.GetRowCellValue(GridViewTicket.FocusedRowHandle, "NoRequest")
        'If checkList Then
        For i As Integer = 0 To GridViewTicket.RowCount - 1
            If GridViewTicket.GetRowCellValue(i, "NoRequest") = noRequest Then
                GridViewTicket.SetRowCellValue(i, "CheckList", checkList)
            End If
        Next
        'End If 
        HitungTotal()

    End Sub

    Private Sub CAmount_EditValueChanged(sender As Object, e As EventArgs) Handles CAmount.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
        HitungTotal()

    End Sub

    Private Sub HitungTotal()
        Dim totalAmount As Double
        For i As Integer = 0 To GridViewTicket.RowCount - 1
            Dim checkList As Boolean
            Dim amount As Double
            checkList = GridViewTicket.GetRowCellValue(i, "CheckList")
            amount = IIf(GridViewTicket.GetRowCellValue(i, "Amount") Is DBNull.Value, 0, GridViewTicket.GetRowCellValue(i, "Amount"))
            If checkList Then
                totalAmount = totalAmount + amount
            End If
        Next
        'txtTotal.Text = Format(totalAmount, gs_FormatDecimal)
        'txtBalance.Text = Format(txtTotAmount.Text - txtTotal.Text, gs_FormatDecimal)
        'If txtBalance.Text = 0 Then
        '    chkBalance.Checked = True
        'Else
        '    chkBalance.Checked = False
        'End If
    End Sub

    Private Sub btnProsesInvoice_Click(sender As Object, e As EventArgs) Handles btnProsesInvoice.Click
        dtInvoiceDetail = New DataTable
        Dim filterRows As DataRow()
        filterRows = dtRequest.Select("CheckList = true")
        If filterRows.Count() = 0 Then
            MessageBox.Show("Tidak ada data yang dipilih !",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            dtInvoiceDetail = dtRequest.Copy
        End If

        Dim frm_TicketInvoice As FrmTravelTicketInvoice
        frm_TicketInvoice = New FrmTravelTicketInvoice(fs_Code, dtInvoiceHeader, dtInvoiceDetail, FrmParent)
        frm_TicketInvoice.Text = "Input Invoice"
        frm_TicketInvoice.StartPosition = FormStartPosition.CenterScreen
        frm_TicketInvoice.ShowDialog()

        If frm_TicketInvoice.Proses Then
            GridDtl.DataSource = ObjTravelTicket.GetTravelTicket()
            IsClosed = True
            Me.Hide()
        End If
    End Sub

    Private Sub btnAddDetail_Click(sender As Object, e As EventArgs) Handles btnAddDetail.Click
        Dim dtRequestUncheck As New DataTable
        dtRequest = New DataTable

        ObjTravelTicket.NoVoucher = ""
        dtRequestUncheck = ObjTravelTicket.GetTravelTicketDetail()

        If fs_Code <> "" Then
            dtRequest = dtGrid.Copy
            For Each row As DataRow In dtRequestUncheck.Rows
                dtRequest.Rows.Add(row.ItemArray)
            Next
            GridTicket.DataSource = dtRequest
        Else
            dtRequest = dtRequestUncheck
            GridTicket.DataSource = dtRequest
        End If

    End Sub

End Class
