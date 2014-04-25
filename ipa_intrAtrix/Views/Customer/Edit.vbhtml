@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Title") = "Edit"
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
End Code



@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustId, "Kundennetzwerk ID:")

            @Html.TextBoxFor(Function(model) model.CustId, New With {.class = "form-control", .disabled = True})
            @*@Html.ValidationMessageFor(Function(model) model.CustId)*@
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SpiderId, "Spider ID:")

            @Html.TextBoxFor(Function(model) model.SpiderId, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.SpiderId)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InternalDescr, "Interne Beschreibung:")

            @Html.TextBoxFor(Function(model) model.InternalDescr, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.InternalDescr)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Schema, "Netzwerkschema:")

            @Html.TextBoxFor(Function(model) model.Schema, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Schema)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Starting, "Inbetriebnahme:")

            @Html.TextBoxFor(Function(model) model.Starting, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Starting)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Shutdown, "Ausserbetriebnahme:")

            @Html.TextBoxFor(Function(model) model.Shutdown, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Shutdown)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Waranty, "Garantieart:")

            @Html.DropDownListFor(Function(model) model.Waranty, New SelectList(ViewData("GarantieArt"), "value", "text", Model.Waranty.WarantyId), New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Waranty.WarantyDescr)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WarantyExp, "Garantie:")

            @Html.TextBoxFor(Function(model) model.WarantyExp, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.WarantyExp)
        </div>

        <p>
            <input type="submit" value="Save" class="btn btn-default" />
        </p>
    </div>
End Using

<div>
    @Html.ActionLink("Zurück", "Index", New With {.class = "btn btn-primary active", .role = "button"})
</div>


