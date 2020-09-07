Namespace Win_Dashboards
    Partial Public Class Dashboard_kanbanSum
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ComboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            Me.DashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.DashboardDS1 = New TSMU.DashboardDS()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ComboBoxDashboardItem1
            '
            Me.ComboBoxDashboardItem1.ComponentName = "ComboBoxDashboardItem1"
            Dimension1.DataMember = "Cycle"
            Dimension2.DataMember = "ShopCode"
            Me.ComboBoxDashboardItem1.DataItemRepository.Clear()
            Me.ComboBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ComboBoxDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.ComboBoxDashboardItem1.DataSource = Me.DashboardObjectDataSource1
            Me.ComboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1, Dimension2})
            Me.ComboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ComboBoxDashboardItem1.Name = "Cycle - Assy"
            Me.ComboBoxDashboardItem1.ShowCaption = True
            '
            'DashboardObjectDataSource1
            '
            Me.DashboardObjectDataSource1.ComponentName = "DashboardObjectDataSource1"
            Me.DashboardObjectDataSource1.DataMember = "DtKanbanSum"
            Me.DashboardObjectDataSource1.DataSource = Me.DashboardDS1
            Me.DashboardObjectDataSource1.Name = "Object Data Source 1"
            '
            'DashboardDS1
            '
            Me.DashboardDS1.DataSetName = "DashboardDS"
            Me.DashboardDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ChartDashboardItem1
            '
            Dimension3.DataMember = "Tanggal"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure1.DataMember = "Kanban"
            Measure2.DataMember = "Open"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.ChartDashboardItem1.DataSource = Me.DashboardObjectDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Bar Chart"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            SimpleSeries2.AddDataItem("Value", Measure2)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1, SimpleSeries2})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'Dashboard_kanbanSum
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.ComboBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ComboBoxDashboardItem1
            DashboardLayoutItem1.Weight = 13.184584178498986R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 86.81541582150102R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            Me.Title.Visible = False
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS1 As DashboardDS
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ComboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem

#End Region
    End Class
End Namespace