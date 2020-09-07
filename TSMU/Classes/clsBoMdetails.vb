Imports System.Collections.ObjectModel
Imports TSMU

Public Class clsBoMdetails
#Region "variables"
    Private _bomid As String
    Public Property BoMID() As String
        Get
            Return _bomid
        End Get
        Set(ByVal value As String)
            _bomid = value
        End Set
    End Property
    Private _parentid As String
    Public Property Parentid() As String
        Get
            Return _parentid
        End Get
        Set(ByVal value As String)
            _parentid = value
        End Set
    End Property

    Private _invtid_detail As String
    Public Property inventId() As String
        Get
            Return _invtid_detail
        End Get
        Set(ByVal value As String)
            _invtid_detail = value
        End Set
    End Property

    Private _descr_detail As String
    Public Property Descr_detail() As String
        Get
            Return _descr_detail
        End Get
        Set(ByVal value As String)
            _descr_detail = value
        End Set
    End Property

    Private _qty As Single
    Public Property Qty() As Single
        Get
            Return _qty
        End Get
        Set(ByVal value As Single)
            _qty = value
        End Set
    End Property

    Private _unit As String
    Public Property Unit() As String
        Get
            Return _unit
        End Get
        Set(ByVal value As String)
            _unit = value
        End Set
    End Property

    Public Property Fc_classdetail As New Collection(Of clsBoMdetails)
#End Region
    Public Sub InsertDetail()
        Try
            Dim ls_SP As String = "" & vbCrLf &
                                "INSERT INTO bom(bomid,parentid,invtid,descr,qty,unit) " & vbCrLf &
                                "OUTPUT Inserted.bomid, " & vbCrLf &
                                "       Inserted.parentid, " & vbCrLf &
                                "       Inserted.invtid, " & vbCrLf &
                                "       Inserted.descr, " & vbCrLf &
                                "       Inserted.qty, " & vbCrLf &
                                "       Inserted.unit, " & vbCrLf &
                                "       0 " & vbCrLf &
                                "       INTO bom_detail_history " & vbCrLf &
                                "VALUES(" & QVal(_bomid) & ", " & vbCrLf &
                                "   " & QVal(_parentid) & ", " & vbCrLf &
                                "   " & QVal(_invtid_detail) & ", " & vbCrLf &
                                "   " & QVal(_descr_detail) & ", " & vbCrLf &
                                "   " & QVal(_qty) & ", " & vbCrLf &
                                "   " & QVal(_unit) & ")"
            ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub InsertDetailExcel(i As Integer)

        Try
            Dim _rev As Integer = GetLasRevisi(i)
            Dim ls_SP As String = "" & vbCrLf &
                                "INSERT INTO bom(bomid,parentid,invtid,descr,qty,unit) " & vbCrLf &
                                "OUTPUT Inserted.bomid, " & vbCrLf &
                                "       Inserted.parentid, " & vbCrLf &
                                "       Inserted.invtid, " & vbCrLf &
                                "       Inserted.descr, " & vbCrLf &
                                "       Inserted.qty, " & vbCrLf &
                                "       Inserted.unit, " & vbCrLf &
                                "       " & QVal(_rev) & " " & vbCrLf &
                                "       INTO bom_detail_history " & vbCrLf &
                                "VALUES(" & QVal(Fc_classdetail(i)._bomid) & ", " & vbCrLf &
                                "   " & QVal(Fc_classdetail(i)._parentid) & ", " & vbCrLf &
                                "   " & QVal(Fc_classdetail(i)._invtid_detail) & ", " & vbCrLf &
                                "   " & QVal(Fc_classdetail(i)._descr_detail) & ", " & vbCrLf &
                                "   " & QVal(Fc_classdetail(i)._qty) & ", " & vbCrLf &
                                "   " & QVal(Fc_classdetail(i)._unit) & ")"
            ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DeleteDetail(ByVal bomid As String, ByVal rev As Integer)
        Try
            Dim ls_SP As String = "" & vbCrLf &
                            "Delete from bom " & vbCrLf &
                            "   OUTPUT DELETED.*, " & rev & " + 1 Into bom_detail_history " & vbCrLf &
                            "where bomid = " & QVal(bomid) & ""
            MainModul.ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub DeleteDetailExcel(i As Integer)
        Try
            Dim ls_SP As String = "" & vbCrLf &
                            " Delete from bom 
                              where bomid = " & QVal(Fc_classdetail(i)._bomid) & "
                              and parentid= " & QVal(Fc_classdetail(i)._parentid) & " 
                              and invtid = " & QVal(Fc_classdetail(i).inventId) & ""
            MainModul.ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DeleteDetailByParentAndInvt(ByVal ParentId As String, ByVal InvtID As Integer)
        Try
            Dim ls_SP As String = "" & vbCrLf &
                            "Delete from bom " & vbCrLf &
                            "where ParentId = " & QVal(ParentId) & " AND InvtId = " & QVal(InvtID) & ""
            MainModul.ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateQtyDetailsManual(i As Integer)
        Try
            Dim _rev As Integer = GetLasRevisi(i)
            Dim ls_SP As String = " " & vbCrLf &
                                    " Update bom " & vbCrLf &
                                    " SET    Qty = " & QVal(_qty) & " " & vbCrLf &
                                    " where RTRIM(parentid) = " & QVal(Fc_classdetail(i)._parentid.Trim) & " AND RTRIM(InvtId) = " & QVal(Fc_classdetail(i)._invtid_detail.Trim) & ""
            ExecQuery(ls_SP)


        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub UpdateBoMDetail()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try

                        For i As Integer = 0 To Fc_classdetail.Count - 1
                            With Fc_classdetail(i)
                                DeleteDetailExcel(i)
                                InsertDetailExcel(i)
                            End With
                        Next

                        Trans1.Commit()
                    Catch ex As Exception
                        Trans1.Rollback()
                        Throw
                    Finally
                        MainModul.gh_Trans = Nothing
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Function ValidateUpdateDetail() As Boolean
        Dim _result As Boolean = False
        Try
            Dim Query As String =
                "   
                    SELECT bomid 
                    FROM bom 
                    WHERE bomid = " & QVal(_bomid) & "
                "
            Dim dt As DataTable = GetDataTable(Query)
            If dt.Rows.Count > 0 Then
                _result = True
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetLasRevisi(i As Integer) As Integer
        Dim _result As Integer = 0
        Try
            Dim Sql As String = "select isnull(max(revisi),0) rev from bom_detail_history  where bomid = " & QVal(Fc_classdetail(i)._bomid) & "
                              and parentid= " & QVal(Fc_classdetail(i)._parentid) & " 
                              and invtid = " & QVal(Fc_classdetail(i).inventId) & ""
            Dim dt As New DataTable

            dt = GetDataTable(Sql)
            If dt.Rows.Count > 0 Then
                _result = Convert.ToInt32(dt.Rows(0)(0))
            End If
            Return _result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
