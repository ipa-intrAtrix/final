Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig

    Public Shared Sub RegisterBundles(bundles As BundleCollection)
        bundles.IgnoreList.Clear()

        bundles.Add(New ScriptBundle("~/Content/Scripts/jquery").Include("~/Content/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/Content/Scripts/bootstrapjs").Include("~/Content/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/CSS/bootstrapcss").Include("~/Content/bootstrap.css", "~/Content/bootstrap-theme.css", "~/Content/dashboard.css"))
    End Sub
End Class
