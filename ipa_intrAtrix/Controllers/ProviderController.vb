Imports ipa_intrAtrix.Models
Imports ipa_intrAtrix.Models.Contracts

Public Class ProviderController
    Inherits System.Web.Mvc.Controller

    Dim _providerHelper As ProviderHelper

    Public Sub New()
        _providerHelper = New ProviderHelper
    End Sub


    '
    ' GET: /Provider

    Function Index() As ActionResult
        Return View(_providerHelper.GetProviders())
    End Function

    '
    ' GET: /Provider/Details/5

    Function Details(ByVal id As Integer) As ActionResult
        Return View(_providerHelper.GetProviderById(id))
    End Function

    '
    ' GET: /Provider/Create

    Function Create() As ActionResult
        Dim providers As New Providers

        Return View(providers)
    End Function

    '
    ' POST: /Provider/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken> _
    Function Create(ByVal providers As Providers) As ActionResult
        Try
            If ModelState.IsValid Then
                _providerHelper.CreateProvider(providers)
                Return RedirectToAction("Index")
            End If
            Return View(providers)
        Catch
            Return View()
        End Try
    End Function

    '
    ' GET: /Provider/Edit/5

    Function Edit(ByVal id As Integer) As ActionResult
        Dim provider = _providerHelper.GetProviderById(id)
        Return View(provider)
    End Function

    '
    ' POST: /Provider/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken> _
    Function Edit(ByVal id As Integer, providers As Providers, collection As FormCollection) As ActionResult
        Try

            If ModelState.IsValid Then
                _providerHelper.UpdateProvider(providers)

                Return RedirectToAction("Index")
            End If
            Return View(providers)
        Catch
            Return View()
        End Try
    End Function

    '
    ' GET: /Provider/Delete/5

    Function Delete(ByVal id As Integer) As ActionResult
        Return View(_providerHelper.GetProviderById(id))
    End Function

    '
    ' POST: /Provider/Delete/5

    <HttpPost()> _
    Function Delete(ByVal id As Integer, provider As Providers) As ActionResult
        Try
            _providerHelper.DeleteProvider(provider)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class