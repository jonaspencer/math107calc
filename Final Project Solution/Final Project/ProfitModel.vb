Option Strict On
Option Explicit On
Option Infer Off

Public Class ProfitModel
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim CostQ As Double
        Dim RevK As Double

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim OptQ As Double
        Dim Profit As Double

        Double.TryParse(txtPriceK.Text, RevK)
        Double.TryParse(txtPriceQ.Text, a)
        Double.TryParse(txtCostK.Text, c)
        Double.TryParse(txtCostQ.Text, CostQ)

        b = RevK - CostQ

        ' Sets up quadratic formula for bot
        OptQ = (((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a) + ((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a)) / 2
        Profit = a * Math.Pow(OptQ, 2) + b * OptQ + c

        lblQuantity.Text = OptQ.ToString()
        lblProfit.Text = Profit.ToString()

    End Sub
End Class