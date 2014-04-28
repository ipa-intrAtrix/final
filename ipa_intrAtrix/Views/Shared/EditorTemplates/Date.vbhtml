@modeltype Date?
@code
    Dim value = Nothing
    If (Model.HasValue) Then
        value = String.Format("{0:d}", Model.Value.ToString("dd.MM.yyyy"))
    End If
End Code
@Html.TextBox("", value, New With {.class = "datefield", .type = "text"})