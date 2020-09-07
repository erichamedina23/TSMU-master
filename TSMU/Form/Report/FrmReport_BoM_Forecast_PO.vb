Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class FrmReport_BoM_Forecast_PO
    Dim ObjReportMatome As ClsReportMatome

    Public Sub New()
        ObjReportMatome = New ClsReportMatome
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmReport_BoM_Forecast_PO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Tahun As String = String.Empty
        Tahun = Date.Today.Year().ToString
        _txtTahun.Text = Tahun
        Call Proc_EnableButtons(False, False, False, True, True, False, False, False, False, False, False)
        'LoadGrid(Tahun)
    End Sub
    Private Sub LoadGrid(Tahun As String)
        Try
            Cursor.Current = Cursors.WaitCursor

            SplashScreenManager.ShowForm(Me, GetType(FrmWait), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please wait...")
            Dim dt As New DataTable
            dt = ObjReportMatome.Generate_Report_BoM_PO_ForecastCalculate(Tahun, txtInvtId.EditValue, TxtPerost.EditValue)
            Grid.DataSource = dt
            AdvBandedGridView1.BestFitColumns()
            'If AdvBandedGridView1.RowCount > 0 Then
            '    FormatGridBadgeView(AdvBandedGridView1)
            'End If

            Call Proc_EnableButtons(False, False, False, True, True, False, False, False, False, False, False)
            Cursor.Current = Cursors.Default
            SplashScreenManager.CloseForm()
            'XtraMessageBox.Show("Proses selesai !")
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message)
        End Try

        'With AdvBandedGridView1
        '    .BestFitColumns()
        '    .FixedLineWidth = 2
        '    .Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        '    .Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        'End With
    End Sub
    Public Overrides Sub Proc_Refresh()
        If _txtTahun.Text = "" Then
            XtraMessageBox.Show("Silahkan isi tahun !")
            _txtTahun.Focus()
        ElseIf txtInvtId.Text = "" Then
            XtraMessageBox.Show("Inventory ID harus di isi !")
            txtInvtId.Focus()
        ElseIf TxtPerost.Text = "" Then
            XtraMessageBox.Show("Perpost harus di isi !")
            TxtPerost.Focus()
        Else
            LoadGrid(_txtTahun.Text)
        End If
    End Sub
    Public Overrides Sub Proc_Excel()
        Try
            If AdvBandedGridView1.RowCount > 0 Then
                Dim Bulan As String = String.Empty
                Select Case Microsoft.VisualBasic.Right(TxtPerost.EditValue, 2)
                    Case "01"
                        Bulan = "Jan " & _txtTahun.EditValue
                    Case "02"
                        Bulan = "Feb " & _txtTahun.EditValue
                    Case "03"
                        Bulan = "Mar " & _txtTahun.EditValue
                    Case "04"
                        Bulan = "Apr " & _txtTahun.EditValue
                    Case "05"
                        Bulan = "Mei " & _txtTahun.EditValue
                    Case "06"
                        Bulan = "Jun " & _txtTahun.EditValue
                    Case "07"
                        Bulan = "Jul " & _txtTahun.EditValue
                    Case "08"
                        Bulan = "Agt " & _txtTahun.EditValue
                    Case "09"
                        Bulan = "Sep " & _txtTahun.EditValue
                    Case "10"
                        Bulan = "Okt " & _txtTahun.EditValue
                    Case "11"
                        Bulan = "Nov " & _txtTahun.EditValue
                    Case "12"
                        Bulan = "Des " & _txtTahun.EditValue
                End Select
                SaveToExcel(Grid, "Actual Sales " & Bulan, "Konsumsi Actual Sales Material", False)

            Else
                Throw New Exception("Tidak ada Data yg di export")
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub _txtTahun_KeyDown(sender As Object, e As KeyEventArgs) Handles _txtTahun.KeyDown
        If e.KeyCode = Keys.Enter Then
            tsBtn_refresh.PerformClick()
        Else
            e.Handled = True
        End If
    End Sub
    Dim ObjReport As clsReport
    Private Sub txtInvtId_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtInvtId.ButtonClick
        Try
            Dim ls_Judul As String = ""
            Dim dtSearch As New DataTable
            Dim ls_OldKode As String = ""

            ObjReport = New clsReport
            dtSearch = ObjReport.getInvtItem
            ls_OldKode = txtInvtId.Text.Trim
            ls_Judul = "Invetory ID"


            '   dtSearch.Rows.InsertAt(dtSearch.NewRow, 0)
            dtSearch.Rows(0).Item(0) = "ALL"
            dtSearch.Rows(0).Item(1) = "ALL"

            Dim lF_SearchData As FrmSystem_LookupGrid
            lF_SearchData = New FrmSystem_LookupGrid(dtSearch)
            lF_SearchData.Text = "Select Data " & ls_Judul
            lF_SearchData.StartPosition = FormStartPosition.CenterScreen
            lF_SearchData.ShowDialog()
            Dim ls_Kode As String = ""
            Dim ls_Nama As String = ""

            If lF_SearchData.Values IsNot Nothing AndAlso lF_SearchData.Values.Item(0).ToString.Trim <> ls_OldKode Then
                ls_Kode = lF_SearchData.Values.Item(0).ToString.Trim
                ls_Nama = lF_SearchData.Values.Item(1).ToString.Trim
                txtInvtId.Text = ls_Kode
            End If
            txtInvtId.Focus()
            lF_SearchData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub txtInvtId_EditValueChanged(sender As Object, e As EventArgs) Handles txtInvtId.EditValueChanged
        Try
            tsBtn_refresh.PerformClick()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AdvBandedGridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles AdvBandedGridView1.RowStyle
        Dim View As AdvBandedGridView = sender
        If e.RowHandle > 0 Then
            Dim Level As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Level"))
            'Dim array2() As String = TempSJ.ToArray
            If Level.ToLower = "level 0" Then
                e.Appearance.BackColor = Color.LightBlue
                e.Appearance.BackColor2 = Color.SeaShell
                e.HighPriority = True
            End If
            'For Each sj As String In array2

            'Next
        End If
    End Sub

    Private Sub TxtPerost_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPerost.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                tsBtn_refresh.PerformClick()
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
End Class
