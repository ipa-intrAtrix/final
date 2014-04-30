@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Title") = Model.Company
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."

End Code

<div >

    <div class="form-group">
        @Html.LabelFor(Function(model) model.ProviderId, "Lieferant ID:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.ProviderId, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Company, "Firma:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.Company, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.CustomerRef, "Kundennummer:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.CustomerRef, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Phone, "Telefon:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.Phone, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Email, "Email:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Place.Name, "Ort:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.Place.Name, New With {.class = "form-control", .disabled = True})

        @Html.LabelFor(Function(model) model.Place.Land, "Land:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.Place.Land, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.LoginData.Username, "Username:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.LoginData.Username, New With {.class = "form-control", .disabled = True})

        @Html.LabelFor(Function(model) model.LoginData.Password, "Password:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.LoginData.Password, New With {.class = "form-control", .disabled = True})
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Weblink, "Weblink:", New With {.class = "control-label"})
    
        @Html.TextBoxFor(Function(model) model.Weblink, New With {.class = "form-control", .disabled = True})
    </div>



    <p>
        @Html.ActionLink("Zurück", "Index", Nothing, New With {.class = "btn btn-primary", .role = "button"})
        @Html.ActionLink("Kundennetzwerk bearbeiten", "Edit", New With {.id = Model.ProviderId}, New With {.class = "btn btn-default", .role = "button"})
    </p>
</div>

