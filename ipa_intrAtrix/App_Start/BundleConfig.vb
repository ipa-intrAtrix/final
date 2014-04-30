Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig

    Public Shared Sub RegisterBundles(bundles As BundleCollection)
        bundles.IgnoreList.Clear()

        bundles.Add(New ScriptBundle("~/bundles/Scripts/jquery").Include("~/Content/Scripts/jquery-*"))


        bundles.Add(New ScriptBundle("~/bundles/Scripts/modernizr").Include("~/Content/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/Scripts/jqueryval").Include("~/Content/Scripts/jquery.unobstrusive*",
                                                                            "~/Content/Scripts/jquery.validate*"))

        bundles.Add(New ScriptBundle("~/bundles/Scripts/bootstrapjs").Include("~/Content/Scripts/bootstrap.js",
                                                                              "~/Content/Scripts/bootstrap-datepicker.js"))



        bundles.Add(New StyleBundle("~/Content/CSS").Include("~/Content/bootstrap.css",
                                                             "~/Content/bootstrap-theme.css",
                                                             "~/Content/dashboard.css",
                                                             "~/Content/datepicker3.css"))

        'bundles.Add(New StyleBundle("~/Content/CSS/themes/base").Include("~/Content/themes/base/jquery.ui.autocomplete.css",
        '                                                             "~/Content/themes/base/jquery.ui.datepicker.css"))



    End Sub
End Class
