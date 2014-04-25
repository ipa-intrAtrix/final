@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Title") = "Delete"
End Code

<div class="container">
    <h2>Delete</h2>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CustId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CustId)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.SpiderId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.SpiderId)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.InternalDescr)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.InternalDescr)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Schema)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Schema)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Starting)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Starting)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Shutdown)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Shutdown)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.WarantyExp)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.WarantyExp)
    </div>

    @Using Html.BeginForm()
        @Html.AntiForgeryToken()
        @<p>
            <input type="submit" value="Delete" class="btn btn-default" />
            |
        @Html.ActionLink("Zurück zur Kundennetzwerkseite ", "Index", New With {.class = "btn btn-primary active", .role = "button"})
        </p>
    End Using
</div>
