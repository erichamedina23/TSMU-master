﻿Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelLibrary
Imports DevExpress.XtraGrid

Public Class frmReport_BarcodeGenerator
    Dim fc_class As New clsReport
    Dim fdtl_Config As DataTable = Nothing

    Private Sub frmReport_adm_BoM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Proc_EnableButtons(False, False, False, True, True, False, False, False, False, False, False)
        Init()
        ProgBar.Visible = False
    End Sub
    Private Sub Init()
        Grid.DataSource = Nothing
    End Sub
    Sub LoadTxtBox()
        If ProgBar.Visible = True Then
            MsgBox("Proses masih berjalan !")
            Exit Sub
        Else
            Grid.DataSource = Nothing
        End If
    End Sub
    Public Overrides Sub Proc_Refresh()
        Try
            Call LoadTxtBox()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveToExcel(_Grid As GridControl)
        Dim save As New SaveFileDialog
        save.Filter = "Excel File|*.xlsx"
        save.Title = "Save an Excel File"
        If save.ShowDialog = DialogResult.OK Then
            _Grid.ExportToXlsx(save.FileName)
        End If
    End Sub
    Public Overrides Sub Proc_Excel()
        Try
            If GridView1.RowCount > 0 Then
                SaveToExcel(Grid)
            Else
                MsgBox("Grid Kosong !")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Async Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try

            If ProgBar.Visible = True Then
                Throw New Exception("Process already running, Please wait !")
            End If
            ProgBar.Visible = True
            ProgBar.Style = ProgressBarStyle.Marquee
            Await Task.Run(Sub() GetDataGrid())
        Catch ex As Exception
            ProgBar.Visible = False
            MsgBox(ex.Message)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub
    Private Sub GetDataGrid()
        Dim dt As New DataTable
        Dim Objadm = New ReportAdmModels
        dt = Objadm.GetDataGridBarcodeGenerate()
        setDataSource(dt, Grid)
        Invoke(Sub()
                   ProgBar.Visible = False
               End Sub)

    End Sub

    Friend Delegate Sub SetDataSourceDelegate(table As DataTable, _Grid As GridControl)
    Private Sub setDataSource(table As DataTable, _Grid As GridControl)
        ' Invoke method if required:
        If Me.InvokeRequired Then
            Me.Invoke(New SetDataSourceDelegate(AddressOf setDataSource), table, _Grid)
        Else
            _Grid.DataSource = table
            If GridView1.RowCount > 0 Then
                GridView1.BestFitColumns()
                GridCellFormat(GridView1)
            End If
        End If
    End Sub

End Class
