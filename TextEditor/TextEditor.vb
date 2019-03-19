' TextEditor - An application that allows text to be edited
' Brennan Kerr
' February 12th, 2019


Option Strict On

Imports System.IO

Public Class frmEditor
	Dim path As String = "New"
	Dim previousText As String = ""
	Dim fileRead As FileStream
	Dim fileWrite As FileStream
	Dim reader As StreamReader
	Dim writer As StreamWriter

	Private Sub Load_FrmEditor(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub AttemptingToClose(sender As Object, e As EventArgs) Handles Me.FormClosing
		ExitApplication(sender, e)
	End Sub

	' displays the information about the application
	Private Sub mnuAbout_Click(sender As Object, e As EventArgs)
		MessageBox.Show("NETD-2202" + vbCrLf + "Lab # 5" + vbCrLf + "Brennan Kerr", "About")
	End Sub

	' if the user wants to exit the application
	Public Sub ExitApplication(sender As Object, e As EventArgs)
		' checks to see if the text hasnt changed
		If CheckText() = True Then
			Me.Dispose()
			' if the text has changed
		Else
			SaveFileAs(sender, e)
			Me.Dispose()
		End If
	End Sub

	' if the user wants to open a file
	Public Sub OpenFile(newPath As String)
		path = newPath
		fileRead = New FileStream(path, FileMode.Open, FileAccess.ReadWrite)
		reader = New StreamReader(fileRead)

		tbInput.Text = reader.ReadToEnd

		previousText = tbInput.Text

		reader.Close()

		Text = "Text Editor: " + path + " Open"
	End Sub

	' if the user wants to save the file
	Private Sub SaveFile(sender As Object, e As EventArgs)
		' if the file already exists
		If File.Exists(path) Then
			fileWrite = New FileStream(path, FileMode.Create, FileAccess.Write)
			writer = New StreamWriter(fileWrite)

			writer.Write(tbInput.Text)
			writer.Close()
			' if the file does not exists (it is a new file), goes to the SaveFileAs method
		Else
			SaveFileAs(sender, e)
		End If

		previousText = tbInput.Text
	End Sub

	' if the user wants to save the file as something else
	Private Sub SaveFileAs(sender As Object, e As EventArgs)
		If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
			path = SaveFileDialog1.FileName
			My.Computer.FileSystem.WriteAllText(path, tbInput.Text, False)
		End If

		previousText = tbInput.Text
	End Sub


	' cuts the text
	Public Sub CutText(sender As Object, e As EventArgs)
		' cuts the text
		tbInput.Cut()
	End Sub

	' if the user wants to copy text
	Public Sub CopyText(sender As Object, e As EventArgs)
		tbInput.Copy()
	End Sub

	' if the user wants to past text
	Public Sub PasteText(sender As Object, e As EventArgs)
		' gets the copied text
		tbInput.Paste()
	End Sub

	' if the text has been altered
	Private Function CheckText() As Boolean
		Dim state As Boolean

		' checks to see if the text has been altered
		If previousText = tbInput.Text Or (previousText = "" And tbInput.Text = "") Then
			state = True
		Else
			state = False
		End If

		Return state
	End Function
End Class