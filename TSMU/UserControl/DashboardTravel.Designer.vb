<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardTravel
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DashboardViewer1.Appearance.Options.UseBackColor = True
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(3, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(717, 408)
        Me.DashboardViewer1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 408)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(170, 368)
        Me.Root.TextVisible = False
        '
        'DashboardTravel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DashboardViewer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "DashboardTravel"
        Me.Size = New System.Drawing.Size(720, 408)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
End Class
