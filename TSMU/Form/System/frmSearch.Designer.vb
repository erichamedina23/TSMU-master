<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.TxtTglDari = New DevExpress.XtraEditors.DateEdit()
        Me.TxtTglSampai = New DevExpress.XtraEditors.DateEdit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglDari.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglSampai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglSampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LayoutControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.64286!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.35714!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(438, 186)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnOk)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(3, 132)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(432, 51)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Location = New System.Drawing.Point(326, 17)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(94, 29)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "OK"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtTglDari)
        Me.LayoutControl1.Controls.Add(Me.TxtTglSampai)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(432, 123)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.SimpleSeparator1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(432, 123)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtTglDari
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(412, 26)
        Me.LayoutControlItem1.Text = "Tanggal Dari"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 54)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(412, 49)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtTglSampai
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(412, 26)
        Me.LayoutControlItem2.Text = "Tanggal Sampai"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 16)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 26)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(412, 2)
        '
        'TxtTglDari
        '
        Me.TxtTglDari.EditValue = Nothing
        Me.TxtTglDari.Location = New System.Drawing.Point(109, 12)
        Me.TxtTglDari.Name = "TxtTglDari"
        Me.TxtTglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglDari.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglDari.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglDari.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglDari.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TxtTglDari.Size = New System.Drawing.Size(311, 22)
        Me.TxtTglDari.StyleController = Me.LayoutControl1
        Me.TxtTglDari.TabIndex = 4
        '
        'TxtTglSampai
        '
        Me.TxtTglSampai.EditValue = Nothing
        Me.TxtTglSampai.Location = New System.Drawing.Point(109, 40)
        Me.TxtTglSampai.Name = "TxtTglSampai"
        Me.TxtTglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglSampai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglSampai.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglSampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglSampai.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglSampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglSampai.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TxtTglSampai.Size = New System.Drawing.Size(311, 22)
        Me.TxtTglSampai.StyleController = Me.LayoutControl1
        Me.TxtTglSampai.TabIndex = 5
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.Text = "Parameter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglDari.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglSampai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglSampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents TxtTglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtTglSampai As DevExpress.XtraEditors.DateEdit
End Class
