@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    'ViewData("Title") = "Bearbeiten:" + Model.CustId
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
    
    
End Code



@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)
    
    @<div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.CustId, "Kundennetzwerk ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.CustId, New With {.class = "form-control", .disabled = True})
            @Html.ValidationMessageFor(Function(model) model.CustId)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SpiderId, "Spider ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.SpiderId, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.SpiderId)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InternalDescr, "Interne Beschreibung:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.InternalDescr, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.InternalDescr)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Schema, "Netzwerkschema:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Schema, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Schema)
        </div>

        

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Starting, "Inbetriebnahme:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Starting, New With {.class = "form-control datepicker", .placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.Starting)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Shutdown, "Ausserbetriebnahme:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Shutdown, New With {.class = "form-control datepicker", .placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.Shutdown)
        </div>

        @*<div class="form-group">
            @Html.Label("Garantieart:", New With {.class = "control-label"})
            @Html.DropDownList(ViewData("GarantieArt"))
        </div>*@

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Waranty.WarantyDescr, "Garantieart:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Waranty.WarantyDescr, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.Waranty.WarantyDescr)
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WarantyExp, "Garantie:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.WarantyExp, New With {.class = "form-control datepicker", .placeholder = "Datum auswählen..."})
            @Html.ValidationMessageFor(Function(model) model.WarantyExp)
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
    <script type="text/javascript">
        $('#sandbox-container .datepicker').datepicker({
            format: "dd.mm.yyyy",
            orientation: "auto right",
            autoclose: true,
            todayHighlight: true
        });
    </script>
    
    @*@Scripts.Render("~/bundles/Scripts/jqueryui")
    @Styles.Render("~/Content/CSS/themes/base")*@
End Section

