@modeltype Date?
@code
    Html.TextBox("", (If(Model.HasValue, Model.Value.ToShortDateString(), String.Empty)), New With {.class = "datepicker form-control", .data_date_format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.ToLower()})
End Code
