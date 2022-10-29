<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.lblLess = New System.Windows.Forms.Label()
        Me.lblMember = New System.Windows.Forms.Label()
        Me.chkCooperative = New System.Windows.Forms.CheckBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtSalaryLoan = New System.Windows.Forms.TextBox()
        Me.lblSalaryLoan = New System.Windows.Forms.Label()
        Me.txtOtherDeduction = New System.Windows.Forms.TextBox()
        Me.lblOtherDeduction = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.btnAnother = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(61, 35)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(114, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(314, 25)
        Me.txtName.TabIndex = 1
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(40, 66)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(60, 17)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = "Position"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(114, 58)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(314, 25)
        Me.txtPosition.TabIndex = 3
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbB)
        Me.GroupBox1.Controls.Add(Me.rdbA)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salary Grade"
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Location = New System.Drawing.Point(71, 34)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(36, 21)
        Me.rdbB.TabIndex = 1
        Me.rdbB.TabStop = True
        Me.rdbB.Text = "B"
        Me.rdbB.UseVisualStyleBackColor = True
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Location = New System.Drawing.Point(21, 34)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(35, 21)
        Me.rdbA.TabIndex = 0
        Me.rdbA.TabStop = True
        Me.rdbA.Text = "A"
        Me.rdbA.UseVisualStyleBackColor = True
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(185, 148)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(77, 17)
        Me.lblGrossPay.TabIndex = 5
        Me.lblGrossPay.Text = "Gross Pay"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtGrossPay.Location = New System.Drawing.Point(268, 140)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(160, 25)
        Me.txtGrossPay.TabIndex = 6
        '
        'lblLess
        '
        Me.lblLess.AutoSize = True
        Me.lblLess.Location = New System.Drawing.Point(61, 199)
        Me.lblLess.Name = "lblLess"
        Me.lblLess.Size = New System.Drawing.Size(44, 17)
        Me.lblLess.TabIndex = 7
        Me.lblLess.Text = "Less:"
        '
        'lblMember
        '
        Me.lblMember.AutoSize = True
        Me.lblMember.Location = New System.Drawing.Point(78, 228)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(61, 17)
        Me.lblMember.TabIndex = 8
        Me.lblMember.Text = "Member"
        '
        'chkCooperative
        '
        Me.chkCooperative.AutoSize = True
        Me.chkCooperative.Location = New System.Drawing.Point(160, 227)
        Me.chkCooperative.Name = "chkCooperative"
        Me.chkCooperative.Size = New System.Drawing.Size(165, 21)
        Me.chkCooperative.TabIndex = 9
        Me.chkCooperative.Text = "Cooperative (P50.00)"
        Me.chkCooperative.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(109, 259)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(30, 17)
        Me.lblTax.TabIndex = 10
        Me.lblTax.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(160, 251)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(160, 25)
        Me.txtTax.TabIndex = 11
        '
        'txtSalaryLoan
        '
        Me.txtSalaryLoan.Location = New System.Drawing.Point(160, 282)
        Me.txtSalaryLoan.Name = "txtSalaryLoan"
        Me.txtSalaryLoan.Size = New System.Drawing.Size(160, 25)
        Me.txtSalaryLoan.TabIndex = 12
        '
        'lblSalaryLoan
        '
        Me.lblSalaryLoan.AutoSize = True
        Me.lblSalaryLoan.Location = New System.Drawing.Point(54, 290)
        Me.lblSalaryLoan.Name = "lblSalaryLoan"
        Me.lblSalaryLoan.Size = New System.Drawing.Size(85, 17)
        Me.lblSalaryLoan.TabIndex = 13
        Me.lblSalaryLoan.Text = "Salary Loan"
        '
        'txtOtherDeduction
        '
        Me.txtOtherDeduction.Location = New System.Drawing.Point(160, 313)
        Me.txtOtherDeduction.Name = "txtOtherDeduction"
        Me.txtOtherDeduction.Size = New System.Drawing.Size(160, 25)
        Me.txtOtherDeduction.TabIndex = 14
        '
        'lblOtherDeduction
        '
        Me.lblOtherDeduction.AutoSize = True
        Me.lblOtherDeduction.Location = New System.Drawing.Point(24, 321)
        Me.lblOtherDeduction.Name = "lblOtherDeduction"
        Me.lblOtherDeduction.Size = New System.Drawing.Size(115, 17)
        Me.lblOtherDeduction.TabIndex = 15
        Me.lblOtherDeduction.Text = "Other Deduction"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(80, 352)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(59, 17)
        Me.lblNetPay.TabIndex = 16
        Me.lblNetPay.Text = "Net Pay"
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNetPay.Location = New System.Drawing.Point(160, 344)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(160, 25)
        Me.txtNetPay.TabIndex = 17
        '
        'btnAnother
        '
        Me.btnAnother.Location = New System.Drawing.Point(372, 279)
        Me.btnAnother.Name = "btnAnother"
        Me.btnAnother.Size = New System.Drawing.Size(85, 39)
        Me.btnAnother.TabIndex = 18
        Me.btnAnother.Text = "Another"
        Me.btnAnother.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(372, 324)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 39)
        Me.btnQuit.TabIndex = 19
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(490, 393)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAnother)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblOtherDeduction)
        Me.Controls.Add(Me.txtOtherDeduction)
        Me.Controls.Add(Me.lblSalaryLoan)
        Me.Controls.Add(Me.txtSalaryLoan)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.chkCooperative)
        Me.Controls.Add(Me.lblMember)
        Me.Controls.Add(Me.lblLess)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary of an Employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbB As RadioButton
    Friend WithEvents rdbA As RadioButton
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents lblLess As Label
    Friend WithEvents lblMember As Label
    Friend WithEvents chkCooperative As CheckBox
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSalaryLoan As TextBox
    Friend WithEvents lblSalaryLoan As Label
    Friend WithEvents txtOtherDeduction As TextBox
    Friend WithEvents lblOtherDeduction As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents btnAnother As Button
    Friend WithEvents btnQuit As Button
End Class
