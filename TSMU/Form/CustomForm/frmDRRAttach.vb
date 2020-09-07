Imports System.IO
Imports DevExpress.XtraBars.Ribbon

Public Class frmDRRAttach
    Private dragDropHelper As DragDropHelper
    Dim _NoNPP As String
    Dim _Path As String
    Dim _IsNew As Boolean
    Dim ObjImage As ImageModel
    Dim _Images As New List(Of String)
    Public Sub New(NoNPP As String, Path As String, IsNew As Boolean, Optional Images As List(Of String) = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        dragDropHelper = New DragDropHelper(GalleryControl1)
        dragDropHelper.EnableDragDrop()
        _NoNPP = NoNPP
        _Path = Path
        _IsNew = IsNew
        _Images = Images
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDRRAttach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImageToGalllery()
    End Sub

    Private Sub GalleryControl1_DragEnter(sender As Object, e As DragEventArgs) Handles GalleryControl1.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                e.Effect = DragDropEffects.Copy
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Property ImgList As List(Of ImageModel)
    Public Property ImagesToDelete As New List(Of ImageModel)

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try

            ImgList = New List(Of ImageModel)
            For Each item As GalleryItem In GalleryControl1.Gallery.Groups(0).Items
                ImgList.Add(New ImageModel With {.ImageTitle = If(item.Caption.Contains("Attach"), If(item.Caption.Contains(_NoNPP), item.Caption, _NoNPP & "_" & item.Caption),
                            If(item.Caption.Contains(_NoNPP), item.Caption & "_Attach", _NoNPP & "_" & item.Caption & "_Attach")), .Img = item.Image})
            Next item
            Hide()
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub LoadImageToGalllery()
        Try
            If _IsNew Then
                GalleryControl1.Gallery.Groups(0).Items.Clear()
            Else
                GalleryControl1.Gallery.Groups(0).Items.Clear()
                Dim index As Integer = 0
                For Each gambar In _Images
                    Dim pathParts = gambar.Split("_"c)
                    Dim _filename = _NoNPP & "_" & pathParts(1) & "_" & Replace(pathParts(2), ".png", "")
                    If _filename = "" Then
                        Exit For
                    End If
                    Dim img As Image

                    If Directory.Exists(_Path) Then
                        img = New Bitmap(Image.FromFile(gambar))
                        If img IsNot Nothing Then
                            GalleryControl1.Gallery.Groups(0).Items.Add(New GalleryItem(img, img, _filename, "", index, index, Nothing, ""))
                        End If
                    End If
                    index = index + 1
                Next
                'For Each item As GalleryItem In GalleryControl1.Gallery.Groups(0).Items
                '    ImgList.Add(New ImageModel With {.ImageTitle = item.Caption, .Img = item.Image})
                'Next item
            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub

    Private Sub frmDRRAttach_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
            Else
                If e.KeyCode = Keys.Delete Then
                    Dim item As GalleryItem = GalleryControl1.Gallery.GetCheckedItem()
                    ImagesToDelete.Add(New ImageModel With {.ImageTitle = item.Caption})
                    If item IsNot Nothing Then GalleryControl1.Gallery.Groups(0).Items.Remove(item)
                End If
            End If
        Catch ex As Exception
            Call ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
            WriteToErrorLog(ex.Message, gh_Common.Username, ex.StackTrace)
        End Try
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Try
            Dim _hasil As List(Of String) = New List(Of String)
            Dim Dial As New OpenFileDialog
            Dial.Filter = "Png Files|*.png"
            Dial.Multiselect = True
            Dim result As DialogResult = Dial.ShowDialog()
            ' Test result.
            If result = System.Windows.Forms.DialogResult.OK Then
                Dim _folder = Path.GetDirectoryName(Dial.FileName) & "\"
                _hasil.AddRange(Dial.FileNames.Select(Function(f) Path.GetFileName(f)).ToArray)
                For Each _strImage In _hasil
                    Dim _fileName = _strImage.Split("."c)
                    Dim img As Image
                    Using bmpTemp As Bitmap = New Bitmap(Image.FromFile(Path.Combine(_folder, _strImage)))
                        img = New Bitmap(bmpTemp)
                        If img IsNot Nothing Then
                            GalleryControl1.Gallery.Groups(0).Items.Add(New GalleryItem(img, _fileName(0), ""))
                        End If
                    End Using
                Next
                '_path = String.Join(Environment.NewLine, Dial.FileNames) 'Dial.FileName

            End If
        Catch ex As Exception
            ShowMessage(ex.Message, MessageTypeEnum.ErrorMessage)
        End Try
    End Sub
End Class