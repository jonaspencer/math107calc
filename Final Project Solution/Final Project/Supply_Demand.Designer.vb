<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supply_Demand
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
        Me.txtSlope1 = New System.Windows.Forms.TextBox()
        Me.txtSlope2 = New System.Windows.Forms.TextBox()
        Me.txtIntercept1 = New System.Windows.Forms.TextBox()
        Me.txtIntercept2 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSlope1
        '
        Me.txtSlope1.Location = New System.Drawing.Point(48, 49)
        Me.txtSlope1.Name = "txtSlope1"
        Me.txtSlope1.Size = New System.Drawing.Size(62, 20)
        Me.txtSlope1.TabIndex = 2
        '
        'txtSlope2
        '
        Me.txtSlope2.Location = New System.Drawing.Point(48, 150)
        Me.txtSlope2.Name = "txtSlope2"
        Me.txtSlope2.Size = New System.Drawing.Size(62, 20)
        Me.txtSlope2.TabIndex = 7
        '
        'txtIntercept1
        '
        Me.txtIntercept1.Location = New System.Drawing.Point(165, 51)
        Me.txtIntercept1.Name = "txtIntercept1"
        Me.txtIntercept1.Size = New System.Drawing.Size(100, 20)
        Me.txtIntercept1.TabIndex = 4
        '
        'txtIntercept2
        '
        Me.txtIntercept2.Location = New System.Drawing.Point(165, 150)
        Me.txtIntercept2.Name = "txtIntercept2"
        Me.txtIntercept2.Size = New System.Drawing.Size(100, 20)
        Me.txtIntercept2.TabIndex = 9
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(165, 208)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supply"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Demand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 67)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "x +"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 67)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "x +"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-5, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 41)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "y ="
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-5, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 45)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "y ="
        '
        'lblAns
        '
        Me.lblAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAns.Location = New System.Drawing.Point(48, 208)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(100, 23)
        Me.lblAns.TabIndex = 10
        '
        'Supply_Demand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtIntercept2)
        Me.Controls.Add(Me.txtIntercept1)
        Me.Controls.Add(Me.txtSlope2)
        Me.Controls.Add(Me.txtSlope1)
        Me.Name = "Supply_Demand"
        Me.Text = "Supply_Demand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSlope1 As TextBox
    Friend WithEvents txtSlope2 As TextBox
    Friend WithEvents txtIntercept1 As TextBox
    Friend WithEvents txtIntercept2 As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAns As Label
End Class
