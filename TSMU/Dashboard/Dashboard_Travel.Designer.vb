Namespace Win_Dashboards
    Partial Public Class Dashboard_Travel
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
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn2 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn3 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn4 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn5 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn6 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn7 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn8 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ComboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
            Me.DashboardObjectDataSource2 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.DashboardDS2 = New TSMU.DashboardDS()
            Me.GridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.DashboardDS1 = New TSMU.DashboardDS()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardObjectDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ComboBoxDashboardItem1
            '
            Me.ComboBoxDashboardItem1.ComponentName = "ComboBoxDashboardItem1"
            Dimension1.DataMember = "DeptID"
            Me.ComboBoxDashboardItem1.DataItemRepository.Clear()
            Me.ComboBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ComboBoxDashboardItem1.DataSource = Me.DashboardObjectDataSource2
            Me.ComboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ComboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ComboBoxDashboardItem1.Name = "Dept ID"
            Me.ComboBoxDashboardItem1.ShowCaption = True
            '
            'DashboardObjectDataSource2
            '
            Me.DashboardObjectDataSource2.ComponentName = "DashboardObjectDataSource2"
            Me.DashboardObjectDataSource2.DataMember = "dtTravel"
            Me.DashboardObjectDataSource2.DataSource = Me.DashboardDS2
            Me.DashboardObjectDataSource2.Name = "Object Data Source 1"
            '
            'DashboardDS2
            '
            Me.DashboardDS2.DataSetName = "DashboardDS"
            Me.DashboardDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridDashboardItem1
            '
            Dimension2.DataMember = "NIK"
            GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn1.AddDataItem("Dimension", Dimension2)
            Dimension3.DataMember = "Nama"
            Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            GridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn2.AddDataItem("Dimension", Dimension3)
            Dimension4.DataMember = "DeptID"
            GridDimensionColumn3.Name = "Dept ID"
            GridDimensionColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn3.AddDataItem("Dimension", Dimension4)
            Dimension5.DataMember = "Negara"
            GridDimensionColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn4.AddDataItem("Dimension", Dimension5)
            Dimension6.DataMember = "NoPaspor"
            GridDimensionColumn5.Name = "No Paspor"
            GridDimensionColumn5.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn5.AddDataItem("Dimension", Dimension6)
            Dimension7.DataMember = "NoVisa"
            GridDimensionColumn6.Name = "No Visa"
            GridDimensionColumn6.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn6.AddDataItem("Dimension", Dimension7)
            Dimension8.DataMember = "DepartureDate"
            GridDimensionColumn7.Name = "Departure Date"
            GridDimensionColumn7.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn7.AddDataItem("Dimension", Dimension8)
            Dimension9.DataMember = "ArrivalDate"
            GridDimensionColumn8.Name = "Arrival Date"
            GridDimensionColumn8.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn8.AddDataItem("Dimension", Dimension9)
            Me.GridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4, GridDimensionColumn5, GridDimensionColumn6, GridDimensionColumn7, GridDimensionColumn8})
            Me.GridDashboardItem1.ComponentName = "GridDashboardItem1"
            Me.GridDashboardItem1.DataItemRepository.Clear()
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem3")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem4")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem5")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem6")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem7")
            Me.GridDashboardItem1.DataSource = Me.DashboardObjectDataSource2
            Me.GridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.GridDashboardItem1.Name = "Request Paspor & Visa Traveler"
            Me.GridDashboardItem1.ShowCaption = True
            '
            'DashboardDS1
            '
            Me.DashboardDS1.DataSetName = "DashboardDS"
            Me.DashboardDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Dashboard_Travel
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.GridDashboardItem1, Me.ComboBoxDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ComboBoxDashboardItem1
            DashboardLayoutItem1.Weight = 50.0R
            DashboardLayoutItem2.DashboardItem = Me.GridDashboardItem1
            DashboardLayoutItem2.Weight = 50.0R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ComboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardObjectDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS1 As DashboardDS
        Friend WithEvents DashboardObjectDataSource2 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS2 As DashboardDS
        Friend WithEvents GridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents ComboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem

#End Region
    End Class
End Namespace