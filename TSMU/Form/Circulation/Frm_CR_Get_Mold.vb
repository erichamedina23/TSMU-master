

Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Public Class Frm_CR_Get_Mold

    Dim fc_Class As New ClsCR_CreateUser

    Dim DtGridNPWO As DataTable

    Dim Model As String
    Dim Grid1 As GridControl
    Dim Grid_V As DataGridView
    Dim IsNew As Boolean
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dtRef As DataTable
    Dim BG As String
    Dim dtModel As DataTable
    Dim dtNPWO As DataTable
    Dim Model1 As String
    Dim _Customer As String


    Private Sub Frm_CR_Get_Mold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call LoadGrid()
        Call FillModel()
        Call FillNPWO()
    End Sub

    Public Sub New(ByVal _Model As String,
                  ByRef _dt As DataTable,
                  ByRef _grid As GridControl,
                  ByVal _BG As String)

        ' This call is required by the designer.
        InitializeComponent()

        Model = _Model
        Grid1 = _grid
        dtRef = _dt
        BG = _BG


    End Sub

    ReadOnly Property Values_Model() As String
        Get
            Return Model1
        End Get
    End Property

    ReadOnly Property Values_Customer() As String
        Get
            Return _Customer
        End Get
    End Property

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            'Dim DtGridNPWO As New DataTable
            dt = fc_Class.GetMold()

            dt.Columns.Add("Qty")
            dt.Columns.Add("Price")
            dt.Columns.Add("Total Amount Currency")
            dt.Columns.Add("Total IDR")
            dt.Columns.Add("PR No")
            dt.Columns.Add("Curr")
            dt.Columns.Add("Rate")
            dt.Columns.Add("Balance")
            dt.Columns.Add("Remaining Budget")
            dt.Columns.Add("Category")


            For a As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(a).Item("Qty") = "1"
                dt.Rows(a).Item("Price") = "0"
                dt.Rows(a).Item("Total Amount Currency") = "0"
                dt.Rows(a).Item("PR No") = ""
                dt.Rows(a).Item("Curr") = ""
                dt.Rows(a).Item("Rate") = "1"
                dt.Rows(a).Item("Balance") = "0"
                dt.Rows(a).Item("Remaining Budget") = "0"
                dt.Rows(a).Item("Category") = BG
                dt.Rows(a).Item("Total IDR") = "0"
            Next

            Grid.DataSource = dt
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadGrid_ByNpwo(Npwo As String)

        Try

            Cursor.Current = Cursors.WaitCursor

            'Dim DtGridNPWO As New DataTable
            dt = fc_Class.GetMold_ByNpwo(Npwo)

            dt.Columns.Add("Qty")
            dt.Columns.Add("Price")
            dt.Columns.Add("Total Amount Currency")
            dt.Columns.Add("Total IDR")
            dt.Columns.Add("PR No")
            dt.Columns.Add("Curr")
            dt.Columns.Add("Rate")
            dt.Columns.Add("Balance")
            dt.Columns.Add("Remaining Budget")
            dt.Columns.Add("Category")


            For a As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(a).Item("Qty") = "1"
                dt.Rows(a).Item("Price") = "0"
                dt.Rows(a).Item("Total Amount Currency") = "0"
                dt.Rows(a).Item("PR No") = ""
                dt.Rows(a).Item("Curr") = ""
                dt.Rows(a).Item("Rate") = "1"
                dt.Rows(a).Item("Balance") = "0"
                dt.Rows(a).Item("Remaining Budget") = "0"
                dt.Rows(a).Item("Category") = BG
                dt.Rows(a).Item("Total IDR") = "0"

            Next
            ' Model = dt.Rows(0).Item("Model")
            Grid.DataSource = dt
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadGrid_ByModel(Model As String)

        Try

            Cursor.Current = Cursors.WaitCursor

            'Dim DtGridNPWO As New DataTable
            dt = fc_Class.GetMold_ByModel(Model)

            dt.Columns.Add("Qty")
            dt.Columns.Add("Price")
            dt.Columns.Add("Total Amount Currency")
            dt.Columns.Add("Total IDR")
            dt.Columns.Add("PR No")
            dt.Columns.Add("Curr")
            dt.Columns.Add("Rate")
            dt.Columns.Add("Balance")
            dt.Columns.Add("Remaining Budget")
            dt.Columns.Add("Category")


            For a As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(a).Item("Qty") = "1"
                dt.Rows(a).Item("Price") = "0"
                dt.Rows(a).Item("Total Amount Currency") = "0"
                dt.Rows(a).Item("PR No") = ""
                dt.Rows(a).Item("Curr") = ""
                dt.Rows(a).Item("Rate") = "1"
                dt.Rows(a).Item("Balance") = "0"
                dt.Rows(a).Item("Remaining Budget") = "0"
                dt.Rows(a).Item("Category") = BG
                dt.Rows(a).Item("Total IDR") = "0"

            Next
            'Model = dt.Rows(0).Item("Model")
            Grid.DataSource = dt
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Badd_Click(sender As Object, e As EventArgs) Handles Badd.Click

        Model1 = dt.Rows(0).Item("Model")

        If Model <> "" Then

            If Model <> Model1 Then
                MessageBox.Show("Please Select Same Model",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

        End If


        Dim MyNewRow As DataRow
        Dim chkSelect As Boolean

        For j As Integer = 0 To GridView1.RowCount - 1

            chkSelect = If(GridView1.GetRowCellValue(j, GridView1.Columns("Check")) Is DBNull.Value, False, Convert.ToBoolean(GridView1.GetRowCellValue(j, GridView1.Columns("Check"))))
            MyNewRow = dtRef.NewRow
            If chkSelect = True Then

                With MyNewRow
                    .Item("Name Of Goods") = GridView1.GetRowCellValue(j, GridView1.Columns("Name Of Goods")).ToString
                    .Item("Spesification") = GridView1.GetRowCellValue(j, GridView1.Columns("Spesification")).ToString
                    .Item("Qty") = GridView1.GetRowCellValue(j, GridView1.Columns("Qty")).ToString
                    .Item("Price") = GridView1.GetRowCellValue(j, GridView1.Columns("Price")).ToString
                    .Item("Total Amount Currency") = GridView1.GetRowCellValue(j, GridView1.Columns("Total Amount Currency")).ToString
                    .Item("Curr") = "IDR"
                    .Item("Rate") = GridView1.GetRowCellValue(j, GridView1.Columns("Rate")).ToString
                    .Item("Balance") = GridView1.GetRowCellValue(j, GridView1.Columns("Balance")).ToString
                    .Item("Remaining Budget") = 0
                    .Item("Category") = GridView1.GetRowCellValue(j, GridView1.Columns("Category")).ToString
                    .Item("Total IDR") = GridView1.GetRowCellValue(j, GridView1.Columns("Total IDR")).ToString
                End With
                dtRef.Rows.Add(MyNewRow)
                dtRef.AcceptChanges()
                Model1 = dt.Rows(0).Item("Model")
                _Customer = dt.Rows(0).Item("Customer")

            End If

        Next

        Me.Close()


    End Sub

    Private Sub FillModel()
        Try

            dtModel = fc_Class.Get_Model()

            C_Model.Properties.DataSource = Nothing
            C_Model.Properties.DataSource = dtModel
            C_Model.Properties.ValueMember = "Model"
            C_Model.Properties.DisplayMember = "Model"

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub FillNPWO()
        Try

            dtNPWO = fc_Class.Get_NPWO()




            C_NPWO.Properties.DataSource = Nothing
            C_NPWO.Properties.DataSource = dtNPWO
            C_NPWO.Properties.ValueMember = "NPWO"
            C_NPWO.Properties.DisplayMember = "NPWO"


        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub C_NPWO_EditValueChanged(sender As Object, e As EventArgs) Handles C_NPWO.EditValueChanged
        Grid.DataSource = Nothing
        Call LoadGrid_ByNpwo(C_NPWO.EditValue)
    End Sub

    Private Sub C_Model_EditValueChanged(sender As Object, e As EventArgs) Handles C_Model.EditValueChanged
        Grid.DataSource = Nothing
        Call LoadGrid_ByModel(C_Model.EditValue)
    End Sub
End Class