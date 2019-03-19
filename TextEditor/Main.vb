Public Class Main
	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	' displays the AverageByEmployee form as a child
	Private Sub OpenAverageByEmployee(sender As Object, e As EventArgs) Handles mnuAverage.Click
		Dim newMDI As frmAverage = New frmAverage
		newMDI.MdiParent = Me
		newMDI.Show()
	End Sub

	' opens a new form as frmEditor
	Private Sub NewFile(sender As Object, e As EventArgs) Handles mnuNew.Click
		Dim newMDI As frmEditor = New frmEditor
		newMDI.Text = ""
		newMDI.MdiParent = Me
		newMDI.Show()
	End Sub

	' displays the information about the application
	Private Sub AboutApplication(sender As Object, e As EventArgs) Handles mnuAbout.Click
		MessageBox.Show("NETD-2202" + vbCrLf + "MDI Text Editor" + vbCrLf + "Brennan Kerr", "About")
	End Sub


	' open a new form
	Private Sub OpenEditor(sender As Object, e As EventArgs) Handles mnuOpen.Click
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			Dim newMDI As frmEditor = New frmEditor
			newMDI.MdiParent = Me
			newMDI.OpenFile(OpenFileDialog1.FileName)

			newMDI.Show()
		End If
	End Sub


	' exits the application
	Private Sub ExitApplication(sender As Object, e As EventArgs) Handles mnuExit.Click
		Close()
	End Sub

	' Cascades the MDI
	Private Sub CascadeForm(sender As Object, e As EventArgs) Handles mnuCascade.Click
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	'Makes all the 
	Private Sub VerticalLayout(sender As Object, e As EventArgs) Handles mnuVertical.Click
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	'
	Private Sub HorizontalLayout(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub
End Class