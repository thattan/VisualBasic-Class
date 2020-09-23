'Tyler Hattan
'Project: 10-1
'9/14/2020
'This is a payment application

Public Class frmCustomer

    Dim isDataSaved As Boolean = True

    Private Sub DataChanged(sender As Object, e As EventArgs) Handles cboNames.SelectedIndexChanged, lblPayment.TextChanged
        isDataSaved = False
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNames.Items.Add("Mike Smith")
        cboNames.Items.Add("Nancy Jones")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsValidData() Then
            Me.SaveData()
        End If
    End Sub

    Private Sub btnSelectPayment_Click(sender As Object, e As EventArgs) Handles btnSelectPayment.Click
        Dim paymentForm As New frmPayment
        Dim selectedButton As DialogResult = paymentForm.ShowDialog()
        If selectedButton = DialogResult.OK Then
            lblPayment.Text = paymentForm.Tag.ToString
        End If
    End Sub

    Private Function IsValidData() As Boolean
        If cboNames.SelectedIndex = -1 Then
            MessageBox.Show("You must select a customer.", "Entry Error")
            cboNames.Select()
            Return False
        End If
        If lblPayment.Text = "" Then
            MessageBox.Show("You must enter a payment.", "Entry Error")
            Return False
        End If
        Return True
    End Function

    Private Sub SaveData()
        cboNames.SelectedIndex = -1
        lblPayment.Text = ""
        isDataSaved = True
        cboNames.Select()
    End Sub

    Private Sub frmCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then
            Dim message As String = "This form contains unsaved data." & vbCrLf & vbCrLf & "Do you want to save it?"
            Dim button As DialogResult = MessageBox.Show(message, "Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If button = DialogResult.Yes Then
                If IsValidData() Then
                    Me.SaveData()
                Else
                    e.Cancel = True
                End If
            ElseIf button = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
