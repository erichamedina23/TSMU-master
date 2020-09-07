<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTravelTicket
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabPageRequest = New DevExpress.XtraTab.XtraTabPage()
        Me.GridRequest = New DevExpress.XtraGrid.GridControl()
        Me.GridViewRequest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeptID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Purpose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TravelType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Destination = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Negara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoPaspor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Visa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartureDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ArrivalDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StatusTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CStatusTicket = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.TabPageTicket = New DevExpress.XtraTab.XtraTabPage()
        Me.GridTicket = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTicket = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoVoucher = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vendor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.TabPageRequest.SuspendLayout()
        CType(Me.GridRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CStatusTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTicket.SuspendLayout()
        CType(Me.GridTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 39)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.TabPageRequest
        Me.XtraTabControl1.Size = New System.Drawing.Size(931, 555)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPageRequest, Me.TabPageTicket})
        '
        'TabPageRequest
        '
        Me.TabPageRequest.Controls.Add(Me.GridRequest)
        Me.TabPageRequest.Name = "TabPageRequest"
        Me.TabPageRequest.Size = New System.Drawing.Size(924, 521)
        Me.TabPageRequest.Text = "Ticket"
        '
        'GridRequest
        '
        Me.GridRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRequest.Location = New System.Drawing.Point(3, 3)
        Me.GridRequest.MainView = Me.GridViewRequest
        Me.GridRequest.Name = "GridRequest"
        Me.GridRequest.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CStatusTicket})
        Me.GridRequest.Size = New System.Drawing.Size(918, 515)
        Me.GridRequest.TabIndex = 0
        Me.GridRequest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewRequest})
        '
        'GridViewRequest
        '
        Me.GridViewRequest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoRequest, Me.Nama, Me.DeptID, Me.Purpose, Me.TravelType, Me.Destination, Me.Negara, Me.NoPaspor, Me.Visa, Me.DepartureDate, Me.ArrivalDate, Me.Status, Me.StatusTicket})
        Me.GridViewRequest.GridControl = Me.GridRequest
        Me.GridViewRequest.Name = "GridViewRequest"
        Me.GridViewRequest.OptionsView.ShowGroupPanel = False
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
        'TravelType
        '
        Me.TravelType.Caption = "Travel Type"
        Me.TravelType.FieldName = "TravelType"
        Me.TravelType.MinWidth = 25
        Me.TravelType.Name = "TravelType"
        Me.TravelType.OptionsColumn.AllowEdit = False
        Me.TravelType.OptionsColumn.FixedWidth = True
        Me.TravelType.Visible = True
        Me.TravelType.VisibleIndex = 4
        Me.TravelType.Width = 100
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
        Me.Destination.VisibleIndex = 5
        Me.Destination.Width = 200
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
        Me.Negara.VisibleIndex = 6
        Me.Negara.Width = 120
        '
        'NoPaspor
        '
        Me.NoPaspor.Caption = "No Paspor"
        Me.NoPaspor.FieldName = "NoPaspor"
        Me.NoPaspor.MinWidth = 25
        Me.NoPaspor.Name = "NoPaspor"
        Me.NoPaspor.OptionsColumn.AllowEdit = False
        Me.NoPaspor.OptionsColumn.FixedWidth = True
        Me.NoPaspor.Visible = True
        Me.NoPaspor.VisibleIndex = 7
        Me.NoPaspor.Width = 130
        '
        'Visa
        '
        Me.Visa.Caption = "Visa"
        Me.Visa.FieldName = "Visa"
        Me.Visa.MinWidth = 25
        Me.Visa.Name = "Visa"
        Me.Visa.OptionsColumn.AllowEdit = False
        Me.Visa.OptionsColumn.FixedWidth = True
        Me.Visa.Visible = True
        Me.Visa.VisibleIndex = 8
        Me.Visa.Width = 130
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
        Me.DepartureDate.VisibleIndex = 9
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
        Me.ArrivalDate.VisibleIndex = 10
        Me.ArrivalDate.Width = 120
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.MinWidth = 25
        Me.Status.Name = "Status"
        Me.Status.Width = 94
        '
        'StatusTicket
        '
        Me.StatusTicket.Caption = "StatusTicket"
        Me.StatusTicket.ColumnEdit = Me.CStatusTicket
        Me.StatusTicket.FieldName = "StatusTicket"
        Me.StatusTicket.MinWidth = 25
        Me.StatusTicket.Name = "StatusTicket"
        Me.StatusTicket.OptionsColumn.FixedWidth = True
        Me.StatusTicket.Visible = True
        Me.StatusTicket.VisibleIndex = 11
        Me.StatusTicket.Width = 100
        '
        'CStatusTicket
        '
        Me.CStatusTicket.AutoHeight = False
        Me.CStatusTicket.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CStatusTicket.Items.AddRange(New Object() {"ISSUE", "CLOSE", "CANCEL"})
        Me.CStatusTicket.Name = "CStatusTicket"
        Me.CStatusTicket.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'TabPageTicket
        '
        Me.TabPageTicket.Controls.Add(Me.GridTicket)
        Me.TabPageTicket.Name = "TabPageTicket"
        Me.TabPageTicket.Size = New System.Drawing.Size(924, 521)
        Me.TabPageTicket.Text = "Invoice"
        '
        'GridTicket
        '
        Me.GridTicket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTicket.Location = New System.Drawing.Point(3, 3)
        Me.GridTicket.MainView = Me.GridViewTicket
        Me.GridTicket.Name = "GridTicket"
        Me.GridTicket.Size = New System.Drawing.Size(918, 515)
        Me.GridTicket.TabIndex = 0
        Me.GridTicket.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTicket})
        '
        'GridViewTicket
        '
        Me.GridViewTicket.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoVoucher, Me.Tanggal, Me.Vendor, Me.NoInvoice, Me.CuryID, Me.TotAmount})
        Me.GridViewTicket.GridControl = Me.GridTicket
        Me.GridViewTicket.Name = "GridViewTicket"
        Me.GridViewTicket.OptionsBehavior.Editable = False
        Me.GridViewTicket.OptionsView.ColumnAutoWidth = False
        Me.GridViewTicket.OptionsView.ShowGroupPanel = False
        '
        'NoVoucher
        '
        Me.NoVoucher.Caption = "No Voucher"
        Me.NoVoucher.FieldName = "NoVoucher"
        Me.NoVoucher.MinWidth = 25
        Me.NoVoucher.Name = "NoVoucher"
        Me.NoVoucher.OptionsColumn.FixedWidth = True
        Me.NoVoucher.Visible = True
        Me.NoVoucher.VisibleIndex = 0
        Me.NoVoucher.Width = 150
        '
        'Tanggal
        '
        Me.Tanggal.Caption = "Tanggal"
        Me.Tanggal.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.Tanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggal.FieldName = "Tanggal"
        Me.Tanggal.MinWidth = 25
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.OptionsColumn.FixedWidth = True
        Me.Tanggal.Visible = True
        Me.Tanggal.VisibleIndex = 1
        Me.Tanggal.Width = 140
        '
        'Vendor
        '
        Me.Vendor.Caption = "Vendor"
        Me.Vendor.FieldName = "Vendor"
        Me.Vendor.MinWidth = 25
        Me.Vendor.Name = "Vendor"
        Me.Vendor.OptionsColumn.FixedWidth = True
        Me.Vendor.Visible = True
        Me.Vendor.VisibleIndex = 2
        Me.Vendor.Width = 180
        '
        'NoInvoice
        '
        Me.NoInvoice.Caption = "No Invoice"
        Me.NoInvoice.FieldName = "NoInvoice"
        Me.NoInvoice.MinWidth = 25
        Me.NoInvoice.Name = "NoInvoice"
        Me.NoInvoice.OptionsColumn.FixedWidth = True
        Me.NoInvoice.Visible = True
        Me.NoInvoice.VisibleIndex = 3
        Me.NoInvoice.Width = 150
        '
        'CuryID
        '
        Me.CuryID.Caption = "Cury ID"
        Me.CuryID.FieldName = "CuryID"
        Me.CuryID.MinWidth = 25
        Me.CuryID.Name = "CuryID"
        Me.CuryID.OptionsColumn.FixedWidth = True
        Me.CuryID.Visible = True
        Me.CuryID.VisibleIndex = 4
        Me.CuryID.Width = 120
        '
        'TotAmount
        '
        Me.TotAmount.Caption = "Total Amount"
        Me.TotAmount.DisplayFormat.FormatString = "n2"
        Me.TotAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotAmount.FieldName = "TotAmount"
        Me.TotAmount.MinWidth = 25
        Me.TotAmount.Name = "TotAmount"
        Me.TotAmount.Visible = True
        Me.TotAmount.VisibleIndex = 5
        Me.TotAmount.Width = 150
        '
        'FrmTravelTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(955, 602)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "FrmTravelTicket"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.TabPageRequest.ResumeLayout(False)
        CType(Me.GridRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CStatusTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTicket.ResumeLayout(False)
        CType(Me.GridTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabPageRequest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridRequest As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewRequest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeptID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Purpose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TravelType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Destination As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Negara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Visa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartureDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArrivalDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPageTicket As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridTicket As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTicket As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoVoucher As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vendor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoInvoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CStatusTicket As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoPaspor As DevExpress.XtraGrid.Columns.GridColumn
End Class
