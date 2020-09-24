Public Class frmInvMaint

    ' Add a statement here that declares the list of items.
    Private invItems As List(Of InvItem)

    Private Sub frmInvMaint_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        ' Add code here that gets the list of items and fills the list box.
        invItems = InvItemDB.GetItems
        Me.FillItemListBox()

    End Sub

    Private Sub FillItemListBox()
        lstItems.Items.Clear()
        ' Add code here that loads the list box with the items in the list.
        For Each i As InvItem In invItems
            lstItems.Items.Add(i.GetDisplayText(4))
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object,
            e As EventArgs) Handles btnAdd.Click
        ' Add code here that creates an instance of the New Item form,
        ' displays the form as a dialog box
        ' If a New item was instanciated 
        '     add the item to the list
        '     saves the list of items
        '     refreshes the list box

        Dim newItemForm As New frmNewItem
        newItemForm.ShowDialog()
        If newItemForm.invItem IsNot Nothing Then
            invItems.Add(newItemForm.invItem)
            InvItemDB.SaveItems(invItems)
            FillItemListBox()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstItems.SelectedIndex
        If i <> -1 Then
            ' Add code here that displays a dialog box to confirm
            ' the deletion and then removes the item from the list,
            ' saves the list of items, and refreshes the list box
            ' if the deletion is confirmed.
            Dim item As InvItem = invItems(i)
            Dim message = "Are you sure you want to delete this item?"
            Dim button As DialogResult = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo)
            If button = DialogResult.Yes Then
                invItems.Remove(item)
                InvItemDB.SaveItems(invItems)
                FillItemListBox()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        ' Add code here that creates an instance of the New Item form,

        Dim i As Integer = lstItems.SelectedIndex
        If i <> -1 Then
            ' Add code here that calls the Update method from the new instance of the New Item form
            ' if a new item was instanciated 
            '     assign the new values (description and price) to the selected item
            '     saves the list of items
            '     refreshes the list box
            Dim item As InvItem = invItems(i)
            Dim newItemForm As New frmNewItem
            newItemForm.UpdateInventory(item)
            newItemForm.ShowDialog()
            If newItemForm.invItem IsNot Nothing Then
                invItems.Remove(item)
                invItems.Add(newItemForm.invItem)
                InvItemDB.SaveItems(invItems)
                FillItemListBox()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
