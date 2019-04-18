' TextEditor - An application that allows text to be edited
' Brennan Kerr
' February 12th, 2019


Option Strict On

Imports System.IO

Public Class frmEditor
	Dim path As String = ""             ' saves the path of the current file
	Dim previousText As String = ""     ' saves the previous text of the file (Either when opened or saved)
	Dim currentFile As FileStream
	Dim reader As StreamReader          ' steamreader that displays the text
	Dim writer As StreamWriter          ' streamwriter to save all the text to a given file

	''' <summary>
	''' AttemptingToClose - If the user presses 'X', checks to see if any text has been changed
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub AttemptingToClose(sender As Object, e As EventArgs) Handles Me.FormClosing
		ExitApplication(sender, e)
	End Sub

	''' <summary>
	''' AboutApplication - Displays the information about the application
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub AboutApplication(sender As Object, e As EventArgs)
		MessageBox.Show("NETD-2202" + vbCrLf + "Lab # 5" + vbCrLf + "Brennan Kerr", "About")
	End Sub

	''' <summary>
	''' ExitApplication - Determines if the file can save or not
	'''					- If text has been edited, go to the SaveFileAs subroutine
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
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

	''' <summary>
	''' OpenFile - Open a new file, determined by the user
	''' </summary>
	''' <param name="newPath">The location of the file on the hard drive</param>
	Public Sub OpenFile(newPath As String)
		path = newPath
		currentFile = New FileStream(path, FileMode.Open, FileAccess.ReadWrite)
		reader = New StreamReader(currentFile)

		tbInput.Text = reader.ReadToEnd

		previousText = tbInput.Text

		reader.Close()

		Text = "Text Editor: " + path + " Open"
	End Sub

	''' <summary>
	''' SaveFile - If the file exists, saves it to the current path, otherwise, go to the SaveFileAs() subroutine
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Public Sub SaveFile(sender As Object, e As EventArgs)
		' if the file already exists
		If File.Exists(path) Then
			currentFile = New FileStream(path, FileMode.Create, FileAccess.Write)
			writer = New StreamWriter(currentFile)

			writer.Write(tbInput.Text)
			writer.Close()

			previousText = tbInput.Text ' saves the previous text to memory


			' if the file does not exists (it is a new file), goes to the SaveFileAs method
		Else
			SaveFileAs(sender, e)
		End If

	End Sub

	''' <summary>
	''' SaveFileAs - Allows the user to pick the location of the file and saves the current text to previousText
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Public Sub SaveFileAs(sender As Object, e As EventArgs)
		If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
			path = SaveFileDialog1.FileName
			My.Computer.FileSystem.WriteAllText(path, tbInput.Text, False)
			Me.Text = path
		End If

		' saves the previous text to memory
		previousText = tbInput.Text
	End Sub


	''' <summary>
	''' CheckText - Determines if the text has been changed
	''' </summary>
	''' <returns>state: boolean - False if text has been changed, true if it has not been motified</returns>
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

	''' <summary>
	''' GetPath() - Sets or returns the location of the given file
	''' </summary>
	''' <returns>path: string - The location of the file</returns>
	Public Property GetPath() As String
		Get
			Return path
		End Get
		Set(value As String)
			path = value
		End Set
	End Property

	Private Sub frmEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class