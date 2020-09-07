Public Class clsCR_Accounting


    Public Function Get_Approve_Accounting() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"


            Dim query As String = "[CR_Request_Get_ApproveAccounting]"

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt




        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_Approve_Accounting2() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Request_Get_ApproveAccounting2]"

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_Cek_Purchase() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Request_Get_Cek_Purchase]"

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Function Get_Purchase_Monitor_Proses(TAwal As Date, TAkhir As Date) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"


            Dim query As String = "[CR_Request_Get_Purcase_Monitor_Proses]"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@pAwal", SqlDbType.Date)
            pParam(1) = New SqlClient.SqlParameter("@pAkhir", SqlDbType.Date)

            pParam(0).Value = TAwal
            pParam(1).Value = TAkhir

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt




        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_Purchase_Monitor_Approve(TAwal As Date, TAkhir As Date) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"


            Dim query As String = "[CR_Request_Get_Purcase_Monitor_Approve]"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@pAwal", SqlDbType.Date)
            pParam(1) = New SqlClient.SqlParameter("@pAkhir", SqlDbType.Date)

            pParam(0).Value = TAwal
            pParam(1).Value = TAkhir

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt




        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_BeritaAcara(Dept As String) As DataTable

        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_BeritaAcara]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_BeritaAcara_Finish(Dept As String) As DataTable

        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_BeritaAcara_Finish]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function


End Class
