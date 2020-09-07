Imports System.Collections.ObjectModel

Public Class MApproveService
    Public Property DetailModel() As New Collection(Of DRRDetail)
    Public Function GetAll() As DataTable
        Try
            Dim Sql As String = "m_approve_getdata"
            Dim dt As New DataTable
            dt = GetDataTableSP(Sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetById(Id As Integer) As MApproveModel
        Try
            Dim Sql As String = "m_approve_getdataById"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@id", SqlDbType.Int)
            pParam(0).Value = Id
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(Sql, pParam)
            Dim _Model As New MApproveModel
            If dt.Rows.Count > 0 Then
                With _Model
                    .ID = If(IsDBNull(dt.Rows(0)("ID")), 0, Convert.ToInt32(dt.Rows(0)("ID")))
                    .UserName = If(IsDBNull(dt.Rows(0)("UserName")), "", Convert.ToString(dt.Rows(0)("UserName")))
                    .MenuCode = If(IsDBNull(dt.Rows(0)("MenuCode")), "", Convert.ToString(dt.Rows(0)("MenuCode")))
                    .DeptID = If(IsDBNull(dt.Rows(0)("DeptID")), "", Convert.ToString(dt.Rows(0)("DeptID")))
                    .LevelApprove = If(IsDBNull(dt.Rows(0)("LevelApprove")), "", Convert.ToString(dt.Rows(0)("LevelApprove")))
                End With
            End If
            Return _Model
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetFormName() As DataTable
        Try
            Dim Sql As String = "S_UserPermission_getFormName"
            Dim dt As New DataTable
            dt = GetDataTableSP(Sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetUsername() As DataTable
        Try
            Dim Sql As String = "S_User_GetUsername"
            Dim dt As New DataTable
            dt = GetDataTableSP(Sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Add(ByVal Model As MApproveModel) As Integer
        Try
            Dim _result As Integer = 0
            Dim Sql As String = "M_Approve_Insert"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(4) {}
            pParam(0) = New SqlClient.SqlParameter("@UserName", SqlDbType.VarChar)
            pParam(0).Value = Model.UserName
            pParam(1) = New SqlClient.SqlParameter("@MenuCode", SqlDbType.VarChar)
            pParam(1).Value = Model.MenuCode
            pParam(2) = New SqlClient.SqlParameter("@DeptID", SqlDbType.Char)
            pParam(2).Value = Model.DeptID
            pParam(3) = New SqlClient.SqlParameter("@LevelApprove", SqlDbType.Int)
            pParam(3).Value = Model.LevelApprove
            pParam(4) = New SqlClient.SqlParameter("@user", SqlDbType.VarChar)
            pParam(4).Value = gh_Common.Username
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(Sql, pParam)
            If dt.Rows.Count > 0 Then
                _result = CInt(dt.Rows(0)(0))
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Update(ByVal Model As MApproveModel)
        Try
            Dim _result As Integer = 0
            Dim Sql As String = "M_Approve_Update"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}
            pParam(0) = New SqlClient.SqlParameter("@UserName", SqlDbType.VarChar)
            pParam(0).Value = Model.UserName
            pParam(1) = New SqlClient.SqlParameter("@MenuCode", SqlDbType.VarChar)
            pParam(1).Value = Model.MenuCode
            pParam(2) = New SqlClient.SqlParameter("@DeptID", SqlDbType.Char)
            pParam(2).Value = Model.DeptID
            pParam(3) = New SqlClient.SqlParameter("@LevelApprove", SqlDbType.Int)
            pParam(3).Value = Model.LevelApprove
            pParam(4) = New SqlClient.SqlParameter("@user", SqlDbType.VarChar)
            pParam(4).Value = gh_Common.Username
            pParam(5) = New SqlClient.SqlParameter("@id", SqlDbType.Int)
            pParam(5).Value = Model.ID
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function IsDataExist(Model As MApproveModel) As Boolean
        Dim _result As Boolean = False
        Try
            Dim Sql As String = "M_Approve_IsExist"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@UserName", SqlDbType.VarChar)
            pParam(0).Value = Model.UserName
            pParam(1) = New SqlClient.SqlParameter("@MenuCode", SqlDbType.VarChar)
            pParam(1).Value = Model.MenuCode
            pParam(2) = New SqlClient.SqlParameter("@DeptID", SqlDbType.Char)
            pParam(2).Value = Model.DeptID
            Dim dt As New DataTable

            dt = GetDataTableByCommand_SP(Sql, pParam)
            If dt.Rows.Count > 0 Then
                _result = Convert.ToBoolean(If(IsDBNull(dt.Rows(0)(0)), 0, 1))
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub DeleteHeader(Id As Integer)
        Try
            Dim Sql As String = "M_Approve_Delete"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@id", SqlDbType.Int)
            pParam(0).Value = Id
            ExecQueryByCommand_SP(Sql, pParam)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
