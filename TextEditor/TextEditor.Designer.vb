<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditor
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.textToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.tbInput = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'tbInput
		'
		Me.tbInput.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbInput.Location = New System.Drawing.Point(0, 0)
		Me.tbInput.Multiline = True
		Me.tbInput.Name = "tbInput"
		Me.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.tbInput.Size = New System.Drawing.Size(536, 313)
		Me.tbInput.TabIndex = 1
		Me.textToolTip.SetToolTip(Me.tbInput, "Enter text that can be saved.")
		'
		'frmEditor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(536, 313)
		Me.Controls.Add(Me.tbInput)
		Me.Name = "frmEditor"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Text Editor: Select a File to Open."
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents textToolTip As ToolTip
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents tbInput As TextBox
End Class
