Public Class frmSearch

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Property TglDari() As Date
    Public Property TglSampai() As Date


    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTglDari.EditValue = Date.Today
        TxtTglSampai.EditValue = Date.Today
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            TglDari = TxtTglDari.EditValue
            TglSampai = TxtTglSampai.EditValue
            Hide()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
End Class