<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeVal
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
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtNumPeriods = New System.Windows.Forms.TextBox()
        Me.cboCompoundPeriod = New System.Windows.Forms.ComboBox()
        Me.cboPeriodType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.cboCompounding = New System.Windows.Forms.ComboBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(64, 42)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(73, 20)
        Me.txtPrincipal.TabIndex = 0
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(64, 86)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(73, 20)
        Me.txtRate.TabIndex = 1
        '
        'txtNumPeriods
        '
        Me.txtNumPeriods.Location = New System.Drawing.Point(64, 126)
        Me.txtNumPeriods.Name = "txtNumPeriods"
        Me.txtNumPeriods.Size = New System.Drawing.Size(73, 20)
        Me.txtNumPeriods.TabIndex = 2
        '
        'cboCompoundPeriod
        '
        Me.cboCompoundPeriod.FormattingEnabled = True
        Me.cboCompoundPeriod.Location = New System.Drawing.Point(166, 86)
        Me.cboCompoundPeriod.Name = "cboCompoundPeriod"
        Me.cboCompoundPeriod.Size = New System.Drawing.Size(106, 21)
        Me.cboCompoundPeriod.TabIndex = 3
        '
        'cboPeriodType
        '
        Me.cboPeriodType.FormattingEnabled = True
        Me.cboPeriodType.Location = New System.Drawing.Point(166, 133)
        Me.cboPeriodType.Name = "cboPeriodType"
        Me.cboPeriodType.Size = New System.Drawing.Size(106, 21)
        Me.cboPeriodType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Principal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rate: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Periods:"
        '
        'lblAns
        '
        Me.lblAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAns.Location = New System.Drawing.Point(64, 211)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(73, 23)
        Me.lblAns.TabIndex = 8
        '
        'cboCompounding
        '
        Me.cboCompounding.FormattingEnabled = True
        Me.cboCompounding.Location = New System.Drawing.Point(166, 213)
        Me.cboCompounding.Name = "cboCompounding"
        Me.cboCompounding.Size = New System.Drawing.Size(106, 21)
        Me.cboCompounding.TabIndex = 9
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(64, 168)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(73, 20)
        Me.txtYears.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Years:"
        '
        'TimeVal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.cboCompounding)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPeriodType)
        Me.Controls.Add(Me.cboCompoundPeriod)
        Me.Controls.Add(Me.txtNumPeriods)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Name = "TimeVal"
        Me.Text = "Time Value of Money"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtNumPeriods As TextBox
    Friend WithEvents cboCompoundPeriod As ComboBox
    Friend WithEvents cboPeriodType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAns As Label
    Friend WithEvents cboCompounding As ComboBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents Label4 As Label
End Class
