Imports System.Collections.ObjectModel

Public Class ClsTraveller
    Public Property DeptID As String
    Public Property Nama As String
    Public Property NIK As String
    Public Property Golongan As Integer

    Public Property ObjVisa() As New Collection(Of ClsTravelerVisa)
    Public Property ObjPaspor() As New Collection(Of ClsTravelerPaspor)

    Dim strQuery As String

    Public Function GetAllDataTable(ByVal ls_Filter As String) As DataTable
        Try
            strQuery = "SELECT  NIK ,
                                Nama ,
                                DeptID ,
                                Golongan
                        FROM    dbo.Traveler "
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTable(strQuery)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub getDataByID(ByVal NIK As String)
        Try
            strQuery = "SELECT  NIK ,
                                Nama ,
                                DeptID ,
                                Golongan
                        FROM    dbo.Traveler
                        WHERE NIK = " & QVal(NIK) & ""
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTable(strQuery)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                With dtTable.Rows(0)
                    Me.NIK = Trim(.Item("NIK") & "")
                    Me.Nama = Trim(.Item("Nama") & "")
                    Me.DeptID = Trim(.Item("DeptID") & "")
                    Me.Golongan = Trim(.Item("Golongan") & "")
                End With
            Else
                NIK = ""
                Nama = ""
                DeptID = ""
                Golongan = ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function GetDept() As DataTable
        Try
            strQuery = "SELECT  [IdDept] ,
                                [NamaDept]
                        FROM    [mDept]"
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetListNegara() As DataTable
        Try
            strQuery = "SELECT  KodeNegara ,
                                NamaNegara
                        FROM    dbo.TravelNegara"
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ValidateInsert()
        Try
            strQuery = "SELECT  NIK ,
                                Nama ,
                                DeptID ,
                                Golongan
                        FROM    Traveler
                        WHERE   [NIK] = " & QVal(NIK) & ""
            Dim dtTable As New DataTable
            dtTable = GetDataTable(strQuery)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                Err.Raise(ErrNumber, , GetMessage(MessageEnum.InsertGagal) &
                "[" & Me.NIK & "]")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

#Region "CRUD"

    Public Sub Insert()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        InsertData()

                        For i As Integer = 0 To ObjPaspor.Count - 1
                            With ObjPaspor(i)
                                .InsertTravelerPaspor()
                            End With
                        Next

                        For i As Integer = 0 To ObjVisa.Count - 1
                            With ObjVisa(i)
                                .InsertTravelerVisa()
                            End With
                        Next

                        Trans1.Commit()
                    Catch ex As Exception
                        Trans1.Rollback()
                        Throw
                    Finally
                        gh_Trans = Nothing
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub InsertData()
        Try
            strQuery = "INSERT INTO [Traveler] 
                                ([NIK]
                                ,[Nama]
                                ,[DeptID]
                                ,[Golongan])
                        VALUES
                                (" & QVal(NIK) & "
                                ," & QVal(Nama) & " 
                                ," & QVal(DeptID) & " 
                                ," & QVal(Golongan) & ")"
            MainModul.ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Update()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        UpdateData(NIK)

                        Dim ObjTravelerPaspor As New ClsTravelerPaspor
                        ObjTravelerPaspor.DeletePaspor(NIK)

                        For i As Integer = 0 To ObjPaspor.Count - 1
                            With ObjPaspor(i)
                                .InsertTravelerPaspor()
                            End With
                        Next

                        Dim ObjTravelerVisa As New ClsTravelerVisa
                        ObjTravelerVisa.DeleteVisa(NIK)

                        For i As Integer = 0 To ObjVisa.Count - 1
                            With ObjVisa(i)
                                .InsertTravelerVisa()
                            End With
                        Next

                        Trans1.Commit()
                    Catch ex As Exception
                        Trans1.Rollback()
                        Throw
                    Finally
                        gh_Trans = Nothing
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateData(ByVal NIK As String)
        Try
            strQuery = "UPDATE  dbo.Traveler
                        SET     Nama = " & QVal(Nama) & " ,
                                DeptID = " & QVal(DeptID) & " ,
                                Golongan = " & QVal(Golongan) & "
                        WHERE   NIK = " & QVal(NIK) & ""
            MainModul.ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Delete(ByVal NIK As String)
        Try
            strQuery = "DELETE FROM Traveler WHERE NIK =" & QVal(NIK) & ""
            MainModul.ExecQuery(strQuery)

            Dim ObjTravelerVisa As New ClsTravelerVisa
            ObjTravelerVisa.DeleteVisa(NIK)

            Dim ObjTravelerPaspor As New ClsTravelerPaspor
            ObjTravelerPaspor.DeletePaspor(NIK)
        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region
End Class

Public Class ClsTravelerVisa
    Public Property NIK As String
    Public Property NoVisa As String
    Public Property Negara As String
    Public Property Category As String
    Public Property DateIssued As Date
    Public Property DateExpired As Date

    Dim strQuery As String

    Public Function GetTravelerVisa() As DataTable
        Try
            strQuery = "SELECT  NIK ,
                                NoVisa ,
                                Negara ,
                                Entries ,
                                DateIssued ,
                                DateExpired
                        FROM    dbo.TravelerVisa
                        WHERE   NIK = " & QVal(NIK) & ""
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTable(strQuery)

            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub InsertTravelerVisa()
        Try
            strQuery = "INSERT INTO [dbo].[TravelerVisa]
                            ([NIK]
                            ,[NoVisa]
                            ,[Negara]
                            ,[Entries]
                            ,[DateIssued]
                            ,[DateExpired])
                        VALUES
                            (" & QVal(NIK) & "
                            ," & QVal(NoVisa) & "
                            ," & QVal(Negara) & "
                            ," & QVal(Category) & "
                            ," & QVal(DateIssued) & "
                            ," & QVal(DateExpired) & ")"
            MainModul.ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DeleteVisa(ByVal NIK As String)
        Try
            strQuery = "DELETE FROM TravelerVisa WHERE NIK =" & QVal(NIK) & ""
            MainModul.ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class

Public Class ClsTravelerPaspor
    Public Property NIK As String
    Public Property NoPaspor As String
    Public Property Nama As String
    Public Property KodeNegara As String
    Public Property TanggalLahir As Date
    Public Property JenisKelamin As String
    Public Property TanggalKeluar As Date
    Public Property ExpiredDate As Date
    Public Property TempatKeluar As String

    Dim strQuery As String

    Public Function GetTravelerPaspor() As DataTable
        Try
            strQuery = "SELECT  NIK ,
                                NoPaspor ,
                                Nama ,
                                KodeNegara ,
                                TanggalLahir ,
                                JenisKelamin ,
                                TanggalKeluar ,
                                ExpiredDate ,
                                TempatKeluar
                        FROM    dbo.TravelerPaspor
                        WHERE   NIK = " & QVal(NIK) & ""
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTable(strQuery)

            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub InsertTravelerPaspor()
        Try
            strQuery = "INSERT INTO [dbo].[TravelerPaspor]
                                ([NIK]
                                ,[NoPaspor]
                                ,[Nama]
                                ,[KodeNegara]
                                ,[TanggalLahir]
                                ,[JenisKelamin]
                                ,[TanggalKeluar]
                                ,[ExpiredDate]
                                ,[TempatKeluar])
                            VALUES
                                (" & QVal(NIK) & "
                                ," & QVal(NoPaspor) & "
                                ," & QVal(Nama) & "
                                ," & QVal(KodeNegara) & "
                                ," & QVal(TanggalLahir) & "
                                ," & QVal(JenisKelamin) & "
                                ," & QVal(TanggalKeluar) & "
                                ," & QVal(ExpiredDate) & "
                                ," & QVal(TempatKeluar) & ")"
            MainModul.ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DeletePaspor(ByVal NIK As String)
        Try
            strQuery = "DELETE FROM dbo.TravelerPaspor WHERE NIK =" & QVal(NIK) & ""
            MainModul.ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
