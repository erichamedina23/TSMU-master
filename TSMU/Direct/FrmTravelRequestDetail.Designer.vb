<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTravelRequestDetail
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
        Me.CDepartureDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.CArrivalDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.txtNoRequest = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnAddDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNIK = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdvanceIDR = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdvanceYEN = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdvanceUSD = New DevExpress.XtraEditors.TextEdit()
        Me.txtTravelType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtNama = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepartement = New DevExpress.XtraEditors.TextEdit()
        Me.txtGolongan = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtPurpose = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GridDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DestinationGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NegaraGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CNegara = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.NoPasporGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoVisaGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VisaGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartureDateGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ArrivalDateGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRateAllowanceUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRateAllowanceYEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GridAdvance = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAdvance = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GAdvanceCostType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAdvanceDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAdvanceDays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAdvanceAdvanceUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CAdvanceUSD = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GAdvanceAdvanceIDRUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAdvanceAdvanceYEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CAdvanceYEN = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GAdvanceAdvanceIDRYEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAdvanceAdvanceIDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CAdvanceIDR = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GAdvanceRateAdvanceIDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAdvanceTotalAdvanceIDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.CDepartureDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDepartureDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CArrivalDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CArrivalDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRequest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNIK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdvanceIDR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdvanceYEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdvanceUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTravelType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGolongan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurpose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CNegara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAdvanceUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAdvanceYEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAdvanceIDR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CDepartureDate
        '
        Me.CDepartureDate.AutoHeight = False
        Me.CDepartureDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CDepartureDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CDepartureDate.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.CDepartureDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CDepartureDate.EditFormat.FormatString = "dd-MM-yyyy"
        Me.CDepartureDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CDepartureDate.Mask.EditMask = "dd-MM-yyyy"
        Me.CDepartureDate.Name = "CDepartureDate"
        Me.CDepartureDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'CArrivalDate
        '
        Me.CArrivalDate.AutoHeight = False
        Me.CArrivalDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CArrivalDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CArrivalDate.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.CArrivalDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CArrivalDate.EditFormat.FormatString = "dd-MM-yyyy"
        Me.CArrivalDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CArrivalDate.Mask.EditMask = "dd-MM-yyyy"
        Me.CArrivalDate.Name = "CArrivalDate"
        Me.CArrivalDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'txtNoRequest
        '
        Me.txtNoRequest.EditValue = ""
        Me.txtNoRequest.Enabled = False
        Me.txtNoRequest.Location = New System.Drawing.Point(43, 12)
        Me.txtNoRequest.MaximumSize = New System.Drawing.Size(140, 22)
        Me.txtNoRequest.Name = "txtNoRequest"
        Me.txtNoRequest.Size = New System.Drawing.Size(62, 22)
        Me.txtNoRequest.StyleController = Me.LayoutControl1
        Me.txtNoRequest.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnAddDetail)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.txtNIK)
        Me.LayoutControl1.Controls.Add(Me.txtAdvanceIDR)
        Me.LayoutControl1.Controls.Add(Me.txtAdvanceYEN)
        Me.LayoutControl1.Controls.Add(Me.txtAdvanceUSD)
        Me.LayoutControl1.Controls.Add(Me.txtTravelType)
        Me.LayoutControl1.Controls.Add(Me.txtNama)
        Me.LayoutControl1.Controls.Add(Me.txtNoRequest)
        Me.LayoutControl1.Controls.Add(Me.txtDepartement)
        Me.LayoutControl1.Controls.Add(Me.txtGolongan)
        Me.LayoutControl1.Controls.Add(Me.txtPurpose)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(362, 479, 812, 500)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1276, 134)
        Me.LayoutControl1.TabIndex = 35
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnAddDetail
        '
        Me.btnAddDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDetail.Location = New System.Drawing.Point(1125, 41)
        Me.btnAddDetail.MaximumSize = New System.Drawing.Size(120, 0)
        Me.btnAddDetail.Name = "btnAddDetail"
        Me.btnAddDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAddDetail.Size = New System.Drawing.Size(118, 68)
        Me.btnAddDetail.StyleController = Me.LayoutControl1
        Me.btnAddDetail.TabIndex = 35
        Me.btnAddDetail.Text = "Add Detail ++"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(1009, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Exchange Rate"
        '
        'txtNIK
        '
        Me.txtNIK.EditValue = ""
        Me.txtNIK.Location = New System.Drawing.Point(333, 12)
        Me.txtNIK.MaximumSize = New System.Drawing.Size(120, 22)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Properties.MaxLength = 9
        Me.txtNIK.Size = New System.Drawing.Size(62, 22)
        Me.txtNIK.StyleController = Me.LayoutControl1
        Me.txtNIK.TabIndex = 2
        '
        'txtAdvanceIDR
        '
        Me.txtAdvanceIDR.EditValue = "0"
        Me.txtAdvanceIDR.Location = New System.Drawing.Point(925, 74)
        Me.txtAdvanceIDR.MaximumSize = New System.Drawing.Size(150, 0)
        Me.txtAdvanceIDR.Name = "txtAdvanceIDR"
        Me.txtAdvanceIDR.Properties.Mask.EditMask = "n2"
        Me.txtAdvanceIDR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdvanceIDR.Properties.Name = "txtAdvanceIDR"
        Me.txtAdvanceIDR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAdvanceIDR.Size = New System.Drawing.Size(62, 22)
        Me.txtAdvanceIDR.StyleController = Me.LayoutControl1
        Me.txtAdvanceIDR.TabIndex = 7
        '
        'txtAdvanceYEN
        '
        Me.txtAdvanceYEN.EditValue = "0"
        Me.txtAdvanceYEN.Location = New System.Drawing.Point(780, 74)
        Me.txtAdvanceYEN.MaximumSize = New System.Drawing.Size(150, 0)
        Me.txtAdvanceYEN.Name = "txtAdvanceYEN"
        Me.txtAdvanceYEN.Properties.Mask.EditMask = "n2"
        Me.txtAdvanceYEN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdvanceYEN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAdvanceYEN.Size = New System.Drawing.Size(62, 22)
        Me.txtAdvanceYEN.StyleController = Me.LayoutControl1
        Me.txtAdvanceYEN.TabIndex = 9
        '
        'txtAdvanceUSD
        '
        Me.txtAdvanceUSD.EditValue = "0"
        Me.txtAdvanceUSD.Location = New System.Drawing.Point(635, 74)
        Me.txtAdvanceUSD.MaximumSize = New System.Drawing.Size(150, 0)
        Me.txtAdvanceUSD.Name = "txtAdvanceUSD"
        Me.txtAdvanceUSD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtAdvanceUSD.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAdvanceUSD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdvanceUSD.Properties.EditFormat.FormatString = "n2"
        Me.txtAdvanceUSD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdvanceUSD.Properties.Mask.EditMask = "n2"
        Me.txtAdvanceUSD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdvanceUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAdvanceUSD.Size = New System.Drawing.Size(62, 22)
        Me.txtAdvanceUSD.StyleController = Me.LayoutControl1
        Me.txtAdvanceUSD.TabIndex = 8
        '
        'txtTravelType
        '
        Me.txtTravelType.EditValue = ""
        Me.txtTravelType.Location = New System.Drawing.Point(478, 58)
        Me.txtTravelType.Name = "txtTravelType"
        Me.txtTravelType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTravelType.Properties.Items.AddRange(New Object() {"DN", "LN"})
        Me.txtTravelType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTravelType.Size = New System.Drawing.Size(62, 22)
        Me.txtTravelType.StyleController = Me.LayoutControl1
        Me.txtTravelType.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.EditValue = ""
        Me.txtNama.Location = New System.Drawing.Point(43, 58)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtNama.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNama.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtNama.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNama.Size = New System.Drawing.Size(352, 22)
        Me.txtNama.StyleController = Me.LayoutControl1
        Me.txtNama.TabIndex = 5
        '
        'txtDepartement
        '
        Me.txtDepartement.EditValue = ""
        Me.txtDepartement.Enabled = False
        Me.txtDepartement.Location = New System.Drawing.Point(188, 12)
        Me.txtDepartement.MaximumSize = New System.Drawing.Size(70, 22)
        Me.txtDepartement.Name = "txtDepartement"
        Me.txtDepartement.Size = New System.Drawing.Size(62, 22)
        Me.txtDepartement.StyleController = Me.LayoutControl1
        Me.txtDepartement.TabIndex = 1
        '
        'txtGolongan
        '
        Me.txtGolongan.Location = New System.Drawing.Point(478, 12)
        Me.txtGolongan.MaximumSize = New System.Drawing.Size(100, 22)
        Me.txtGolongan.Name = "txtGolongan"
        Me.txtGolongan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtGolongan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGolongan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Golongan", "Golongan", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "")})
        Me.txtGolongan.Properties.DisplayMember = "Description"
        Me.txtGolongan.Properties.NullText = ""
        Me.txtGolongan.Properties.PopupFormMinSize = New System.Drawing.Size(30, 0)
        Me.txtGolongan.Properties.PopupSizeable = False
        Me.txtGolongan.Properties.ShowFooter = False
        Me.txtGolongan.Properties.ShowHeader = False
        Me.txtGolongan.Properties.ValueMember = "Golongan"
        Me.txtGolongan.Size = New System.Drawing.Size(62, 22)
        Me.txtGolongan.StyleController = Me.LayoutControl1
        Me.txtGolongan.TabIndex = 3
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(623, 12)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(620, 22)
        Me.txtPurpose.StyleController = Me.LayoutControl1
        Me.txtPurpose.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.EmptySpaceItem4, Me.LayoutControlGroup4, Me.EmptySpaceItem7, Me.LayoutControlItem15})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1295, 124)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNoRequest
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem5.Text = "No Request"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtDepartement
        Me.LayoutControlItem6.Location = New System.Drawing.Point(137, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem6.Text = "Dept"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtGolongan
        Me.LayoutControlItem7.Location = New System.Drawing.Point(437, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(135, 26)
        Me.LayoutControlItem7.Text = "Golongan"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtPurpose
        Me.LayoutControlItem8.Location = New System.Drawing.Point(582, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
        Me.LayoutControlItem8.Size = New System.Drawing.Size(693, 26)
        Me.LayoutControlItem8.Text = "Purpose"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtNama
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 46)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(427, 58)
        Me.LayoutControlItem9.Text = "Nama"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtTravelType
        Me.LayoutControlItem10.Location = New System.Drawing.Point(437, 46)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(135, 58)
        Me.LayoutControlItem10.Text = "Travel Type"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNIK
        Me.LayoutControlItem1.Location = New System.Drawing.Point(282, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem1.Text = "NIK"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 16)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 26)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(0, 20)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(10, 7)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(427, 20)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(437, 26)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(0, 20)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(10, 7)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(135, 20)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(427, 0)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(10, 104)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(572, 0)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 104)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup4.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup4.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup4.AppearanceItemCaption.BorderColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup4.AppearanceItemCaption.Options.UseBackColor = True
        Me.LayoutControlGroup4.AppearanceItemCaption.Options.UseBorderColor = True
        Me.LayoutControlGroup4.AppearanceTabPage.Header.BorderColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup4.AppearanceTabPage.Header.Options.UseBorderColor = True
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem16, Me.EmptySpaceItem3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(582, 26)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(563, 78)
        Me.LayoutControlGroup4.Text = "Advance"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtAdvanceUSD
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(135, 30)
        Me.LayoutControlItem2.Text = "USD"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtAdvanceYEN
        Me.LayoutControlItem11.Location = New System.Drawing.Point(135, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem11.Size = New System.Drawing.Size(145, 30)
        Me.LayoutControlItem11.Text = "YEN"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtAdvanceIDR
        Me.LayoutControlItem12.Location = New System.Drawing.Point(280, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem12.Size = New System.Drawing.Size(145, 30)
        Me.LayoutControlItem12.Text = "IDR"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(68, 16)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.LabelControl1
        Me.LayoutControlItem16.Location = New System.Drawing.Point(435, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 12, 2)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(104, 30)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(425, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 30)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(1145, 26)
        Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(10, 0)
        Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(10, 78)
        Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnAddDetail
        Me.LayoutControlItem15.Location = New System.Drawing.Point(1155, 26)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(120, 80)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(120, 75)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 5, 5)
        Me.LayoutControlItem15.Size = New System.Drawing.Size(120, 78)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1077, 94)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'GridDetail
        '
        Me.GridDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetail.Location = New System.Drawing.Point(12, 12)
        Me.GridDetail.MainView = Me.GridViewDetail
        Me.GridDetail.Name = "GridDetail"
        Me.GridDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CNegara})
        Me.GridDetail.Size = New System.Drawing.Size(1252, 180)
        Me.GridDetail.TabIndex = 2
        Me.GridDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDetail})
        '
        'GridViewDetail
        '
        Me.GridViewDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DestinationGrid, Me.NegaraGrid, Me.NoPasporGrid, Me.NoVisaGrid, Me.VisaGrid, Me.DepartureDateGrid, Me.ArrivalDateGrid, Me.GDetailDay, Me.GRateAllowanceUSD, Me.GRateAllowanceYEN})
        Me.GridViewDetail.GridControl = Me.GridDetail
        Me.GridViewDetail.Name = "GridViewDetail"
        Me.GridViewDetail.OptionsCustomization.AllowFilter = False
        Me.GridViewDetail.OptionsCustomization.AllowSort = False
        Me.GridViewDetail.OptionsView.ShowGroupPanel = False
        '
        'DestinationGrid
        '
        Me.DestinationGrid.Caption = "Destination"
        Me.DestinationGrid.FieldName = "Destination"
        Me.DestinationGrid.MinWidth = 25
        Me.DestinationGrid.Name = "DestinationGrid"
        Me.DestinationGrid.Visible = True
        Me.DestinationGrid.VisibleIndex = 0
        Me.DestinationGrid.Width = 642
        '
        'NegaraGrid
        '
        Me.NegaraGrid.Caption = "Negara"
        Me.NegaraGrid.ColumnEdit = Me.CNegara
        Me.NegaraGrid.FieldName = "Negara"
        Me.NegaraGrid.MinWidth = 25
        Me.NegaraGrid.Name = "NegaraGrid"
        Me.NegaraGrid.OptionsColumn.FixedWidth = True
        Me.NegaraGrid.Visible = True
        Me.NegaraGrid.VisibleIndex = 1
        Me.NegaraGrid.Width = 170
        '
        'CNegara
        '
        Me.CNegara.AutoHeight = False
        Me.CNegara.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CNegara.Name = "CNegara"
        Me.CNegara.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'NoPasporGrid
        '
        Me.NoPasporGrid.Caption = "No Paspor"
        Me.NoPasporGrid.FieldName = "NoPaspor"
        Me.NoPasporGrid.MinWidth = 25
        Me.NoPasporGrid.Name = "NoPasporGrid"
        Me.NoPasporGrid.OptionsColumn.AllowEdit = False
        Me.NoPasporGrid.Visible = True
        Me.NoPasporGrid.VisibleIndex = 2
        Me.NoPasporGrid.Width = 59
        '
        'NoVisaGrid
        '
        Me.NoVisaGrid.Caption = "No Visa"
        Me.NoVisaGrid.FieldName = "NoVisa"
        Me.NoVisaGrid.MinWidth = 25
        Me.NoVisaGrid.Name = "NoVisaGrid"
        Me.NoVisaGrid.Width = 94
        '
        'VisaGrid
        '
        Me.VisaGrid.Caption = "Visa"
        Me.VisaGrid.FieldName = "Visa"
        Me.VisaGrid.MinWidth = 25
        Me.VisaGrid.Name = "VisaGrid"
        Me.VisaGrid.OptionsColumn.AllowEdit = False
        Me.VisaGrid.Visible = True
        Me.VisaGrid.VisibleIndex = 3
        Me.VisaGrid.Width = 61
        '
        'DepartureDateGrid
        '
        Me.DepartureDateGrid.Caption = "Departure Date"
        Me.DepartureDateGrid.ColumnEdit = Me.CDepartureDate
        Me.DepartureDateGrid.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.DepartureDateGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DepartureDateGrid.FieldName = "DepartureDate"
        Me.DepartureDateGrid.MinWidth = 25
        Me.DepartureDateGrid.Name = "DepartureDateGrid"
        Me.DepartureDateGrid.OptionsColumn.FixedWidth = True
        Me.DepartureDateGrid.Visible = True
        Me.DepartureDateGrid.VisibleIndex = 4
        Me.DepartureDateGrid.Width = 150
        '
        'ArrivalDateGrid
        '
        Me.ArrivalDateGrid.Caption = "Arrival Date"
        Me.ArrivalDateGrid.ColumnEdit = Me.CArrivalDate
        Me.ArrivalDateGrid.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.ArrivalDateGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ArrivalDateGrid.FieldName = "ArrivalDate"
        Me.ArrivalDateGrid.MinWidth = 25
        Me.ArrivalDateGrid.Name = "ArrivalDateGrid"
        Me.ArrivalDateGrid.OptionsColumn.FixedWidth = True
        Me.ArrivalDateGrid.Visible = True
        Me.ArrivalDateGrid.VisibleIndex = 5
        Me.ArrivalDateGrid.Width = 150
        '
        'GDetailDay
        '
        Me.GDetailDay.Caption = "Day"
        Me.GDetailDay.FieldName = "Day"
        Me.GDetailDay.MinWidth = 25
        Me.GDetailDay.Name = "GDetailDay"
        Me.GDetailDay.Width = 94
        '
        'GRateAllowanceUSD
        '
        Me.GRateAllowanceUSD.Caption = "RateAllowanceUSD"
        Me.GRateAllowanceUSD.FieldName = "RateAllowanceUSD"
        Me.GRateAllowanceUSD.MinWidth = 25
        Me.GRateAllowanceUSD.Name = "GRateAllowanceUSD"
        Me.GRateAllowanceUSD.Width = 94
        '
        'GRateAllowanceYEN
        '
        Me.GRateAllowanceYEN.Caption = "RateAllowanceYEN"
        Me.GRateAllowanceYEN.FieldName = "RateAllowanceYEN"
        Me.GRateAllowanceYEN.MinWidth = 25
        Me.GRateAllowanceYEN.Name = "GRateAllowanceYEN"
        Me.GRateAllowanceYEN.Width = 94
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'GridAdvance
        '
        Me.GridAdvance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAdvance.Location = New System.Drawing.Point(24, 48)
        Me.GridAdvance.MainView = Me.GridViewAdvance
        Me.GridAdvance.Name = "GridAdvance"
        Me.GridAdvance.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CAdvanceIDR, Me.CAdvanceUSD, Me.CAdvanceYEN})
        Me.GridAdvance.Size = New System.Drawing.Size(1228, 162)
        Me.GridAdvance.TabIndex = 23
        Me.GridAdvance.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAdvance})
        '
        'GridViewAdvance
        '
        Me.GridViewAdvance.ActiveFilterEnabled = False
        Me.GridViewAdvance.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GAdvanceCostType, Me.GAdvanceDescription, Me.GAdvanceDays, Me.GAdvanceAdvanceUSD, Me.GAdvanceAdvanceIDRUSD, Me.GAdvanceAdvanceYEN, Me.GAdvanceAdvanceIDRYEN, Me.GAdvanceAdvanceIDR, Me.GAdvanceRateAdvanceIDR, Me.GAdvanceTotalAdvanceIDR})
        Me.GridViewAdvance.GridControl = Me.GridAdvance
        Me.GridViewAdvance.Name = "GridViewAdvance"
        Me.GridViewAdvance.OptionsCustomization.AllowFilter = False
        Me.GridViewAdvance.OptionsCustomization.AllowSort = False
        Me.GridViewAdvance.OptionsView.ShowFooter = True
        Me.GridViewAdvance.OptionsView.ShowGroupPanel = False
        '
        'GAdvanceCostType
        '
        Me.GAdvanceCostType.Caption = "Cost Type"
        Me.GAdvanceCostType.FieldName = "CostType"
        Me.GAdvanceCostType.MinWidth = 25
        Me.GAdvanceCostType.Name = "GAdvanceCostType"
        Me.GAdvanceCostType.OptionsColumn.AllowEdit = False
        Me.GAdvanceCostType.Width = 94
        '
        'GAdvanceDescription
        '
        Me.GAdvanceDescription.Caption = "Description"
        Me.GAdvanceDescription.FieldName = "Description"
        Me.GAdvanceDescription.MinWidth = 25
        Me.GAdvanceDescription.Name = "GAdvanceDescription"
        Me.GAdvanceDescription.OptionsColumn.AllowEdit = False
        Me.GAdvanceDescription.Visible = True
        Me.GAdvanceDescription.VisibleIndex = 0
        Me.GAdvanceDescription.Width = 450
        '
        'GAdvanceDays
        '
        Me.GAdvanceDays.Caption = "Days"
        Me.GAdvanceDays.FieldName = "Days"
        Me.GAdvanceDays.MinWidth = 25
        Me.GAdvanceDays.Name = "GAdvanceDays"
        Me.GAdvanceDays.OptionsColumn.AllowEdit = False
        Me.GAdvanceDays.OptionsColumn.FixedWidth = True
        Me.GAdvanceDays.Visible = True
        Me.GAdvanceDays.VisibleIndex = 1
        Me.GAdvanceDays.Width = 100
        '
        'GAdvanceAdvanceUSD
        '
        Me.GAdvanceAdvanceUSD.Caption = "Advance USD"
        Me.GAdvanceAdvanceUSD.ColumnEdit = Me.CAdvanceUSD
        Me.GAdvanceAdvanceUSD.DisplayFormat.FormatString = "n2"
        Me.GAdvanceAdvanceUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAdvanceAdvanceUSD.FieldName = "AdvanceUSD"
        Me.GAdvanceAdvanceUSD.MinWidth = 25
        Me.GAdvanceAdvanceUSD.Name = "GAdvanceAdvanceUSD"
        Me.GAdvanceAdvanceUSD.OptionsColumn.AllowEdit = False
        Me.GAdvanceAdvanceUSD.OptionsColumn.FixedWidth = True
        Me.GAdvanceAdvanceUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AdvanceUSD", "{0:#,##0.#0}")})
        Me.GAdvanceAdvanceUSD.Visible = True
        Me.GAdvanceAdvanceUSD.VisibleIndex = 2
        Me.GAdvanceAdvanceUSD.Width = 200
        '
        'CAdvanceUSD
        '
        Me.CAdvanceUSD.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CAdvanceUSD.AutoHeight = False
        Me.CAdvanceUSD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAdvanceUSD.DisplayFormat.FormatString = "n2"
        Me.CAdvanceUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAdvanceUSD.EditFormat.FormatString = "n2"
        Me.CAdvanceUSD.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAdvanceUSD.Mask.EditMask = "n2"
        Me.CAdvanceUSD.Name = "CAdvanceUSD"
        '
        'GAdvanceAdvanceIDRUSD
        '
        Me.GAdvanceAdvanceIDRUSD.Caption = "Advance IDR USD"
        Me.GAdvanceAdvanceIDRUSD.FieldName = "AdvanceIDRUSD"
        Me.GAdvanceAdvanceIDRUSD.MinWidth = 25
        Me.GAdvanceAdvanceIDRUSD.Name = "GAdvanceAdvanceIDRUSD"
        Me.GAdvanceAdvanceIDRUSD.Width = 94
        '
        'GAdvanceAdvanceYEN
        '
        Me.GAdvanceAdvanceYEN.Caption = "Advance YEN"
        Me.GAdvanceAdvanceYEN.ColumnEdit = Me.CAdvanceYEN
        Me.GAdvanceAdvanceYEN.DisplayFormat.FormatString = "n2"
        Me.GAdvanceAdvanceYEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAdvanceAdvanceYEN.FieldName = "AdvanceYEN"
        Me.GAdvanceAdvanceYEN.MinWidth = 25
        Me.GAdvanceAdvanceYEN.Name = "GAdvanceAdvanceYEN"
        Me.GAdvanceAdvanceYEN.OptionsColumn.AllowEdit = False
        Me.GAdvanceAdvanceYEN.OptionsColumn.FixedWidth = True
        Me.GAdvanceAdvanceYEN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AdvanceYEN", "{0:#,##0.#0}")})
        Me.GAdvanceAdvanceYEN.Visible = True
        Me.GAdvanceAdvanceYEN.VisibleIndex = 3
        Me.GAdvanceAdvanceYEN.Width = 200
        '
        'CAdvanceYEN
        '
        Me.CAdvanceYEN.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CAdvanceYEN.AutoHeight = False
        Me.CAdvanceYEN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAdvanceYEN.DisplayFormat.FormatString = "n2"
        Me.CAdvanceYEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAdvanceYEN.EditFormat.FormatString = "n2"
        Me.CAdvanceYEN.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAdvanceYEN.Mask.EditMask = "n2"
        Me.CAdvanceYEN.Name = "CAdvanceYEN"
        Me.CAdvanceYEN.NullText = "0000"
        Me.CAdvanceYEN.NullValuePrompt = "0000"
        '
        'GAdvanceAdvanceIDRYEN
        '
        Me.GAdvanceAdvanceIDRYEN.Caption = "Advance IDR YEN"
        Me.GAdvanceAdvanceIDRYEN.FieldName = "AdvanceIDRYEN"
        Me.GAdvanceAdvanceIDRYEN.MinWidth = 25
        Me.GAdvanceAdvanceIDRYEN.Name = "GAdvanceAdvanceIDRYEN"
        Me.GAdvanceAdvanceIDRYEN.Width = 94
        '
        'GAdvanceAdvanceIDR
        '
        Me.GAdvanceAdvanceIDR.Caption = "Advance IDR"
        Me.GAdvanceAdvanceIDR.ColumnEdit = Me.CAdvanceIDR
        Me.GAdvanceAdvanceIDR.DisplayFormat.FormatString = "n2"
        Me.GAdvanceAdvanceIDR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAdvanceAdvanceIDR.FieldName = "AdvanceIDR"
        Me.GAdvanceAdvanceIDR.MinWidth = 25
        Me.GAdvanceAdvanceIDR.Name = "GAdvanceAdvanceIDR"
        Me.GAdvanceAdvanceIDR.OptionsColumn.AllowEdit = False
        Me.GAdvanceAdvanceIDR.OptionsColumn.FixedWidth = True
        Me.GAdvanceAdvanceIDR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AdvanceIDR", "{0:#,##0.#0}")})
        Me.GAdvanceAdvanceIDR.Visible = True
        Me.GAdvanceAdvanceIDR.VisibleIndex = 4
        Me.GAdvanceAdvanceIDR.Width = 200
        '
        'CAdvanceIDR
        '
        Me.CAdvanceIDR.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CAdvanceIDR.AutoHeight = False
        Me.CAdvanceIDR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAdvanceIDR.DisplayFormat.FormatString = "n2"
        Me.CAdvanceIDR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAdvanceIDR.EditFormat.FormatString = "n2"
        Me.CAdvanceIDR.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAdvanceIDR.Mask.EditMask = "n2"
        Me.CAdvanceIDR.Name = "CAdvanceIDR"
        '
        'GAdvanceRateAdvanceIDR
        '
        Me.GAdvanceRateAdvanceIDR.Caption = "Rate Advance IDR"
        Me.GAdvanceRateAdvanceIDR.DisplayFormat.FormatString = "n2"
        Me.GAdvanceRateAdvanceIDR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAdvanceRateAdvanceIDR.FieldName = "RateAdvanceIDR"
        Me.GAdvanceRateAdvanceIDR.MinWidth = 25
        Me.GAdvanceRateAdvanceIDR.Name = "GAdvanceRateAdvanceIDR"
        Me.GAdvanceRateAdvanceIDR.OptionsColumn.AllowEdit = False
        Me.GAdvanceRateAdvanceIDR.OptionsColumn.FixedWidth = True
        Me.GAdvanceRateAdvanceIDR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RateAdvanceIDR", "{0:#,##0.#0}")})
        Me.GAdvanceRateAdvanceIDR.Visible = True
        Me.GAdvanceRateAdvanceIDR.VisibleIndex = 5
        Me.GAdvanceRateAdvanceIDR.Width = 200
        '
        'GAdvanceTotalAdvanceIDR
        '
        Me.GAdvanceTotalAdvanceIDR.Caption = "Total Advance IDR"
        Me.GAdvanceTotalAdvanceIDR.DisplayFormat.FormatString = "n2"
        Me.GAdvanceTotalAdvanceIDR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAdvanceTotalAdvanceIDR.FieldName = "TotalAdvanceIDR"
        Me.GAdvanceTotalAdvanceIDR.MinWidth = 25
        Me.GAdvanceTotalAdvanceIDR.Name = "GAdvanceTotalAdvanceIDR"
        Me.GAdvanceTotalAdvanceIDR.OptionsColumn.AllowEdit = False
        Me.GAdvanceTotalAdvanceIDR.OptionsColumn.FixedWidth = True
        Me.GAdvanceTotalAdvanceIDR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAdvanceIDR", "{0:#,##0.#0}")})
        Me.GAdvanceTotalAdvanceIDR.UnboundExpression = "[AdvanceIDRUSD] + [AdvanceIDRYEN] + [AdvanceIDR]"
        Me.GAdvanceTotalAdvanceIDR.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GAdvanceTotalAdvanceIDR.Visible = True
        Me.GAdvanceTotalAdvanceIDR.VisibleIndex = 6
        Me.GAdvanceTotalAdvanceIDR.Width = 200
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1282, 590)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridDetail)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(3, 143)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1276, 204)
        Me.LayoutControl2.TabIndex = 36
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1276, 204)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.GridDetail
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(1256, 184)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.GridAdvance)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(3, 353)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1108, 74, 812, 500)
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(1276, 234)
        Me.LayoutControl3.TabIndex = 37
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1276, 234)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1256, 214)
        Me.LayoutControlGroup3.Text = "Advance dan Pocket Allowance"
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.GridAdvance
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1232, 166)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'FrmTravelRequestDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1282, 617)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmTravelRequestDetail"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        CType(Me.CDepartureDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDepartureDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CArrivalDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CArrivalDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRequest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNIK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdvanceIDR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdvanceYEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdvanceUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTravelType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGolongan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurpose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CNegara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAdvanceUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAdvanceYEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAdvanceIDR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNoRequest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DepartureDateGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArrivalDateGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DestinationGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTravelType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents NegaraGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPurpose As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridAdvance As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAdvance As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GAdvanceDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAdvanceAdvanceIDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAdvanceAdvanceUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAdvanceAdvanceYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAdvanceIDR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdvanceUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdvanceYEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GAdvanceDays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VisaGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CNegara As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CDepartureDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents CArrivalDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GAdvanceCostType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoPasporGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDepartement As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CAdvanceUSD As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents CAdvanceYEN As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents CAdvanceIDR As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents NoVisaGrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAdvanceTotalAdvanceIDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAdvanceAdvanceIDRUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAdvanceAdvanceIDRYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNIK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GAdvanceRateAdvanceIDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtGolongan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GDetailDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRateAllowanceUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRateAllowanceYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAddDetail As DevExpress.XtraEditors.SimpleButton
End Class
