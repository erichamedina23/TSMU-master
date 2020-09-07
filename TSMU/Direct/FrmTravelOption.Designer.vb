<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTravelOption
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
        Me.radioUSD = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTanya = New DevExpress.XtraEditors.LabelControl()
        Me.radioYEN = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'radioUSD
        '
        Me.radioUSD.AutoSize = True
        Me.radioUSD.Location = New System.Drawing.Point(25, 126)
        Me.radioUSD.Name = "radioUSD"
        Me.radioUSD.Size = New System.Drawing.Size(58, 21)
        Me.radioUSD.TabIndex = 0
        Me.radioUSD.TabStop = True
        Me.radioUSD.Text = "USD"
        Me.radioUSD.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(366, 32)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(366, 70)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTanya
        '
        Me.lblTanya.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTanya.Appearance.Options.UseFont = True
        Me.lblTanya.Location = New System.Drawing.Point(25, 32)
        Me.lblTanya.Name = "lblTanya"
        Me.lblTanya.Size = New System.Drawing.Size(58, 21)
        Me.lblTanya.TabIndex = 3
        Me.lblTanya.Text = "Tanya ?"
        '
        'radioYEN
        '
        Me.radioYEN.AutoSize = True
        Me.radioYEN.Location = New System.Drawing.Point(121, 126)
        Me.radioYEN.Name = "radioYEN"
        Me.radioYEN.Size = New System.Drawing.Size(57, 21)
        Me.radioYEN.TabIndex = 4
        Me.radioYEN.TabStop = True
        Me.radioYEN.Text = "YEN"
        Me.radioYEN.UseVisualStyleBackColor = True
        '
        'FrmTravelOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 163)
        Me.Controls.Add(Me.radioYEN)
        Me.Controls.Add(Me.lblTanya)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.radioUSD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTravelOption"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioUSD As RadioButton
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTanya As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radioYEN As RadioButton
End Class
