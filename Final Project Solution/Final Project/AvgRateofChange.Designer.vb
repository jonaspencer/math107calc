﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvgRateofChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtXinital = New System.Windows.Forms.TextBox()
        Me.txtXfinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial X:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Final X:"
        '
        'txtXinital
        '
        Me.txtXinital.Location = New System.Drawing.Point(60, 43)
        Me.txtXinital.Name = "txtXinital"
        Me.txtXinital.Size = New System.Drawing.Size(68, 20)
        Me.txtXinital.TabIndex = 2
        '
        'txtXfinal
        '
        Me.txtXfinal.Location = New System.Drawing.Point(60, 74)
        Me.txtXfinal.Name = "txtXfinal"
        Me.txtXfinal.Size = New System.Drawing.Size(68, 20)
        Me.txtXfinal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "a:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "c:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "b:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(60, 105)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(68, 20)
        Me.txtA.TabIndex = 7
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(60, 136)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(68, 20)
        Me.txtB.TabIndex = 8
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(60, 167)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(68, 20)
        Me.txtC.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(60, 216)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(87, 23)
        Me.lblResult.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(197, 216)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Power of X:"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(215, 39)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(45, 20)
        Me.txtPower.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(197, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'AvgRateofChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtXfinal)
        Me.Controls.Add(Me.txtXinital)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AvgRateofChange"
        Me.Text = "AvgRateofChange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtXinital As TextBox
    Friend WithEvents txtXfinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPower As TextBox
    Friend WithEvents btnClear As Button
End Class
