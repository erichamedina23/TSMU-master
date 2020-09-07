<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTravelRequest
    Inherits TSMU.baseForm

    'Form overrides dispose to clean up the component list.
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
        Me.GridRequest = New DevExpress.XtraGrid.GridControl()
        Me.GridViewRequest = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridRequest
        '
        Me.GridRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRequest.Location = New System.Drawing.Point(15, 45)
        Me.GridRequest.MainView = Me.GridViewRequest
        Me.GridRequest.Name = "GridRequest"
        Me.GridRequest.Size = New System.Drawing.Size(1151, 495)
        Me.GridRequest.TabIndex = 2
        Me.GridRequest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewRequest})
        '
        'GridViewRequest
        '
        Me.GridViewRequest.GridControl = Me.GridRequest
        Me.GridViewRequest.Name = "GridViewRequest"
        Me.GridViewRequest.OptionsBehavior.Editable = False
        Me.GridViewRequest.OptionsView.ColumnAutoWidth = False
        Me.GridViewRequest.OptionsView.ShowAutoFilterRow = True
        Me.GridViewRequest.OptionsView.ShowGroupPanel = False
        '
        'FrmTravelRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1182, 552)
        Me.Controls.Add(Me.GridRequest)
        Me.Name = "FrmTravelRequest"
        Me.Controls.SetChildIndex(Me.GridRequest, 0)
        CType(Me.GridRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridRequest As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewRequest As DevExpress.XtraGrid.Views.Grid.GridView
End Class
