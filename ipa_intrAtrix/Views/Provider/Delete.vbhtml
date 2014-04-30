@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
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
            @Html.LabelFor(Function(model) model.LockBox, "Postfach:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.LockBox, New With {.class = "form-control", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerRef, "Kundennummer:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.CustomerRef, New With {.class = "form-control", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Phone, "Telefon:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Phone, New With {.class = "form-control ", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Email, "Email:", New With {.class = "control-label"}) 

            @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control", .disabled = True})

        </div>



        <div class="form-group">
            @Html.LabelFor(Function(model) model.Weblink, "Weblink:")

            @Html.TextBoxFor(Function(model) model.Weblink, New With {.class = "form-control", .disabled = True})
        </div>

    @Using Html.BeginForm()
        @Html.AntiForgeryToken()
        @<p>
            @Html.ActionLink("Zurück zu den Lieferantenangaben ", "Index", Nothing, New With {.class = "btn btn-default", .role = "button"})
            <input type="submit" value="Delete" class="btn btn-primary" />
        
        </p>
    End Using
</div>