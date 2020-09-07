<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM_ApprovalDetail
    Inherits TSMU.baseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtDept1 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUsername = New DevExpress.XtraEditors.ButtonEdit()
        Me.TxtForm = New DevExpress.XtraEditors.ButtonEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.TxtLevel = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtDept1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtDept1)
        Me.LayoutControl1.Controls.Add(Me.TxtUsername)
        Me.LayoutControl1.Controls.Add(Me.TxtForm)
        Me.LayoutControl1.Controls.Add(Me.TxtLevel)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 27)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(828, 554)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtDept1
        '
        Me.TxtDept1.Location = New System.Drawing.Point(73, 38)
        Me.TxtDept1.Name = "TxtDept1"
        Me.TxtDept1.Properties.ReadOnly = True
        Me.TxtDept1.Size = New System.Drawing.Size(208, 22)
        Me.TxtDept1.StyleController = Me.LayoutControl1
        Me.TxtDept1.TabIndex = 5
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(73, 12)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtUsername.Size = New System.Drawing.Size(208, 22)
        Me.TxtUsername.StyleController = Me.LayoutControl1
        Me.TxtUsername.TabIndex = 4
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Username tidak boleh kosong"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.DxValidationProvider1.SetValidationRule(Me.TxtUsername, ConditionValidationRule1)
        '
        'TxtForm
        '
        Me.TxtForm.Location = New System.Drawing.Point(346, 12)
        Me.TxtForm.Name = "TxtForm"
        Me.TxtForm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtForm.Size = New System.Drawing.Size(202, 22)
        Me.TxtForm.StyleController = Me.LayoutControl1
        Me.TxtForm.TabIndex = 6
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Form tidak boleh kosong"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.DxValidationProvider1.SetValidationRule(Me.TxtForm, ConditionValidationRule2)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(828, 554)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(540, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(268, 534)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtUsername
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(273, 26)
        Me.LayoutControlItem1.Text = "Username"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(58, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtDept1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(273, 508)
        Me.LayoutControlItem2.Text = "Dept"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(58, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtLevel
        Me.LayoutControlItem4.Location = New System.Drawing.Point(273, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(267, 508)
        Me.LayoutControlItem4.Text = "Level"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(58, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtForm
        Me.LayoutControlItem3.Location = New System.Drawing.Point(273, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(267, 26)
        Me.LayoutControlItem3.Text = "Form"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(58, 16)
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'TxtLevel
        '
        Me.TxtLevel.Location = New System.Drawing.Point(346, 38)
        Me.TxtLevel.Name = "TxtLevel"
        Me.TxtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtLevel.Properties.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.TxtLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TxtLevel.Size = New System.Drawing.Size(202, 22)
        Me.TxtLevel.StyleController = Me.LayoutControl1
        Me.TxtLevel.TabIndex = 7
        '
        'frmM_ApprovalDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(828, 581)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmM_ApprovalDetail"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtDept1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TxtDept1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUsername As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtForm As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents TxtLevel As DevExpress.XtraEditors.ComboBoxEdit
End Class
