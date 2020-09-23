<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.rdoCreditCard = New System.Windows.Forms.RadioButton()
        Me.rdoBillCustomer = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstCreditCardType = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboExpirationMonth = New System.Windows.Forms.ComboBox()
        Me.cboExpirationYear = New System.Windows.Forms.ComboBox()
        Me.chckDefault = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoCreditCard
        '
        Me.rdoCreditCard.AutoSize = True
        Me.rdoCreditCard.Checked = True
        Me.rdoCreditCard.Location = New System.Drawing.Point(27, 34)
        Me.rdoCreditCard.Name = "rdoCreditCard"
        Me.rdoCreditCard.Size = New System.Drawing.Size(76, 17)
        Me.rdoCreditCard.TabIndex = 0
        Me.rdoCreditCard.TabStop = True
        Me.rdoCreditCard.Text = "Credit card"
        Me.rdoCreditCard.UseVisualStyleBackColor = True
        '
        'rdoBillCustomer
        '
        Me.rdoBillCustomer.AutoSize = True
        Me.rdoBillCustomer.Location = New System.Drawing.Point(194, 34)
        Me.rdoBillCustomer.Name = "rdoBillCustomer"
        Me.rdoBillCustomer.Size = New System.Drawing.Size(84, 17)
        Me.rdoBillCustomer.TabIndex = 1
        Me.rdoBillCustomer.Text = "Bill customer"
        Me.rdoBillCustomer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoCreditCard)
        Me.GroupBox1.Controls.Add(Me.rdoBillCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing"
        '
        'lstCreditCardType
        '
        Me.lstCreditCardType.FormattingEnabled = True
        Me.lstCreditCardType.Location = New System.Drawing.Point(129, 114)
        Me.lstCreditCardType.Name = "lstCreditCardType"
        Me.lstCreditCardType.Size = New System.Drawing.Size(229, 134)
        Me.lstCreditCardType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Card Number:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(129, 268)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(135, 20)
        Me.txtCardNumber.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Expiration Date:"
        '
        'cboExpirationMonth
        '
        Me.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpirationMonth.FormattingEnabled = True
        Me.cboExpirationMonth.Location = New System.Drawing.Point(129, 311)
        Me.cboExpirationMonth.Name = "cboExpirationMonth"
        Me.cboExpirationMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboExpirationMonth.TabIndex = 6
        '
        'cboExpirationYear
        '
        Me.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpirationYear.FormattingEnabled = True
        Me.cboExpirationYear.Location = New System.Drawing.Point(268, 312)
        Me.cboExpirationYear.Name = "cboExpirationYear"
        Me.cboExpirationYear.Size = New System.Drawing.Size(90, 21)
        Me.cboExpirationYear.TabIndex = 7
        '
        'chckDefault
        '
        Me.chckDefault.AutoSize = True
        Me.chckDefault.Checked = True
        Me.chckDefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckDefault.Location = New System.Drawing.Point(26, 377)
        Me.chckDefault.Name = "chckDefault"
        Me.chckDefault.Size = New System.Drawing.Size(158, 17)
        Me.chckDefault.TabIndex = 8
        Me.chckDefault.Text = "Set as default billing method"
        Me.chckDefault.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(188, 412)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(283, 412)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.chckDefault)
        Me.Controls.Add(Me.cboExpirationYear)
        Me.Controls.Add(Me.cboExpirationMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCreditCardType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoCreditCard As RadioButton
    Friend WithEvents rdoBillCustomer As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstCreditCardType As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboExpirationMonth As ComboBox
    Friend WithEvents cboExpirationYear As ComboBox
    Friend WithEvents chckDefault As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
