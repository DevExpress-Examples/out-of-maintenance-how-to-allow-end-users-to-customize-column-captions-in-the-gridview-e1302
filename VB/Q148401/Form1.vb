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

		Private Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow

			table.Columns.Add("Prod_NO", GetType(String))
			table.Columns.Add("Prod_Name", GetType(String))
			table.Columns.Add("Order_Date", GetType(String))
			table.Columns.Add("Quantity", GetType(String))

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "101"
			dataRow("Prod_Name") = "Product1"
			dataRow("Order_Date") = "12/06/2012"
			dataRow("Quantity") = "50"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "103"
			dataRow("Prod_Name") = "Product3"
			dataRow("Order_Date") = "18/06/2012"
			dataRow("Quantity") = "30"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "104"
			dataRow("Prod_Name") = "Product4"
			dataRow("Order_Date") = "25/06/2012"
			dataRow("Quantity") = "20"
			table.Rows.Add(dataRow)

			Return table
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			gridControl1.DataSource = CreateTable()
		End Sub

		Private Sub OnGridViewShowGridMenu(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles gridView1.ShowGridMenu
			If e.MenuType = GridMenuType.Column Then
				Dim item As New DXMenuItem("Change caption", New EventHandler(AddressOf OnDXMenuItemClick))
				item.Tag = e.HitInfo.Column
				e.Menu.Items.Add(item)
			End If
		End Sub

		Private Sub OnDXMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim gColumn As GridColumn = CType((DirectCast(sender, DXMenuItem)).Tag, GridColumn)
			Dim gView As GridView = CType(gColumn.View, GridView)
			Dim columnBounds As Rectangle = CType(gView.GetViewInfo(), GridViewInfo).ColumnsInfo(gColumn).Bounds
			Dim formLocation As New Point(columnBounds.Left, columnBounds.Bottom)
			formLocation = gView.GridControl.PointToScreen(formLocation)
			Call (New ChangeCaptionDialog(gColumn, formLocation)).ShowDialog(Me)
		End Sub
	End Class
End Namespace