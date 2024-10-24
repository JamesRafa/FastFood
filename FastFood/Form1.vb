
Public Class Form1
    Dim Burger As Double
    Dim Fries As Double
    Dim Hotdog As Double
    Dim Yumburger As Double
    Public Property Total As String

    Private Sub btnBurgerPlus_Click(sender As Object, e As EventArgs) Handles btnBurgerPlus.Click
        txtBurger.Text += 1

    End Sub

    Private Sub btnFriesPlus_Click(sender As Object, e As EventArgs) Handles btnFriesPlus.Click
        txtFries.Text += 1
    End Sub

    Private Sub btnHotdogPlus_Click(sender As Object, e As EventArgs) Handles btnHotdogPlus.Click
        txtHotdog.Text += 1
    End Sub

    Private Sub btnYumburgerPlus_Click(sender As Object, e As EventArgs) Handles btnYumburgerPlus.Click
        txtYumburger.Text += 1
    End Sub





    Private Sub btnBurgerMinus_Click(sender As Object, e As EventArgs) Handles btnBurgerMinus.Click
        txtBurger.Text -= 1
        If txtBurger.Text <= 0 Then
            txtBurger.Text = 0
        End If
    End Sub

    Private Sub btnFriesMinus_Click(sender As Object, e As EventArgs) Handles btnFriesMinus.Click
        txtFries.Text -= 1
        If txtFries.Text <= 0 Then
            txtFries.Text = 0
        End If
    End Sub

    Private Sub btnHotdogMinus_Click(sender As Object, e As EventArgs) Handles btnHotdogMinus.Click
        txtHotdog.Text -= 1
        If txtHotdog.Text <= 0 Then
            txtHotdog.Text = 0
        End If
    End Sub
    Private Sub btnYumburgerMinus_Click(sender As Object, e As EventArgs) Handles btnYumburgerMinus.Click
        txtHotdog.Text -= 1
        If txtHotdog.Text <= 0 Then
            txtHotdog.Text = 0
        End If


    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Burger = txtBurger.Text * 50
        Fries = txtFries.Text * 45
        Hotdog = txtHotdog.Text * 35
        Yumburger = txtYumburger.Text * 45

        txtTotal.Text = "₱" & Format(Burger + Fries + Hotdog + Yumburger, "0.00")
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        Total = txtTotal.Text

        MessageBox.Show("Burgers:" & Burger & vbCrLf & "Fries:" & Fries & vbCrLf & "Hotdog:" & Hotdog & vbCrLf & "Yumburger:" & Yumburger & vbCrLf & "Total:" & Total)

    End Sub

    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click
        txtBurger.Text = 0
        txtFries.Text = 0
        txtHotdog.Text = 0
        txtYumburger.Text = 0
        txtTotal.Text = 0

        Burger = 0
        Fries = 0
        Hotdog = 0
        Yumburger = 0
        Total = 0
    End Sub
End Class
