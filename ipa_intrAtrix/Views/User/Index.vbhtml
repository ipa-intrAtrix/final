@ModelType ipa_intrAtrix.Models.Contracts.Users

@Code
    ViewData("Title") = "Details"
    ViewData("Info") = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."

End Code



    <div>
    <div class="table-responsive">
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>User ID
                    </th>
                    <th>Vorname
                    </th>
                    <th>Nachname
                    </th>
                    <th>Domain Name
                    </th>
                    <th>PC
                    </th>
                    <th>IP
                    </th>
                    <th>Benutzername
                    </th>
                    <th>Password
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                        <td>
                            @Html.DisplayFor(Function(model) model.UserId)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.Name)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.Lastname)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.DomainName)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.Pc)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.Ip)

                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.Username)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(model) model.Pass)
                        </td>
                        
                    </tr>
            </tbody>
        </table>
    </div>
</div>