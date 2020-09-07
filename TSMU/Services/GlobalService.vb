Public Class GlobalService
    Dim ObjApprove As ApproveHistoryModel
    Public Function GetLevel(Frm As Form) As Integer
        Dim _result As Integer = 0
        Try
            Dim Sql As String = "M_Approve_GetUserLevel"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@form", SqlDbType.VarChar)
            pParam(0).Value = Frm.Name
            pParam(1) = New SqlClient.SqlParameter("@username", SqlDbType.VarChar)
            pParam(1).Value = gh_Common.Username
            Dim dt As New DataTable

            dt = GetDataTableByCommand_SP(Sql, pParam)
            If dt.Rows.Count > 0 Then
                _result = Convert.ToInt32(dt.Rows(0)(0))
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetMaxLevel(Frm As Form) As Integer
        Dim _result As Integer = 0
        Try
            Dim Sql As String = "M_Approve_GetMaxApprove"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@form", SqlDbType.VarChar)
            pParam(0).Value = Frm.Name
            Dim dt As New DataTable

            dt = GetDataTableByCommand_SP(Sql, pParam)
            If dt.Rows.Count > 0 Then
                _result = Convert.ToInt32(dt.Rows(0)(0))
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetNoDRR(Seq As Integer, NoNPP As String) As DataTable
        Dim _result As Integer = 0
        Try
            Dim Sql As String = "NPP_GetNoDRR"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@Seq", SqlDbType.Int)
            pParam(0).Value = Seq

            Dim dt As New DataTable

            dt = GetDataTableByCommand_SP(Sql, pParam)
            'If dt.Rows.Count > 0 Then
            '    _result = Convert.ToInt32(dt.Rows(0)(0))
            'End If
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AprrovedBy(Frm As Form, NoTran As String, Level As Integer) As String
        Dim _result As String = String.Empty
        Try
            Dim Sql As String = "T_Approve_History_IsDataExist"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@form", SqlDbType.VarChar)
            pParam(0).Value = Frm.Name
            pParam(1) = New SqlClient.SqlParameter("@notran", SqlDbType.VarChar)
            pParam(1).Value = NoTran
            pParam(2) = New SqlClient.SqlParameter("@level", SqlDbType.Int)
            pParam(2).Value = Level
            Dim dt As New DataTable

            dt = GetDataTableByCommand_SP(Sql, pParam)
            If dt.Rows.Count > 0 Then
                _result = Convert.ToString(dt(0)(0))
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Approve(Model As ApproveHistoryModel, Status As String)
        Try

            Dim Sql As String = "T_ApproveHistory_Insert"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(7) {}
            pParam(0) = New SqlClient.SqlParameter("@UserName", SqlDbType.VarChar)
            pParam(0).Value = Model.UserName
            pParam(1) = New SqlClient.SqlParameter("@MenuCode", SqlDbType.VarChar)
            pParam(1).Value = Model.MenuCode
            pParam(2) = New SqlClient.SqlParameter("@DeptID", SqlDbType.VarChar)
            pParam(2).Value = Model.DeptID
            pParam(3) = New SqlClient.SqlParameter("@NoTransaksi", SqlDbType.VarChar)
            pParam(3).Value = Model.NoTransaksi
            pParam(4) = New SqlClient.SqlParameter("@LevelApprove", SqlDbType.Int)
            pParam(4).Value = Model.LevelApproved
            pParam(5) = New SqlClient.SqlParameter("@StatusApproved", SqlDbType.VarChar)
            pParam(5).Value = Status
            pParam(6) = New SqlClient.SqlParameter("@ApprovedBy", SqlDbType.VarChar)
            pParam(6).Value = gh_Common.Username
            pParam(7) = New SqlClient.SqlParameter("@IsActive", SqlDbType.Int)
            pParam(7).Value = Model.IsActive
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateFlag(Model As ApproveHistoryModel, Level As Integer)
        Try

            Dim Sql As String = "T_ApproveHistory_UpdateFlag"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@notransaksi", SqlDbType.VarChar)
            pParam(0).Value = Model.NoTransaksi
            pParam(1) = New SqlClient.SqlParameter("@form", SqlDbType.VarChar)
            pParam(1).Value = Model.MenuCode
            pParam(2) = New SqlClient.SqlParameter("@level", SqlDbType.Int)
            pParam(2).Value = Level
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Add by Midi for update all flag 0
    Public Sub UpdateFlagAll(Model As ApproveHistoryModel)
        Try

            Dim Sql As String = "T_ApproveHistory_UpdateFlagAll"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@notransaksi", SqlDbType.VarChar)
            pParam(0).Value = Model.NoTransaksi
            pParam(1) = New SqlClient.SqlParameter("@form", SqlDbType.VarChar)
            pParam(1).Value = Model.MenuCode
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Delete(Id As String, Frm As Form)
        Try

            Dim Sql As String = "T_ApproveHistory_Delete"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@notransaksi", SqlDbType.VarChar)
            pParam(0).Value = Id
            pParam(1) = New SqlClient.SqlParameter("@form", SqlDbType.VarChar)
            pParam(1).Value = Frm.Name
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub UpdateAutoNo(frm As Form)
        Try

            Dim Sql As String = "s_numbering_update_lastno"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@frm", SqlDbType.VarChar)
            pParam(0).Value = frm.Name
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub SNumneringInsert(FrmName As String, Customer As String, ProjectName As String)
        Try

            Dim Sql As String = "S_Numbering_insert"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}
            pParam(0) = New SqlClient.SqlParameter("@MenuCode", SqlDbType.VarChar)
            pParam(0).Value = FrmName
            pParam(1) = New SqlClient.SqlParameter("@Prefix", SqlDbType.VarChar)
            pParam(1).Value = "DRR"
            pParam(2) = New SqlClient.SqlParameter("@Suffix", SqlDbType.VarChar)
            pParam(2).Value = "NPP"
            pParam(3) = New SqlClient.SqlParameter("@Param1", SqlDbType.VarChar)
            pParam(3).Value = Customer
            pParam(4) = New SqlClient.SqlParameter("@Param2", SqlDbType.VarChar)
            pParam(4).Value = ProjectName
            pParam(5) = New SqlClient.SqlParameter("@Separator", SqlDbType.VarChar)
            pParam(5).Value = "/"
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Get auto number format "prefix-tahun-bulan-number"/"TR-2020-12-0001"
    Public Function GetAutoNumber(frm As Form) As String
        Try
            Dim dt As New DataTable
            Dim SP_Name As String = "S_GetAutoNumber"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@menuCode", SqlDbType.VarChar)
            pParam(0).Value = frm.Name

            dt = GetDataTableByCommand_SP(SP_Name, pParam)

            Return dt.Rows(0).Item(0).ToString

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub UpdateAutoNumber(frm As Form)
        Try
            Dim dt As New DataTable
            Dim SP_Name As String = "S_UpdateAutoNumber"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@menuCode", SqlDbType.VarChar)
            pParam(0).Value = frm.Name

            ExecQueryByCommand_SP(SP_Name, pParam)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
