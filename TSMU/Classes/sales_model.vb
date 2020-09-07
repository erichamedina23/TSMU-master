Public Class sales_model
    Public Function SalesLoadDataGrid(Perpost As String) As DataTable
        Try
            If Not IsNumeric(Perpost) Then
                Throw New Exception("Perpost harus angka!, Ex. : 202006")
            End If
            Dim query As String = String.Empty
            Dim _perPost As Integer = Convert.ToInt32(Perpost)
            Dim Batas As Integer = 202005
            If _perPost > Batas Then
                query = "Stp_Sales_202006"
            Else
                query = "Stp_Sales"
            End If

            'Exit Function
            Dim pParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}
            pParam(0) = New SqlClient.SqlParameter("@PerPost", SqlDbType.VarChar)
            pParam(0).Value = Perpost

            Dim dt As New DataTable
            dt = MainModul.GetDataTableByCommand_SP_Solomon(query, pParam)

            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
