<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTravelPocketAllowance
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
        Me.GridPocketAllowance = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPocketAllowance = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TravelTypeGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GolonganGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescGolongan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NamaNegara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CurryIDGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FirstTravelGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAmountAllowance = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNamaNegara = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTravelType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtAmountFirstTravel = New DevExpress.XtraEditors.TextEdit()
        Me.txtGolongan = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCurryID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.GridPocketAllowance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPocketAllowance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountAllowance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNamaNegara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTravelType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountFirstTravel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGolongan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPocketAllowance
        '
        Me.GridPocketAllowance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPocketAllowance.Location = New System.Drawing.Point(15, 105)
        Me.GridPocketAllowance.MainView = Me.GridViewPocketAllowance
        Me.GridPocketAllowance.Name = "GridPocketAllowance"
        Me.GridPocketAllowance.Size = New System.Drawing.Size(1140, 465)
        Me.GridPocketAllowance.TabIndex = 1
        Me.GridPocketAllowance.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPocketAllowance})
        '
        'GridViewPocketAllowance
        '
        Me.GridViewPocketAllowance.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TravelTypeGrid, Me.GolonganGrid, Me.DescGolongan, Me.NamaNegara, Me.CurryIDGrid, Me.AmountGrid, Me.FirstTravelGrid})
        Me.GridViewPocketAllowance.GridControl = Me.GridPocketAllowance
        Me.GridViewPocketAllowance.Name = "GridViewPocketAllowance"
        Me.GridViewPocketAllowance.OptionsBehavior.Editable = False
        Me.GridViewPocketAllowance.OptionsView.ColumnAutoWidth = False
        Me.GridViewPocketAllowance.OptionsView.ShowGroupPanel = False
        '
        'TravelTypeGrid
        '
        Me.TravelTypeGrid.Caption = "Travel Type"
        Me.TravelTypeGrid.FieldName = "TravelType"
        Me.TravelTypeGrid.MinWidth = 25
        Me.TravelTypeGrid.Name = "TravelTypeGrid"
        Me.TravelTypeGrid.OptionsColumn.FixedWidth = True
        Me.TravelTypeGrid.Visible = True
        Me.TravelTypeGrid.VisibleIndex = 0
        Me.TravelTypeGrid.Width = 100
        '
        'GolonganGrid
        '
        Me.GolonganGrid.Caption = "Golongan"
        Me.GolonganGrid.FieldName = "Golongan"
        Me.GolonganGrid.MinWidth = 25
        Me.GolonganGrid.Name = "GolonganGrid"
        Me.GolonganGrid.OptionsColumn.FixedWidth = True
        Me.GolonganGrid.Width = 100
        '
        'DescGolongan
        '
        Me.DescGolongan.Caption = "Golongan"
        Me.DescGolongan.FieldName = "DescGolongan"
        Me.DescGolongan.MinWidth = 25
        Me.DescGolongan.Name = "DescGolongan"
        Me.DescGolongan.OptionsColumn.FixedWidth = True
        Me.DescGolongan.Visible = True
        Me.DescGolongan.VisibleIndex = 1
        Me.DescGolongan.Width = 100
        '
        'NamaNegara
        '
        Me.NamaNegara.Caption = "Negara"
        Me.NamaNegara.FieldName = "NamaNegara"
        Me.NamaNegara.MinWidth = 25
        Me.NamaNegara.Name = "NamaNegara"
        Me.NamaNegara.OptionsColumn.FixedWidth = True
        Me.NamaNegara.Visible = True
        Me.NamaNegara.VisibleIndex = 2
        Me.NamaNegara.Width = 200
        '
        'CurryIDGrid
        '
        Me.CurryIDGrid.Caption = "Curry ID"
        Me.CurryIDGrid.FieldName = "CuryID"
        Me.CurryIDGrid.MinWidth = 25
        Me.CurryIDGrid.Name = "CurryIDGrid"
        Me.CurryIDGrid.OptionsColumn.FixedWidth = True
        Me.CurryIDGrid.Visible = True
        Me.CurryIDGrid.VisibleIndex = 3
        Me.CurryIDGrid.Width = 150
        '
        'AmountGrid
        '
        Me.AmountGrid.Caption = "Amount Allowance"
        Me.AmountGrid.DisplayFormat.FormatString = "n2"
        Me.AmountGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountGrid.FieldName = "Amount"
        Me.AmountGrid.MinWidth = 25
        Me.AmountGrid.Name = "AmountGrid"
        Me.AmountGrid.OptionsColumn.FixedWidth = True
        Me.AmountGrid.Visible = True
        Me.AmountGrid.VisibleIndex = 4
        Me.AmountGrid.Width = 200
        '
        'FirstTravelGrid
        '
        Me.FirstTravelGrid.Caption = "Amount 1St Travel"
        Me.FirstTravelGrid.DisplayFormat.FormatString = "n2"
        Me.FirstTravelGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FirstTravelGrid.FieldName = "FirstTravel"
        Me.FirstTravelGrid.MinWidth = 25
        Me.FirstTravelGrid.Name = "FirstTravelGrid"
        Me.FirstTravelGrid.OptionsColumn.FixedWidth = True
        Me.FirstTravelGrid.Visible = True
        Me.FirstTravelGrid.VisibleIndex = 5
        Me.FirstTravelGrid.Width = 200
        '
        'txtAmountAllowance
        '
        Me.txtAmountAllowance.Location = New System.Drawing.Point(872, 12)
        Me.txtAmountAllowance.MaximumSize = New System.Drawing.Size(160, 22)
        Me.txtAmountAllowance.Name = "txtAmountAllowance"
        Me.txtAmountAllowance.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtAmountAllowance.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAmountAllowance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountAllowance.Properties.EditFormat.FormatString = "n2"
        Me.txtAmountAllowance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountAllowance.Properties.Mask.EditMask = "n2"
        Me.txtAmountAllowance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountAllowance.Properties.NullText = "0"
        Me.txtAmountAllowance.Properties.NullValuePrompt = "0"
        Me.txtAmountAllowance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmountAllowance.Size = New System.Drawing.Size(62, 22)
        Me.txtAmountAllowance.StyleController = Me.LayoutControl1
        Me.txtAmountAllowance.TabIndex = 3
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControl1.Controls.Add(Me.txtNamaNegara)
        Me.LayoutControl1.Controls.Add(Me.txtTravelType)
        Me.LayoutControl1.Controls.Add(Me.txtAmountFirstTravel)
        Me.LayoutControl1.Controls.Add(Me.txtAmountAllowance)
        Me.LayoutControl1.Controls.Add(Me.txtGolongan)
        Me.LayoutControl1.Controls.Add(Me.txtCurryID)
        Me.LayoutControl1.Location = New System.Drawing.Point(15, 39)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(783, 472, 812, 500)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1140, 59)
        Me.LayoutControl1.TabIndex = 14
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNamaNegara
        '
        Me.txtNamaNegara.Location = New System.Drawing.Point(498, 12)
        Me.txtNamaNegara.MaximumSize = New System.Drawing.Size(200, 22)
        Me.txtNamaNegara.Name = "txtNamaNegara"
        Me.txtNamaNegara.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNamaNegara.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtNamaNegara.Size = New System.Drawing.Size(68, 22)
        Me.txtNamaNegara.StyleController = Me.LayoutControl1
        Me.txtNamaNegara.TabIndex = 12
        '
        'txtTravelType
        '
        Me.txtTravelType.Location = New System.Drawing.Point(130, 12)
        Me.txtTravelType.MaximumSize = New System.Drawing.Size(80, 22)
        Me.txtTravelType.Name = "txtTravelType"
        Me.txtTravelType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTravelType.Properties.Items.AddRange(New Object() {"LN", "DN"})
        Me.txtTravelType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTravelType.Size = New System.Drawing.Size(62, 22)
        Me.txtTravelType.StyleController = Me.LayoutControl1
        Me.txtTravelType.TabIndex = 2
        '
        'txtAmountFirstTravel
        '
        Me.txtAmountFirstTravel.EditValue = "0"
        Me.txtAmountFirstTravel.Location = New System.Drawing.Point(1056, 12)
        Me.txtAmountFirstTravel.MaximumSize = New System.Drawing.Size(160, 22)
        Me.txtAmountFirstTravel.Name = "txtAmountFirstTravel"
        Me.txtAmountFirstTravel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtAmountFirstTravel.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAmountFirstTravel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountFirstTravel.Properties.EditFormat.FormatString = "n2"
        Me.txtAmountFirstTravel.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountFirstTravel.Properties.Mask.EditMask = "n2"
        Me.txtAmountFirstTravel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountFirstTravel.Properties.NullText = "0"
        Me.txtAmountFirstTravel.Properties.NullValuePrompt = "0"
        Me.txtAmountFirstTravel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmountFirstTravel.Size = New System.Drawing.Size(62, 22)
        Me.txtAmountFirstTravel.StyleController = Me.LayoutControl1
        Me.txtAmountFirstTravel.TabIndex = 6
        '
        'txtGolongan
        '
        Me.txtGolongan.Location = New System.Drawing.Point(314, 12)
        Me.txtGolongan.MaximumSize = New System.Drawing.Size(120, 22)
        Me.txtGolongan.Name = "txtGolongan"
        Me.txtGolongan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtGolongan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGolongan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Golongan", "Golongan", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtGolongan.Properties.DisplayMember = "Description"
        Me.txtGolongan.Properties.NullText = ""
        Me.txtGolongan.Properties.PopupFormMinSize = New System.Drawing.Size(30, 0)
        Me.txtGolongan.Properties.PopupSizeable = False
        Me.txtGolongan.Properties.ShowFooter = False
        Me.txtGolongan.Properties.ShowHeader = False
        Me.txtGolongan.Properties.ValueMember = "Golongan"
        Me.txtGolongan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGolongan.Size = New System.Drawing.Size(62, 22)
        Me.txtGolongan.StyleController = Me.LayoutControl1
        Me.txtGolongan.TabIndex = 4
        '
        'txtCurryID
        '
        Me.txtCurryID.Enabled = False
        Me.txtCurryID.Location = New System.Drawing.Point(688, 12)
        Me.txtCurryID.MaximumSize = New System.Drawing.Size(100, 22)
        Me.txtCurryID.Name = "txtCurryID"
        Me.txtCurryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCurryID.Properties.Items.AddRange(New Object() {"USD", "YEN", "IDR"})
        Me.txtCurryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCurryID.Size = New System.Drawing.Size(62, 22)
        Me.txtCurryID.StyleController = Me.LayoutControl1
        Me.txtCurryID.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1140, 59)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtTravelType
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(184, 39)
        Me.LayoutControlItem1.Text = "Travel Type"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtAmountFirstTravel
        Me.LayoutControlItem2.Location = New System.Drawing.Point(926, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(184, 39)
        Me.LayoutControlItem2.Text = "Amount 1St Travel  "
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtAmountAllowance
        Me.LayoutControlItem3.Location = New System.Drawing.Point(742, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(184, 39)
        Me.LayoutControlItem3.Text = "Amount Allowance"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCurryID
        Me.LayoutControlItem4.Location = New System.Drawing.Point(558, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(184, 39)
        Me.LayoutControlItem4.Text = "Curry ID"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNamaNegara
        Me.LayoutControlItem5.Location = New System.Drawing.Point(368, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(190, 39)
        Me.LayoutControlItem5.Text = "Negara/Benua"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtGolongan
        Me.LayoutControlItem6.Location = New System.Drawing.Point(184, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(184, 39)
        Me.LayoutControlItem6.Text = "Golongan"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(115, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1110, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 39)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'FrmTravelPocketAllowance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1182, 583)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GridPocketAllowance)
        Me.Name = "FrmTravelPocketAllowance"
        Me.Controls.SetChildIndex(Me.GridPocketAllowance, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.GridPocketAllowance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPocketAllowance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountAllowance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNamaNegara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTravelType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountFirstTravel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGolongan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridPocketAllowance As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPocketAllowance As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TravelTypeGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GolonganGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CurryIDGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FirstTravelGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAmountAllowance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmountFirstTravel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTravelType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtCurryID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtNamaNegara As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DescGolongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaNegara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtGolongan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
