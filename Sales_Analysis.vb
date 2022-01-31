Public Class Sales_Analysis
  Private Sub btnStatus_Output_Click(sender As Object, e As EventArgs) Handles btnStatus_Output.Click
    
    On Error Resume Next
    Dim a As Double 'From User
    Dim b As Double 'From User
    Dim c As Double 'From User
    Dim x As Double 'From User
    Dim revenue As Double
    Dim total As Double
    Dim result As String
    a = txtMarginalRevenue.Text
    b = txtMarginalCost.Text
    c = txtFixedCost.Text
    x = txtNumOfUnits.Text
    'Calculate
    'x units of product cost
    revenue = a * x
    'total cost
    total = b * x + c
    
    result = revenue - total
    'Display Status and Output
    Select Case result
      Case Is > 0
        txtStatus.Text = "Profit"
      Case Is < 0
        txtStatus.Text = "Loss"
      Case Is = 0
        txtStatus.Text = "Break Even"
    End Select
  txtOutput.Text = "$" + result
  End Sub
End Class
