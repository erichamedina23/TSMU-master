Imports System.Collections.ObjectModel

Public Class TravelEntertainModel
    Public Property CuryID As String
    Public Property DeptID As String
    Public Property ID As Integer
    Public Property pay As Short
    Public Property Remark As String
    Public Property SettleID As String
    Public Property Status As String
    Public Property PRNo As String
    Public Property SuspendID As String
    Public Property Tgl As Date
    Public Property Total As Double
    Public Property TotalSuspend As Double
    Public Property Tgl1 As Date
    Public Property Tgl2 As Date
    Public Property Jenis As String
    Public Property noPR As String
    Public Property Date1 As Date
    Public Property Date2 As Date
    'Public Property ObjDetails() As New Collection(Of SettleDetail)
    Dim strQuery As String
    Public Sub GetSettleById()
        Try
            strQuery = "SELECT  t.ID ,
                                t.SettleID ,
                                t.SuspendID ,
                                t.DeptID ,
                                t.Remark ,
                                t.Tgl ,
                                t.CuryID ,
                                t.Status ,
                                t.Total ,
                                t.pay ,
                                s.Total TotSuspend ,
                                t.PRNo
                        FROM    settle_header t
                                LEFT JOIN suspend_header s ON t.SuspendID = s.SuspendID
                        WHERE   t.SettleID = " & QVal(SettleID) & ""
            Dim dt As New DataTable
            dt = GetDataTable_Solomon(strQuery)
            If dt.Rows.Count > 0 Then
                ID = If(IsDBNull(dt.Rows(0).Item("ID")), "", Trim(dt.Rows(0).Item("ID").ToString()))
                SettleID = If(IsDBNull(dt.Rows(0).Item("SettleID")), "", Trim(dt.Rows(0).Item("SettleID").ToString()))
                SuspendID = If(IsDBNull(dt.Rows(0).Item("SuspendID")), "", Trim(dt.Rows(0).Item("SuspendID").ToString()))
                DeptID = If(IsDBNull(dt.Rows(0).Item("DeptID")), "", Trim(dt.Rows(0).Item("DeptID").ToString()))
                Remark = If(IsDBNull(dt.Rows(0).Item("Remark")), "", Trim(dt.Rows(0).Item("Remark").ToString()))
                Tgl = If(IsDBNull(dt.Rows(0).Item("Tgl")), DateTime.Today, Convert.ToDateTime(dt.Rows(0).Item("Tgl")))
                Status = If(IsDBNull(dt.Rows(0).Item("Status")), "", Trim(dt.Rows(0).Item("Status").ToString()))
                Total = If(IsDBNull(dt.Rows(0).Item("Total")), 0, Convert.ToDouble(dt.Rows(0).Item("Total")))
                TotalSuspend = If(IsDBNull(dt.Rows(0).Item("TotSuspend")), 0, Convert.ToDouble(dt.Rows(0).Item("TotSuspend")))
                CuryID = If(IsDBNull(dt.Rows(0).Item("CuryID")), "", Convert.ToString(dt.Rows(0).Item("CuryID")))
                PRNo = If(IsDBNull(dt.Rows(0).Item("PRNo")), "", Convert.ToString(dt.Rows(0).Item("PRNo")))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Sub InsertRelasiSettleEnt()
    '    Try
    '        Dim ls_SP As String = " " & vbCrLf &
    '        "INSERT INTO Settle_Relasi (SettleID,Nama,Posisi,Perusahaan,JenisUsaha,Remark ) " & vbCrLf &
    '        "Values(" & QVal(SettleID) & ", " & vbCrLf &
    '        "       " & QVal(Nama) & ", " & vbCrLf &
    '        "       " & QVal(Posisi) & ", " & vbCrLf &
    '        "       " & QVal(Perusahaan) & ", " & vbCrLf &
    '        "       " & QVal(JenisUSaha) & ", " & vbCrLf &
    '        "       " & QVal(Remark) & ")"
    '        ExecQuery_Solomon(ls_SP)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub

    'Public Sub InsertDetails()
    '    Try
    '        Dim ls_SP As String = " " & vbCrLf &
    '        "INSERT INTO suspend_detail (SuspendID,AcctID,SubAcct,Description,Tgl,DeptID,Nama,Tempat,Alamat,Jenis,NoKwitansi,Amount ) " & vbCrLf &
    '        "Values(" & QVal(SuspendID) & ", " & vbCrLf &
    '        "       " & QVal(AcctID) & ", " & vbCrLf &
    '        "       " & QVal(SubAcct) & ", " & vbCrLf &
    '        "       " & QVal(Description) & ", " & vbCrLf &
    '        "       " & QVal(Tgl) & ", " & vbCrLf &
    '        "       " & QVal(DeptID) & ", " & vbCrLf &
    '        "       " & QVal(Nama) & ", " & vbCrLf &
    '        "       " & QVal(Tempat) & ", " & vbCrLf &
    '        "       " & QVal(Alamat) & ", " & vbCrLf &
    '        "       " & QVal(Jenis) & ", " & vbCrLf &
    '        "       " & QVal(NoKwitansi) & ", " & vbCrLf &
    '        "       " & QVal(Amount) & ")"
    '        ExecQuery_Solomon(ls_SP)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub

    'Public Sub InsertRelasi()
    '    Try
    '        Dim ls_SP As String = " " & vbCrLf &
    '        "INSERT INTO SuspendRelasi (SuspendID,Nama,Posisi,Perusahaan,JenisUsaha,Remark ) " & vbCrLf &
    '        "Values(" & QVal(SuspendID) & ", " & vbCrLf &
    '        "       " & QVal(Nama) & ", " & vbCrLf &
    '        "       " & QVal(Posisi) & ", " & vbCrLf &
    '        "       " & QVal(Perusahaan) & ", " & vbCrLf &
    '        "       " & QVal(JenisUSaha) & ", " & vbCrLf &
    '        "       " & QVal(Remark) & ")"
    '        ExecQuery_Solomon(ls_SP)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub

    'Public Sub InsertRelasiSettle()
    '    Try
    '        Dim ls_SP As String = " " & vbCrLf &
    '        "INSERT INTO settlerelasi (SettleID,Nama,Posisi,Perusahaan,JenisUsaha,Remark ) " & vbCrLf &
    '        "Values(" & QVal(SettleID) & ", " & vbCrLf &
    '        "       " & QVal(NamaRelasi) & ", " & vbCrLf &
    '        "       " & QVal(Posisi) & ", " & vbCrLf &
    '        "       " & QVal(Relasi) & ", " & vbCrLf &
    '        "       " & QVal(JenisRelasi) & ", " & vbCrLf &
    '        "       " & QVal(Nota) & ")"
    '        ExecQuery_Solomon(ls_SP)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub

    'Public Sub DeleteDetail(_suspendID)
    '    Try
    '        Dim ls_SP As String = "DELETE FROM suspend_detail WHERE rtrim(SuspendID)=" & QVal(_suspendID.TrimEnd) & ""
    '        ExecQuery_Solomon(ls_SP)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub

    'Public Function GetSubAccountbyid() As DataTable
    '    Try
    '        Dim sql As String = "SELECT 
    '                              RTRIM(Consolsub) [SubAccount],
    '                             RTRIM(Descr) Descritiption
    '                            FROM dbo.SubAcct WHERE Consolsub = " & QVal(SubAcct) & ""
    '        Dim dt As New DataTable
    '        dt = GetDataTable_Solomon(sql)
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function GetDataDetailByID() As DataTable
    '    Try
    '        Dim sql As String = "SELECT 
    '                              RTRIM([SubAcct]) SubAccount,
    '                                RTRIM([AcctID]) Account,
    '                             RTRIM(Description) Description,
    '                                Tgl,
    '                                RTRIM(DeptID) DeptID,
    '                                RTRIM(Nama) Nama,
    '                                RTRIM(Tempat) Tempat,
    '                                RTRIM(Alamat) Alamat,
    '                                RTRIM(Jenis) Jenis,
    '                                RTRIM(NoKwitansi) NoKwitansi,
    '                                [Amount] Amount
    '                            FROM suspend_detail WHERE SuspendID = " & QVal(SuspendID) & ""

    '        Dim dt As New DataTable
    '        dt = GetDataTable_Solomon(sql)
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function GetDataDetailByIDSettleENt() As DataTable
    '    Try
    '        Dim sql As String = "SELECT 
    '                              RTRIM([SubAcct]) SubAccount,
    '                                RTRIM([AcctID]) Account,
    '                             RTRIM(Description) Description,
    '                                Tgl,
    '                                RTRIM(DeptID) DeptID,
    '                                RTRIM(Nama) Nama,
    '                                RTRIM(Tempat) Tempat,
    '                                RTRIM(Alamat) Alamat,
    '                                RTRIM(Jenis) Jenis,
    '                                RTRIM(NoKwitansi) NoKwitansi,
    '                                [Amount] Amount
    '                            FROM suspend_detail WHERE SuspendID = " & QVal(SuspendID) & ""

    '        Dim dt As New DataTable
    '        dt = GetDataTable_Solomon(sql)
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function GetDataDetailByIDEnt() As DataTable
    '    Try
    '        Dim sql As String = "SELECT 
    '                              RTRIM([SubAcct]) SubAccount,
    '                                RTRIM([AcctID]) Account,
    '                             RTRIM(Description) Description,
    '                                Tgl,
    '                                RTRIM(DeptID) DeptID,
    '                                RTRIM(Nama) Nama,
    '                                RTRIM(Tempat) Tempat,
    '                                RTRIM(Alamat) Alamat,
    '                                RTRIM(Jenis) Jenis,
    '                                RTRIM(NoKwitansi) NoKwitansi,
    '                                Amount
    '                            FROM suspend_detail WHERE SuspendID = " & QVal(SuspendID) & ""

    '        Dim dt As New DataTable
    '        dt = GetDataTable_Solomon(sql)
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function GetDataDetailByID1Ent(_SuspendID As String) As DataTable
    '    Try
    '        Dim sql As String = "SELECT GETDATE() as Tgl,
    '                              RTRIM([SubAcct]) SubAccount,
    '                                RTRIM([AcctID]) Account,
    '                             RTRIM(Description) Description,
    '                                Amount,
    '                                0 ActualAmount 
    '                            FROM suspend_detail WHERE SuspendID = " & QVal(_SuspendID) & ""
    '        Dim dt As New DataTable
    '        dt = GetDataTable_Solomon(sql)
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function GetDataDetailByIDtrial() As DataTable
    '    Try
    '        Dim sql As String = "SELECT 
    '                              RTRIM([SubAcct]) SubAccount,
    '                                RTRIM([AcctID]) Account,
    '                             RTRIM(Description) Description,
    '                                [Amount] Amount
    '                            FROM suspend_detail WHERE SuspendID = " & QVal(SuspendID) & ""
    '        Dim dt As New DataTable
    '        dt = GetDataTable_Solomon(sql)
    '        Return dt
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

End Class

Public Class TravelEntertainDetailModel
    Public Property AcctID As String
    Public Property Alamat As String
    Public Property Amount As Double
    Public Property DeptID As String
    Public Property Description As String
    Public Property Jenis As String
    Public Property Nama As String
    Public Property NoKwitansi As String
    Public Property SubAcct As String
    Public Property SuspendDetailID As Integer
    Public Property SuspendID As String
    Public Property Tempat As String
    Public Property Tgl As Date
    Public Property Posisi As String
    Public Property Perusahaan As String
    Public Property JenisUSaha As String
    Public Property Remark As String
    Public Property SettleID As String
    Public Property Relasi As String
    Public Property JenisRelasi As String
    Public Property Nota As String
    Public Property NamaRelasi As String

    Public Function GetDataDetailByID() As DataTable
        Try
            Dim sql As String = "SELECT 
 	                                RTRIM([SubAcct]) SubAccount,
                                    RTRIM([AcctID]) Account,
	                                RTRIM(Description) Description,
                                    Tgl,
                                    RTRIM(DeptID) DeptID,
                                    RTRIM(Nama) Nama,
                                    RTRIM(Tempat) Tempat,
                                    RTRIM(Alamat) Alamat,
                                    RTRIM(Jenis) Jenis,
                                    RTRIM(NoKwitansi) NoKwitansi,
                                    [Amount] Amount
                                FROM suspend_detail WHERE SuspendID = " & QVal(SuspendID) & ""

            Dim dt As New DataTable
            dt = GetDataTable_Solomon(sql)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
