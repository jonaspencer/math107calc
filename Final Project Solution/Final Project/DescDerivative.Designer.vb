<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DescDerivative
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DescDerivative))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDerive = New System.Windows.Forms.Button()
        Me.txtConst = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.radNeg = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.lblDerivative = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 101)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnDerive
        '
        Me.btnDerive.Location = New System.Drawing.Point(82, 286)
        Me.btnDerive.Name = "btnDerive"
        Me.btnDerive.Size = New System.Drawing.Size(78, 34)
        Me.btnDerive.TabIndex = 1
        Me.btnDerive.Text = "Find the Derivative"
        Me.btnDerive.UseVisualStyleBackColor = True
        '
        'txtConst
        '
        Me.txtConst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConst.Location = New System.Drawing.Point(100, 135)
        Me.txtConst.Name = "txtConst"
        Me.txtConst.Size = New System.Drawing.Size(51, 29)
        Me.txtConst.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "y = "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = " x "
        '
        'txtExp
        '
        Me.txtExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExp.Location = New System.Drawing.Point(184, 113)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(39, 22)
        Me.txtExp.TabIndex = 5
        '
        'radNeg
        '
        Me.radNeg.AutoSize = True
        Me.radNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNeg.Location = New System.Drawing.Point(57, 135)
        Me.radNeg.Name = "radNeg"
        Me.radNeg.Size = New System.Drawing.Size(37, 29)
        Me.radNeg.TabIndex = 6
        Me.radNeg.TabStop = True
        Me.radNeg.Text = "-"
        Me.radNeg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "^ Check this to make it negative"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Constant Multiplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Exponent"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(274, 161)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add to Function"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(200, 286)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(78, 34)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "New Function"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblFormula
        '
        Me.lblFormula.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(12, 212)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(337, 45)
        Me.lblFormula.TabIndex = 12
        Me.lblFormula.Text = "y = "
        Me.lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDerivative
        '
        Me.lblDerivative.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblDerivative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDerivative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDerivative.Location = New System.Drawing.Point(11, 339)
        Me.lblDerivative.Name = "lblDerivative"
        Me.lblDerivative.Size = New System.Drawing.Size(337, 45)
        Me.lblDerivative.TabIndex = 13
        Me.lblDerivative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescDerivative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 406)
        Me.Controls.Add(Me.lblDerivative)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.radNeg)
        Me.Controls.Add(Me.txtExp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConst)
        Me.Controls.Add(Me.btnDerive)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DescDerivative"
        Me.Text = "DescDerivative"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDerive As Button
    Friend WithEvents txtConst As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExp As TextBox
    Friend WithEvents radNeg As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents lblFormula As Label
    Friend WithEvents lblDerivative As Label
End Class
