Imports System.IO
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraSplashScreen
Imports TSMU.Win_Dashboards

Public Class DashboardTravel
    Dim dashboardTravel As New Dashboard_TravelSum
    Dim Dashboard As New ClsDashbard
    Private Shared _instance As DashboardTravel
    Private Initializing As Boolean = False
    Public Shared ReadOnly Property Instance As DashboardTravel
        Get
            If _instance Is Nothing Then
                _instance = New DashboardTravel
            End If
            Return _instance
        End Get

    End Property
    Sub New()
        Initializing = True
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Dim dt As DataTable
    Private Sub DashboardEnginer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initializing = False
    End Sub

    Private Sub DashboardViewer1_DataLoading(sender As Object, e As DataLoadingEventArgs) Handles DashboardViewer1.DataLoading
        Try
            If e.DataSourceName = "Object Data Source 1" Then
                e.Data = dt
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try

    End Sub

    Private Sub DashboardViewer1_Load(sender As Object, e As EventArgs) Handles DashboardViewer1.Load
        Try

            DashboardSource()
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try

    End Sub
    Private Sub DashboardSource()
        Try

            dt = New DataTable

            dt = Dashboard.GetDashboardTravelSum()
            DashboardViewer1.Dashboard = dashboardTravel
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
