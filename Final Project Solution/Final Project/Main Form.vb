Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Dim sd As Supply_Demand = New Supply_Demand()
    Dim pf As ProfitModel = New ProfitModel()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sd.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pf.Show()
    End Sub
End Class
