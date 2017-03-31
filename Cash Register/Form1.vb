Public Class FrmCashRegister

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        Dim decTax As Decimal = 0.0775D
        Dim strItemPurchased As String
        Dim strAmount As String
        Dim decTotalCost As Decimal
        Dim decTaxAmount As Decimal
        Dim decAmount As Decimal

        strItemPurchased = TxtItem.Text
        strAmount = TxtAmount.Text
        decAmount = Convert.ToDecimal(strAmount)
        decTaxAmount = decTax * decAmount
        decTotalCost = decTaxAmount + decAmount
        LblTotalAmount.Text = decTotalCost.ToString("c")
        LblTaxAmount.Text = decTaxAmount.ToString("c")
        LblItemSelected.Text = strItemPurchased
        LblCostAmount.Text = decAmount.ToString("c")










    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtAmount.Clear()
        TxtItem.Clear()
        LblCostAmount.Text = ""
        LblItemSelected.Text = ""
        LblTotalAmount.Text = ""
        LblTaxAmount.Text = ""
        TxtItem.Focus()


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()

    End Sub


    Private Sub FrmCashRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCostAmount.Text = ""
        LblItemSelected.Text = ""
        LblTaxAmount.Text = ""
        LblTotalAmount.Text = ""

    End Sub
End Class
