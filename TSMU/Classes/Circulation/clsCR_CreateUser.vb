Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Globalization
Public Class ClsCR_CreateUser

    Dim _Query As String

    Public Property H_CirculationNo As String
    Public Property H_RequirementDate As DateTime
    Public Property H_DeptID As String
    Public Property H_SiteID As String
    Public Property H_PR As String
    Public Property H_Budget As Integer
    Public Property H_Account As String
    Public Property H_CR_Type As String
    Public Property H_Currency As String
    Public Property H_Rate As Double
    Public Property H_Reason As String
    Public Property H_RemainingBudget As Double
    Public Property H_CurrentCR As Double
    Public Property H_Balance As Double
    Public Property H_InvoiceNo As String
    Public Property H_UserSubmition As Boolean
    Public Property H_DeptHead_ID As String
    Public Property H_DeptHead_Name As String
    Public Property H_DeptHead_Opinion As String
    Public Property H_DeptHead_Approve As Boolean
    Public Property H_DeptHead_Approve_Date As Date
    Public Property H_DivHead_ID As String
    Public Property H_DivHead_Name As String
    Public Property H_DivHead_Opinion As String
    Public Property H_DivHead_Approve As Boolean
    Public Property H_DivHead_Approve_Date As Date
    Public Property H_Status As String
    Public Property H_Parent_Circulation As String
    Public Property H_Parent_Circulation_Amount As Double

    Public Property H_Dies_Sales_Type As String
    Public Property H_Dies_Customer_Name As String
    Public Property H_Dies_Remark As String
    Public Property H_Dies_Model As String
    Public Property H_Dies As Int32
    Public Property H_ChargedOf As Int32
    Public Property H_InvoiceNumber As String
    Public Property H_InvoiceStatus As Int32
    Public Property H_TotalCR As Double
    Public Property H_NameItem As String
    Public Property H_PO As Boolean
    Public Property H_Spesification As String
    Public Property H_BOD_Approve As Boolean
    Public Property H_BOD_Approve_Date As Date
    Public Property H_BOD_User As String

    Public Property H_NoBeritaAcara As String
    Public Property H_TanggalBeritaAcara As Date

    Public Property Collection_Description_Of_Cost() As New Collection(Of ClsCR_Description_of_Cost)
    Public Property Collection_Other_Dept() As New Collection(Of ClsCR_Other_Dept)
    Public Property Collection_Installment() As New Collection(Of ClsCR_Installment)
    Public Property Collection_BomT1() As New Collection(Of ClsCR_BomT1)
    Public Property Collection_Approve() As New Collection(Of ClsCR_Approve)




    Public Function Get_Mold(NPP_ As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[NPP_Get_Detail_NPP]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@NPP", SqlDbType.VarChar)
            pParam(0).Value = NPP_
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_Detail_OtherDept(CirculationNo As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "Select 
                                    [DeptID] as [Dept]
                                    ,[DeptHead_Name] as [Name]
                                    ,[Date] 
                                    ,[Opinion]  
                                  from [CR_Other_Dept] Where [CirculationNo] = '" & CirculationNo & "'"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            'pParam(0).Value = CirculationNo
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            For a As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(a).Item("Date") Is Nothing Then
                    dt.Rows(a).Item("Date") = Date.Now
                End If
            Next

            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_Detail_DescriptionOfCost(CirculationNo As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_Detail_DescriptionOfCost]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(0).Value = CirculationNo
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Get_Detail_Installment(CirculationNo As String) As DataTable
        Try
            Dim query As String = "[CR_Get_Detail_Installment]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(0).Value = CirculationNo
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim D As String = Convert.ToString(dt.Rows(i).Item("Date"))
                dt.Rows(i).Item("Date") = IIf((dt.Rows(i).Item("Date") Is Nothing) Or D = "01/01/0001 12:00:00 AM", DBNull.Value, dt.Rows(i).Item("Date"))
            Next

            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Get_CRRequest(Dept As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_Request]"
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

    Public Function GetMold() As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "Select Npwo_Detail.NoUrut
                                      ,Npwo_Detail.[No_Npwo] as NPWO
	                                  ,Npwo_Detail.Part_No as [Name Of Goods]
                                      ,Npwo_Detail.Part_Name as [Spesification]
                                      ,Npwo_Detail.[Check] 
                                      ,Npwo_Head.[Model_Name]  as Model
                                      ,Npwo_Head.[Customer_Name] as Customer
                                 from Npwo_Detail inner join Npwo_Head
	                                  on Npwo_Detail.[No_Npwo] = Npwo_Head.[No_Npwo]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetBeritaAcara(NoSirkulasi As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "SELECT [CirculationNo]
                                  ,[NoBeritaAcara]
                                  ,[TanggalBeritaAcara]
                              FROM [CR_BeritaAcara]
                                   Where [CirculationNo] = '" & NoSirkulasi & "' "
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetMold_ByModel(_Model As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "Select Npwo_Detail.NoUrut
                                      ,Npwo_Detail.[No_Npwo] as NPWO
	                                  ,Npwo_Detail.Part_No as [Name Of Goods]
                                      ,Npwo_Detail.Part_Name as [Spesification]
                                      ,Npwo_Detail.[Check] 
                                      ,Npwo_Head.[Model_Name]  as Model
                                      ,Npwo_Head.[Customer_Name] as Customer
                                 from Npwo_Detail inner join Npwo_Head
	                                  on Npwo_Detail.[No_Npwo] = Npwo_Head.[No_Npwo]
                                      Where Npwo_Head.[Model_Name] = '" & _Model & "' "
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function GetMold_ByNpwo(Npwo_ As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "Select Npwo_Detail.NoUrut
                                      ,Npwo_Detail.[No_Npwo] as NPWO
	                                  ,Npwo_Detail.Part_No as [Name Of Goods]
                                      ,Npwo_Detail.Part_Name as [Spesification]
                                      ,Npwo_Detail.[Check] 
                                      ,Npwo_Head.[Model_Name]  as Model
                                      ,Npwo_Head.[Customer_Name] as Customer
                                 from Npwo_Detail inner join Npwo_Head
	                                  on Npwo_Detail.[No_Npwo] = Npwo_Head.[No_Npwo]
                                      Where Npwo_Detail.[No_Npwo] = '" & Npwo_ & "'"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function GetPR(Dept_Sub As String, Tahun As String, Bulan As Double) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query1 As String = "[CR_Get_PRNo]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@Sub", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Tahun", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Bulan", SqlDbType.Float)
            pParam(0).Value = Dept_Sub
            pParam(1).Value = Tahun
            pParam(2).Value = Bulan
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP_Solomon(query1, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function GetBudget(Dept_Sub As String, Tahun As String, Bulan As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_AccountBudget]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@Sub", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Tahun", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Bulan", SqlDbType.VarChar)
            pParam(0).Value = Dept_Sub
            pParam(1).Value = Tahun
            pParam(2).Value = Bulan
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP_Solomon(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function GetParent_Circulation(Dept As String, Tahun As String, Bulan As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_ParentCirculation]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)
            'pParam(1) = New SqlClient.SqlParameter("@Tahun", SqlDbType.VarChar)
            'pParam(2) = New SqlClient.SqlParameter("@Bulan", SqlDbType.VarChar)
            pParam(0).Value = Dept
            'pParam(1).Value = Tahun
            'pParam(2).Value = Bulan
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function getWC() As DataTable
        Try
            Dim query As String = "[CR_Get_Currency]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP_Solomon(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Get_Other_DeptID() As DataTable
        Try
            Dim query As String = "[CR_Get_Other_DeptID]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Other_DeptID_Filter(Circulation_ As String) As DataTable
        Try
            Dim query As String = "SELECT [CirculationNo]
                                  ,[DeptID]
                                  ,[DeptHead_ID]
                                  ,[DeptHead_Name]
                                  ,[DeptHead_Email]
                                  ,[Date]
                                  ,[Opinion]
                                  ,[Approve]
                              FROM [CR_Other_Dept] where [CirculationNo] = '" & Circulation_ & "'"
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Email_Dept(Circulation_ As String) As DataTable
        Try
            Dim query As String = "SELECT isnull([DeptHead_Email],'')
                                    FROM [CR_Other_Dept] where CirculationNo = '" & Circulation_ & "'"
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_NPWO() As DataTable
        Try
            Dim query As String = "SELECT Distinct No_Npwo as NPWO 
                                  FROM [Npwo_Head] "
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Model() As DataTable
        Try
            Dim query As String = "SELECT Distinct [Model_Name] as Model
                                  FROM [Npwo_Head] "
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_ApproveBOD(Dept As String, Awal As Integer, ahir As Integer) As DataTable
        Try
            Dim query As String = "SELECT A.[No]
                                  ,A.[DeptID]
                                  ,A.[IDApprove]
                                  ,B.ApproveBy
                                  ,B.ApproveName
                              FROM [CR_Approve_Dept_Master] 
                              A inner join CR_Approve_Master B
                              on A.IDApprove = B.IDApprove
                              Where A.[DeptID] = '" & Dept & "' and A.[No] >= '" & Awal & "' and A.[No]<= '" & ahir & "' order by A.no asc "
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Rate(Tahun As String, Bulan As String, Curr As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_Rate]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@Tahun", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Bulan", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Cur", SqlDbType.VarChar)

            pParam(0).Value = Tahun
            pParam(1).Value = Bulan
            pParam(2).Value = Curr

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP_Solomon(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Dept_Sub(Departemen_Sub As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_Sub]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@deptID", SqlDbType.VarChar)

            pParam(0).Value = Departemen_Sub

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)

            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Data_CR_Delete(Circulation As String, Dept As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[Get_Data_CR_Delete]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
            pParam(0) = New SqlClient.SqlParameter("@Circulation", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Dept", SqlDbType.VarChar)

            pParam(0).Value = Circulation
            pParam(1).Value = Dept

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)

            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_Total_Sisa_Budget_Dept(Dept_Sub As String, Account As String, Tahun As String, Bulan As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_Total_Sisa_Budget_Dept]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(3) {}
            pParam(0) = New SqlClient.SqlParameter("@Sub", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Account", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Tahun", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@Bulan", SqlDbType.VarChar)

            pParam(0).Value = Dept_Sub
            pParam(1).Value = Account
            pParam(2).Value = Tahun
            pParam(3).Value = Bulan

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP_Solomon(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Total_CR_Dept(Dept As String, site As String, Account As String, Tahun As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "[CR_Get_Total_CR_Dept]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(3) {}
            pParam(0) = New SqlClient.SqlParameter("@Dept", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Site", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Account", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@Tahun", SqlDbType.VarChar)

            pParam(0).Value = Dept
            pParam(1).Value = site
            pParam(2).Value = Account
            pParam(3).Value = Tahun

            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Sub GetCirculationNoAuto()
        Try
            Dim Tahun As String
            Tahun = Format(Now, "yy")
            Dim Dept As String = gh_Common.GroupID

            Dim ls_SP As String = "SELECT [CirculationNo] FROM [CR_Request] order by CirculationNo desc" 'where IDTrans= " & QVal(IDTrans) & " or TanggalSampai = '" & TanggalDari & "' "
            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand(ls_SP)
            Dim Ulang As String = Tahun
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count <= 0 Then
                H_CirculationNo = "QP" & Tahun & "0001"
            Else
                H_CirculationNo = dtTable.Rows(0).Item("CirculationNo")
                H_CirculationNo = Microsoft.VisualBasic.Mid(H_CirculationNo, 3, 2)
                If H_CirculationNo <> Ulang Then
                    H_CirculationNo = "QP" & Tahun & "0001"
                Else
                    H_CirculationNo = dtTable.Rows(0).Item("CirculationNo")
                    H_CirculationNo = Val(Microsoft.VisualBasic.Mid(H_CirculationNo, 5, 4)) + 1
                    If Len(H_CirculationNo) = 1 Then
                        H_CirculationNo = "QP" & Tahun & "000" & H_CirculationNo & ""
                    ElseIf Len(H_CirculationNo) = 2 Then
                        H_CirculationNo = "QP" & Tahun & "00" & H_CirculationNo & ""
                    ElseIf Len(H_CirculationNo) = 3 Then
                        H_CirculationNo = "QP" & Tahun & "0" & H_CirculationNo & ""
                    Else
                        H_CirculationNo = "QP" & Tahun & H_CirculationNo & ""
                    End If

                End If

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub GetDataByID(ByVal ID As String)
        Try
            Dim query As String = "[CR_Get_Request_ByID]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@Circulation", SqlDbType.VarChar)

            pParam(0).Value = ID


            Dim dt As New DataTable
            dt = GetDataTableByCommand_SP(query, pParam)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    H_CirculationNo = Trim(.Item("CirculationNo") & "")
                    H_RequirementDate = Trim(.Item("RequirementDate") & "")
                    H_DeptID = Trim(.Item("DeptID") & "")
                    H_SiteID = Trim(.Item("SiteID") & "")
                    H_PR = Trim(.Item("PR_No") & "")
                    If .Item("Budget") = "True" Then
                        H_Budget = 1
                    Else
                        H_Budget = 0
                    End If

                    H_Account = Trim(.Item("Account") & "")
                    H_CR_Type = Trim(.Item("CR_Type") & "")
                    H_Currency = Trim(.Item("Currency") & "")
                    ' H_Rate = Trim(.Item("Rate") & "")
                    H_Reason = Trim(.Item("Reason") & "")
                    ' H_RemainingBudget = Trim(.Item("RemainingBudget") & "")
                    'H_CurrentCR = Trim(.Item("CurrentCR") & "")
                    ' H_Balance = Trim(.Item("Balance") & "")
                    H_InvoiceNo = Trim(.Item("InvoiceNo") & "")
                    H_Status = Trim(.Item("Status") & "")
                    H_UserSubmition = Trim(.Item("UserSubmition") & "")
                    'H_DeptHead_ID = Trim(.Item("") & "")
                    'H_DeptHead_Name = Trim(.Item("") & "")
                    'H_DeptHead_Opinion = Trim(.Item("") & "")
                    H_DeptHead_Approve = Trim(.Item("DeptHead_Approve") & "")
                    'H_DeptHead_Approve_Date = Trim(.Item("") & "")
                    'H_DivHead_ID = Trim(.Item("") & "")
                    'H_DivHead_Name = Trim(.Item("") & "")
                    'H_DivHead_Opinion = Trim(.Item("") & "")
                    H_DivHead_Approve = Trim(.Item("DivHead_Approve") & "")
                    'H_DivHead_Approve_Date = Trim(.Item("") & "")
                    'H_Status = Trim(.Item("") & "")
                    H_Parent_Circulation = Trim(.Item("Parent_Circuation") & "")
                    H_Parent_Circulation_Amount = Trim(.Item("Parent_Circuation_Amount") & "")
                    H_Dies_Sales_Type = Trim(.Item("Dies_Sales_Type") & "")
                    H_Dies_Customer_Name = Trim(.Item("Dies_Customer_Name") & "")
                    H_Dies_Model = Trim(.Item("Dies_Model_Name") & "")
                    H_Dies_Remark = Trim(.Item("Dies_Remark") & "")
                    H_NameItem = Trim(.Item("NameItem") & "")
                    H_Spesification = Trim(.Item("Spesification") & "")
                    H_PO = Trim(.Item("PoType") & "")
                    If Trim(.Item("ChargedOfCustomer") & "") = "0" Then
                        H_ChargedOf = 0
                    Else
                        H_ChargedOf = 1
                    End If


                    If .Item("ChargedOfCustomer") = "True" Then
                        H_ChargedOf = 1
                    Else
                        H_ChargedOf = 0
                    End If

                End With
            Else

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub



    Public Sub Delete(CirculationNo As String, Dept_ As String)
        Try
            Try


                Dim query As String = "[CR_Delete_CR_Request]"
                Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}
                pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
                pParam(1) = New SqlClient.SqlParameter("@Dept", SqlDbType.VarChar)

                pParam(0).Value = CirculationNo
                pParam(1).Value = Dept_

                'Dim dtTable As New DataTable
                'dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
                MainModul.ExecQueryByCommand_SP(query, pParam)
            Catch ex As Exception
                Throw
            End Try

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub Delete_Approve(CirculationNo As String)
        Try
            Try


                Dim query As String = "Delete From [CR_Approve] Where CirculationNo = '" & CirculationNo & "' "

                'Dim dtTable As New DataTable
                'dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
                'MainModul.ExecQueryByCommand_SP(query, pParam)
                MainModul.ExecQueryByCommand(query)
            Catch ex As Exception
                Throw
            End Try

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Delete_Detail(CirculationNo As String)
        Try
            Try


                Dim query As String = "[CR_Delete_CR_Request_Detail]"
                Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
                pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)

                pParam(0).Value = CirculationNo

                'Dim dtTable As New DataTable
                'dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
                MainModul.ExecQueryByCommand_SP(query, pParam)
            Catch ex As Exception
                Throw
            End Try

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Delete_Installment(CirculationNo As String)
        Try
            Try

                Dim query As String = "Delete From [CR_Installment] Where CirculationNo = '" & CirculationNo & "' "
                MainModul.ExecQueryByCommand(query)

            Catch ex As Exception
                Throw
            End Try

        Catch ex As Exception
            Throw
        End Try
    End Sub



#Region "CRUD"

    Public Sub InsertTemp()
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try

                        For i As Integer = 0 To Collection_BomT1.Count - 1
                            With Collection_BomT1(i)
                                .InsertCR_BomTemp()
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

    Public Sub UpdateAprove(NoSirkulasi As String, Active_Form As Integer)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        'InsertHistory(NPWO_)

                        If Active_Form = 2 Then
                            Update_Approve(H_CirculationNo,
                                         H_UserSubmition,
                                         H_DeptHead_Approve,
                                         H_DeptHead_Approve_Date,
                                         H_DivHead_Approve,
                                         H_DivHead_Approve_Date,
                                         H_Status)



                            For i As Integer = 0 To Collection_Description_Of_Cost.Count - 1
                                With Collection_Description_Of_Cost(i)
                                    .Update_DOC_Approve(NoSirkulasi)
                                End With
                            Next

                            Delete_Approve(H_CirculationNo)

                            For a As Integer = 0 To Collection_Approve.Count - 1
                                With Collection_Approve(a)
                                    .Insert_Approve(NoSirkulasi)
                                End With
                            Next

                        ElseIf Active_Form = 3 Then

                            Update_Approve(H_CirculationNo,
                                             H_UserSubmition,
                                             H_DeptHead_Approve,
                                             H_DeptHead_Approve_Date,
                                             H_DivHead_Approve,
                                             H_DivHead_Approve_Date,
                                             H_Status)



                        End If



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
    Public Sub Update(NoSirkulasi As String)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try
                        'InsertHistory(NPWO_)

                        Update_CrRequest(H_CirculationNo,
                                         H_RequirementDate,
                                         gh_Common.GroupID,
                                         gh_Common.Site,
                                         H_Budget,
                                         H_CR_Type,
                                         H_Reason,
                                         H_Status,
                                         H_Parent_Circulation,
                                         H_Parent_Circulation_Amount,
                                         gh_Common.Username,
                                         Date.Now,
                                         H_Dies_Sales_Type,
                                         H_Dies_Customer_Name,
                                         H_Dies_Model,
                                         H_Dies,
                                         H_Dies_Remark,
                                         H_ChargedOf,
                                         H_NameItem,
                                         H_Spesification,
                                         H_PO)

                        Delete_Detail(NoSirkulasi)

                        For i As Integer = 0 To Collection_Description_Of_Cost.Count - 1
                            With Collection_Description_Of_Cost(i)
                                .InsertCR_Description_Of_Cost(NoSirkulasi)
                            End With
                        Next

                        For i As Integer = 0 To Collection_Other_Dept.Count - 1
                            With Collection_Other_Dept(i)
                                .InsertCR_Other_Dept(NoSirkulasi)
                            End With
                        Next

                        For i As Integer = 0 To Collection_Installment.Count - 1
                            With Collection_Installment(i)
                                .InsertCR_Installment(NoSirkulasi)
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


    Public Sub UpdateInstallMent(NoSirkulasi As String)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try

                        Delete_Installment(NoSirkulasi)

                        For i As Integer = 0 To Collection_Installment.Count - 1
                            With Collection_Installment(i)
                                .InsertCR_Installment(NoSirkulasi)
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


    Public Sub Insert(NoSirkualasi As String)
        Try
            Using Conn1 As New SqlClient.SqlConnection(GetConnString)
                Conn1.Open()
                Using Trans1 As SqlClient.SqlTransaction = Conn1.BeginTransaction
                    gh_Trans = New InstanceVariables.TransactionHelper
                    gh_Trans.Command.Connection = Conn1
                    gh_Trans.Command.Transaction = Trans1

                    Try


                        Insert_CrRequest(H_CirculationNo,
                                         H_RequirementDate,
                                         gh_Common.GroupID,
                                         gh_Common.Site,
                                         H_Budget,
                                         H_CR_Type,
                                         H_Reason,
                                         H_UserSubmition,
                                         H_Status,
                                         H_Parent_Circulation,
                                         H_Parent_Circulation_Amount,
                                         gh_Common.Username,
                                         Date.Now,
                                         H_Dies_Sales_Type,
                                         H_Dies_Customer_Name,
                                         H_Dies_Model,
                                         H_Dies,
                                         H_Dies_Remark,
                                         H_ChargedOf,
                                         H_InvoiceNo,
                                         H_InvoiceStatus,
                                         H_NameItem,
                                         H_Spesification,
                                         H_PO)


                        For i As Integer = 0 To Collection_Description_Of_Cost.Count - 1
                            With Collection_Description_Of_Cost(i)
                                .InsertCR_Description_Of_Cost(NoSirkualasi)
                            End With
                        Next

                        For i As Integer = 0 To Collection_Other_Dept.Count - 1
                            With Collection_Other_Dept(i)
                                .InsertCR_Other_Dept(NoSirkualasi)
                            End With
                        Next

                        For i As Integer = 0 To Collection_Installment.Count - 1
                            With Collection_Installment(i)
                                .InsertCR_Installment(NoSirkualasi)
                            End With
                        Next

                        'Insert_Bom(H_CirculationNo)



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


    Public Sub Insert_CrRequest(CirculationNo As String,
                                RequirementDate As Date,
                                DeptID As String,
                                SiteID As String,
                                Budget As Integer,
                                CR_Type As String,
                                Reason As String,
                                UserSubmition As Integer,
                                Status As String,
                                Parent As String,
                                ParentAmount As Double,
                                CreatedBy As String,
                                CreatedDate As Date,
                                Sales_Type As String,
                                Customer_Name As String,
                                Model As String,
                                Dies As Int32,
                                DiesRemark As String,
                                ChangedOf As Int32,
                                InvoiceNo As String,
                                InvoiceStatus As Int32,
                                NameItem As String,
                                Spesification As String,
                                PoType As Boolean)


        Dim result As Integer = 0
        Try
            If Parent = "" Then
                Parent = DBNull.Value.ToString
            End If

            If Sales_Type = "" Then
                Sales_Type = DBNull.Value.ToString
            End If

            If Customer_Name = "" Then
                Customer_Name = DBNull.Value.ToString
            End If

            If Model = "" Then
                Model = DBNull.Value.ToString
            End If

            If DiesRemark = "" Then
                DiesRemark = DBNull.Value.ToString
            End If

            If InvoiceNo = "" Then
                InvoiceNo = DBNull.Value.ToString
            End If

            If DiesRemark = "" Then
                DiesRemark = DBNull.Value.ToString
            End If

            If NameItem = "" Then
                NameItem = DBNull.Value.ToString
            End If

            If Spesification = "" Then
                Spesification = DBNull.Value.ToString
            End If

            If Reason = "" Then
                Reason = DBNull.Value.ToString
            End If


            Dim query As String = "[CR_Insert_CrRequest]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(23) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@RequirementDate", SqlDbType.Date)
            pParam(2) = New SqlClient.SqlParameter("@DeptID", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@SiteID", SqlDbType.VarChar)
            pParam(4) = New SqlClient.SqlParameter("@Budget", SqlDbType.Int)
            pParam(5) = New SqlClient.SqlParameter("@CR_Type", SqlDbType.VarChar)
            pParam(6) = New SqlClient.SqlParameter("@Reason", SqlDbType.VarChar)
            pParam(7) = New SqlClient.SqlParameter("@UserSubmition", SqlDbType.Int)
            pParam(8) = New SqlClient.SqlParameter("@Status", SqlDbType.VarChar)
            pParam(9) = New SqlClient.SqlParameter("@Parent", SqlDbType.VarChar)
            pParam(10) = New SqlClient.SqlParameter("@ParentAmount ", SqlDbType.Float)
            pParam(11) = New SqlClient.SqlParameter("@CreatedBy", SqlDbType.VarChar)
            pParam(12) = New SqlClient.SqlParameter("@CreatedDate ", SqlDbType.Date)
            pParam(13) = New SqlClient.SqlParameter("@SalesType ", SqlDbType.VarChar)
            pParam(14) = New SqlClient.SqlParameter("@CustomerName ", SqlDbType.VarChar)
            pParam(15) = New SqlClient.SqlParameter("@Model ", SqlDbType.VarChar)
            pParam(16) = New SqlClient.SqlParameter("@Dies ", SqlDbType.Int)
            pParam(17) = New SqlClient.SqlParameter("@DiesRemark ", SqlDbType.VarChar)
            pParam(18) = New SqlClient.SqlParameter("@ChargedOf ", SqlDbType.Int)
            pParam(19) = New SqlClient.SqlParameter("@InvoiceNo ", SqlDbType.VarChar)
            pParam(20) = New SqlClient.SqlParameter("@InvoiceStatus ", SqlDbType.Int)
            pParam(21) = New SqlClient.SqlParameter("@NameItem ", SqlDbType.VarChar)
            pParam(22) = New SqlClient.SqlParameter("@Spesification ", SqlDbType.VarChar)
            pParam(23) = New SqlClient.SqlParameter("@POType ", SqlDbType.Bit)

            pParam(0).Value = CirculationNo
            pParam(1).Value = RequirementDate
            pParam(2).Value = DeptID
            pParam(3).Value = SiteID
            pParam(4).Value = Budget
            pParam(5).Value = CR_Type
            pParam(6).Value = Reason
            pParam(7).Value = UserSubmition
            pParam(8).Value = Status
            pParam(9).Value = Parent
            pParam(10).Value = ParentAmount
            pParam(11).Value = CreatedBy
            pParam(12).Value = CreatedDate
            pParam(13).Value = Sales_Type
            pParam(14).Value = Customer_Name
            pParam(15).Value = Model
            pParam(16).Value = Dies
            pParam(17).Value = DiesRemark
            pParam(18).Value = ChangedOf
            pParam(19).Value = InvoiceNo
            pParam(20).Value = InvoiceStatus
            pParam(21).Value = NameItem
            pParam(22).Value = Spesification
            pParam(23).Value = PoType


            'Dim dtTable As New DataTable
            'dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
            MainModul.ExecQueryByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub ValidateInsert()
        Try
            'Dim ls_SP As String = "SELECT TOP 1 [IDTransaksi],Tanggal                   
            '                        FROM [AsakaiQualityProblem] where Tanggal = '" & H_Tanggal & "' "
            'Dim dtTable As New DataTable
            ''dtTable = MainModul.GetDataTableByCommand(ls_SP)
            'dtTable = MainModul.GetDataTableByCommand(ls_SP)
            'If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
            '    Err.Raise(ErrNumber, , GetMessage(MessageEnum.InsertGagal) &
            '    "[" & Format(Me.H_Tanggal, "dd-MM-yyyy") & "]")
            'Else

            'End If

        Catch ex As Exception
            Throw
        End Try
    End Sub


#End Region

    Public Sub Insert_Bom(CirculationNo As String)
        Dim result As Integer = 0


        Try

            Dim query As String = "[CR_BOM_Insert]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)

            pParam(0).Value = CirculationNo

            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub Update_Approve_BOD(CirculationNo As String)

        Try


            Dim ls_SP As String = " " & vbCrLf &
                                        "UPDATE CR_Request" & vbCrLf &
                                        "SET [BOD_Approve] = '" & H_BOD_Approve & "'
                                            ,[Status] = '" & H_Status & "'
                                            ,[BOD_User] = '" & H_BOD_User & "'
                                            ,[BOD_Date] = '" & H_BOD_Approve_Date & "' 
                                        WHERE [CirculationNo] = '" & CirculationNo & "'"
            MainModul.ExecQuery(ls_SP)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub Update_Berita_Acara(Act As Int16)

        Try
            If Act = 1 Then
                Dim ls_SP As String = "INSERT INTO [CR_BeritaAcara]
                                               ([CirculationNo]
                                               ,[NoBeritaAcara]
                                               ,[TanggalBeritaAcara])
                                         VALUES
                                               ('" & H_CirculationNo & "'
                                               ,'" & H_NoBeritaAcara & "'
                                               ,'" & H_TanggalBeritaAcara & "')"
                MainModul.ExecQuery(ls_SP)

            ElseIf Act = 2 Then
                Dim ls_SP As String = "UPDATE [CR_BeritaAcara]
                                       SET [NoBeritaAcara] = '" & H_NoBeritaAcara & "'
                                          ,[TanggalBeritaAcara] = '" & H_TanggalBeritaAcara & "'
                                     WHERE [CirculationNo] = '" & H_CirculationNo & "'"
                MainModul.ExecQuery(ls_SP)

            ElseIf Act = 3 Then

                Dim ls_SP As String = "Delete From [CR_BeritaAcara]
                                     WHERE [CirculationNo] = '" & H_CirculationNo & "'"
                MainModul.ExecQuery(ls_SP)

            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub


    Public Sub Update_Approve(CirculationNo As String,
                                UserSubmit As Boolean,
                                DeptApprove As Boolean,
                                DeptApproveDate As Date,
                                DivApprove As Boolean,
                                DivApproveDate As Date,
                                Status As String)

        Dim result As Integer = 0
        Try
            If Status = "" Then
                Status = DBNull.Value.ToString
            End If

            Dim query As String = "[CR_Update_Approve]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(6) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo ", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@UserSubmit", SqlDbType.Bit)
            pParam(2) = New SqlClient.SqlParameter("@DeptApprove", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@DeptApproveDate", SqlDbType.Date)
            pParam(4) = New SqlClient.SqlParameter("@DivApprove", SqlDbType.VarChar)
            pParam(5) = New SqlClient.SqlParameter("@DivApproveDate", SqlDbType.Date)
            pParam(6) = New SqlClient.SqlParameter("@Status", SqlDbType.VarChar)


            pParam(0).Value = CirculationNo
            pParam(1).Value = UserSubmit
            pParam(2).Value = DeptApprove
            pParam(3).Value = DeptApproveDate
            pParam(4).Value = DivApprove
            pParam(5).Value = DivApproveDate
            pParam(6).Value = Status


            MainModul.ExecQueryByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub



    Public Sub Update_CrRequest(CirculationNo As String,
                                RequirementDate As Date,
                                DeptID As String,
                                SiteID As String,
                                Budget As Integer,
                                CR_Type As String,
                                Reason As String,
                                Status As String,
                                Parent As String,
                                ParentAmount As Double,
                                UpdateBy As String,
                                UpdateDate As Date,
                                Sales_Type As String,
                                Customer_Name As String,
                                Model As String,
                                Dies As Int32,
                                DiesRemark As String,
                                ChangedOf As Int32,
                                NameItem As String,
                                Spesification As String,
                                PO As Boolean)

        Dim result As Integer = 0
        Try
            If Parent = "" Then
                Parent = DBNull.Value.ToString
            End If

            If Sales_Type = "" Then
                Sales_Type = DBNull.Value.ToString
            End If

            If Customer_Name = "" Then
                Customer_Name = DBNull.Value.ToString
            End If

            If Model = "" Then
                Model = DBNull.Value.ToString
            End If

            If DiesRemark = "" Then
                DiesRemark = DBNull.Value.ToString
            End If

            If DiesRemark = "" Then
                DiesRemark = DBNull.Value.ToString
            End If

            If NameItem = "" Then
                NameItem = DBNull.Value.ToString
            End If

            If Spesification = "" Then
                Spesification = DBNull.Value.ToString
            End If



            Dim query As String = "[CR_Update_CrRequest]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(20) {}
            pParam(0) = New SqlClient.SqlParameter("@ChargedOf ", SqlDbType.Int)
            pParam(1) = New SqlClient.SqlParameter("@RequirementDate", SqlDbType.Date)
            pParam(2) = New SqlClient.SqlParameter("@DeptID", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@SiteID", SqlDbType.VarChar)
            pParam(4) = New SqlClient.SqlParameter("@Budget", SqlDbType.Int)
            pParam(5) = New SqlClient.SqlParameter("@CR_Type", SqlDbType.VarChar)
            pParam(6) = New SqlClient.SqlParameter("@Reason", SqlDbType.VarChar)
            pParam(7) = New SqlClient.SqlParameter("@Status", SqlDbType.VarChar)
            pParam(8) = New SqlClient.SqlParameter("@Parent", SqlDbType.VarChar)
            pParam(9) = New SqlClient.SqlParameter("@ParentAmount ", SqlDbType.Float)
            pParam(10) = New SqlClient.SqlParameter("@UpdateBy", SqlDbType.VarChar)
            pParam(11) = New SqlClient.SqlParameter("@UpdateDate ", SqlDbType.Date)
            pParam(12) = New SqlClient.SqlParameter("@SalesType ", SqlDbType.VarChar)
            pParam(13) = New SqlClient.SqlParameter("@CustomerName ", SqlDbType.VarChar)
            pParam(14) = New SqlClient.SqlParameter("@Model ", SqlDbType.VarChar)
            pParam(15) = New SqlClient.SqlParameter("@Dies ", SqlDbType.Int)
            pParam(16) = New SqlClient.SqlParameter("@DiesRemark ", SqlDbType.VarChar)
            pParam(17) = New SqlClient.SqlParameter("@CirculationNo ", SqlDbType.VarChar)
            pParam(18) = New SqlClient.SqlParameter("@NameItem ", SqlDbType.VarChar)
            pParam(19) = New SqlClient.SqlParameter("@Spesification ", SqlDbType.VarChar)
            pParam(20) = New SqlClient.SqlParameter("@PO ", SqlDbType.Bit)

            pParam(0).Value = ChangedOf
            pParam(1).Value = RequirementDate
            pParam(2).Value = DeptID
            pParam(3).Value = SiteID
            pParam(4).Value = Budget
            pParam(5).Value = CR_Type
            pParam(6).Value = Reason
            pParam(7).Value = Status
            pParam(8).Value = Parent
            pParam(9).Value = ParentAmount
            pParam(10).Value = UpdateBy
            pParam(11).Value = UpdateDate
            pParam(12).Value = Sales_Type
            pParam(13).Value = Customer_Name
            pParam(14).Value = Model
            pParam(15).Value = Dies
            pParam(16).Value = DiesRemark
            pParam(17).Value = CirculationNo
            pParam(18).Value = NameItem
            pParam(19).Value = Spesification
            pParam(20).Value = PO

            MainModul.ExecQueryByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Public Sub UpdateUserSubmit(ByVal _FsCode As String)
        Try
            Dim ls_SP As String = " " & vbCrLf &
                                    "UPDATE CR_Request" & vbCrLf &
                                    "SET [UserSubmition] = '" & H_UserSubmition & "'
                                    ,[Status] = 'Submit' WHERE [CirculationNo] = '" & _FsCode & "'"
            MainModul.ExecQuery(ls_SP)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub




#Region "Laporan"

    Public Function Cek_CR_Report(CirculationNo As String) As DataTable
        Try
            'Dim query As String = "[Generate_Report_Matome]"
            Dim query As String = "select a.CirculationNo
	                              ,a.DeptID
	                              ,a.UserSubmition
	                              ,a.DeptHead_Approve
	                              ,a.DivHead_Approve
	                              ,b.Approve
	                              from CR_Request a inner join CR_Other_Dept b 
	                              on a.CirculationNo = b.CirculationNo Where a.CirculationNo = '" & CirculationNo & "'"
            'Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            'pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            'pParam(0).Value = CirculationNo
            Dim dt As New DataTable
            dt = GetDataTableByCommand(query)
            Return dt
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function RptCirculation(No As String) As DataSet
        Dim query As String
        'Dim NP As String = "TSC/NPP/MKT/04/SIM-Y98/2020/001"
        query = "SELECT [CR_Request].[CirculationNo]
                  ,[CR_Request].[DeptID]
                  ,[CR_Request].[CR_Type]
                  ,[CR_Request].[Budget]
                  ,[CR_Request].[Dies_Model_Name]
                  ,[CR_Request].[Reason]
                  ,[CR_Request].[DeptHead_Name]
                  ,[CR_Request].[DivHead_Name]
                  ,[CR_Request].[CreatedBy]
                  ,[CR_Request].[NameItem]
                  ,[CR_Request].[PoType]
                  ,[CR_Request].[UserSubmitionDate]
                  ,[CR_Request].[DeptHead_Approve_Date]
                  ,[CR_Request].[DivHead_Approve_Date]
                  ,[CR_Request].[Spesification] as H_Spesification
                  ,[CR_Request].[RequirementDate]
                  ,[CR_Description_Of_Cost].[Name_Of_Goods]
                  ,[CR_Description_Of_Cost].[Spesification]
                  ,[CR_Description_Of_Cost].[Account] 
                  ,[CR_Description_Of_Cost].[RemainingBudget]
                  ,[CR_Description_Of_Cost].[Qty]
                  ,[CR_Description_Of_Cost].[Price]
                  ,[CR_Description_Of_Cost].[Currency]
                  ,[CR_Description_Of_Cost].[Rate]
                  ,[CR_Description_Of_Cost].[Amount]
                  ,[CR_Description_Of_Cost].[Category]
                  ,[CR_Description_Of_Cost].[Amount_IDR]
                From [CR_Request] inner join CR_Description_Of_Cost 
                on [CR_Request].[CirculationNo] = [CR_Description_Of_Cost].[CirculationNo]
	            Where [CR_Request].[CirculationNo] = '" & No & "'
                order by Id Asc "

        Dim ds As New dsLaporan
        ds = GetDsReport(query, "CirculationHead")
        Return ds

        'Mold_Number

    End Function

    Public Function RptCirculationTotalDOC(No As String) As DataSet
        Dim query As String
        query = "SELECT Currency, 
                    SUM (Amount) as Amount
                    ,Rate
                 FROM CR_Description_Of_Cost 
                    where CirculationNo='" & No & "'
                 GROUP BY Currency,rate"

        Dim ds As New dsLaporan
        ds = GetDsReport(query, "CirculationTotalDOC")
        Return ds
    End Function



    Public Function RptCirculation_OtherDept(No As String) As DataSet
        Dim query As String
        'Dim NP As String = "TSC/NPP/MKT/04/SIM-Y98/2020/001"
        query = "SELECT [CirculationNo]
                      ,[DeptID]
                      ,[DeptHead_ID]
                      ,[DeptHead_Name]
                      ,[DeptHead_Email]
                      ,[Date]
                      ,[Opinion]
                      ,[Approve]
                  FROM [CR_Other_Dept]
	            Where[CirculationNo] = '" & No & "'"

        Dim ds1 As New dsLaporan
        ds1 = GetDsReport(query, "CirculationOtherDept")
        Return ds1

        'Mold_Number

    End Function


    Public Function RptCirculation_Approve(No As String) As DataSet
        Dim query As String
        'Dim NP As String = "TSC/NPP/MKT/04/SIM-Y98/2020/001"
        query = "Select [CirculationNo]
                      ,[No]
                      ,[ApproveBy]
                      ,[ApproveName]
                  FROM [CR_Approve]
	            Where[CirculationNo] = '" & No & "'"

        Dim ds1 As New dsLaporan
        ds1 = GetDsReport(query, "CirculationApprove")
        Return ds1

        'Mold_Number

    End Function

#End Region




End Class








Public Class ClsCR_Description_of_Cost

    Public Property D_CirculationNo As String
    Public Property D_Name_Of_Goods As String
    Public Property D_Spesification As String
    Public Property D_Qty As Double
    Public Property D_Price As Double
    Public Property D_Currency As String
    Public Property D_Rate As Double
    Public Property D_Amount As Double
    Public Property D_Amount_IDR As Double
    Public Property D_PR_No As String
    Public Property D_RemainingBudget As Double
    Public Property D_Account As String
    Public Property D_Category As String
    Public Property D_Check As String
    Public Property D_Note As String
    Public Property D_Id As Integer


    Public Sub InsertCR_Description_Of_Cost(CirculationNo As String)

        Try

            Dim query As String = "[CR_Insert_Description_Of_Cost]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(14) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Name_Of_Goods", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Spesification", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@Qty", SqlDbType.Float)
            pParam(4) = New SqlClient.SqlParameter("@Price", SqlDbType.Float)
            pParam(5) = New SqlClient.SqlParameter("@Currency", SqlDbType.VarChar)
            pParam(6) = New SqlClient.SqlParameter("@Rate", SqlDbType.Float)
            pParam(7) = New SqlClient.SqlParameter("@Amount", SqlDbType.Float)
            pParam(8) = New SqlClient.SqlParameter("@Amount_IDR", SqlDbType.Float)
            pParam(9) = New SqlClient.SqlParameter("@PR_No", SqlDbType.VarChar)
            pParam(10) = New SqlClient.SqlParameter("@RemainingBudget", SqlDbType.Float)
            pParam(11) = New SqlClient.SqlParameter("@Account", SqlDbType.VarChar)
            pParam(12) = New SqlClient.SqlParameter("@Category", SqlDbType.VarChar)
            pParam(13) = New SqlClient.SqlParameter("@Check", SqlDbType.VarChar)
            pParam(14) = New SqlClient.SqlParameter("@Note", SqlDbType.VarChar)


            pParam(0).Value = CirculationNo
            pParam(1).Value = D_Name_Of_Goods
            pParam(2).Value = D_Spesification
            pParam(3).Value = D_Qty
            pParam(4).Value = D_Price
            pParam(5).Value = D_Currency
            pParam(6).Value = D_Rate
            pParam(7).Value = D_Amount
            pParam(8).Value = D_Amount_IDR
            pParam(9).Value = D_PR_No
            pParam(10).Value = D_RemainingBudget
            pParam(11).Value = D_Account
            pParam(12).Value = D_Category
            pParam(13).Value = D_Check
            pParam(14).Value = D_Note


            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Public Sub Update_DOC_Approve(CirculationNo As String)

        Try

            Dim query As String = "[CR_Update_DOC_Approve]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(3) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
            pParam(2) = New SqlClient.SqlParameter("@Check", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@Note", SqlDbType.VarChar)

            pParam(0).Value = CirculationNo
            pParam(1).Value = D_Id
            pParam(2).Value = D_Check
            pParam(3).Value = D_Note


            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub

End Class

Public Class ClsCR_Other_Dept

    Public Property D_CirculationNo As String
    Public Property D_Dept As String
    Public Property D_UserName As String
    Public Property D_Name As String
    Public Property D_Date As Date
    Public Property D_Opinion As String
    Public Property D_Approve As Int32

    Public Sub InsertCR_Other_Dept(CirculationNo As String)



        Try

            Dim query As String = "[CR_Insert_Other_Dept]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@DeptID", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@Approve", SqlDbType.Bit)

            pParam(0).Value = CirculationNo
            pParam(1).Value = D_Dept
            pParam(2).Value = D_Approve


            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Public Sub UpdateOtherDept(ByVal _FsCode As String, ByVal _Dept As String)
        Try
            Dim ls_SP As String = " " & vbCrLf &
                                    "UPDATE CR_Other_Dept" & vbCrLf &
                                    "SET [Date] = '" & D_Date & "'
                                    ,[Opinion] = '" & D_Opinion & "' 
                                    ,[Approve] = '" & D_Approve & "'
                                    WHERE [CirculationNo] = '" & _FsCode & "' and [DeptID] = '" & _Dept & "' "
            MainModul.ExecQuery(ls_SP)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class

Public Class ClsCR_Installment
    Public Property D_CirculationNo As String
    Public Property D_Term As Integer
    Public Property D_Date As Date
    Public Property D_Amount As Double
    Public Property D_Percent As Double
    Public Property D_Curr As String
    Public Property D_Value As Double

    Public Sub InsertCR_Installment(CirculationNo As String)
        Try

            Dim query As String = "[CR_Insert_Installment]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}
            pParam(0) = New SqlClient.SqlParameter("@CirculationNo", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@Term", SqlDbType.Int)
            pParam(2) = New SqlClient.SqlParameter("@Date", SqlDbType.Date)
            pParam(3) = New SqlClient.SqlParameter("@Percent", SqlDbType.Float)
            pParam(4) = New SqlClient.SqlParameter("@Curr", SqlDbType.VarChar)
            pParam(5) = New SqlClient.SqlParameter("@Value", SqlDbType.Float)

            pParam(0).Value = CirculationNo
            pParam(1).Value = D_Term
            pParam(2).Value = D_Date
            pParam(3).Value = D_Percent
            pParam(4).Value = D_Curr
            pParam(5).Value = D_Value

            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try

    End Sub


End Class

Public Class ClsCR_BomT1
    Public Property D_T1 As String
    Public Property D_PartNo As String
    Public Property D_ParName As String
    Public Property D_Qty As Double


    Public Sub InsertCR_BomTemp()
        Try

            Dim query As String = "[CR_BOM_Insert_Temp]"
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(3) {}
            pParam(0) = New SqlClient.SqlParameter("@T1", SqlDbType.VarChar)
            pParam(1) = New SqlClient.SqlParameter("@PartNo", SqlDbType.VarChar)
            pParam(2) = New SqlClient.SqlParameter("@PartName", SqlDbType.VarChar)
            pParam(3) = New SqlClient.SqlParameter("@Qty", SqlDbType.Float)

            pParam(0).Value = D_T1
            pParam(1).Value = D_PartNo
            pParam(2).Value = D_ParName
            pParam(3).Value = D_Qty

            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand_SP(query, pParam)
        Catch ex As Exception
            Throw
        End Try
    End Sub


End Class

Public Class ClsCR_Approve
    Public Property D_Circulation As String
    Public Property D_No As Int32
    Public Property D_ApproveBy As String
    Public Property D_ApproveName As String

    Public Sub Insert_Approve(CirculationNo As String)

        Try

            Dim query As String = "insert into [CR_Approve] 
                                    ([CirculationNo]
                                   ,[No]
                                   ,[ApproveBy]
                                   ,[ApproveName]) 
                                    values 
                                    ( '" & CirculationNo & "'
                                       , '" & D_No & "'
                                       , '" & D_ApproveBy & "'
                                       , '" & D_ApproveName & "')
                                    "

            Dim dtTable As New DataTable
            dtTable = MainModul.GetDataTableByCommand(query)
        Catch ex As Exception
            Throw
        End Try

    End Sub


End Class

