Public Class Cls_NPP_Header

    Public Function Get_NPP() As DataTable
        Try
            Dim d As DateTime = Date.Today
            Dim TA As DateTime = d.AddDays(-d.Day)
            Dim TangalAwal As DateTime = TA.AddDays(-(TA.Day - 1))
            TangalAwal = TangalAwal.AddMonths(-5)
            Dim TangalAkhir As DateTime = Date.Now

            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP]"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@TgAwal", SqlDbType.Date)
            pParam(1) = New SqlClient.SqlParameter("@TgAkhir", SqlDbType.Date)

            pParam(0).Value = TangalAwal
            pParam(1).Value = TangalAkhir


            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_NPP2() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP2]"
            Dim dt2 As New DataTable
            dt2 = GetDataTableByCommand_SP(query)
            Return dt2
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_NPP_Search(tgawal As Date, tgakhir As Date, Status As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP_Search]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@TgAwal", SqlDbType.Date)
            pParam(1) = New SqlClient.SqlParameter("@TgAkhir", SqlDbType.Date)
            pParam(2) = New SqlClient.SqlParameter("@Status", SqlDbType.VarChar)

            pParam(0).Value = tgawal
            pParam(1).Value = tgakhir
            pParam(2).Value = Status

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_NPP_DeptHead() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP_DeptHead]"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            'pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_NPP_DeptHead2() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP_DeptHead2]"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            'pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_NPP_DivHead() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP_DivHead]"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            'pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_NPP_DivHead2() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP_DivHead2]"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            'pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_NPP_NPD() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_NPP_NPD]"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            'pParam(0).Value = Dept
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Function GetDelete(NP As String) As DataTable
        Try

            Dim ls_SP As String = "SELECT A.[No_NPP] 
                                        FROM [NPP_Head] A Inner join [NPWO_HEAD] B 
                                        ON A.[No_NPP] = B.[No_NPP]
                                        where A.[No_NPP] = '" & NP & "'"
            Dim dtTable As New DataTable
            dtTable = GetDataTableByCommand(ls_SP)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetDataUSer(User As String, MenuCode As String) As DataTable
        Try

            'Dim ls_SP As String = "SELECT username,level from S_user
            '                            where username = '" & User & "'"

            Dim ls_SP As String = "SELECT M_Approve.username,M_Approve.levelApprove 
                                    from S_user inner join M_Approve on S_user.UserName = M_Approve.UserName
                                    where S_user.username = '" & User & "' and M_Approve.MenuCode = '" & MenuCode & "'"
            Dim dtTable As New DataTable
            dtTable = GetDataTableByCommand(ls_SP)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Sub Delete(NPP_ As String)
        Try



            Dim ls_SP As String = "DELETE FROM [NPP_Head] WHERE No_NPP = '" & NPP_ & "'"

            MainModul.ExecQueryByCommand(ls_SP)



            Dim ls_Detail As String = "DELETE FROM [NPP_Detail]
                                     WHERE No_NPP = '" & NPP_ & "'"

            MainModul.ExecQueryByCommand(ls_Detail)



            Dim ls_Sp_History As String = "DELETE FROM [NPP_Head_History]
                                     WHERE No_NPP = '" & NPP_ & "'"

            MainModul.ExecQueryByCommand(ls_Sp_History)

            Dim ls_Detail_History As String = "DELETE FROM [NPP_Detail_History]
                                     WHERE No_NPP = '" & NPP_ & "'"

            MainModul.ExecQueryByCommand(ls_Detail_History)

            Dim ls_Detail_Rev As String = "DELETE FROM [NPP_Rev_Information]
                                     WHERE No_NPP = '" & NPP_ & "'"

            MainModul.ExecQueryByCommand(ls_Detail_Rev)


        Catch ex As Exception

        End Try


    End Sub


End Class
