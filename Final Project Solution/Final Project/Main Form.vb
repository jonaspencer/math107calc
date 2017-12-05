Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    ' Variables for other formula forms
    Dim sd As Supply_Demand = New Supply_Demand()
    Dim pf As ProfitModel = New ProfitModel()

    'Making the entire form draggable
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    ' functions for making the form draggable
    ' grab mousex mousey
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            mousex = e.X
            mousey = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            drag = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - mousex)
            temp.Y = Me.Location.Y + (e.Y - mousey)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sd.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pf.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

End Class
