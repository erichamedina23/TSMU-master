Imports System.IO
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraSplashScreen
Imports TSMU.Win_Dashboards

Public Class DashboardPainting
    Dim dashboardKanban As New Dashboard_kanbanSum
    Dim Dashboard As New ClsDashbard
    Private Shared _instance As DashboardPainting
    Private Initializing As Boolean = False
    Public Shared ReadOnly Property Instance As DashboardPainting
        Get
            If _instance Is Nothing Then
                _instance = New DashboardPainting
            End If
            Return _instance
        End Get

    End Property
    Sub New()
        Initializing = True
        ' This call is required by the designer.
        InitializeComponent()
        TglFrom.EditValue = Date.Today
        TglTo.EditValue = Date.Today
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
            If TglFrom.Text = "" OrElse TglTo.Text = "" Then
                TglFrom.Focus()
                Throw New Exception("Harap isi tanggal From atau To !")
            End If
            dt = New DataTable
            Dashboard._From = TglFrom.EditValue
            Dashboard._To = TglTo.EditValue
            dt = Dashboard.GetDashboardKanbanSum()
            DashboardViewer1.Dashboard = dashboardKanban
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TglTo_EditValueChanged(sender As Object, e As EventArgs) Handles TglTo.EditValueChanged, TglFrom.EditValueChanged
        Try
            If Initializing Then
                Exit Sub
            End If
            DashboardSource()
            DashboardViewer1.ReloadData()
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
End Class
