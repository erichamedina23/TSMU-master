<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTravelSettle
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabPageSett = New DevExpress.XtraTab.XtraTabPage()
        Me.GridSettle = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSettle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TravelSettleID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoPRGrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeptID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TravelerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Destination = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Purpose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Term = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPageReq = New DevExpress.XtraTab.XtraTabPage()
        Me.btnProses = New DevExpress.XtraEditors.SimpleButton()
        Me.GridRequest = New DevExpress.XtraGrid.GridControl()
        Me.GridViewRequest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoVoucher = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoRequest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TravelType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.TabPageSett.SuspendLayout()
        CType(Me.GridSettle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSettle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageReq.SuspendLayout()
        CType(Me.GridRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.TabPageSett
        Me.XtraTabControl1.Size = New System.Drawing.Size(955, 590)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPageReq, Me.TabPageSett})
        '
        'TabPageSett
        '
        Me.TabPageSett.Controls.Add(Me.GridSettle)
        Me.TabPageSett.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageSett.Name = "TabPageSett"
        Me.TabPageSett.Size = New System.Drawing.Size(948, 556)
        Me.TabPageSett.Text = "Settlement"
        '
        'GridSettle
        '
        Me.GridSettle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSettle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridSettle.Location = New System.Drawing.Point(4, 5)
        Me.GridSettle.MainView = Me.GridViewSettle
        Me.GridSettle.Margin = New System.Windows.Forms.Padding(4)
        Me.GridSettle.Name = "GridSettle"
        Me.GridSettle.Size = New System.Drawing.Size(939, 544)
        Me.GridSettle.TabIndex = 3
        Me.GridSettle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSettle})
        '
        'GridViewSettle
        '
        Me.GridViewSettle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TravelSettleID, Me.NoPRGrid, Me.DeptID, Me.TravelerName, Me.Destination, Me.Purpose, Me.Term, Me.Pay})
        Me.GridViewSettle.DetailHeight = 458
        Me.GridViewSettle.FixedLineWidth = 3
        Me.GridViewSettle.GridControl = Me.GridSettle
        Me.GridViewSettle.Name = "GridViewSettle"
        Me.GridViewSettle.OptionsBehavior.Editable = False
        Me.GridViewSettle.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSettle.OptionsView.ShowGroupPanel = False
        '
        'TravelSettleID
        '
        Me.TravelSettleID.Caption = "Settlement ID"
        Me.TravelSettleID.FieldName = "TravelSettleID"
        Me.TravelSettleID.MinWidth = 27
        Me.TravelSettleID.Name = "TravelSettleID"
        Me.TravelSettleID.OptionsColumn.FixedWidth = True
        Me.TravelSettleID.Visible = True
        Me.TravelSettleID.VisibleIndex = 0
        Me.TravelSettleID.Width = 130
        '
        'NoPRGrid
        '
        Me.NoPRGrid.Caption = "No PR"
        Me.NoPRGrid.FieldName = "NoPR"
        Me.NoPRGrid.MinWidth = 25
        Me.NoPRGrid.Name = "NoPRGrid"
        Me.NoPRGrid.OptionsColumn.FixedWidth = True
        Me.NoPRGrid.Visible = True
        Me.NoPRGrid.VisibleIndex = 1
        Me.NoPRGrid.Width = 130
        '
        'DeptID
        '
        Me.DeptID.Caption = "Dept ID"
        Me.DeptID.FieldName = "DeptID"
        Me.DeptID.MinWidth = 27
        Me.DeptID.Name = "DeptID"
        Me.DeptID.OptionsColumn.FixedWidth = True
        Me.DeptID.Visible = True
        Me.DeptID.VisibleIndex = 2
        Me.DeptID.Width = 100
        '
        'TravelerName
        '
        Me.TravelerName.Caption = "Name"
        Me.TravelerName.FieldName = "Nama"
        Me.TravelerName.MinWidth = 27
        Me.TravelerName.Name = "TravelerName"
        Me.TravelerName.OptionsColumn.FixedWidth = True
        Me.TravelerName.Visible = True
        Me.TravelerName.VisibleIndex = 3
        Me.TravelerName.Width = 500
        '
        'Destination
        '
        Me.Destination.Caption = "Destination"
        Me.Destination.FieldName = "Destination"
        Me.Destination.MinWidth = 27
        Me.Destination.Name = "Destination"
        Me.Destination.OptionsColumn.FixedWidth = True
        Me.Destination.Visible = True
        Me.Destination.VisibleIndex = 4
        Me.Destination.Width = 250
        '
        'Purpose
        '
        Me.Purpose.Caption = "Purpose"
        Me.Purpose.FieldName = "Purpose"
        Me.Purpose.MinWidth = 25
        Me.Purpose.Name = "Purpose"
        Me.Purpose.Visible = True
        Me.Purpose.VisibleIndex = 5
        Me.Purpose.Width = 25
        '
        'Term
        '
        Me.Term.Caption = "Term"
        Me.Term.FieldName = "Term"
        Me.Term.MinWidth = 25
        Me.Term.Name = "Term"
        Me.Term.OptionsColumn.FixedWidth = True
        Me.Term.Visible = True
        Me.Term.VisibleIndex = 6
        Me.Term.Width = 260
        '
        'Pay
        '
        Me.Pay.Caption = "Pay"
        Me.Pay.FieldName = "Pay"
        Me.Pay.MinWidth = 25
        Me.Pay.Name = "Pay"
        Me.Pay.Width = 94
        '
        'TabPageReq
        '
        Me.TabPageReq.Controls.Add(Me.btnProses)
        Me.TabPageReq.Controls.Add(Me.GridRequest)
        Me.TabPageReq.Name = "TabPageReq"
        Me.TabPageReq.Size = New System.Drawing.Size(948, 556)
        Me.TabPageReq.Text = "Request"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(4, 6)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(94, 29)
        Me.btnProses.TabIndex = 2
        Me.btnProses.Text = "PROSES"
        '
        'GridRequest
        '
        Me.GridRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRequest.Location = New System.Drawing.Point(4, 41)
        Me.GridRequest.MainView = Me.GridViewRequest
        Me.GridRequest.Name = "GridRequest"
        Me.GridRequest.Size = New System.Drawing.Size(930, 508)
        Me.GridRequest.TabIndex = 0
        Me.GridRequest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewRequest})
        '
        'GridViewRequest
        '
        Me.GridViewRequest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoVoucher, Me.NoRequest, Me.Nama, Me.GridColumn3, Me.TravelType, Me.GridColumn6, Me.GridColumn21, Me.GridColumn22, Me.GridColumn10, Me.GridColumn9, Me.GridColumn7, Me.GridColumn8})
        Me.GridViewRequest.GridControl = Me.GridRequest
        Me.GridViewRequest.Name = "GridViewRequest"
        Me.GridViewRequest.OptionsBehavior.Editable = False
        Me.GridViewRequest.OptionsSelection.MultiSelect = True
        Me.GridViewRequest.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridViewRequest.OptionsView.ShowGroupPanel = False
        '
        'NoVoucher
        '
        Me.NoVoucher.Caption = "No Voucher"
        Me.NoVoucher.FieldName = "NoVoucher"
        Me.NoVoucher.MinWidth = 25
        Me.NoVoucher.Name = "NoVoucher"
        Me.NoVoucher.OptionsColumn.FixedWidth = True
        Me.NoVoucher.Visible = True
        Me.NoVoucher.VisibleIndex = 1
        Me.NoVoucher.Width = 130
        '
        'NoRequest
        '
        Me.NoRequest.Caption = "No Request"
        Me.NoRequest.FieldName = "NoRequest"
        Me.NoRequest.MinWidth = 25
        Me.NoRequest.Name = "NoRequest"
        Me.NoRequest.OptionsColumn.FixedWidth = True
        Me.NoRequest.Visible = True
        Me.NoRequest.VisibleIndex = 2
        Me.NoRequest.Width = 130
        '
        'Nama
        '
        Me.Nama.Caption = "Name"
        Me.Nama.FieldName = "Nama"
        Me.Nama.MinWidth = 25
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.FixedWidth = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 3
        Me.Nama.Width = 200
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Dept ID"
        Me.GridColumn3.FieldName = "DeptID"
        Me.GridColumn3.MinWidth = 25
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 80
        '
        'TravelType
        '
        Me.TravelType.Caption = "Travel Type"
        Me.TravelType.FieldName = "TravelType"
        Me.TravelType.MinWidth = 25
        Me.TravelType.Name = "TravelType"
        Me.TravelType.OptionsColumn.FixedWidth = True
        Me.TravelType.Visible = True
        Me.TravelType.VisibleIndex = 5
        Me.TravelType.Width = 100
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Purpose"
        Me.GridColumn6.FieldName = "Purpose"
        Me.GridColumn6.MinWidth = 25
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 25
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Departure Date"
        Me.GridColumn21.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn21.FieldName = "DepartureDate"
        Me.GridColumn21.MinWidth = 25
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.FixedWidth = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 7
        Me.GridColumn21.Width = 120
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Arrival Date"
        Me.GridColumn22.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn22.FieldName = "ArrivalDate"
        Me.GridColumn22.MinWidth = 25
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.FixedWidth = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 8
        Me.GridColumn22.Width = 120
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Term"
        Me.GridColumn10.FieldName = "Term"
        Me.GridColumn10.MinWidth = 25
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.FixedWidth = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 260
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Advance IDR"
        Me.GridColumn9.DisplayFormat.FormatString = "n2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "AdvanceIDR"
        Me.GridColumn9.MinWidth = 25
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.FixedWidth = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 10
        Me.GridColumn9.Width = 130
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Advance USD"
        Me.GridColumn7.DisplayFormat.FormatString = "n2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "AdvanceUSD"
        Me.GridColumn7.MinWidth = 25
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 11
        Me.GridColumn7.Width = 130
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Advance YEN"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "AdvanceYEN"
        Me.GridColumn8.MinWidth = 25
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 12
        Me.GridColumn8.Width = 130
        '
        'FrmTravelSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(971, 631)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmTravelSettle"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.TabPageSett.ResumeLayout(False)
        CType(Me.GridSettle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSettle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageReq.ResumeLayout(False)
        CType(Me.GridRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabPageSett As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSettle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSettle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TravelSettleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeptID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Destination As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TravelerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPageReq As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridRequest As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewRequest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoRequest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TravelType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Purpose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Term As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnProses As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NoVoucher As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoPRGrid As DevExpress.XtraGrid.Columns.GridColumn
End Class
