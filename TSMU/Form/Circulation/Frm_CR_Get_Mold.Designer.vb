<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CR_Get_Mold
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
        Me.C_Qty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.C_Price = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.C_Amount_Barang = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Badd = New System.Windows.Forms.Button()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NameOfGoods = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Spesification = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Check = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PAmoutIDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C_Model = New DevExpress.XtraEditors.LookUpEdit()
        Me.C_NPWO = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.C_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Amount_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Model.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_NPWO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C_Qty
        '
        Me.C_Qty.Appearance.Options.UseTextOptions = True
        Me.C_Qty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.C_Qty.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.C_Qty.AutoHeight = False
        Me.C_Qty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.C_Qty.Name = "C_Qty"
        '
        'C_Price
        '
        Me.C_Price.Appearance.Options.UseTextOptions = True
        Me.C_Price.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.C_Price.AutoHeight = False
        Me.C_Price.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.C_Price.Name = "C_Price"
        '
        'C_Amount_Barang
        '
        Me.C_Amount_Barang.AutoHeight = False
        Me.C_Amount_Barang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.C_Amount_Barang.Name = "C_Amount_Barang"
        '
        'Badd
        '
        Me.Badd.Location = New System.Drawing.Point(12, 12)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(75, 23)
        Me.Badd.TabIndex = 10
        Me.Badd.Text = "Add"
        Me.Badd.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(12, 41)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(966, 273)
        Me.Grid.TabIndex = 11
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NameOfGoods, Me.Spesification, Me.Qty, Me.Price, Me.PTotal, Me.Check, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.PAmoutIDR, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'NameOfGoods
        '
        Me.NameOfGoods.FieldName = "Name Of Goods"
        Me.NameOfGoods.Name = "NameOfGoods"
        Me.NameOfGoods.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name Of Goods", "{0:N0}")})
        Me.NameOfGoods.Visible = True
        Me.NameOfGoods.VisibleIndex = 3
        Me.NameOfGoods.Width = 269
        '
        'Spesification
        '
        Me.Spesification.FieldName = "Spesification"
        Me.Spesification.Name = "Spesification"
        Me.Spesification.Visible = True
        Me.Spesification.VisibleIndex = 4
        Me.Spesification.Width = 342
        '
        'Qty
        '
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Qty.Caption = "Qty"
        Me.Qty.ColumnEdit = Me.C_Qty
        Me.Qty.DisplayFormat.FormatString = "c2"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'Price
        '
        Me.Price.AppearanceHeader.Options.UseTextOptions = True
        Me.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price.Caption = "Price"
        Me.Price.ColumnEdit = Me.C_Price
        Me.Price.DisplayFormat.FormatString = "{0:N2}"
        Me.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price.FieldName = "Price"
        Me.Price.Name = "Price"
        Me.Price.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.Price.Width = 96
        '
        'PTotal
        '
        Me.PTotal.ColumnEdit = Me.C_Amount_Barang
        Me.PTotal.DisplayFormat.FormatString = "{0:N2}"
        Me.PTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PTotal.FieldName = "Total Amount Currency"
        Me.PTotal.Name = "PTotal"
        Me.PTotal.OptionsColumn.AllowEdit = False
        Me.PTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:N2}")})
        Me.PTotal.Width = 121
        '
        'Check
        '
        Me.Check.FieldName = "Check"
        Me.Check.Name = "Check"
        Me.Check.Visible = True
        Me.Check.VisibleIndex = 5
        Me.Check.Width = 55
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Curr"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Rate"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Balance"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "Category"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'PAmoutIDR
        '
        Me.PAmoutIDR.FieldName = "Total IDR"
        Me.PAmoutIDR.Name = "PAmoutIDR"
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "NoUrut"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Model"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 90
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "Customer"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 87
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "NPWO"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 227
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "By Npwo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "By Model"
        '
        'C_Model
        '
        Me.C_Model.Location = New System.Drawing.Point(506, 14)
        Me.C_Model.Name = "C_Model"
        Me.C_Model.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.C_Model.Properties.DropDownRows = 10
        Me.C_Model.Properties.NullText = ""
        Me.C_Model.Properties.PopupSizeable = False
        Me.C_Model.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.C_Model.Size = New System.Drawing.Size(130, 20)
        Me.C_Model.TabIndex = 13
        '
        'C_NPWO
        '
        Me.C_NPWO.Location = New System.Drawing.Point(188, 14)
        Me.C_NPWO.Name = "C_NPWO"
        Me.C_NPWO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.C_NPWO.Properties.DropDownRows = 10
        Me.C_NPWO.Properties.NullText = ""
        Me.C_NPWO.Properties.PopupSizeable = False
        Me.C_NPWO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.C_NPWO.Size = New System.Drawing.Size(224, 20)
        Me.C_NPWO.TabIndex = 12
        '
        'Frm_CR_Get_Mold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 326)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.C_Model)
        Me.Controls.Add(Me.C_NPWO)
        Me.Name = "Frm_CR_Get_Mold"
        Me.Text = "Circulation Get Mold"
        CType(Me.C_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Amount_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Model.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_NPWO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Badd As Button
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NameOfGoods As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Spesification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Qty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents C_Price As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents C_Amount_Barang As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PAmoutIDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents C_Model As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents C_NPWO As DevExpress.XtraEditors.LookUpEdit
End Class
