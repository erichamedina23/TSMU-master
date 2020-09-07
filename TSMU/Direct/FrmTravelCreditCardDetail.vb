Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmTravelCreditCardDetail
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim _Tag = New TagModel

    Dim cls_Creditcard As New TravelCreditCardModel

    Dim GridDtl As GridControl
    Dim dtGrid As DataTable

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
        GridDtl = _Grid
        FrmParent = lf_FormParent
        _Tag = New TagModel
        _Tag.PageIndex = lf_FormParent.Tag.PageIndex
        Tag = _Tag
    End Sub

    Private Sub FrmTravelCreditCardDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mati()
    End Sub

    Public Overrides Sub Proc_InputNewData()
        fs_Code = ""
        Call InitialSetForm()
    End Sub

    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "" Then
                cls_Creditcard.CreditCardID = fs_Code
                cls_Creditcard.GetCreditCardByID()
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                Me.Text = "CREDIT CARD"
            Else
                isUpdate = False
                Me.Text = "NEW CREDIT CARD"
            End If
            Call LoadTxtBox()
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = "FrmTravelCreditCard"
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub LoadTxtBox()
        Hidup()
        Try
            If fs_Code <> "" Then
                Call Proc_EnableButtons(True, True, True, True, False, False, False, True, False, False, False)
                With cls_Creditcard
                    txtCreditCardID.Text = .CreditCardID
                    txtCreditCardNumber.Text = .CreditCardNumber
                    txtAccountName.Text = .AccountName
                    txtBankName.Text = .BankName
                    txtType.Text = .Type
                    dtExpDate.EditValue = .ExpDate
                    txtCreditCardNumber.Focus()
                End With
            Else
                Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, False)
                txtCreditCardID.Text = ""
                txtCreditCardNumber.Text = ""
                txtAccountName.Text = ""
                txtBankName.Text = ""
                txtType.Text = "VISA"
                dtExpDate.EditValue = Date.Today
                txtCreditCardNumber.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LoadGrid()
        Try
            dtGrid = cls_Creditcard.GetAllDataTable(bs_Filter)
            GridCreditCard.DataSource = dtGrid
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Function ValidateSave() As Boolean
        Dim lb_Validated As Boolean = False
        Try
            Dim success As Boolean = True

            If DxValidationProvider1.Validate Then
                lb_Validated = True
            Else
                Err.Raise(ErrNumber, , "Data yang anda input tidak valid, silahkan cek inputan anda !")
            End If

            If Len(Replace(txtCreditCardNumber.Text,"-","")) <> 16 Then
                Err.Raise(ErrNumber, , "Credit Card Number harus 16 digit !")
            End If

            If txtAccountName.Text = "" Or txtBankName.Text = "" Then
                Err.Raise(ErrNumber, , GetMessage(MessageEnum.PropertyKosong))
            End If

            If lb_Validated Then
                If isUpdate = False Then
                    txtCreditCardID.Text = cls_Creditcard.TravelAutoCreditCardID
                End If

                With cls_Creditcard
                    .CreditCardID = txtCreditCardID.Text.Trim.ToUpper
                    .CreditCardNumber = Replace(txtCreditCardNumber.Text, "-", "")
                    .AccountName = txtAccountName.Text.Trim.ToUpper
                    .BankName = txtBankName.Text.Trim.ToUpper
                    .Type = txtType.Text.Trim.ToUpper
                    .ExpDate = dtExpDate.EditValue
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
                cls_Creditcard.InsertData()
                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            Else
                cls_Creditcard.CreditCardID = txtCreditCardID.Text
                cls_Creditcard.UpdateData()
                Call ShowMessage("Data Updated", MessageTypeEnum.NormalMessage)
            End If
            tsBtn_refresh.PerformClick()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_DeleteData()
        Try
            cls_Creditcard.CreditCardID = txtCreditCardID.Text
            cls_Creditcard.DeleteData()
            tsBtn_refresh.PerformClick()
            Call ShowMessage(GetMessage(MessageEnum.HapusBerhasil), MessageTypeEnum.NormalMessage)
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_Refresh()
        Bersih()
        Mati()
    End Sub

    Private Sub GridCreditCard_DoubleClick(sender As Object, e As EventArgs) Handles GridCreditCard.DoubleClick
        Try
            Dim CreditCardID As String = String.Empty

            Dim selectedRows() As Integer = GridViewCreditCard.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    CreditCardID = GridViewCreditCard.GetRowCellValue(rowHandle, "CreditCardID")
                End If
            Next rowHandle

            If GridViewCreditCard.GetSelectedRows.Length > 0 Then
                fs_Code = CreditCardID
                InitialSetForm()
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub Hidup()
        txtCreditCardNumber.Enabled = True
        txtAccountName.Enabled = True
        txtBankName.Enabled = True
        txtType.Enabled = True
        dtExpDate.Enabled = True
    End Sub

    Private Sub Mati()
        Call Proc_EnableButtons(True, False, False, True, False, False, False, False)
        Call LoadGrid()
        txtCreditCardNumber.Enabled = False
        txtAccountName.Enabled = False
        txtBankName.Enabled = False
        txtType.Enabled = False
        dtExpDate.Enabled = False
    End Sub

    Private Sub Bersih()
        fs_Code = ""
        txtCreditCardID.Text = ""
        txtCreditCardNumber.Text = ""
        txtAccountName.Text = ""
        txtBankName.Text = ""
        txtType.Text = ""
        dtExpDate.EditValue = Nothing
    End Sub

End Class
