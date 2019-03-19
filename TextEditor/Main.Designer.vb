<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
		Me.mnControls = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAverage = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.textToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.mnControls.SuspendLayout()
		Me.SuspendLayout()
		'
		'mnControls
		'
		Me.mnControls.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp, Me.WindowsToolStripMenuItem})
		Me.mnControls.Location = New System.Drawing.Point(0, 0)
		Me.mnControls.Name = "mnControls"
		Me.mnControls.Size = New System.Drawing.Size(377, 24)
		Me.mnControls.TabIndex = 1
		Me.mnControls.Text = "Menu"
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuClose, Me.mnuExit})
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(37, 20)
		Me.mnuFile.Text = "&File"
		Me.mnuFile.ToolTipText = "Open to view File options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+F."
		'
		'mnuNew
		'
		Me.mnuNew.Name = "mnuNew"
		Me.mnuNew.ShortcutKeyDisplayString = "Ctrl-N"
		Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.mnuNew.Size = New System.Drawing.Size(143, 22)
		Me.mnuNew.Text = "&New"
		Me.mnuNew.ToolTipText = "Create a new file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by Pressing Alt+F+N or Ctrl+N."
		'
		'mnuOpen
		'
		Me.mnuOpen.Name = "mnuOpen"
		Me.mnuOpen.ShortcutKeyDisplayString = "Ctrl-O"
		Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.mnuOpen.Size = New System.Drawing.Size(143, 22)
		Me.mnuOpen.Text = "&Open"
		Me.mnuOpen.ToolTipText = "Open a file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+F+O or Ctrl+O."
		'
		'mnuSave
		'
		Me.mnuSave.Name = "mnuSave"
		Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.mnuSave.Size = New System.Drawing.Size(143, 22)
		Me.mnuSave.Text = "&Save"
		Me.mnuSave.ToolTipText = "Save the file to its default location." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+F+S or Ct" &
	"rl+S."
		'
		'mnuSaveAs
		'
		Me.mnuSaveAs.Name = "mnuSaveAs"
		Me.mnuSaveAs.Size = New System.Drawing.Size(143, 22)
		Me.mnuSaveAs.Text = "Save &As"
		Me.mnuSaveAs.ToolTipText = "Save the file to a different location." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+F+A."
		'
		'mnuClose
		'
		Me.mnuClose.Name = "mnuClose"
		Me.mnuClose.Size = New System.Drawing.Size(143, 22)
		Me.mnuClose.Text = "C&lose"
		'
		'mnuExit
		'
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
		Me.mnuExit.Size = New System.Drawing.Size(143, 22)
		Me.mnuExit.Text = "E&xit"
		Me.mnuExit.ToolTipText = "Close the Application." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+F+X."
		'
		'mnuEdit
		'
		Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
		Me.mnuEdit.Name = "mnuEdit"
		Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
		Me.mnuEdit.Text = "&Edit"
		Me.mnuEdit.ToolTipText = "View options that will Edit the text." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+E."
		'
		'mnuCopy
		'
		Me.mnuCopy.Name = "mnuCopy"
		Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.mnuCopy.Size = New System.Drawing.Size(144, 22)
		Me.mnuCopy.Text = "&Copy"
		Me.mnuCopy.ToolTipText = "Copy the selected text." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be acessed by pressing Alt+E+C or Ctrl+C."
		'
		'mnuCut
		'
		Me.mnuCut.Name = "mnuCut"
		Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.mnuCut.Size = New System.Drawing.Size(144, 22)
		Me.mnuCut.Text = "Cu&t"
		Me.mnuCut.ToolTipText = "Remove the text and save it to the clipboard." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+E+" &
	"T or Ctrl+X."
		'
		'mnuPaste
		'
		Me.mnuPaste.Name = "mnuPaste"
		Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.mnuPaste.Size = New System.Drawing.Size(144, 22)
		Me.mnuPaste.Text = "&Paste"
		Me.mnuPaste.ToolTipText = "Paste the text saved to the clipboard." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+E+P or Ct" &
	"rl+P."
		'
		'mnuHelp
		'
		Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
		Me.mnuHelp.Text = "Help"
		Me.mnuHelp.ToolTipText = "View Help Options."
		'
		'mnuAbout
		'
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
		Me.mnuAbout.Text = "About"
		Me.mnuAbout.ToolTipText = "Learn about the application."
		'
		'WindowsToolStripMenuItem
		'
		Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuVertical, Me.mnuHorizontal, Me.mnuAverage})
		Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
		Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
		Me.WindowsToolStripMenuItem.Text = "Windows"
		'
		'mnuCascade
		'
		Me.mnuCascade.Name = "mnuCascade"
		Me.mnuCascade.Size = New System.Drawing.Size(173, 22)
		Me.mnuCascade.Text = "Cascade"
		'
		'mnuVertical
		'
		Me.mnuVertical.Name = "mnuVertical"
		Me.mnuVertical.Size = New System.Drawing.Size(173, 22)
		Me.mnuVertical.Text = "Tile Vertical"
		'
		'mnuHorizontal
		'
		Me.mnuHorizontal.Name = "mnuHorizontal"
		Me.mnuHorizontal.Size = New System.Drawing.Size(173, 22)
		Me.mnuHorizontal.Text = "Tile Horizontal"
		'
		'mnuAverage
		'
		Me.mnuAverage.Name = "mnuAverage"
		Me.mnuAverage.Size = New System.Drawing.Size(173, 22)
		Me.mnuAverage.Text = "Average Units Sold"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(377, 323)
		Me.Controls.Add(Me.mnControls)
		Me.IsMdiContainer = True
		Me.Name = "Main"
		Me.Text = "Main"
		Me.mnControls.ResumeLayout(False)
		Me.mnControls.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents mnControls As MenuStrip
	Friend WithEvents mnuFile As ToolStripMenuItem
	Friend WithEvents mnuNew As ToolStripMenuItem
	Friend WithEvents mnuOpen As ToolStripMenuItem
	Friend WithEvents mnuSave As ToolStripMenuItem
	Friend WithEvents mnuSaveAs As ToolStripMenuItem
	Friend WithEvents mnuClose As ToolStripMenuItem
	Friend WithEvents mnuExit As ToolStripMenuItem
	Friend WithEvents mnuEdit As ToolStripMenuItem
	Friend WithEvents mnuCopy As ToolStripMenuItem
	Friend WithEvents mnuCut As ToolStripMenuItem
	Friend WithEvents mnuPaste As ToolStripMenuItem
	Friend WithEvents mnuHelp As ToolStripMenuItem
	Friend WithEvents mnuAbout As ToolStripMenuItem
	Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuCascade As ToolStripMenuItem
	Friend WithEvents mnuVertical As ToolStripMenuItem
	Friend WithEvents mnuHorizontal As ToolStripMenuItem
	Friend WithEvents mnuAverage As ToolStripMenuItem
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents textToolTip As ToolTip
End Class
