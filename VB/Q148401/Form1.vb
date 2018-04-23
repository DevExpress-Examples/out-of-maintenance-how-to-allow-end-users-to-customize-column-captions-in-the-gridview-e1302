Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace Q148401
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)

		End Sub

		Private Sub OnGridViewShowGridMenu(ByVal sender As Object, ByVal e As GridMenuEventArgs) Handles gridView1.ShowGridMenu
			If e.MenuType = GridMenuType.Column Then
				Dim item As New DXMenuItem("Change caption", New EventHandler(AddressOf OnDXMenuItemClick))
				item.Tag = e.HitInfo.Column
				e.Menu.Items.Add(item)
			End If
		End Sub

		Private Sub OnDXMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim gColumn As GridColumn = CType((CType(sender, DXMenuItem)).Tag, GridColumn)
			Dim gView As GridView = CType(gColumn.View, GridView)
			Dim columnBounds As Rectangle = (CType(gView.GetViewInfo(), GridViewInfo)).ColumnsInfo(gColumn).Bounds
			Dim formLocation As New Point(columnBounds.Left, columnBounds.Bottom)
			formLocation = gView.GridControl.PointToScreen(formLocation)
			CType(New ChangeCaptionDialog(gColumn, formLocation), ChangeCaptionDialog).ShowDialog(Me)
		End Sub
	End Class
End Namespace