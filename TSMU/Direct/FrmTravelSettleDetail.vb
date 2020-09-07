Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports TSMU

Public Class FrmTravelSettleDetail
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim _Tag As TagModel

    Dim cls_TravelSett As New TravelSettleHeaderModel
    Dim cls_TravelSettDetail As New TravelSettleDetailModel
    Dim cls_TravelSettCost As New TravelSettleCostModel
    Dim clsGlobal As GlobalService

    Dim GridDtl As GridControl
    Dim gv_Request As New GridView
    Dim dtGrid As New DataTable
    Dim filterRows As DataRow()
    Dim dtSummary As New DataTable
    Dim dtBalance As New DataTable
    Dim dtVoucher As New DataTable

    Dim dtEntertainHeader As New DataTable
    Dim dtEntertainDetail As New DataTable
    Dim dtEntertainRelasi As New DataTable

    Dim dtAllowance As New DataTable
    Dim row As Integer
    Dim flag As Integer
    Dim TabPage As String

    Dim travelSettID As String
    Dim RateSalomonUSD As Double
    Dim RateSalomonYEN As Double
    Dim ReturnUSD As Double
    Dim ReturnYEN As Double
    Dim ReturnIDR As Double

    Dim CashIDR As Double
    Dim CashUSD As Double
    Dim CashYEN As Double
    Dim CreditIDR As Double
    Dim CreditUSD As Double
    Dim CreditYEN As Double

    'Dim frm_Entertain As FrmTravelEntertainDetail
    Dim frm_Entertainment As FrmEntertainSettleDetailDirect

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form,
                   ByVal li_GridRow As Integer,
                   ByVal gv_GridView As GridView,
                   ByRef _Grid As GridControl)
        ' this call is required by the windows form designer
        Me.New()
        If strCode <> "" Then
            fs_Code = strCode
            fs_Code2 = strCode2
            bi_GridParentRow = li_GridRow
        End If
        GridDtl = _Grid
        FrmParent = lf_FormParent
        gv_Request = gv_GridView
        _Tag = New TagModel
        _Tag.PageIndex = lf_FormParent.Tag.PageIndex
        Tag = _Tag
    End Sub

    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0, Optional ByVal IsNew As Boolean = True)
        'If frm_Entertain IsNot Nothing AndAlso frm_Entertain.Visible Then
        '    If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
        '        Exit Sub
        '    End If
        '    frm_Entertain.Close()
        'End If
        'frm_Entertain = New FrmTravelEntertainDetail(ls_Code, Me)
        'frm_Entertain.MdiParent = FrmMain
        'frm_Entertain.StartPosition = FormStartPosition.CenterScreen
        'frm_Entertain.Show()
        If frm_Entertainment IsNot Nothing AndAlso frm_Entertainment.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            frm_Entertainment.Close()
        End If
        frm_Entertainment = New FrmEntertainSettleDetailDirect(ls_Code, ls_Code2, Me, li_Row, GridEntertain)
        frm_Entertainment.MdiParent = FrmMain
        frm_Entertainment.StartPosition = FormStartPosition.CenterScreen
        frm_Entertainment.Show()
    End Sub

    Private Sub FrmTravelSettleDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, False)
        Call InitialSetForm()
    End Sub

    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "" Then
                Call Proc_EnableButtons(False, True, False, True, False, False, False, True, False, False, False)
                cls_TravelSett.TravelSettleID = fs_Code
                cls_TravelSett.GetTravelSettHeaderByID()
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                Me.Text = "SETTLEMENT DETAIL"
            Else
                Me.Text = "NEW SETTLEMENT"
            End If
            Call LoadTxtBox()
            LoadGridDetail()
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = "FrmTravelSettle"
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub EntertainID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles CEntertainIDEntertain.ButtonClick
        Dim entertainID As String = String.Empty

        Dim selectedRows() As Integer = GridViewEntertain.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                row = rowHandle
                entertainID = IIf(GridViewEntertain.GetRowCellValue(rowHandle, "EntertainID") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(rowHandle, "EntertainID"))
                'If entertainID <> "" Then
                '    'id2 = ObjTravelSettDetail.GetSettleID(id)
                'End If
            End If
        Next rowHandle

        Call CallFrm(entertainID, entertainID, row)
        flag = 1
    End Sub

    Private Sub LoadTxtBox()
        Try
            dtAllowance = New DataTable
            If fs_Code <> "" Then
                With cls_TravelSett
                    txtTravelSettID.Text = .TravelSettleID
                    TxtTgl.EditValue = .DateHeader
                    txtPRNo.Text = .NoPR
                    TxtDep.Text = .DeptID
                    TxtNama.Text = .Nama
                    txtPurpose.Text = .Purpose
                    txtTravelType.Text = .TravelType
                    TxtDepDate.EditValue = .DepartureDate
                    TxtArrDate.EditValue = .ArrivalDate
                    txtTotalDay.Text = DateDiff(DateInterval.Day, TxtDepDate.EditValue, TxtArrDate.EditValue) + 1
                    TxtTerm.Text = .Term
                    TxtTotalAdvanceIDR.Text = Format(.TotalAdvanceIDR, gs_FormatDecimal)
                    TxtTotalAdvanceYEN.Text = Format(.TotalAdvanceYEN, gs_FormatDecimal)
                    TxtTotalAdvanceUSD.Text = Format(.TotalAdvanceUSD, gs_FormatDecimal)
                    ReturnIDR = .TotalReturnIDR
                    ReturnUSD = .TotalReturnUSD
                    ReturnYEN = .TotalReturnYEN
                    RateSalomonUSD = .RateSalomonUSD
                    RateSalomonYEN = .RateYEN
                    txtRateUSD.Text = Format(.RateUSD, gs_FormatDecimal)
                    txtRateYEN.Text = Format(.RateYEN, gs_FormatDecimal)
                End With
                cls_TravelSettDetail.TravelSettleID = txtTravelSettID.Text
                dtAllowance = cls_TravelSettDetail.GetTravelSettDetailByID
            Else
                Dim listNama = New ArrayList()
                Dim listRequest = New ArrayList()
                Dim advanceIDR As Double
                Dim advanceUSD As Double
                Dim advanceYEN As Double

                Dim Rows As New ArrayList()
                For i As Integer = 0 To gv_Request.SelectedRowsCount() - 1
                    If (gv_Request.GetSelectedRows()(i) >= 0) Then
                        Rows.Add(gv_Request.GetDataRow(gv_Request.GetSelectedRows()(i)))
                    End If
                Next

                For i = 0 To Rows.Count - 1
                    Dim Row As DataRow = CType(Rows(i), DataRow)
                    listRequest.Add("'" + Row("NoRequest") + "'")
                    TxtDep.Text = Row("DeptID")
                    listNama.Add(Row("Nama"))
                    txtPurpose.Text = Row("Purpose")
                    txtTravelType.Text = Row("TravelType")
                    TxtDepDate.EditValue = Row("DepartureDate")
                    TxtArrDate.EditValue = Row("ArrivalDate")
                    TxtTerm.Text = Row("Term")
                    advanceIDR = advanceIDR + Row("AdvanceIDR")
                    advanceUSD = advanceUSD + Row("AdvanceUSD")
                    advanceYEN = advanceYEN + Row("AdvanceYEN")
                Next
                TxtNama.Text = String.Join(", ", listNama.ToArray)
                TxtTgl.EditValue = DateTime.Today
                TxtTotalAdvanceIDR.Text = Format(advanceIDR, gs_FormatDecimal)
                TxtTotalAdvanceUSD.Text = Format(advanceUSD, gs_FormatDecimal)
                TxtTotalAdvanceYEN.Text = Format(advanceYEN, gs_FormatDecimal)
                RateSalomonUSD = cls_TravelSett.GetRate("USD", TxtTgl.EditValue)
                RateSalomonYEN = cls_TravelSett.GetRate("JPY", TxtTgl.EditValue)
                txtRateUSD.Text = Format(RateSalomonUSD, gs_FormatDecimal)
                txtRateYEN.Text = Format(RateSalomonYEN, gs_FormatDecimal)
                txtTotalDay.Text = DateDiff(DateInterval.Day, TxtDepDate.EditValue, TxtArrDate.EditValue) + 1

                Dim inNoRequest As String = String.Join(",", listRequest.ToArray)
                dtAllowance = cls_TravelSett.GetRequestAllowance(inNoRequest)
            End If
            dtAllowance.Columns.Add("RateAllowanceIDR", GetType(Double))
            dtAllowance.Columns.Add("TotalAllowanceIDR", GetType(Double))
            For Each row_ As DataRow In dtAllowance.Rows
                Dim total As Double = (row_("SettlementUSD") * txtRateUSD.Text) + (row_("SettlementYEN") * txtRateYEN.Text) + row_("SettlementIDR")
                row_("RateAllowanceIDR") = row_("RateAllowanceUSD") * txtRateUSD.Text * row_("Days")
                row_("TotalAllowanceIDR") = total
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub LoadGridDetail()
        Try
            Dim dtGridKosong = New DataTable
            dtGridKosong.Columns.AddRange(New DataColumn(16) {New DataColumn("TravelSettleID", GetType(String)),
                                                            New DataColumn("ID", GetType(Integer)),
                                                            New DataColumn("AccountID", GetType(String)),
                                                            New DataColumn("SubAccount", GetType(String)),
                                                            New DataColumn("Date", GetType(Date)),
                                                            New DataColumn("EntertainID", GetType(String)),
                                                            New DataColumn("TFrom", GetType(String)),
                                                            New DataColumn("TTo", GetType(String)),
                                                            New DataColumn("Transport", GetType(String)),
                                                            New DataColumn("Description", GetType(String)),
                                                            New DataColumn("PaymentType", GetType(String)),
                                                            New DataColumn("CreditCardID", GetType(String)),
                                                            New DataColumn("CreditCardNumber", GetType(String)),
                                                            New DataColumn("AccountName", GetType(String)),
                                                            New DataColumn("CurryID", GetType(String)),
                                                            New DataColumn("Amount", GetType(Double)),
                                                            New DataColumn("AmountIDR", GetType(Double))})

            Dim dtGridTransport = New DataTable
            Dim dtGridHotel = New DataTable
            Dim dtGridEntertain = New DataTable
            Dim dtGridOther = New DataTable

            If fs_Code <> "" Then
                dtGrid = New DataTable
                cls_TravelSettCost.TravelSettleID = txtTravelSettID.Text
                dtGrid = cls_TravelSettCost.GetTravelSettleCostByID

                filterRows = dtGrid.Select("ID = 2")
                If filterRows.Count > 0 Then
                    GridTransport.DataSource = filterRows.CopyToDataTable
                Else
                    dtGridTransport = dtGridKosong.Copy
                    GridTransport.DataSource = dtGridTransport
                End If

                filterRows = dtGrid.Select("ID = 3")
                If filterRows.Count > 0 Then
                    GridHotel.DataSource = filterRows.CopyToDataTable
                Else
                    dtGridHotel = dtGridKosong.Copy
                    GridHotel.DataSource = dtGridHotel
                End If

                filterRows = dtGrid.Select("ID = 4")
                If filterRows.Count > 0 Then
                    GridEntertain.DataSource = filterRows.CopyToDataTable
                Else
                    dtGridEntertain = dtGridKosong.Copy
                    GridEntertain.DataSource = dtGridEntertain
                End If

                filterRows = dtGrid.Select("ID = 7")
                If filterRows.Count > 0 Then
                    GridOther.DataSource = filterRows.CopyToDataTable
                Else
                    dtGridOther = dtGridKosong.Copy
                    GridOther.DataSource = dtGridOther
                End If

                GridPocketAllowance.DataSource = dtAllowance
            Else
                dtGridTransport = dtGridKosong.Copy
                GridTransport.DataSource = dtGridTransport

                dtGridHotel = dtGridKosong.Copy
                GridHotel.DataSource = dtGridHotel

                dtGridEntertain = dtGridKosong.Copy
                GridEntertain.DataSource = dtGridEntertain

                dtGridOther = dtGridKosong.Copy
                GridOther.DataSource = dtGridOther

                GridPocketAllowance.DataSource = dtAllowance
            End If

            CreateTable()
            HitungSummaryAll(GridSumTransport, GridViewSumTransport)

            GridBalanceTransport.DataSource = dtBalance

            dtVoucher.Rows.Add("USD", 0, 0, 0, ReturnUSD, 0, 0)
            dtVoucher.Rows.Add("YEN", 0, 0, 0, ReturnYEN, 0, 0)
            dtVoucher.Rows.Add("IDR", 0, 0, 0, ReturnIDR, 0, 0)
            GridBalance.DataSource = dtVoucher

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Overrides Function ValidateSave() As Boolean
        Dim lb_Validated As Boolean = False
        Try

            If DxValidationProvider1.Validate Then
                lb_Validated = True
            Else
                Err.Raise(ErrNumber, , "Data yang anda input tidak valid, silahkan cek inputan anda !")
            End If

            If isUpdate Then
                cls_TravelSett.TravelSettleID = txtTravelSettID.Text
                If cls_TravelSett.CheckSettleAccrued Then
                    Err.Raise(ErrNumber, , "No Settlement " & txtTravelSettID.Text & " sudah dilakukan proses Accrued !")
                End If
            End If

            If lb_Validated Then
                If isUpdate = False Then
                    clsGlobal = New GlobalService
                    travelSettID = clsGlobal.GetAutoNumber(FrmParent)
                    DataTravelSettDetail()
                    txtTravelSettID.Text = travelSettID
                Else
                    travelSettID = txtTravelSettID.Text
                    DataTravelSettDetail()
                End If

                With cls_TravelSett
                    .TravelSettleID = txtTravelSettID.Text
                    .DateHeader = TxtTgl.EditValue
                    .NoPR = txtPRNo.Text
                    .DeptID = TxtDep.Text
                    .Nama = TxtNama.Text
                    .Destination = ""
                    .TravelType = txtTravelType.Text
                    .Purpose = txtPurpose.Text
                    .DepartureDate = TxtDepDate.EditValue
                    .ArrivalDate = TxtArrDate.EditValue
                    .Term = TxtTerm.Text
                    .PickUp = ""
                    .Visa = ""
                    .RateSalomonUSD = RateSalomonUSD
                    .RateSalomonYEN = RateSalomonYEN
                    .RateUSD = txtRateUSD.Text
                    .RateYEN = txtRateYEN.Text
                    .TotalAdvanceIDR = TxtTotalAdvanceIDR.Text
                    .TotalAdvanceYEN = TxtTotalAdvanceYEN.Text
                    .TotalAdvanceUSD = TxtTotalAdvanceUSD.Text
                    .TotalReturnIDR = ReturnIDR
                    .TotalReturnUSD = ReturnUSD
                    .TotalReturnYEN = ReturnYEN
                End With
            End If

        Catch ex As Exception
            lb_Validated = False
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
        Return lb_Validated
    End Function

    Public Overrides Sub Proc_SaveData()
        Try
            If isUpdate = False Then
                cls_TravelSett.InsertDataTravelSettle(FrmParent)
                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            Else
                cls_TravelSett.UpdateDataTravelSettle()
                Call ShowMessage("Data Updated", MessageTypeEnum.NormalMessage)
            End If
            GridDtl.DataSource = cls_TravelSett.GetDataGridRequest()
            IsClosed = True
            Me.Hide()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        InitialSetForm()
    End Sub

    Public Overrides Sub Proc_print()
        'Dim PersonInCharge As String = InputBox("Siapa yang bertanggung jawab ?", "Input Penanggung Jawab")
        Dim strArr() As String
        strArr = TxtNama.Text.Split(",")
        Dim PersonInCharge As String = strArr(0)
        FrmReportTravelSett.StartPosition = FormStartPosition.CenterScreen
        FrmReportTravelSett.txtTravelSettleID.Text = txtTravelSettID.Text
        FrmReportTravelSett.txtPersonInCharge.Text = PersonInCharge
        FrmReportTravelSett.Show()
    End Sub

    Private Sub txtRateUSD_EditValueChanged(sender As Object, e As EventArgs) Handles txtRateUSD.EditValueChanged
        If String.IsNullOrEmpty(txtRateUSD.Text) Then
            txtRateUSD.Text = 1
        End If
        txtRateUSD.Text = Format(Convert.ToDecimal(txtRateUSD.Text), gs_FormatDecimal)
        HitungAmountDetail()
        If TabPage = "TabPageVoucher" Then
            HitungAmountBalance()
        End If
        For Each row_ As DataRow In dtAllowance.Rows
            Dim total As Double = (row_("SettlementUSD") * txtRateUSD.Text) + (row_("SettlementYEN") * txtRateYEN.Text) + row_("SettlementIDR")
            row_("RateAllowanceIDR") = row_("RateAllowanceUSD") * txtRateUSD.Text * row_("Days")
            row_("TotalAllowanceIDR") = total
        Next
    End Sub

    Private Sub txtRateYEN_EditValueChanged(sender As Object, e As EventArgs) Handles txtRateYEN.EditValueChanged
        If String.IsNullOrEmpty(txtRateYEN.Text) Then
            txtRateYEN.Text = 1
        End If
        txtRateYEN.Text = Format(Convert.ToDecimal(txtRateYEN.Text), gs_FormatDecimal)
        HitungAmountDetail()
        If TabPage = "TabPageVoucher" Then
            HitungAmountBalance()
        End If
        For Each row_ As DataRow In dtAllowance.Rows
            Dim total As Double = (row_("SettlementUSD") * txtRateUSD.Text) + (row_("SettlementYEN") * txtRateYEN.Text) + row_("SettlementIDR")
            row_("RateAllowanceIDR") = row_("RateAllowanceUSD") * txtRateUSD.Text * row_("Days")
            row_("TotalAllowanceIDR") = total
        Next
    End Sub

    Private Sub GAccount_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles CAccountTransport.ButtonClick, CAccountHotel.ButtonClick, CAccountEntertain.ButtonClick, CAccountOther.ButtonClick
        Try
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""

            dtSearch = cls_TravelSett.GetAccount
            ls_Judul = "Account"

            Dim editor As ButtonEdit = CType(sender, ButtonEdit)

            If editor.AccessibleName = CAccountTransport.Name Then
                ls_OldKode = IIf(GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "AccountID") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "AccountID"))
            ElseIf editor.AccessibleName = CAccountHotel.Name Then
                ls_OldKode = IIf(GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "AccountID") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "AccountID"))
            ElseIf editor.AccessibleName = CAccountEntertain.Name Then
                ls_OldKode = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "AccountID") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "AccountID"))
            Else ls_OldKode = IIf(GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "AccountID") Is DBNull.Value, "", GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "AccountID"))
            End If

            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select Data " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim Value1 As String = ""
            Dim Value2 As String = ""

            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then
                Value1 = lF_SearchData.Values.Item(0).ToString.Trim
                Value2 = lF_SearchData.Values.Item(1).ToString.Trim
                If editor.AccessibleName = CAccountTransport.Name Then
                    GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "AccountID", Value1)
                ElseIf editor.AccessibleName = CAccountHotel.Name Then
                    GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "AccountID", Value1)
                ElseIf editor.AccessibleName = CAccountEntertain.Name Then
                    GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "AccountID", Value1)
                Else GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "AccountID", Value1)
                End If
            End If

            lF_SearchData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub CPayType_EditValueChanged(sender As Object, e As EventArgs) Handles CPayTypeTransport.EditValueChanged, CPayTypeHotel.EditValueChanged, CPayTypeEntertain.EditValueChanged, CPayTypeOther.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim PayType As String
        Dim CreditCardID As String = ""
        Dim CreditCardNumber As String = ""
        Dim AccountNameNBank As String = ""
        Dim PaymentType As String = ""

        Dim editor As ComboBoxEdit = CType(sender, ComboBoxEdit)

        If editor.AccessibleName = CPayTypeTransport.Name Then
            PayType = IIf(GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "PaymentType") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "PaymentType"))
        ElseIf editor.AccessibleName = CPayTypeHotel.Name Then
            PayType = IIf(GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "PaymentType") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "PaymentType"))
        ElseIf editor.AccessibleName = CPayTypeEntertain.Name Then
            PayType = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "PaymentType") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "PaymentType"))
        Else PayType = IIf(GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "PaymentType") Is DBNull.Value, "", GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "PaymentType"))
        End If


        If PayType = "CREDIT CARD" Then
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable

            dtSearch = cls_TravelSett.GetCreditCard
            ls_Judul = "CREDIT CARD"

            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select Data " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()

            If lF_SearchData.Values IsNot Nothing Then
                CreditCardID = lF_SearchData.Values.Item(0).ToString.Trim
                CreditCardNumber = lF_SearchData.Values.Item(1).ToString.Trim
                AccountNameNBank = lF_SearchData.Values.Item(2).ToString.Trim + "-" + lF_SearchData.Values.Item(3).ToString.Trim
                PaymentType = "CC-" + lF_SearchData.Values.Item(1).ToString.Trim
            Else
                PaymentType = "CASH"
            End If

            lF_SearchData.Close()
        Else
            PaymentType = PayType
        End If

        If editor.AccessibleName = CPayTypeTransport.Name Then
            GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "CreditCardID", CreditCardID)
            GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "CreditCardNumber", CreditCardNumber)
            GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "AccountName", AccountNameNBank)
            GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "PaymentType", PaymentType)
            HitungSummaryAll(GridSumTransport, GridViewSumTransport)
            GridBalanceTransport.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceTransport)
        ElseIf editor.AccessibleName = CPayTypeHotel.Name Then
            GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "CreditCardID", CreditCardID)
            GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "CreditCardNumber", CreditCardNumber)
            GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "AccountName", AccountNameNBank)
            GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "PaymentType", PaymentType)
            HitungSummaryAll(GridSumHotel, GridViewSumHotel)
            GridBalanceHotel.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceHotel)
        ElseIf editor.AccessibleName = CPayTypeEntertain.Name Then
            GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "CreditCardID", CreditCardID)
            GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "CreditCardNumber", CreditCardNumber)
            GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "AccountName", AccountNameNBank)
            GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "PaymentType", PaymentType)
            HitungSummaryAll(GridSumEntertain, GridViewSumEntertain)
            GridBalanceEntertain.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceEntertain)
        Else GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "CreditCardID", CreditCardID)
            GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "CreditCardNumber", CreditCardNumber)
            GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "AccountName", AccountNameNBank)
            GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "PaymentType", PaymentType)
            HitungSummaryAll(GridSumOthers, GridViewSumOthers)
            GridBalanceOther.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceOther)
        End If
    End Sub

    Private Sub DataTravelSettDetail()
        Dim seq As Integer

        'Data settlement detail
        cls_TravelSett.ObjSettleDetail.Clear()
        For i As Integer = 0 To GridViewPocketAllowance.RowCount - 1
            cls_TravelSettDetail = New TravelSettleDetailModel
            With cls_TravelSettDetail
                .TravelSettleID = travelSettID
                .NoRequest = GridViewPocketAllowance.GetRowCellValue(i, "NoRequest")
                .Nama = GridViewPocketAllowance.GetRowCellValue(i, "Nama")
                If String.IsNullOrEmpty(IIf(GridViewPocketAllowance.GetRowCellValue(i, "DepartureDate") Is DBNull.Value, "", GridViewPocketAllowance.GetRowCellValue(i, "DepartureDate"))) Then
                    Err.Raise(ErrNumber, , "Departure Date tidak boleh kosong !")
                End If
                .DepartureDate = GridViewPocketAllowance.GetRowCellValue(i, "DepartureDate")
                If String.IsNullOrEmpty(IIf(GridViewPocketAllowance.GetRowCellValue(i, "ArrivalDate") Is DBNull.Value, "", GridViewPocketAllowance.GetRowCellValue(i, "ArrivalDate"))) Then
                    Err.Raise(ErrNumber, , "Arrival Date tidak boleh kosong !")
                End If
                .ArrivalDate = GridViewPocketAllowance.GetRowCellValue(i, "ArrivalDate")
                .Days = GridViewPocketAllowance.GetRowCellValue(i, "Days")
                .RateAllowanceUSD = GridViewPocketAllowance.GetRowCellValue(i, "RateAllowanceUSD")
                .AllowanceUSD = GridViewPocketAllowance.GetRowCellValue(i, "SettlementUSD")
                .AllowanceYEN = GridViewPocketAllowance.GetRowCellValue(i, "SettlementYEN")
                .AllowanceIDR = GridViewPocketAllowance.GetRowCellValue(i, "SettlementIDR")
            End With
            cls_TravelSett.ObjSettleDetail.Add(cls_TravelSettDetail)
        Next

        'Data from grid transportasi
        cls_TravelSett.ObjSettleCost.Clear()
        seq = 0
        For i As Integer = 0 To GridViewTransport.RowCount - 1
            cls_TravelSettCost = New TravelSettleCostModel
            seq = seq + 1
            With cls_TravelSettCost
                .TravelSettleID = travelSettID
                .ID = GridViewTransport.GetRowCellValue(i, "ID")
                .Seq = seq
                .AccountID = IIf(GridViewTransport.GetRowCellValue(i, "AccountID") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(i, "AccountID"))
                If String.IsNullOrEmpty(IIf(GridViewTransport.GetRowCellValue(i, "Date") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(i, "Date"))) Then
                    Err.Raise(ErrNumber, , "Tanggal transport tidak boleh kosong !")
                End If
                .DateCost = IIf(String.IsNullOrEmpty(GridViewTransport.GetRowCellValue(i, "Date")), Nothing, GridViewTransport.GetRowCellValue(i, "Date"))
                .EntertainID = ""
                .TFrom = GridViewTransport.GetRowCellValue(i, "TFrom").ToString()
                .TTo = GridViewTransport.GetRowCellValue(i, "TTo").ToString()
                .Transport = GridViewTransport.GetRowCellValue(i, "Transport").ToString()
                .Description = ""
                .PaymentType = IIf(GridViewTransport.GetRowCellValue(i, "PaymentType").ToString().Substring(0, 2) = "CC", "CREDIT CARD", GridViewTransport.GetRowCellValue(i, "PaymentType").ToString())
                .CreditCardID = GridViewTransport.GetRowCellValue(i, "CreditCardID").ToString()
                .CreditCardNumber = GridViewTransport.GetRowCellValue(i, "CreditCardNumber").ToString()
                .AccountName = GridViewTransport.GetRowCellValue(i, "AccountName").ToString()
                .CurryID = GridViewTransport.GetRowCellValue(i, "CurryID").ToString()
                .Amount = IIf(GridViewTransport.GetRowCellValue(i, "Amount") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewTransport.GetRowCellValue(i, "Amount")))
                .AmountIDR = IIf(GridViewTransport.GetRowCellValue(i, "AmountIDR") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewTransport.GetRowCellValue(i, "AmountIDR")))
            End With
            cls_TravelSett.ObjSettleCost.Add(cls_TravelSettCost)
        Next

        'Data from grid hotel
        seq = 0
        For i As Integer = 0 To GridViewHotel.RowCount - 1
            cls_TravelSettCost = New TravelSettleCostModel
            seq = seq + 1
            With cls_TravelSettCost
                .TravelSettleID = travelSettID
                .ID = GridViewHotel.GetRowCellValue(i, "ID")
                .Seq = seq
                .AccountID = IIf(GridViewHotel.GetRowCellValue(i, "AccountID") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(i, "AccountID"))
                If String.IsNullOrEmpty(IIf(GridViewHotel.GetRowCellValue(i, "Date") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(i, "Date"))) Then
                    Err.Raise(ErrNumber, , "Tanggal Hotel tidak boleh kosong !")
                End If
                .DateCost = GridViewHotel.GetRowCellValue(i, "Date")
                .EntertainID = ""
                .TFrom = ""
                .TTo = ""
                .Transport = ""
                .Description = GridViewHotel.GetRowCellValue(i, "Description").ToString()
                .PaymentType = IIf(GridViewHotel.GetRowCellValue(i, "PaymentType").ToString().Substring(0, 2) = "CC", "CREDIT CARD", GridViewHotel.GetRowCellValue(i, "PaymentType").ToString())
                .CreditCardID = GridViewHotel.GetRowCellValue(i, "CreditCardID").ToString()
                .CreditCardNumber = GridViewHotel.GetRowCellValue(i, "CreditCardNumber").ToString()
                .AccountName = GridViewHotel.GetRowCellValue(i, "AccountName").ToString()
                .CurryID = GridViewHotel.GetRowCellValue(i, "CurryID").ToString()
                .Amount = IIf(GridViewHotel.GetRowCellValue(i, "Amount") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewHotel.GetRowCellValue(i, "Amount")))
                .AmountIDR = IIf(GridViewHotel.GetRowCellValue(i, "AmountIDR") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewHotel.GetRowCellValue(i, "AmountIDR")))
            End With
            cls_TravelSett.ObjSettleCost.Add(cls_TravelSettCost)
        Next

        'Data from grid entertainment
        seq = 0
        For i As Integer = 0 To GridViewEntertain.RowCount - 1
            cls_TravelSettCost = New TravelSettleCostModel
            seq = seq + 1
            With cls_TravelSettCost
                .TravelSettleID = travelSettID
                .ID = GridViewEntertain.GetRowCellValue(i, "ID")
                .Seq = seq
                .AccountID = IIf(GridViewEntertain.GetRowCellValue(i, "AccountID") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(i, "AccountID"))
                If String.IsNullOrEmpty(IIf(GridViewEntertain.GetRowCellValue(i, "Date") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(i, "Date"))) Then
                    Err.Raise(ErrNumber, , "Tanggal Entertain tidak boleh kosong !")
                End If
                .DateCost = GridViewEntertain.GetRowCellValue(i, "Date")
                If String.IsNullOrEmpty(GridViewEntertain.GetRowCellValue(i, "EntertainID").ToString()) Then
                    Err.Raise(ErrNumber, , "Entertain ID tidak boleh kosong !")
                End If
                .EntertainID = GridViewEntertain.GetRowCellValue(i, "EntertainID").ToString()
                .TFrom = ""
                .TTo = ""
                .Transport = ""
                .Description = GridViewEntertain.GetRowCellValue(i, "Description").ToString()
                .PaymentType = IIf(GridViewEntertain.GetRowCellValue(i, "PaymentType").ToString().Substring(0, 2) = "CC", "CREDIT CARD", GridViewEntertain.GetRowCellValue(i, "PaymentType").ToString())
                .CreditCardID = GridViewEntertain.GetRowCellValue(i, "CreditCardID").ToString()
                .CreditCardNumber = GridViewEntertain.GetRowCellValue(i, "CreditCardNumber").ToString()
                .AccountName = GridViewEntertain.GetRowCellValue(i, "AccountName").ToString()
                .CurryID = GridViewEntertain.GetRowCellValue(i, "CurryID").ToString()
                .Amount = IIf(GridViewEntertain.GetRowCellValue(i, "Amount") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewEntertain.GetRowCellValue(i, "Amount")))
                .AmountIDR = IIf(GridViewEntertain.GetRowCellValue(i, "AmountIDR") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewEntertain.GetRowCellValue(i, "AmountIDR")))
            End With
            cls_TravelSett.ObjSettleCost.Add(cls_TravelSettCost)
        Next

        'Data from grid other
        seq = 0
        For i As Integer = 0 To GridViewOther.RowCount - 1
            cls_TravelSettCost = New TravelSettleCostModel
            seq = seq + 1
            With cls_TravelSettCost
                .TravelSettleID = txtTravelSettID.Text
                .ID = GridViewOther.GetRowCellValue(i, "ID")
                .Seq = seq
                .AccountID = IIf(GridViewOther.GetRowCellValue(i, "AccountID") Is DBNull.Value, "", GridViewOther.GetRowCellValue(i, "AccountID"))
                If String.IsNullOrEmpty(IIf(GridViewOther.GetRowCellValue(i, "Date") Is DBNull.Value, "", GridViewOther.GetRowCellValue(i, "Date"))) Then
                    Err.Raise(ErrNumber, , "Tanggal Others tidak boleh kosong !")
                End If
                .DateCost = GridViewOther.GetRowCellValue(i, "Date")
                .EntertainID = ""
                .TFrom = ""
                .TTo = ""
                .Transport = ""
                .Description = GridViewOther.GetRowCellValue(i, "Description").ToString()
                .PaymentType = IIf(GridViewOther.GetRowCellValue(i, "PaymentType").ToString().Substring(0, 2) = "CC", "CREDIT CARD", GridViewOther.GetRowCellValue(i, "PaymentType").ToString())
                .CreditCardID = GridViewOther.GetRowCellValue(i, "CreditCardID").ToString()
                .CreditCardNumber = GridViewOther.GetRowCellValue(i, "CreditCardNumber").ToString()
                .AccountName = GridViewOther.GetRowCellValue(i, "AccountName").ToString()
                .CurryID = GridViewOther.GetRowCellValue(i, "CurryID").ToString()
                .Amount = IIf(GridViewOther.GetRowCellValue(i, "Amount") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewOther.GetRowCellValue(i, "Amount")))
                .AmountIDR = IIf(GridViewOther.GetRowCellValue(i, "AmountIDR") Is DBNull.Value, Nothing, Convert.ToDouble(GridViewOther.GetRowCellValue(i, "AmountIDR")))
            End With
            cls_TravelSett.ObjSettleCost.Add(cls_TravelSettCost)
        Next

    End Sub

#Region "Event From Grid Transportasi"
    Private Sub GridTransport_DoubleClick(sender As Object, e As EventArgs) Handles GridTransport.DoubleClick
        AddNewRow(GridViewTransport, 2)
    End Sub

    Private Sub CDateTransport_EditValueChanged(sender As Object, e As EventArgs) Handles CDateTransport.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CAmountTransport_EditValueChanged(sender As Object, e As EventArgs) Handles CAmountTransport.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double = 1
        Dim CurryID As String
        Amount = IIf(GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "Amount"))
        CurryID = IIf(GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "CurryID"))

        If CurryID = "USD" Then
            Rate = Convert.ToDouble(txtRateUSD.Text)
        ElseIf CurryID = "YEN" Then
            Rate = Convert.ToDouble(txtRateYEN.Text)
        End If
        GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "AmountIDR", Amount * Rate)
        HitungSummaryAll(GridSumTransport, GridViewSumTransport)
        GridBalanceTransport.DataSource = dtBalance
        'GridCellFormat(GridViewBalanceTransport)
    End Sub

    Private Sub CCurryTransport_EditValueChanged(sender As Object, e As EventArgs) Handles CCurryTransport.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double = 1
        Dim CurryID As String
        Amount = IIf(GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "Amount"))
        CurryID = IIf(GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(GridViewTransport.FocusedRowHandle, "CurryID"))

        If CurryID = "USD" Then
            Rate = Convert.ToDouble(txtRateUSD.Text)
        ElseIf CurryID = "YEN" Then
            Rate = Convert.ToDouble(txtRateYEN.Text)
        End If
        GridViewTransport.SetRowCellValue(GridViewTransport.FocusedRowHandle, "AmountIDR", Amount * Rate)
        HitungSummaryAll(GridSumTransport, GridViewSumTransport)
        GridBalanceTransport.DataSource = dtBalance
        'GridCellFormat(GridViewBalanceTransport)
    End Sub

    Private Sub GridViewTransport_KeyDown(sender As Object, e As KeyEventArgs) Handles GridViewTransport.KeyDown
        If e.KeyData = Keys.Delete Then
            GridViewTransport.DeleteRow(GridViewTransport.FocusedRowHandle)
            GridViewTransport.RefreshData()
            HitungSummaryAll(GridSumTransport, GridViewSumTransport)
            GridBalanceTransport.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceTransport)
        End If
        If e.KeyData = Keys.Insert Or e.KeyData = Keys.F1 Then
            AddNewRow(GridViewTransport, 2)
        End If
    End Sub

#End Region

#Region "Event From Grid Hotel"
    Private Sub GridHotel_DoubleClick(sender As Object, e As EventArgs) Handles GridHotel.DoubleClick
        AddNewRow(GridViewHotel, 3)
    End Sub

    Private Sub CDateHotel_EditValueChanged(sender As Object, e As EventArgs) Handles CDateHotel.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CAmountHotel_EditValueChanged(sender As Object, e As EventArgs) Handles CAmountHotel.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double = 1
        Dim CurryID As String

        Amount = IIf(GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "Amount"))
        CurryID = IIf(GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "CurryID"))

        If CurryID = "USD" Then
            Rate = Convert.ToDouble(txtRateUSD.Text)
        ElseIf CurryID = "YEN" Then
            Rate = Convert.ToDouble(txtRateYEN.Text)
        End If

        GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "AmountIDR", Amount * Rate)
        HitungSummaryAll(GridSumHotel, GridViewSumHotel)
        GridBalanceHotel.DataSource = dtBalance
        'GridCellFormat(GridViewBalanceHotel)
    End Sub

    Private Sub CCurryHotel_EditValueChanged(sender As Object, e As EventArgs) Handles CCurryHotel.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double = 1
        Dim CurryID As String

        Amount = IIf(GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "Amount"))
        CurryID = IIf(GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(GridViewHotel.FocusedRowHandle, "CurryID"))

        If CurryID = "USD" Then
            Rate = Convert.ToDouble(txtRateUSD.Text)
        ElseIf CurryID = "YEN" Then
            Rate = Convert.ToDouble(txtRateYEN.Text)
        End If

        GridViewHotel.SetRowCellValue(GridViewHotel.FocusedRowHandle, "AmountIDR", Amount * Rate)
        HitungSummaryAll(GridSumHotel, GridViewSumHotel)
        GridBalanceHotel.DataSource = dtBalance
        'GridCellFormat(GridViewBalanceHotel)
    End Sub

    Private Sub GridViewHotel_KeyDown(sender As Object, e As KeyEventArgs) Handles GridViewHotel.KeyDown
        If e.KeyData = Keys.Delete Then
            GridViewHotel.DeleteRow(GridViewHotel.FocusedRowHandle)
            GridViewHotel.RefreshData()
            HitungSummaryAll(GridSumHotel, GridViewSumHotel)
            GridBalanceHotel.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceHotel)
        End If
        If e.KeyData = Keys.Insert Or e.KeyData = Keys.F1 Then
            AddNewRow(GridViewHotel, 3)
        End If
    End Sub

#End Region

#Region "Event From Grid Entertainment"
    Private Sub GridEntertain_DoubleClick(sender As Object, e As EventArgs) Handles GridEntertain.DoubleClick
        AddNewRow(GridViewEntertain, 4)
    End Sub

    Private Sub CDateEntertain_EditValueChanged(sender As Object, e As EventArgs) Handles CDateEntertain.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CAmountEntertain_EditValueChanged(sender As Object, e As EventArgs) Handles CAmountEntertain.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double

        Amount = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "Amount"))
        Rate = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "Rate") Is DBNull.Value, 1, GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "Rate"))

        GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "AmountIDR", Amount * Rate)
    End Sub

    Private Sub CCurryEntertain_EditValueChanged(sender As Object, e As EventArgs) Handles CCurryEntertain.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub GridViewEntertain_KeyDown(sender As Object, e As KeyEventArgs) Handles GridViewEntertain.KeyDown
        Try
            If e.KeyData = Keys.Delete Then
                Dim entertainID As String = GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "EntertainID")
                GridViewEntertain.DeleteRow(GridViewEntertain.FocusedRowHandle)
                If Not String.IsNullOrEmpty(entertainID) Then
                    'Delete data from tabel entertain
                    cls_TravelSettCost.EntertainID = entertainID
                    cls_TravelSettCost.DeleteSettleEntertain()
                End If
                GridViewEntertain.RefreshData()
                HitungSummaryAll(GridSumEntertain, GridViewSumEntertain)
                GridBalanceEntertain.DataSource = dtBalance
                'GridCellFormat(GridViewBalanceEntertain)
            End If
            If e.KeyData = Keys.Insert Or e.KeyData = Keys.F1 Then
                AddNewRow(GridViewEntertain, 4)
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub

#End Region

#Region "Event From Grid Others"
    Private Sub GridOther_DoubleClick(sender As Object, e As EventArgs) Handles GridOther.DoubleClick
        AddNewRow(GridViewOther, 7)
    End Sub

    Private Sub CDateOther_EditValueChanged(sender As Object, e As EventArgs) Handles CDateOther.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CAmountOther_EditValueChanged(sender As Object, e As EventArgs) Handles CAmountOther.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double = 1
        Dim CurryID As String

        Amount = IIf(GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "Amount"))
        CurryID = IIf(GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "CurryID"))

        If CurryID = "USD" Then
            Rate = Convert.ToDouble(txtRateUSD.Text)
        ElseIf CurryID = "YEN" Then
            Rate = Convert.ToDouble(txtRateYEN.Text)
        End If

        GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "AmountIDR", Amount * Rate)
        HitungSummaryAll(GridSumOthers, GridViewSumOthers)
        GridBalanceOther.DataSource = dtBalance
        'GridCellFormat(GridViewBalanceOther)
    End Sub

    Private Sub CCurryOther_EditValueChanged(sender As Object, e As EventArgs) Handles CCurryOther.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim Amount As Double
        Dim Rate As Double = 1
        Dim CurryID As String

        Amount = IIf(GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "Amount"))
        CurryID = IIf(GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewOther.GetRowCellValue(GridViewOther.FocusedRowHandle, "CurryID"))

        If CurryID = "USD" Then
            Rate = Convert.ToDouble(txtRateUSD.Text)
        ElseIf CurryID = "YEN" Then
            Rate = Convert.ToDouble(txtRateYEN.Text)
        End If

        GridViewOther.SetRowCellValue(GridViewOther.FocusedRowHandle, "AmountIDR", Amount * Rate)
        HitungSummaryAll(GridSumOthers, GridViewSumOthers)
        GridBalanceOther.DataSource = dtBalance
        'GridCellFormat(GridViewBalanceOther)
    End Sub

    Private Sub GridViewOther_KeyDown(sender As Object, e As KeyEventArgs) Handles GridViewOther.KeyDown
        If e.KeyData = Keys.Delete Then
            GridViewOther.DeleteRow(GridViewOther.FocusedRowHandle)
            GridViewOther.RefreshData()
            HitungSummaryAll(GridSumOthers, GridViewSumOthers)
            GridBalanceOther.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceOther)
        End If
        If e.KeyData = Keys.Insert Or e.KeyData = Keys.F1 Then
            AddNewRow(GridViewOther, 7)
        End If
    End Sub

#End Region

#Region "Event From Grid Pocket Allowance"
    Private Sub CDepartureDate_EditValueChanged(sender As Object, e As EventArgs) Handles CDepartureDate.EditValueChanged
        Dim _departureDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate"))
        Dim _arrivalDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate"))

        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim departureDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate"))
        Dim arrivalDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate"))
        Dim rateAllowanceUSD As Double = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceUSD") Is DBNull.Value, 0, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceUSD"))

        If departureDate > arrivalDate And arrivalDate <> Nothing Then
            MessageBox.Show("Departure Date tidak boleh lebih besar dari Arrival Date", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate", _departureDate)
            departureDate = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate"))
        End If

        Dim Days As Integer = DateDiff(DateInterval.Day, departureDate, arrivalDate) + 1
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "Days", Days)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD", rateAllowanceUSD * Days)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN", 0)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR", 0)
    End Sub

    Private Sub CArrivalDate_EditValueChanged(sender As Object, e As EventArgs) Handles CArrivalDate.EditValueChanged
        Dim _departureDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate"))
        Dim _arrivalDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate"))

        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim departureDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "DepartureDate"))
        Dim arrivalDate As Date = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate"))
        Dim rateAllowanceUSD As Double = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceUSD") Is DBNull.Value, 0, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceUSD"))

        If arrivalDate < departureDate Then
            MessageBox.Show("Arrival Date tidak boleh lebih kecil dari Departure Date", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate", _arrivalDate)
            arrivalDate = IIf(GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate") Is DBNull.Value, Nothing, GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "ArrivalDate"))
        End If

        Dim Days As Integer = DateDiff(DateInterval.Day, departureDate, arrivalDate) + 1
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "Days", Days)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD", rateAllowanceUSD * Days)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN", 0)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR", 0)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceIDR", (rateAllowanceUSD * Days) * txtRateUSD.Text)
        GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "TotalAllowanceIDR", (rateAllowanceUSD * Days) * txtRateUSD.Text)
    End Sub

    Private Sub CAdvanceUSD_EditValueChanged(sender As Object, e As EventArgs) Handles CAdvanceUSD.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CAdvanceYEN_EditValueChanged(sender As Object, e As EventArgs) Handles CAdvanceYEN.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CAdvanceIDR_EditValueChanged(sender As Object, e As EventArgs) Handles CAdvanceIDR.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub CSettlementUSD_EditValueChanged(sender As Object, e As EventArgs) Handles CSettlementUSD.EditValueChanged
        Dim amountUSDBefore As Double
        Dim amountUSDAfter As Double
        Dim amountIDR As Double
        Dim amountYEN As Double
        Dim totalAmountIDR As Double
        Dim rateAllowanceIDR As Double
        amountUSDBefore = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD")
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        amountUSDAfter = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD")
        amountYEN = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN")
        rateAllowanceIDR = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceIDR")
        amountIDR = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR")

        totalAmountIDR = (amountUSDAfter * txtRateUSD.Text) + (amountYEN * txtRateYEN.Text)
        amountIDR = rateAllowanceIDR - totalAmountIDR
        If rateAllowanceIDR < totalAmountIDR Then
            MessageBox.Show("Total Amount Melebihi Rate Pocket Allowance !",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD", amountUSDBefore)
        Else
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR", amountIDR)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "TotalAllowanceIDR", totalAmountIDR + amountIDR)
        End If
    End Sub

    Private Sub CSettlementYEN_EditValueChanged(sender As Object, e As EventArgs) Handles CSettlementYEN.EditValueChanged
        Dim amountYENBefore As Double
        Dim amountYENAfter As Double
        Dim amountUSD As Double
        Dim amountIDR As Double
        Dim totalAmountIDR As Double
        Dim rateAllowanceIDR As Double
        amountYENBefore = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN")
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
        amountYENAfter = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN")
        rateAllowanceIDR = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceIDR")
        amountUSD = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD")
        amountIDR = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR")

        totalAmountIDR = (amountYENAfter * txtRateYEN.Text) + (amountUSD * txtRateUSD.Text)
        amountIDR = rateAllowanceIDR - totalAmountIDR

        If rateAllowanceIDR < totalAmountIDR Then
            MessageBox.Show("Total Amount Melebihi Rate Pocket Allowance !",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN", amountYENBefore)
        Else
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR", amountIDR)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "TotalAllowanceIDR", totalAmountIDR + amountIDR)
        End If
    End Sub

    Private Sub CSettlementIDR_EditValueChanged(sender As Object, e As EventArgs) Handles CSettlementIDR.EditValueChanged
        Dim amountIDRBefore As Double
        Dim amountIDRAfter As Double
        Dim amountUSD As Double
        Dim amountYEN As Double
        Dim totalAmountIDR As Double
        Dim rateAllowanceIDR As Double
        amountIDRBefore = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR")
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
        rateAllowanceIDR = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "RateAllowanceIDR")
        amountIDRAfter = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR")
        amountUSD = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementUSD")
        amountYEN = GridViewPocketAllowance.GetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementYEN")

        totalAmountIDR = (amountUSD * txtRateUSD.Text) + (amountYEN * txtRateYEN.Text) + amountIDRAfter

        If rateAllowanceIDR < totalAmountIDR Then
            MessageBox.Show("Total Amount Melebihi Rate Pocket Allowance !",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "SettlementIDR", amountIDRBefore)
        Else
            GridViewPocketAllowance.SetRowCellValue(GridViewPocketAllowance.FocusedRowHandle, "TotalAllowanceIDR", totalAmountIDR)
        End If
    End Sub

#End Region

    Private Sub AddNewRow(ByVal view As GridView, ByVal ID As Integer)
        view.AddNewRow()
        view.OptionsNavigation.AutoFocusNewRow = True
        'GridCellFormat(view)
        Dim defaultAccount As String
        If view Is GridViewEntertain Then
            defaultAccount = "62300"
        Else
            defaultAccount = "62250"
        End If

        Dim defaultCurryID As String
        If txtTravelType.Text = "DN" Then
            defaultCurryID = "IDR"
        Else
            defaultCurryID = "YEN"
        End If

        view.SetRowCellValue(view.FocusedRowHandle, "ID", ID)
        view.SetRowCellValue(view.FocusedRowHandle, "AccountID", defaultAccount)
        view.SetRowCellValue(view.FocusedRowHandle, "SubAccount", "")
        view.SetRowCellValue(view.FocusedRowHandle, "Date", TxtDepDate.EditValue)
        view.SetRowCellValue(view.FocusedRowHandle, "TFrom", "")
        view.SetRowCellValue(view.FocusedRowHandle, "TTo", "")
        view.SetRowCellValue(view.FocusedRowHandle, "Transport", "")
        view.SetRowCellValue(view.FocusedRowHandle, "EntertainID", "")
        view.SetRowCellValue(view.FocusedRowHandle, "Description", "")
        view.SetRowCellValue(view.FocusedRowHandle, "PaymentType", "CASH")
        view.SetRowCellValue(view.FocusedRowHandle, "CreditCardID", "")
        view.SetRowCellValue(view.FocusedRowHandle, "CreditCardNumber", "")
        view.SetRowCellValue(view.FocusedRowHandle, "AccountName", "")
        view.SetRowCellValue(view.FocusedRowHandle, "CurryID", defaultCurryID)
        view.SetRowCellValue(view.FocusedRowHandle, "Amount", 0)
        view.SetRowCellValue(view.FocusedRowHandle, "AmountIDR", 0)
        'GridCellFormat(view)
    End Sub

    Private Sub CreateTable()
        dtSummary = New DataTable
        dtSummary.Columns.AddRange(New DataColumn(6) {New DataColumn("Description", GetType(String)),
                                                            New DataColumn("CashIDR", GetType(Double)),
                                                            New DataColumn("CashUSD", GetType(Double)),
                                                            New DataColumn("CashYEN", GetType(Double)),
                                                            New DataColumn("CreditIDR", GetType(Double)),
                                                            New DataColumn("CreditUSD", GetType(Double)),
                                                            New DataColumn("CreditYEN", GetType(Double))})

        dtBalance = New DataTable
        dtBalance.Columns.AddRange(New DataColumn(2) {New DataColumn("BalanceUSD", GetType(Double)),
                                                            New DataColumn("BalanceYEN", GetType(Double)),
                                                            New DataColumn("BalanceIDR", GetType(Double))})

        dtVoucher = New DataTable
        dtVoucher.Columns.AddRange(New DataColumn(6) {New DataColumn("CurryID", GetType(String)),
                                                            New DataColumn("Advance", GetType(Double)),
                                                            New DataColumn("Actual", GetType(Double)),
                                                            New DataColumn("SisaBalance", GetType(Double)),
                                                            New DataColumn("ReturnBalance", GetType(Double)),
                                                            New DataColumn("PaidBalance", GetType(Double)),
                                                            New DataColumn("AmountIDRBalance", GetType(Double))})
    End Sub

    Private Sub FrmTravelSettleDetail_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If flag = 1 Then
            'Dim EntertainID As String
            'Dim IDSettle As String = String.Empty
            Dim jumlah As Double
            Dim rate As Double = 1
            Dim curryID As String

            'EntertainID = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "EntertainID") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "EntertainID"))

            'If EntertainID <> "" Then
            '    IDSettle = ObjTravelSettDetail.GetSettleID(EntertainID)
            '    GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "IDSettle", IDSettle)
            'End If

            jumlah = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "Amount") Is DBNull.Value, 0, GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "Amount"))
            curryID = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "CurryID") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "CurryID"))
            'vrate = IIf(GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "RateSett") Is DBNull.Value, 1, GridViewEntertain.GetRowCellValue(GridViewEntertain.FocusedRowHandle, "RateSett"))
            If curryID = "USD" Then
                rate = txtRateUSD.Text
            ElseIf curryID = "YEN" Then
                rate = txtRateYEN.Text
            End If
            GridViewEntertain.SetRowCellValue(GridViewEntertain.FocusedRowHandle, "AmountIDR", jumlah * rate)
            HitungSummaryAll(GridSumEntertain, GridViewSumEntertain)
            GridBalanceEntertain.DataSource = dtBalance
            flag = 0
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TabPage = XtraTabControl1.SelectedTabPage.Name()
        If TabPage = "TabPageTransport" Then
            GridSumTransport.DataSource = dtSummary
            'GridCellFormat(GridViewSumTransport)

            GridBalanceTransport.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceTransport)

        ElseIf TabPage = "TabPageHotel" Then
            GridSumHotel.DataSource = dtSummary
            'GridCellFormat(GridViewSumHotel)

            GridBalanceHotel.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceHotel)
        ElseIf TabPage = "TabPageEntertain" Then
            GridSumEntertain.DataSource = dtSummary
            'GridCellFormat(GridViewSumEntertain)

            GridBalanceEntertain.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceEntertain)
        ElseIf TabPage = "TabPageOthers" Then
            GridSumOthers.DataSource = dtSummary
            'GridCellFormat(GridViewSumOthers)

            GridBalanceOther.DataSource = dtBalance
            'GridCellFormat(GridViewBalanceOther)
        ElseIf TabPage = "TabPageVoucher" Then
            GridSumBalance.DataSource = dtSummary
            'GridCellFormat(GridViewSumBalance)

            HitungAmountBalance()
        End If
    End Sub

    Private Sub HitungSummaryAll(ByVal gridSum As GridControl, ByVal viewSum As GridView)
        dtSummary.Clear()
        HitungSummary(GridViewTransport)
        dtSummary.Rows.Add("TRANSPORTATION FEE", CashIDR, CashUSD, CashYEN, CreditIDR, CreditUSD, CreditYEN)
        HitungSummary(GridViewHotel)
        dtSummary.Rows.Add("STAYING FEE", CashIDR, CashUSD, CashYEN, CreditIDR, CreditUSD, CreditYEN)
        HitungSummary(GridViewEntertain)
        dtSummary.Rows.Add("ENTERTAINMENT", CashIDR, CashUSD, CashYEN, CreditIDR, CreditUSD, CreditYEN)
        HitungSummary(GridViewOther)
        dtSummary.Rows.Add("OTHERS", CashIDR, CashUSD, CashYEN, CreditIDR, CreditUSD, CreditYEN)

        gridSum.DataSource = dtSummary
        'GridCellFormat(viewSum)

        Dim balanceUSD As Double = Convert.ToDouble(TxtTotalAdvanceUSD.Text) - viewSum.Columns("CashUSD").SummaryItem.SummaryValue
        Dim balanceYEN As Double = Convert.ToDouble(TxtTotalAdvanceYEN.Text) - viewSum.Columns("CashYEN").SummaryItem.SummaryValue
        Dim balanceIDR As Double = Convert.ToDouble(TxtTotalAdvanceIDR.Text) - viewSum.Columns("CashIDR").SummaryItem.SummaryValue

        dtBalance.Clear()
        dtBalance.Rows.Add(balanceUSD, balanceYEN, balanceIDR)
    End Sub

    Private Sub HitungSummary(ByVal view As GridView)
        Try
            CashIDR = 0
            CashUSD = 0
            CashYEN = 0
            CreditIDR = 0
            CreditUSD = 0
            CreditYEN = 0

            For i As Integer = 0 To view.RowCount - 1
                Dim payType As String = IIf(view.GetRowCellValue(i, "PaymentType") Is DBNull.Value, "", view.GetRowCellValue(i, "PaymentType"))
                Dim curryID As String = IIf(view.GetRowCellValue(i, "CurryID") Is DBNull.Value, "", view.GetRowCellValue(i, "CurryID"))
                Dim amount As Double = IIf(view.GetRowCellValue(i, "Amount") Is DBNull.Value, 0, Convert.ToDouble(view.GetRowCellValue(i, "Amount")))

                If payType = "CASH" And curryID = "IDR" Then
                    CashIDR = CashIDR + amount
                ElseIf payType = "CASH" And curryID = "USD" Then
                    CashUSD = CashUSD + amount
                ElseIf payType = "CASH" And curryID = "YEN" Then
                    CashYEN = CashYEN + amount
                ElseIf (payType = "CREDIT CARD" Or payType.Substring(0, 2) = "CC") And curryID = "IDR" Then
                    CreditIDR = CreditIDR + amount
                ElseIf (payType = "CREDIT CARD" Or payType.Substring(0, 2) = "CC") And curryID = "USD" Then
                    CreditUSD = CreditUSD + amount
                ElseIf (payType = "CREDIT CARD" Or payType.Substring(0, 2) = "CC") And curryID = "YEN" Then
                    CreditYEN = CreditYEN + amount
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub HitungAmountDetail()
        Try
            Dim curryID As String
            Dim amount As Double
            Dim Rate As Double = 1

            For i As Integer = 0 To GridViewTransport.RowCount - 1
                curryID = IIf(GridViewTransport.GetRowCellValue(i, "CurryID") Is DBNull.Value, "", GridViewTransport.GetRowCellValue(i, "CurryID"))
                amount = IIf(GridViewTransport.GetRowCellValue(i, "Amount") Is DBNull.Value, 0, Convert.ToDecimal(GridViewTransport.GetRowCellValue(i, "Amount")))

                If curryID = "USD" Then
                    Rate = Convert.ToDouble(txtRateUSD.Text)
                ElseIf curryID = "YEN" Then
                    Rate = Convert.ToDouble(txtRateYEN.Text)
                End If
                GridViewTransport.SetRowCellValue(i, "AmountIDR", amount * Rate)
            Next

            For i As Integer = 0 To GridViewHotel.RowCount - 1
                curryID = IIf(GridViewHotel.GetRowCellValue(i, "CurryID") Is DBNull.Value, "", GridViewHotel.GetRowCellValue(i, "CurryID"))
                amount = IIf(GridViewHotel.GetRowCellValue(i, "Amount") Is DBNull.Value, 0, Convert.ToDecimal(GridViewHotel.GetRowCellValue(i, "Amount")))

                If curryID = "USD" Then
                    Rate = Convert.ToDouble(txtRateUSD.Text)
                ElseIf curryID = "YEN" Then
                    Rate = Convert.ToDouble(txtRateYEN.Text)
                End If
                GridViewHotel.SetRowCellValue(i, "AmountIDR", amount * Rate)
            Next

            For i As Integer = 0 To GridViewEntertain.RowCount - 1
                curryID = IIf(GridViewEntertain.GetRowCellValue(i, "CurryID") Is DBNull.Value, "", GridViewEntertain.GetRowCellValue(i, "CurryID"))
                amount = IIf(GridViewEntertain.GetRowCellValue(i, "Amount") Is DBNull.Value, 0, Convert.ToDecimal(GridViewEntertain.GetRowCellValue(i, "Amount")))

                If curryID = "USD" Then
                    Rate = Convert.ToDouble(txtRateUSD.Text)
                ElseIf curryID = "YEN" Then
                    Rate = Convert.ToDouble(txtRateYEN.Text)
                End If
                GridViewEntertain.SetRowCellValue(i, "AmountIDR", amount * Rate)
            Next

            For i As Integer = 0 To GridViewOther.RowCount - 1
                curryID = IIf(GridViewOther.GetRowCellValue(i, "CurryID") Is DBNull.Value, "", GridViewOther.GetRowCellValue(i, "CurryID"))
                amount = IIf(GridViewOther.GetRowCellValue(i, "Amount") Is DBNull.Value, 0, Convert.ToDecimal(GridViewOther.GetRowCellValue(i, "Amount")))

                If curryID = "USD" Then
                    Rate = Convert.ToDouble(txtRateUSD.Text)
                ElseIf curryID = "YEN" Then
                    Rate = Convert.ToDouble(txtRateYEN.Text)
                End If
                GridViewOther.SetRowCellValue(i, "AmountIDR", amount * Rate)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub HitungAmountBalance()
        Dim BalanceUSD As Double
        Dim BalanceYEN As Double
        Dim BalanceIDR As Double
        Dim ReturnUSD As Double
        Dim ReturnYEN As Double
        Dim ReturnIDR As Double
        Dim PaidUSD As Double
        Dim PaidYEN As Double
        Dim PaidIDR As Double

        BalanceUSD = GridViewBalanceTransport.GetRowCellValue(0, "BalanceUSD")
        BalanceYEN = GridViewBalanceTransport.GetRowCellValue(0, "BalanceYEN")
        BalanceIDR = GridViewBalanceTransport.GetRowCellValue(0, "BalanceIDR")

        If GridViewBalance.RowCount > 0 Then
            For i As Integer = 0 To GridViewBalance.RowCount - 1
                Dim curryID As String = GridViewBalance.GetRowCellValue(i, "CurryID")
                If curryID = "USD" Then
                    ReturnUSD = GridViewBalance.GetRowCellValue(i, "ReturnBalance")
                ElseIf curryID = "YEN" Then
                    ReturnYEN = GridViewBalance.GetRowCellValue(i, "ReturnBalance")
                ElseIf curryID = "IDR" Then
                    ReturnIDR = GridViewBalance.GetRowCellValue(i, "ReturnBalance")
                End If
            Next
        End If
        PaidUSD = BalanceUSD - ReturnUSD
        PaidYEN = BalanceYEN - ReturnYEN
        PaidIDR = BalanceIDR - ReturnIDR

        dtVoucher.Clear()
        dtVoucher.Rows.Add("USD", Convert.ToDouble(TxtTotalAdvanceUSD.Text), GridViewSumTransport.Columns("CashUSD").SummaryItem.SummaryValue, BalanceUSD, ReturnUSD, PaidUSD, PaidUSD * Convert.ToDouble(txtRateUSD.Text))
        dtVoucher.Rows.Add("YEN", Convert.ToDouble(TxtTotalAdvanceYEN.Text), GridViewSumTransport.Columns("CashYEN").SummaryItem.SummaryValue, BalanceYEN, ReturnYEN, PaidYEN, PaidYEN * Convert.ToDouble(txtRateYEN.Text))
        dtVoucher.Rows.Add("IDR", Convert.ToDouble(TxtTotalAdvanceIDR.Text), GridViewSumTransport.Columns("CashIDR").SummaryItem.SummaryValue, BalanceIDR, ReturnIDR, PaidIDR, PaidIDR)
        GridBalance.DataSource = dtVoucher
        'GridCellFormat(GridViewBalance)
    End Sub

    Private Sub CReturnBalance_EditValueChanged(sender As Object, e As EventArgs) Handles CReturnBalance.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim curryID As String
        Dim balance As Double
        Dim return_ As Double
        curryID = GridViewBalance.GetRowCellValue(GridViewBalance.FocusedRowHandle, "CurryID")
        balance = IIf(GridViewBalance.GetRowCellValue(GridViewBalance.FocusedRowHandle, "SisaBalance") Is DBNull.Value, 0, GridViewBalance.GetRowCellValue(GridViewBalance.FocusedRowHandle, "SisaBalance"))
        return_ = IIf(GridViewBalance.GetRowCellValue(GridViewBalance.FocusedRowHandle, "ReturnBalance") Is DBNull.Value, 0, GridViewBalance.GetRowCellValue(GridViewBalance.FocusedRowHandle, "ReturnBalance"))
        GridViewBalance.SetRowCellValue(GridViewBalance.FocusedRowHandle, "PaidBalance", balance - return_)
        If curryID = "USD" Then
            ReturnUSD = return_
            GridViewBalance.SetRowCellValue(GridViewBalance.FocusedRowHandle, "AmountIDRBalance", (balance - return_) * Convert.ToDouble(txtRateUSD.Text))
        ElseIf curryID = "YEN" Then
            ReturnYEN = return_
            GridViewBalance.SetRowCellValue(GridViewBalance.FocusedRowHandle, "AmountIDRBalance", (balance - return_) * Convert.ToDouble(txtRateYEN.Text))
        ElseIf curryID = "IDR" Then
            ReturnIDR = return_
            GridViewBalance.SetRowCellValue(GridViewBalance.FocusedRowHandle, "AmountIDRBalance", balance - return_)
        End If
    End Sub

End Class