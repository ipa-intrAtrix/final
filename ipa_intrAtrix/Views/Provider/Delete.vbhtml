@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
End Code

<div >


    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.ProviderId)

        @Html.DisplayFor(Function(model) model.ProviderId)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Company)

        @Html.DisplayFor(Function(model) model.Company)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.LockBox)

        @Html.DisplayFor(Function(model) model.LockBox)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.CustomerRef)

        @Html.DisplayFor(Function(model) model.CustomerRef)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Phone)

        @Html.DisplayFor(Function(model) model.Phone)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Email)

        @Html.DisplayFor(Function(model) model.Email)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Weblink)

        @Html.DisplayFor(Function(model) model.Weblink)
    </div>
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
            <input type="submit" value="Delete" class="btn btn-default" />
            @Html.ActionLink("Zurück zur Kundennetzwerkseite ", "Index", New With {.class = "btn btn-primary", .role = "button"})</p>
End Using
</div>