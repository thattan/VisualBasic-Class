<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceTotal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubtotalEnter = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNumberOfInvoices = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.txtInvoiceTotal = New System.Windows.Forms.TextBox()
        Me.txtInvoiceAverage = New System.Windows.Forms.TextBox()
        Me.lblInvoiceTotal = New System.Windows.Forms.Label()
        Me.lblInvoiceAverage = New System.Windows.Forms.Label()
        Me.lblLastSubtotal = New System.Windows.Forms.Label()
        Me.txtLastSubtotal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblLargestInvoice = New System.Windows.Forms.Label()
        Me.lblSmallestInvoice = New System.Windows.Forms.Label()
        Me.lblMidPoint = New System.Windows.Forms.Label()
        Me.txtLargestInvoice = New System.Windows.Forms.TextBox()
        Me.txtSmallestInvoice = New System.Windows.Forms.TextBox()
        Me.txtMidPoint = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(417, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(234, 297)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 23
        Me.btnCalculate.Text = "&Calculate"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(110, 24)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discount Amount:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubtotalEnter
        '
        Me.lblSubtotalEnter.AutoSize = True
        Me.lblSubtotalEnter.Location = New System.Drawing.Point(12, 27)
        Me.lblSubtotalEnter.Name = "lblSubtotalEnter"
        Me.lblSubtotalEnter.Size = New System.Drawing.Size(77, 13)
        Me.lblSubtotalEnter.TabIndex = 0
        Me.lblSubtotalEnter.Text = "&Enter Subtotal:"
        Me.lblSubtotalEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Discount Percent:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(110, 78)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.ReadOnly = True
        Me.txtDiscountPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountPercent.TabIndex = 5
        Me.txtDiscountPercent.TabStop = False
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.Location = New System.Drawing.Point(110, 104)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountAmount.TabIndex = 7
        Me.txtDiscountAmount.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(110, 130)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 310)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Tyler Hattan"
        '
        'lblNumberOfInvoices
        '
        Me.lblNumberOfInvoices.AutoSize = True
        Me.lblNumberOfInvoices.Location = New System.Drawing.Point(284, 42)
        Me.lblNumberOfInvoices.Name = "lblNumberOfInvoices"
        Me.lblNumberOfInvoices.Size = New System.Drawing.Size(101, 13)
        Me.lblNumberOfInvoices.TabIndex = 11
        Me.lblNumberOfInvoices.Text = "Number of invoices:"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(392, 42)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.ReadOnly = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceNumber.TabIndex = 12
        '
        'txtInvoiceTotal
        '
        Me.txtInvoiceTotal.Location = New System.Drawing.Point(392, 69)
        Me.txtInvoiceTotal.Name = "txtInvoiceTotal"
        Me.txtInvoiceTotal.ReadOnly = True
        Me.txtInvoiceTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceTotal.TabIndex = 14
        '
        'txtInvoiceAverage
        '
        Me.txtInvoiceAverage.Location = New System.Drawing.Point(392, 96)
        Me.txtInvoiceAverage.Name = "txtInvoiceAverage"
        Me.txtInvoiceAverage.ReadOnly = True
        Me.txtInvoiceAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceAverage.TabIndex = 16
        '
        'lblInvoiceTotal
        '
        Me.lblInvoiceTotal.AutoSize = True
        Me.lblInvoiceTotal.Location = New System.Drawing.Point(287, 69)
        Me.lblInvoiceTotal.Name = "lblInvoiceTotal"
        Me.lblInvoiceTotal.Size = New System.Drawing.Size(88, 13)
        Me.lblInvoiceTotal.TabIndex = 13
        Me.lblInvoiceTotal.Text = "Total of invoices:"
        '
        'lblInvoiceAverage
        '
        Me.lblInvoiceAverage.AutoSize = True
        Me.lblInvoiceAverage.Location = New System.Drawing.Point(290, 96)
        Me.lblInvoiceAverage.Name = "lblInvoiceAverage"
        Me.lblInvoiceAverage.Size = New System.Drawing.Size(87, 13)
        Me.lblInvoiceAverage.TabIndex = 15
        Me.lblInvoiceAverage.Text = "Invoice average:"
        '
        'lblLastSubtotal
        '
        Me.lblLastSubtotal.AutoSize = True
        Me.lblLastSubtotal.Location = New System.Drawing.Point(13, 54)
        Me.lblLastSubtotal.Name = "lblLastSubtotal"
        Me.lblLastSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblLastSubtotal.TabIndex = 2
        Me.lblLastSubtotal.Text = "Subtotal"
        '
        'txtLastSubtotal
        '
        Me.txtLastSubtotal.Location = New System.Drawing.Point(110, 51)
        Me.txtLastSubtotal.Name = "txtLastSubtotal"
        Me.txtLastSubtotal.ReadOnly = True
        Me.txtLastSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtLastSubtotal.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(324, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear Totals"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblLargestInvoice
        '
        Me.lblLargestInvoice.AutoSize = True
        Me.lblLargestInvoice.Location = New System.Drawing.Point(293, 150)
        Me.lblLargestInvoice.Name = "lblLargestInvoice"
        Me.lblLargestInvoice.Size = New System.Drawing.Size(83, 13)
        Me.lblLargestInvoice.TabIndex = 17
        Me.lblLargestInvoice.Text = "Largest Invoice:"
        '
        'lblSmallestInvoice
        '
        Me.lblSmallestInvoice.AutoSize = True
        Me.lblSmallestInvoice.Location = New System.Drawing.Point(293, 176)
        Me.lblSmallestInvoice.Name = "lblSmallestInvoice"
        Me.lblSmallestInvoice.Size = New System.Drawing.Size(87, 13)
        Me.lblSmallestInvoice.TabIndex = 19
        Me.lblSmallestInvoice.Text = "Smallest Invoice:"
        '
        'lblMidPoint
        '
        Me.lblMidPoint.AutoSize = True
        Me.lblMidPoint.Location = New System.Drawing.Point(293, 202)
        Me.lblMidPoint.Name = "lblMidPoint"
        Me.lblMidPoint.Size = New System.Drawing.Size(51, 13)
        Me.lblMidPoint.TabIndex = 21
        Me.lblMidPoint.Text = "Mid Point"
        '
        'txtLargestInvoice
        '
        Me.txtLargestInvoice.Location = New System.Drawing.Point(392, 147)
        Me.txtLargestInvoice.Name = "txtLargestInvoice"
        Me.txtLargestInvoice.ReadOnly = True
        Me.txtLargestInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtLargestInvoice.TabIndex = 18
        '
        'txtSmallestInvoice
        '
        Me.txtSmallestInvoice.Location = New System.Drawing.Point(392, 173)
        Me.txtSmallestInvoice.Name = "txtSmallestInvoice"
        Me.txtSmallestInvoice.ReadOnly = True
        Me.txtSmallestInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtSmallestInvoice.TabIndex = 20
        '
        'txtMidPoint
        '
        Me.txtMidPoint.Location = New System.Drawing.Point(392, 199)
        Me.txtMidPoint.Name = "txtMidPoint"
        Me.txtMidPoint.ReadOnly = True
        Me.txtMidPoint.Size = New System.Drawing.Size(100, 20)
        Me.txtMidPoint.TabIndex = 22
        '
        'frmInvoiceTotal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(542, 332)
        Me.Controls.Add(Me.txtMidPoint)
        Me.Controls.Add(Me.txtSmallestInvoice)
        Me.Controls.Add(Me.txtLargestInvoice)
        Me.Controls.Add(Me.lblMidPoint)
        Me.Controls.Add(Me.lblSmallestInvoice)
        Me.Controls.Add(Me.lblLargestInvoice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtLastSubtotal)
        Me.Controls.Add(Me.lblLastSubtotal)
        Me.Controls.Add(Me.lblInvoiceAverage)
        Me.Controls.Add(Me.lblInvoiceTotal)
        Me.Controls.Add(Me.txtInvoiceAverage)
        Me.Controls.Add(Me.txtInvoiceTotal)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.lblNumberOfInvoices)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.txtDiscountPercent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSubtotalEnter)
        Me.Name = "frmInvoiceTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Total"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalEnter As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblNumberOfInvoices As Label
    Friend WithEvents txtInvoiceNumber As TextBox
    Friend WithEvents txtInvoiceTotal As TextBox
    Friend WithEvents txtInvoiceAverage As TextBox
    Friend WithEvents lblInvoiceTotal As Label
    Friend WithEvents lblInvoiceAverage As Label
    Friend WithEvents lblLastSubtotal As Label
    Friend WithEvents txtLastSubtotal As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblLargestInvoice As Label
    Friend WithEvents lblSmallestInvoice As Label
    Friend WithEvents lblMidPoint As Label
    Friend WithEvents txtLargestInvoice As TextBox
    Friend WithEvents txtSmallestInvoice As TextBox
    Friend WithEvents txtMidPoint As TextBox
End Class
