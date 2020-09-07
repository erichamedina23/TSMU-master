<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTravelCreditCard
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
        Me.GridCreditCard = New DevExpress.XtraGrid.GridControl()
        Me.GridViewCreditCard = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridCreditCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCreditCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCreditCard
        '
        Me.GridCreditCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCreditCard.Location = New System.Drawing.Point(12, 40)
        Me.GridCreditCard.MainView = Me.GridViewCreditCard
        Me.GridCreditCard.Name = "GridCreditCard"
        Me.GridCreditCard.Size = New System.Drawing.Size(804, 529)
        Me.GridCreditCard.TabIndex = 1
        Me.GridCreditCard.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCreditCard})
        '
        'GridViewCreditCard
        '
        Me.GridViewCreditCard.GridControl = Me.GridCreditCard
        Me.GridViewCreditCard.Name = "GridViewCreditCard"
        Me.GridViewCreditCard.OptionsBehavior.Editable = False
        '
        'FrmTravelCreditCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(828, 581)
        Me.Controls.Add(Me.GridCreditCard)
        Me.Name = "FrmTravelCreditCard"
        Me.Controls.SetChildIndex(Me.GridCreditCard, 0)
        CType(Me.GridCreditCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCreditCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridCreditCard As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCreditCard As DevExpress.XtraGrid.Views.Grid.GridView
End Class
