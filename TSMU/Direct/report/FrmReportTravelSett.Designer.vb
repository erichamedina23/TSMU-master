<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportTravelSett
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtTravelSettleID = New DevExpress.XtraEditors.TextEdit()
        Me.txtPersonInCharge = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtTravelSettleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersonInCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1055, 600)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'txtTravelSettleID
        '
        Me.txtTravelSettleID.Location = New System.Drawing.Point(493, 12)
        Me.txtTravelSettleID.Name = "txtTravelSettleID"
        Me.txtTravelSettleID.Size = New System.Drawing.Size(125, 22)
        Me.txtTravelSettleID.TabIndex = 2
        Me.txtTravelSettleID.Visible = False
        '
        'txtPersonInCharge
        '
        Me.txtPersonInCharge.Location = New System.Drawing.Point(642, 13)
        Me.txtPersonInCharge.Name = "txtPersonInCharge"
        Me.txtPersonInCharge.Size = New System.Drawing.Size(125, 22)
        Me.txtPersonInCharge.TabIndex = 3
        Me.txtPersonInCharge.Visible = False
        '
        'FrmReportTravelSett
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 600)
        Me.Controls.Add(Me.txtPersonInCharge)
        Me.Controls.Add(Me.txtTravelSettleID)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmReportTravelSett"
        Me.Text = "FrmReportTravelSett"
        CType(Me.txtTravelSettleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersonInCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtTravelSettleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPersonInCharge As DevExpress.XtraEditors.TextEdit
End Class
