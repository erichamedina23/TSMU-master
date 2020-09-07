<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDRRAttach
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
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.GalleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GalleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GalleryControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GalleryControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.39855!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.601449!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1039, 552)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnBrowse)
        Me.PanelControl1.Controls.Add(Me.BtnSubmit)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(3, 502)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1033, 47)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrowse.Location = New System.Drawing.Point(816, 9)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(94, 29)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "Browse"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubmit.Location = New System.Drawing.Point(916, 9)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.BtnSubmit.TabIndex = 0
        Me.BtnSubmit.Text = "Ok"
        '
        'GalleryControl1
        '
        Me.GalleryControl1.Controls.Add(Me.GalleryControlClient1)
        Me.GalleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.GalleryControl1.Gallery.AllowHoverImages = True
        Me.GalleryControl1.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.ImageAndText
        GalleryItemGroup1.Caption = "Attach"
        Me.GalleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.GalleryControl1.Gallery.HoverImageSize = New System.Drawing.Size(750, 500)
        Me.GalleryControl1.Gallery.ImageSize = New System.Drawing.Size(150, 100)
        Me.GalleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
        Me.GalleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
        Me.GalleryControl1.Gallery.ShowItemText = True
        Me.GalleryControl1.Location = New System.Drawing.Point(3, 3)
        Me.GalleryControl1.Name = "GalleryControl1"
        Me.GalleryControl1.Size = New System.Drawing.Size(1033, 493)
        Me.GalleryControl1.TabIndex = 1
        Me.GalleryControl1.Text = "GalleryControl1"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.GalleryControl1
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(1008, 489)
        '
        'frmDRRAttach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmDRRAttach"
        Me.Text = "Attach Image"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GalleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GalleryControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GalleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents BtnSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBrowse As DevExpress.XtraEditors.SimpleButton
End Class
