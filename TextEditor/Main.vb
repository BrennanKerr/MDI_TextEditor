Public Class Main
	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	' displays the AverageByEmployee form as a child
	Private Sub AverageUnitsSoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAverage.Click
		Dim newMDI As frmAverage = New frmAverage
		newMDI.MdiParent = Me
		newMDI.Show()
	End Sub

	Private Sub NewFile(sender As Object, e As EventArgs) Handles mnuNew.Click
		Dim newMDI As frmEditor = New frmEditor
		newMDI.MdiParent = Me
		newMDI.Show()
	End Sub
End Class