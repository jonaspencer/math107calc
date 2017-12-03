Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sd As Supply_Demand = New Supply_Demand()
        sd.Show()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
