Public Class AvgRateofChange

    Private dblPower As Double

    Function findAvg(ByVal A As Double, ByVal B As Double, ByVal C As Double, ByVal X As Double) As Double
        Dim dblResult As Double
        If txtPower.Text = "" Then
            txtPower.Text = 1
        End If

        Double.TryParse(txtPower.Text, dblPower)
        X = Math.Pow(X, dblPower)
        dblResult = (A * X) + (B * X) + C

        Return dblResult

    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblXInitial As Double
        Dim dblXFinal As Double
        Dim dblA As Double
        Dim dblB As Double
        Dim dblC As Double
        Dim dblResult As Double
        Dim dblResultXinitial As Double
        Dim dblResultXfinal As Double

        Double.TryParse(txtXinital.Text, dblXInitial)
        Double.TryParse(txtXfinal.Text, dblXFinal)
        Double.TryParse(txtA.Text, dblA)
        Double.TryParse(txtB.Text, dblB)
        Double.TryParse(txtC.Text, dblC)

        dblResultXinitial = findAvg(dblA, dblB, dblC, dblXInitial)
        dblResultXfinal = findAvg(dblA, dblB, dblC, dblXFinal)

        dblResult = (dblResultXfinal - dblResultXinitial) / (dblXFinal - dblXInitial)

        lblResult.Text = dblResult.ToString

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
        txtPower.Text = ""
        txtXfinal.Text = ""
        txtXinital.Text = ""
    End Sub

    Private Sub txtA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtA.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtB.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtB.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtC.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtPower_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPower.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtPower.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtXfinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtXfinal.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtXfinal.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtXinitial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtXinital.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If (txtXinital.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub




End Class