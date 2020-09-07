Public Class frmAdvanceSearch
    Dim _Stat As New List(Of String)
    Public Sub New(Status As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()
        _Stat = Status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Property TglDari() As String
    Public Property TglSampai() As String
    Public Property Status() As String


    Private Sub frmAdvanceSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As New DateTime(DateTime.Now.Year, 1, 1)
        TxtTglDari.EditValue = year
        TxtTglSampai.EditValue = Date.Today
        CmbStatus.Properties.Items.Clear()
        CmbStatus.Properties.Items.AddRange(_Stat)
        CmbStatus.SelectedIndex = 0
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            TglDari = Format(TxtTglDari.EditValue, gs_FormatSQLDate)
            TglSampai = Format(TxtTglSampai.EditValue, gs_FormatSQLDate)
            Status = CmbStatus.Text

            Hide()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
End Class