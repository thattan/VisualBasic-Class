Public Class frmPayment

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCreditCardType.Items.Add("Visa")
        lstCreditCardType.Items.Add("Mastercard")
        lstCreditCardType.Items.Add("American Express")
        lstCreditCardType.SelectedIndex = 0

        Dim months() As String = {"Select a month...", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For Each month As String In months
            cboExpirationMonth.Items.Add(month)
        Next

        cboExpirationMonth.SelectedIndex = 0

        Dim year As Integer = DateTime.Today.Year
        Dim endYear As Integer = year + 8
        cboExpirationYear.Items.Add("Select a year...")

        Do While year < endYear
            cboExpirationYear.Items.Add(year)
            year += 1
        Loop

        cboExpirationYear.SelectedIndex = 0

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If isValidData() Then
            Me.SaveData()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function IsValidData() As Boolean
        If rdoCreditCard.Checked Then
            If lstCreditCardType.SelectedIndex = -1 Then
                MessageBox.Show("You must select a credit card type.", "Entry Error")
                lstCreditCardType.Select()
                Return False
            End If
            If txtCardNumber.Text = "" Then
                MessageBox.Show("You must enter a credit card number.", "Entry Error")
                txtCardNumber.Select()
                Return False
            End If
            If cboExpirationMonth.SelectedIndex = 0 Then
                MessageBox.Show("You must select a month.", "Entry Error")
                cboExpirationMonth.Select()
                Return False
            End If
            If cboExpirationYear.SelectedIndex = 0 Then
                MessageBox.Show("You must select a year.", "Entry Error")
                cboExpirationYear.Select()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub SaveData()
        Dim message As String

        If rdoCreditCard.Checked Then
            message = "Charge to credit card." & vbCrLf & vbCrLf & "Card Type: " & lstCreditCardType.Text & vbCrLf & vbCrLf &
                "Card number: " & txtCardNumber.Text & vbCrLf & "Expiration date: " & cboExpirationMonth.Text & "/" & cboExpirationYear.Text & vbCrLf
        Else
            message = "Send bill to customer." & vbCrLf & vbCrLf
        End If

        Dim isDefaultBilling As Boolean = chckDefault.Checked
        message &= "Default billing: " & isDefaultBilling

        Me.Tag = message
        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub BillingChecked(sender As Object, e As EventArgs) Handles rdoCreditCard.CheckedChanged, rdoBillCustomer.CheckedChanged
        If rdoCreditCard.Checked Then
            Me.EnableControls()
        Else
            Me.DisableControls()
        End If
    End Sub

    Private Sub EnableControls()
        lstCreditCardType.Enabled = True
        txtCardNumber.Enabled = True
        cboExpirationMonth.Enabled = True
        cboExpirationYear.Enabled = True
    End Sub

    Private Sub DisableControls()
        lstCreditCardType.Enabled = False
        txtCardNumber.Enabled = False
        cboExpirationMonth.Enabled = False
        cboExpirationYear.Enabled = False
    End Sub

End Class