Imports System.Collections.ObjectModel

Public Class TravelTicketModel
    Dim clsGlobal As GlobalService
    Public Property NoRequest As String
    Public Property NoVoucher As String
    Public Property Tanggal As Date
    Public Property Vendor As String
    Public Property NoInvoice As String
    Public Property DateInvoice As Date
    Public Property DueDateInvoice As Date
    Public Property CurryID As String
    Public Property Status As String
    Public Property TotAmount As Double
    Public Property StatusTicket As String

    Dim strQuery As String

    Public Property ObjTravelTicketDetail() As New Collection(Of TravelTicketDetailModel)
    Public Property ObjTravelTicketUncheck() As New Collection(Of TravelTicketDetailModel)

    Public Function TravelAutoNoVoucher() As String
        Try
            strQuery = " DECLARE @bulan VARCHAR(4) " &
                        " DECLARE @tahun VARCHAR(4) " &
                        " DECLARE @seq VARCHAR(4) " &
                        " SET @bulan = LEFT(CONVERT(CHAR(20), GETDATE(), 101), 2) " &
                        " SET @tahun = DATEPART(YEAR, GETDATE()) " &
                        " SET @seq = ( SELECT RIGHT('0000' " &
                        "                           + CAST(RIGHT(RTRIM(MAX(NoVoucher)), 4) + 1 AS VARCHAR), " &
                        "                           4) " &
                        "              From dbo.TravelTicket " &
                        "              WHERE  SUBSTRING(NoVoucher, 1, 7) = 'TT' + '-' + RIGHT(@tahun, 4) " &
                        "                     And SUBSTRING(NoVoucher, 9, 2) = RIGHT(@bulan, 2) " &
                        "            ) " &
                        " SELECT 'TT' + '-' + RIGHT(@tahun, 4) + '-' + @bulan + '-' + COALESCE(@seq, " &
                        "                                                               '0001') "

            Dim dt As DataTable = New DataTable
            dt = GetDataTable(strQuery)
            Return dt.Rows(0).Item(0).ToString

        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function GetTravelRequest() As DataTable
        Try
            strQuery = " SELECT  trh.NoRequest ,
                                trh.Nama ,
                                trh.DeptID ,
                                trh.Purpose ,
                                trh.TravelType ,
                                trd.Destination ,
                                trd.Negara ,
                                trd.Visa ,
                                trd.DepartureDate ,
                                trd.ArrivalDate ,
                                trh.Status ,
                                trh.StatusTicket
                        FROM    dbo.TravelRequestHeader AS trh
                                LEFT JOIN dbo.TravelRequestDetail AS trd ON trd.NoRequest = trh.NoRequest
                                LEFT JOIN dbo.TravelTicketDetail AS ttd ON ttd.NoRequest = trd.NoRequest
                                                                            AND ttd.Seq = trd.Seq
                        WHERE   ttd.NoRequest IS NULL
                                AND trh.Status = 'PROGRESS'
                                AND trh.Approved = 'APPROVED' "
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetTravelTicket() As DataTable
        Try
            strQuery = " SELECT  NoVoucher ,
                                Tanggal ,
                                Vendor ,
                                NoInvoice ,
                                CuryID ,
                                TotAmount
                        FROM    dbo.TravelTicket "
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetTravelTicketDetail() As DataTable
        Try
            Dim dt As New DataTable

            Dim SP_Name As String = "Travel_Get_TravelTicketDetail"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@NoVoucher", SqlDbType.VarChar)
            pParam(0).Value = IIf(NoVoucher = Nothing, "", NoVoucher)

            dt = MainModul.GetDataTableByCommand_SP(SP_Name, pParam)

            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetTravelRequestByID() As DataTable
        Try
            strQuery = " SELECT  trh.NoRequest ,
                                trh.Nama ,
                                trh.DeptID ,
                                trh.Purpose ,
                                trh.TravelType ,
                                trd.Destination ,
                                trd.Negara ,
                                trd.Visa ,
                                trd.DepartureDate ,
                                trd.ArrivalDate
                        FROM    dbo.TravelRequestHeader AS trh
                                LEFT JOIN dbo.TravelRequestDetail AS trd ON trd.NoRequest = trh.NoRequest "
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GetTravelTicketByID()
        Try
            strQuery = "SELECT  NoVoucher ,
                                Tanggal ,
                                Vendor ,
                                NoInvoice ,
                                DateInvoice ,
                                DueDateInvoice ,
                                CuryID ,
                                TotAmount
                        FROM    dbo.TravelTicket
                        WHERE   NoVoucher = " & QVal(NoVoucher) & ""
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            If dt.Rows.Count > 0 Then
                NoVoucher = If(IsDBNull(dt.Rows(0).Item("NoVoucher")), "", Trim(dt.Rows(0).Item("NoVoucher").ToString()))
                Tanggal = If(IsDBNull(dt.Rows(0).Item("Tanggal")), DateTime.Today, Convert.ToDateTime(dt.Rows(0).Item("Tanggal")))
                Vendor = If(IsDBNull(dt.Rows(0).Item("Vendor")), "", Trim(dt.Rows(0).Item("Vendor").ToString()))
                NoInvoice = If(IsDBNull(dt.Rows(0).Item("NoInvoice")), "", Trim(dt.Rows(0).Item("NoInvoice").ToString()))
                DateInvoice = If(IsDBNull(dt.Rows(0).Item("DateInvoice")), Nothing, Convert.ToDateTime(dt.Rows(0).Item("DateInvoice")))
                DueDateInvoice = If(IsDBNull(dt.Rows(0).Item("DueDateInvoice")), Nothing, Convert.ToDateTime(dt.Rows(0).Item("DueDateInvoice")))
                CurryID = If(IsDBNull(dt.Rows(0).Item("CuryID")), "", Trim(dt.Rows(0).Item("CuryID").ToString()))
                TotAmount = If(IsDBNull(dt.Rows(0).Item("TotAmount")), 0, Convert.ToDouble(dt.Rows(0).Item("TotAmount")))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertData(frm As Form)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        InsertHeader()

                        For i As Integer = 0 To ObjTravelTicketDetail.Count - 1
                            With ObjTravelTicketDetail(i)
                                .InsertDetail()
                            End With
                        Next
                        clsGlobal = New GlobalService
                        clsGlobal.UpdateAutoNumber(frm)

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

    Public Sub InsertHeader()
        Try
            Dim SP_Name As String = "Travel_Insert_TravelTicketHeader"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(8) {}

            pParam(0) = New SqlClient.SqlParameter("@NoVoucher", SqlDbType.VarChar)
            pParam(0).Value = NoVoucher
            pParam(1) = New SqlClient.SqlParameter("@Tanggal", SqlDbType.Date)
            pParam(1).Value = Tanggal
            pParam(2) = New SqlClient.SqlParameter("@Vendor", SqlDbType.VarChar)
            pParam(2).Value = Vendor
            pParam(3) = New SqlClient.SqlParameter("@NoInvoice", SqlDbType.VarChar)
            pParam(3).Value = NoInvoice
            pParam(4) = New SqlClient.SqlParameter("@DateInvoice", SqlDbType.Date)
            pParam(4).Value = DateInvoice
            pParam(5) = New SqlClient.SqlParameter("@DueDateInvoice", SqlDbType.Date)
            pParam(5).Value = DueDateInvoice
            pParam(6) = New SqlClient.SqlParameter("@CuryID", SqlDbType.VarChar)
            pParam(6).Value = CurryID
            pParam(7) = New SqlClient.SqlParameter("@TotAmount", SqlDbType.Float)
            pParam(7).Value = TotAmount
            pParam(8) = New SqlClient.SqlParameter("@Username", SqlDbType.VarChar)
            pParam(8).Value = gh_Common.Username

            ExecQueryByCommand_SP(SP_Name, pParam)
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
                        UpdateHeader()

                        Dim ObjTicketDetail As New TravelTicketDetailModel
                        ObjTicketDetail.DeleteDetail(NoVoucher)

                        For i As Integer = 0 To ObjTravelTicketDetail.Count - 1
                            With ObjTravelTicketDetail(i)
                                .InsertDetail()
                            End With
                        Next

                        For i As Integer = 0 To ObjTravelTicketUncheck.Count - 1
                            With ObjTravelTicketUncheck(i)
                                .UpdateRequestUncheck()
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

    Public Sub UpdateHeader()
        Try
            strQuery = " UPDATE  dbo.TravelTicket " & vbCrLf &
                        " SET     Vendor = " & QVal(Vendor) & " , " & vbCrLf &
                        "         NoInvoice = " & QVal(NoInvoice) & " , " & vbCrLf &
                        "         DateInvoice = " & QVal(DateInvoice) & " , " & vbCrLf &
                        "         DueDateInvoice = " & QVal(DueDateInvoice) & " , " & vbCrLf &
                        "         CuryID = " & QVal(CurryID) & " , " & vbCrLf &
                        "         TotAmount = " & QVal(TotAmount) & " , " & vbCrLf &
                        "         UpdatedBy = " & QVal(gh_Common.Username) & " , " & vbCrLf &
                        "         UpdatedDate = GETDATE() " & vbCrLf &
                        " WHERE   NoVoucher = " & QVal(NoVoucher) & " "
            ExecQuery(strQuery)
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
                        DeleteHeader(NoVoucher)

                        Dim ObjTicketDetail As New TravelTicketDetailModel
                        ObjTicketDetail.UpdateRequest(NoVoucher)
                        ObjTicketDetail.DeleteDetail(NoVoucher)

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

    Public Sub DeleteHeader(ByVal _NoVoucher As String)
        Try
            Dim ls_SP As String = " DELETE FROM dbo.TravelTicket
                                    WHERE NoVoucher = " & QVal(_NoVoucher) & ""
            ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateRequestStatusTicket(ByVal dtTempStatus As DataTable)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        For i As Integer = 0 To dtTempStatus.Rows.Count - 1
                            Dim noRequest As String = dtTempStatus.Rows(i).Item("NoRequest")
                            Dim status As String = dtTempStatus.Rows(i).Item("Status")
                            Dim statusTicket As String = dtTempStatus.Rows(i).Item("StatusTicket")
                            strQuery = "UPDATE  dbo.TravelRequestHeader
                                        SET     Status = " & QVal(status) & " ,
                                                StatusTicket = " & QVal(statusTicket) & " ,
                                                UpdatedBy = " & QVal(gh_Common.Username) & " ,
                                                UpdatedDate = GETDATE()
                                        WHERE   NoRequest = " & QVal(noRequest) & ""
                            ExecQuery(strQuery)
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

    Public Function CheckRequestSettle() As Boolean
        Try
            Dim ada As Boolean = False
            strQuery = "SELECT  COUNT(ttd.NoVoucher) AS Ada
                        FROM    dbo.TravelTicketDetail AS ttd
                                INNER JOIN dbo.TravelSettleDetail AS tsd ON tsd.NoRequest = ttd.NoRequest
                        WHERE   NoVoucher = " & QVal(NoVoucher) & ""
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            If dt.Rows(0).Item(0) > 0 Then
                ada = True
            End If
            Return ada
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetTravelVendor() As DataTable
        Try
            strQuery = "SELECT  VendId ,
                                Name
                        FROM    dbo.Vendor"
            Dim dt As New DataTable
            dt = GetDataTable_Solomon(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetTravelTicketTSC(ByVal noVoucher_ As String, ByVal NoRequest_ As String, ByVal Seq_ As Integer) As DataTable
        Try
            strQuery = " SELECT Seq ,
                                TicketNumber ,
                                Amount
                         FROM   dbo.TravelTicketDetail
                         WHERE  NoVoucher = " & QVal(noVoucher_) & "
                                AND NoRequest = " & QVal(NoRequest_) & "
                                AND Seq = " & Seq_ & " "
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

Public Class TravelTicketDetailModel

    Public Property NoRequest As String
    Public Property NoVoucher As String
    Public Property Seq As Integer
    Public Property TicketNumber As String
    Public Property CuryID As String
    Public Property Amount As Double

    Dim strQuery As String

    Public Sub InsertDetail()
        Try
            Dim SP_Name As String = "Travel_Insert_TravelTicketDetail"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}

            pParam(0) = New SqlClient.SqlParameter("@NoVoucher", SqlDbType.VarChar)
            pParam(0).Value = NoVoucher
            pParam(1) = New SqlClient.SqlParameter("@NoRequest", SqlDbType.VarChar)
            pParam(1).Value = NoRequest
            pParam(2) = New SqlClient.SqlParameter("@Seq", SqlDbType.Int)
            pParam(2).Value = Seq
            pParam(3) = New SqlClient.SqlParameter("@TicketNumber", SqlDbType.VarChar)
            pParam(3).Value = TicketNumber
            pParam(4) = New SqlClient.SqlParameter("@CuryID", SqlDbType.VarChar)
            pParam(4).Value = CuryID
            pParam(5) = New SqlClient.SqlParameter("@Amount", SqlDbType.Float)
            pParam(5).Value = Amount

            ExecQueryByCommand_SP(SP_Name, pParam)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DeleteDetail(ByVal _NoVoucher As String)
        Try
            Dim ls_SP As String = " DELETE FROM dbo.TravelTicketDetail
                                    WHERE NoVoucher = " & QVal(_NoVoucher) & ""
            ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateRequest(ByVal _NoVoucher As String)
        Try
            strQuery = " UPDATE dbo.TravelRequestHeader
                         SET    Status = 'PROGRESS' ,
                                StatusTicket = 'ISSUE'
                         WHERE  NoRequest IN ( SELECT   NoRequest
                                               FROM     dbo.TravelTicketDetail WITH ( NOLOCK )
                                               WHERE    NoVoucher = " & QVal(_NoVoucher) & " ); "
            ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateRequestUncheck()
        Try
            strQuery = " UPDATE dbo.TravelRequestHeader
                         SET    Status = 'PENDING' ,
                                StatusTicket = 'ISSUE'
                         WHERE  NoRequest = " & QVal(NoRequest) & ""
            ExecQuery(strQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
