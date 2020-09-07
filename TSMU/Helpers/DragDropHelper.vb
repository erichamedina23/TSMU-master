Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing
Imports System.Diagnostics


Public Class DragDropHelper
    Private galleryControl1 As GalleryControl
    Private _SelectedPen As New Pen(Color.Indigo, 3)
    Private targetHighlightItem As GalleryItem
    Private DragItemHitInfo As RibbonHitInfo
    Private dragging As Boolean
    Public Sub New(ByVal galleryControl1 As GalleryControl)
        Me.galleryControl1 = galleryControl1
    End Sub

    Public Property SelectedPen() As Pen
        Get
            Return _SelectedPen
        End Get
        Set(ByVal value As Pen)
            _SelectedPen = value
        End Set
    End Property

    Public Sub EnableDragDrop()
        galleryControl1.AllowDrop = True
        AddHandler galleryControl1.MouseDown, AddressOf OnGalleryControlMouseDown
        AddHandler galleryControl1.MouseMove, AddressOf OnGalleryControlMouseMove
        AddHandler galleryControl1.DragOver, AddressOf OnGalleryControlDragOver
        AddHandler galleryControl1.DragDrop, AddressOf OnGalleryControlDragDrop
        AddHandler galleryControl1.MouseUp, AddressOf OnSourceGalleryMouseUp
        AddHandler galleryControl1.Gallery.CustomDrawItemText, AddressOf OnCustomDrawItemText
    End Sub

    Private Sub OnGalleryControlMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim gallery As GalleryControl = CType(sender, GalleryControl)
        Dim hitInfo As RibbonHitInfo = gallery.CalcHitInfo(e.Location)
        If hitInfo.InGalleryItem Then
            DragItemHitInfo = hitInfo
        Else
            DragItemHitInfo = Nothing
        End If
    End Sub

    Private Sub OnGalleryControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button <> MouseButtons.Left OrElse Control.ModifierKeys <> Keys.None OrElse DragItemHitInfo Is Nothing Then
            Return
        End If
        Dim gallery As GalleryControl = CType(sender, GalleryControl)
        Dim checkedItems As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
        If checkedItems.Count = 0 Then
            checkedItems.Add(DragItemHitInfo.GalleryItem)
        End If
        If (Not New Rectangle(DragItemHitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2, DragItemHitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2, SystemInformation.DragSize.Width, SystemInformation.DragSize.Height).Contains(e.Location)) Then
            gallery.DoDragDrop(checkedItems, DragDropEffects.All)
        End If

    End Sub

    Private Sub OnGalleryControlDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
        If e.Data.GetDataPresent(GetType(List(Of GalleryItem))) Then
            e.Effect = DragDropEffects.Move
        End If
        Dim gallery As GalleryControl = CType(sender, GalleryControl)

        Dim hitInfo As RibbonHitInfo = gallery.CalcHitInfo(gallery.PointToClient(New Point(e.X, e.Y)))
        targetHighlightItem = hitInfo.GalleryItem
        gallery.Invalidate()

    End Sub

    Private Sub OnGalleryControlDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        If (Not e.Data.GetDataPresent(GetType(List(Of GalleryItem)))) Then
            'Dim Image As Image
            'Image = Image.FromFile(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)
            Dim file = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim pathParts = file(0).Split("\"c)
            Dim fileName = pathParts(pathParts.Count() - 1).Split("."c)

            Dim img As Image
            Using bmpTemp As Bitmap = New Bitmap(Image.FromFile(file(0))) 'file(0)
                img = New Bitmap(bmpTemp)
                If img IsNot Nothing Then
                    galleryControl1.Gallery.Groups(0).Items.Add(New GalleryItem(img, fileName(0), ""))
                End If
            End Using
            GC.Collect()

            'If Image IsNot Nothing Then

            'Dim graphics As Graphics = Graphics.FromImage(Image)
            'Dim item As New GalleryItem(Image, fileName(0), "")
            ''item.ImageOptions.SvgImageSize = Image.Size
            ''galleryControl1.Gallery.MaxItemWidth = Image.Width

            'galleryControl1.Gallery.Groups(0).Items.Add(item)
            'End If
            Return
        End If
        Dim dragTarget As GalleryControl = CType(sender, GalleryControl)
        Dim hitInfo As RibbonHitInfo = dragTarget.CalcHitInfo(dragTarget.PointToClient(New Point(e.X, e.Y)))
        Dim targetItem As GalleryItem = hitInfo.GalleryItem
        If targetItem IsNot Nothing Then
            Dim target As GalleryItemCollection = targetItem.GalleryGroup.Items
            Dim index As Integer = target.IndexOf(targetItem)
            Dim draggedItems As List(Of GalleryItem) = CType(e.Data.GetData(GetType(List(Of GalleryItem))), List(Of GalleryItem))
            For Each item As GalleryItem In draggedItems
                Dim source As GalleryItemCollection = item.GalleryGroup.Items
                source.Remove(item)
                target.Insert(index, item)
                index += 1
            Next item
        End If
        targetHighlightItem = Nothing
    End Sub

    Private Sub OnCustomDrawItemText(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
        If e.Item.Equals(targetHighlightItem) Then
            Dim newPoint As New Point(e.Bounds.X, e.Bounds.Bottom)
            e.Cache.Graphics.DrawLine(SelectedPen, newPoint, New Point(e.Bounds.Right, e.Bounds.Bottom))
        End If
    End Sub
    Private Sub OnSourceGalleryMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim point As Point = galleryControl1.Parent.PointToClient(Cursor.Position)

        If Not galleryControl1.Bounds.Contains(point) AndAlso dragging Then
            DragItemHitInfo.GalleryItemGroup.Items.Remove(DragItemHitInfo.GalleryItem)
        End If

        dragging = False
    End Sub
    Public Sub DisableDragDrop()
        galleryControl1.AllowDrop = True
        RemoveHandler galleryControl1.MouseDown, AddressOf OnGalleryControlMouseDown
        RemoveHandler galleryControl1.MouseMove, AddressOf OnGalleryControlMouseMove
        RemoveHandler galleryControl1.DragOver, AddressOf OnGalleryControlDragOver
        RemoveHandler galleryControl1.DragDrop, AddressOf OnGalleryControlDragDrop
        RemoveHandler galleryControl1.MouseUp, AddressOf OnSourceGalleryMouseUp
        RemoveHandler galleryControl1.Gallery.CustomDrawItemText, AddressOf OnCustomDrawItemText
    End Sub
End Class
