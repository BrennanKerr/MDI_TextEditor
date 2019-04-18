' Main.vb - The parent of all forms
' @author	Brennan Kerr
' @since	19 Mar 2019

Option Strict On


Public Class frmMain

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	' OpenAverageByEmployee - Opens the AverageByEmployee form
	'						  Runs if the average menu button is pressed
	' @param	sender : object
	' @param	e : EventArgs
	Private Sub OpenAverageByEmployee(sender As Object, e As EventArgs) Handles mnuAverage.Click
		Try
			Dim newChild As frmAverage = New frmAverage
			newChild.MdiParent = Me
			newChild.Show()
			tsStatus.Text = "Status: Opening Average By Employee"
		Catch ex As Exception
			Console.WriteLine(ex.ToString())
		End Try
	End Sub

	' NewFile - Creates a blank frmEditor form that allows for editing
	'			Runs if the new menuitem or button are pressed
	' @param	sender : object
	' @param	e : EventArgs
	Private Sub NewFile(sender As Object, e As EventArgs) Handles mnuNew.Click, mnuBtnNew.Click
		Try
			Dim newChild As frmEditor = New frmEditor
			newChild.Text = "New"
			newChild.MdiParent = Me
			newChild.Show()
			tsStatus.Text = "Status: Creating new File"
		Catch ex As Exception
			Console.WriteLine(ex.ToString())
		End Try
	End Sub

	' AboutApplication - Displays information about the application
	'					 Runs if the about menu button is pressed
	' @param	sender : object
	' @param	e : EventArgs
	Private Sub AboutApplication(sender As Object, e As EventArgs) Handles mnuAbout.Click
		MessageBox.Show("NETD-2202" + vbCrLf + "MDI Text Editor" + vbCrLf + "Brennan Kerr", "About")
	End Sub


	' OpenEditor - Opens a currently existing file
	'			   Runs if the open menu item or button are pressed
	' @param	sender : object
	' @param	e : EventArgs
	Private Sub OpenEditor(sender As Object, e As EventArgs) Handles mnuOpen.Click, mnuBtnOpen.Click
		OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"

		Try
			If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
				Dim newChild As frmEditor = New frmEditor
				newChild.MdiParent = Me

				newChild.OpenFile(OpenFileDialog1.FileName)

				newChild.Show()
				tsStatus.Text = "Status: Opened " + OpenFileDialog1.FileName
			End If
		Catch ex As Exception
			Console.WriteLine(ex.ToString())
		End Try
	End Sub

	' SaveActiveForm - Saves the currently selected form
	'					Runs if the save menu item or button are pressed
	' @param	sender : object
	' @param	e : EventArgs
	Private Sub SaveActiveForm(sender As Object, e As EventArgs) Handles mnuSave.Click, mnuBtnSave.Click
		Try
			If Me.MdiChildren.Length > 0 Then

				If TypeOf Me.ActiveMdiChild Is frmEditor Then
					Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
					activeChild.SaveFile(sender, e)
					tsStatus.Text = "Status: Saved form " + activeChild.GetPath()
				Else
					ErrorMessage()
				End If
			End If

		Catch ex As Exception
			Console.WriteLine(ex.ToString())
		End Try
	End Sub

	' SaveActiveFormAs - Saves the currently selected form to a desired location
	'						Runs if the save as menu item is pressed
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub SaveActiveFormAs(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
		Try
			If Me.MdiChildren.Length > 0 Then
				SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"

				If TypeOf Me.ActiveMdiChild Is frmEditor Then
					Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
					activeChild.SaveFileAs(sender, e)
					tsStatus.Text = "Status: Saved Form As " + activeChild.GetPath()
				Else
					ErrorMessage()
				End If
			End If

		Catch ex As Exception
			Console.WriteLine(ex.ToString())
		End Try
	End Sub

	' ======================= 
	' = CLIPBOARD PROCESSES =
	' =======================

	' CopyActivated - Copies the desired text to the computers clipboard
	'					Runs if the copy menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub CopyActivated(sender As Object, e As EventArgs) Handles mnuCopy.Click
		If TypeOf Me.ActiveMdiChild Is frmEditor And Me.MdiChildren.Length > 0 Then
			Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
			activeChild.tbInput.Copy()
			tsStatus.Text = "Status: Copied text"
		End If
	End Sub

	' CutActivated - Removes the text from the desired form and saves it to the clipboard
	'				 Runs if the cut menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub CutActivated(sender As Object, e As EventArgs) Handles mnuCut.Click
		If TypeOf Me.ActiveMdiChild Is frmEditor And Me.MdiChildren.Length > 0 Then
			Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
			activeChild.tbInput.Cut()
			tsStatus.Text = "Status: Cut Text"
		End If
	End Sub

	' PasteActivated - Pastes the text from the clipboard onto the desired form
	'					Runs if the paste menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub PasteActivated(sender As Object, e As EventArgs) Handles mnuPaste.Click
		If TypeOf Me.ActiveMdiChild Is frmEditor And Me.MdiChildren.Length > 0 Then
			Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
			activeChild.tbInput.Paste()
			tsStatus.Text = "Status: Pasted Text"
		End If
	End Sub

	' ======================= 
	' == CLOSING PROCESSES ==
	' =======================

	' ExitApplication - Exits the mdi, closing all forms
	'					Runs if the exit menu item is selected
	' @param	sender : Object
	' @param	e : Event Args
	Private Sub ExitApplication(sender As Object, e As EventArgs) Handles mnuExit.Click
		Close()
	End Sub

	' CloseActive - Closes the currently selected form
	'				Runs if the close menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub CloseActive(sender As Object, e As EventArgs) Handles mnuClose.Click
		' checks to see if there are any opened children
		If Me.MdiChildren.Length > 0 Then
			' runs through the ExitApplication method of the frmEditor class if the form is a text editor
			If TypeOf Me.ActiveMdiChild Is frmEditor Then
				Dim activeChild As frmEditor = CType(Me.ActiveMdiChild, frmEditor)
				tsStatus.Text = "Status: Closed Form " + activeChild.GetPath()
				activeChild.ExitApplication(sender, e)

				' closes any other application
			Else
				tsStatus.Text = "Status: Closed Average By Employee"
				ActiveMdiChild.Close()
			End If
		End If
	End Sub

	' ======================
	' == LAYOUT PROCESSES ==
	' ======================

	' CascadeForm - Organizes the windows into a cascading style
	'				Runs if the cascade menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub CascadeForm(sender As Object, e As EventArgs) Handles mnuCascade.Click
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	' VerticalLayout - Organizes the windows into a vertical style
	'					Runs if the vertical menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub VerticalLayout(sender As Object, e As EventArgs) Handles mnuVertical.Click
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	' HorizontalLayout - Organizes the windows into a horizontal style
	'						Runs if the horizontal menu item is selected
	' @param	sender : Object
	' @param	e : EventArgs
	Private Sub HorizontalLayout(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	' ErrorMessage - Displays an error message if the action the user is attempting to do is prohibited
	' @param	none
	Private Sub ErrorMessage()
		MessageBox.Show("You cannot save this form as it has been prohibited.")
	End Sub
End Class