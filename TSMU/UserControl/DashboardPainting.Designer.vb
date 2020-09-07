<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardPainting
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TglFrom = New DevExpress.XtraEditors.DateEdit()
        Me.TglTo = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl1.SuspendLayout()
        Me.AccordionContentContainer1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TglFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DashboardViewer1.Appearance.Options.UseBackColor = True
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(194, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(526, 408)
        Me.DashboardViewer1.TabIndex = 0
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer1)
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 0)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.Size = New System.Drawing.Size(191, 408)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.Text = "AccordionControl1"
        '
        'AccordionContentContainer1
        '
        Me.AccordionContentContainer1.Controls.Add(Me.LayoutControl1)
        Me.AccordionContentContainer1.Name = "AccordionContentContainer1"
        Me.AccordionContentContainer1.Size = New System.Drawing.Size(170, 368)
        Me.AccordionContentContainer1.TabIndex = 1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TglFrom)
        Me.LayoutControl1.Controls.Add(Me.TglTo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(170, 368)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TglFrom
        '
        Me.TglFrom.EditValue = Nothing
        Me.TglFrom.Location = New System.Drawing.Point(45, 12)
        Me.TglFrom.Name = "TglFrom"
        Me.TglFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TglFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglFrom.Properties.EditFormat.FormatString = ""
        Me.TglFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglFrom.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TglFrom.Size = New System.Drawing.Size(113, 22)
        Me.TglFrom.StyleController = Me.LayoutControl1
        Me.TglFrom.TabIndex = 4
        '
        'TglTo
        '
        Me.TglTo.EditValue = Nothing
        Me.TglTo.Location = New System.Drawing.Point(45, 38)
        Me.TglTo.Name = "TglTo"
        Me.TglTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TglTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglTo.Properties.EditFormat.FormatString = ""
        Me.TglTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglTo.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TglTo.Size = New System.Drawing.Size(113, 22)
        Me.TglTo.StyleController = Me.LayoutControl1
        Me.TglTo.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(170, 368)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TglFrom
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem1.Text = "From"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(30, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 52)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(150, 296)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TglTo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem2.Text = "To"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(30, 16)
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.ContentContainer = Me.AccordionContentContainer1
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement1.Text = "Tanngal"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(191, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 408)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'DashboardEnginer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DashboardViewer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Name = "DashboardEnginer"
        Me.Size = New System.Drawing.Size(720, 408)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl1.ResumeLayout(False)
        Me.AccordionContentContainer1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TglFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TglFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TglTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Splitter1 As Splitter
End Class
