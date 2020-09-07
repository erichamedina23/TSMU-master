<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTravelTicketInvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtVendor = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNoInvoice = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotAmount = New DevExpress.XtraEditors.TextEdit()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCuryID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnSaveInvoice = New DevExpress.XtraEditors.SimpleButton()
        Me.dtDueDate = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridInvoice = New DevExpress.XtraGrid.GridControl()
        Me.GridViewInvoice = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Check = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.chkBalance = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBalance = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNoInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.txtBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtVendor
        '
        Me.txtVendor.Location = New System.Drawing.Point(77, 12)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtVendor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtVendor.Size = New System.Drawing.Size(209, 22)
        Me.txtVendor.StyleController = Me.LayoutControl1
        Me.txtVendor.TabIndex = 14
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtVendor)
        Me.LayoutControl1.Controls.Add(Me.txtNoInvoice)
        Me.LayoutControl1.Controls.Add(Me.txtTotAmount)
        Me.LayoutControl1.Controls.Add(Me.dtDate)
        Me.LayoutControl1.Controls.Add(Me.txtCuryID)
        Me.LayoutControl1.Controls.Add(Me.btnSaveInvoice)
        Me.LayoutControl1.Controls.Add(Me.dtDueDate)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1376, 54)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNoInvoice
        '
        Me.txtNoInvoice.Location = New System.Drawing.Point(363, 12)
        Me.txtNoInvoice.MaximumSize = New System.Drawing.Size(130, 0)
        Me.txtNoInvoice.MinimumSize = New System.Drawing.Size(130, 0)
        Me.txtNoInvoice.Name = "txtNoInvoice"
        Me.txtNoInvoice.Size = New System.Drawing.Size(130, 22)
        Me.txtNoInvoice.StyleController = Me.LayoutControl1
        Me.txtNoInvoice.TabIndex = 16
        '
        'txtTotAmount
        '
        Me.txtTotAmount.Location = New System.Drawing.Point(1141, 12)
        Me.txtTotAmount.MaximumSize = New System.Drawing.Size(130, 0)
        Me.txtTotAmount.MinimumSize = New System.Drawing.Size(130, 0)
        Me.txtTotAmount.Name = "txtTotAmount"
        Me.txtTotAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTotAmount.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotAmount.Properties.EditFormat.FormatString = "n2"
        Me.txtTotAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotAmount.Properties.Mask.EditMask = "n2"
        Me.txtTotAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotAmount.Size = New System.Drawing.Size(130, 22)
        Me.txtTotAmount.StyleController = Me.LayoutControl1
        Me.txtTotAmount.TabIndex = 26
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.Location = New System.Drawing.Point(560, 12)
        Me.dtDate.MaximumSize = New System.Drawing.Size(120, 0)
        Me.dtDate.MinimumSize = New System.Drawing.Size(120, 0)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.dtDate.Size = New System.Drawing.Size(120, 22)
        Me.dtDate.StyleController = Me.LayoutControl1
        Me.dtDate.TabIndex = 21
        '
        'txtCuryID
        '
        Me.txtCuryID.EditValue = "IDR"
        Me.txtCuryID.Location = New System.Drawing.Point(974, 12)
        Me.txtCuryID.MaximumSize = New System.Drawing.Size(70, 0)
        Me.txtCuryID.MinimumSize = New System.Drawing.Size(70, 0)
        Me.txtCuryID.Name = "txtCuryID"
        Me.txtCuryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCuryID.Properties.Items.AddRange(New Object() {"IDR", "USD", "YEN"})
        Me.txtCuryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCuryID.Size = New System.Drawing.Size(70, 22)
        Me.txtCuryID.StyleController = Me.LayoutControl1
        Me.txtCuryID.TabIndex = 25
        '
        'btnSaveInvoice
        '
        Me.btnSaveInvoice.Location = New System.Drawing.Point(1283, 12)
        Me.btnSaveInvoice.MaximumSize = New System.Drawing.Size(90, 0)
        Me.btnSaveInvoice.Name = "btnSaveInvoice"
        Me.btnSaveInvoice.Size = New System.Drawing.Size(81, 27)
        Me.btnSaveInvoice.StyleController = Me.LayoutControl1
        Me.btnSaveInvoice.TabIndex = 19
        Me.btnSaveInvoice.Text = "Save Invoice"
        '
        'dtDueDate
        '
        Me.dtDueDate.EditValue = Nothing
        Me.dtDueDate.Location = New System.Drawing.Point(767, 12)
        Me.dtDueDate.MaximumSize = New System.Drawing.Size(120, 0)
        Me.dtDueDate.MinimumSize = New System.Drawing.Size(120, 0)
        Me.dtDueDate.Name = "dtDueDate"
        Me.dtDueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDueDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dtDueDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDueDate.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dtDueDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtDueDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.dtDueDate.Size = New System.Drawing.Size(120, 22)
        Me.dtDueDate.StyleController = Me.LayoutControl1
        Me.dtDueDate.TabIndex = 23
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1376, 54)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtVendor
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(278, 34)
        Me.LayoutControlItem1.Text = "Vendor"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 16)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNoInvoice
        Me.LayoutControlItem2.Location = New System.Drawing.Point(278, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(207, 34)
        Me.LayoutControlItem2.Text = "Invoice"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 16)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dtDate
        Me.LayoutControlItem3.Location = New System.Drawing.Point(485, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(187, 34)
        Me.LayoutControlItem3.Text = "Date"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 16)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtDueDate
        Me.LayoutControlItem4.Location = New System.Drawing.Point(672, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(207, 34)
        Me.LayoutControlItem4.Text = "Due Date"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(70, 16)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtCuryID
        Me.LayoutControlItem5.Location = New System.Drawing.Point(879, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(157, 34)
        Me.LayoutControlItem5.Text = "Curry ID"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(70, 16)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtTotAmount
        Me.LayoutControlItem6.Location = New System.Drawing.Point(1036, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(227, 34)
        Me.LayoutControlItem6.Text = "Total Amount"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(80, 16)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnSaveInvoice
        Me.LayoutControlItem7.Location = New System.Drawing.Point(1263, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(93, 34)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'GridInvoice
        '
        Me.GridInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridInvoice.Location = New System.Drawing.Point(12, 12)
        Me.GridInvoice.MainView = Me.GridViewInvoice
        Me.GridInvoice.Name = "GridInvoice"
        Me.GridInvoice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CAmount, Me.CCheck, Me.CStatus})
        Me.GridInvoice.Size = New System.Drawing.Size(1352, 428)
        Me.GridInvoice.TabIndex = 20
        Me.GridInvoice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewInvoice})
        '
        'GridViewInvoice
        '
        Me.GridViewInvoice.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoRequest, Me.Seq, Me.Nama, Me.DeptID, Me.Purpose, Me.Destination, Me.Negara, Me.DepartureDate, Me.ArrivalDate, Me.TicketNumber, Me.CuryID, Me.Amount, Me.Status, Me.Invoice, Me.Check})
        Me.GridViewInvoice.GridControl = Me.GridInvoice
        Me.GridViewInvoice.Name = "GridViewInvoice"
        Me.GridViewInvoice.OptionsView.ShowFooter = True
        Me.GridViewInvoice.OptionsView.ShowGroupPanel = False
        '
        'NoRequest
        '
        Me.NoRequest.Caption = "No Request"
        Me.NoRequest.FieldName = "NoRequest"
        Me.NoRequest.MinWidth = 25
        Me.NoRequest.Name = "NoRequest"
        Me.NoRequest.OptionsColumn.AllowEdit = False
        Me.NoRequest.OptionsColumn.FixedWidth = True
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
        Me.Nama.VisibleIndex = 0
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
        Me.DeptID.Width = 80
        '
        'Purpose
        '
        Me.Purpose.Caption = "Purpose"
        Me.Purpose.FieldName = "Purpose"
        Me.Purpose.MinWidth = 25
        Me.Purpose.Name = "Purpose"
        Me.Purpose.OptionsColumn.AllowEdit = False
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
        Me.Destination.VisibleIndex = 1
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
        Me.Negara.Width = 120
        '
        'DepartureDate
        '
        Me.DepartureDate.Caption = "Departure Date"
        Me.DepartureDate.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.DepartureDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DepartureDate.FieldName = "DepartureDate"
        Me.DepartureDate.MinWidth = 25
        Me.DepartureDate.Name = "DepartureDate"
        Me.DepartureDate.OptionsColumn.AllowEdit = False
        Me.DepartureDate.OptionsColumn.FixedWidth = True
        Me.DepartureDate.Visible = True
        Me.DepartureDate.VisibleIndex = 2
        Me.DepartureDate.Width = 120
        '
        'ArrivalDate
        '
        Me.ArrivalDate.Caption = "Arrival Date"
        Me.ArrivalDate.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.ArrivalDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ArrivalDate.FieldName = "ArrivalDate"
        Me.ArrivalDate.MinWidth = 25
        Me.ArrivalDate.Name = "ArrivalDate"
        Me.ArrivalDate.OptionsColumn.AllowEdit = False
        Me.ArrivalDate.OptionsColumn.FixedWidth = True
        Me.ArrivalDate.Visible = True
        Me.ArrivalDate.VisibleIndex = 3
        Me.ArrivalDate.Width = 120
        '
        'TicketNumber
        '
        Me.TicketNumber.Caption = "Ticket Number"
        Me.TicketNumber.FieldName = "TicketNumber"
        Me.TicketNumber.MinWidth = 25
        Me.TicketNumber.Name = "TicketNumber"
        Me.TicketNumber.OptionsColumn.FixedWidth = True
        Me.TicketNumber.Visible = True
        Me.TicketNumber.VisibleIndex = 4
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
        Me.CuryID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.CuryID.Visible = True
        Me.CuryID.VisibleIndex = 5
        Me.CuryID.Width = 70
        '
        'Amount
        '
        Me.Amount.Caption = "Amount"
        Me.Amount.ColumnEdit = Me.CAmount
        Me.Amount.DisplayFormat.FormatString = "n2"
        Me.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Amount.FieldName = "Amount"
        Me.Amount.MinWidth = 25
        Me.Amount.Name = "Amount"
        Me.Amount.OptionsColumn.FixedWidth = True
        Me.Amount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:#,##0.#0}")})
        Me.Amount.Visible = True
        Me.Amount.VisibleIndex = 6
        Me.Amount.Width = 130
        '
        'CAmount
        '
        Me.CAmount.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CAmount.AutoHeight = False
        Me.CAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CAmount.DisplayFormat.FormatString = "n2"
        Me.CAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAmount.EditFormat.FormatString = "n2"
        Me.CAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CAmount.Mask.EditMask = "n2"
        Me.CAmount.Name = "CAmount"
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.ColumnEdit = Me.CStatus
        Me.Status.FieldName = "Status"
        Me.Status.MinWidth = 25
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.FixedWidth = True
        Me.Status.Width = 100
        '
        'CStatus
        '
        Me.CStatus.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CStatus.AutoHeight = False
        Me.CStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CStatus.Items.AddRange(New Object() {"BOOKED", "INVOICE", "CLOSE", "CANCEL"})
        Me.CStatus.Name = "CStatus"
        '
        'Invoice
        '
        Me.Invoice.Caption = "Invoice"
        Me.Invoice.FieldName = "Invoice"
        Me.Invoice.MinWidth = 25
        Me.Invoice.Name = "Invoice"
        Me.Invoice.OptionsColumn.FixedWidth = True
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
        Me.Check.Width = 60
        '
        'CCheck
        '
        Me.CCheck.AutoHeight = False
        Me.CCheck.Name = "CCheck"
        '
        'chkBalance
        '
        Me.chkBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkBalance.EditValue = True
        Me.chkBalance.Location = New System.Drawing.Point(1140, 12)
        Me.chkBalance.MaximumSize = New System.Drawing.Size(50, 0)
        Me.chkBalance.Name = "chkBalance"
        Me.chkBalance.Properties.Caption = ""
        Me.chkBalance.Size = New System.Drawing.Size(50, 19)
        Me.chkBalance.StyleController = Me.LayoutControl3
        Me.chkBalance.TabIndex = 31
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.Label8)
        Me.LayoutControl3.Controls.Add(Me.chkBalance)
        Me.LayoutControl3.Controls.Add(Me.txtBalance)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(3, 521)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1108, 96, 812, 500)
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(1376, 49)
        Me.LayoutControl3.TabIndex = 2
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(1027, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Selisih"
        '
        'txtBalance
        '
        Me.txtBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBalance.Enabled = False
        Me.txtBalance.Location = New System.Drawing.Point(1194, 12)
        Me.txtBalance.MaximumSize = New System.Drawing.Size(170, 0)
        Me.txtBalance.MinimumSize = New System.Drawing.Size(170, 0)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBalance.Properties.EditFormat.FormatString = "n2"
        Me.txtBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBalance.Properties.Mask.EditMask = "n0"
        Me.txtBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBalance.Size = New System.Drawing.Size(170, 22)
        Me.txtBalance.StyleController = Me.LayoutControl3
        Me.txtBalance.TabIndex = 29
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1376, 49)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtBalance
        Me.LayoutControlItem9.Location = New System.Drawing.Point(1182, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(174, 29)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.chkBalance
        Me.LayoutControlItem10.Location = New System.Drawing.Point(1128, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(54, 29)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.Label8
        Me.LayoutControlItem11.Location = New System.Drawing.Point(1015, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(113, 29)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1015, 29)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1382, 573)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridInvoice)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(3, 63)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1376, 452)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1376, 452)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridInvoice
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1356, 432)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'FrmTravelTicketInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 573)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTravelTicketInvoice"
        Me.Text = "FrmTravelTicketInvoice"
        CType(Me.txtVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNoInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.txtBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVendor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNoInvoice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSaveInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridInvoice As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewInvoice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Seq As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents CAmount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Invoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dtDueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTotAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuryID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkBalance As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
