<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBankReconsal
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me._txtcuryid = New DevExpress.XtraEditors.TextEdit()
        Me._txtaccountname = New DevExpress.XtraEditors.TextEdit()
        Me._txtsaldo = New DevExpress.XtraEditors.TextEdit()
        Me._txtperpost = New DevExpress.XtraEditors.TextEdit()
        Me._txtaccount = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.EditRek = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.vtxtmasuk = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.vtxtkeluar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._txtcuryid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txtaccountname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txtsaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txtperpost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txtaccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditRek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vtxtmasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vtxtkeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._txtcuryid)
        Me.LayoutControl1.Controls.Add(Me._txtaccountname)
        Me.LayoutControl1.Controls.Add(Me._txtsaldo)
        Me.LayoutControl1.Controls.Add(Me._txtperpost)
        Me.LayoutControl1.Controls.Add(Me._txtaccount)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(716, 0, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(918, 61)
        Me.LayoutControl1.TabIndex = 9
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_txtcuryid
        '
        Me._txtcuryid.Location = New System.Drawing.Point(605, 12)
        Me._txtcuryid.Name = "_txtcuryid"
        Me._txtcuryid.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me._txtcuryid.Properties.Appearance.Options.UseBackColor = True
        Me._txtcuryid.Size = New System.Drawing.Size(64, 20)
        Me._txtcuryid.StyleController = Me.LayoutControl1
        Me._txtcuryid.TabIndex = 4
        '
        '_txtaccountname
        '
        Me._txtaccountname.Location = New System.Drawing.Point(323, 12)
        Me._txtaccountname.Name = "_txtaccountname"
        Me._txtaccountname.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me._txtaccountname.Properties.Appearance.Options.UseBackColor = True
        Me._txtaccountname.Size = New System.Drawing.Size(278, 20)
        Me._txtaccountname.StyleController = Me.LayoutControl1
        Me._txtaccountname.TabIndex = 3
        '
        '_txtsaldo
        '
        Me._txtsaldo.Location = New System.Drawing.Point(762, 12)
        Me._txtsaldo.Name = "_txtsaldo"
        Me._txtsaldo.Properties.Appearance.Options.UseTextOptions = True
        Me._txtsaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._txtsaldo.Properties.ReadOnly = True
        Me._txtsaldo.Size = New System.Drawing.Size(144, 20)
        Me._txtsaldo.StyleController = Me.LayoutControl1
        Me._txtsaldo.TabIndex = 5
        '
        '_txtperpost
        '
        Me._txtperpost.Location = New System.Drawing.Point(101, 12)
        Me._txtperpost.Name = "_txtperpost"
        Me._txtperpost.Size = New System.Drawing.Size(50, 20)
        Me._txtperpost.StyleController = Me.LayoutControl1
        Me._txtperpost.TabIndex = 0
        '
        '_txtaccount
        '
        Me._txtaccount.Location = New System.Drawing.Point(244, 12)
        Me._txtaccount.Name = "_txtaccount"
        Me._txtaccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me._txtaccount.Size = New System.Drawing.Size(75, 20)
        Me._txtaccount.StyleController = Me.LayoutControl1
        Me._txtaccount.TabIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem11, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(918, 61)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._txtperpost
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(143, 24)
        Me.LayoutControlItem1.Text = "PerPost"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(86, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(898, 17)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._txtaccount
        Me.LayoutControlItem2.Location = New System.Drawing.Point(143, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(168, 24)
        Me.LayoutControlItem2.Text = "Rekening"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._txtsaldo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(661, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem3.Text = "Beginning Balance"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me._txtaccountname
        Me.LayoutControlItem11.Enabled = False
        Me.LayoutControlItem11.Location = New System.Drawing.Point(311, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(282, 24)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._txtcuryid
        Me.LayoutControlItem4.Enabled = False
        Me.LayoutControlItem4.Location = New System.Drawing.Point(593, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(68, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'EditRek
        '
        Me.EditRek.AutoHeight = False
        Me.EditRek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EditRek.Name = "EditRek"
        '
        'vtxtmasuk
        '
        Me.vtxtmasuk.AutoHeight = False
        Me.vtxtmasuk.Name = "vtxtmasuk"
        '
        'vtxtkeluar
        '
        Me.vtxtkeluar.AutoHeight = False
        Me.vtxtkeluar.Name = "vtxtkeluar"
        '
        'cek
        '
        Me.cek.AutoHeight = False
        Me.cek.Name = "cek"
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit6
        '
        Me.RepositoryItemCheckEdit6.AutoHeight = False
        Me.RepositoryItemCheckEdit6.Name = "RepositoryItemCheckEdit6"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn3, Me.GridColumn43, Me.GridColumn41, Me.GridColumn40, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.ID, Me.GridColumn44, Me.GridColumn57, Me.GridColumn58})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Date"
        Me.GridColumn1.FieldName = "Tgl"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 70
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Voucher No."
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemButtonEdit2
        Me.GridColumn2.FieldName = "NoBukti"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 88
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Description"
        Me.GridColumn4.FieldName = "Keterangan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 275
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Transaction"
        Me.GridColumn3.FieldName = "Transaksi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 71
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Ref No"
        Me.GridColumn43.FieldName = "Noref"
        Me.GridColumn43.Name = "GridColumn43"
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Advance"
        Me.GridColumn41.FieldName = "SuspendAmount"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.OptionsColumn.AllowEdit = False
        Me.GridColumn41.Width = 65
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Settlement"
        Me.GridColumn40.FieldName = "SettleAmount"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsColumn.AllowEdit = False
        Me.GridColumn40.Width = 77
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Debit"
        Me.GridColumn5.ColumnEdit = Me.vtxtmasuk
        Me.GridColumn5.FieldName = "Masuk"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 89
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Credit"
        Me.GridColumn6.ColumnEdit = Me.vtxtkeluar
        Me.GridColumn6.FieldName = "Keluar"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 72
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Balance"
        Me.GridColumn7.FieldName = "Saldo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'ID
        '
        Me.ID.Caption = "GridColumn46"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "Edit"
        Me.GridColumn44.ColumnEdit = Me.EditRek
        Me.GridColumn44.FieldName = "AcctID"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Width = 46
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "Check"
        Me.GridColumn57.ColumnEdit = Me.RepositoryItemCheckEdit5
        Me.GridColumn57.FieldName = "cek"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.Width = 42
        '
        'GridColumn58
        '
        Me.GridColumn58.Caption = "Reconciliation"
        Me.GridColumn58.ColumnEdit = Me.RepositoryItemCheckEdit6
        Me.GridColumn58.FieldName = "recon"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 7
        Me.GridColumn58.Width = 82
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 92)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit2, Me.EditRek, Me.vtxtmasuk, Me.vtxtkeluar, Me.cek, Me.RepositoryItemCheckEdit5, Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit6})
        Me.GridControl1.Size = New System.Drawing.Size(1154, 423)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'FrmBankReconsal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1178, 740)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmBankReconsal"
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._txtcuryid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txtaccountname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txtsaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txtperpost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txtaccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditRek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vtxtmasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vtxtkeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents _txtcuryid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _txtaccountname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _txtsaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _txtperpost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _txtaccount As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents EditRek As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents vtxtmasuk As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents vtxtkeluar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
End Class
