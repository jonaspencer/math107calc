Option Strict On
Option Infer Off
Option Explicit On

Public Class Supply_Demand


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim slope1 As Double
        Dim slope2 As Double
        Dim intercept1 As Double
        Dim intercept2 As Double
        Dim X As Double
        Dim Y As Double
        Dim Response As String

        Double.TryParse(txtSlope1.Text, slope1)
        Double.TryParse(txtSlope2.Text, slope2)
        Double.TryParse(txtIntercept1.Text, intercept1)
        Double.TryParse(txtIntercept2.Text, intercept2)

        ' If they have the same slope
        If slope1 = slope2 Then
            ' If they have the same y intercept, they are the same line
            If intercept1 = intercept2 Then
                Response = "These lines intersect at every point"
                MessageBox.Show(Response)
                Response = "Same Line"
            Else
                ' else they are parallel
                Response = "These lines are parallel and do not intersect"
                MessageBox.Show(Response)
                Response = "Parallel"
            End If
        Else
            ' Not the same slope
            X = (intercept2 - intercept1) / (slope1 - slope2)
            Y = slope1 * X + intercept1
            Response = "(" & X.ToString & " , " & Y.ToString & ")"
            MessageBox.Show(Response)
        End If

        lblAns.Text = Response

    End Sub

    Private Sub txtSlope2_TextChanged(sender As Object, e As EventArgs) Handles txtSlope1.TextChanged, txtSlope2.TextChanged, txtIntercept1.TextChanged, txtIntercept2.TextChanged
        lblAns.Text = String.Empty
        ' add in stuff to validate input to be numbers, decimal point, and backspace
    End Sub
End Class