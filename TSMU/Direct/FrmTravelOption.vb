Public Class FrmTravelOption

    Dim value As String
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal strCode As String)
        ' this call is required by the windows form designer
        Me.New()

    End Sub

    ReadOnly Property Values() As String
        Get
            Return value
        End Get
    End Property

    Private Sub FrmTravelOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTanya.Text = "Ingin Ambil Currency Apa ?" & (Chr(10)) & "USD/YEN"
        radioUSD.Checked = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If radioUSD.Checked = True Then
            value = radioUSD.Text
        ElseIf radioYEN.Checked = True Then
            value = radioYEN.Text
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        value = radioUSD.Text
    End Sub
End Class