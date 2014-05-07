@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    'ViewData("Title") = "Bearbeiten:" + Model.CustId
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
    
    
End Code



@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)
    
    @<div>
        @*<div class="form-group">
            @Html.LabelFor(Function(model) model.CustId, "Kundennetzwerk ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.CustId, New With {.class = "form-control", .disabled = True})
            @Html.ValidationMessageFor(Function(model) model.CustId)
        </div>*@

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SpiderId, "Spider ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.SpiderId, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.SpiderId, Nothing, New With {.class = "help-inline"})
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InternalDescr, "Interne Beschreibung:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.InternalDescr, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.InternalDescr, Nothing, New With {.class = "help-inline"})
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Schema, "Netzwerkschema:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Schema, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Schema, Nothing, New With {.class = "help-inline"})
        </div>

        

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Starting, "Inbetriebnahme:", New With {.class = "control-label"})

            @Html.EditorFor(Function(model) model.Starting, New With {.placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.Starting, Nothing, New With {.class = "help-inline"})
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Shutdown, "Ausserbetriebnahme:", New With {.class = "control-label"})

            @Html.EditorFor(Function(model) model.Shutdown, New With {.placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.Shutdown, Nothing, New With {.class = "help-inline"})
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Waranty.WarantyDescr, "Garantieart:", New With {.class = "control-label"})
            @Html.DropDownListFor(Function(model) model.Waranty.WarantyId, New SelectList(ViewData("GarantieArt"), "WarantyId", "WarantyDescr"), New With {.class = "form-control"})

        </div>

        

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WarantyExp, "Garantie:", New With {.class = "control-label"})

            @Html.EditorFor(Function(model) model.WarantyExp, New With {.placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.WarantyExp, Nothing, New With {.class = "help-inline"})
        </div>

        <p>
            @Html.ActionLink("Zurück", "Index", Nothing, New With {.class = "btn btn-default", .role = "button"})
            <input type="submit" value="Kundennetzwerk speichern" class="btn btn-primary" />
        </p>
    </div>
End Using


@section Scripts
    @Scripts.Render("~/bundles/Scripts/jquery")
    @Scripts.Render("~/bundles/Scripts/jqueryval")
    @Scripts.Render("~/bundles/Scripts/bootstrapjs")
    <script type="text/javascript">
        $('.datepicker').datepicker();
    </script>
End Section

