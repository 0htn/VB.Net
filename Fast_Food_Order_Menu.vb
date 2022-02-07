Public Class frmFastFoodOrderMenu
  '****************************************************
  '* Author : Huyen Nguyen
  '* Purpose: Fast Food Order Menu
  '* Updated: Feb. 6th, 2022
  '****************************************************

  'Declare the global variable
  Dim totalCost As Double

  'Calculate the total cost
  Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
    totalCost = 0
    'Burgers menu
    If (ChkBurgers.Checked) = True Then
      If (RadRegular.Checked = True) Then
        totalCost += 4.19
      ElseIf (RadCheese.Checked = True) Or (RadBacon.Checked = True) Then
        totalCost += 4.79
      ElseIf (RadBoth.Checked = True) Then
        totalCost += 5.39
      End If
    End If
    'Fries menu
    If (ChkFries.Checked) = True Then
      If (RadSmall.Checked = True) Then
        totalCost += 2.39
      ElseIf (RadMedium.Checked = True) Then
        totalCost += 3.09
      ElseIf (RadLarge.Checked = True) Then
        totalCost += 4.99
      End If
    End If
    'Drinks menu
    If (ChkDrinks.Checked = True) Then
      If (RadSoda.Checked = True) Then
        totalCost += 1.69
      ElseIf (RadWater.Checked = True) Then
        totalCost += 1.49
      End If
    End If

    'Display the total cost
    lblOutput.Text = "Total Cost: " & CStr(totalCost.ToString("C"))

    'None of the box is checked
    If (ChkBurgers.Checked = False) And (ChkFries.Checked = False) And
      (ChkDrinks.Checked = False) Then
      lblOutput.Text = "Must Check Something..."
    End If
  End Sub

  'Reset the menu
  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    ChkBurgers.Checked = False
    ChkFries.Checked = False
    ChkDrinks.Checked = False
    totalCost = 0
    lblOutput.Text = "Ready for next meal..."
  End Sub

  'Close the form
  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub

  'If the burgers box is checked/unchecked
  Private Sub ChkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBurgers.CheckedChanged
    If ChkBurgers.Checked = True Then
      GrpBurgers.Visible = True
    Else
      GrpBurgers.Visible = False
      totalCost = 0
    End If
  End Sub

  'If the fries box is checked/unchecked
  Private Sub ChkFries_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFries.CheckedChanged
    If ChkFries.Checked = True Then
      GrpFries.Visible = True
    Else
      GrpFries.Visible = False
      totalCost = 0
    End If
  End Sub

  'If the drinks box is checked/unchecked
  Private Sub ChkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDrinks.CheckedChanged
    If ChkDrinks.Checked = True Then
      GrpDrinks.Visible = True
    Else
      GrpDrinks.Visible = False
      totalCost = 0
    End If
  End Sub

End Class
