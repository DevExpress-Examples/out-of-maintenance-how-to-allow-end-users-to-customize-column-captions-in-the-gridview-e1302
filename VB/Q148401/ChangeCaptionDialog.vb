Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns

Namespace Q148401
	Partial Public Class ChangeCaptionDialog
		Inherits Form
		Private column As GridColumn

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal column As GridColumn, ByVal position As Point)
			Me.New()
			Me.column = column
			textBox1.Text = column.Caption
			Location = position
		End Sub

		Private Sub OnApplyClick(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			column.Caption = textBox1.Text
			Close()
		End Sub

		Private Sub OnCancelClick(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Close()
		End Sub
	End Class
End Namespace