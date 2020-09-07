<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReport_BoM_Forecast_PO
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
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.colAccount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProses = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColInvtId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOJan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOFeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOMar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOApr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOMei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOJun = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOJul = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOAgt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOSep = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPOOkt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPONov = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColPODes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFJan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFFeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFMar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFApr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFMei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFJun = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFJul = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFAgt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFSep = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFOkt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFNov = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColFDes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColQtyAktualDes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOJan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOFeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOMar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOApr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOMei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOJun = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOJul = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOAgt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOSep = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPOOkt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPONov = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotPODes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFJan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFFeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFMar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFApr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFMei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFJun = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFJul = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFAgt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFSep = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFOkt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFNov = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotFDes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColTotAktualSales = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtPerost = New DevExpress.XtraEditors.TextEdit()
        Me._txtTahun = New DevExpress.XtraEditors.TextEdit()
        Me.txtInvtId = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtPerost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid.Location = New System.Drawing.Point(0, 175)
        Me.Grid.MainView = Me.AdvBandedGridView1
        Me.Grid.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1104, 585)
        Me.Grid.TabIndex = 1
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand5, Me.gridBand4, Me.gridBand1, Me.gridBand2, Me.gridBand7, Me.gridBand3, Me.gridBand6, Me.gridBand8})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colAccount, Me.colProses, Me.ColLevel, Me.ColInvtId, Me.ColDescription, Me.ColUnit, Me.ColQty, Me.ColPOJan, Me.ColPOFeb, Me.ColPOMar, Me.ColPOApr, Me.ColPOMei, Me.ColPOJun, Me.ColPOJul, Me.ColPOAgt, Me.ColPOSep, Me.ColPOOkt, Me.ColPONov, Me.ColPODes, Me.ColFJan, Me.ColFFeb, Me.ColFMar, Me.ColFApr, Me.ColFMei, Me.ColFJun, Me.ColFJul, Me.ColFAgt, Me.ColFSep, Me.ColFOkt, Me.ColFNov, Me.ColFDes, Me.ColQtyAktualDes, Me.ColTotPOJan, Me.ColTotPOFeb, Me.ColTotPOMar, Me.ColTotPOApr, Me.ColTotPOMei, Me.ColTotPOJun, Me.ColTotPOJul, Me.ColTotPOAgt, Me.ColTotPOSep, Me.ColTotPOOkt, Me.ColTotPONov, Me.ColTotPODes, Me.ColTotFJan, Me.ColTotFFeb, Me.ColTotFMar, Me.ColTotFApr, Me.ColTotFMei, Me.ColTotFJun, Me.ColTotFJul, Me.ColTotFAgt, Me.ColTotFSep, Me.ColTotFOkt, Me.ColTotFNov, Me.ColTotFDes, Me.ColTotAktualSales})
        Me.AdvBandedGridView1.DetailHeight = 458
        Me.AdvBandedGridView1.FixedLineWidth = 3
        Me.AdvBandedGridView1.GridControl = Me.Grid
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsCustomization.AllowFilter = False
        Me.AdvBandedGridView1.OptionsCustomization.AllowSort = False
        Me.AdvBandedGridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.AdvBandedGridView1.OptionsPrint.AllowMultilineHeaders = True
        Me.AdvBandedGridView1.OptionsPrint.PrintHorzLines = False
        Me.AdvBandedGridView1.OptionsPrint.PrintVertLines = False
        Me.AdvBandedGridView1.OptionsPrint.UsePrintStyles = False
        Me.AdvBandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.AdvBandedGridView1.OptionsView.ShowFooter = True
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'colAccount
        '
        Me.colAccount.Caption = "Account"
        Me.colAccount.FieldName = "Account"
        Me.colAccount.MinWidth = 25
        Me.colAccount.Name = "colAccount"
        Me.colAccount.Visible = True
        Me.colAccount.Width = 94
        '
        'colProses
        '
        Me.colProses.Caption = "Proses"
        Me.colProses.FieldName = "Proses"
        Me.colProses.MinWidth = 25
        Me.colProses.Name = "colProses"
        Me.colProses.Visible = True
        Me.colProses.Width = 94
        '
        'ColLevel
        '
        Me.ColLevel.Caption = "Level"
        Me.ColLevel.FieldName = "Level"
        Me.ColLevel.MinWidth = 27
        Me.ColLevel.Name = "ColLevel"
        Me.ColLevel.Visible = True
        Me.ColLevel.Width = 100
        '
        'ColInvtId
        '
        Me.ColInvtId.Caption = "Inventory ID"
        Me.ColInvtId.FieldName = "InvtID"
        Me.ColInvtId.MinWidth = 27
        Me.ColInvtId.Name = "ColInvtId"
        Me.ColInvtId.Visible = True
        Me.ColInvtId.Width = 100
        '
        'ColDescription
        '
        Me.ColDescription.Caption = "Description"
        Me.ColDescription.FieldName = "Description"
        Me.ColDescription.MinWidth = 27
        Me.ColDescription.Name = "ColDescription"
        Me.ColDescription.Visible = True
        Me.ColDescription.Width = 100
        '
        'ColUnit
        '
        Me.ColUnit.Caption = "Unit"
        Me.ColUnit.FieldName = "Unit"
        Me.ColUnit.MinWidth = 27
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.Visible = True
        Me.ColUnit.Width = 100
        '
        'ColQty
        '
        Me.ColQty.Caption = "Kons. Material"
        Me.ColQty.DisplayFormat.FormatString = "#,##0.#00000"
        Me.ColQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColQty.FieldName = "Qty"
        Me.ColQty.MinWidth = 27
        Me.ColQty.Name = "ColQty"
        Me.ColQty.Visible = True
        Me.ColQty.Width = 100
        '
        'ColPOJan
        '
        Me.ColPOJan.Caption = "Jan"
        Me.ColPOJan.FieldName = "POJan"
        Me.ColPOJan.MinWidth = 27
        Me.ColPOJan.Name = "ColPOJan"
        Me.ColPOJan.Visible = True
        Me.ColPOJan.Width = 96
        '
        'ColPOFeb
        '
        Me.ColPOFeb.Caption = "Feb"
        Me.ColPOFeb.FieldName = "POFeb"
        Me.ColPOFeb.MinWidth = 27
        Me.ColPOFeb.Name = "ColPOFeb"
        Me.ColPOFeb.Visible = True
        Me.ColPOFeb.Width = 96
        '
        'ColPOMar
        '
        Me.ColPOMar.Caption = "Mar"
        Me.ColPOMar.FieldName = "POMar"
        Me.ColPOMar.MinWidth = 27
        Me.ColPOMar.Name = "ColPOMar"
        Me.ColPOMar.Visible = True
        Me.ColPOMar.Width = 96
        '
        'ColPOApr
        '
        Me.ColPOApr.Caption = "Apr"
        Me.ColPOApr.FieldName = "POApr"
        Me.ColPOApr.MinWidth = 27
        Me.ColPOApr.Name = "ColPOApr"
        Me.ColPOApr.Visible = True
        Me.ColPOApr.Width = 96
        '
        'ColPOMei
        '
        Me.ColPOMei.Caption = "Mei"
        Me.ColPOMei.FieldName = "POMei"
        Me.ColPOMei.MinWidth = 27
        Me.ColPOMei.Name = "ColPOMei"
        Me.ColPOMei.Visible = True
        Me.ColPOMei.Width = 96
        '
        'ColPOJun
        '
        Me.ColPOJun.Caption = "Jun"
        Me.ColPOJun.FieldName = "POJun"
        Me.ColPOJun.MinWidth = 27
        Me.ColPOJun.Name = "ColPOJun"
        Me.ColPOJun.Visible = True
        Me.ColPOJun.Width = 96
        '
        'ColPOJul
        '
        Me.ColPOJul.Caption = "Jul"
        Me.ColPOJul.FieldName = "POJul"
        Me.ColPOJul.MinWidth = 27
        Me.ColPOJul.Name = "ColPOJul"
        Me.ColPOJul.Visible = True
        Me.ColPOJul.Width = 96
        '
        'ColPOAgt
        '
        Me.ColPOAgt.Caption = "Agt"
        Me.ColPOAgt.FieldName = "POAgt"
        Me.ColPOAgt.MinWidth = 27
        Me.ColPOAgt.Name = "ColPOAgt"
        Me.ColPOAgt.Visible = True
        Me.ColPOAgt.Width = 96
        '
        'ColPOSep
        '
        Me.ColPOSep.Caption = "Sep"
        Me.ColPOSep.FieldName = "POSep"
        Me.ColPOSep.MinWidth = 27
        Me.ColPOSep.Name = "ColPOSep"
        Me.ColPOSep.Visible = True
        Me.ColPOSep.Width = 96
        '
        'ColPOOkt
        '
        Me.ColPOOkt.Caption = "Okt"
        Me.ColPOOkt.FieldName = "POOkt"
        Me.ColPOOkt.MinWidth = 27
        Me.ColPOOkt.Name = "ColPOOkt"
        Me.ColPOOkt.Visible = True
        Me.ColPOOkt.Width = 96
        '
        'ColPONov
        '
        Me.ColPONov.Caption = "Nov"
        Me.ColPONov.FieldName = "PONov"
        Me.ColPONov.MinWidth = 27
        Me.ColPONov.Name = "ColPONov"
        Me.ColPONov.Visible = True
        Me.ColPONov.Width = 96
        '
        'ColPODes
        '
        Me.ColPODes.Caption = "Des"
        Me.ColPODes.FieldName = "PODes"
        Me.ColPODes.MinWidth = 27
        Me.ColPODes.Name = "ColPODes"
        Me.ColPODes.Visible = True
        Me.ColPODes.Width = 99
        '
        'ColFJan
        '
        Me.ColFJan.Caption = "Jan"
        Me.ColFJan.FieldName = "FJan"
        Me.ColFJan.MinWidth = 27
        Me.ColFJan.Name = "ColFJan"
        Me.ColFJan.Visible = True
        Me.ColFJan.Width = 87
        '
        'ColFFeb
        '
        Me.ColFFeb.Caption = "Feb"
        Me.ColFFeb.FieldName = "FFeb"
        Me.ColFFeb.MinWidth = 27
        Me.ColFFeb.Name = "ColFFeb"
        Me.ColFFeb.Visible = True
        Me.ColFFeb.Width = 87
        '
        'ColFMar
        '
        Me.ColFMar.Caption = "Mar"
        Me.ColFMar.FieldName = "FMar"
        Me.ColFMar.MinWidth = 27
        Me.ColFMar.Name = "ColFMar"
        Me.ColFMar.Visible = True
        Me.ColFMar.Width = 87
        '
        'ColFApr
        '
        Me.ColFApr.Caption = "Apr"
        Me.ColFApr.FieldName = "FApr"
        Me.ColFApr.MinWidth = 27
        Me.ColFApr.Name = "ColFApr"
        Me.ColFApr.Visible = True
        Me.ColFApr.Width = 87
        '
        'ColFMei
        '
        Me.ColFMei.Caption = "Mei"
        Me.ColFMei.FieldName = "FMei"
        Me.ColFMei.MinWidth = 27
        Me.ColFMei.Name = "ColFMei"
        Me.ColFMei.Visible = True
        Me.ColFMei.Width = 87
        '
        'ColFJun
        '
        Me.ColFJun.Caption = "Jun"
        Me.ColFJun.FieldName = "FJun"
        Me.ColFJun.MinWidth = 27
        Me.ColFJun.Name = "ColFJun"
        Me.ColFJun.Visible = True
        Me.ColFJun.Width = 87
        '
        'ColFJul
        '
        Me.ColFJul.Caption = "Jul"
        Me.ColFJul.FieldName = "FJul"
        Me.ColFJul.MinWidth = 27
        Me.ColFJul.Name = "ColFJul"
        Me.ColFJul.Visible = True
        Me.ColFJul.Width = 87
        '
        'ColFAgt
        '
        Me.ColFAgt.Caption = "Agt"
        Me.ColFAgt.FieldName = "FAgt"
        Me.ColFAgt.MinWidth = 27
        Me.ColFAgt.Name = "ColFAgt"
        Me.ColFAgt.Visible = True
        Me.ColFAgt.Width = 87
        '
        'ColFSep
        '
        Me.ColFSep.Caption = "Sep"
        Me.ColFSep.FieldName = "FSep"
        Me.ColFSep.MinWidth = 27
        Me.ColFSep.Name = "ColFSep"
        Me.ColFSep.Visible = True
        Me.ColFSep.Width = 87
        '
        'ColFOkt
        '
        Me.ColFOkt.Caption = "Okt"
        Me.ColFOkt.FieldName = "FOkt"
        Me.ColFOkt.MinWidth = 27
        Me.ColFOkt.Name = "ColFOkt"
        Me.ColFOkt.Visible = True
        Me.ColFOkt.Width = 87
        '
        'ColFNov
        '
        Me.ColFNov.Caption = "Nov"
        Me.ColFNov.FieldName = "FNov"
        Me.ColFNov.MinWidth = 27
        Me.ColFNov.Name = "ColFNov"
        Me.ColFNov.Visible = True
        Me.ColFNov.Width = 87
        '
        'ColFDes
        '
        Me.ColFDes.Caption = "Des"
        Me.ColFDes.FieldName = "FDes"
        Me.ColFDes.MinWidth = 27
        Me.ColFDes.Name = "ColFDes"
        Me.ColFDes.Visible = True
        Me.ColFDes.Width = 91
        '
        'ColQtyAktualDes
        '
        Me.ColQtyAktualDes.Caption = "Aktual Sales"
        Me.ColQtyAktualDes.FieldName = "AktSalesJan"
        Me.ColQtyAktualDes.MinWidth = 25
        Me.ColQtyAktualDes.Name = "ColQtyAktualDes"
        Me.ColQtyAktualDes.Visible = True
        Me.ColQtyAktualDes.Width = 150
        '
        'ColTotPOJan
        '
        Me.ColTotPOJan.Caption = "Jan"
        Me.ColTotPOJan.FieldName = "TotPOJan"
        Me.ColTotPOJan.MinWidth = 27
        Me.ColTotPOJan.Name = "ColTotPOJan"
        Me.ColTotPOJan.Visible = True
        Me.ColTotPOJan.Width = 82
        '
        'ColTotPOFeb
        '
        Me.ColTotPOFeb.Caption = "Feb"
        Me.ColTotPOFeb.FieldName = "TotPOFeb"
        Me.ColTotPOFeb.MinWidth = 27
        Me.ColTotPOFeb.Name = "ColTotPOFeb"
        Me.ColTotPOFeb.Visible = True
        Me.ColTotPOFeb.Width = 82
        '
        'ColTotPOMar
        '
        Me.ColTotPOMar.Caption = "Mar"
        Me.ColTotPOMar.FieldName = "TotPOMar"
        Me.ColTotPOMar.MinWidth = 27
        Me.ColTotPOMar.Name = "ColTotPOMar"
        Me.ColTotPOMar.Visible = True
        Me.ColTotPOMar.Width = 82
        '
        'ColTotPOApr
        '
        Me.ColTotPOApr.Caption = "Apr"
        Me.ColTotPOApr.FieldName = "TotPOApr"
        Me.ColTotPOApr.MinWidth = 27
        Me.ColTotPOApr.Name = "ColTotPOApr"
        Me.ColTotPOApr.Visible = True
        Me.ColTotPOApr.Width = 82
        '
        'ColTotPOMei
        '
        Me.ColTotPOMei.Caption = "Mei"
        Me.ColTotPOMei.FieldName = "TotPOMei"
        Me.ColTotPOMei.MinWidth = 27
        Me.ColTotPOMei.Name = "ColTotPOMei"
        Me.ColTotPOMei.Visible = True
        Me.ColTotPOMei.Width = 82
        '
        'ColTotPOJun
        '
        Me.ColTotPOJun.Caption = "Jun"
        Me.ColTotPOJun.FieldName = "TotPOJun"
        Me.ColTotPOJun.MinWidth = 27
        Me.ColTotPOJun.Name = "ColTotPOJun"
        Me.ColTotPOJun.Visible = True
        Me.ColTotPOJun.Width = 82
        '
        'ColTotPOJul
        '
        Me.ColTotPOJul.Caption = "Jul"
        Me.ColTotPOJul.FieldName = "TotPOJul"
        Me.ColTotPOJul.MinWidth = 27
        Me.ColTotPOJul.Name = "ColTotPOJul"
        Me.ColTotPOJul.Visible = True
        Me.ColTotPOJul.Width = 82
        '
        'ColTotPOAgt
        '
        Me.ColTotPOAgt.Caption = "Agt"
        Me.ColTotPOAgt.FieldName = "TotPOAgt"
        Me.ColTotPOAgt.MinWidth = 27
        Me.ColTotPOAgt.Name = "ColTotPOAgt"
        Me.ColTotPOAgt.Visible = True
        Me.ColTotPOAgt.Width = 82
        '
        'ColTotPOSep
        '
        Me.ColTotPOSep.Caption = "Sep"
        Me.ColTotPOSep.FieldName = "TotPOSep"
        Me.ColTotPOSep.MinWidth = 27
        Me.ColTotPOSep.Name = "ColTotPOSep"
        Me.ColTotPOSep.Visible = True
        Me.ColTotPOSep.Width = 82
        '
        'ColTotPOOkt
        '
        Me.ColTotPOOkt.Caption = "Okt"
        Me.ColTotPOOkt.FieldName = "TotPOOkt"
        Me.ColTotPOOkt.MinWidth = 27
        Me.ColTotPOOkt.Name = "ColTotPOOkt"
        Me.ColTotPOOkt.Visible = True
        Me.ColTotPOOkt.Width = 82
        '
        'ColTotPONov
        '
        Me.ColTotPONov.Caption = "Nov"
        Me.ColTotPONov.FieldName = "TotPONov"
        Me.ColTotPONov.MinWidth = 27
        Me.ColTotPONov.Name = "ColTotPONov"
        Me.ColTotPONov.Visible = True
        Me.ColTotPONov.Width = 82
        '
        'ColTotPODes
        '
        Me.ColTotPODes.Caption = "Des"
        Me.ColTotPODes.FieldName = "TotPODes"
        Me.ColTotPODes.MinWidth = 27
        Me.ColTotPODes.Name = "ColTotPODes"
        Me.ColTotPODes.Visible = True
        Me.ColTotPODes.Width = 82
        '
        'ColTotFJan
        '
        Me.ColTotFJan.Caption = "Jan"
        Me.ColTotFJan.FieldName = "TotFJan"
        Me.ColTotFJan.MinWidth = 27
        Me.ColTotFJan.Name = "ColTotFJan"
        Me.ColTotFJan.Visible = True
        Me.ColTotFJan.Width = 100
        '
        'ColTotFFeb
        '
        Me.ColTotFFeb.Caption = "Feb"
        Me.ColTotFFeb.FieldName = "TotFFeb"
        Me.ColTotFFeb.MinWidth = 27
        Me.ColTotFFeb.Name = "ColTotFFeb"
        Me.ColTotFFeb.Visible = True
        Me.ColTotFFeb.Width = 100
        '
        'ColTotFMar
        '
        Me.ColTotFMar.Caption = "Mar"
        Me.ColTotFMar.FieldName = "TotFMar"
        Me.ColTotFMar.MinWidth = 27
        Me.ColTotFMar.Name = "ColTotFMar"
        Me.ColTotFMar.Visible = True
        Me.ColTotFMar.Width = 100
        '
        'ColTotFApr
        '
        Me.ColTotFApr.Caption = "Apr"
        Me.ColTotFApr.FieldName = "TotFApr"
        Me.ColTotFApr.MinWidth = 27
        Me.ColTotFApr.Name = "ColTotFApr"
        Me.ColTotFApr.Visible = True
        Me.ColTotFApr.Width = 100
        '
        'ColTotFMei
        '
        Me.ColTotFMei.Caption = "Mei"
        Me.ColTotFMei.FieldName = "TotFMei"
        Me.ColTotFMei.MinWidth = 27
        Me.ColTotFMei.Name = "ColTotFMei"
        Me.ColTotFMei.Visible = True
        Me.ColTotFMei.Width = 100
        '
        'ColTotFJun
        '
        Me.ColTotFJun.Caption = "Jun"
        Me.ColTotFJun.FieldName = "TotFJun"
        Me.ColTotFJun.MinWidth = 27
        Me.ColTotFJun.Name = "ColTotFJun"
        Me.ColTotFJun.Visible = True
        Me.ColTotFJun.Width = 100
        '
        'ColTotFJul
        '
        Me.ColTotFJul.Caption = "Jul"
        Me.ColTotFJul.FieldName = "TotFJul"
        Me.ColTotFJul.MinWidth = 27
        Me.ColTotFJul.Name = "ColTotFJul"
        Me.ColTotFJul.Visible = True
        Me.ColTotFJul.Width = 100
        '
        'ColTotFAgt
        '
        Me.ColTotFAgt.Caption = "Agt"
        Me.ColTotFAgt.FieldName = "TotFAgt"
        Me.ColTotFAgt.MinWidth = 27
        Me.ColTotFAgt.Name = "ColTotFAgt"
        Me.ColTotFAgt.Visible = True
        Me.ColTotFAgt.Width = 100
        '
        'ColTotFSep
        '
        Me.ColTotFSep.Caption = "Sep"
        Me.ColTotFSep.FieldName = "TotFSep"
        Me.ColTotFSep.MinWidth = 27
        Me.ColTotFSep.Name = "ColTotFSep"
        Me.ColTotFSep.Visible = True
        Me.ColTotFSep.Width = 100
        '
        'ColTotFOkt
        '
        Me.ColTotFOkt.Caption = "Okt"
        Me.ColTotFOkt.FieldName = "TotFOkt"
        Me.ColTotFOkt.MinWidth = 27
        Me.ColTotFOkt.Name = "ColTotFOkt"
        Me.ColTotFOkt.Visible = True
        Me.ColTotFOkt.Width = 100
        '
        'ColTotFNov
        '
        Me.ColTotFNov.Caption = "Nov"
        Me.ColTotFNov.FieldName = "TotFNov"
        Me.ColTotFNov.MinWidth = 27
        Me.ColTotFNov.Name = "ColTotFNov"
        Me.ColTotFNov.Visible = True
        Me.ColTotFNov.Width = 100
        '
        'ColTotFDes
        '
        Me.ColTotFDes.Caption = "Des"
        Me.ColTotFDes.FieldName = "TotFDes"
        Me.ColTotFDes.MinWidth = 27
        Me.ColTotFDes.Name = "ColTotFDes"
        Me.ColTotFDes.Visible = True
        Me.ColTotFDes.Width = 100
        '
        'ColTotAktualSales
        '
        Me.ColTotAktualSales.Caption = "Total Aktual Sales"
        Me.ColTotAktualSales.FieldName = "TotAktSalesJan"
        Me.ColTotAktualSales.MinWidth = 25
        Me.ColTotAktualSales.Name = "ColTotAktualSales"
        Me.ColTotAktualSales.Visible = True
        Me.ColTotAktualSales.Width = 150
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1116, 140)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1109, 106)
        Me.XtraTabPage1.Text = "Filter By"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TxtPerost)
        Me.LayoutControl1.Controls.Add(Me._txtTahun)
        Me.LayoutControl1.Controls.Add(Me.txtInvtId)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1109, 106)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtPerost
        '
        Me.TxtPerost.Location = New System.Drawing.Point(88, 64)
        Me.TxtPerost.Name = "TxtPerost"
        Me.TxtPerost.Size = New System.Drawing.Size(151, 22)
        Me.TxtPerost.StyleController = Me.LayoutControl1
        Me.TxtPerost.TabIndex = 6
        '
        '_txtTahun
        '
        Me._txtTahun.Location = New System.Drawing.Point(88, 12)
        Me._txtTahun.Margin = New System.Windows.Forms.Padding(4)
        Me._txtTahun.Name = "_txtTahun"
        Me._txtTahun.Size = New System.Drawing.Size(151, 22)
        Me._txtTahun.StyleController = Me.LayoutControl1
        Me._txtTahun.TabIndex = 4
        '
        'txtInvtId
        '
        Me.txtInvtId.Location = New System.Drawing.Point(88, 38)
        Me.txtInvtId.Name = "txtInvtId"
        Me.txtInvtId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtInvtId.Size = New System.Drawing.Size(151, 22)
        Me.txtInvtId.StyleController = Me.LayoutControl1
        Me.txtInvtId.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1109, 106)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(231, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(858, 86)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._txtTahun
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem1.Text = "Tahun"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(73, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtInvtId
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem2.Text = "Invtentory ID"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(73, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtPerost
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(231, 34)
        Me.LayoutControlItem3.Text = "Perpost"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(73, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(802, 37)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'gridBand5
        '
        Me.gridBand5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gridBand5.MinWidth = 13
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.OptionsBand.ShowCaption = False
        Me.gridBand5.Visible = False
        Me.gridBand5.VisibleIndex = -1
        Me.gridBand5.Width = 100
        '
        'gridBand4
        '
        Me.gridBand4.Columns.Add(Me.colAccount)
        Me.gridBand4.Columns.Add(Me.colProses)
        Me.gridBand4.Columns.Add(Me.ColLevel)
        Me.gridBand4.Columns.Add(Me.ColInvtId)
        Me.gridBand4.Columns.Add(Me.ColDescription)
        Me.gridBand4.Columns.Add(Me.ColUnit)
        Me.gridBand4.Columns.Add(Me.ColQty)
        Me.gridBand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gridBand4.MinWidth = 13
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 0
        Me.gridBand4.Width = 688
        '
        'gridBand1
        '
        Me.gridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand1.AppearanceHeader.Options.UseFont = True
        Me.gridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand1.Caption = "Qty PO"
        Me.gridBand1.Columns.Add(Me.ColPOJan)
        Me.gridBand1.Columns.Add(Me.ColPOFeb)
        Me.gridBand1.Columns.Add(Me.ColPOMar)
        Me.gridBand1.Columns.Add(Me.ColPOApr)
        Me.gridBand1.Columns.Add(Me.ColPOMei)
        Me.gridBand1.Columns.Add(Me.ColPOJun)
        Me.gridBand1.Columns.Add(Me.ColPOJul)
        Me.gridBand1.Columns.Add(Me.ColPOAgt)
        Me.gridBand1.Columns.Add(Me.ColPOSep)
        Me.gridBand1.Columns.Add(Me.ColPOOkt)
        Me.gridBand1.Columns.Add(Me.ColPONov)
        Me.gridBand1.Columns.Add(Me.ColPODes)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.VisibleIndex = 1
        Me.gridBand1.Width = 1155
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Qty Forecast"
        Me.gridBand2.Columns.Add(Me.ColFJan)
        Me.gridBand2.Columns.Add(Me.ColFFeb)
        Me.gridBand2.Columns.Add(Me.ColFMar)
        Me.gridBand2.Columns.Add(Me.ColFApr)
        Me.gridBand2.Columns.Add(Me.ColFMei)
        Me.gridBand2.Columns.Add(Me.ColFJun)
        Me.gridBand2.Columns.Add(Me.ColFJul)
        Me.gridBand2.Columns.Add(Me.ColFAgt)
        Me.gridBand2.Columns.Add(Me.ColFSep)
        Me.gridBand2.Columns.Add(Me.ColFOkt)
        Me.gridBand2.Columns.Add(Me.ColFNov)
        Me.gridBand2.Columns.Add(Me.ColFDes)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 1048
        '
        'gridBand7
        '
        Me.gridBand7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand7.AppearanceHeader.Options.UseFont = True
        Me.gridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand7.Caption = "Qty Actual Sales"
        Me.gridBand7.Columns.Add(Me.ColQtyAktualDes)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 3
        Me.gridBand7.Width = 150
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand3.AppearanceHeader.Options.UseFont = True
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "Total Konsumsi PO"
        Me.gridBand3.Columns.Add(Me.ColTotPOJan)
        Me.gridBand3.Columns.Add(Me.ColTotPOFeb)
        Me.gridBand3.Columns.Add(Me.ColTotPOMar)
        Me.gridBand3.Columns.Add(Me.ColTotPOApr)
        Me.gridBand3.Columns.Add(Me.ColTotPOMei)
        Me.gridBand3.Columns.Add(Me.ColTotPOJun)
        Me.gridBand3.Columns.Add(Me.ColTotPOJul)
        Me.gridBand3.Columns.Add(Me.ColTotPOAgt)
        Me.gridBand3.Columns.Add(Me.ColTotPOSep)
        Me.gridBand3.Columns.Add(Me.ColTotPOOkt)
        Me.gridBand3.Columns.Add(Me.ColTotPONov)
        Me.gridBand3.Columns.Add(Me.ColTotPODes)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 4
        Me.gridBand3.Width = 984
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand6.AppearanceHeader.Options.UseFont = True
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.Caption = "Total Konsumsi Forecast"
        Me.gridBand6.Columns.Add(Me.ColTotFJan)
        Me.gridBand6.Columns.Add(Me.ColTotFFeb)
        Me.gridBand6.Columns.Add(Me.ColTotFMar)
        Me.gridBand6.Columns.Add(Me.ColTotFApr)
        Me.gridBand6.Columns.Add(Me.ColTotFMei)
        Me.gridBand6.Columns.Add(Me.ColTotFJun)
        Me.gridBand6.Columns.Add(Me.ColTotFJul)
        Me.gridBand6.Columns.Add(Me.ColTotFAgt)
        Me.gridBand6.Columns.Add(Me.ColTotFSep)
        Me.gridBand6.Columns.Add(Me.ColTotFOkt)
        Me.gridBand6.Columns.Add(Me.ColTotFNov)
        Me.gridBand6.Columns.Add(Me.ColTotFDes)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 5
        Me.gridBand6.Width = 1200
        '
        'gridBand8
        '
        Me.gridBand8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.gridBand8.AppearanceHeader.Options.UseFont = True
        Me.gridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand8.Caption = "Total Konsumsi Actual Sales"
        Me.gridBand8.Columns.Add(Me.ColTotAktualSales)
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.VisibleIndex = 6
        Me.gridBand8.Width = 150
        '
        'FrmReport_BoM_Forecast_PO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1104, 760)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmReport_BoM_Forecast_PO"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.Grid, 0)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtPerost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents ColLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColInvtId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOApr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOFeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOMar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOJan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOMei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOJun As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOJul As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOAgt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOSep As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPOOkt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPONov As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPODes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFJan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFFeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFMar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFApr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFMei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFJun As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFJul As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFAgt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFSep As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFOkt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFNov As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColFDes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOJan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOFeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOMar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOApr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOMei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOJun As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOJul As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOAgt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOSep As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPOOkt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPONov As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotPODes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFJan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFFeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFMar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFApr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFMei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFJun As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFJul As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFAgt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFSep As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFOkt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFNov As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotFDes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _txtTahun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtInvtId As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colAccount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProses As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColQtyAktualDes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColTotAktualSales As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TxtPerost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
