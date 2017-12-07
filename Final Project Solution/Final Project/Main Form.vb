' This is the main form of our application. 
' The purpose Of this application is to assist Professor Kilmer in teaching Math 107

' Authors: Jonathan Spencer, Jared Butler, David Abraham, David Park

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    ' Variables for other formula forms
    Dim sd As Supply_Demand = New Supply_Demand()
    Dim pf As ProfitModel = New ProfitModel()
    Dim aroc As AvgRateofChange = New AvgRateofChange()
    Dim interest As TimeVal = New TimeVal()
    Dim descderiv As DescDerivative = New DescDerivative()
    Dim rulederiv As DerivRules = New DerivRules()

    'Making the entire form draggable
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    ' functions for making the form draggable
    ' grab mousex mousey
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            mousex = e.X
            mousey = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp, Label1.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseDown
        If drag Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - mousex)
            temp.Y = Me.Location.Y + (e.Y - mousey)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    ' Buttons to Display Various Sub Forms
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sd.Show()
        sd.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pf.Show()
        pf.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        aroc.Show()
        aroc.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        interest.Show()
        interest.BringToFront()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        descderiv.Show()
        descderiv.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        rulederiv.Show()
        rulederiv.BringToFront()
    End Sub

    'Terminate All Open Forms
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        sd.Hide()
        pf.Hide()
        aroc.Hide()
        interest.Hide()
        descderiv.Hide()
        rulederiv.Hide()
        Me.BringToFront()
    End Sub

    'Close the Application
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class
