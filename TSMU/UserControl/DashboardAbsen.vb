Imports System.IO
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters

Public Class DashboardAbsen
    Private Shared _instance As DashboardAbsen
    Public Shared ReadOnly Property Instance As DashboardAbsen
        Get
            If _instance Is Nothing Then
                _instance = New DashboardAbsen
            End If
            Return _instance
        End Get

    End Property

    Private Sub DashboardAbsen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _connFile As String = System.IO.Directory.GetCurrentDirectory + "\Absen.xml"
        DashboardViewer1.LoadDashboard(_connFile)
    End Sub

    Private Sub DashboardViewer1_ConfigureDataConnection(sender As Object, e As DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
        'Dim parameters As ExtractDataSourceConnectionParameters = TryCast(e.ConnectionParameters, ExtractDataSourceConnectionParameters)
        'If parameters IsNot Nothing Then
        '    parameters.FileName = Path.GetFileName(parameters.FileName)

        'End If
        If e.DataSourceName = "SQL Data Source 1" Then
            Dim parameters As MsSqlConnectionParameters = CType(e.ConnectionParameters, MsSqlConnectionParameters)
            parameters.ServerName = gs_DBServer
            parameters.DatabaseName = gs_Database
            parameters.UserName = gs_DBUserName
            parameters.Password = gs_DBPassword
        End If
    End Sub
End Class
