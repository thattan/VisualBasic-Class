Public Class InvItem
    Public ItemNo As Integer
    Public Description As String
    Public Price As Decimal

    Public Sub New()

    End Sub

    Public Sub New(ItemNo As Integer, Description As String, Price As Decimal)
        Me.ItemNo = ItemNo
        Me.Description = Description
        Me.Price = Price
    End Sub

    Public Function GetDisplayText(SpacesNo As Integer) As String
        Dim text = "" & Me.ItemNo & Space(SpacesNo) & Me.Description & "($" & Me.Price & ")"
        Return text
    End Function


End Class
