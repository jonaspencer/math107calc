Public Class TimeVal

    Private Sub TimeVal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim dblPrincipal As Double
        Dim intRate As Integer
        Dim intPeriods As Integer
        Dim dblResult As Double
        Dim intYears As Integer


        Double.TryParse(txtPrincipal.Text, dblPrincipal)
        Decimal.TryParse(txtRate.Text, intRate)
        Decimal.TryParse(txtNumPeriods.Text, intPeriods)
        Decimal.TryParse(txtYears.Text, intYears)

        intRate = intRate / 100
        dblResult = (1 + (intRate / intPeriods))
        dblResult = dblResult ^ (intPeriods * intYears)
        dblResult = dblPrincipal * dblResult

        lblAns.Text = dblResult.ToString("n2")

        cboCompoundPeriod.Items.Add("Annually")
        cboCompoundPeriod.Items.Add("Monthly")
        cboCompoundPeriod.Items.Add("Weekly")
        cboCompoundPeriod.Items.Add("Daily")

        cboCompounding.Items.Add("Annually")
        cboCompounding.Items.Add("Monthly")
        cboCompounding.Items.Add("Weekly")
        cboCompounding.Items.Add("Daily")

        cboPeriodType.Items.Add("Annally")
        cboPeriodType.Items.Add("Monthly")
        cboPeriodType.Items.Add("Weekly")
        cboPeriodType.Items.Add("Daily")


    End Sub


End Class