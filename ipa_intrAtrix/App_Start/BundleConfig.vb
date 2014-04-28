Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig

    Public Shared Sub RegisterBundles(bundles As BundleCollection)
        bundles.IgnoreList.Clear()

        bundles.Add(New ScriptBundle("~/bundles/Scripts/jquery").Include("~/Content/Scripts/jquery-{version}.js", "~/Content/Scripts/datepicker.js", "~/Content/Scripts/jquery-ui-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/Scripts/bootstrapjs").Include("~/Content/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/CSS/bootstrapcss").Include("~/Content/bootstrap.css", "~/Content/bootstrap-theme.css", "~/Content/dashboard.css"))

        bundles.Add(New StyleBundle("~/Content/CSS/jquerycss").Include("~/Content/jquery.ui.datepicker.css"))


    End Sub
End Class
