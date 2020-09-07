<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTravelTicketDetail
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
        Me.txtNoVoucher = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridTicket = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTicket = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Seq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeptID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Purpose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Destination = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Negara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartureDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ArrivalDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TicketNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CAmount = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.StatusTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CStatusTicket = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Check = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.btnProsesInvoice = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.txtNoVoucher.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CStatusTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoVoucher
        '
        Me.txtNoVoucher.Enabled = False
        Me.txtNoVoucher.Location = New System.Drawing.Point(81, 12)
        Me.txtNoVoucher.MaximumSize = New System.Drawing.Size(140, 22)
        Me.txtNoVoucher.Name = "txtNoVoucher"
        Me.txtNoVoucher.Size = New System.Drawing.Size(139, 22)
        Me.txtNoVoucher.StyleController = Me.LayoutControl1
        Me.txtNoVoucher.TabIndex = 8
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnProsesInvoice)
        Me.LayoutControl1.Controls.Add(Me.btnAddDetail)
        Me.LayoutControl1.Controls.Add(Me.txtNoVoucher)
        Me.LayoutControl1.Controls.Add(Me.dtTanggal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(643, 448, 812, 500)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1176, 54)
        Me.LayoutControl1.TabIndex = 23
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridTicket
        '
        Me.GridTicket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTicket.Location = New System.Drawing.Point(12, 12)
        Me.GridTicket.MainView = Me.GridViewTicket
        Me.GridTicket.Name = "GridTicket"
        Me.GridTicket.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CAmount, Me.CCheck, Me.CStatusTicket})
        Me.GridTicket.Size = New System.Drawing.Size(1152, 461)
        Me.GridTicket.TabIndex = 12
        Me.GridTicket.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTicket})
        '
        'GridViewTicket
        '
        Me.GridViewTicket.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoRequest, Me.Seq, Me.Nama, Me.DeptID, Me.Purpose, Me.Destination, Me.Negara, Me.DepartureDate, Me.ArrivalDate, Me.TicketNumber, Me.CuryID, Me.Amount, Me.StatusTicket, Me.Invoice, Me.Check})
        Me.GridViewTicket.GridControl = Me.GridTicket
        Me.GridViewTicket.Name = "GridViewTicket"
        Me.GridViewTicket.OptionsView.ShowGroupPanel = False
        '
        'NoRequest
        '
        Me.NoRequest.Caption = "No Request"
        Me.NoRequest.FieldName = "NoRequest"
        Me.NoRequest.MinWidth = 25
        Me.NoRequest.Name = "NoRequest"
        Me.NoRequest.OptionsColumn.AllowEdit = False
        Me.NoRequest.OptionsColumn.FixedWidth = True
        Me.NoRequest.Visible = True
        Me.NoRequest.VisibleIndex = 0
        Me.NoRequest.Width = 140
        '
        'Seq
        '
        Me.Seq.Caption = "Seq"
        Me.Seq.FieldName = "Seq"
        Me.Seq.MinWidth = 25
        Me.Seq.Name = "Seq"
        Me.Seq.Width = 94
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.MinWidth = 25
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.FixedWidth = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 1
        Me.Nama.Width = 200
        '
        'DeptID
        '
        Me.DeptID.Caption = "Dept ID"
        Me.DeptID.FieldName = "DeptID"
        Me.DeptID.MinWidth = 25
        Me.DeptID.Name = "DeptID"
        Me.DeptID.OptionsColumn.AllowEdit = False
        Me.DeptID.OptionsColumn.FixedWidth = True
        Me.DeptID.Visible = True
        Me.DeptID.VisibleIndex = 2
        Me.DeptID.Width = 80
        '
        'Purpose
        '
        Me.Purpose.Caption = "Purpose"
        Me.Purpose.FieldName = "Purpose"
        Me.Purpose.MinWidth = 25
        Me.Purpose.Name = "Purpose"
        Me.Purpose.OptionsColumn.AllowEdit = False
        Me.Purpose.Visible = True
        Me.Purpose.VisibleIndex = 3
        Me.Purpose.Width = 25
        '
        'Destination
        '
        Me.Destination.Caption = "Destination"
        Me.Destination.FieldName = "Destination"
        Me.Destination.MinWidth = 25
        Me.Destination.Name = "Destination"
        Me.Destination.OptionsColumn.AllowEdit = False
        Me.Destination.OptionsColumn.FixedWidth = True
        Me.Destination.Visible = True
        Me.Destination.VisibleIndex = 4
        Me.Destination.Width = 150
        '
        'Negara
        '
        Me.Negara.Caption = "Negara"
        Me.Negara.FieldName = "Negara"
        Me.Negara.MinWidth = 25
        Me.Negara.Name = "Negara"
        Me.Negara.OptionsColumn.AllowEdit = False
        Me.Negara.OptionsColumn.FixedWidth = True
        Me.Negara.Visible = True
        Me.Negara.VisibleIndex = 5
        Me.Negara.Width = 120
        '
        'DepartureDate
        '
        Me.DepartureDate.Caption = "Departure Date"
        Me.DepartureDate.FieldName = "DepartureDate"
        Me.DepartureDate.MinWidth = 25
        Me.DepartureDate.Name = "DepartureDate"
        Me.DepartureDate.OptionsColumn.AllowEdit = False
        Me.DepartureDate.OptionsColumn.FixedWidth = True
        Me.DepartureDate.Visible = True
        Me.DepartureDate.VisibleIndex = 6
        Me.DepartureDate.Width = 120
        '
        'ArrivalDate
        '
        Me.ArrivalDate.Caption = "Arrival Date"
        Me.ArrivalDate.FieldName = "ArrivalDate"
        Me.ArrivalDate.MinWidth = 25
        Me.ArrivalDate.Name = "ArrivalDate"
        Me.ArrivalDate.OptionsColumn.AllowEdit = False
        Me.ArrivalDate.OptionsColumn.FixedWidth = True
        Me.ArrivalDate.Visible = True
        Me.ArrivalDate.VisibleIndex = 7
        Me.ArrivalDate.Width = 120
        '
        'TicketNumber
        '
        Me.TicketNumber.Caption = "Ticket Number"
        Me.TicketNumber.FieldName = "TicketNumber"
        Me.TicketNumber.MinWidth = 25
        Me.TicketNumber.Name = "TicketNumber"
        Me.TicketNumber.OptionsColumn.AllowEdit = False
        Me.TicketNumber.OptionsColumn.FixedWidth = True
        Me.TicketNumber.Visible = True
        Me.TicketNumber.VisibleIndex = 8
        Me.TicketNumber.Width = 140
        '
        'CuryID
        '
        Me.CuryID.Caption = "Curry ID"
        Me.CuryID.FieldName = "CuryID"
        Me.CuryID.MinWidth = 25
        Me.CuryID.Name = "CuryID"
        Me.CuryID.OptionsColumn.AllowEdit = False
        Me.CuryID.OptionsColumn.FixedWidth = True
        Me.CuryID.Visible = True
        Me.CuryID.VisibleIndex = 9
        Me.CuryID.Width = 70
        '
        'Amount
        '
        Me.Amount.Caption = "Amount"
        Me.Amount.ColumnEdit = Me.CAmount
        Me.Amount.FieldName = "Amount"
        Me.Amount.MinWidth = 25
        Me.Amount.Name = "Amount"
        Me.Amount.OptionsColumn.AllowEdit = False
        Me.Amount.OptionsColumn.FixedWidth = True
        Me.Amount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:#,##0.#0}")})
        Me.Amount.Visible = True
        Me.Amount.VisibleIndex = 10
        Me.Amount.Width = 140
        '
        'CAmount
        '
        Me.CAmount.AutoHeight = False
        Me.CAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAmount.DisplayFormat.FormatString = "n2"
        Me.CAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAmount.EditFormat.FormatString = "n2"
        Me.CAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAmount.Name = "CAmount"
        '
        'StatusTicket
        '
        Me.StatusTicket.Caption = "Status Ticket"
        Me.StatusTicket.ColumnEdit = Me.CStatusTicket
        Me.StatusTicket.FieldName = "StatusTicket"
        Me.StatusTicket.MinWidth = 25
        Me.StatusTicket.Name = "StatusTicket"
        Me.StatusTicket.OptionsColumn.AllowEdit = False
        Me.StatusTicket.OptionsColumn.FixedWidth = True
        Me.StatusTicket.Visible = True
        Me.StatusTicket.VisibleIndex = 11
        Me.StatusTicket.Width = 100
        '
        'CStatusTicket
        '
        Me.CStatusTicket.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CStatusTicket.AutoHeight = False
        Me.CStatusTicket.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CStatusTicket.Items.AddRange(New Object() {"ISSUE", "INVOICE", "CLOSE", "CANCEL"})
        Me.CStatusTicket.Name = "CStatusTicket"
        '
        'Invoice
        '
        Me.Invoice.Caption = "Invoice"
        Me.Invoice.FieldName = "Invoice"
        Me.Invoice.MinWidth = 25
        Me.Invoice.Name = "Invoice"
        Me.Invoice.OptionsColumn.AllowEdit = False
        Me.Invoice.OptionsColumn.FixedWidth = True
        Me.Invoice.Visible = True
        Me.Invoice.VisibleIndex = 12
        Me.Invoice.Width = 120
        '
        'Check
        '
        Me.Check.Caption = "Check"
        Me.Check.ColumnEdit = Me.CCheck
        Me.Check.FieldName = "CheckList"
        Me.Check.MinWidth = 25
        Me.Check.Name = "Check"
        Me.Check.OptionsColumn.FixedWidth = True
        Me.Check.Visible = True
        Me.Check.VisibleIndex = 13
        Me.Check.Width = 60
        '
        'CCheck
        '
        Me.CCheck.AutoHeight = False
        Me.CCheck.Name = "CCheck"
        '
        'btnProsesInvoice
        '
        Me.btnProsesInvoice.Location = New System.Drawing.Point(1045, 12)
        Me.btnProsesInvoice.MaximumSize = New System.Drawing.Size(120, 27)
        Me.btnProsesInvoice.Name = "btnProsesInvoice"
        Me.btnProsesInvoice.Size = New System.Drawing.Size(119, 27)
        Me.btnProsesInvoice.StyleController = Me.LayoutControl1
        Me.btnProsesInvoice.TabIndex = 22
        Me.btnProsesInvoice.Text = "Input Invoice"
        '
        'btnAddDetail
        '
        Me.btnAddDetail.Location = New System.Drawing.Point(913, 12)
        Me.btnAddDetail.MaximumSize = New System.Drawing.Size(120, 27)
        Me.btnAddDetail.Name = "btnAddDetail"
        Me.btnAddDetail.Size = New System.Drawing.Size(120, 27)
        Me.btnAddDetail.StyleController = Me.LayoutControl1
        Me.btnAddDetail.TabIndex = 21
        Me.btnAddDetail.Text = "Add Detail"
        '
        'dtTanggal
        '
        Me.dtTanggal.EditValue = Nothing
        Me.dtTanggal.Enabled = False
        Me.dtTanggal.Location = New System.Drawing.Point(311, 12)
        Me.dtTanggal.MaximumSize = New System.Drawing.Size(140, 22)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dtTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTanggal.Properties.Mask.EditMask = ""
        Me.dtTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtTanggal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtTanggal.Size = New System.Drawing.Size(139, 22)
        Me.dtTanggal.StyleController = Me.LayoutControl1
        Me.dtTanggal.TabIndex = 13
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1176, 54)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNoVoucher
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(212, 34)
        Me.LayoutControlItem1.Text = "No Voucher"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(66, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtTanggal
        Me.LayoutControlItem2.Location = New System.Drawing.Point(212, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(230, 34)
        Me.LayoutControlItem2.Text = "Tanggal"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(66, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnAddDetail
        Me.LayoutControlItem3.Location = New System.Drawing.Point(901, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(124, 34)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnProsesInvoice
        Me.LayoutControlItem4.Location = New System.Drawing.Point(1025, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(131, 34)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(442, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(459, 34)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1182, 551)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridTicket)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(3, 63)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1176, 485)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1176, 485)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridTicket
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1156, 465)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'FrmTravelTicketDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1182, 578)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmTravelTicketDetail"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        CType(Me.txtNoVoucher.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CStatusTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoVoucher As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridTicket As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTicket As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeptID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Purpose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Destination As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Negara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartureDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArrivalDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TicketNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CAmount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CStatusTicket As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Invoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProsesInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
