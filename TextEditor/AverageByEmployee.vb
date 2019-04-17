' AverageUnitsShippedByEmployee
' Brennan Kerr
' February 5th 2019
' Takes input for three employees for a week and calculates the averages

Option Strict On

Public Class frmAverage
	' CONSTANTS ----------------------------
	Const NUM_OF_DAYS As Integer = 7        ' the number of days that will be entered per employee
	Const NUM_OF_EMPLOYEES As Integer = 3   ' the number of employees that will be entered
	Const TOTAL_NUM_OF_DAYS As Integer = NUM_OF_DAYS * NUM_OF_EMPLOYEES ' the total number of days for all employees.
	Const MAX_VALUE As Integer = 1000   ' the minimum value that can be entered
	Const MIN_VALUE As Integer = 0      ' the maximum value that can be entered

	' ARRAYS ----------------------------
	Dim tbEmployeeOutput(NUM_OF_EMPLOYEES) As TextBox   ' saves the tbOutputs into an array
	Dim tbEmployeeAverage(NUM_OF_EMPLOYEES) As TextBox  ' saves the tbAvg textboxes into an array
	Dim values(NUM_OF_EMPLOYEES, NUM_OF_DAYS) As Integer ' saves all the items sold into a 2 dimensional array
	Dim lbEmployeeLabel(NUM_OF_EMPLOYEES) As Label   ' saves the employee labels to an array

	' COUNTERS ----------------
	Dim employee As Integer = 0 ' used to determines which employee is entered
	Dim day As Integer = 0      ' used to determine which day is being inputed

	' TOTALS -----------------
	Dim overallTotal As Integer = 0 ' will add up every value
	Dim currentTotal As Integer = 0 ' will add up the current values

	' FONT ---------------------------------
	Dim fontBold As Font ' creates a font veriable for when bold is used

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' saves the output textboxes to an array
		tbEmployeeOutput(0) = tbOutputOne
		tbEmployeeOutput(1) = tbOutputTwo
		tbEmployeeOutput(2) = tbOutputThree

		' saves the average textboxes to an array
		tbEmployeeAverage(0) = tbAvgOne
		tbEmployeeAverage(1) = tbAvgTwo
		tbEmployeeAverage(2) = tbAvgThree

		' saves all the employee labels to an array
		lbEmployeeLabel(0) = lbEmployeeOne
		lbEmployeeLabel(1) = lbEmployeeTwo
		lbEmployeeLabel(2) = lbEmployeeThree

		' saves the font as bold
		fontBold = New Font(lbInput.Font, FontStyle.Bold)

		' makes the first employee label bold
		lbEmployeeLabel(0).Font = fontBold
	End Sub

	' takes the input
	Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
		ValidateInput(tbInput.Text)
	End Sub

	' validates the input
	Private Sub ValidateInput(input As String)
		' saves the value if it is valid
		Dim number As Integer

		' if the input is a integer
		If Integer.TryParse(input, number) Then
			If MIN_VALUE <= number And number <= MAX_VALUE Then
				values(employee, day) = number  ' saves the value to its appropriate place in an array
				day = day + 1 ' adds one to the day

				' displays the information in the text box
				tbEmployeeOutput(employee).Text = tbEmployeeOutput(employee).Text + number.ToString() + vbCrLf

				' adds the value to the current total
				currentTotal = currentTotal + number
				overallTotal = overallTotal + number

				' clears and focuses on the input textbox
				tbInput.Clear()
				tbInput.Focus()

				' changes the input label text
				lbInput.Text = "Day " + (day + 1).ToString
			Else
				' calls ERRORMESSAGE subroutine
				ErrorMessage()
			End If
		Else
			' calls ERRORMESSAGE subrouting
			ErrorMessage()
		End If

		' checks to see if the number of days has reached the maximum amount of days
		If day = NUM_OF_DAYS Then

			' determines the average for the employee
			Average()

			' if the current employee value has reached the maximum number of employees
			' disable the buttons and display the overall average
			If employee = NUM_OF_EMPLOYEES Then

				' remves bold from the last label
				lbEmployeeLabel(employee - 1).Font = Font

				btnEnter.Enabled = False
				tbInput.ReadOnly = True
				tbOutput.Text = "Average per day: " + Math.Round((overallTotal / TOTAL_NUM_OF_DAYS), 2).ToString

				lbInput.Text = "Done"

				btnReset.Focus()
			Else
				' resets the day
				day = 0

				' changes which employee label has bold
				lbEmployeeLabel(employee).Font = fontBold
				lbEmployeeLabel(employee - 1).Font = Font

				lbInput.Text = "Day 1"
			End If
		End If
	End Sub

	' displays the average and changes any values associated with the average
	Private Sub Average()
		tbEmployeeAverage(employee).Text = "Average: " + Math.Round((currentTotal / NUM_OF_DAYS), 2).ToString
		currentTotal = 0
		employee = employee + 1
	End Sub

	' displays an error message
	Private Sub ErrorMessage()
		MessageBox.Show("Please enter a number between " + MIN_VALUE.ToString + " and " + MAX_VALUE.ToString + " inclusive")
		tbInput.Focus()
		tbInput.SelectAll()
	End Sub

	' reset the application
	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		' resets the values and clear the textboxes
		For employeeCount = 0 To NUM_OF_EMPLOYEES - 1
			For dayCount = 0 To NUM_OF_DAYS - 1
				values(employeeCount, dayCount) = 0
			Next

			tbEmployeeOutput(employeeCount).Clear()
			tbEmployeeAverage(employeeCount).Clear()
		Next

		' clears any other values/controls
		tbOutput.Clear()
		btnEnter.Enabled = True
		tbInput.ReadOnly = False

		' resets all counters
		employee = 0
		day = 0
		currentTotal = 0
		overallTotal = 0

		' moves focus to the input textbox
		tbInput.Focus()

		' resets the bold
		lbEmployeeLabel(0).Font = fontBold

		For employeeCount = 1 To NUM_OF_EMPLOYEES - 1
			lbEmployeeLabel(employeeCount).Font = Font
		Next

		' resets the input label
		lbInput.Text = "Day 1"
	End Sub

	' Exits the Application
	Private Sub ExitApplication(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub
End Class
