<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rpt_ViewPayment2
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Rpt_ViewPayment2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colvrno1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvendorname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltot_DPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltot_PPN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpph1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrand_Total1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbiaya_transfer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Bayar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colvrno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldpp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colppn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpph = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgrand_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbiaya_transfer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotal_bayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnLoad = New System.Windows.Forms.ToolStripButton()
        Me.ProgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmb_supplier = New System.Windows.Forms.ComboBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateEdit2_sup = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1_sup = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnLoad_sup = New System.Windows.Forms.ToolStripButton()
        Me.Progbar_sup = New System.Windows.Forms.ToolStripProgressBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2_sup.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2_sup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1_sup.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1_sup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(803, 554)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DateEdit2)
        Me.TabPage1.Controls.Add(Me.DateEdit1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(795, 528)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Filter By Tgl"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(251, 7)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(143, 20)
        Me.DateEdit2.TabIndex = 18
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(48, 7)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(143, 20)
        Me.DateEdit1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GridControl3)
        Me.Panel1.Controls.Add(Me.GridControl2)
        Me.Panel1.Controls.Add(Me.Grid)
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Location = New System.Drawing.Point(3, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 489)
        Me.Panel1.TabIndex = 16
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = Nothing
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 25)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(789, 464)
        Me.GridControl3.TabIndex = 5
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4, Me.GridView5})
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl3
        Me.GridView5.Name = "GridView5"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Query"
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 25)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(789, 464)
        Me.GridControl2.TabIndex = 4
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colvrno1, Me.coltgl1, Me.colvendorname1, Me.coltot_DPP, Me.coltot_PPN, Me.colTotal1, Me.colpph1, Me.colGrand_Total1, Me.colbiaya_transfer1, Me.colTotal_Bayar1})
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colvrno1
        '
        Me.colvrno1.FieldName = "vrno"
        Me.colvrno1.Name = "colvrno1"
        Me.colvrno1.Visible = True
        Me.colvrno1.VisibleIndex = 0
        '
        'coltgl1
        '
        Me.coltgl1.FieldName = "tgl"
        Me.coltgl1.Name = "coltgl1"
        Me.coltgl1.Visible = True
        Me.coltgl1.VisibleIndex = 1
        '
        'colvendorname1
        '
        Me.colvendorname1.FieldName = "vendorname"
        Me.colvendorname1.Name = "colvendorname1"
        Me.colvendorname1.Visible = True
        Me.colvendorname1.VisibleIndex = 2
        '
        'coltot_DPP
        '
        Me.coltot_DPP.FieldName = "tot_DPP"
        Me.coltot_DPP.Name = "coltot_DPP"
        Me.coltot_DPP.Visible = True
        Me.coltot_DPP.VisibleIndex = 3
        '
        'coltot_PPN
        '
        Me.coltot_PPN.FieldName = "tot_PPN"
        Me.coltot_PPN.Name = "coltot_PPN"
        Me.coltot_PPN.Visible = True
        Me.coltot_PPN.VisibleIndex = 4
        '
        'colTotal1
        '
        Me.colTotal1.FieldName = "Total"
        Me.colTotal1.Name = "colTotal1"
        Me.colTotal1.Visible = True
        Me.colTotal1.VisibleIndex = 5
        '
        'colpph1
        '
        Me.colpph1.FieldName = "pph"
        Me.colpph1.Name = "colpph1"
        Me.colpph1.Visible = True
        Me.colpph1.VisibleIndex = 6
        '
        'colGrand_Total1
        '
        Me.colGrand_Total1.FieldName = "Grand_Total"
        Me.colGrand_Total1.Name = "colGrand_Total1"
        Me.colGrand_Total1.Visible = True
        Me.colGrand_Total1.VisibleIndex = 7
        '
        'colbiaya_transfer1
        '
        Me.colbiaya_transfer1.FieldName = "biaya_transfer"
        Me.colbiaya_transfer1.Name = "colbiaya_transfer1"
        Me.colbiaya_transfer1.Visible = True
        Me.colbiaya_transfer1.VisibleIndex = 8
        '
        'colTotal_Bayar1
        '
        Me.colTotal_Bayar1.FieldName = "Total_Bayar"
        Me.colTotal_Bayar1.Name = "colTotal_Bayar1"
        Me.colTotal_Bayar1.Visible = True
        Me.colTotal_Bayar1.VisibleIndex = 9
        '
        'Grid
        '
        Me.Grid.DataMember = "ViewPayment"
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(0, 25)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(789, 464)
        Me.Grid.TabIndex = 3
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colvrno, Me.coltgl, Me.colvendorname, Me.coldpp, Me.colppn, Me.coltotal, Me.colpph, Me.colgrand_total, Me.colbiaya_transfer, Me.coltotal_bayar})
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colvrno
        '
        Me.colvrno.FieldName = "vrno"
        Me.colvrno.Name = "colvrno"
        Me.colvrno.Visible = True
        Me.colvrno.VisibleIndex = 0
        '
        'coltgl
        '
        Me.coltgl.FieldName = "tgl"
        Me.coltgl.Name = "coltgl"
        Me.coltgl.Visible = True
        Me.coltgl.VisibleIndex = 1
        '
        'colvendorname
        '
        Me.colvendorname.FieldName = "vendorname"
        Me.colvendorname.Name = "colvendorname"
        Me.colvendorname.Visible = True
        Me.colvendorname.VisibleIndex = 2
        '
        'coldpp
        '
        Me.coldpp.FieldName = "dpp"
        Me.coldpp.Name = "coldpp"
        Me.coldpp.Visible = True
        Me.coldpp.VisibleIndex = 3
        '
        'colppn
        '
        Me.colppn.FieldName = "ppn"
        Me.colppn.Name = "colppn"
        Me.colppn.Visible = True
        Me.colppn.VisibleIndex = 4
        '
        'coltotal
        '
        Me.coltotal.FieldName = "total"
        Me.coltotal.Name = "coltotal"
        Me.coltotal.Visible = True
        Me.coltotal.VisibleIndex = 5
        '
        'colpph
        '
        Me.colpph.FieldName = "pph"
        Me.colpph.Name = "colpph"
        Me.colpph.Visible = True
        Me.colpph.VisibleIndex = 6
        '
        'colgrand_total
        '
        Me.colgrand_total.FieldName = "grand_total"
        Me.colgrand_total.Name = "colgrand_total"
        Me.colgrand_total.Visible = True
        Me.colgrand_total.VisibleIndex = 7
        '
        'colbiaya_transfer
        '
        Me.colbiaya_transfer.FieldName = "biaya_transfer"
        Me.colbiaya_transfer.Name = "colbiaya_transfer"
        Me.colbiaya_transfer.Visible = True
        Me.colbiaya_transfer.VisibleIndex = 8
        '
        'coltotal_bayar
        '
        Me.coltotal_bayar.FieldName = "total_bayar"
        Me.coltotal_bayar.Name = "coltotal_bayar"
        Me.coltotal_bayar.Visible = True
        Me.coltotal_bayar.VisibleIndex = 9
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLoad, Me.ProgBar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(789, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnLoad
        '
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(80, 22)
        Me.btnLoad.Text = "Load Data"
        '
        'ProgBar
        '
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(100, 22)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Until :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmb_supplier)
        Me.TabPage3.Controls.Add(Me.GridControl1)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.DateEdit2_sup)
        Me.TabPage3.Controls.Add(Me.DateEdit1_sup)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.ToolStrip3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(795, 528)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Filter By Supplier"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmb_supplier
        '
        Me.cmb_supplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_supplier.FormattingEnabled = True
        Me.cmb_supplier.Location = New System.Drawing.Point(467, 6)
        Me.cmb_supplier.Name = "cmb_supplier"
        Me.cmb_supplier.Size = New System.Drawing.Size(233, 21)
        Me.cmb_supplier.TabIndex = 27
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.Location = New System.Drawing.Point(0, 62)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(789, 462)
        Me.GridControl1.TabIndex = 26
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView6})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GridControl1
        Me.GridView6.Name = "GridView6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(410, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Supplier :"
        '
        'DateEdit2_sup
        '
        Me.DateEdit2_sup.EditValue = Nothing
        Me.DateEdit2_sup.Location = New System.Drawing.Point(251, 6)
        Me.DateEdit2_sup.Name = "DateEdit2_sup"
        Me.DateEdit2_sup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2_sup.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2_sup.Size = New System.Drawing.Size(143, 20)
        Me.DateEdit2_sup.TabIndex = 22
        '
        'DateEdit1_sup
        '
        Me.DateEdit1_sup.EditValue = Nothing
        Me.DateEdit1_sup.Location = New System.Drawing.Point(48, 6)
        Me.DateEdit1_sup.Name = "DateEdit1_sup"
        Me.DateEdit1_sup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1_sup.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1_sup.Size = New System.Drawing.Size(143, 20)
        Me.DateEdit1_sup.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Until :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "From :"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLoad_sup, Me.Progbar_sup})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 34)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(194, 25)
        Me.ToolStrip3.TabIndex = 25
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnLoad_sup
        '
        Me.btnLoad_sup.Image = CType(resources.GetObject("btnLoad_sup.Image"), System.Drawing.Image)
        Me.btnLoad_sup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoad_sup.Name = "btnLoad_sup"
        Me.btnLoad_sup.Size = New System.Drawing.Size(80, 22)
        Me.btnLoad_sup.Text = "Load Data"
        '
        'Progbar_sup
        '
        Me.Progbar_sup.Name = "Progbar_sup"
        Me.Progbar_sup.Size = New System.Drawing.Size(100, 22)
        '
        'Frm_Rpt_ViewPayment2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(828, 581)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_Rpt_ViewPayment2"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2_sup.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2_sup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1_sup.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1_sup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colvrno1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvendorname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltot_DPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltot_PPN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpph1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrand_Total1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiaya_transfer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Bayar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colvrno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldpp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgrand_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiaya_transfer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotal_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btnLoad As ToolStripButton
    Friend WithEvents ProgBar As ToolStripProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmb_supplier As ComboBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label5 As Label
    Friend WithEvents DateEdit2_sup As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1_sup As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents btnLoad_sup As ToolStripButton
    Friend WithEvents Progbar_sup As ToolStripProgressBar
End Class
