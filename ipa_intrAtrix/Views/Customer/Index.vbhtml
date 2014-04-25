@ModelType IEnumerable(Of ipa_intrAtrix.Models.Contracts.CustomerNetwork)

@Code
    ViewData("Title") = "Kundennetzwerkangaben von Atrix Consult GmbH"
    ViewData("Info") = "Die Kundennetzwerkdaten sind hier erfasst. Bevor man diese Daten jedoch ändert sollte man das mit dem Systemadministrator besprechen." + Environment.NewLine _
        + "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
    Layout = "~/Views/Shared/_Layout1.vbhtml"
End Code


<div>
    <div class="table-responsive">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>Kundennetzwerk ID
                    </th>
                    <th>Spider ID
                    </th>
                    <th>Interne Beschreibung
                    </th>
                    <th>Netzwerkschema
                    </th>
                    <th>Inbetriebnahme
                    </th>
                    <th>Ausserbetriebnahme
                    </th>
                    <th>Garantieart
                    </th>
                    <th>Garantie
                    </th>

                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    Dim currentItem = item
                    @<tr>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.CustId)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.SpiderId)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.InternalDescr)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.Schema)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.Starting)
                        </td>
                        <td>

                            @Html.DisplayFor(Function(modelItem) currentItem.Shutdown)

                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.Waranty.WarantyDescr)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) currentItem.WarantyExp)
                        </td>
                        <td>
                            @Html.ActionLink("Bearbeiten", "Edit", New With {.id = currentItem.CustId})
                            <br />
                            @Html.ActionLink("Details", "Details", New With {.id = currentItem.CustId})
                            <br />
                            @Html.ActionLink("Löschen", "Delete", New With {.id = currentItem.CustId})
                        </td>
                    </tr>
                Next
            </tbody>
        </table>
    </div>
</div>
