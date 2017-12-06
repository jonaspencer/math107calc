Public Class TimeVal

    Function findFV(ByVal PV As Double, i As Double, n As Integer, t As Integer) As Double
        Dim FV As Double
        i = i / 100
        FV = PV * (1 + (i / n)) ^ (n * t)
        Return FV

    End Function


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblPrincipal As Double
        Dim intRate As Integer
        Dim intYears As Integer
        Dim intCPeriods As Integer
        Dim dblFv As Double


        Double.TryParse(txtPrincipal.Text, dblPrincipal)
        Decimal.TryParse(txtInterestRate.Text, intRate)
        Decimal.TryParse(txtYears.Text, intYears)

        If radQuarterly.Checked Then
            intCPeriods = 4
        End If

        If radMonthly.Checked Then
            intCPeriods = 12
        End If

        If radDaily.Checked Then
            intCPeriods = 365
        End If

        If radYearly.Checked Then
            intCPeriods = 1
        End If

        dblFv = findFV(dblPrincipal, intRate, intCPeriods, intYears)

        lblAns.Text = dblFv.ToString("c2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblAns.Text = ""
        txtYears.Text = ""
        txtInterestRate.Text = ""
        txtPrincipal.Text = ""

    End Sub

    Private Sub TimeVal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radYearly.Checked = True

    End Sub

    Private Sub txtInterestRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInterestRate.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtInterestRate.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub txtPrincipal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrincipal.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
        If (txtPrincipal.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtYears_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYears.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If



    End Sub


End Class