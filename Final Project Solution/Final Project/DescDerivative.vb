Public Class DescDerivative
    Dim addArray(20) As Char
    Dim constArray(20) As Double
    Dim expArray(20) As Double
    Dim counter As Integer = 0
    Dim input As String = " y = "
    Dim output As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtConst.Text IsNot "" AndAlso txtExp.Text IsNot "" Then
            counter = counter + 1
            If radNeg.Checked = True Then
                addArray(counter) = "-"
                input = input + " - "
            Else
                addArray(counter) = "+"
                If input IsNot " y = " Then
                    input = input + " + "
                End If
            End If
            constArray(counter) = Convert.ToDouble(txtConst.Text)
            expArray(counter) = Convert.ToDouble(txtExp.Text)
            input = input + "(" + txtConst.Text + " x " + " ^ " + txtExp.Text + ")"
            lblFormula.Text = input
            txtExp.Clear()
            txtConst.Clear()
            radNeg.Checked = False
            txtConst.Focus()
        End If
    End Sub

    Private Sub fieldTextChanged(sender As Object, e As KeyPressEventArgs) Handles txtConst.KeyPress, txtExp.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        input = " y = "
        counter = 0
        lblFormula.Text = input
        txtExp.Clear()
        txtConst.Clear()
        radNeg.Checked = False
        txtConst.Focus()
    End Sub
End Class