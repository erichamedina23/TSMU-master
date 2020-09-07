Imports DevExpress.XtraEditors.Controls

Public Class FrmTravelPocketAllowance
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""

    Dim dtGrid As DataTable
    Dim fc_Class As New TravelPocketAllowanceModel

    Dim travelType As String = String.Empty
    Dim golongan As String = String.Empty
    Dim negara As String = String.Empty
    Dim curryID As String = String.Empty

    Private Sub FrmTravelPocketAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListItemsGolongan()
        ListItemsNegara()
        tsBtn_refresh.PerformClick()
    End Sub

    Public Overrides Sub InitialSetForm()
        Try
            If travelType <> "" And golongan <> "" And curryID <> "" And negara <> "" Then
                fc_Class.TravelType = travelType
                fc_Class.Golongan = golongan
                fc_Class.NamaNegara = negara
                fc_Class.CurryID = curryID
                fc_Class.GetPocketAllowanceByID()
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                Me.Text = "ALLOWANCE"
            Else
                isUpdate = False
                Me.Text = "NEW ALLOWANCE"
            End If
            Call LoadTxtBox()
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = "FrmTravelPocketAllowance"
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Public Overrides Sub Proc_InputNewData()
        travelType = ""
        golongan = ""
        curryID = ""
        negara = ""
        Call InitialSetForm()
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

            If txtTravelType.Text = "" Or txtGolongan.Text = "" Or txtNamaNegara.Text = "" Or txtCurryID.Text = "" Then
                Err.Raise(ErrNumber, , GetMessage(MessageEnum.PropertyKosong))
            End If

            If isUpdate = False Then
                lb_Validated = fc_Class.CheckValidasi(txtTravelType.Text, txtGolongan.EditValue, txtNamaNegara.Text)
            End If

            If lb_Validated Then
                With fc_Class
                    .TravelType = txtTravelType.Text
                    .Golongan = txtGolongan.EditValue
                    .NamaNegara = txtNamaNegara.Text
                    .DescGolongan = txtGolongan.Text
                    .CurryID = txtCurryID.Text
                    .AmountAllowance = Convert.ToDouble(txtAmountAllowance.Text)
                    .AmountFirstTravel = Convert.ToDouble(txtAmountFirstTravel.Text)
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
                fc_Class.InsertData()
                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            Else
                fc_Class.UpdateData()
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
            fc_Class.DeleteData()
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

    Private Sub GridViewPocketAllowance_DoubleClick(sender As Object, e As EventArgs) Handles GridViewPocketAllowance.DoubleClick
        Try
            Dim selectedRows() As Integer = GridViewPocketAllowance.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    travelType = GridViewPocketAllowance.GetRowCellValue(rowHandle, "TravelType")
                    golongan = GridViewPocketAllowance.GetRowCellValue(rowHandle, "Golongan")
                    curryID = GridViewPocketAllowance.GetRowCellValue(rowHandle, "CuryID")
                    negara = GridViewPocketAllowance.GetRowCellValue(rowHandle, "NamaNegara")
                End If
            Next rowHandle

            If GridViewPocketAllowance.GetSelectedRows.Length > 0 Then
                InitialSetForm()
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub LoadTxtBox()
        Try
            If isUpdate Then
                Call Proc_EnableButtons(True, True, True, True, False, False, False, True, False, False, False)
                HidupEdit()
                With fc_Class
                    txtTravelType.Text = .TravelType
                    txtGolongan.EditValue = .Golongan
                    txtNamaNegara.Text = .NamaNegara
                    txtCurryID.Text = .CurryID
                    txtAmountAllowance.Text = .AmountAllowance
                    txtAmountFirstTravel.Text = .AmountFirstTravel
                End With
            Else
                Call Proc_EnableButtons(False, True, False, True, True, False, False, False, False, False, False)
                Bersih()
                HidupNew()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LoadGrid()
        Try
            dtGrid = fc_Class.GetAllDataTable()
            GridPocketAllowance.DataSource = dtGrid
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub HidupNew()
        txtTravelType.Enabled = True
        txtGolongan.Enabled = True
        txtNamaNegara.Enabled = True
        txtCurryID.Enabled = True
        txtAmountAllowance.Enabled = True
        txtAmountFirstTravel.Enabled = True
    End Sub

    Private Sub HidupEdit()
        txtTravelType.Enabled = False
        txtGolongan.Enabled = False
        txtNamaNegara.Enabled = False
        txtAmountAllowance.Enabled = True
        If txtTravelType.Text = "DN" Then
            txtAmountFirstTravel.Enabled = False
        Else
            txtAmountFirstTravel.Enabled = True
        End If
    End Sub

    Private Sub Mati()
        Call Proc_EnableButtons(True, False, False, True, False, False, False, False)
        Call LoadGrid()
        txtTravelType.Enabled = False
        txtGolongan.Enabled = False
        txtNamaNegara.Enabled = False
        txtCurryID.Enabled = False
        txtAmountAllowance.Enabled = False
        txtAmountFirstTravel.Enabled = False
    End Sub

    Private Sub Bersih()
        txtTravelType.Text = ""
        txtGolongan.EditValue = Nothing
        txtNamaNegara.Text = ""
        txtCurryID.Text = ""
        txtAmountAllowance.Text = Format(0, gs_FormatDecimal)
        txtAmountFirstTravel.Text = Format(0, gs_FormatDecimal)
    End Sub

    Private Sub txtAmountAllowance_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountAllowance.EditValueChanged
        If String.IsNullOrEmpty(txtAmountAllowance.Text) Then
            txtAmountAllowance.Text = 0
        End If
        txtAmountAllowance.Text = Format(Convert.ToDecimal(txtAmountAllowance.Text), gs_FormatDecimal)
    End Sub

    Private Sub txtAmountFirstTravel_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountFirstTravel.EditValueChanged
        If String.IsNullOrEmpty(txtAmountFirstTravel.Text) Then
            txtAmountFirstTravel.Text = 0
        End If
        txtAmountFirstTravel.Text = Format(Convert.ToDecimal(txtAmountFirstTravel.Text), gs_FormatDecimal)
    End Sub

    Private Sub txtTravelType_EditValueChanged(sender As Object, e As EventArgs) Handles txtTravelType.EditValueChanged
        If txtTravelType.Text = "DN" Then
            txtNamaNegara.Text = "INDONESIA"
            txtAmountFirstTravel.Text = 0
            txtNamaNegara.Enabled = False
            txtCurryID.Enabled = False
            txtAmountFirstTravel.Enabled = False
            txtCurryID.Text = "IDR"
        Else
            txtNamaNegara.Text = ""
            If isUpdate Then
                txtNamaNegara.Enabled = False
            Else
                txtNamaNegara.Enabled = True
            End If
            txtCurryID.Enabled = True
            txtAmountFirstTravel.Enabled = True
            txtCurryID.Text = "USD"
        End If
    End Sub

    Private Sub ListItemsGolongan()
        Dim dtGolongan = New DataTable
        dtGolongan = fc_Class.GetListGolongan()
        txtGolongan.Properties.DataSource = dtGolongan
    End Sub

    Private Sub ListItemsNegara()
        Dim dtNegara = New DataTable
        dtNegara = fc_Class.GetListNegara()
        dtNegara.Rows.Add("EROPA")
        dtNegara.Rows.Add("ASIA")
        dtNegara.Rows.Add("AFRIKA")
        dtNegara.Rows.Add("OTHERS")
        Dim itemsCollection As ComboBoxItemCollection = txtNamaNegara.Properties.Items
        itemsCollection.BeginUpdate()
        itemsCollection.Clear()
        Try
            For Each r As DataRow In dtNegara.Select("", "NamaNegara ASC").CopyToDataTable.Rows
                itemsCollection.Add(r.Item(0))
            Next
        Finally
            itemsCollection.EndUpdate()
        End Try
    End Sub

End Class
