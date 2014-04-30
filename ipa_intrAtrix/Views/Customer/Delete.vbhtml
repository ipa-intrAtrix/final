@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
End Code

<div >


    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.CustId)

        @Html.DisplayFor(Function(model) model.CustId)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.SpiderId)

        @Html.DisplayFor(Function(model) model.SpiderId)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.InternalDescr)

        @Html.DisplayFor(Function(model) model.InternalDescr)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Schema)

        @Html.DisplayFor(Function(model) model.Schema)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Starting)

        @Html.DisplayFor(Function(model) model.Starting)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.Shutdown)

        @Html.DisplayFor(Function(model) model.Shutdown)
    </div>

    <div class="form-group">
        @Html.DisplayNameFor(Function(model) model.WarantyExp)

        @Html.DisplayFor(Function(model) model.WarantyExp)
    </div>

    @Using Html.BeginForm()
        @Html.AntiForgeryToken()
        @<p>
            <input type="submit" value="Delete" class="btn btn-default" />
        @Html.ActionLink("Zurück zur Kundennetzwerkseite ", "Index", New With {.class = "btn btn-primary", .role = "button"})
        </p>
    End Using
</div>
