<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.mnControls = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAverage = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.textToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.mnuButtons = New System.Windows.Forms.ToolStrip()
		Me.mnuBtnNew = New System.Windows.Forms.ToolStripButton()
		Me.mnuBtnOpen = New System.Windows.Forms.ToolStripButton()
		Me.mnuBtnSave = New System.Windows.Forms.ToolStripButton()
		Me.statusStrip = New System.Windows.Forms.StatusStrip()
		Me.tsStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnControls.SuspendLayout()
		Me.mnuButtons.SuspendLayout()
		Me.statusStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'mnControls
		'
		Me.mnControls.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
		Me.mnControls.Location = New System.Drawing.Point(0, 0)
		Me.mnControls.MdiWindowListItem = Me.mnuWindows
		Me.mnControls.Name = "mnControls"
		Me.mnControls.Size = New System.Drawing.Size(377, 24)
		Me.mnControls.TabIndex = 1
		Me.mnControls.Text = "Menu"
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.ToolStripSeparator2, Me.mnuSave, Me.mnuSaveAs, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.mnuClose, Me.mnuExit})
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
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(140, 6)
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
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(140, 6)
		'
		'mnuClose
		'
		Me.mnuClose.Name = "mnuClose"
		Me.mnuClose.Size = New System.Drawing.Size(152, 22)
		Me.mnuClose.Text = "&Close"
		'
		'mnuExit
		'
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Size = New System.Drawing.Size(152, 22)
		Me.mnuExit.Text = "E&xit"
		Me.mnuExit.ToolTipText = "Close the Application." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be accessed by pressing Alt+F+X."
		'
		'mnuEdit
		'
		Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.mnuCopy, Me.mnuCut, Me.mnuPaste, Me.ToolStripSeparator5})
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
		'mnuWindows
		'
		Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuVertical, Me.mnuHorizontal, Me.mnuAverage, Me.ToolStripSeparator1})
		Me.mnuWindows.Name = "mnuWindows"
		Me.mnuWindows.Size = New System.Drawing.Size(68, 20)
		Me.mnuWindows.Text = "&Windows"
		'
		'mnuCascade
		'
		Me.mnuCascade.Name = "mnuCascade"
		Me.mnuCascade.Size = New System.Drawing.Size(173, 22)
		Me.mnuCascade.Text = "Casca&de"
		'
		'mnuVertical
		'
		Me.mnuVertical.Name = "mnuVertical"
		Me.mnuVertical.Size = New System.Drawing.Size(173, 22)
		Me.mnuVertical.Text = "Tile &Vertical"
		'
		'mnuHorizontal
		'
		Me.mnuHorizontal.Name = "mnuHorizontal"
		Me.mnuHorizontal.Size = New System.Drawing.Size(173, 22)
		Me.mnuHorizontal.Text = "Tile &Horizontal"
		'
		'mnuAverage
		'
		Me.mnuAverage.Name = "mnuAverage"
		Me.mnuAverage.Size = New System.Drawing.Size(173, 22)
		Me.mnuAverage.Text = "Average &Units Sold"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
		'
		'mnuHelp
		'
		Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
		Me.mnuHelp.Text = "&Help"
		Me.mnuHelp.ToolTipText = "View Help Options."
		'
		'mnuAbout
		'
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
		Me.mnuAbout.Text = "&About"
		Me.mnuAbout.ToolTipText = "Learn about the application."
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'mnuButtons
		'
		Me.mnuButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnNew, Me.mnuBtnOpen, Me.mnuBtnSave})
		Me.mnuButtons.Location = New System.Drawing.Point(0, 24)
		Me.mnuButtons.Name = "mnuButtons"
		Me.mnuButtons.Size = New System.Drawing.Size(377, 25)
		Me.mnuButtons.TabIndex = 3
		Me.mnuButtons.Text = "mnuButtons"
		'
		'mnuBtnNew
		'
		Me.mnuBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.mnuBtnNew.Image = CType(resources.GetObject("mnuBtnNew.Image"), System.Drawing.Image)
		Me.mnuBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuBtnNew.Name = "mnuBtnNew"
		Me.mnuBtnNew.Size = New System.Drawing.Size(23, 22)
		Me.mnuBtnNew.Text = "mnuBtnNew"
		'
		'mnuBtnOpen
		'
		Me.mnuBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.mnuBtnOpen.Image = CType(resources.GetObject("mnuBtnOpen.Image"), System.Drawing.Image)
		Me.mnuBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuBtnOpen.Name = "mnuBtnOpen"
		Me.mnuBtnOpen.Size = New System.Drawing.Size(23, 22)
		Me.mnuBtnOpen.Text = "mnuBtnOpen"
		'
		'mnuBtnSave
		'
		Me.mnuBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.mnuBtnSave.Image = CType(resources.GetObject("mnuBtnSave.Image"), System.Drawing.Image)
		Me.mnuBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuBtnSave.Name = "mnuBtnSave"
		Me.mnuBtnSave.Size = New System.Drawing.Size(23, 22)
		Me.mnuBtnSave.Text = "mnuBtnSave"
		'
		'statusStrip
		'
		Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatus})
		Me.statusStrip.Location = New System.Drawing.Point(0, 301)
		Me.statusStrip.Name = "statusStrip"
		Me.statusStrip.Size = New System.Drawing.Size(377, 22)
		Me.statusStrip.TabIndex = 5
		Me.statusStrip.Text = "StatusStrip1"
		'
		'tsStatus
		'
		Me.tsStatus.Name = "tsStatus"
		Me.tsStatus.Size = New System.Drawing.Size(95, 17)
		Me.tsStatus.Text = "Status: Welcome"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(149, 6)
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(377, 323)
		Me.Controls.Add(Me.statusStrip)
		Me.Controls.Add(Me.mnuButtons)
		Me.Controls.Add(Me.mnControls)
		Me.IsMdiContainer = True
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MDI Text Editor"
		Me.textToolTip.SetToolTip(Me, "Main Form that holds all the open files.")
		Me.mnControls.ResumeLayout(False)
		Me.mnControls.PerformLayout()
		Me.mnuButtons.ResumeLayout(False)
		Me.mnuButtons.PerformLayout()
		Me.statusStrip.ResumeLayout(False)
		Me.statusStrip.PerformLayout()
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
	Friend WithEvents mnuWindows As ToolStripMenuItem
	Friend WithEvents mnuCascade As ToolStripMenuItem
	Friend WithEvents mnuVertical As ToolStripMenuItem
	Friend WithEvents mnuHorizontal As ToolStripMenuItem
	Friend WithEvents mnuAverage As ToolStripMenuItem
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents textToolTip As ToolTip
	Friend WithEvents mnuButtons As ToolStrip
	Friend WithEvents mnuBtnNew As ToolStripButton
	Friend WithEvents mnuBtnOpen As ToolStripButton
	Friend WithEvents mnuBtnSave As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents statusStrip As StatusStrip
	Friend WithEvents tsStatus As ToolStripStatusLabel
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
