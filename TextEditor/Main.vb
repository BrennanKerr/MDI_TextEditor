' Main.vb - The parent of all forms
' @author	Brennan Kerr
' @since	19 Mar 2019

Option Strict On


Public Class frmMain

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	' displays the AverageByEmployee form as a child
	Private Sub OpenAverageByEmployee(sender As Object, e As EventArgs) Handles mnuAverage.Click
		Dim newMDI As frmAverage = New frmAverage
		newMDI.MdiParent = Me
		newMDI.Show()
	End Sub

	' opens a new form as frmEditor
	Private Sub NewFile(sender As Object, e As EventArgs) Handles mnuNew.Click, mnuBtnNew.Click
		Dim newMDI As frmEditor = New frmEditor
		newMDI.Text = "New"
		newMDI.MdiParent = Me
		newMDI.Show()

		AddItemToWindows(newMDI)
	End Sub

	' displays the information about the application
	Private Sub AboutApplication(sender As Object, e As EventArgs) Handles mnuAbout.Click
		MessageBox.Show("NETD-2202" + vbCrLf + "MDI Text Editor" + vbCrLf + "Brennan Kerr", "About")
	End Sub


	' open a new form
	Private Sub OpenEditor(sender As Object, e As EventArgs) Handles mnuOpen.Click, mnuBtnOpen.Click
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			Dim newMDI As frmEditor = New frmEditor
			newMDI.MdiParent = Me
			newMDI.OpenFile(OpenFileDialog1.FileName)

			newMDI.Show()

			AddItemToWindows(newMDI)
		End If
	End Sub

	' Save current form
	Private Sub SaveActiveForm(sender As Object, e As EventArgs) Handles mnuSave.Click, mnuBtnSave.Click
		If TypeOf Me.ActiveMdiChild Is frmEditor Then
			Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
			activeChild.SaveFile(sender, e)
		Else
			ErrorMessage()
		End If
	End Sub

	' Save Active Form As
	Private Sub SaveActiveFormAs(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
		If TypeOf Me.ActiveMdiChild Is frmEditor Then
			Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
			activeChild.SaveFileAs(sender, e)

		Else
			ErrorMessage()
		End If
	End Sub

	Private Sub CopyActivated(sender As Object, e As EventArgs) Handles mnuCopy.Click
		Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
		activeChild.CopyText(sender, e)
	End Sub

	Private Sub CutActivated(sender As Object, e As EventArgs) Handles mnuCut.Click
		Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
		activeChild.CutText(sender, e)
	End Sub

	Private Sub PasteActivated(sender As Object, e As EventArgs) Handles mnuPaste.Click
		Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
		activeChild.PasteText(sender, e)
	End Sub

	' exits the application
	Private Sub ExitApplication(sender As Object, e As EventArgs) Handles mnuExit.Click
		Close()
	End Sub

	' Cascades the MDI
	Private Sub CascadeForm(sender As Object, e As EventArgs) Handles mnuCascade.Click
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	'Makes all the forms vertically alligned
	Private Sub VerticalLayout(sender As Object, e As EventArgs) Handles mnuVertical.Click
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	' Makes all the forms horizontally alligned
	Private Sub HorizontalLayout(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	' Closes whichever child is currently active
	Private Sub CloseActive(sender As Object, e As EventArgs) Handles mnuClose.Click
		' runs through the ExitApplication method of the frmEditor class if the form is a text editor
		If TypeOf Me.ActiveMdiChild Is frmEditor Then
			Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
			activeChild.ExitApplication(sender, e)

			' simply disposes of the form if it is the AverageByEmployee form
		Else
			ActiveMdiChild.Dispose()
		End If
	End Sub

	Private Sub AddItemToWindows(newMDI As frmEditor)

		MnuWindows.DropDown.Items.Add(newMDI.NumberAssignment().ToString() + newMDI.GetPath())
	End Sub

	' Displays an error message when attempting to save the AverageByEmployee
	Private Sub ErrorMessage()
		MessageBox.Show("You cannot save this form as it has been prohibited." + vbCrLf + vbCrLf + "Form: Average By Employee", "Cannot Save Form")
	End Sub
End Class