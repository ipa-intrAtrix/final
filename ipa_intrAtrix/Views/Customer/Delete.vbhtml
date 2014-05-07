@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
End Code

<div >


    <div class="form-group">
            @Html.LabelFor(Function(model) model.CustId, "Kundennetzwerk ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.CustId, New With {.class = "form-control", .disabled = True})
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SpiderId, "Spider ID:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.SpiderId, New With {.class = "form-control", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InternalDescr, "Interne Beschreibung:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.InternalDescr, New With {.class = "form-control", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Schema, "Netzwerkschema:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Schema, New With {.class = "form-control", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Starting, "Inbetriebnahme:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.Starting, New With {.class = "form-control datepicker", .disabled = True})

        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Shutdown, "Ausserbetriebnahme:", New With {.class = "control-label"}) 

            @Html.TextBoxFor(Function(model) model.Shutdown, New With {.class = "form-control datepicker", .disabled = True})

        </div>



        <div class="form-group">
            @Html.LabelFor(Function(model) model.Waranty.WarantyDescr, "Garantieart:")

            @Html.TextBoxFor(Function(model) model.Waranty.WarantyDescr, New With {.class = "form-control", .disabled = True})
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.WarantyExp, "Garantie:", New With {.class = "control-label"})

            @Html.TextBoxFor(Function(model) model.WarantyExp, New With {.class = "form-control datepicker", .disabled = True})
        </div>

    @Using Html.BeginForm()
        @Html.AntiForgeryToken()
        @<p>
            @Html.ActionLink("Zurück zur Kundennetzwerkseite ", "Index", Nothing, New With {.class = "btn btn-default", .role = "button"})
            <input type="submit" value="Löschen" class="btn btn-primary" />
        
        </p>
    End Using
</div>
