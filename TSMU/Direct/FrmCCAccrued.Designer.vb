<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCCAccrued
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
        Me.GridAccrued = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAccrued = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GTanggalTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GNoTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSeq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GJenisTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCurryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAmountIDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CAmountIDR = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GCreditCardNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GBankName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnProses = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCCNumber = New DevExpress.XtraEditors.ButtonEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabPageProses = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabPageCancel = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridAccruedAll = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAccruedAll = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabPagePaid = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl5 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridAccruedPaid = New DevExpress.XtraGrid.GridControl()
        Me.GridViewAccruedPaid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridAccrued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAccrued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAmountIDR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtCCNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.TabPageProses.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCancel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.GridAccruedAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAccruedAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePaid.SuspendLayout()
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl5.SuspendLayout()
        CType(Me.GridAccruedPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAccruedPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAccrued
        '
        Me.GridAccrued.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAccrued.Location = New System.Drawing.Point(12, 12)
        Me.GridAccrued.MainView = Me.GridViewAccrued
        Me.GridAccrued.Name = "GridAccrued"
        Me.GridAccrued.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CAmountIDR})
        Me.GridAccrued.Size = New System.Drawing.Size(858, 379)
        Me.GridAccrued.TabIndex = 1
        Me.GridAccrued.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAccrued})
        '
        'GridViewAccrued
        '
        Me.GridViewAccrued.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GTanggalTransaksi, Me.GNoTransaksi, Me.GSeq, Me.GJenisTransaksi, Me.GDescription, Me.GCurryID, Me.GAmount, Me.GRate, Me.GAmountIDR, Me.GCreditCardNumber, Me.GAccountName, Me.GBankName})
        Me.GridViewAccrued.GridControl = Me.GridAccrued
        Me.GridViewAccrued.Name = "GridViewAccrued"
        Me.GridViewAccrued.OptionsSelection.MultiSelect = True
        Me.GridViewAccrued.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridViewAccrued.OptionsView.ShowFooter = True
        '
        'GTanggalTransaksi
        '
        Me.GTanggalTransaksi.Caption = "Tanggal Transaksi"
        Me.GTanggalTransaksi.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.GTanggalTransaksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GTanggalTransaksi.FieldName = "TanggalTransaksi"
        Me.GTanggalTransaksi.MinWidth = 25
        Me.GTanggalTransaksi.Name = "GTanggalTransaksi"
        Me.GTanggalTransaksi.OptionsColumn.AllowEdit = False
        Me.GTanggalTransaksi.OptionsColumn.FixedWidth = True
        Me.GTanggalTransaksi.Visible = True
        Me.GTanggalTransaksi.VisibleIndex = 1
        Me.GTanggalTransaksi.Width = 140
        '
        'GNoTransaksi
        '
        Me.GNoTransaksi.Caption = "No Transaksi"
        Me.GNoTransaksi.FieldName = "NoTransaksi"
        Me.GNoTransaksi.MinWidth = 25
        Me.GNoTransaksi.Name = "GNoTransaksi"
        Me.GNoTransaksi.OptionsColumn.AllowEdit = False
        Me.GNoTransaksi.OptionsColumn.FixedWidth = True
        Me.GNoTransaksi.Visible = True
        Me.GNoTransaksi.VisibleIndex = 2
        Me.GNoTransaksi.Width = 140
        '
        'GSeq
        '
        Me.GSeq.Caption = "Seq"
        Me.GSeq.FieldName = "Seq"
        Me.GSeq.MinWidth = 25
        Me.GSeq.Name = "GSeq"
        Me.GSeq.OptionsColumn.AllowEdit = False
        Me.GSeq.OptionsColumn.FixedWidth = True
        Me.GSeq.Width = 94
        '
        'GJenisTransaksi
        '
        Me.GJenisTransaksi.Caption = "Jenis Transaksi"
        Me.GJenisTransaksi.FieldName = "JenisTransaksi"
        Me.GJenisTransaksi.MinWidth = 25
        Me.GJenisTransaksi.Name = "GJenisTransaksi"
        Me.GJenisTransaksi.OptionsColumn.AllowEdit = False
        Me.GJenisTransaksi.OptionsColumn.FixedWidth = True
        Me.GJenisTransaksi.Visible = True
        Me.GJenisTransaksi.VisibleIndex = 3
        Me.GJenisTransaksi.Width = 120
        '
        'GDescription
        '
        Me.GDescription.Caption = "Description"
        Me.GDescription.FieldName = "Description"
        Me.GDescription.MinWidth = 25
        Me.GDescription.Name = "GDescription"
        Me.GDescription.OptionsColumn.AllowEdit = False
        Me.GDescription.Visible = True
        Me.GDescription.VisibleIndex = 4
        Me.GDescription.Width = 25
        '
        'GCurryID
        '
        Me.GCurryID.Caption = "Curry ID"
        Me.GCurryID.FieldName = "CurryID"
        Me.GCurryID.MinWidth = 25
        Me.GCurryID.Name = "GCurryID"
        Me.GCurryID.OptionsColumn.AllowEdit = False
        Me.GCurryID.OptionsColumn.FixedWidth = True
        Me.GCurryID.Visible = True
        Me.GCurryID.VisibleIndex = 5
        Me.GCurryID.Width = 70
        '
        'GAmount
        '
        Me.GAmount.Caption = "Amount"
        Me.GAmount.DisplayFormat.FormatString = "n2"
        Me.GAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAmount.FieldName = "Amount"
        Me.GAmount.MinWidth = 25
        Me.GAmount.Name = "GAmount"
        Me.GAmount.OptionsColumn.AllowEdit = False
        Me.GAmount.OptionsColumn.FixedWidth = True
        Me.GAmount.Visible = True
        Me.GAmount.VisibleIndex = 6
        Me.GAmount.Width = 140
        '
        'GRate
        '
        Me.GRate.Caption = "Rate"
        Me.GRate.DisplayFormat.FormatString = "n2"
        Me.GRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GRate.FieldName = "Rate"
        Me.GRate.MinWidth = 25
        Me.GRate.Name = "GRate"
        Me.GRate.OptionsColumn.AllowEdit = False
        Me.GRate.OptionsColumn.FixedWidth = True
        Me.GRate.Visible = True
        Me.GRate.VisibleIndex = 7
        Me.GRate.Width = 120
        '
        'GAmountIDR
        '
        Me.GAmountIDR.Caption = "Amount IDR"
        Me.GAmountIDR.ColumnEdit = Me.CAmountIDR
        Me.GAmountIDR.DisplayFormat.FormatString = "n2"
        Me.GAmountIDR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GAmountIDR.FieldName = "AmountIDR"
        Me.GAmountIDR.MinWidth = 25
        Me.GAmountIDR.Name = "GAmountIDR"
        Me.GAmountIDR.OptionsColumn.FixedWidth = True
        Me.GAmountIDR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountIDR", "{0:#,##0.#0}")})
        Me.GAmountIDR.Visible = True
        Me.GAmountIDR.VisibleIndex = 8
        Me.GAmountIDR.Width = 140
        '
        'CAmountIDR
        '
        Me.CAmountIDR.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CAmountIDR.AutoHeight = False
        Me.CAmountIDR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAmountIDR.DisplayFormat.FormatString = "n2"
        Me.CAmountIDR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAmountIDR.EditFormat.FormatString = "n2"
        Me.CAmountIDR.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAmountIDR.Mask.EditMask = "n2"
        Me.CAmountIDR.Name = "CAmountIDR"
        '
        'GCreditCardNumber
        '
        Me.GCreditCardNumber.Caption = "Credit Card Number"
        Me.GCreditCardNumber.FieldName = "CreditCardNumber"
        Me.GCreditCardNumber.MinWidth = 25
        Me.GCreditCardNumber.Name = "GCreditCardNumber"
        Me.GCreditCardNumber.OptionsColumn.AllowEdit = False
        Me.GCreditCardNumber.OptionsColumn.FixedWidth = True
        Me.GCreditCardNumber.Visible = True
        Me.GCreditCardNumber.VisibleIndex = 9
        Me.GCreditCardNumber.Width = 160
        '
        'GAccountName
        '
        Me.GAccountName.Caption = "Account Name"
        Me.GAccountName.FieldName = "AccountName"
        Me.GAccountName.MinWidth = 25
        Me.GAccountName.Name = "GAccountName"
        Me.GAccountName.OptionsColumn.AllowEdit = False
        Me.GAccountName.OptionsColumn.FixedWidth = True
        Me.GAccountName.Visible = True
        Me.GAccountName.VisibleIndex = 10
        Me.GAccountName.Width = 210
        '
        'GBankName
        '
        Me.GBankName.Caption = "Bank Name"
        Me.GBankName.FieldName = "BankName"
        Me.GBankName.MinWidth = 25
        Me.GBankName.Name = "GBankName"
        Me.GBankName.OptionsColumn.AllowEdit = False
        Me.GBankName.OptionsColumn.FixedWidth = True
        Me.GBankName.Visible = True
        Me.GBankName.VisibleIndex = 11
        Me.GBankName.Width = 130
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnProses)
        Me.LayoutControl1.Controls.Add(Me.txtCCNumber)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(955, 0, 812, 500)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(882, 54)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(12, 12)
        Me.btnProses.MaximumSize = New System.Drawing.Size(68, 0)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(68, 27)
        Me.btnProses.StyleController = Me.LayoutControl1
        Me.btnProses.TabIndex = 4
        Me.btnProses.Text = "PROSES"
        '
        'txtCCNumber
        '
        Me.txtCCNumber.Location = New System.Drawing.Point(222, 12)
        Me.txtCCNumber.MaximumSize = New System.Drawing.Size(190, 0)
        Me.txtCCNumber.Name = "txtCCNumber"
        Me.txtCCNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCCNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCCNumber.Size = New System.Drawing.Size(189, 22)
        Me.txtCCNumber.StyleController = Me.LayoutControl1
        Me.txtCCNumber.TabIndex = 6
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem6})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(882, 54)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnProses
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(72, 34)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(403, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(459, 34)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCCNumber
        Me.LayoutControlItem6.Location = New System.Drawing.Point(72, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(331, 34)
        Me.LayoutControlItem6.Text = "Credit Card Number"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(125, 20)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 27)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.TabPageProses
        Me.XtraTabControl1.Size = New System.Drawing.Size(895, 503)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPageProses, Me.TabPageCancel, Me.TabPagePaid})
        '
        'TabPageProses
        '
        Me.TabPageProses.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPageProses.Name = "TabPageProses"
        Me.TabPageProses.Size = New System.Drawing.Size(888, 469)
        Me.TabPageProses.Text = "Proses"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LayoutControl1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LayoutControl2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(888, 469)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridAccrued)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(3, 63)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(882, 403)
        Me.LayoutControl2.TabIndex = 3
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(882, 403)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridAccrued
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(862, 383)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'TabPageCancel
        '
        Me.TabPageCancel.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageCancel.Name = "TabPageCancel"
        Me.TabPageCancel.Size = New System.Drawing.Size(888, 469)
        Me.TabPageCancel.Text = "Accrued"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(888, 469)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.btnCancel)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(882, 54)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 12)
        Me.btnCancel.MaximumSize = New System.Drawing.Size(90, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 27)
        Me.btnCancel.StyleController = Me.LayoutControl3
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "CANCEL"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(882, 54)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnCancel
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(94, 34)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(94, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(768, 34)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.GridAccruedAll)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(3, 63)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup3
        Me.LayoutControl4.Size = New System.Drawing.Size(882, 403)
        Me.LayoutControl4.TabIndex = 1
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'GridAccruedAll
        '
        Me.GridAccruedAll.Location = New System.Drawing.Point(12, 12)
        Me.GridAccruedAll.MainView = Me.GridViewAccruedAll
        Me.GridAccruedAll.Name = "GridAccruedAll"
        Me.GridAccruedAll.Size = New System.Drawing.Size(858, 379)
        Me.GridAccruedAll.TabIndex = 4
        Me.GridAccruedAll.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAccruedAll})
        '
        'GridViewAccruedAll
        '
        Me.GridViewAccruedAll.GridControl = Me.GridAccruedAll
        Me.GridViewAccruedAll.Name = "GridViewAccruedAll"
        Me.GridViewAccruedAll.OptionsBehavior.Editable = False
        Me.GridViewAccruedAll.OptionsSelection.MultiSelect = True
        Me.GridViewAccruedAll.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridViewAccruedAll.OptionsView.ColumnAutoWidth = False
        Me.GridViewAccruedAll.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(882, 403)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.GridAccruedAll
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(862, 383)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'TabPagePaid
        '
        Me.TabPagePaid.Controls.Add(Me.LayoutControl5)
        Me.TabPagePaid.Name = "TabPagePaid"
        Me.TabPagePaid.Size = New System.Drawing.Size(888, 469)
        Me.TabPagePaid.Text = "Paid"
        '
        'LayoutControl5
        '
        Me.LayoutControl5.Controls.Add(Me.GridAccruedPaid)
        Me.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl5.Name = "LayoutControl5"
        Me.LayoutControl5.Root = Me.LayoutControlGroup4
        Me.LayoutControl5.Size = New System.Drawing.Size(888, 469)
        Me.LayoutControl5.TabIndex = 0
        Me.LayoutControl5.Text = "LayoutControl5"
        '
        'GridAccruedPaid
        '
        Me.GridAccruedPaid.Location = New System.Drawing.Point(12, 12)
        Me.GridAccruedPaid.MainView = Me.GridViewAccruedPaid
        Me.GridAccruedPaid.Name = "GridAccruedPaid"
        Me.GridAccruedPaid.Size = New System.Drawing.Size(864, 445)
        Me.GridAccruedPaid.TabIndex = 4
        Me.GridAccruedPaid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAccruedPaid})
        '
        'GridViewAccruedPaid
        '
        Me.GridViewAccruedPaid.GridControl = Me.GridAccruedPaid
        Me.GridViewAccruedPaid.Name = "GridViewAccruedPaid"
        Me.GridViewAccruedPaid.OptionsBehavior.Editable = False
        Me.GridViewAccruedPaid.OptionsView.ColumnAutoWidth = False
        Me.GridViewAccruedPaid.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(888, 469)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridAccruedPaid
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(868, 449)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'FrmCCAccrued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(895, 530)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "FrmCCAccrued"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.GridAccrued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAccrued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAmountIDR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtCCNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.TabPageProses.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCancel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.GridAccruedAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAccruedAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePaid.ResumeLayout(False)
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl5.ResumeLayout(False)
        CType(Me.GridAccruedPaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAccruedPaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridAccrued As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAccrued As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabPageProses As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabPageCancel As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridAccruedAll As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAccruedAll As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnProses As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabPagePaid As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCCNumber As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControl5 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridAccruedPaid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAccruedPaid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GTanggalTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GNoTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GJenisTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCurryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAmountIDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCreditCardNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GBankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CAmountIDR As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
