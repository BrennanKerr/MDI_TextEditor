<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.lbInput = New System.Windows.Forms.Label()
		Me.lbUnits = New System.Windows.Forms.Label()
		Me.tbInput = New System.Windows.Forms.TextBox()
		Me.lbEmployeeOne = New System.Windows.Forms.Label()
		Me.lbEmployeeTwo = New System.Windows.Forms.Label()
		Me.lbEmployeeThree = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.tbAvgThree = New System.Windows.Forms.TextBox()
		Me.tbAvgTwo = New System.Windows.Forms.TextBox()
		Me.tbOutputThree = New System.Windows.Forms.TextBox()
		Me.tbOutputTwo = New System.Windows.Forms.TextBox()
		Me.tbOutputOne = New System.Windows.Forms.TextBox()
		Me.tbOutput = New System.Windows.Forms.TextBox()
		Me.btnEnter = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.tbAvgOne = New System.Windows.Forms.TextBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lbInput
		'
		Me.lbInput.Location = New System.Drawing.Point(12, 9)
		Me.lbInput.Name = "lbInput"
		Me.lbInput.Size = New System.Drawing.Size(38, 13)
		Me.lbInput.TabIndex = 0
		Me.lbInput.Text = "Day 1:"
		Me.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbUnits
		'
		Me.lbUnits.Location = New System.Drawing.Point(12, 35)
		Me.lbUnits.Name = "lbUnits"
		Me.lbUnits.Size = New System.Drawing.Size(34, 13)
		Me.lbUnits.TabIndex = 1
		Me.lbUnits.Text = "Units:"
		'
		'tbInput
		'
		Me.tbInput.Location = New System.Drawing.Point(52, 35)
		Me.tbInput.Name = "tbInput"
		Me.tbInput.Size = New System.Drawing.Size(74, 20)
		Me.tbInput.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.tbInput, "Enter the number of Units Sold for the given employee and day.")
		'
		'lbEmployeeOne
		'
		Me.lbEmployeeOne.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lbEmployeeOne.Location = New System.Drawing.Point(3, 0)
		Me.lbEmployeeOne.Name = "lbEmployeeOne"
		Me.lbEmployeeOne.Size = New System.Drawing.Size(121, 25)
		Me.lbEmployeeOne.TabIndex = 3
		Me.lbEmployeeOne.Text = "Employee 1:"
		Me.lbEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbEmployeeTwo
		'
		Me.lbEmployeeTwo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lbEmployeeTwo.Location = New System.Drawing.Point(130, 0)
		Me.lbEmployeeTwo.Name = "lbEmployeeTwo"
		Me.lbEmployeeTwo.Size = New System.Drawing.Size(121, 25)
		Me.lbEmployeeTwo.TabIndex = 4
		Me.lbEmployeeTwo.Text = "Employee 2:"
		Me.lbEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbEmployeeThree
		'
		Me.lbEmployeeThree.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lbEmployeeThree.Location = New System.Drawing.Point(257, 0)
		Me.lbEmployeeThree.Name = "lbEmployeeThree"
		Me.lbEmployeeThree.Size = New System.Drawing.Size(122, 25)
		Me.lbEmployeeThree.TabIndex = 5
		Me.lbEmployeeThree.Text = "Employee 3:"
		Me.lbEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TableLayoutPanel1.Controls.Add(Me.tbAvgThree, 2, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.tbAvgTwo, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.tbOutputThree, 2, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.tbOutputTwo, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.lbEmployeeOne, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.lbEmployeeThree, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.lbEmployeeTwo, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.tbOutputOne, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.tbOutput, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.btnEnter, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 2, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.tbAvgOne, 0, 2)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 76)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 5
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(382, 240)
		Me.TableLayoutPanel1.TabIndex = 6
		'
		'tbAvgThree
		'
		Me.tbAvgThree.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbAvgThree.Location = New System.Drawing.Point(257, 168)
		Me.tbAvgThree.Name = "tbAvgThree"
		Me.tbAvgThree.ReadOnly = True
		Me.tbAvgThree.Size = New System.Drawing.Size(122, 20)
		Me.tbAvgThree.TabIndex = 15
		Me.tbAvgThree.TabStop = False
		Me.tbAvgThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.tbAvgThree, "Displays the average for the third employee once" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the employee has the maximum nu" &
		"mber of values" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entered." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'tbAvgTwo
		'
		Me.tbAvgTwo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbAvgTwo.Location = New System.Drawing.Point(130, 168)
		Me.tbAvgTwo.Name = "tbAvgTwo"
		Me.tbAvgTwo.ReadOnly = True
		Me.tbAvgTwo.Size = New System.Drawing.Size(121, 20)
		Me.tbAvgTwo.TabIndex = 14
		Me.tbAvgTwo.TabStop = False
		Me.tbAvgTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.tbAvgTwo, "Displays the average for the second employee once" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the employee has the maximum n" &
		"umber of values" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entered.")
		'
		'tbOutputThree
		'
		Me.tbOutputThree.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbOutputThree.Location = New System.Drawing.Point(257, 28)
		Me.tbOutputThree.Multiline = True
		Me.tbOutputThree.Name = "tbOutputThree"
		Me.tbOutputThree.ReadOnly = True
		Me.tbOutputThree.Size = New System.Drawing.Size(122, 134)
		Me.tbOutputThree.TabIndex = 8
		Me.tbOutputThree.TabStop = False
		Me.ToolTip1.SetToolTip(Me.tbOutputThree, "Displays the values entered for the third employee." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'tbOutputTwo
		'
		Me.tbOutputTwo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbOutputTwo.Location = New System.Drawing.Point(130, 28)
		Me.tbOutputTwo.Multiline = True
		Me.tbOutputTwo.Name = "tbOutputTwo"
		Me.tbOutputTwo.ReadOnly = True
		Me.tbOutputTwo.Size = New System.Drawing.Size(121, 134)
		Me.tbOutputTwo.TabIndex = 7
		Me.tbOutputTwo.TabStop = False
		Me.ToolTip1.SetToolTip(Me.tbOutputTwo, "Displays the values entered for the second employee.")
		'
		'tbOutputOne
		'
		Me.tbOutputOne.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbOutputOne.Location = New System.Drawing.Point(3, 28)
		Me.tbOutputOne.Multiline = True
		Me.tbOutputOne.Name = "tbOutputOne"
		Me.tbOutputOne.ReadOnly = True
		Me.tbOutputOne.Size = New System.Drawing.Size(121, 134)
		Me.tbOutputOne.TabIndex = 6
		Me.tbOutputOne.TabStop = False
		Me.ToolTip1.SetToolTip(Me.tbOutputOne, "Displays the values entered for the first employee.")
		'
		'tbOutput
		'
		Me.TableLayoutPanel1.SetColumnSpan(Me.tbOutput, 3)
		Me.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbOutput.Location = New System.Drawing.Point(3, 193)
		Me.tbOutput.Name = "tbOutput"
		Me.tbOutput.ReadOnly = True
		Me.tbOutput.Size = New System.Drawing.Size(376, 20)
		Me.tbOutput.TabIndex = 9
		Me.tbOutput.TabStop = False
		Me.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.tbOutput, "Displays the overall average once all values have been" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entered.")
		'
		'btnEnter
		'
		Me.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnEnter.Location = New System.Drawing.Point(3, 218)
		Me.btnEnter.Name = "btnEnter"
		Me.btnEnter.Size = New System.Drawing.Size(121, 19)
		Me.btnEnter.TabIndex = 10
		Me.btnEnter.Text = "&Enter"
		Me.ToolTip1.SetToolTip(Me.btnEnter, "Press to enter the units sold. The value will be saved (if valid)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be access" &
		"ed by pressing Enter or Alt+E.")
		Me.btnEnter.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnReset.Location = New System.Drawing.Point(130, 218)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(121, 19)
		Me.btnReset.TabIndex = 11
		Me.btnReset.Text = "&Reset"
		Me.ToolTip1.SetToolTip(Me.btnReset, "Reset the application. This will clear all input and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "calculated averages." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can b" &
		"e accessed by pressing Esc or Alt-R.")
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnExit.Location = New System.Drawing.Point(257, 218)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(122, 19)
		Me.btnExit.TabIndex = 12
		Me.btnExit.Text = "E&xit"
		Me.ToolTip1.SetToolTip(Me.btnExit, "Close the Application." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt-X.")
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'tbAvgOne
		'
		Me.tbAvgOne.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbAvgOne.Location = New System.Drawing.Point(3, 168)
		Me.tbAvgOne.Name = "tbAvgOne"
		Me.tbAvgOne.ReadOnly = True
		Me.tbAvgOne.Size = New System.Drawing.Size(121, 20)
		Me.tbAvgOne.TabIndex = 13
		Me.tbAvgOne.TabStop = False
		Me.tbAvgOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.tbAvgOne, "Displays the average for the first employee once" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the employee has the maximum nu" &
		"mber of values" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entered.")
		'
		'Form1
		'
		Me.AcceptButton = Me.btnEnter
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnReset
		Me.ClientSize = New System.Drawing.Size(408, 328)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.tbInput)
		Me.Controls.Add(Me.lbUnits)
		Me.Controls.Add(Me.lbInput)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Average Units Shipped By Employee"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbInput As Label
	Friend WithEvents lbUnits As Label
	Friend WithEvents tbInput As TextBox
	Friend WithEvents lbEmployeeOne As Label
	Friend WithEvents lbEmployeeTwo As Label
	Friend WithEvents lbEmployeeThree As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents tbOutputThree As TextBox
	Friend WithEvents tbOutputTwo As TextBox
	Friend WithEvents tbOutputOne As TextBox
	Friend WithEvents tbOutput As TextBox
	Friend WithEvents btnEnter As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents tbAvgOne As TextBox
	Friend WithEvents tbAvgThree As TextBox
	Friend WithEvents tbAvgTwo As TextBox
	Friend WithEvents ToolTip1 As ToolTip
End Class
