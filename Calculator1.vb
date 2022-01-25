Public Class Calculator
	  Dim intN1 As Integer 'From User
	  Dim intN2 As Integer 'From User
	  Dim result As Integer
	
	  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
	    intN1 = txtInt1.Text
	    intN2 = txtInt2.Text
	    'Calculate the numeric
	    result = intN1 + intN2
	    MsgBox(intN1 & "+" & intN2 & "=" & result)
	  End Sub
	
	  Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
	    intN1 = txtInt1.Text
	    intN2 = txtInt2.Text
	    'Calculate the numeric
	    result = intN1 - intN2
	    MsgBox(intN1 & "-" & intN2 & "=" & result)
	  End Sub

	  Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
	    intN1 = txtInt1.Text
	    intN2 = txtInt2.Text
	    'Calculate the numeric
	    result = intN1 * intN2
	    MsgBox(intN1 & "x" & intN2 & "=" & result)
	  End Sub
	  
	  Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
	    intN1 = txtInt1.Text
	    intN2 = txtInt2.Text
	    'Calculate the numeric
	    result = intN1 / intN2
	    MsgBox(intN1 & "/" & intN2 & "=" & result)
	  End Sub
	
	  Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
	    intN1 = txtInt1.Text
	    intN2 = txtInt2.Text
	    'Calculate the numeric
	    result = intN1 ^ intN2
	    MsgBox(intN1 & "^" & intN2 & "=" & result)
	  End Sub
	  
	  Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
	    intN1 = txtInt1.Text
	    intN2 = txtInt2.Text
	    'Calculate the numeric
	    result = intN1 \ intN2
	    MsgBox(intN1 & "\" & intN2 & "=" & result)
	  End Sub
	  
	  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
	    'Clear inputs
	    int1.Clear()
	    int2.Clear()
	  End Sub
	
End Class
