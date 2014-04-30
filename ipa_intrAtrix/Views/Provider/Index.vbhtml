@ModelType IEnumerable(Of ipa_intrAtrix.Models.Contracts.Providers)

@Code
    ViewData("Title") = "Alle Lieferantenangaben"
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
    'Layout = "~/Views/Shared/_Layout1.vbhtml"
End Code

<div>
    <div class="table-responsive">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>Lieferant ID
                    </th>
                    <th>Firma
                    </th>
                    <th>Kundennummer
                    </th>
                    <th>Logindaten
                    </th>
                    <th>Email
                    </th>
                    <th>Ort
                    </th>
                    <th>Weblink
                    </th>
                    @*<th>Ansprechspartner</th>*@

                </tr>
            </thead>
            <tbody>
@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.ProviderId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Company)
        </td>
        
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CustomerRef)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.LoginData.Username)
            <br />
            @Html.DisplayFor(Function(modelItem) currentItem.LoginData.Password)

        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Place.Name)
            <br />
            @Html.DisplayFor(Function(modelItem) currentItem.Place.Land)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Weblink)
        </td>

        <td>
            @Html.ActionLink("Bearbeiten", "Edit", New With {.id = currentItem.ProviderId})
                            <br />
                            @Html.ActionLink("Details", "Details", New With {.id = currentItem.ProviderId})
                            <br />
                            @Html.ActionLink("Löschen", "Delete", New With {.id = currentItem.ProviderId})
        </td>
                    </tr>
                Next
            </tbody>
        </table>
    </div>
</div>