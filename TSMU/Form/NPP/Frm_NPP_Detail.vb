Imports System.Data.OleDb
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class Frm_NPP_Detail

    Dim CForm As Integer = 0
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim ls_Error As String = ""
    Dim fc_Class As New Cls_NPP_Detail
    Dim fc_Class_Head As New Cls_NPP_Header
    Dim NPP_Detail As New Col_Cls_NPP_Detail_NPP
    Dim GridDtl As GridControl
    Dim fs_Split As String = "'"
    Dim lg_Grid As DataGridView
    Dim boomId As String = String.Empty
    Dim dtGrid As New DataTable
    Dim Dept As String
    Dim DeptSub As String = ""
    Dim DtGridNPWO As DataTable
    Dim DtGridPayment As DataTable
    Dim frmInput As Frm_Input_NPPDetail
    Dim frmSetGroup As Frm_NPP_Set_Grup
    Dim frmPrepare As Frm_NPP_Prepare
    Dim dt As New DataTable
    Dim DtDelete As New DataTable
    Dim dtApprove As New DataTable
    Dim FrmReport As ReportNPWO
    Dim NoSirkulasi As String = ""
    Dim _Tag As TagModel
    Dim FileLokasi As String = ""
    Dim dtExcel As New DataTable
    Dim RowsAwal As Integer
    Dim Active_Form As Integer = 0
    Dim MenuCode As String = ""
    Dim ChekHeader As CheckBox

    Dim _frmNPPHeader As Frm_NPP_Header
    Dim _frmNPPApprove As Frm_Approve_Dept_Head

    Public Property Test As String = "t"

    Dim ff_Detail As frmDRR_details




    Private Sub TextBox_False()

        TNPP_No.Enabled = False
        TCustomer.Enabled = False
        TModel.Enabled = False
        TOrderMonth.Enabled = False
        TOrderMaxMonth.Enabled = False
        TCategory.Enabled = False
        TIssue_Date.Enabled = False
        TModelDesc.Enabled = False
        TMassPro.Enabled = False
        TTargetDr.Enabled = False
        TTargetQuot.Enabled = False
        TRevisiInformasi.Enabled = False

    End Sub

    Private Sub TextBox_True()

        TNPP_No.Enabled = False
        TCustomer.Enabled = False
        TModel.Enabled = False
        TOrderMonth.Enabled = False
        TOrderMaxMonth.Enabled = False
        TCategory.Enabled = False
        TIssue_Date.Enabled = False
        TModelDesc.Enabled = False
        TMassPro.Enabled = False
        TTargetDr.Enabled = False
        TTargetQuot.Enabled = False
        TRevisiInformasi.Enabled = False

    End Sub

    Private Sub FillComboCustomer()
        Try
            Dim dt As New DataTable
            dt = fc_Class.GetCustomer
            TCustomer.Properties.DataSource = Nothing
            TCustomer.Properties.DataSource = dt
            TCustomer.Properties.ValueMember = "Value"
            TCustomer.Properties.DisplayMember = "Value"
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub FillComboCategory()
        Try
            Dim dt As New DataTable
            dt = fc_Class.GetCategory
            TCategory.Properties.DataSource = Nothing
            TCategory.Properties.DataSource = dt
            TCategory.Properties.ValueMember = "Value"
            TCategory.Properties.DisplayMember = "Value"
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Colums_AllowEdit_False()

        Me.PartNo.OptionsColumn.AllowEdit = False
        Me.PartName.OptionsColumn.AllowEdit = False
        Me.Machine.OptionsColumn.AllowEdit = False
        Me.CT.OptionsColumn.AllowEdit = False
        Me.Cav.OptionsColumn.AllowEdit = False
        Me.Weight.OptionsColumn.AllowEdit = False
        Me.Material.OptionsColumn.AllowEdit = False
        Me.Inj.OptionsColumn.AllowEdit = False
        Me.Painting.OptionsColumn.AllowEdit = False
        Me.Chrome.OptionsColumn.AllowEdit = False
        Me.Assy.OptionsColumn.AllowEdit = False
        Me.StatusMold.OptionsColumn.AllowEdit = False
        Me.OrderMonth.OptionsColumn.AllowEdit = False
        Me.Ultrasonic.OptionsColumn.AllowEdit = False
        Me.Vibration.OptionsColumn.AllowEdit = False
        Me.GroupID.OptionsColumn.AllowEdit = False
        Me.Revisi.OptionsColumn.AllowEdit = False
        Me.Status.OptionsColumn.AllowEdit = False
        Me.CapabilityDate.OptionsColumn.AllowEdit = False
        Me.Note.OptionsColumn.AllowEdit = False
        Me.Cek.OptionsColumn.AllowEdit = False
        Me.Commit.OptionsColumn.AllowEdit = False
        Me.Runner.OptionsColumn.AllowEdit = False
        Me.ChangeFrom.OptionsColumn.AllowEdit = False

    End Sub

    Private Sub Colums_AllowEdit_True()

        Me.PartNo.OptionsColumn.AllowEdit = True
        Me.PartName.OptionsColumn.AllowEdit = True
        Me.Machine.OptionsColumn.AllowEdit = True
        Me.CT.OptionsColumn.AllowEdit = True
        Me.Cav.OptionsColumn.AllowEdit = True
        Me.Weight.OptionsColumn.AllowEdit = True
        Me.Material.OptionsColumn.AllowEdit = True
        Me.Inj.OptionsColumn.AllowEdit = True
        Me.Painting.OptionsColumn.AllowEdit = True
        Me.Chrome.OptionsColumn.AllowEdit = True
        Me.Assy.OptionsColumn.AllowEdit = True
        Me.StatusMold.OptionsColumn.AllowEdit = True
        Me.OrderMonth.OptionsColumn.AllowEdit = True
        Me.Ultrasonic.OptionsColumn.AllowEdit = True
        Me.Vibration.OptionsColumn.AllowEdit = True
        Me.GroupID.OptionsColumn.AllowEdit = True
        Me.Revisi.OptionsColumn.AllowEdit = True
        Me.Status.OptionsColumn.AllowEdit = True
        Me.CapabilityDate.OptionsColumn.AllowEdit = True
        Me.Note.OptionsColumn.AllowEdit = True
        Me.Cek.OptionsColumn.AllowEdit = True
        Me.Commit.OptionsColumn.AllowEdit = True
        Me.Runner.OptionsColumn.AllowEdit = True
        Me.ChangeFrom.OptionsColumn.AllowEdit = True

    End Sub

    Private Sub CreateTableBarang()

        DtGridNPWO = New DataTable
        DtGridNPWO.Columns.AddRange(New DataColumn(31) {New DataColumn("No Urut", GetType(Integer)),
                                                           New DataColumn("Part No", GetType(String)),
                                                           New DataColumn("Part Name", GetType(String)),
                                                           New DataColumn("Machine", GetType(String)),
                                                           New DataColumn("C/T", GetType(String)),
                                                           New DataColumn("Cav", GetType(String)),
                                                           New DataColumn("Runner", GetType(Double)),
                                                           New DataColumn("Weight", GetType(Double)),
                                                           New DataColumn("Qty Mold", GetType(Int32)),
                                                           New DataColumn("Material", GetType(String)),
                                                           New DataColumn("Inj", GetType(Boolean)),
                                                           New DataColumn("Painting", GetType(Boolean)),
                                                           New DataColumn("Chrome", GetType(Boolean)),
                                                           New DataColumn("Assy", GetType(Boolean)),
                                                           New DataColumn("Status Mold", GetType(String)),
                                                           New DataColumn("Forecast", GetType(String)),
                                                           New DataColumn("Vibration", GetType(Boolean)),
                                                           New DataColumn("Ultrasonic", GetType(Boolean)),
                                                           New DataColumn("Single", GetType(Boolean)),
                                                           New DataColumn("Group ID", GetType(String)),
                                                           New DataColumn("ID", GetType(Integer)),
                                                           New DataColumn("Revisi", GetType(String)),
                                                           New DataColumn("Order Month", GetType(Int32)),
                                                           New DataColumn("Status", GetType(String)),
                                                           New DataColumn("Cek", GetType(String)),
                                                           New DataColumn("Replace", GetType(String)),
                                                           New DataColumn("Note", GetType(String)),
                                                           New DataColumn("Seq", GetType(Integer)),
                                                           New DataColumn("Active", GetType(Boolean)),
                                                           New DataColumn("Commit NPD", GetType(Boolean)),
                                                           New DataColumn("DRR", GetType(Boolean)),
                                                           New DataColumn("Capability date", GetType(Date))})
        Grid.DataSource = DtGridNPWO
        GridView1.OptionsView.ShowAutoFilterRow = False

    End Sub
    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "" Then
                fc_Class.GetDataByID(fs_Code)
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Me.Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
                If Active_Form = 1 Then
                    TCustomer.Enabled = False
                    TModel.Enabled = False
                    TNPP_No.Enabled = False
                    Me.Text = "NPP FORM "
                    If fc_Class.H_Approve <= 1 Then
                        Call Proc_EnableButtons(False, True, False, True, False, False, False, True, False, False, True)
                        Call Colums_AllowEdit_True()
                        Me.CapabilityDate.Visible = False
                        Me.Commit.Visible = False
                        BUpload.Visible = True
                        B_AddRows.Visible = True
                        B_Submit.Visible = False
                    ElseIf fc_Class.H_Approve = 3 And fc_Class.H_Submit_NPD = False Then
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, True, False, False, False)
                        Call Colums_AllowEdit_False()
                        B_Submit.Visible = True
                        Me.CapabilityDate.OptionsColumn.AllowEdit = False
                        Me.Commit.OptionsColumn.AllowEdit = True
                        B_AddRows.Visible = False
                        BUpload.Visible = False
                    ElseIf fc_Class.H_Approve = 3 And fc_Class.H_Submit_NPD = True Then
                        Call Proc_EnableButtons(False, True, False, False, False, False, False, True, False, False, False)
                        Call Colums_AllowEdit_True()
                        Me.PartNo.OptionsColumn.AllowEdit = False
                        Me.PartName.OptionsColumn.AllowEdit = False
                        Me.CapabilityDate.OptionsColumn.AllowEdit = False
                        Me.Revisi.OptionsColumn.AllowEdit = False
                        Me.Commit.OptionsColumn.AllowEdit = True
                        'B_Revise.Visible = True
                    Else
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, True, False, False, False)
                        Call Colums_AllowEdit_False()
                    End If
                ElseIf Active_Form = 2 Then
                    TCustomer.Enabled = False
                    TModel.Enabled = False
                    GridView1.OptionsView.ShowAutoFilterRow = True
                    Me.Text = "NPP FORM "
                    Me.GroupID.Fixed = False
                    Call Colums_AllowEdit_False()
                    Call TextBox_False()
                    Me.Cek.OptionsColumn.AllowEdit = True
                    Me.Note.OptionsColumn.AllowEdit = True
                    If fc_Class.H_Approve_Dept_Head = True And fc_Class.H_Status = "Approve Div Head" Then
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, False)
                        Call Colums_AllowEdit_False()
                    ElseIf fc_Class.H_Approve_Dept_Head = True And fc_Class.H_Status = "Submit To NPD" Then
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, False)
                        Call Colums_AllowEdit_False()
                        B_AddRows.Enabled = False
                        BUpload.Enabled = False
                        B_Revise.Visible = True
                    Else
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, False)
                        B_AddRows.Enabled = False
                        BUpload.Enabled = False
                        B_Approve.Visible = True
                        B_Reject.Visible = True
                    End If
                ElseIf Active_Form = 3 Then
                    TCustomer.Enabled = False
                    TModel.Enabled = False
                    GridView1.OptionsView.ShowAutoFilterRow = True
                    Me.Text = "NPP FORM "
                    Me.GroupID.Fixed = False
                    Call Colums_AllowEdit_False()
                    Call TextBox_False()
                    Me.Cek.OptionsColumn.AllowEdit = True
                    Me.Note.OptionsColumn.AllowEdit = True
                    If fc_Class.H_Approve_Div_Head = False Then
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, False)
                        B_Approve.Visible = True
                        B_Reject.Visible = True
                    Else
                        Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, False)
                        B_AddRows.Enabled = False
                        BUpload.Enabled = False
                    End If
                ElseIf Active_Form = 4 Then
                    TCustomer.Enabled = False
                    TModel.Enabled = False
                    GridView1.OptionsView.ShowAutoFilterRow = True
                    Me.Text = "NPP FORM "
                    Me.GroupID.Fixed = False
                    Call Colums_AllowEdit_False()
                    Call TextBox_False()
                    Me.Cek.OptionsColumn.AllowEdit = True
                    Me.Note.OptionsColumn.AllowEdit = True
                    Me.CapabilityDate.OptionsColumn.AllowEdit = True
                    Me.Commit.OptionsColumn.AllowEdit = True
                    Call Proc_EnableButtons(False, False, False, False, False, False, False, False, False, False, True, False)
                    B_AddRows.Enabled = False
                    BUpload.Enabled = False
                End If
            Else
                Call Proc_EnableButtons(False, True, False, True, False, False, False, True, False, False, True)
                Call Colums_AllowEdit_True()
                Me.CapabilityDate.OptionsColumn.AllowEdit = False
                Me.Text = "NPP FORM "
                B_AddRows.Visible = True
                BUpload.Visible = True
                TIssue_Date.EditValue = Date.Now
            End If
            Call LoadTxtBox()
            Call LoadGrid(fc_Class.H_No_NPP)
            Call InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = FrmParent.Name.ToString()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub LoadGrid(NPP_ As String)

        Try
            If fs_Code <> "" Then
                Cursor.Current = Cursors.WaitCursor
                'DtGridNPWO = New DataTable
                DtGridNPWO = fc_Class.Get_Detail_NPP(NPP_)
                Grid.DataSource = DtGridNPWO
                Cursor.Current = Cursors.Default
            Else
                'Code
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form,
                   ByVal li_GridRow As Integer,
                   ByRef _Grid As GridControl,
                   ByRef _Active_Form As Integer,
                   ByRef _MenuCode As String)
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
        Active_Form = _Active_Form
        MenuCode = _MenuCode
    End Sub

    Private Sub B_AddRows_Click(sender As Object, e As EventArgs) Handles B_AddRows.Click

        If TOrderMonth.Text = "" Then
            MessageBox.Show("Please Fill Order Month",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
        Else
            CallForm()
        End If


    End Sub

    Private Sub LoadTxtBox()
        Try
            If fs_Code <> "" Then
                With fc_Class
                    TNPP_No.EditValue = .H_No_NPP
                    TCustomer.EditValue = .H_Customer_Name
                    TModel.EditValue = .H_Model_Name
                    TModelDesc.EditValue = .H_Model_Description
                    TOrderMonth.EditValue = .H_Order_Month
                    TOrderMaxMonth.EditValue = .H_Order_Max_Month
                    If .H_MassPro = "01-01-1900" Then
                        TMassPro.Text = ""
                    Else
                        TMassPro.EditValue = .H_MassPro
                    End If
                    CBCad.Checked = .H_CAD_Data
                    CBDrawing.Checked = .H_Drawing
                    CBSample.Checked = .H_Sample
                    CBStr.Checked = .H_Special_Technical_Requires
                    CBTng.Checked = .H_Factory_Tsc_TNG
                    CBCkr.Checked = .H_Factory_Tsc_CKR
                    TCategory.EditValue = .H_Category_Class
                    TTargetDr.EditValue = .H_TargetDRR
                    TTargetQuot.EditValue = .H_TargetQuot
                    TIssue_Date.EditValue = .H_Issue_Date
                End With


                TRevisi.EditValue = fc_Class.H_Rev

                TRevisiInformasi.EditValue = ""
            Else
                TRevisi.EditValue = "0"
                TRevisiInformasi.EditValue = "New Model"
                BSetGroup.Enabled = False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Overrides Function ValidateSave() As Boolean

        Dim lb_Validated As Boolean = False
        Try
            Dim DR As Date = CDate(TTargetDr.EditValue)
            Dim QUOT As Date = CDate(TTargetQuot.EditValue)

            If TNPP_No.EditValue = "" Then
                MessageBox.Show("Please Choose Customer and Model", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            ElseIf TCustomer.EditValue = "" Then
                MessageBox.Show("Please Choose Customer Name", "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)

            ElseIf TModel.EditValue = "" Then
                MessageBox.Show("Please fill Model Name", "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            ElseIf TOrderMonth.Text = "" Then
                MessageBox.Show("Order Month Must Be Number", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            ElseIf TOrderMaxMonth.Text = "" Then
                MessageBox.Show("Order Max Month Must Be Number", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            ElseIf TCategory.EditValue = "" Then
                MessageBox.Show("Please fill Category", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1)
                'ElseIf TMassPro.Text = "" Then
                '    MessageBox.Show("Please fill MP", "Warning",
                '            MessageBoxButtons.OK,
                '            MessageBoxIcon.Exclamation,
                '            MessageBoxDefaultButton.Button1)
            ElseIf TTargetDr.Text = "" Then
                MessageBox.Show("Please fill Target DR", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1)
            ElseIf TTargetQuot.Text = "" Then
                MessageBox.Show("Please fill Quotation Target", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1)
            ElseIf DR > QUOT Then
                MessageBox.Show("Please Check DR Target and Quotatio Target", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1)
            Else

                lb_Validated = True
            End If

            If lb_Validated Then
                With fc_Class
                    If isUpdate = False Then
                        .ValidateInsert(TNPP_No.EditValue)
                    End If
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
            'Dim baseEdit = TryCast(sender, BaseEdit)
            'Dim gridView = (TryCast((TryCast(BaseEdit.Parent, GridControl)).MainView, GridView))
            'gridView.PostEditor()
            'GridView.UpdateCurrentRow()
            getdataview1()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub

    Private Sub getdataview1()
        Try
            Dim IsEmpty As Boolean = False

            If GridView1.RowCount = 0 Then

                MessageBox.Show("Please Fill Part Information ", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                Exit Sub

            Else

                For i As Integer = 0 To GridView1.RowCount - 1
                    GridView1.MoveFirst()
                    If GridView1.GetRowCellValue(i, GridView1.Columns("Part No")).ToString = "" Then
                        IsEmpty = True
                        MessageBox.Show("Ensure that nothing is empty Of Description of Cost ", "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                        Exit Sub
                    Else

                    End If
                Next

            End If

            If isUpdate = False Then

                dtApprove = New DataTable
                dtApprove = fc_Class.GetApprove
                With fc_Class
                    .H_No_NPP = TNPP_No.EditValue
                    .H_Issue_Date = TIssue_Date.EditValue
                    .H_Model_Name = TModel.EditValue
                    .H_Model_Description = TModelDesc.EditValue
                    .H_Customer_Name = TCustomer.EditValue
                    .H_Order_Month = TOrderMonth.EditValue
                    .H_Order_Max_Month = TOrderMaxMonth.EditValue
                    If TMassPro.Text = "" Then
                        .H_MassPro = "01-01-1900"
                    Else
                        .H_MassPro = TMassPro.EditValue

                    End If
                    .H_Drawing = CBDrawing.CheckState
                    .H_CAD_Data = CBCad.CheckState
                    .H_Sample = CBSample.CheckState
                    .H_Special_Technical_Requires = CBStr.CheckState
                    .H_Category_Class = TCategory.EditValue
                    .H_Factory_Tsc_TNG = CBTng.CheckState
                    .H_Factory_Tsc_CKR = CBCkr.CheckState
                    .H_Rev = 0
                    .H_RevInformasi = TRevisiInformasi.EditValue
                    .H_TargetDRR = TTargetDr.EditValue
                    .H_TargetQuot = TTargetQuot.EditValue
                    .H_Checked = dtApprove.Rows(0).Item("Checked")
                    .H_A1 = dtApprove.Rows(0).Item("A1")
                    .H_A2 = dtApprove.Rows(0).Item("A2")
                    .H_A3 = dtApprove.Rows(0).Item("A3")
                    .H_A4 = dtApprove.Rows(0).Item("A4")
                    .H_Status = "Create"
                    .H_Approve = 0
                End With
                'Insert To ObjDetailMaterial
                fc_Class.Collection_Detail.Clear()
                For i As Integer = 0 To GridView1.RowCount - 1
                    NPP_Detail = New Col_Cls_NPP_Detail_NPP
                    With NPP_Detail
                        .No_Npwo = TNPP_No.EditValue
                        .Part_No = Convert.ToString(GridView1.GetRowCellValue(i, "Part No"))
                        .Part_Name = Convert.ToString(GridView1.GetRowCellValue(i, "Part Name"))
                        .Machine = Convert.ToString(GridView1.GetRowCellValue(i, "Machine"))
                        .Material_Resin = Convert.ToString(GridView1.GetRowCellValue(i, "Material"))
                        .Injection = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Inj"))
                        .Painting = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Painting"))
                        .Chrome = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Chrome"))
                        .Vibration = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Vibration"))
                        .Assy = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Assy"))
                        .Ultrasonic = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Ultrasonic"))
                        .StatusMold = Convert.ToString(GridView1.GetRowCellValue(i, "Status Mold"))
                        .Cavity = Convert.ToString(GridView1.GetRowCellValue(i, "Cav"))
                        .MoldNumber = Convert.ToString(GridView1.GetRowCellValue(i, "Group ID"))
                        .Revisi = Convert.ToString(GridView1.GetRowCellValue(i, "Revisi"))
                        .Status = Convert.ToString(GridView1.GetRowCellValue(i, "Status"))
                        .Rev = 0
                        .Cek = Convert.ToString(GridView1.GetRowCellValue(i, "Cek"))
                        .Note = Convert.ToString(GridView1.GetRowCellValue(i, "Note"))
                        .Seq = Convert.ToInt64(GridView1.GetRowCellValue(i, "Seq"))
                        .Commit = IIf(GridView1.GetRowCellValue(i, "Commit NPD") Is DBNull.Value, False, GridView1.GetRowCellValue(i, "Commit NPD"))
                        .Capability = IIf(GridView1.GetRowCellValue(i, "Due Date NPD") Is DBNull.Value, Nothing, GridView1.GetRowCellValue(i, "Due Date NPD"))

                        If IsNumeric(GridView1.GetRowCellValue(i, "No Urut")) = True Then
                            .NoUrut = Convert.ToInt64(GridView1.GetRowCellValue(i, "No Urut"))
                        Else
                            .NoUrut = 0
                        End If

                        If IsNumeric(GridView1.GetRowCellValue(i, "C/T")) = True Then
                            .Cycle_Time = Convert.ToString(GridView1.GetRowCellValue(i, "C/T"))
                        Else
                            .Cycle_Time = 0
                        End If
                        If IsNumeric(GridView1.GetRowCellValue(i, "Weight")) = True Then
                            .Weight = Convert.ToDouble(GridView1.GetRowCellValue(i, "Weight"))
                        Else
                            .Weight = 0
                        End If
                        If IsNumeric(GridView1.GetRowCellValue(i, "Runner")) = True Then
                            .Runner = Convert.ToDouble(GridView1.GetRowCellValue(i, "Runner"))
                        Else
                            .Runner = 0
                        End If
                        If IsNumeric(GridView1.GetRowCellValue(i, "Order Month")) = True Then
                            .OrderMonth = Convert.ToInt32(GridView1.GetRowCellValue(i, "Order Month"))
                        Else
                            .OrderMonth = 0
                        End If

                        .ChangeFrom = Convert.ToString(GridView1.GetRowCellValue(i, "Change From"))
                        ._Active = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Active"))
                        .DRR = IIf(GridView1.GetRowCellValue(i, "DRR") Is DBNull.Value, 0, GridView1.GetRowCellValue(i, "DRR"))


                    End With
                    fc_Class.Collection_Detail.Add(NPP_Detail)
                Next

                fc_Class.Insert(fc_Class.H_No_NPP)
                bs_Filter = gh_Common.GroupID
                '_frmNPPApprove = New Frm_Approve_Dept_Head
                '_frmNPPApprove.NPP_Approve_LoadGrid()
                '_frmNPPHeader.gr
                'GridDtl.DataSource = fc_Class_Head.Get_NPP()
                IsClosed = True
                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                Me.Hide()
            Else
                If fc_Class.H_RevStatus = False Then
                    With fc_Class
                        .H_Issue_Date = TIssue_Date.EditValue
                        .H_No_NPP = TNPP_No.EditValue
                        .H_Model_Name = TModel.EditValue
                        .H_Model_Description = TModelDesc.EditValue
                        .H_Customer_Name = TCustomer.EditValue
                        .H_Order_Month = TOrderMonth.EditValue
                        .H_Order_Max_Month = TOrderMaxMonth.EditValue
                        If TMassPro.Text = "" Then
                            .H_MassPro = "01-01-1900"
                        Else
                            .H_MassPro = TMassPro.EditValue
                        End If
                        .H_Drawing = CBDrawing.CheckState
                        .H_CAD_Data = CBCad.CheckState
                        .H_Sample = CBSample.CheckState
                        .H_Special_Technical_Requires = CBStr.CheckState
                        .H_Category_Class = TCategory.EditValue
                        .H_Factory_Tsc_TNG = CBTng.CheckState
                        .H_Factory_Tsc_CKR = CBCkr.CheckState
                        .H_Rev = TRevisi.EditValue
                        .H_RevInformasi = TRevisiInformasi.EditValue
                        .H_TargetDRR = TTargetDr.EditValue
                        .H_TargetQuot = TTargetQuot.EditValue
                        .H_RevInformasi = TRevisiInformasi.EditValue
                    End With

                    'Insert To ObjDetailMaterial
                    fc_Class.Collection_Detail.Clear()
                    For i As Integer = 0 To GridView1.RowCount - 1

                        NPP_Detail = New Col_Cls_NPP_Detail_NPP
                        With NPP_Detail

                            .No_Npwo = TNPP_No.EditValue
                            .Part_No = Convert.ToString(GridView1.GetRowCellValue(i, "Part No"))
                            .Part_Name = Convert.ToString(GridView1.GetRowCellValue(i, "Part Name"))
                            .Machine = Convert.ToString(GridView1.GetRowCellValue(i, "Machine"))
                            '.Cycle_Time = Convert.ToString(GridView1.GetRowCellValue(i, "C/T"))
                            .Cavity = Convert.ToString(GridView1.GetRowCellValue(i, "Cav"))
                            '.Weight = Convert.ToDouble(GridView1.GetRowCellValue(i, "Weight"))
                            .Material_Resin = Convert.ToString(GridView1.GetRowCellValue(i, "Material"))
                            .Injection = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Inj"))
                            .Painting = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Painting"))
                            .Chrome = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Chrome"))
                            .Vibration = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Vibration"))
                            .Assy = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Assy"))
                            .Ultrasonic = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Ultrasonic"))
                            .StatusMold = Convert.ToString(GridView1.GetRowCellValue(i, "Status Mold"))
                            '.OrderMonth = Convert.ToInt32(GridView1.GetRowCellValue(i, "Order Month"))
                            .MoldNumber = Convert.ToString(GridView1.GetRowCellValue(i, "Group ID"))
                            .Revisi = Convert.ToString(GridView1.GetRowCellValue(i, "Revisi"))
                            .Status = Convert.ToString(GridView1.GetRowCellValue(i, "Status"))
                            .Cek = Convert.ToString(GridView1.GetRowCellValue(i, "Cek"))
                            .Note = Convert.ToString(GridView1.GetRowCellValue(i, "Note"))
                            '.Runner = Convert.ToDouble(GridView1.GetRowCellValue(i, "Runner"))
                            .Seq = Convert.ToInt64(GridView1.GetRowCellValue(i, "Seq"))
                            .Commit = IIf(GridView1.GetRowCellValue(i, "Commit NPD") Is DBNull.Value, False, GridView1.GetRowCellValue(i, "Commit NPD"))
                            .Capability = IIf(GridView1.GetRowCellValue(i, "Due Date NPD") Is DBNull.Value, Nothing, GridView1.GetRowCellValue(i, "Due Date NPD"))

                            If IsNumeric(GridView1.GetRowCellValue(i, "No Urut")) = True Then
                                .NoUrut = Convert.ToInt64(GridView1.GetRowCellValue(i, "No Urut"))
                            Else
                                .NoUrut = 0
                            End If


                            If IsNumeric(GridView1.GetRowCellValue(i, "C/T")) = True Then
                                .Cycle_Time = Convert.ToString(GridView1.GetRowCellValue(i, "C/T"))
                            Else
                                .Cycle_Time = 0
                            End If
                            If IsNumeric(GridView1.GetRowCellValue(i, "Weight")) = True Then
                                .Weight = Convert.ToDouble(GridView1.GetRowCellValue(i, "Weight"))
                            Else
                                .Weight = 0
                            End If
                            If IsNumeric(GridView1.GetRowCellValue(i, "Runner")) = True Then
                                .Runner = Convert.ToDouble(GridView1.GetRowCellValue(i, "Runner"))
                            Else
                                .Runner = 0
                            End If
                            If IsNumeric(GridView1.GetRowCellValue(i, "Order Month")) = True Then
                                .OrderMonth = Convert.ToInt32(GridView1.GetRowCellValue(i, "Order Month"))
                            Else
                                .OrderMonth = 0
                            End If

                            .ChangeFrom = Convert.ToString(GridView1.GetRowCellValue(i, "Change From"))
                            ._Active = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Active"))
                            .DRR = IIf(GridView1.GetRowCellValue(i, "DRR") Is DBNull.Value, 0, GridView1.GetRowCellValue(i, "DRR"))

                        End With
                        fc_Class.Collection_Detail.Add(NPP_Detail)
                    Next
                    'fc_Class.UpdateData(fs_Code)
                    fc_Class.Update(fc_Class.H_No_NPP)
                    bs_Filter = gh_Common.GroupID
                    GridDtl.DataSource = fc_Class_Head.Get_NPP()
                    IsClosed = True
                    Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                    Me.Hide()

                Else
                    If TRevisiInformasi.EditValue = "" Then
                        MessageBox.Show("Please fill Revice Information", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If

                    With fc_Class
                        .H_Issue_Date = TIssue_Date.EditValue
                        .H_No_NPP = TNPP_No.EditValue
                        .H_Model_Name = TModel.EditValue
                        .H_Model_Description = TModelDesc.EditValue
                        .H_Customer_Name = TCustomer.EditValue
                        .H_Order_Month = TOrderMonth.EditValue
                        .H_Order_Max_Month = TOrderMaxMonth.EditValue
                        If TMassPro.Text = "" Then
                            .H_MassPro = "01-01-1900"
                        Else
                            .H_MassPro = TMassPro.EditValue

                        End If
                        .H_Drawing = CBDrawing.CheckState
                        .H_CAD_Data = CBCad.CheckState
                        .H_Sample = CBSample.CheckState
                        .H_Special_Technical_Requires = CBStr.CheckState
                        .H_Category_Class = TCategory.EditValue
                        .H_Factory_Tsc_TNG = CBTng.CheckState
                        .H_Factory_Tsc_CKR = CBCkr.CheckState
                        .H_RevInformasi = TRevisiInformasi.EditValue
                        .H_TargetDRR = TTargetDr.EditValue
                        .H_TargetQuot = TTargetQuot.EditValue
                        .H_RevStatus = False

                        .H_Rev = .H_Rev + 1

                    End With

                    'Insert To ObjDetailMaterial
                    fc_Class.Collection_Detail.Clear()
                    For i As Integer = 0 To GridView1.RowCount - 1

                        NPP_Detail = New Col_Cls_NPP_Detail_NPP
                        With NPP_Detail

                            .No_Npwo = TNPP_No.EditValue
                            .Part_No = Convert.ToString(GridView1.GetRowCellValue(i, "Part No"))
                            .Part_Name = Convert.ToString(GridView1.GetRowCellValue(i, "Part Name"))
                            .Machine = Convert.ToString(GridView1.GetRowCellValue(i, "Machine"))
                            '.Cycle_Time = Convert.ToString(GridView1.GetRowCellValue(i, "C/T"))
                            .Cavity = Convert.ToString(GridView1.GetRowCellValue(i, "Cav"))
                            '.Weight = Convert.ToDouble(GridView1.GetRowCellValue(i, "Weight"))
                            .Material_Resin = Convert.ToString(GridView1.GetRowCellValue(i, "Material"))
                            .Injection = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Inj"))
                            .Painting = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Painting"))
                            .Chrome = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Chrome"))
                            .Vibration = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Vibration"))
                            .Assy = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Assy"))
                            .Ultrasonic = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Ultrasonic"))
                            .StatusMold = Convert.ToString(GridView1.GetRowCellValue(i, "Status Mold"))
                            '.OrderMonth = Convert.ToInt32(GridView1.GetRowCellValue(i, "Order Month"))
                            .MoldNumber = Convert.ToString(GridView1.GetRowCellValue(i, "Group ID"))
                            .Rev = fc_Class.H_Rev
                            .Revisi = Convert.ToString(GridView1.GetRowCellValue(i, "Revisi"))
                            .Status = Convert.ToString(GridView1.GetRowCellValue(i, "Status"))
                            .Cek = Convert.ToString(GridView1.GetRowCellValue(i, "Cek"))
                            .Note = Convert.ToString(GridView1.GetRowCellValue(i, "Note"))
                            '.Runner = Convert.ToDouble(GridView1.GetRowCellValue(i, "Runner"))
                            .Seq = Convert.ToInt64(GridView1.GetRowCellValue(i, "Seq"))
                            .Commit = IIf(GridView1.GetRowCellValue(i, "Commit NPD") Is DBNull.Value, False, GridView1.GetRowCellValue(i, "Commit NPD"))
                            .Capability = IIf(GridView1.GetRowCellValue(i, "Due Date NPD") Is DBNull.Value, Nothing, GridView1.GetRowCellValue(i, "Due Date NPD"))

                            If IsNumeric(GridView1.GetRowCellValue(i, "No Urut")) = True Then
                                .NoUrut = Convert.ToInt64(GridView1.GetRowCellValue(i, "No Urut"))
                            Else
                                .NoUrut = 0
                            End If


                            If IsNumeric(GridView1.GetRowCellValue(i, "C/T")) = True Then
                                .Cycle_Time = Convert.ToString(GridView1.GetRowCellValue(i, "C/T"))
                            Else
                                .Cycle_Time = 0
                            End If
                            If IsNumeric(GridView1.GetRowCellValue(i, "Weight")) = True Then
                                .Weight = Convert.ToDouble(GridView1.GetRowCellValue(i, "Weight"))
                            Else
                                .Weight = 0
                            End If
                            If IsNumeric(GridView1.GetRowCellValue(i, "Runner")) = True Then
                                .Runner = Convert.ToDouble(GridView1.GetRowCellValue(i, "Runner"))
                            Else
                                .Runner = 0
                            End If
                            If IsNumeric(GridView1.GetRowCellValue(i, "Order Month")) = True Then
                                .OrderMonth = Convert.ToInt32(GridView1.GetRowCellValue(i, "Order Month"))
                            Else
                                .OrderMonth = 0
                            End If

                            .ChangeFrom = Convert.ToString(GridView1.GetRowCellValue(i, "Change From"))
                            ._Active = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Active"))
                            .DRR = IIf(GridView1.GetRowCellValue(i, "DRR") Is DBNull.Value, 0, GridView1.GetRowCellValue(i, "DRR"))

                        End With
                        fc_Class.Collection_Detail.Add(NPP_Detail)

                    Next

                    'fc_Class.UpdateData(fs_Code)
                    fc_Class.UpdateaAndHistory(fc_Class.H_No_NPP)
                    bs_Filter = gh_Common.GroupID
                    GridDtl.DataSource = fc_Class_Head.Get_NPP()
                    IsClosed = True
                    Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                    Me.Hide()



                End If

            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub


    'Private Sub Frm_Npwo_Detail_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
    '    '_TNPP_No.EditValue = Test
    'End Sub

    Public Sub CallForm(Optional ByVal ID As String = "",
                        Optional ByVal Nama As String = "",
                        Optional ByVal Machine As String = "",
                        Optional ByVal CycleTime As String = "",
                        Optional ByVal Cav As String = "",
                        Optional ByVal Weight As String = "",
                        Optional ByVal Material As String = "",
                        Optional ByVal Inj As Boolean = False,
                        Optional ByVal Paint As Boolean = False,
                        Optional ByVal Chrome As Boolean = False,
                        Optional ByVal Assy As Boolean = False,
                        Optional ByVal Ultrasonic As Boolean = False,
                        Optional ByVal Vibration As Boolean = False,
                        Optional ByVal StatusMold As String = "",
                        Optional ByVal OrderMonth As String = "",
                        Optional ByVal IsNew As Boolean = True)

        If CForm = 1 Then
            frmSetGroup = New Frm_NPP_Set_Grup(TNPP_No.EditValue, ID, Nama, False, False, DtGridNPWO, Grid)
            frmSetGroup.StartPosition = FormStartPosition.CenterScreen
            frmSetGroup.MaximizeBox = False
            frmSetGroup.ShowDialog()
        ElseIf CForm = 3 Then
            frmPrepare = New Frm_NPP_Prepare(ID)
            frmPrepare.StartPosition = FormStartPosition.CenterScreen
            frmPrepare.MaximizeBox = False
            frmPrepare.ShowDialog()
        Else
            frmInput = New Frm_Input_NPPDetail(ID, Nama, Machine, CycleTime, Cav, Weight, Material, Inj, Paint, Chrome, Assy, Ultrasonic, Vibration, StatusMold, OrderMonth, IsNew, DtGridNPWO, Grid, TOrderMonth.EditValue, TNPP_No.EditValue)
            frmInput.StartPosition = FormStartPosition.CenterScreen
            frmInput.MaximizeBox = False
            frmInput.ShowDialog()
        End If



    End Sub

    Private Sub TOrderMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOrderMonth.KeyPress

        Dim tombol As Integer
        tombol = Asc(e.KeyChar)

        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 13) Or (tombol = 44)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TOrderMaxMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOrderMaxMonth.KeyPress

        Dim tombol As Integer
        tombol = Asc(e.KeyChar)

        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 13) Or (tombol = 44)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Grid_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid.KeyDown

        If e.KeyData = Keys.Delete Then

            Dim DRR As Boolean = IIf(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DRR") Is DBNull.Value, 0, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DRR"))

            If DRR = False Then
                GridView1.DeleteRow(GridView1.FocusedRowHandle)
                GridView1.RefreshData()
                Grid.Refresh()
                DtGridNPWO.AcceptChanges()
            Else
                MessageBox.Show("Data Cannot Be Deleted Already DRR",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            End If

            'Dim baseEdit = TryCast(sender, BaseEdit)
            'Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
            'gridView.PostEditor()
            'gridView.UpdateCurrentRow()

        End If
    End Sub

    Public Overrides Sub Proc_Approve()

        fc_Class.GetDataByID(fs_Code)
        If Active_Form = 1 Then
            If fc_Class.H_Approve = 0 Then
                Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Approve " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Try
                        fc_Class = New Cls_NPP_Detail
                        With fc_Class
                            .H_Approve = 1
                            .H_Status = "Submit"
                            .H_Note = ""
                            .TA_Username = gh_Common.Username
                            .TA_MenuCode = MenuCode
                            .TA_DeptID = gh_Common.GroupID
                            .TA_NoTransaksi = TNPP_No.EditValue
                            .TA_LevelApprove = Active_Form
                            .TA_StatusApprove = "Submit"
                            .TA_ApproveBy = gh_Common.Username
                            .TA_ApproveDAte = Date.Now
                            .TA_IsActive = 1

                        End With

                        fc_Class.UpdateApprove(fs_Code)
                        bs_Filter = gh_Common.Username()
                        'GridDtl.DataSource = fc_Class_Head.Get_NPP()
                        _frmNPPHeader = New Frm_NPP_Header
                        _frmNPPHeader.NPP_Head_LoadGrid(Active_Form)
                        IsClosed = True
                        Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                        Me.Hide()
                    Catch ex As Exception
                        ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                        WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
                    End Try

                End If
            Else
                XtraMessageBox.Show("NPP '" & fs_Code & "' has been Submitted  ?", "Confirmation", MessageBoxButtons.OK)
            End If

            'ElseIf Active_Form = 2 Then
            '    If fc_Class.H_Approve_Dept_Head = False Then
            '        Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Approve " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
            '        If result = System.Windows.Forms.DialogResult.Yes Then
            '            Try
            '                fc_Class = New Cls_NPP_Detail
            '                With fc_Class
            '                    .H_Approve = 1
            '                    .H_Approve_Dept_Head = 1
            '                    .H_Approve_Dept_Head_Date = Date.Now
            '                    .H_Approve_Dept_Head_Name = gh_Common.Username
            '                    .H_Note = ""
            '                End With



            '                'Next
            '                fc_Class.Update_DeptHead(fs_Code)
            '                bs_Filter = gh_Common.Username()
            '                GridDtl.DataSource = fc_Class_Head.Get_NPP_DeptHead()

            '                IsClosed = True
            '                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            '                Me.Hide()
            '            Catch ex As Exception
            '                ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            '                WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            '            End Try

            '        End If
            '    Else
            '        XtraMessageBox.Show("NPP '" & fs_Code & "' has been Submitted  ?", "Confirmation", MessageBoxButtons.OK)
            '    End If

            'ElseIf Active_Form = 3 Then

            '    If fc_Class.H_Approve_Div_Head = False Then
            '        Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Approve " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
            '        If result = System.Windows.Forms.DialogResult.Yes Then
            '            Try
            '                fc_Class = New Cls_NPP_Detail
            '                With fc_Class
            '                    .H_Approve = 1
            '                    .H_Approve_Div_Head = 1
            '                    .H_Approve_Div_Head_Date = Date.Now
            '                    .H_Approve_Div_Head_Name = gh_Common.Username
            '                End With


            '                fc_Class.Update_DivHead(fs_Code)
            '                bs_Filter = gh_Common.Username()
            '                GridDtl.DataSource = fc_Class_Head.Get_NPP_DivHead()

            '                IsClosed = True
            '                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            '                Me.Hide()
            '            Catch ex As Exception
            '                ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            '                WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            '            End Try

            '        End If
            '    Else
            '        XtraMessageBox.Show("NPP '" & fs_Code & "' has been Submitted  ?", "Confirmation", MessageBoxButtons.OK)
            '    End If

        ElseIf Active_Form = 4 Then

            With fc_Class
                .H_Issue_Date = TIssue_Date.EditValue
                .H_No_NPP = TNPP_No.EditValue
                .H_Model_Name = TModel.EditValue
                .H_Model_Description = TModelDesc.EditValue
                .H_Customer_Name = TCustomer.EditValue
                .H_Order_Month = TOrderMonth.EditValue
                .H_Order_Max_Month = TOrderMaxMonth.EditValue
                If TMassPro.Text = "" Then
                    .H_MassPro = "01-01-1900"
                Else
                    .H_MassPro = TMassPro.EditValue

                End If
                .H_Drawing = CBDrawing.CheckState
                .H_CAD_Data = CBCad.CheckState
                .H_Sample = CBSample.CheckState
                .H_Special_Technical_Requires = CBStr.CheckState
                .H_Category_Class = TCategory.EditValue
                .H_Factory_Tsc_TNG = CBTng.CheckState
                .H_Factory_Tsc_CKR = CBCkr.CheckState
                .H_Rev = TRevisi.EditValue
                .H_RevInformasi = TRevisiInformasi.EditValue
                .H_TargetDRR = TTargetDr.EditValue
                .H_TargetQuot = TTargetQuot.EditValue
                .H_RevInformasi = TRevisiInformasi.EditValue

            End With

            'Insert To ObjDetailMaterial
            fc_Class.Collection_Detail.Clear()
            For i As Integer = 0 To GridView1.RowCount - 1

                NPP_Detail = New Col_Cls_NPP_Detail_NPP
                With NPP_Detail

                    .No_Npwo = TNPP_No.EditValue
                    .Part_No = Convert.ToString(GridView1.GetRowCellValue(i, "Part No"))
                    .Part_Name = Convert.ToString(GridView1.GetRowCellValue(i, "Part Name"))
                    .Machine = Convert.ToString(GridView1.GetRowCellValue(i, "Machine"))
                    .Cycle_Time = Convert.ToString(GridView1.GetRowCellValue(i, "C/T"))
                    .Cavity = Convert.ToString(GridView1.GetRowCellValue(i, "Cav"))
                    .Weight = Convert.ToDouble(GridView1.GetRowCellValue(i, "Weight"))
                    .Material_Resin = Convert.ToString(GridView1.GetRowCellValue(i, "Material"))
                    .Injection = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Inj"))
                    .Painting = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Painting"))
                    .Chrome = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Chrome"))
                    .Vibration = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Vibration"))
                    .Assy = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Assy"))
                    .Ultrasonic = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Ultrasonic"))
                    .StatusMold = Convert.ToString(GridView1.GetRowCellValue(i, "Status Mold"))
                    .OrderMonth = Convert.ToInt32(GridView1.GetRowCellValue(i, "Order Month"))
                    .MoldNumber = Convert.ToString(GridView1.GetRowCellValue(i, "Group ID"))
                    .Revisi = Convert.ToString(GridView1.GetRowCellValue(i, "Revisi"))
                    .Status = Convert.ToString(GridView1.GetRowCellValue(i, "Status"))
                    .Cek = Convert.ToString(GridView1.GetRowCellValue(i, "Cek"))
                    .Note = Convert.ToString(GridView1.GetRowCellValue(i, "Note"))
                    .Seq = Convert.ToInt64(GridView1.GetRowCellValue(i, "Seq"))
                    .Capability = IIf(GridView1.GetRowCellValue(i, "Due Date NPD") Is DBNull.Value, Nothing, GridView1.GetRowCellValue(i, "Due Date NPD"))
                    .Commit = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Commit NPD"))
                End With
                fc_Class.Collection_Detail.Add(NPP_Detail)

            Next


            'fc_Class.UpdateData(fs_Code)
            fc_Class.Update_NPD(TNPP_No.EditValue)
            bs_Filter = gh_Common.GroupID
            GridDtl.DataSource = fc_Class_Head.Get_NPP_NPD()
            IsClosed = True
            Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            Me.Hide()

        End If


    End Sub

    Private Sub TCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCategory.KeyPress
        Dim tombol As Integer
        tombol = Asc(e.KeyChar)

        If Not (tombol = 0) Then
            e.Handled = True
        End If
    End Sub

    Public Overrides Sub Proc_Print()

        fc_Class.GetDataByID(fs_Code)
        If fc_Class.H_Approve >= 1 Then

            'CForm = 3
            'CallForm(fs_Code)


            FrmReport = New ReportNPWO
            FrmReport.NPP_No = TNPP_No.EditValue
            FrmReport.REV = TRevisi.EditValue

            FrmReport.StartPosition = FormStartPosition.CenterScreen
            FrmReport.WindowState = FormWindowState.Maximized
            FrmReport.MaximizeBox = False
            FrmReport.ShowDialog()

        Else

            MessageBox.Show("NPP No " & TNPP_No.EditValue & " Must be Approved First",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub TModel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TModel.KeyPress
        'e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick

        Try
            Dim provider As CultureInfo = CultureInfo.InvariantCulture
            Dim NoSeq As Integer
            'fc_ClassCRUD = New ClsCR_CreateUser
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            For Each rowHandle As Integer In selectedRows
                If rowHandle >= 0 Then
                    NoSeq = GridView1.GetRowCellValue(rowHandle, "Seq")
                End If
            Next rowHandle

            Dim GServis As New GlobalService
            Dim NoNPP As String = TNPP_No.EditValue
            Dim dtDrr As New DataTable
            Dim NoDRR As String = ""
            dtDrr = GServis.GetNoDRR(NoSeq, NoNPP)

            If dtDrr.Rows.Count <= 0 Then

                MessageBox.Show("Data Not Found",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                Exit Sub

            Else
                If dtDrr.Rows(0).Item("Release") <> 3 Then
                    MessageBox.Show("DRR is Still Process",
                               "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1)
                    Exit Sub
                Else
                    NoDRR = dtDrr.Rows(0).Item("IdDRR")

                    If GridView1.GetSelectedRows.Length > 0 Then
                        Call CallFrm(NoDRR, NoNPP,
                                    GridView1.RowCount)
                    End If
                End If

            End If

        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub


    Private Sub TModelDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TModelDesc.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub SingleCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SingleCheck.CheckedChanged

        'Try
        '    'Part No
        '    Dim Kode As Boolean = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Single"))
        '    Dim baseEdit = TryCast(sender, BaseEdit)
        '    Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        '    gridView.PostEditor()
        '    gridView.UpdateCurrentRow()

        '    If Kode = False Then
        '        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Mold Number", GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Part No"))
        '    Else Kode = True
        '        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Mold Number", "")
        '    End If

        'Catch ex As Exception
        '    ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        '    WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        'End Try

        Dim Kode As Boolean = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Single"))
        If Kode = False Then
            Dim Check As Boolean = True
            Dim Cek As String = ""
            Cek = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Mold Number")

            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "Mold Number") = Cek Then
                    GridView1.SetRowCellValue(i, "Single", Check)
                End If
            Next
        Else
            Dim Check As Boolean = False
            Dim Cek As String = ""
            Cek = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Mold Number")

            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "Mold Number") = Cek Then
                    GridView1.SetRowCellValue(i, "Single", Check)
                End If
            Next
        End If



    End Sub

    Private Sub BSetGroup_Click(sender As Object, e As EventArgs) Handles BSetGroup.Click

        CForm = 1

        CallForm()

    End Sub

    Private Sub BUpload_Click(sender As Object, e As EventArgs) Handles BUpload.Click

        If TModel.Text = "" Then
            MessageBox.Show("Please Fill Model",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
        Else

            Try
                Dim Sheet As String = "NPP$A21:AZ300"

                Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Files|*.xls;*.xlsx"}

                    If ofd.ShowDialog() = DialogResult.OK Then
                        FileLokasi = ofd.FileName
                        'TxtFileName.Text = FileLokasi

                        If IO.File.Exists(FileLokasi) Then

                            Dim cb As New OleDbConnectionStringBuilder With {.DataSource = FileLokasi, .Provider = "Microsoft.ACE.OLEDB.12.0"}  'Microsoft.ACE.OLEDB.12.0     Microsoft.Jet.OLEDB.4.0
                            cb.Add("Extended Properties", "Excel 8.0; IMEX=1; HDR=No;")
                            Dim cn As New System.Data.OleDb.OleDbConnection With {.ConnectionString = cb.ConnectionString}
                            cn.Open()
                            Dim cmd As OleDbCommand = New OleDbCommand("SELECT F2 as PartNo
                                                                      ,F3 as PartName
                                                                      ,F4 as MC
                                                                      ,F5 as CT
                                                                      ,F6 as Cav
                                                                      ,F7 as Berat
                                                                      ,F8 as Runner
                                                                      ,F9 as Material
                                                                      ,F10 as Inj
                                                                      ,F11 as Painting
                                                                      ,F12 as Chrome
                                                                      ,F13 as Assy
                                                                      ,F14 as Ultrasonic
                                                                      ,F15 as Vibration
                                                                      ,F19 as Bulan
                                                                      ,F20 as Status
                                                                      ,F21 as Revisi from [" & Sheet & "]
                                                               Where F2 <>''", cn)
                            'Dim dtLimaBesar As New DataTable
                            dtExcel = New DataTable
                            dtExcel.Load(cmd.ExecuteReader)
                            cn.Close()
                        End If

                        For i As Integer = 0 To dtExcel.Rows.Count - 1

                            Dim Sequence As New DataTable
                            Sequence = fc_Class.Get_Sequence_NppDetail()
                            Dim Seq As Integer = Val(Sequence.Rows(0).Item(0)) + 1

                            'Dim dt_SeqGroup As New DataTable
                            'dt_SeqGroup = fc_Class.Get_Sequence_GroupID()
                            'Dim SeqGroup As Integer = Val(dt_SeqGroup.Rows(0).Item(0)) + 1
                            Dim GroupID As String = "G" & Seq

                            Dim MyNewRow As DataRow
                            MyNewRow = DtGridNPWO.NewRow
                            'Dim GroupID As String = fc_Class.GetGroupIDAuto(DtGridNPWO.Rows.Count, RowsAwal)
                            With MyNewRow
                                .Item("Part No") = dtExcel.Rows(i).Item("PartNo")
                                .Item("Part Name") = dtExcel.Rows(i).Item("PartName")
                                .Item("Machine") = dtExcel.Rows(i).Item("MC")

                                If IsNumeric(dtExcel.Rows(i).Item("CT")) = True Then
                                    .Item("C/T") = dtExcel.Rows(i).Item("CT")
                                Else
                                    .Item("C/T") = 0
                                End If

                                .Item("Cav") = dtExcel.Rows(i).Item("Cav")

                                If IsNumeric(dtExcel.Rows(i).Item("Berat")) = True Then
                                    .Item("Weight") = dtExcel.Rows(i).Item("Berat")
                                Else
                                    .Item("Weight") = 0
                                End If

                                If IsNumeric(dtExcel.Rows(i).Item("Runner")) = True Then
                                    .Item("Runner") = dtExcel.Rows(i).Item("Runner")
                                Else
                                    .Item("Runner") = 0
                                End If

                                .Item("Material") = dtExcel.Rows(i).Item("Material")

                                Dim inj As String = Trim(Convert.ToString(dtExcel.Rows(i).Item("Inj")))
                                If inj = "1" Then
                                    .Item("Inj") = 1
                                Else
                                    .Item("Inj") = 0
                                End If

                                Dim Painting As String = Trim(Convert.ToString(dtExcel.Rows(i).Item("Painting")))
                                If Painting = "1" Then
                                    .Item("Painting") = 1
                                Else
                                    .Item("Painting") = 0
                                End If

                                Dim Chrome As String = Trim(Convert.ToString(dtExcel.Rows(i).Item("Chrome")))
                                If Chrome = "1" Then
                                    .Item("Chrome") = 1
                                Else
                                    .Item("Chrome") = 0
                                End If

                                Dim Assy As String = Trim(Convert.ToString(dtExcel.Rows(i).Item("Assy")))
                                If Assy = "1" Then
                                    .Item("Assy") = 1
                                Else
                                    .Item("Assy") = 0
                                End If

                                Dim Vibration As String = Trim(Convert.ToString(dtExcel.Rows(i).Item("Vibration")))
                                If Vibration = "1" Then
                                    .Item("Vibration") = 1
                                Else
                                    .Item("Vibration") = 0
                                End If

                                Dim Ultrasonic As String = Trim(Convert.ToString(dtExcel.Rows(i).Item("Ultrasonic")))
                                If Ultrasonic = "1" Then
                                    .Item("Ultrasonic") = 1
                                Else
                                    .Item("Ultrasonic") = 0
                                End If

                                .Item("Status Mold") = ""

                                If IsNumeric(dtExcel.Rows(i).Item("Bulan")) = True Then
                                    .Item("Order Month") = dtExcel.Rows(i).Item("Bulan")
                                Else
                                    .Item("Order Month") = 0
                                End If

                                .Item("Group ID") = GroupID
                                .Item("Status") = dtExcel.Rows(i).Item("Status")
                                .Item("Revisi") = dtExcel.Rows(i).Item("Revisi")
                                .Item("Seq") = Seq
                                .Item("No Urut") = i + 1
                                .Item("Active") = True
                            End With
                            DtGridNPWO.Rows.Add(MyNewRow)
                            DtGridNPWO.AcceptChanges()
                            fc_Class.Update_Seq_NPPDetail(Seq)
                        Next

                    End If

                End Using
            Catch ex As Exception
                WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            End Try
        End If

    End Sub

    Private Sub Check_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Check.KeyPress
        Dim tombol As Integer
        tombol = Asc(e.KeyChar)

        If (tombol <> 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub B_Submit_Click(sender As Object, e As EventArgs) Handles B_Submit.Click

        Dim result As DialogResult = XtraMessageBox.Show("Are You Want Submit To NPD " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = System.Windows.Forms.DialogResult.Yes Then
            fc_Class = New Cls_NPP_Detail
            With fc_Class
                .H_Submit_NPD = 1
                .H_Submit_NPD_Date = Date.Now
            End With

            fc_Class.Update_Submit_To_NPD(fs_Code)
            bs_Filter = gh_Common.Username()
            GridDtl.DataSource = fc_Class_Head.Get_NPP()

            IsClosed = True
            Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
            Me.Hide()
        End If

    End Sub

    Private Sub B_Approve_Click(sender As Object, e As EventArgs) Handles B_Approve.Click

        Dim dtAprovel As New DataTable

        If Active_Form = 2 Then
            If fc_Class.H_Approve = 1 Then
                Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Approve " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Try
                        fc_Class = New Cls_NPP_Detail
                        With fc_Class

                            .H_Approve = Active_Form
                            .H_Status = "Approve Dept Head"
                            .H_Note = ""
                            .H_Prepare = gh_Common.Username

                            .TA_Username = gh_Common.Username
                            .TA_MenuCode = MenuCode
                            .TA_DeptID = gh_Common.GroupID
                            .TA_NoTransaksi = TNPP_No.EditValue
                            .TA_LevelApprove = Active_Form
                            .TA_StatusApprove = "Approved"
                            .TA_ApproveBy = gh_Common.Username
                            .TA_ApproveDAte = Date.Now
                            .TA_IsActive = 1

                            '.H_Approve = 1
                            '.H_Approve_Dept_Head = 1
                            '.H_Approve_Dept_Head_Date = Date.Now
                            '.H_Approve_Dept_Head_Name = gh_Common.Username
                            '.H_Status = "Approve Dept Head"

                        End With

                        fc_Class.UpdateApprove(fs_Code)
                        bs_Filter = gh_Common.Username()
                        _frmNPPHeader = New Frm_NPP_Header
                        _frmNPPHeader.NPP_Head_LoadGrid(Active_Form)
                        'GridDtl.DataSource = fc_Class_Head.Get_NPP_DeptHead()
                        '_frmNPPHeader.NPP_Head_LoadGrid()

                        IsClosed = True
                        Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                        Me.Hide()
                    Catch ex As Exception
                        ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                        WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
                    End Try

                End If
            Else
                XtraMessageBox.Show("NPP '" & fs_Code & "' has been Submitted  ?", "Confirmation", MessageBoxButtons.OK)
            End If

        ElseIf Active_Form = 3 Then

            If fc_Class.H_Approve = 2 Then
                Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Approve " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Try
                        fc_Class = New Cls_NPP_Detail
                        With fc_Class
                            .H_Approve = Active_Form
                            .H_Status = "Approve Div Head"
                            .H_Note = ""
                            .H_Prepare = gh_Common.Username

                            .TA_Username = gh_Common.Username
                            .TA_MenuCode = MenuCode
                            .TA_DeptID = gh_Common.GroupID
                            .TA_NoTransaksi = TNPP_No.EditValue
                            .TA_LevelApprove = Active_Form
                            .TA_StatusApprove = "Approved"
                            .TA_ApproveBy = gh_Common.Username
                            .TA_ApproveDAte = Date.Now
                            .TA_IsActive = 1

                        End With


                        fc_Class.UpdateApprove(fs_Code)
                        bs_Filter = gh_Common.Username()
                        'GridDtl.DataSource = fc_Class_Head.Get_NPP_DivHead()

                        IsClosed = True
                        Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                        Me.Hide()
                    Catch ex As Exception
                        ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                        WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
                    End Try

                End If
            Else
                XtraMessageBox.Show("NPP '" & fs_Code & "' has been Submitted  ?", "Confirmation", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub B_Reject_Click(sender As Object, e As EventArgs) Handles B_Reject.Click

        Dim Note As String = InputBox("Enter Value", "Enter Value", "Please Enter Value")

        If Active_Form = 2 Then
            If fc_Class.H_Approve = 1 Or fc_Class.H_Approve = 2 Then
                Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Reject " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Try
                        fc_Class = New Cls_NPP_Detail
                        With fc_Class
                            .H_Approve = 0
                            .H_Status = "Revise"
                            .H_Note = Note
                            .H_Prepare = ""

                            .TA_Username = gh_Common.Username
                            .TA_MenuCode = MenuCode
                            .TA_DeptID = gh_Common.GroupID
                            .TA_NoTransaksi = TNPP_No.EditValue
                            .TA_LevelApprove = Active_Form
                            .TA_StatusApprove = "Reject"
                            .TA_ApproveBy = gh_Common.Username
                            .TA_ApproveDAte = Date.Now
                            .TA_IsActive = 0
                        End With

                        fc_Class.UpdateApprove(fs_Code)
                        fc_Class.UpdateTb_Approve_History(fs_Code, FrmParent.Name.ToString)
                        bs_Filter = gh_Common.Username()
                        'GridDtl.DataSource = fc_Class_Head.Get_NPP_DeptHead()

                        IsClosed = True
                        Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                        Me.Hide()
                    Catch ex As Exception
                        ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                        WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
                    End Try

                End If
            Else
                XtraMessageBox.Show("NPP '" & fs_Code & "' Cannot Be Reject !", "Confirmation", MessageBoxButtons.OK)
            End If

        ElseIf Active_Form = 3 Then
            If fc_Class.H_Approve = 2 Or fc_Class.H_Approve = 3 Then
                Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Reject " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Try

                        fc_Class = New Cls_NPP_Detail
                        With fc_Class
                            .H_Approve = 0
                            .H_Status = "Revise"
                            .H_Note = Note
                            .H_Prepare = ""

                            .TA_Username = gh_Common.Username
                            .TA_MenuCode = MenuCode
                            .TA_DeptID = gh_Common.GroupID
                            .TA_NoTransaksi = TNPP_No.EditValue
                            .TA_LevelApprove = Active_Form
                            .TA_StatusApprove = "Reject"
                            .TA_ApproveBy = gh_Common.Username
                            .TA_ApproveDAte = Date.Now
                            .TA_IsActive = 0
                        End With
                        fc_Class.UpdateApprove(fs_Code)
                        fc_Class.UpdateTb_Approve_History(fs_Code, FrmParent.ToString)
                        ' Call LoadGrid(fs_Code)
                        bs_Filter = gh_Common.Username()
                        'GridDtl.DataSource = fc_Class_Head.Get_NPP_DivHead()

                        IsClosed = True
                        Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                        Me.Hide()
                    Catch ex As Exception
                        ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                        WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
                    End Try

                End If
            Else
                XtraMessageBox.Show("NPP '" & fs_Code & "' Cannot Be Reject !", "Confirmation", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If Active_Form = 4 Then
            Try
                Dim Comit As Boolean
                Dim _Active As Boolean
                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        Comit = GridView1.GetRowCellValue(rowHandle, "Commit1")
                        _Active = GridView1.GetRowCellValue(rowHandle, "Active")
                    End If
                Next rowHandle
                If Comit = True Or _Active = False Then
                    GridView1.Columns("Commit NPD").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Due Date NPD").OptionsColumn.AllowEdit = False
                Else
                    GridView1.Columns("Commit NPD").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Due Date NPD").OptionsColumn.AllowEdit = True
                End If
            Catch ex As Exception
                Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            End Try
        ElseIf Active_Form = 1 Then
            Try
                Dim _Active As Boolean
                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        _Active = GridView1.GetRowCellValue(rowHandle, "Active")
                    End If
                Next rowHandle

                If _Active = False Then
                    GridView1.Columns("Part No").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Part Name").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Machine").OptionsColumn.AllowEdit = False
                    GridView1.Columns("C/T").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Cav").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Weight").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Material").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Inj").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Painting").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Chrome").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Assy").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Ultrasonic").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Vibration").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Status Mold").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Order Month").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Group ID").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Revisi").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Status").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Due Date NPD").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Commit NPD").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Note").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Active").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Change From").OptionsColumn.AllowEdit = False
                    GridView1.Columns("No Urut").OptionsColumn.AllowEdit = False
                    GridView1.Columns("DRR").OptionsColumn.AllowEdit = False
                    GridView1.Columns("Runner").OptionsColumn.AllowEdit = False
                Else _Active = True
                    GridView1.Columns("Part No").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Part Name").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Machine").OptionsColumn.AllowEdit = True
                    GridView1.Columns("C/T").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Cav").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Weight").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Material").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Inj").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Painting").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Chrome").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Assy").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Ultrasonic").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Vibration").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Status Mold").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Order Month").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Group ID").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Revisi").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Status").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Due Date NPD").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Commit NPD").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Note").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Active").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Change From").OptionsColumn.AllowEdit = True
                    GridView1.Columns("No Urut").OptionsColumn.AllowEdit = True
                    GridView1.Columns("DRR").OptionsColumn.AllowEdit = True
                    GridView1.Columns("Runner").OptionsColumn.AllowEdit = True

                End If



            Catch ex As Exception

            End Try

            'If fc_Class.H_Approve_Div_Head = True And fc_Class.H_Submit_NPD = True Then
            '    Try
            '        'Dim Comit As Boolean
            '        'Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            '        'For Each rowHandle As Integer In selectedRows
            '        '    If rowHandle >= 0 Then
            '        '        Comit = GridView1.GetRowCellValue(rowHandle, "Commit1")
            '        '    End If
            '        'Next rowHandle
            '        'If Comit = True Then
            '        Call Colums_AllowEdit_True()
            '        'Me.PartNo.OptionsColumn.AllowEdit = False
            '        'Me.PartName.OptionsColumn.AllowEdit = False
            '        Me.CapabilityDate.OptionsColumn.AllowEdit = False
            '        'Else
            '        '    Call Colums_AllowEdit_False()
            '        'End If
            '    Catch ex As Exception
            '        Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            '        WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            '    End Try
            'End If
        End If
    End Sub

    Private Sub B_Revise_Click(sender As Object, e As EventArgs) Handles B_Revise.Click
        If Active_Form = 2 Then

            Dim result As DialogResult = XtraMessageBox.Show("Are You Sure To Revise " & fs_Code & "  ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Try
                    fc_Class = New Cls_NPP_Detail
                    With fc_Class
                        .H_Approve = 0
                        .H_Approve_Dept_Head = 0
                        .H_Approve_Div_Head = 0
                        .H_Submit_NPD = 0
                        .H_RevStatus = 1
                        .H_Status = "Revise"
                    End With


                    fc_Class.Update_DeptHead_Revisi(fs_Code)
                    bs_Filter = gh_Common.Username()
                    GridDtl.DataSource = fc_Class_Head.Get_NPP_DeptHead()

                    IsClosed = True
                    Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)
                    Me.Hide()
                Catch ex As Exception
                    ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
                    WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
                End Try
            End If

        End If
    End Sub

    Private Sub RepoCapability_DateTimeChanged(sender As Object, e As EventArgs) Handles RepoCapability.DateTimeChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub RepoComit_CheckedChanged(sender As Object, e As EventArgs) Handles RepoComit.CheckedChanged
        Dim baseEdit = TryCast(sender, BaseEdit)
        Dim gridView = (TryCast((TryCast(baseEdit.Parent, GridControl)).MainView, GridView))
        gridView.PostEditor()
        gridView.UpdateCurrentRow()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim myValue As String = InputBox("Enter Value", "Enter Value", "Please Enter Value")
    End Sub

    Private Sub B_Replace_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles B_ChangeFrom.ButtonClick
        Try
            Dim DRR As Boolean = IIf(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DRR") Is DBNull.Value, 0, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DRR"))
            Dim _Active As Boolean = IIf(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Active") Is DBNull.Value, 0, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Active"))

            If DRR = False Or _Active = False Then
                MessageBox.Show("Data Canot be Revise",
                               "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1)
            Else

                Dim Sequence As New DataTable
                Sequence = fc_Class.Get_Sequence_NppDetail()
                Dim Seq As Integer = Val(Sequence.Rows(0).Item(0)) + 1

                Dim provider As CultureInfo = CultureInfo.InvariantCulture
                Dim PN As String = ""
                'fc_ClassCRUD = New ClsCR_CreateUser
                Dim selectedRows() As Integer = GridView1.GetSelectedRows()
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then

                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Active", False)

                        Dim MyNewRow As DataRow
                        MyNewRow = DtGridNPWO.NewRow
                        With MyNewRow
                            .Item("No Urut") = GridView1.GetRowCellValue(rowHandle, "No Urut")
                            .Item("Part No") = GridView1.GetRowCellValue(rowHandle, "Part No")
                            .Item("Part Name") = GridView1.GetRowCellValue(rowHandle, "Part Name")
                            .Item("Machine") = GridView1.GetRowCellValue(rowHandle, "Machine")
                            .Item("C/T") = GridView1.GetRowCellValue(rowHandle, "C/T")
                            .Item("Cav") = GridView1.GetRowCellValue(rowHandle, "Cav")
                            .Item("Runner") = GridView1.GetRowCellValue(rowHandle, "Runner")
                            .Item("Weight") = GridView1.GetRowCellValue(rowHandle, "Weight")
                            .Item("Qty Mold") = GridView1.GetRowCellValue(rowHandle, "Qty Mold")
                            .Item("Material") = GridView1.GetRowCellValue(rowHandle, "Material")
                            .Item("Inj") = GridView1.GetRowCellValue(rowHandle, "Inj")
                            .Item("Painting") = GridView1.GetRowCellValue(rowHandle, "Painting")
                            .Item("Chrome") = GridView1.GetRowCellValue(rowHandle, "Chrome")
                            .Item("Assy") = GridView1.GetRowCellValue(rowHandle, "Assy")
                            .Item("Status Mold") = GridView1.GetRowCellValue(rowHandle, "Status Mold")
                            .Item("Vibration") = GridView1.GetRowCellValue(rowHandle, "Vibration")
                            .Item("Ultrasonic") = GridView1.GetRowCellValue(rowHandle, "Ultrasonic")
                            .Item("Group ID") = GridView1.GetRowCellValue(rowHandle, "Group ID")
                            .Item("Order Month") = GridView1.GetRowCellValue(rowHandle, "Order Month")
                            .Item("DRR") = False
                            .Item("Due Date NPD") = GridView1.GetRowCellValue(rowHandle, "Due Date NPD")
                            .Item("Commit NPD") = GridView1.GetRowCellValue(rowHandle, "Commit NPD")
                            .Item("Seq") = Seq
                            .Item("Revisi") = GridView1.GetRowCellValue(rowHandle, "Revisi")
                            .Item("Note") = GridView1.GetRowCellValue(rowHandle, "Note")
                            .Item("Change From") = GridView1.GetRowCellValue(rowHandle, "Part No") & "     " & GridView1.GetRowCellValue(rowHandle, "Part Name")
                            .Item("Active") = True
                            .Item("No Urut") = GridView1.RowCount + 1
                        End With
                        DtGridNPWO.Rows.Add(MyNewRow)
                        DtGridNPWO.AcceptChanges()

                    End If
                Next rowHandle

                fc_Class.Update_Seq_NPPDetail(Seq)

            End If

        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            'Dim _Active As Boolean = IIf(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Active") Is DBNull.Value, 0, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Active"))
            Dim _Active As Boolean = IIf(GridView1.GetRowCellValue(e.RowHandle, View.Columns("Active")) Is DBNull.Value, 0, GridView1.GetRowCellValue(e.RowHandle, View.Columns("Active")))
            If _Active = False Then
                e.Appearance.BackColor = Color.OrangeRed
                'e.Appearance.BackColor2 = Color.Yellow
                e.HighPriority = True

            End If
        End If
    End Sub

    Private Sub Frm_NPP_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CreateTableBarang()
        Call FillComboCustomer()
        Call FillComboCategory()
        Call InitialSetForm()
        Me.TOrderMonth.Properties.Mask.EditMask = "n0"
        Me.TOrderMonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TOrderMaxMonth.Properties.Mask.EditMask = "n0"
        Me.TOrderMaxMonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        RowsAwal = DtGridNPWO.Rows.Count

    End Sub

    Private Sub CallFrm(Optional ByVal ls_Code As String = "0", Optional ByVal ls_Code2 As String = "", Optional ByVal li_Row As Integer = 0)
        If ff_Detail IsNot Nothing AndAlso ff_Detail.Visible Then
            If MsgBox(gs_ConfirmDetailOpen, MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            ff_Detail.Close()
        End If
        ff_Detail = New frmDRR_details(ls_Code, ls_Code2, Me, li_Row, Grid, 0)
        ff_Detail.MdiParent = FrmMain
        ff_Detail.StartPosition = FormStartPosition.CenterScreen
        ff_Detail.Show()
    End Sub

    Private Function GetLevel() As Integer
        Dim _ServiceGlobal As GlobalService
        Dim _level As Integer = 0
        Try
            _ServiceGlobal = New GlobalService
            _level = _ServiceGlobal.GetLevel(Me)
            Return _level
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
        Return _level
    End Function
End Class
