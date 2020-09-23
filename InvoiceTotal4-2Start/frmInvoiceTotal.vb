'Tyler Hattan
'Project 4-2
'9/8/2020
'Calculates invoice total


Public Class frmInvoiceTotal

    Dim numberofInvoices As Integer
    Dim totalOfInvoices As Decimal
    Dim invoiceAverage As Decimal
    Dim largestInvoice As Decimal = 0
    Dim smallestInvoice As Decimal = 99999999
    Dim midPoint As Decimal


    'NOTE: the Handles keyword is the wire for this event handler
    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        Dim subtotal As Decimal = CDec(txtSubtotal.Text) ' CDec is Convert to Decimal
        Dim discountPercent As Decimal = 0.25D   ' NOTE: the D means that this is a decimal literal vs a double literal which is the default
        Dim discountAmount As Decimal = Math.Round(subtotal * discountPercent, 2)
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        txtSubtotal.Text = FormatCurrency(subtotal)
        txtLastSubtotal.Text = FormatCurrency(subtotal)
        txtDiscountPercent.Text = FormatPercent(discountPercent, 1) ' format discount percent with % and 1 decimal position
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        txtTotal.Text = FormatCurrency(invoiceTotal)  ' or use the ToString with the currency format specifier

        numberofInvoices += 1
        totalOfInvoices += invoiceTotal
        invoiceAverage = totalOfInvoices / numberofInvoices
        largestInvoice = Math.Max(largestInvoice, subtotal)
        smallestInvoice = Math.Min(smallestInvoice, subtotal)


        txtInvoiceNumber.Text = numberofInvoices.ToString
        txtInvoiceTotal.Text = FormatCurrency(totalOfInvoices)
        txtInvoiceAverage.Text = FormatCurrency(invoiceAverage)
        txtLargestInvoice.Text = FormatCurrency(largestInvoice)
        txtSmallestInvoice.Text = FormatCurrency(smallestInvoice)
        If (largestInvoice - smallestInvoice) > 0 Then
            midPoint = (largestInvoice - ((largestInvoice - smallestInvoice) / 2))
            txtMidPoint.Text = FormatCurrency(midPoint)
        End If

        txtSubtotal.Text = ""
        txtSubtotal.Focus()  ' returns control back to the textbox
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        numberofInvoices = 0
        totalOfInvoices = 0
        invoiceAverage = 0
        largestInvoice = 0
        smallestInvoice = 99999999
        midPoint = 0

        txtInvoiceNumber.Text = ""
        txtInvoiceTotal.Text = ""
        txtInvoiceAverage.Text = ""
        txtLargestInvoice.Text = ""
        txtSmallestInvoice.Text = ""
        txtMidPoint.Text = ""

        txtSubtotal.Select()
    End Sub

End Class