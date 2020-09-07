Public Class frmAdvanceApprove
    Dim _approved As New List(Of String)
    Public Sub New(Approve As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()
        _approved = Approve
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Property Approve() As String
    Public Property Comment() As String


    Private Sub frmAdvanceApprove_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtApproved.Properties.Items.Clear()
        txtApproved.Properties.Items.AddRange(_approved)
        txtApproved.SelectedIndex = 0
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If txtComment.Text = "" AndAlso Not txtApproved.Text.ToLower.Contains("approve") Then
                Throw New Exception("Silahkan isi commentnya dulu!")
            Else
                Approve = txtApproved.Text
                Comment = txtComment.Text
                Hide()
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class