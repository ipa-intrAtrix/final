@modeltype Date?
@code
    Dim value = Nothing
    If (Model.HasValue = False) Then
        Throw New Exception("Fehler Datum")
    End If
    
    @Html.TextBox("", value, New With {
                      .class = "datepicker",
                      .date_date_format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.ToLower()
                  })  
End Code
