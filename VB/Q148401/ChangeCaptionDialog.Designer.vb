Imports Microsoft.VisualBasic
Imports System
Namespace Q148401
	Partial Public Class ChangeCaptionDialog
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(43, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Caption"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(61, 6)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(100, 20)
			Me.textBox1.TabIndex = 1
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(12, 32)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(66, 23)
			Me.button1.TabIndex = 2
			Me.button1.Text = "Apply"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.OnApplyClick);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(91, 32)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(66, 23)
			Me.button2.TabIndex = 3
			Me.button2.Text = "Cancel"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.OnCancelClick);
			' 
			' ChangeCaptionDialog
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(169, 64)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "ChangeCaptionDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "ChangeCaptionDialog"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button

	End Class
End Namespace