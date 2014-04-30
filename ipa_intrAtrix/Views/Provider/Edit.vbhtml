@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Title") = "Edit"
End Code


@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)
    
    @<div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.ProviderId, "Lieferant ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.ProviderId, New With {.class = "form-control", .disabled = True})
            @*@Html.ValidationMessageFor(Function(model) model.CustId)*@
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Company, "Firma:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Company, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Company)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerRef, "Kundennummer:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.CustomerRef, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.CustomerRef)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Phone, "Telefon:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Phone, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Phone)
        </div>

        

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Email, "Email:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control datepicker", .placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.Email)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LockBox, "Postfach:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.LockBox, New With {.class = "form-control datepicker", .placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.LockBox)
        </div>

        @*<div class="form-group">
            @Html.Label("Garantieart:", New With {.class = "control-label"})
            @Html.DropDownList(ViewData("GarantieArt"))
        </div>*@

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Weblink, "Weblink:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Weblink, New With {.class = "form-control datepicker", .placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.Weblink)
        </div>

        <p>
            @Html.ActionLink("Zurück", "Index", Nothing, New With {.class = "btn btn-default", .role = "button"})
            <input type="submit" value="Kundennetzwerk speichern" class="btn btn-primary" />
        </p>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
