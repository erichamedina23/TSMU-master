<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NPP_Detail
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
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Machine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cav = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Weight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Inj = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Painting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Chrome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Assy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StatusMold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepStatusMold = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.OrderMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ultrasonic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vibration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Revisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.CapabilityDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoCapability = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.Cek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Check = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Note = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Seq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Commit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoComit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Commit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Runner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoUrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.No_Urut = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.ChangeFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.B_ChangeFrom = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Active_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SingleCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TMassPro = New DevExpress.XtraEditors.DateEdit()
        Me.TTargetQuot = New DevExpress.XtraEditors.DateEdit()
        Me.TTargetDr = New DevExpress.XtraEditors.DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.B_AddRows = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TIssue_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBCkr = New System.Windows.Forms.CheckBox()
        Me.TModelDesc = New DevExpress.XtraEditors.TextEdit()
        Me.CBTng = New System.Windows.Forms.CheckBox()
        Me.CBStr = New System.Windows.Forms.CheckBox()
        Me.CBSample = New System.Windows.Forms.CheckBox()
        Me.CBCad = New System.Windows.Forms.CheckBox()
        Me.CBDrawing = New System.Windows.Forms.CheckBox()
        Me.TCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TRevisi = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TOrderMaxMonth = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOrderMonth = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TModel = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNPP_No = New DevExpress.XtraEditors.TextEdit()
        Me.TCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.TRevisiInformasi = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BSetGroup = New System.Windows.Forms.Button()
        Me.B_Submit = New System.Windows.Forms.Button()
        Me.BUpload = New System.Windows.Forms.Button()
        Me.B_Reject = New System.Windows.Forms.Button()
        Me.B_Approve = New System.Windows.Forms.Button()
        Me.B_Revise = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepStatusMold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoCapability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoCapability.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoComit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.No_Urut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B_ChangeFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SingleCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TMassPro.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMassPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTargetQuot.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTargetQuot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTargetDr.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTargetDr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TIssue_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIssue_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TModelDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TRevisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOrderMaxMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOrderMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TNPP_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRevisiInformasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(12, 142)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SingleCheck, Me.Check, Me.RepStatus, Me.RepStatusMold, Me.RepoCapability, Me.RepoComit, Me.No_Urut, Me.B_ChangeFrom})
        Me.Grid.Size = New System.Drawing.Size(1235, 292)
        Me.Grid.TabIndex = 7
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PartNo, Me.PartName, Me.Machine, Me.CT, Me.Cav, Me.Weight, Me.Material, Me.Inj, Me.Painting, Me.Chrome, Me.Assy, Me.StatusMold, Me.OrderMonth, Me.Ultrasonic, Me.Vibration, Me.GroupID, Me.GridColumn4, Me.Revisi, Me.Status, Me.CapabilityDate, Me.Cek, Me.Note, Me.Seq, Me.Commit, Me.Commit1, Me.Runner, Me.DRR, Me.NoUrut, Me.ChangeFrom, Me.Active_})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PartNo
        '
        Me.PartNo.FieldName = "Part No"
        Me.PartNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.PartNo.Name = "PartNo"
        Me.PartNo.OptionsColumn.AllowEdit = False
        Me.PartNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PartNo.Visible = True
        Me.PartNo.VisibleIndex = 1
        Me.PartNo.Width = 167
        '
        'PartName
        '
        Me.PartName.FieldName = "Part Name"
        Me.PartName.Name = "PartName"
        Me.PartName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PartName.Visible = True
        Me.PartName.VisibleIndex = 2
        Me.PartName.Width = 190
        '
        'Machine
        '
        Me.Machine.FieldName = "Machine"
        Me.Machine.Name = "Machine"
        Me.Machine.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Machine.Visible = True
        Me.Machine.VisibleIndex = 3
        Me.Machine.Width = 66
        '
        'CT
        '
        Me.CT.AppearanceCell.Options.UseTextOptions = True
        Me.CT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CT.AppearanceHeader.Options.UseTextOptions = True
        Me.CT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CT.FieldName = "C/T"
        Me.CT.Name = "CT"
        Me.CT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CT.Visible = True
        Me.CT.VisibleIndex = 4
        Me.CT.Width = 71
        '
        'Cav
        '
        Me.Cav.AppearanceCell.Options.UseTextOptions = True
        Me.Cav.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cav.AppearanceHeader.Options.UseTextOptions = True
        Me.Cav.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cav.FieldName = "Cav"
        Me.Cav.Name = "Cav"
        Me.Cav.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Cav.Visible = True
        Me.Cav.VisibleIndex = 5
        Me.Cav.Width = 65
        '
        'Weight
        '
        Me.Weight.AppearanceCell.Options.UseTextOptions = True
        Me.Weight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.AppearanceHeader.Options.UseTextOptions = True
        Me.Weight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.FieldName = "Weight"
        Me.Weight.Name = "Weight"
        Me.Weight.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Weight.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.Weight.Visible = True
        Me.Weight.VisibleIndex = 6
        Me.Weight.Width = 83
        '
        'Material
        '
        Me.Material.AppearanceCell.Options.UseTextOptions = True
        Me.Material.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Material.AppearanceHeader.Options.UseTextOptions = True
        Me.Material.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Material.FieldName = "Material"
        Me.Material.Name = "Material"
        Me.Material.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Material.Visible = True
        Me.Material.VisibleIndex = 8
        Me.Material.Width = 147
        '
        'Inj
        '
        Me.Inj.AppearanceCell.Options.UseTextOptions = True
        Me.Inj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Inj.AppearanceHeader.Options.UseTextOptions = True
        Me.Inj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Inj.FieldName = "Inj"
        Me.Inj.Name = "Inj"
        Me.Inj.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Inj.Visible = True
        Me.Inj.VisibleIndex = 9
        '
        'Painting
        '
        Me.Painting.AppearanceCell.Options.UseTextOptions = True
        Me.Painting.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Painting.AppearanceHeader.Options.UseTextOptions = True
        Me.Painting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Painting.FieldName = "Painting"
        Me.Painting.Name = "Painting"
        Me.Painting.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Painting.Visible = True
        Me.Painting.VisibleIndex = 10
        '
        'Chrome
        '
        Me.Chrome.AppearanceCell.Options.UseTextOptions = True
        Me.Chrome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Chrome.AppearanceHeader.Options.UseTextOptions = True
        Me.Chrome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Chrome.FieldName = "Chrome"
        Me.Chrome.Name = "Chrome"
        Me.Chrome.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Chrome.Visible = True
        Me.Chrome.VisibleIndex = 11
        Me.Chrome.Width = 81
        '
        'Assy
        '
        Me.Assy.AppearanceCell.Options.UseTextOptions = True
        Me.Assy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Assy.AppearanceHeader.Options.UseTextOptions = True
        Me.Assy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Assy.FieldName = "Assy"
        Me.Assy.Name = "Assy"
        Me.Assy.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Assy.Visible = True
        Me.Assy.VisibleIndex = 12
        '
        'StatusMold
        '
        Me.StatusMold.AppearanceCell.Options.UseTextOptions = True
        Me.StatusMold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StatusMold.AppearanceHeader.Options.UseTextOptions = True
        Me.StatusMold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StatusMold.ColumnEdit = Me.RepStatusMold
        Me.StatusMold.FieldName = "Status Mold"
        Me.StatusMold.Name = "StatusMold"
        Me.StatusMold.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.StatusMold.Visible = True
        Me.StatusMold.VisibleIndex = 15
        Me.StatusMold.Width = 145
        '
        'RepStatusMold
        '
        Me.RepStatusMold.AutoHeight = False
        Me.RepStatusMold.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepStatusMold.Items.AddRange(New Object() {"Depreciation", "Sales"})
        Me.RepStatusMold.Name = "RepStatusMold"
        '
        'OrderMonth
        '
        Me.OrderMonth.AppearanceCell.Options.UseTextOptions = True
        Me.OrderMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderMonth.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderMonth.DisplayFormat.FormatString = "{0:N0}"
        Me.OrderMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderMonth.FieldName = "Order Month"
        Me.OrderMonth.Name = "OrderMonth"
        Me.OrderMonth.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.OrderMonth.Visible = True
        Me.OrderMonth.VisibleIndex = 16
        Me.OrderMonth.Width = 130
        '
        'Ultrasonic
        '
        Me.Ultrasonic.AppearanceCell.Options.UseTextOptions = True
        Me.Ultrasonic.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ultrasonic.AppearanceHeader.Options.UseTextOptions = True
        Me.Ultrasonic.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ultrasonic.FieldName = "Ultrasonic"
        Me.Ultrasonic.Name = "Ultrasonic"
        Me.Ultrasonic.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Ultrasonic.Visible = True
        Me.Ultrasonic.VisibleIndex = 13
        Me.Ultrasonic.Width = 82
        '
        'Vibration
        '
        Me.Vibration.AppearanceHeader.Options.UseTextOptions = True
        Me.Vibration.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Vibration.FieldName = "Vibration"
        Me.Vibration.Name = "Vibration"
        Me.Vibration.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Vibration.Visible = True
        Me.Vibration.VisibleIndex = 14
        '
        'GroupID
        '
        Me.GroupID.AppearanceCell.Options.UseTextOptions = True
        Me.GroupID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupID.AppearanceHeader.Options.UseTextOptions = True
        Me.GroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupID.FieldName = "Group ID"
        Me.GroupID.Name = "GroupID"
        Me.GroupID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GroupID.Visible = True
        Me.GroupID.VisibleIndex = 19
        Me.GroupID.Width = 84
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "ID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'Revisi
        '
        Me.Revisi.AppearanceCell.Options.UseTextOptions = True
        Me.Revisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Revisi.AppearanceHeader.Options.UseTextOptions = True
        Me.Revisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Revisi.FieldName = "Revisi"
        Me.Revisi.Name = "Revisi"
        Me.Revisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Revisi.Visible = True
        Me.Revisi.VisibleIndex = 21
        Me.Revisi.Width = 51
        '
        'Status
        '
        Me.Status.AppearanceCell.Options.UseTextOptions = True
        Me.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.AppearanceHeader.Options.UseTextOptions = True
        Me.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.ColumnEdit = Me.RepStatus
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 17
        '
        'RepStatus
        '
        Me.RepStatus.AutoHeight = False
        Me.RepStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepStatus.Items.AddRange(New Object() {"P", "D"})
        Me.RepStatus.Name = "RepStatus"
        '
        'CapabilityDate
        '
        Me.CapabilityDate.AppearanceCell.Options.UseTextOptions = True
        Me.CapabilityDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CapabilityDate.AppearanceHeader.Options.UseTextOptions = True
        Me.CapabilityDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CapabilityDate.ColumnEdit = Me.RepoCapability
        Me.CapabilityDate.FieldName = "Due Date NPD"
        Me.CapabilityDate.Name = "CapabilityDate"
        Me.CapabilityDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CapabilityDate.Visible = True
        Me.CapabilityDate.VisibleIndex = 18
        Me.CapabilityDate.Width = 109
        '
        'RepoCapability
        '
        Me.RepoCapability.AutoHeight = False
        Me.RepoCapability.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepoCapability.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepoCapability.Name = "RepoCapability"
        '
        'Cek
        '
        Me.Cek.AppearanceCell.Options.UseTextOptions = True
        Me.Cek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cek.AppearanceHeader.Options.UseTextOptions = True
        Me.Cek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cek.ColumnEdit = Me.Check
        Me.Cek.FieldName = "Cek"
        Me.Cek.Name = "Cek"
        Me.Cek.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Check
        '
        Me.Check.AutoHeight = False
        Me.Check.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Check.Items.AddRange(New Object() {"OK", "REVISE", "DELETE"})
        Me.Check.Name = "Check"
        '
        'Note
        '
        Me.Note.FieldName = "Note"
        Me.Note.Name = "Note"
        Me.Note.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Note.Visible = True
        Me.Note.VisibleIndex = 22
        Me.Note.Width = 279
        '
        'Seq
        '
        Me.Seq.FieldName = "Seq"
        Me.Seq.Name = "Seq"
        '
        'Commit
        '
        Me.Commit.ColumnEdit = Me.RepoComit
        Me.Commit.FieldName = "Commit NPD"
        Me.Commit.Name = "Commit"
        Me.Commit.Visible = True
        Me.Commit.VisibleIndex = 20
        '
        'RepoComit
        '
        Me.RepoComit.AutoHeight = False
        Me.RepoComit.Name = "RepoComit"
        '
        'Commit1
        '
        Me.Commit1.FieldName = "Commit1"
        Me.Commit1.Name = "Commit1"
        '
        'Runner
        '
        Me.Runner.AppearanceCell.Options.UseTextOptions = True
        Me.Runner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Runner.AppearanceHeader.Options.UseTextOptions = True
        Me.Runner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Runner.FieldName = "Runner"
        Me.Runner.Name = "Runner"
        Me.Runner.Visible = True
        Me.Runner.VisibleIndex = 7
        '
        'DRR
        '
        Me.DRR.AppearanceCell.Options.UseTextOptions = True
        Me.DRR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DRR.AppearanceHeader.Options.UseTextOptions = True
        Me.DRR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DRR.FieldName = "DRR"
        Me.DRR.Name = "DRR"
        Me.DRR.OptionsColumn.AllowEdit = False
        Me.DRR.Visible = True
        Me.DRR.VisibleIndex = 23
        '
        'NoUrut
        '
        Me.NoUrut.AppearanceCell.Options.UseTextOptions = True
        Me.NoUrut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoUrut.AppearanceHeader.Options.UseTextOptions = True
        Me.NoUrut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoUrut.ColumnEdit = Me.No_Urut
        Me.NoUrut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NoUrut.FieldName = "No Urut"
        Me.NoUrut.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NoUrut.Name = "NoUrut"
        Me.NoUrut.OptionsFilter.AllowFilter = False
        Me.NoUrut.Visible = True
        Me.NoUrut.VisibleIndex = 0
        Me.NoUrut.Width = 53
        '
        'No_Urut
        '
        Me.No_Urut.AutoHeight = False
        Me.No_Urut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.No_Urut.Name = "No_Urut"
        '
        'ChangeFrom
        '
        Me.ChangeFrom.ColumnEdit = Me.B_ChangeFrom
        Me.ChangeFrom.FieldName = "Change From"
        Me.ChangeFrom.Name = "ChangeFrom"
        Me.ChangeFrom.Visible = True
        Me.ChangeFrom.VisibleIndex = 24
        Me.ChangeFrom.Width = 209
        '
        'B_ChangeFrom
        '
        Me.B_ChangeFrom.AutoHeight = False
        Me.B_ChangeFrom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.B_ChangeFrom.Name = "B_ChangeFrom"
        '
        'Active_
        '
        Me.Active_.FieldName = "Active"
        Me.Active_.Name = "Active_"
        Me.Active_.OptionsColumn.AllowEdit = False
        Me.Active_.Visible = True
        Me.Active_.VisibleIndex = 25
        '
        'SingleCheck
        '
        Me.SingleCheck.AutoHeight = False
        Me.SingleCheck.Name = "SingleCheck"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TMassPro)
        Me.GroupBox1.Controls.Add(Me.TTargetQuot)
        Me.GroupBox1.Controls.Add(Me.TTargetDr)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(988, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 102)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Schedule"
        '
        'TMassPro
        '
        Me.TMassPro.EditValue = Nothing
        Me.TMassPro.Location = New System.Drawing.Point(115, 20)
        Me.TMassPro.Name = "TMassPro"
        Me.TMassPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TMassPro.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TMassPro.Properties.DisplayFormat.FormatString = "MMMM-yyyy"
        Me.TMassPro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TMassPro.Properties.EditFormat.FormatString = "MMMM-yyyy"
        Me.TMassPro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TMassPro.Properties.Mask.EditMask = "MMMM-yyyy"
        Me.TMassPro.Size = New System.Drawing.Size(131, 20)
        Me.TMassPro.TabIndex = 42
        '
        'TTargetQuot
        '
        Me.TTargetQuot.EditValue = Nothing
        Me.TTargetQuot.Location = New System.Drawing.Point(115, 65)
        Me.TTargetQuot.Name = "TTargetQuot"
        Me.TTargetQuot.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TTargetQuot.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TTargetQuot.Properties.DisplayFormat.FormatString = "dd-MMMM-yyyy"
        Me.TTargetQuot.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TTargetQuot.Properties.EditFormat.FormatString = "dd-MMMM-yyyy"
        Me.TTargetQuot.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TTargetQuot.Properties.Mask.EditMask = "dd-MMMM-yyyy"
        Me.TTargetQuot.Size = New System.Drawing.Size(131, 20)
        Me.TTargetQuot.TabIndex = 41
        '
        'TTargetDr
        '
        Me.TTargetDr.EditValue = Nothing
        Me.TTargetDr.Location = New System.Drawing.Point(115, 43)
        Me.TTargetDr.Name = "TTargetDr"
        Me.TTargetDr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TTargetDr.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TTargetDr.Properties.DisplayFormat.FormatString = "dd-MMMM-yyyy"
        Me.TTargetDr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TTargetDr.Properties.EditFormat.FormatString = "dd-MMMM-yyyy"
        Me.TTargetDr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TTargetDr.Properties.Mask.EditMask = "dd-MMMM-yyyy"
        Me.TTargetDr.Size = New System.Drawing.Size(131, 20)
        Me.TTargetDr.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Target Quotation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Target DR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "MassPro"
        '
        'B_AddRows
        '
        Me.B_AddRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_AddRows.Location = New System.Drawing.Point(1119, 440)
        Me.B_AddRows.Name = "B_AddRows"
        Me.B_AddRows.Size = New System.Drawing.Size(64, 21)
        Me.B_AddRows.TabIndex = 8
        Me.B_AddRows.Text = "Add Detail"
        Me.B_AddRows.UseVisualStyleBackColor = True
        Me.B_AddRows.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TIssue_Date)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CBCkr)
        Me.GroupBox2.Controls.Add(Me.TModelDesc)
        Me.GroupBox2.Controls.Add(Me.CBTng)
        Me.GroupBox2.Controls.Add(Me.CBStr)
        Me.GroupBox2.Controls.Add(Me.CBSample)
        Me.GroupBox2.Controls.Add(Me.CBCad)
        Me.GroupBox2.Controls.Add(Me.CBDrawing)
        Me.GroupBox2.Controls.Add(Me.TCategory)
        Me.GroupBox2.Location = New System.Drawing.Point(450, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 102)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Technical Info (Available)"
        '
        'TIssue_Date
        '
        Me.TIssue_Date.EditValue = Nothing
        Me.TIssue_Date.Location = New System.Drawing.Point(97, 45)
        Me.TIssue_Date.Name = "TIssue_Date"
        Me.TIssue_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TIssue_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TIssue_Date.Properties.DisplayFormat.FormatString = "dd-MMMM-yyyy"
        Me.TIssue_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TIssue_Date.Properties.EditFormat.FormatString = "dd-MMMM-yyyy"
        Me.TIssue_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TIssue_Date.Properties.Mask.EditMask = "dd-MMMM-yyyy"
        Me.TIssue_Date.Size = New System.Drawing.Size(125, 20)
        Me.TIssue_Date.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Issue Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Class Category"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(228, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Model Desc"
        '
        'CBCkr
        '
        Me.CBCkr.AutoSize = True
        Me.CBCkr.Location = New System.Drawing.Point(366, 73)
        Me.CBCkr.Name = "CBCkr"
        Me.CBCkr.Size = New System.Drawing.Size(72, 17)
        Me.CBCkr.TabIndex = 43
        Me.CBCkr.Text = "TSC CKR"
        Me.CBCkr.UseVisualStyleBackColor = True
        '
        'TModelDesc
        '
        Me.TModelDesc.Location = New System.Drawing.Point(308, 45)
        Me.TModelDesc.Name = "TModelDesc"
        Me.TModelDesc.Properties.MaxLength = 30
        Me.TModelDesc.Size = New System.Drawing.Size(216, 20)
        Me.TModelDesc.TabIndex = 31
        '
        'CBTng
        '
        Me.CBTng.AutoSize = True
        Me.CBTng.Location = New System.Drawing.Point(446, 73)
        Me.CBTng.Name = "CBTng"
        Me.CBTng.Size = New System.Drawing.Size(73, 17)
        Me.CBTng.TabIndex = 42
        Me.CBTng.Text = "TSC TNG"
        Me.CBTng.UseVisualStyleBackColor = True
        '
        'CBStr
        '
        Me.CBStr.AutoSize = True
        Me.CBStr.Location = New System.Drawing.Point(308, 73)
        Me.CBStr.Name = "CBStr"
        Me.CBStr.Size = New System.Drawing.Size(48, 17)
        Me.CBStr.TabIndex = 41
        Me.CBStr.Text = "STR"
        Me.CBStr.UseVisualStyleBackColor = True
        '
        'CBSample
        '
        Me.CBSample.AutoSize = True
        Me.CBSample.Location = New System.Drawing.Point(245, 73)
        Me.CBSample.Name = "CBSample"
        Me.CBSample.Size = New System.Drawing.Size(61, 17)
        Me.CBSample.TabIndex = 40
        Me.CBSample.Text = "Sampel"
        Me.CBSample.UseVisualStyleBackColor = True
        '
        'CBCad
        '
        Me.CBCad.AutoSize = True
        Me.CBCad.Location = New System.Drawing.Point(164, 73)
        Me.CBCad.Name = "CBCad"
        Me.CBCad.Size = New System.Drawing.Size(71, 17)
        Me.CBCad.TabIndex = 39
        Me.CBCad.Text = "Cad Data"
        Me.CBCad.UseVisualStyleBackColor = True
        '
        'CBDrawing
        '
        Me.CBDrawing.AutoSize = True
        Me.CBDrawing.Location = New System.Drawing.Point(98, 73)
        Me.CBDrawing.Name = "CBDrawing"
        Me.CBDrawing.Size = New System.Drawing.Size(65, 17)
        Me.CBDrawing.TabIndex = 38
        Me.CBDrawing.Text = "Drawing"
        Me.CBDrawing.UseVisualStyleBackColor = True
        '
        'TCategory
        '
        Me.TCategory.Location = New System.Drawing.Point(97, 23)
        Me.TCategory.Name = "TCategory"
        Me.TCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TCategory.Properties.DropDownRows = 4
        Me.TCategory.Properties.NullText = ""
        Me.TCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TCategory.Size = New System.Drawing.Size(429, 20)
        Me.TCategory.TabIndex = 44
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TRevisi)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TOrderMaxMonth)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TOrderMonth)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TModel)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TNPP_No)
        Me.GroupBox3.Controls.Add(Me.TCustomer)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 102)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Model Information "
        '
        'TRevisi
        '
        Me.TRevisi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TRevisi.Enabled = False
        Me.TRevisi.Location = New System.Drawing.Point(392, 23)
        Me.TRevisi.Name = "TRevisi"
        Me.TRevisi.Size = New System.Drawing.Size(28, 20)
        Me.TRevisi.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Order Max (M)"
        '
        'TOrderMaxMonth
        '
        Me.TOrderMaxMonth.Location = New System.Drawing.Point(328, 70)
        Me.TOrderMaxMonth.Name = "TOrderMaxMonth"
        Me.TOrderMaxMonth.Properties.DisplayFormat.FormatString = "{0:N0}"
        Me.TOrderMaxMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TOrderMaxMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TOrderMaxMonth.Size = New System.Drawing.Size(92, 20)
        Me.TOrderMaxMonth.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Order  (M)"
        '
        'TOrderMonth
        '
        Me.TOrderMonth.Location = New System.Drawing.Point(328, 47)
        Me.TOrderMonth.Name = "TOrderMonth"
        Me.TOrderMonth.Properties.DisplayFormat.FormatString = "{0:N0}"
        Me.TOrderMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TOrderMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TOrderMonth.Size = New System.Drawing.Size(92, 20)
        Me.TOrderMonth.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Model"
        '
        'TModel
        '
        Me.TModel.Location = New System.Drawing.Point(76, 70)
        Me.TModel.Name = "TModel"
        Me.TModel.Properties.MaxLength = 12
        Me.TModel.Size = New System.Drawing.Size(171, 20)
        Me.TModel.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "NPP NO"
        '
        'TNPP_No
        '
        Me.TNPP_No.Location = New System.Drawing.Point(76, 23)
        Me.TNPP_No.Name = "TNPP_No"
        Me.TNPP_No.Properties.MaxLength = 48
        Me.TNPP_No.Size = New System.Drawing.Size(310, 20)
        Me.TNPP_No.TabIndex = 21
        '
        'TCustomer
        '
        Me.TCustomer.Location = New System.Drawing.Point(76, 47)
        Me.TCustomer.Name = "TCustomer"
        Me.TCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TCustomer.Properties.DropDownRows = 10
        Me.TCustomer.Properties.MaxLength = 6
        Me.TCustomer.Properties.NullText = ""
        Me.TCustomer.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.TCustomer.Properties.PopupSizeable = False
        Me.TCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TCustomer.Size = New System.Drawing.Size(171, 20)
        Me.TCustomer.TabIndex = 23
        '
        'TRevisiInformasi
        '
        Me.TRevisiInformasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TRevisiInformasi.Location = New System.Drawing.Point(129, 440)
        Me.TRevisiInformasi.Name = "TRevisiInformasi"
        Me.TRevisiInformasi.Properties.MaxLength = 100
        Me.TRevisiInformasi.Size = New System.Drawing.Size(269, 20)
        Me.TRevisiInformasi.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 443)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Revision Information"
        '
        'BSetGroup
        '
        Me.BSetGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSetGroup.Location = New System.Drawing.Point(959, 439)
        Me.BSetGroup.Name = "BSetGroup"
        Me.BSetGroup.Size = New System.Drawing.Size(75, 21)
        Me.BSetGroup.TabIndex = 34
        Me.BSetGroup.Text = "Set Group"
        Me.BSetGroup.UseVisualStyleBackColor = True
        Me.BSetGroup.Visible = False
        '
        'B_Submit
        '
        Me.B_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Submit.Location = New System.Drawing.Point(1143, 439)
        Me.B_Submit.Name = "B_Submit"
        Me.B_Submit.Size = New System.Drawing.Size(104, 23)
        Me.B_Submit.TabIndex = 35
        Me.B_Submit.Text = "Submit To NPD"
        Me.B_Submit.UseVisualStyleBackColor = True
        Me.B_Submit.Visible = False
        '
        'BUpload
        '
        Me.BUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BUpload.Location = New System.Drawing.Point(1189, 439)
        Me.BUpload.Name = "BUpload"
        Me.BUpload.Size = New System.Drawing.Size(64, 21)
        Me.BUpload.TabIndex = 36
        Me.BUpload.Text = "Upload"
        Me.BUpload.UseVisualStyleBackColor = True
        Me.BUpload.Visible = False
        '
        'B_Reject
        '
        Me.B_Reject.BackColor = System.Drawing.Color.Yellow
        Me.B_Reject.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Reject.Location = New System.Drawing.Point(365, 2)
        Me.B_Reject.Name = "B_Reject"
        Me.B_Reject.Size = New System.Drawing.Size(26, 23)
        Me.B_Reject.TabIndex = 38
        Me.B_Reject.Text = "R"
        Me.B_Reject.UseVisualStyleBackColor = False
        Me.B_Reject.Visible = False
        '
        'B_Approve
        '
        Me.B_Approve.BackColor = System.Drawing.Color.Lime
        Me.B_Approve.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Approve.Location = New System.Drawing.Point(336, 2)
        Me.B_Approve.Name = "B_Approve"
        Me.B_Approve.Size = New System.Drawing.Size(26, 23)
        Me.B_Approve.TabIndex = 37
        Me.B_Approve.Text = "A"
        Me.B_Approve.UseVisualStyleBackColor = False
        Me.B_Approve.Visible = False
        '
        'B_Revise
        '
        Me.B_Revise.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Revise.Location = New System.Drawing.Point(1040, 438)
        Me.B_Revise.Name = "B_Revise"
        Me.B_Revise.Size = New System.Drawing.Size(73, 23)
        Me.B_Revise.TabIndex = 39
        Me.B_Revise.Text = "Revision"
        Me.B_Revise.UseVisualStyleBackColor = True
        Me.B_Revise.Visible = False
        '
        'Frm_NPP_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1253, 472)
        Me.Controls.Add(Me.B_Revise)
        Me.Controls.Add(Me.B_Reject)
        Me.Controls.Add(Me.B_Approve)
        Me.Controls.Add(Me.BUpload)
        Me.Controls.Add(Me.B_Submit)
        Me.Controls.Add(Me.BSetGroup)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TRevisiInformasi)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.B_AddRows)
        Me.Controls.Add(Me.Grid)
        Me.Name = "Frm_NPP_Detail"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.Grid, 0)
        Me.Controls.SetChildIndex(Me.B_AddRows, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.TRevisiInformasi, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.BSetGroup, 0)
        Me.Controls.SetChildIndex(Me.B_Submit, 0)
        Me.Controls.SetChildIndex(Me.BUpload, 0)
        Me.Controls.SetChildIndex(Me.B_Approve, 0)
        Me.Controls.SetChildIndex(Me.B_Reject, 0)
        Me.Controls.SetChildIndex(Me.B_Revise, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepStatusMold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoCapability.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoCapability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoComit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.No_Urut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B_ChangeFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SingleCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TMassPro.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMassPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTargetQuot.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTargetQuot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTargetDr.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTargetDr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TIssue_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIssue_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TModelDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TRevisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOrderMaxMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOrderMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TNPP_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRevisiInformasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents PartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Machine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cav As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Inj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Painting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Chrome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Assy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusMold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBStr As CheckBox
    Friend WithEvents CBSample As CheckBox
    Friend WithEvents CBCad As CheckBox
    Friend WithEvents CBDrawing As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TOrderMaxMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents TOrderMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents TModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CBCkr As CheckBox
    Friend WithEvents CBTng As CheckBox
    Friend WithEvents B_AddRows As Button
    Friend WithEvents TCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TCategory As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents TNPP_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TRevisi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TRevisiInformasi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As Label
    Friend WithEvents TTargetQuot As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TTargetDr As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Ultrasonic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents TModelDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vibration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SingleCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BSetGroup As Button
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TMassPro As DevExpress.XtraEditors.DateEdit
    Friend WithEvents B_Submit As Button
    Friend WithEvents TIssue_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents BUpload As Button
    Friend WithEvents Revisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CapabilityDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Check As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Note As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepStatusMold As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents B_Reject As Button
    Friend WithEvents B_Approve As Button
    Friend WithEvents Commit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Commit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_Revise As Button
    Friend WithEvents Runner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DRR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoCapability As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepoComit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents NoUrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_Urut As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents ChangeFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents B_ChangeFrom As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Active_ As DevExpress.XtraGrid.Columns.GridColumn
End Class
