<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimeVal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.radDaily = New System.Windows.Forms.RadioButton()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.radQuarterly = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(117, 49)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(73, 20)
        Me.txtPrincipal.TabIndex = 0
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(117, 91)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(73, 20)
        Me.txtInterestRate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Principal (PV):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Interest rate (i): "
        '
        'lblAns
        '
        Me.lblAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAns.Location = New System.Drawing.Point(109, 223)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(73, 23)
        Me.lblAns.TabIndex = 8
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(117, 131)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(73, 20)
        Me.txtYears.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Number of years (t):"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(281, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(281, 219)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radYearly)
        Me.GroupBox1.Controls.Add(Me.radDaily)
        Me.GroupBox1.Controls.Add(Me.radMonthly)
        Me.GroupBox1.Controls.Add(Me.radQuarterly)
        Me.GroupBox1.Location = New System.Drawing.Point(220, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 122)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compounding Periods"
        '
        'radYearly
        '
        Me.radYearly.AutoSize = True
        Me.radYearly.Location = New System.Drawing.Point(7, 29)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(54, 17)
        Me.radYearly.TabIndex = 3
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "Yearly"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'radDaily
        '
        Me.radDaily.AutoSize = True
        Me.radDaily.Location = New System.Drawing.Point(7, 98)
        Me.radDaily.Name = "radDaily"
        Me.radDaily.Size = New System.Drawing.Size(48, 17)
        Me.radDaily.TabIndex = 2
        Me.radDaily.TabStop = True
        Me.radDaily.Text = "Daily"
        Me.radDaily.UseVisualStyleBackColor = True
        '
        'radMonthly
        '
        Me.radMonthly.AutoSize = True
        Me.radMonthly.Location = New System.Drawing.Point(7, 52)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(62, 17)
        Me.radMonthly.TabIndex = 1
        Me.radMonthly.TabStop = True
        Me.radMonthly.Text = "Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        '
        'radQuarterly
        '
        Me.radQuarterly.AutoSize = True
        Me.radQuarterly.Location = New System.Drawing.Point(7, 75)
        Me.radQuarterly.Name = "radQuarterly"
        Me.radQuarterly.Size = New System.Drawing.Size(67, 17)
        Me.radQuarterly.TabIndex = 0
        Me.radQuarterly.TabStop = True
        Me.radQuarterly.Text = "Quarterly"
        Me.radQuarterly.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Future value (FV):"
        '
        'TimeVal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Name = "TimeVal"
        Me.Text = "Time Value of Money"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAns As Label
    Friend WithEvents txtYears As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDaily As RadioButton
    Friend WithEvents radMonthly As RadioButton
    Friend WithEvents radQuarterly As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents radYearly As RadioButton
End Class
