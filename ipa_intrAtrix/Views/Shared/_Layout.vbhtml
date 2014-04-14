<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/bootstrapcss")
</head>
<body>
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span3">
                <div class="well sidebar-nav">
                    <ul class="nav nav-list">
                        <li class="nav-header">Kundennetzwerke</li>
                            <li>@Html.ActionLink("Alle Kundennetzwerke", "Index", "Customer")</li>
                            <li>@Html.ActionLink("Kundennetzwerk erfassen", "Create", "Customer")</li>
                        <li class="nav-header">Lieferantenangaben</li>
                            <li>@Html.ActionLink("Alle Lieferantenangaben", "Index", "Provider")</li>
                            <li>@Html.ActionLink("Lieferanten erfassen", "Create", "Provider")</li>
                        <li class="nav-header">@User.Identity.Name</li>
                            <li>@Html.ActionLink("Eigenes Profil", "Index", "User")</li>
                    </ul>
                </div>
            </div>
            <div class="span9">
                @RenderSection("featured", required:=False)
                <div class="row-fluid">
                    @RenderBody()
                </div>

            </div>
        </div>
    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrapjs")
</body>
</html>
@*http://www.mytecbits.com/microsoft/dot-net/bootstrap-with-asp-net-mvc-4-step-by-step 
http://dotnet-forum.de/KnowledgeBase/articles/2008/06/02/242-vom-code-zur-dokumentation-teil-01-prerequisits-und-vorbereitungen.aspx
http://www.asp.net/mvc/tutorials/mvc-4/getting-started-with-aspnet-mvc4/examining-the-details-and-delete-methods
http://nmg.codeplex.com/
*@