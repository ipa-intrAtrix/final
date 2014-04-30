<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width">
    <meta name="description" content="IPA: Intranet Atrix">
    <meta name="author" content="Sakir Olgun">
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/CSS")
    @*@Styles.Render("~/Content/CSS/themes/base/css")*@
    @Scripts.Render("~/bundles/Scripts/modernizr")
    <style>
    </style>

</head>
@code
    Dim helper As New ipa_intrAtrix.IntranetHelper
    Dim name As String = User.Identity.Name
    name = name.Replace("ATRIXDOM\", "")
    name = helper.GetName(name)

End Code
<body>
    <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container-fluid">
            <div class="navbar-header">
                @Html.ActionLink("Intranet Atrix Consult GmbH", "Index", "Home")
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li>@Html.ActionLink(name, "Index", "User")</li>
                </ul>
                @Using Html.BeginForm("Index", "Search", New With {.class = "navbar-form navbar-right"})
                    '<input type="text" class="form-control" placeholder="Suche...">
                    '<input type="submit" value="Suchen" />
                End Using
            </div>
        </div>
    </div>
    @RenderSection("featured", required:=False)
    <div class="container-fluid">

        <div class="row">

            <div class="col-sm-3 col-md-2 sidebar">
                <ul class="nav nav-sidebar">
                    <li class="active">@Html.ActionLink("Home", "index", "Home")</li>
                </ul>
                <ul class="nav nav-sidebar">
                    <li class="nav-header">Kundennetzwerke</li>
                    <li>@Html.ActionLink("Alle Kundennetzwerke", "Index", "Customer")</li>
                    <li>@Html.ActionLink("Kundennetzwerk erfassen", "Create", "Customer")</li>
                    <li class="nav-header">Lieferantenangaben</li>
                    <li>@Html.ActionLink("Alle Lieferantenangaben", "Index", "Provider")</li>
                    <li>@Html.ActionLink("Lieferanten erfassen", "Create", "Provider")</li>
                </ul>
            </div>
            <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
                <div class="page-header">
                    <h1>
                        @Html.ViewData("Title")

                    </h1>
                    <p>@Html.ViewData("Info")</p>
                </div>
                <div>
                    @RenderBody()
                </div>
            </div>

        </div>
    </div>
        @Scripts.Render("~/bundles/Scripts/jquery")
        @Scripts.Render("~/bundles/Scripts/jqueryval")
        @Scripts.Render("~/bundles/Scripts/bootstrapjs")

    @RenderSection("Scripts", required:=False)
</body>
</html>
