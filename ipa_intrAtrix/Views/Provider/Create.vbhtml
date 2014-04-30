@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."

    'Layout = "~/Views/Shared/_Layout1.vbhtml"
End Code

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.ProviderId, "Lieferanten ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.ProviderId, New With {.class = "form-control", .disabled = True})
            @Html.ValidationMessageFor(Function(model) model.ProviderId)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Company, "Firma:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Company, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Company)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LockBox, "Postfach:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.LockBox, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.LockBox)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustomerRef, "Kundennummer:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.CustomerRef, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.CustomerRef)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Place, "Ort:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Place, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Place)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LoginData.Username, "Username:", New With {.class = "control-label"}) 

            @Html.TextBoxFor(Function(model) model.LoginData.Username, New With {.class = "form-control"})

            @Html.ValidationMessageFor(Function(model) model.LoginData.Username)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LoginData.Password, "Password:", New With {.class = "control-label"}) 

            @Html.TextBoxFor(Function(model) model.LoginData.Password, New With {.class = "form-control"})

            @Html.ValidationMessageFor(Function(model) model.LoginData.Password)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Phone, "Telefon:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Phone, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Phone)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Email, "Email:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Email)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Weblink, "Weblink:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Weblink, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Weblink)
        </div>

        <p>
            @Html.ActionLink("Zurück", "Index", Nothing, New With {.class = "btn btn-default", .role = "button"})
            <input type="submit" value="Lieferant erfassen" class="btn btn-primary" />
        </p>
    </div>
End Using


@Section Scripts
    @Scripts.Render("~/bundles/jquery")
    @*@Scripts.Render("~/bundles/jqueryval")*@

    @Scripts.Render("~/bundles/bootstrapjs")
End Section
