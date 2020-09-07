Imports DevExpress.XtraGrid

Public Class frmM_ApprovalDetail
    Public IsClosed As Boolean = False
    Public isCancel As Boolean = False
    Public rs_ReturnCode As String = ""
    Dim isUpdate As Boolean = False
    Dim GridDtl As GridControl
    Dim ls_Error As String = ""
    Dim _Tag As TagModel
    Dim _service As MApproveService
    Dim ObjApprove As MApproveModel
    Public Sub New(ByVal strCode As String,
                   ByVal strCode2 As String,
                   ByRef lf_FormParent As Form,
                   ByVal li_GridRow As Integer,
                   ByRef _Grid As GridControl)

        ' This call is required by the designer.
        InitializeComponent()
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
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmM_ApprovalDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Proc_EnableButtons(False, True, False, True, False, False, False, False, False, False, False, False)
        Call InitialSetForm()
    End Sub
    Public Overrides Sub InitialSetForm()
        Try
            If fs_Code <> "0" Then
                _service = New MApproveService
                ObjApprove = New MApproveModel
                ObjApprove = _service.GetById(Convert.ToInt32(fs_Code))
                If ls_Error <> "" Then
                    Call ShowMessage(ls_Error, MessageTypeEnum.ErrorMessage)
                    isCancel = True
                    Hide()
                    Exit Sub
                Else
                    isUpdate = True
                End If
            End If
            Text = "APPROVE DETAIL"
            'PopulateCustomer()
            'PopulateNPP()
            LoadTxtBox()
            InputBeginState(Me)
            bb_IsUpdate = isUpdate
            bs_MainFormName = FrmParent.Name
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub LoadTxtBox()
        Try
            If fs_Code <> "0" Then

                With ObjApprove
                    TxtUsername.EditValue = .UserName
                    TxtForm.EditValue = .MenuCode
                    TxtDept1.Text = .DeptID
                    TxtLevel.EditValue = .LevelApprove
                End With
            Else
                TxtUsername.EditValue = ""
                TxtForm.EditValue = ""
                TxtDept1.Text = ""
                TxtLevel.EditValue = ""
                TxtUsername.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overrides Sub Proc_Refresh()
        LoadTxtBox()
    End Sub

    Public Overrides Function ValidateSave() As Boolean
        Dim lb_Validated As Boolean = False
        Try
            If DxValidationProvider1.Validate Then
                lb_Validated = True
            Else
                Err.Raise(ErrNumber, , "Data yang anda input tidak valid, silahkan cek inputan anda !")
            End If

            If lb_Validated Then
                ObjApprove = New MApproveModel With {
                    .UserName = TxtUsername.EditValue,
                    .MenuCode = TxtForm.EditValue,
                    .DeptID = TxtDept1.Text,
                    .LevelApprove = TxtLevel.Text
                    }
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
            _service = New MApproveService

            If Not isUpdate Then
                If _service.IsDataExist(ObjApprove) Then
                    Throw New Exception("Data sudah ada !")
                End If
                _service.Add(ObjApprove)

                GridDtl.DataSource = _service.GetAll()
                IsClosed = True
                Call ShowMessage(GetMessage(MessageEnum.SimpanBerhasil), MessageTypeEnum.NormalMessage)

                Hide()
            Else
                _service.Update(ObjApprove)
                GridDtl.DataSource = _service.GetAll()

                IsClosed = True
                ShowMessage(GetMessage(MessageEnum.UpdateBerhasil), MessageTypeEnum.NormalMessage)
                Hide()
            End If
        Catch ex As Exception
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
    Private Sub TxtUsername_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtUsername.ButtonClick, TxtForm.ButtonClick
        Try
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""
            _service = New MApproveService

            If sender.Name = TxtUsername.Name Then
                dtSearch = _service.GetUsername()
                ls_OldKode = TxtUsername.EditValue
                ls_Judul = "Username"
            ElseIf sender.Name = TxtForm.Name Then
                dtSearch = _service.GetFormName()
                ls_OldKode = TxtUsername.EditValue
                ls_Judul = "Form"
            End If


            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim Value1 As String = ""
            Dim Value2 As String = ""
            Dim Value3 As String = ""

            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> "" Then
                Value1 = lF_SearchData.Values.Item(0).ToString.Trim
                Value2 = lF_SearchData.Values.Item(1).ToString.Trim
                If sender.Name = TxtUsername.Name AndAlso Value1 <> "" Then
                    TxtUsername.EditValue = Value1
                    TxtDept1.EditValue = Value2
                    TxtForm.Focus()
                End If
                If sender.Name = TxtForm.Name AndAlso Value1 <> "" AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then
                    TxtForm.EditValue = Value2
                End If
            End If

            lF_SearchData.Close()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        Dim ignoreCancel As Boolean = False
        TxtUsername.DoValidate()
        TxtForm.DoValidate()
        TxtLevel.DoValidate()

        If DxValidationProvider1.GetInvalidControls().Contains(TxtUsername) _
            OrElse DxValidationProvider1.GetInvalidControls().Contains(TxtForm) _
            OrElse DxValidationProvider1.GetInvalidControls().Contains(TxtLevel) Then
            ignoreCancel = True
        Else
            ignoreCancel = True
        End If


        MyBase.OnFormClosing(e)
        e.Cancel = Not ignoreCancel
    End Sub


End Class
