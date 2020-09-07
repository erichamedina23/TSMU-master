<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTravelCreditCardDetail
    Inherits TSMU.baseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.txtCreditCardID = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCreditCardNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtAccountName = New DevExpress.XtraEditors.TextEdit()
        Me.dtExpDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtBankName = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GridCreditCard = New DevExpress.XtraGrid.GridControl()
        Me.GridViewCreditCard = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CreditCardID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CreditCardNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CCreditCardNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BankName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExpiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtCreditCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtCreditCardNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBankName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCreditCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCreditCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCreditCardNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCreditCardID
        '
        Me.txtCreditCardID.Enabled = False
        Me.txtCreditCardID.Location = New System.Drawing.Point(129, 12)
        Me.txtCreditCardID.MaximumSize = New System.Drawing.Size(120, 22)
        Me.txtCreditCardID.Name = "txtCreditCardID"
        Me.txtCreditCardID.Size = New System.Drawing.Size(62, 22)
        Me.txtCreditCardID.StyleController = Me.LayoutControl1
        Me.txtCreditCardID.TabIndex = 1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.txtCreditCardNumber)
        Me.LayoutControl1.Controls.Add(Me.txtCreditCardID)
        Me.LayoutControl1.Controls.Add(Me.txtAccountName)
        Me.LayoutControl1.Controls.Add(Me.dtExpDate)
        Me.LayoutControl1.Controls.Add(Me.txtType)
        Me.LayoutControl1.Controls.Add(Me.txtBankName)
        Me.LayoutControl1.Location = New System.Drawing.Point(15, 39)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1140, 59)
        Me.LayoutControl1.TabIndex = 15
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtCreditCardNumber
        '
        Me.txtCreditCardNumber.Location = New System.Drawing.Point(312, 12)
        Me.txtCreditCardNumber.Name = "txtCreditCardNumber"
        Me.txtCreditCardNumber.Properties.Mask.EditMask = "0000-0000-0000-9999"
        Me.txtCreditCardNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCreditCardNumber.Properties.Mask.ShowPlaceHolders = False
        Me.txtCreditCardNumber.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCreditCardNumber.Size = New System.Drawing.Size(62, 22)
        Me.txtCreditCardNumber.StyleController = Me.LayoutControl1
        Me.txtCreditCardNumber.TabIndex = 14
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.txtCreditCardNumber, ConditionValidationRule3)
        '
        'txtAccountName
        '
        Me.txtAccountName.Location = New System.Drawing.Point(495, 12)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(84, 22)
        Me.txtAccountName.StyleController = Me.LayoutControl1
        Me.txtAccountName.TabIndex = 3
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.txtAccountName, ConditionValidationRule1)
        '
        'dtExpDate
        '
        Me.dtExpDate.EditValue = Nothing
        Me.dtExpDate.Location = New System.Drawing.Point(1066, 12)
        Me.dtExpDate.MaximumSize = New System.Drawing.Size(130, 22)
        Me.dtExpDate.Name = "dtExpDate"
        Me.dtExpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtExpDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtExpDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dtExpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtExpDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dtExpDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtExpDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.dtExpDate.Size = New System.Drawing.Size(62, 22)
        Me.dtExpDate.StyleController = Me.LayoutControl1
        Me.dtExpDate.TabIndex = 6
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(883, 12)
        Me.txtType.MaximumSize = New System.Drawing.Size(150, 22)
        Me.txtType.Name = "txtType"
        Me.txtType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtType.Properties.Items.AddRange(New Object() {"VISA", "MASTERCARD"})
        Me.txtType.Size = New System.Drawing.Size(62, 22)
        Me.txtType.StyleController = Me.LayoutControl1
        Me.txtType.TabIndex = 5
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(700, 12)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(62, 22)
        Me.txtBankName.StyleController = Me.LayoutControl1
        Me.txtBankName.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1140, 59)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCreditCardID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(183, 39)
        Me.LayoutControlItem1.Text = "Credit Card ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(114, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtExpDate
        Me.LayoutControlItem2.Location = New System.Drawing.Point(937, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(183, 39)
        Me.LayoutControlItem2.Text = "Expired Date"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(114, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtType
        Me.LayoutControlItem3.Location = New System.Drawing.Point(754, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(183, 39)
        Me.LayoutControlItem3.Text = "Type"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(114, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtBankName
        Me.LayoutControlItem4.Location = New System.Drawing.Point(571, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(183, 39)
        Me.LayoutControlItem4.Text = "Bank Name"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(114, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtAccountName
        Me.LayoutControlItem5.Location = New System.Drawing.Point(366, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(205, 39)
        Me.LayoutControlItem5.Text = "Account Name"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(114, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCreditCardNumber
        Me.LayoutControlItem6.Location = New System.Drawing.Point(183, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(183, 39)
        Me.LayoutControlItem6.Text = "Credit Card Number"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(114, 16)
        '
        'GridCreditCard
        '
        Me.GridCreditCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCreditCard.Location = New System.Drawing.Point(15, 105)
        Me.GridCreditCard.MainView = Me.GridViewCreditCard
        Me.GridCreditCard.Name = "GridCreditCard"
        Me.GridCreditCard.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CCreditCardNumber})
        Me.GridCreditCard.Size = New System.Drawing.Size(1140, 453)
        Me.GridCreditCard.TabIndex = 13
        Me.GridCreditCard.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCreditCard})
        '
        'GridViewCreditCard
        '
        Me.GridViewCreditCard.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CreditCardID, Me.CreditCardNumber, Me.AccountName, Me.BankName, Me.Type, Me.ExpiredDate})
        Me.GridViewCreditCard.GridControl = Me.GridCreditCard
        Me.GridViewCreditCard.Name = "GridViewCreditCard"
        Me.GridViewCreditCard.OptionsBehavior.Editable = False
        Me.GridViewCreditCard.OptionsView.ColumnAutoWidth = False
        Me.GridViewCreditCard.OptionsView.ShowGroupPanel = False
        '
        'CreditCardID
        '
        Me.CreditCardID.Caption = "Credit Card ID"
        Me.CreditCardID.FieldName = "CreditCardID"
        Me.CreditCardID.MinWidth = 25
        Me.CreditCardID.Name = "CreditCardID"
        Me.CreditCardID.OptionsColumn.FixedWidth = True
        Me.CreditCardID.Visible = True
        Me.CreditCardID.VisibleIndex = 0
        Me.CreditCardID.Width = 120
        '
        'CreditCardNumber
        '
        Me.CreditCardNumber.Caption = "Credit Card Number"
        Me.CreditCardNumber.ColumnEdit = Me.CCreditCardNumber
        Me.CreditCardNumber.DisplayFormat.FormatString = "0000-0000-0000-9999"
        Me.CreditCardNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CreditCardNumber.FieldName = "CreditCardNumber"
        Me.CreditCardNumber.MinWidth = 25
        Me.CreditCardNumber.Name = "CreditCardNumber"
        Me.CreditCardNumber.OptionsColumn.FixedWidth = True
        Me.CreditCardNumber.Visible = True
        Me.CreditCardNumber.VisibleIndex = 1
        Me.CreditCardNumber.Width = 180
        '
        'CCreditCardNumber
        '
        Me.CCreditCardNumber.AutoHeight = False
        Me.CCreditCardNumber.Mask.EditMask = "0000-0000-0000-9999"
        Me.CCreditCardNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.CCreditCardNumber.Mask.ShowPlaceHolders = False
        Me.CCreditCardNumber.Mask.UseMaskAsDisplayFormat = True
        Me.CCreditCardNumber.Name = "CCreditCardNumber"
        '
        'AccountName
        '
        Me.AccountName.Caption = "Account Name"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.MinWidth = 25
        Me.AccountName.Name = "AccountName"
        Me.AccountName.OptionsColumn.FixedWidth = True
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 2
        Me.AccountName.Width = 400
        '
        'BankName
        '
        Me.BankName.Caption = "Bank Name"
        Me.BankName.FieldName = "BankName"
        Me.BankName.MinWidth = 25
        Me.BankName.Name = "BankName"
        Me.BankName.OptionsColumn.FixedWidth = True
        Me.BankName.Visible = True
        Me.BankName.VisibleIndex = 3
        Me.BankName.Width = 250
        '
        'Type
        '
        Me.Type.Caption = "Type"
        Me.Type.FieldName = "Type"
        Me.Type.MinWidth = 25
        Me.Type.Name = "Type"
        Me.Type.OptionsColumn.FixedWidth = True
        Me.Type.Visible = True
        Me.Type.VisibleIndex = 4
        Me.Type.Width = 150
        '
        'ExpiredDate
        '
        Me.ExpiredDate.Caption = "Expired Date"
        Me.ExpiredDate.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.ExpiredDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ExpiredDate.FieldName = "ExpDate"
        Me.ExpiredDate.MinWidth = 25
        Me.ExpiredDate.Name = "ExpiredDate"
        Me.ExpiredDate.OptionsColumn.FixedWidth = True
        Me.ExpiredDate.Visible = True
        Me.ExpiredDate.VisibleIndex = 5
        Me.ExpiredDate.Width = 150
        '
        'FrmTravelCreditCardDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1182, 569)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GridCreditCard)
        Me.Name = "FrmTravelCreditCardDetail"
        Me.Controls.SetChildIndex(Me.GridCreditCard, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.txtCreditCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtCreditCardNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBankName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCreditCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCreditCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCreditCardNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCreditCardID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBankName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccountName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtExpDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GridCreditCard As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCreditCard As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CreditCardID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreditCardNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExpiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCreditCardNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CCreditCardNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
