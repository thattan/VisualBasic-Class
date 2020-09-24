'Tyler Hattan
'Project: Assignment 1
'9/23/2020
'Inventory manager

Public Class frmNewItem

    ' Add a statement here that declares a public inventory item.
    Public invItem As InvItem

    Private Sub btnSave_Click(sender As Object,
            e As EventArgs) Handles btnSave.Click
        If IsValidData() Then
            ' Add code here that creates a new inventory item
            invItem = New InvItem(CInt(txtItemNo.Text), txtDescription.Text, CDec(txtPrice.Text))
            Me.Close()
            ' close the form
        End If
    End Sub

    ' create a new subroutine for the Update 
    '   Set the values and properties of for the controls
    '   Display the form in a modal state
    Public Sub UpdateInventory(item As InvItem)
        txtItemNo.Text = item.ItemNo.ToString
        txtDescription.Text = item.Description
        txtPrice.Text = item.Price.ToString

    End Sub



    Public Function IsValidData() As Boolean
        ' Add the code to return a true if all data entry passes validation
        '  Use the Validator class 
        '  Remember to code all validation criteria for ONE control before moving to the next!
        Return Validator.IsPresent(txtItemNo) AndAlso
                Validator.IsInt32(txtItemNo) AndAlso
                Validator.IsPresent(txtDescription) AndAlso
                Validator.IsDecimal(txtPrice) AndAlso
                Validator.IsWithinRange(txtPrice, 0, 500)
    End Function

    Private Sub btnCancel_Click(sender As Object,
            e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class