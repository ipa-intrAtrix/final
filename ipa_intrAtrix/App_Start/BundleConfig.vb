Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig

    Public Shared Sub RegisterBundles(bundles As BundleCollection)
        bundles.IgnoreList.Clear()

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrapjs").Include("~/Scripts/bootstrap.min.js"))

        bundles.Add(New StyleBundle("~/Content/bootstrapcss").Include("~/Content/bootstrap.min.css", "~/Content/bootstrap-responsive.min.css"))
    End Sub
End Class
