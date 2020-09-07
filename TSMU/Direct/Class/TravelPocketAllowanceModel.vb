Public Class TravelPocketAllowanceModel
    Public Property TravelType As String
    Public Property Golongan As Integer
    Public Property NamaNegara As String
    Public Property DescGolongan As String
    Public Property CurryID As String
    Public Property AmountAllowance As String
    Public Property AmountFirstTravel As String

    Dim strQuery As String

    Public Function GetAllDataTable() As DataTable
        Try
            strQuery = "SELECT  TravelType ,
                                Golongan ,
                                NamaNegara ,
                                DescGolongan ,
                                CuryID ,
                                Amount ,
                                FirstTravel
                        FROM    dbo.TravelPocketAllowance"
            Dim dtTable As New DataTable
            dtTable = GetDataTable(strQuery)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub GetPocketAllowanceByID()
        Try
            strQuery = "SELECT  TravelType ,
                                Golongan ,
                                NamaNegara ,
                                DescGolongan ,
                                CuryID ,
                                Amount ,
                                FirstTravel
                        FROM    dbo.TravelPocketAllowance
                        WHERE   TravelType = " & QVal(TravelType) & "
                                AND Golongan = " & Golongan & "
                                AND NamaNegara = " & QVal(NamaNegara) & "
                                AND CuryID = " & QVal(CurryID) & ""
            Dim dtTable As New DataTable
            dtTable = GetDataTable(strQuery)
            If dtTable.Rows.Count > 0 Then
                TravelType = If(IsDBNull(dtTable.Rows(0).Item("TravelType")), "", dtTable.Rows(0).Item("TravelType").ToString())
                Golongan = If(IsDBNull(dtTable.Rows(0).Item("Golongan")), "", dtTable.Rows(0).Item("Golongan"))
                NamaNegara = If(IsDBNull(dtTable.Rows(0).Item("NamaNegara")), "", dtTable.Rows(0).Item("NamaNegara").ToString())
                DescGolongan = If(IsDBNull(dtTable.Rows(0).Item("DescGolongan")), "", dtTable.Rows(0).Item("DescGolongan").ToString())
                CurryID = If(IsDBNull(dtTable.Rows(0).Item("CuryID")), "", dtTable.Rows(0).Item("CuryID").ToString())
                AmountAllowance = If(IsDBNull(dtTable.Rows(0).Item("Amount")), "", dtTable.Rows(0).Item("Amount"))
                AmountFirstTravel = If(IsDBNull(dtTable.Rows(0).Item("FirstTravel")), "", dtTable.Rows(0).Item("FirstTravel"))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function CheckValidasi(ByVal travelType__ As String, ByVal golongan__ As Integer, ByVal negara__ As String) As Boolean
        Dim value As Boolean = True
        Try
            strQuery = "SELECT  *
                        FROM    dbo.TravelPocketAllowance
                        WHERE   TravelType = " & QVal(travelType__) & "
                                AND Golongan = " & golongan__ & "
                                AND NamaNegara = " & QVal(negara__) & ""
            Dim dtTable As New DataTable
            dtTable = GetDataTable(strQuery)
            If dtTable.Rows.Count > 0 Then
                Err.Raise(ErrNumber, , "Data Travel Type " & QVal(travelType__) & ", Golongan " & QVal(golongan__) & " & Negara " & QVal(negara__) & " sudah ada !")
                value = False
            End If
        Catch ex As Exception
            Throw
        End Try
        Return value
    End Function

    Public Sub InsertData()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        strQuery = "INSERT  INTO dbo.TravelPocketAllowance
                                            ( TravelType ,
                                              Golongan ,
                                              NamaNegara ,
                                              CuryID ,
                                              DescGolongan ,
                                              Amount ,
                                              FirstTravel ,
                                              CreatedBy ,
                                              CreatedDate ,
                                              UpdatedBy ,
                                              UpdatedDate
                                            )
                                    VALUES  ( " & QVal(TravelType) & " , -- TravelType - varchar(15)
                                              " & Golongan & " , -- Golongan - int
                                              " & QVal(NamaNegara) & " , -- NamaNegara - varchar(20)
                                              " & QVal(CurryID) & " , -- CuryID - varchar(5)
                                              " & QVal(DescGolongan) & " , -- DescGolongan - varchar(20)
                                              " & AmountAllowance & " , -- Amount - float
                                              " & AmountFirstTravel & " , -- FirstTravel - float
                                              " & QVal(gh_Common.Username) & " , -- CreatedBy - varchar(20)
                                              GETDATE() , -- CreatedDate - datetime
                                              " & QVal(gh_Common.Username) & " , -- UpdatedBy - varchar(20)
                                              GETDATE()  -- UpdatedDate - datetime
                                            );"
                        ExecQuery(strQuery)

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

    Public Sub UpdateData()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        strQuery = "UPDATE  dbo.TravelPocketAllowance
                                    SET     CuryID = " & QVal(CurryID) & " ,
                                            Amount = " & AmountAllowance & " ,
                                            FirstTravel = " & AmountFirstTravel & " ,
                                            UpdatedBy = " & QVal(gh_Common.Username) & " ,
                                            UpdatedDate = GETDATE()
                                    WHERE   TravelType = " & QVal(TravelType) & "
                                            AND Golongan = " & Golongan & "
                                            AND NamaNegara = " & QVal(NamaNegara) & ""
                        ExecQuery(strQuery)

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

    Public Sub DeleteData()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1
                    Try
                        strQuery = "DELETE  FROM dbo.TravelPocketAllowance
                                    WHERE   TravelType = " & QVal(TravelType) & "
                                            AND Golongan = " & Golongan & "
                                            AND NamaNegara = " & QVal(NamaNegara) & ""
                        ExecQuery(strQuery)

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
            Throw ex
        End Try
    End Sub

    Public Function GetListNegara() As DataTable
        Try
            strQuery = "SELECT  NamaNegara
                        FROM    dbo.TravelNegara"
            Dim dtTable As New DataTable
            dtTable = GetDataTable(strQuery)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetListGolongan() As DataTable
        Try
            strQuery = "SELECT  *
                        FROM    dbo.TravelGolongan"
            Dim dtTable As New DataTable
            dtTable = GetDataTable(strQuery)
            Return dtTable
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
