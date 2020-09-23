'Tyler Hattan
'Project: Update 7-2 to 8-1
'9/8/2020
'Calculates Invoice Total

'Using Select Case seems to be easier to read since it breaks it into sections. The switch statement in Java and C# does not use "End Select"

Public Class frmInvoiceTotal

    Dim invoiceArray(4) As Decimal
    Dim index As Integer = 0
    Dim invoiceList As New List(Of Decimal)

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim discountPercent As Decimal
        Dim customerType As String = txtCustomerType.Text.ToUpper()
        Dim validCustomerType As Boolean
        Dim validSubtotal As Boolean

        validCustomerType = IsValidCustomerType(customerType)
        validSubtotal = IsValidSubtotal(subtotal)

        If validCustomerType = True AndAlso validSubtotal = True Then
            discountPercent = DiscountPct(subtotal, discountPercent, customerType)

            Dim discountAmount As Decimal = subtotal * discountPercent
            Dim invoiceTotal As Decimal = subtotal - discountAmount

            txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
            txtDiscountAmount.Text = FormatCurrency(discountAmount)
            txtTotal.Text = FormatCurrency(invoiceTotal)

            invoiceArray(index) = invoiceTotal
            invoiceList.Add(invoiceTotal)
            index += 1
        End If


        txtCustomerType.Select()

    End Sub

    Private Shared Function DiscountPct(subtotal As Decimal, discountPercent As Decimal, customerType As String) As Decimal
        Select Case customerType
            Case "R"
                If subtotal < 100 Then
                    discountPercent = 0
                ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
                    discountPercent = 0.1D
                ElseIf subtotal >= 250 AndAlso subtotal < 500 Then
                    discountPercent = 0.25D
                ElseIf subtotal >= 500 Then
                    discountPercent = 0.3D
                End If

            Case "C"
                discountPercent = 0.2D

            Case "T"
                discountPercent = 0.4D


                '           Case Else
                '              discountPercent = 0.1D

        End Select
        Return discountPercent
    End Function

    Private Function IsValidCustomerType(customerType As String) As Boolean
        customerType.ToUpper()
        If customerType = "R" Or customerType = "C" Or customerType = "T" Then
            Return True
        Else
            MessageBox.Show("Customer Type must be either R, C or T")
            Return False
        End If

    End Function

    Private Function IsValidSubtotal(subtotal As Decimal) As Boolean
        If subtotal < 0 OrElse subtotal > 1000 Then
            MessageBox.Show("Subtotal must be between 0 and 1000")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearAllBoxes(sender As Object, e As EventArgs) Handles txtCustomerType.TextChanged, txtSubtotal.TextChanged
        txtDiscountAmount.Text = ""
        txtDiscountPercent.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Dim numberString As String = ""
        Array.Sort(invoiceArray)
        For Each i As Decimal In invoiceArray
            If i > 0 Then
                numberString &= "$" & i.ToString & vbCrLf
            End If
        Next
        MessageBox.Show("The totals are: " & vbCrLf & numberString, "Invoice Totals")

        numberString = ""
        invoiceList.Sort()
        For Each i As Decimal In invoiceList
            If i > 0 Then
                numberString &= "$" & i.ToString & vbCrLf
            End If
        Next
        MessageBox.Show("The totals are: " & vbCrLf & numberString, "Invoice Totals")

        Me.Close()
    End Sub

End Class