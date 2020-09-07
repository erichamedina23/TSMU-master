Imports DevExpress.XtraGrid

Public Class Frm_CR_BeritaAcara_Input
    Dim fc_Class As New ClsCR_CreateUser

    Dim NoCirculation As String
    Dim NoBeritaAcara As String
    Dim Dt As DataTable


    Public Sub New(ByVal _NoCirculation As String,
                   ByVal _NoBeritaAcara As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



        NoCirculation = _NoCirculation
        NoBeritaAcara = _NoBeritaAcara

    End Sub

    Private Sub Frm_CR_BeritaAcara_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt = New DataTable
        Dt = fc_Class.GetBeritaAcara(NoCirculation)

        If Dt.Rows.Count = 0 Then
            T_Circulation.EditValue = NoCirculation
        Else
            T_Circulation.EditValue = NoCirculation
            T_BeritaAcara.EditValue = Dt.Rows(0).Item("NoBeritaAcara")
            T_TanggalBeritaAcara.EditValue = Dt.Rows(0).Item("TanggalBeritaAcara")

        End If


    End Sub

    Private Sub B_Save_Click(sender As Object, e As EventArgs) Handles B_Save.Click

        Dim dt As New DataTable
        dt = fc_Class.GetBeritaAcara(T_Circulation.EditValue)

        If dt.Rows.Count <= 0 Then
            fc_Class.H_CirculationNo = T_Circulation.EditValue
            fc_Class.H_NoBeritaAcara = T_BeritaAcara.EditValue
            fc_Class.H_TanggalBeritaAcara = T_TanggalBeritaAcara.EditValue
            fc_Class.Update_Berita_Acara(1)
            MessageBox.Show("Data Das Been Saved", "Information")
            Me.Close()

        Else
            fc_Class.H_CirculationNo = T_Circulation.EditValue
            fc_Class.H_NoBeritaAcara = T_BeritaAcara.EditValue
            fc_Class.H_TanggalBeritaAcara = T_TanggalBeritaAcara.EditValue
            fc_Class.Update_Berita_Acara(2)
            MessageBox.Show("Data Das Been Saved", "Information")
            Me.Close()

        End If



    End Sub

    Private Sub B_Cancel_Click(sender As Object, e As EventArgs) Handles B_Cancel.Click
        Me.Close()
    End Sub
End Class