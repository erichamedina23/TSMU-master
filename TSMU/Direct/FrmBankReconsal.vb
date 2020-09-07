Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Public Class FrmBankReconsal
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim ff_Detail As FrmDetailPaymentDirect1
    Dim ff_Detail2 As FrmDetailPaymentSuspend
    Dim ff_Detail3 As FrmDetailPaymentSettle
    Dim ff_Detail4 As FrmDetailPaymentSuspend
    Dim ff_Detail5 As FrmEditDirectPayment
    Dim ff_Detail6 As FrmBankPaid
    Dim ff_Detail7 As frm_payment_aprrove_details
    Dim ff_Detail8 As FrmBankReceipt_Detail
    Dim ff_Detail9 As FrmDetailPaymentDirect1
    Dim ObjCashBank As New cashbank_models
    Dim ObjSaldoAwal As New saldo_awal_models
    Dim GridDtl As GridControl
    Dim NoBukti As String
    Dim ObjPayment As New cashbank_models
    Dim tempacct As String
    Dim tempperpost As String = Format(DateTime.Today, "yyyy-MM")
    Dim level As Integer = 0
    Dim _Tag As TagModel
    'Dim ID As String
    'Dim suspendid As String
    'Dim suspend1 As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form)
        ' this call is required by the windows form designer
        Me.New()
        If strCode <> "" Then
            fs_Code = strCode
            fs_Code2 = strCode2
            ' bi_GridParentRow = li_GridRow
        End If
        InitialSetForm()
        '   FrmParent = lf_FormParent
        FrmParent = lf_FormParent
        _Tag = New TagModel
        _Tag.PageIndex = lf_FormParent.Tag.PageIndex
        Tag = _Tag

    End Sub
    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "" Then
                ''ObjPayment.ID = fs_Code
                ' ObjPayment.GetSettleById()
                ObjPayment.Perpost = fs_Code
                ObjPayment.AcctID = fs_Code2
                _txtperpost.Text = fs_Code
                _txtaccount.Text = fs_Code2
                ObjPayment.GetGridDetailCashBankReconsal()

                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                Me.Text = "Cash Bank " & fs_Code
            Else
                Me.Text = "Cash Bank"
            End If
            Call LoadTxtBox()
            '' LoadGridDetail()
            DataCashBank()
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = FrmParent.Name.ToString
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub LoadTxtBox()
        Try
            If fs_Code <> "" Then
                With ObjPayment
                    _txtperpost.Text = .Perpost
                    _txtaccount.Text = .AcctID
                End With
            Else
                _txtperpost.Text = ""
                _txtaccount.Text = ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub coba()
        If _txtaccount.Text = "" Then
        Else
            ObjCashBank.Perpost = _txtperpost.Text
            ObjCashBank.AcctID = _txtaccount.Text
            ObjCashBank.account = _txtaccount.Text
        End If

        _txtaccountname.Text = ObjCashBank.GetNamaAccountbyid()
        Dim saldo As Double
        saldo = ObjCashBank.saldo2
        If saldo = 0 Then
            _txtsaldo.Text = saldo
        Else
            _txtsaldo.Text = Format(saldo, "#,#.##")
        End If
        Call DataCashBank()


        For b As Integer = 0 To GridView1.RowCount - 1

            If GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString = "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                End If

            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString = "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            Else
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")))
                End If
            End If
        Next
        Call DataSuspend()
    End Sub
    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles _txtaccount.EditValueChanged
        If _txtaccount.Text = "" Then
        Else
            ObjCashBank.Perpost = _txtperpost.Text
            ObjCashBank.AcctID = _txtaccount.Text
            ObjCashBank.account = _txtaccount.Text
        End If


        ''      ObjCashBank.curyid = Trim(_txtcuryid.Text)

        _txtaccountname.Text = ObjCashBank.GetNamaAccountbyid()
        Dim saldo As Double
        saldo = ObjCashBank.saldo2
        If saldo = 0 Then
            _txtsaldo.Text = saldo
        Else
            _txtsaldo.Text = Format(saldo, "#,#.##")
        End If
        '' _txtsaldo.Text = ObjCashBank.saldo2
        'If _txtsaldo.Text = "0" Then
        '    _txtsaldo.Text = "0"
        'Else
        ''_txtsaldo.Text = Format(Val(_txtsaldo.Text), "#,#.##")
        'End If
        'Dim dtGrid As New DataTable
        'dtGrid = suspen.GetGridDetailSuspendPaymentByAccountID

        'If dtGrid.Rows.Count > 0 Then
        '    GridControl1.DataSource = dtGrid
        '    GridCellFormat(GridView1)
        'End If
        Call DataCashBank()


        For b As Integer = 0 To GridView1.RowCount - 1
            'If GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString = "0" Then
            '    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
            'Else
            '    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
            'End If
            If GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString = "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                End If

            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString = "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            Else
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")))
                End If
            End If
        Next
        Call DataSuspend()
    End Sub
    Private Sub DataSuspend()

    End Sub
    Private Sub refresbank()

        _txtaccountname.Text = ObjCashBank.GetNamaAccountbyid()
        Dim saldo As Double
        saldo = ObjCashBank.saldo2
        If saldo = 0 Then
            _txtsaldo.Text = saldo
        Else
            _txtsaldo.Text = Format(saldo, "#,#.##")
        End If

        Call DataCashBank()


        For b As Integer = 0 To GridView1.RowCount - 1

            If GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString = "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                End If

            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString = "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            Else
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")))
                End If
            End If
        Next
    End Sub


    Private Sub CallFrm(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0, Optional ByVal IsNew As Boolean = True)
        If ff_Detail7 IsNot Nothing AndAlso ff_Detail7.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail7.Close()
        End If
        ff_Detail7 = New frm_payment_aprrove_details(ls_Code, ls_Code2, Me, li_Row, GridControl1, IsNew)
        ff_Detail7.MdiParent = FrmMain
        ff_Detail7.StartPosition = FormStartPosition.CenterScreen
        ff_Detail7.Show()
    End Sub

    Private Sub CallFrm2(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal ls_Code3 As String = "", Optional ByVal ls_Code4 As String = "", Optional ByVal sts_skreen As Byte = 1, Optional ByVal li_Row As Integer = 0)
        If ff_Detail8 IsNot Nothing AndAlso ff_Detail8.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail8.Close()
        End If
        ff_Detail8 = New FrmBankReceipt_Detail(ls_Code, ls_Code2, ls_Code3, ls_Code4, sts_skreen, Me, li_Row, GridControl1)
        ff_Detail8.MdiParent = FrmMain
        ff_Detail8.StartPosition = FormStartPosition.CenterScreen
        ff_Detail8.Show()
    End Sub

    Private Sub CallFrm3(Optional ByVal ls_Code As String = "", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0, Optional ByVal IsNew As Boolean = True)
        If ff_Detail9 IsNot Nothing AndAlso ff_Detail9.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail9.Close()
        End If
        ff_Detail9 = New FrmDetailPaymentDirect1(ls_Code, ls_Code2, Me, li_Row, GridControl1, IsNew)
        ff_Detail9.MdiParent = FrmMain
        ff_Detail9.StartPosition = FormStartPosition.CenterScreen
        ff_Detail9.Show()
    End Sub
    Private Sub DataCashBank()
        Dim dtGrid As New DataTable
        ObjCashBank.Perpost = _txtperpost.Text
        ObjCashBank.AcctID = _txtaccount.Text
        dtGrid = ObjCashBank.GetGridDetailCashBankReconsal

        If dtGrid.Rows.Count > 0 Then
            GridControl1.DataSource = dtGrid
            GridCellFormat(GridView1)
        Else
            GridControl1.DataSource = dtGrid
            GridCellFormat(GridView1)
        End If
    End Sub
    Private Sub TextEdit2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles _txtaccount.ButtonClick
        Try
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""

            Dim ObjSuspend As New ClsSuspend
            If sender.Name = _txtaccount.Name Then
                dtSearch = ObjSuspend.GetBank
                ls_OldKode = _txtaccount.Text.Trim
                ls_Judul = "Account"
            End If

            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select Data " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim Value1 As String = ""
            Dim Value2 As String = ""
            Dim Value3 As String = ""
            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then

                If sender.Name = _txtaccount.Name AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> "" AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then
                    Value1 = lF_SearchData.Values.Item(0).ToString.Trim
                    Value2 = lF_SearchData.Values.Item(1).ToString.Trim
                    Value3 = lF_SearchData.Values.Item(2).ToString.Trim
                    _txtaccount.Text = Value1
                    _txtaccountname.Text = Value2
                    _txtcuryid.Text = Value3
                    ObjCashBank.curyid = Value3

                End If
            End If
            lF_SearchData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub FrmBankReconsal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _txtperpost.EditValue = Format(DateTime.Today, "yyyy-MM")
        _txtperpost.Text = tempperpost
        _txtaccount.Text = tempacct
        DataCashBank()


        level = ObjCashBank.GetUsernameLevel

    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(sender As Object, e As EventArgs)
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub


    Public Overrides Sub Proc_SaveData()
        Try

            For i As Integer = 0 To GridView1.RowCount - 1
                '      If GridView1.GetRowCellValue(i, "cek") = True Then
                With ObjCashBank
                    .cek = CBool(GridView1.GetRowCellValue(i, "cek"))
                    .recon = CBool(GridView1.GetRowCellValue(i, "recon"))
                    .NoBukti = CStr(GridView1.GetRowCellValue(i, "NoBukti"))
                    .UpdateCek()
                    .UpdateRecon()
                End With
                ''       End If
            Next
            Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            tsBtn_refresh.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        _txtperpost.EditValue = Format(DateTime.Today, "yyyy-MM")

        refresbank()

        DataSuspend()

    End Sub

    Private Sub ReposPresesSettle_EditValueChanged(sender As Object, e As EventArgs)
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemCheckEdit2_EditValueChanged(sender As Object, e As EventArgs)
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemCheckEdit5_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit5.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemCheckEdit6_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit6.EditValueChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub
    Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick
        Dim id As String = String.Empty
        Dim id2 As String = String.Empty
        Dim ket As String = String.Empty
        Dim selectedRows() As Integer = GridView1.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                id = GridView1.GetRowCellValue(rowHandle, "NoBukti")
                ket = Mid(GridView1.GetRowCellValue(rowHandle, "NoBukti"), 1, 2)
                id2 = GridView1.GetRowCellValue(rowHandle, "ID")
            End If
        Next rowHandle

        If ket = "AP" Then
            Call CallFrm(id2, id,
                         GridView1.RowCount)
        Else
            ''    ff_Detail = New FrmDetailPaymentDirect1(id)
            ''    ff_Detail.Show()
            Call CallFrm3(id2, id,
                         GridView1.RowCount)
            ' this call is required by the windows form designer

        End If

    End Sub
    Private Sub EditRek_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles EditRek.ButtonClick
        Dim id5 As String = String.Empty
        Dim selectedRows() As Integer = GridView1.GetSelectedRows()
        For Each rowHandle As Integer In selectedRows
            If rowHandle >= 0 Then
                id5 = GridView1.GetRowCellValue(rowHandle, "NoBukti")
            End If
        Next rowHandle
        ff_Detail5 = New FrmEditDirectPayment(id5)
        ff_Detail5.ShowDialog()

        _txtperpost.Text = ff_Detail5.Perpost
        _txtaccount.Text = ff_Detail5.Rekening
        tempperpost = ff_Detail5.Perpost
        tempacct = ff_Detail5.Rekening
        tsBtn_refresh.PerformClick()
    End Sub


    Public Overrides Sub Proc_DeleteData()
        Dim ID As String = String.Empty
        Dim transaksi As String = String.Empty
        Dim ObjDetails As New cashbank_models
        Try
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    ID = GridView1.GetRowCellValue(rowHandle, "NoBukti")
                    transaksi = Trim(GridView1.GetRowCellValue(rowHandle, "Transaksi"))
                End If
            Next rowHandle
            ObjDetails.ID = ID

            If transaksi = "Advance" Then
                ObjDetails.UpdateSuspend_hapus()
            ElseIf transaksi = "Settle" Then
                ObjDetails.UpdateSettle_hapus()
            End If
            ObjDetails.Delete()

            Call DataCashBank()
            Call ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
            tsBtn_refresh.PerformClick()
            'Grid.RemoveItem(Grid.Row)
            'If Grid.Rows.Count > Grid.Rows.Fixed Then
            '    Call Proc_EnableButtons(True, False, True, True, True, True, False, False)
            'Else
            '    Call Proc_EnableButtons(True, False, False, True, True, True, False, False)
            'End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub



    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try

            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As BaseView = GridControl1.GetViewAt(ea.Location)
            If view Is Nothing Then
                Return
            End If
            Dim baseHI As BaseHitInfo = view.CalcHitInfo(ea.Location)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then

                Dim id As String = String.Empty
                Dim id2 As String = String.Empty
                Dim ket As String = String.Empty
                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        id = GridView1.GetRowCellValue(rowHandle, "NoBukti")
                        ket = Mid(GridView1.GetRowCellValue(rowHandle, "NoBukti"), 1, 2)
                        id2 = GridView1.GetRowCellValue(rowHandle, "ID")
                    End If
                Next rowHandle

                If ket = "AP" Then
                    Call CallFrm(id2, id,
                         GridView1.RowCount)
                Else
                    '                    ff_Detail = New FrmDetailPaymentDirect1(id)
                    ''                   ff_Detail.Show()

                    Call CallFrm3(id2, id,
              GridView1.RowCount)
                End If
            End If

        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub



    Private Sub _txtperpost_EditValueChanged(sender As Object, e As EventArgs) Handles _txtperpost.EditValueChanged
        If _txtaccount.Text = "" Then
        Else
            ObjCashBank.Perpost = _txtperpost.Text
            ObjCashBank.AcctID = _txtaccount.Text
            ObjCashBank.account = _txtaccount.Text
        End If

        Dim saldo As Double
        saldo = ObjCashBank.saldo2
        If saldo = 0 Then
            _txtsaldo.Text = saldo
        Else
            _txtsaldo.Text = Format(saldo, "#,#.##")
        End If
        Call DataCashBank()

        For b As Integer = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString = "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")))
                End If

            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString = "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            ElseIf GridView1.GetRowCellValue(b, "Masuk").ToString <> "0" AndAlso GridView1.GetRowCellValue(b, "Keluar").ToString <> "0" Then
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")) + Convert.ToDouble(GridView1.GetRowCellValue(b, "Masuk")) - Convert.ToDouble(GridView1.GetRowCellValue(b, "Keluar")))
                End If
            Else
                If b = 0 Then
                    GridView1.SetRowCellValue(b, "Saldo", CDbl(_txtsaldo.Text))
                Else
                    GridView1.SetRowCellValue(b, "Saldo", Convert.ToDouble(GridView1.GetRowCellValue(b - 1, "Saldo")))
                End If
            End If
        Next
        Call DataSuspend()
    End Sub
End Class
