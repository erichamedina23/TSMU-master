<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdvanceSearch
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CmbStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TxtTglDari = New DevExpress.XtraEditors.DateEdit()
        Me.TxtTglSampai = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglDari.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglSampai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglSampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.47169!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5283!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(421, 189)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnOk)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(3, 145)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(415, 41)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Location = New System.Drawing.Point(309, 7)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(94, 29)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "OK"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CmbStatus)
        Me.LayoutControl1.Controls.Add(Me.TxtTglDari)
        Me.LayoutControl1.Controls.Add(Me.TxtTglSampai)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(415, 136)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CmbStatus
        '
        Me.CmbStatus.Location = New System.Drawing.Point(108, 64)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CmbStatus.Size = New System.Drawing.Size(295, 22)
        Me.CmbStatus.StyleController = Me.LayoutControl1
        Me.CmbStatus.TabIndex = 6
        '
        'TxtTglDari
        '
        Me.TxtTglDari.EditValue = Nothing
        Me.TxtTglDari.Location = New System.Drawing.Point(108, 12)
        Me.TxtTglDari.Name = "TxtTglDari"
        Me.TxtTglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglDari.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglDari.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglDari.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglDari.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TxtTglDari.Size = New System.Drawing.Size(295, 22)
        Me.TxtTglDari.StyleController = Me.LayoutControl1
        Me.TxtTglDari.TabIndex = 4
        '
        'TxtTglSampai
        '
        Me.TxtTglSampai.EditValue = Nothing
        Me.TxtTglSampai.Location = New System.Drawing.Point(108, 38)
        Me.TxtTglSampai.Name = "TxtTglSampai"
        Me.TxtTglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglSampai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglSampai.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglSampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglSampai.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglSampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglSampai.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TxtTglSampai.Size = New System.Drawing.Size(295, 22)
        Me.TxtTglSampai.StyleController = Me.LayoutControl1
        Me.TxtTglSampai.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(415, 136)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtTglDari
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(395, 26)
        Me.LayoutControlItem1.Text = "Tanggal Dari"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 78)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(395, 38)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtTglSampai
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(395, 26)
        Me.LayoutControlItem2.Text = "Tanggal Sampai"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CmbStatus
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(395, 26)
        Me.LayoutControlItem3.Text = "Status"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 16)
        '
        'frmAdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdvanceSearch"
        Me.Text = "Parameter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglDari.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglSampai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglSampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtTglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtTglSampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CmbStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
