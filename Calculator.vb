Public Class Calculator
  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		'Calculate the numeric expression
		On Error Resume Next
		Dim int1 As Integer 'From User
		Dim int2 As Integer 'From User
		Dim result As Double
		Dim operators As New List(Of String) From
				{"+", "-", "*", "/", "^"}

		int1 = txtIntOne.Text
		int2 = txtIntTwo.Text

		'Process the data
		For Each operato As String In operators
			operato = Operators_.Text
			If operato = "+" Then
				result = int1 + int2
			ElseIf operato = "-" Then
				result = int1 - int2
			ElseIf operato = "*" Then
				result = int1 * int2
			ElseIf operato = "/" Then
				result = int1 / int2
			ElseIf operato = "^" Then
				result = int1 ^ int2
			Else
				result = 0
			End If
		Next

		'Output the result
		MsgBox(result)

	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		'Clear inputs
		txtIntOne.Clear()
		txtIntTwo.Clear()
		Operators_.Clear()
	End Sub
End Class
