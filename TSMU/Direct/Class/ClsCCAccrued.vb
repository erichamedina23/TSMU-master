Imports System.Collections.ObjectModel

Public Class ClsCCAccrued
    Dim clsGlobal As GlobalService
    Public Property ID As Integer
    Public Property NoAccrued As String
    Public Property Tanggal As Date
    Public Property TanggalTrans As Date
    Public Property NoTransaksi As String
    Public Property Seq As Integer
    Public Property JenisTransaksi As String
    Public Property Description As String
    Public Property CurryID As String
    Public Property Amount As Double
    Public Property Rate As Double
    Public Property AmountIDR As Double
    Public Property CreditCardNumber As String
    Public Property AccountName As String
    Public Property BankName As String
    Public Property Pay As Integer

    Public Property ObjCCAccrued() As New Collection(Of ClsCCAccrued)

    Dim strQuery As String

    Public Function GetDataCostCC() As DataTable
        Try
            Dim dt As New DataTable
            Dim SP_Name As String = "Accrued_Get_CostCC"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@CreditCardNumber", SqlDbType.VarChar)
            pParam(0).Value = CreditCardNumber

            dt = GetDataTableByCommand_SP(SP_Name, pParam)

            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDataCostCCAll(_Pay As Integer) As DataTable
        Try
            Dim dt As New DataTable
            strQuery = "SELECT  ID ,
                                NoAccrued ,
                                Tanggal ,
                                TanggalTrans AS TanggalTransaksi ,
                                NoTransaksi ,
                                Seq ,
                                JenisTransaksi ,
                                Description ,
                                CurryID ,
                                Amount ,
                                Rate ,
                                AmountIDR ,
                                CreditCardNumber ,
                                AccountName ,
                                BankName ,
                                Pay
                        FROM    dbo.T_CCAccrued
                        WHERE   Pay = " & _Pay & " "
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub InsertData(frm As Form, noAccrued_ As String, rows As ArrayList)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        For i = 0 To rows.Count - 1
                            Dim Row As DataRow = CType(rows(i), DataRow)
                            NoAccrued = noAccrued_
                            Tanggal = Date.Today
                            TanggalTrans = Row("TanggalTransaksi")
                            NoTransaksi = Row("NoTransaksi")
                            Seq = Row("Seq")
                            JenisTransaksi = Row("JenisTransaksi")
                            Description = Row("Description")
                            CurryID = Row("CurryID")
                            Amount = Row("Amount")
                            Rate = Row("Rate")
                            AmountIDR = Row("AmountIDR")
                            CreditCardNumber = Row("CreditCardNumber")
                            AccountName = Row("AccountName")
                            BankName = Row("BankName")
                            InsertDataAccrued()
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

    Public Sub DeleteData(rows As ArrayList)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        For i = 0 To rows.Count - 1
                            Dim Row As DataRow = CType(rows(i), DataRow)
                            NoAccrued = Row("NoAccrued")
                            NoTransaksi = Row("NoTransaksi")
                            Seq = Row("Seq")
                            DeleteDataAccrued()
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

    Public Sub InsertDataAccrued()
        Try
            Dim dt As New DataTable

            Dim SP_Name As String = "Accrued_Insert_CCAccrued"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(14) {}
            pParam(0) = New SqlClient.SqlParameter("@NoAccrued", SqlDbType.VarChar)
            pParam(0).Value = NoAccrued
            pParam(1) = New SqlClient.SqlParameter("@Tanggal", SqlDbType.Date)
            pParam(1).Value = Tanggal
            pParam(2) = New SqlClient.SqlParameter("@TanggalTrans", SqlDbType.Date)
            pParam(2).Value = TanggalTrans
            pParam(3) = New SqlClient.SqlParameter("@NoTransaksi", SqlDbType.VarChar)
            pParam(3).Value = NoTransaksi
            pParam(4) = New SqlClient.SqlParameter("@Seq", SqlDbType.VarChar)
            pParam(4).Value = Seq
            pParam(5) = New SqlClient.SqlParameter("@JenisTransaksi", SqlDbType.VarChar)
            pParam(5).Value = JenisTransaksi
            pParam(6) = New SqlClient.SqlParameter("@Description", SqlDbType.VarChar)
            pParam(6).Value = Description
            pParam(7) = New SqlClient.SqlParameter("@CurryID", SqlDbType.VarChar)
            pParam(7).Value = CurryID
            pParam(8) = New SqlClient.SqlParameter("@Amount", SqlDbType.Float)
            pParam(8).Value = Amount
            pParam(9) = New SqlClient.SqlParameter("@Rate", SqlDbType.Float)
            pParam(9).Value = Rate
            pParam(10) = New SqlClient.SqlParameter("@AmountIDR", SqlDbType.Float)
            pParam(10).Value = AmountIDR
            pParam(11) = New SqlClient.SqlParameter("@CreditCardNumber", SqlDbType.VarChar)
            pParam(11).Value = CreditCardNumber
            pParam(12) = New SqlClient.SqlParameter("@AccountName", SqlDbType.VarChar)
            pParam(12).Value = AccountName
            pParam(13) = New SqlClient.SqlParameter("@BankName", SqlDbType.VarChar)
            pParam(13).Value = BankName
            pParam(14) = New SqlClient.SqlParameter("@Username", SqlDbType.VarChar)
            pParam(14).Value = gh_Common.Username

            ExecQueryByCommand_SP(SP_Name, pParam)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DeleteDataAccrued()
        Try
            Dim dt As New DataTable

            Dim SP_Name As String = "Accrued_Delete_CCAccrued"

            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@NoAccrued", SqlDbType.VarChar)
            pParam(0).Value = NoAccrued
            pParam(1) = New SqlClient.SqlParameter("@NoTransaksi", SqlDbType.VarChar)
            pParam(1).Value = NoTransaksi
            pParam(2) = New SqlClient.SqlParameter("@Seq", SqlDbType.VarChar)
            pParam(2).Value = Seq

            ExecQueryByCommand_SP(SP_Name, pParam)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetCreditCard() As DataTable
        Try
            strQuery = " SELECT  CreditCardID ,
                                CreditCardNumber ,
                                AccountName ,
                                BankName
                        FROM    dbo.TravelCreditCard "
            Dim dt As New DataTable
            dt = GetDataTable(strQuery)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
