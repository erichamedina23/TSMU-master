Namespace Win_Dashboards
    Partial Public Class Dashboard_TravelSum
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
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card1 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardStretchedLayoutTemplate1 As DevExpress.DashboardCommon.CardStretchedLayoutTemplate = New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Card2 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim CardStretchedLayoutTemplate2 As DevExpress.DashboardCommon.CardStretchedLayoutTemplate = New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.CardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.DashboardObjectDataSource6 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.DashboardDS6 = New TSMU.DashboardDS()
            Me.DashboardDS1 = New TSMU.DashboardDS()
            Me.DashboardDS2 = New TSMU.DashboardDS()
            Me.DashboardDS3 = New TSMU.DashboardDS()
            Me.DashboardDS4 = New TSMU.DashboardDS()
            Me.DashboardDS5 = New TSMU.DashboardDS()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardObjectDataSource6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardDS5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'CardDashboardItem1
            '
            Measure1.DataMember = "Passport"
            CardStretchedLayoutTemplate1.BottomValue1.DimensionIndex = 0
            CardStretchedLayoutTemplate1.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardStretchedLayoutTemplate1.BottomValue1.Visible = True
            CardStretchedLayoutTemplate1.BottomValue2.DimensionIndex = 0
            CardStretchedLayoutTemplate1.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardStretchedLayoutTemplate1.BottomValue2.Visible = True
            CardStretchedLayoutTemplate1.DeltaIndicator.Visible = True
            CardStretchedLayoutTemplate1.MainValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardStretchedLayoutTemplate1.MainValue.Visible = True
            CardStretchedLayoutTemplate1.Sparkline.Visible = True
            CardStretchedLayoutTemplate1.SubValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardStretchedLayoutTemplate1.SubValue.Visible = True
            CardStretchedLayoutTemplate1.TopValue.DimensionIndex = 0
            CardStretchedLayoutTemplate1.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardStretchedLayoutTemplate1.TopValue.Visible = True
            Card1.LayoutTemplate = CardStretchedLayoutTemplate1
            Card1.Name = "Passport"
            Card1.AddDataItem("ActualValue", Measure1)
            Measure2.DataMember = "Visa"
            CardStretchedLayoutTemplate2.BottomValue1.DimensionIndex = 0
            CardStretchedLayoutTemplate2.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            CardStretchedLayoutTemplate2.BottomValue1.Visible = True
            CardStretchedLayoutTemplate2.BottomValue2.DimensionIndex = 0
            CardStretchedLayoutTemplate2.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            CardStretchedLayoutTemplate2.BottomValue2.Visible = True
            CardStretchedLayoutTemplate2.DeltaIndicator.Visible = True
            CardStretchedLayoutTemplate2.MainValue.DimensionIndex = 0
            CardStretchedLayoutTemplate2.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            CardStretchedLayoutTemplate2.MainValue.Visible = True
            CardStretchedLayoutTemplate2.Sparkline.Visible = True
            CardStretchedLayoutTemplate2.SubValue.DimensionIndex = 0
            CardStretchedLayoutTemplate2.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            CardStretchedLayoutTemplate2.SubValue.Visible = True
            CardStretchedLayoutTemplate2.TopValue.DimensionIndex = 0
            CardStretchedLayoutTemplate2.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            CardStretchedLayoutTemplate2.TopValue.Visible = True
            Card2.LayoutTemplate = CardStretchedLayoutTemplate2
            Card2.Name = "Visa"
            Card2.AddDataItem("ActualValue", Measure2)
            Me.CardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() {Card1, Card2})
            Me.CardDashboardItem1.ComponentName = "CardDashboardItem1"
            Me.CardDashboardItem1.DataItemRepository.Clear()
            Me.CardDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.CardDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1")
            Me.CardDashboardItem1.DataSource = Me.DashboardObjectDataSource6
            Me.CardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.CardDashboardItem1.Name = "Request Passport & Visa"
            Me.CardDashboardItem1.ShowCaption = True
            '
            'DashboardObjectDataSource6
            '
            Me.DashboardObjectDataSource6.ComponentName = "DashboardObjectDataSource6"
            Me.DashboardObjectDataSource6.DataMember = "dtTravelSum"
            Me.DashboardObjectDataSource6.DataSource = Me.DashboardDS6
            Me.DashboardObjectDataSource6.Name = "Object Data Source 1"
            '
            'DashboardDS6
            '
            Me.DashboardDS6.DataSetName = "DashboardDS"
            Me.DashboardDS6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DashboardDS1
            '
            Me.DashboardDS1.DataSetName = "DashboardDS"
            Me.DashboardDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DashboardDS2
            '
            Me.DashboardDS2.DataSetName = "DashboardDS"
            Me.DashboardDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DashboardDS3
            '
            Me.DashboardDS3.DataSetName = "DashboardDS"
            Me.DashboardDS3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DashboardDS4
            '
            Me.DashboardDS4.DataSetName = "DashboardDS"
            Me.DashboardDS4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DashboardDS5
            '
            Me.DashboardDS5.DataSetName = "DashboardDS"
            Me.DashboardDS5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Dashboard_TravelSum
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource6})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.CardDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.CardDashboardItem1
            DashboardLayoutItem1.Weight = 50.053248136315226R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Weight = 100.0R
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardObjectDataSource6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardDS5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents DashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS1 As DashboardDS
        Friend WithEvents DashboardObjectDataSource2 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS2 As DashboardDS
        Friend WithEvents CardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Friend WithEvents DashboardObjectDataSource3 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS3 As DashboardDS
        Friend WithEvents DashboardObjectDataSource4 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS4 As DashboardDS
        Friend WithEvents DashboardObjectDataSource5 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS5 As DashboardDS
        Friend WithEvents DashboardObjectDataSource6 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Friend WithEvents DashboardDS6 As DashboardDS

#End Region
    End Class
End Namespace