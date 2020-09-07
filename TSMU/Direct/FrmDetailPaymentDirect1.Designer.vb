<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetailPaymentDirect1
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnRefNo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnrptadv = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnrptsettle = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTotAmount2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrptadv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrptsettle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 28)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnRefNo, Me.btnrptadv, Me.btnrptsettle})
        Me.GridControl1.Size = New System.Drawing.Size(816, 312)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn43, Me.GridColumn41, Me.GridColumn40, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
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
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "NoBukti"
        Me.GridColumn2.FieldName = "NoBukti"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Transaksi"
        Me.GridColumn3.FieldName = "Transaksi"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Description"
        Me.GridColumn4.FieldName = "Keterangan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Ref No"
        Me.GridColumn43.ColumnEdit = Me.BtnRefNo
        Me.GridColumn43.FieldName = "Noref"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 1
        '
        'BtnRefNo
        '
        Me.BtnRefNo.AutoHeight = False
        Me.BtnRefNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BtnRefNo.Name = "BtnRefNo"
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Advance Amount"
        Me.GridColumn41.ColumnEdit = Me.btnrptadv
        Me.GridColumn41.FieldName = "SuspendAmount"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'btnrptadv
        '
        Me.btnrptadv.AutoHeight = False
        Me.btnrptadv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnrptadv.Name = "btnrptadv"
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Settle Amount"
        Me.GridColumn40.ColumnEdit = Me.btnrptsettle
        Me.GridColumn40.FieldName = "SettleAmount"
        Me.GridColumn40.Name = "GridColumn40"
        '
        'btnrptsettle
        '
        Me.btnrptsettle.AutoHeight = False
        Me.btnrptsettle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnrptsettle.Name = "btnrptsettle"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Masuk"
        Me.GridColumn5.FieldName = "Masuk"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "keluar"
        Me.GridColumn6.FieldName = "Keluar"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Amount"
        Me.GridColumn7.FieldName = "Amount"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'LblTotAmount2
        '
        Me.LblTotAmount2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotAmount2.AutoSize = True
        Me.LblTotAmount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotAmount2.Location = New System.Drawing.Point(796, 343)
        Me.LblTotAmount2.Name = "LblTotAmount2"
        Me.LblTotAmount2.Size = New System.Drawing.Size(16, 16)
        Me.LblTotAmount2.TabIndex = 13
        Me.LblTotAmount2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Settlement :"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Location = New System.Drawing.Point(47, 359)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(574, 52)
        Me.LayoutControl1.TabIndex = 14
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(574, 52)
        Me.Root.TextVisible = False
        '
        'FrmDetailPaymentDirect1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(828, 413)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.LblTotAmount2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FrmDetailPaymentDirect1"
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LblTotAmount2, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrptadv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrptsettle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnRefNo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTotAmount2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnrptadv As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnrptsettle As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
End Class
