<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTravelPocketAllowanceDetail
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
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtCurryID = New DevExpress.XtraEditors.TextEdit()
        Me.txtGolongan = New DevExpress.XtraEditors.TextEdit()
        Me.txtTravelType = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGolongan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTravelType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(796, 52)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(286, 22)
        Me.txtAmount.TabIndex = 7
        '
        'txtCurryID
        '
        Me.txtCurryID.Location = New System.Drawing.Point(546, 52)
        Me.txtCurryID.Name = "txtCurryID"
        Me.txtCurryID.Size = New System.Drawing.Size(174, 22)
        Me.txtCurryID.TabIndex = 6
        '
        'txtGolongan
        '
        Me.txtGolongan.Location = New System.Drawing.Point(303, 52)
        Me.txtGolongan.Name = "txtGolongan"
        Me.txtGolongan.Size = New System.Drawing.Size(168, 22)
        Me.txtGolongan.TabIndex = 5
        '
        'txtTravelType
        '
        Me.txtTravelType.Location = New System.Drawing.Point(92, 52)
        Me.txtTravelType.Name = "txtTravelType"
        Me.txtTravelType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTravelType.Properties.Items.AddRange(New Object() {"DN", "LN"})
        Me.txtTravelType.Size = New System.Drawing.Size(153, 22)
        Me.txtTravelType.TabIndex = 4
        '
        'FrmTravelPocketAllowanceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1138, 566)
        Me.Controls.Add(Me.txtTravelType)
        Me.Controls.Add(Me.txtGolongan)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCurryID)
        Me.Name = "FrmTravelPocketAllowanceDetail"
        Me.Controls.SetChildIndex(Me.txtCurryID, 0)
        Me.Controls.SetChildIndex(Me.txtAmount, 0)
        Me.Controls.SetChildIndex(Me.txtGolongan, 0)
        Me.Controls.SetChildIndex(Me.txtTravelType, 0)
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGolongan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTravelType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCurryID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGolongan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTravelType As DevExpress.XtraEditors.ComboBoxEdit
End Class
