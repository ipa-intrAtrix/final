Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class CustomerController
    Inherits System.Web.Mvc.Controller

    Dim _customerHelper As CustomerHelper

    Public Sub New()
        _customerHelper = New CustomerHelper
    End Sub

    '
    ' GET: /Customer
    Function Index() As ActionResult
        Return View(_customerHelper.GetCustomerNetworks())
    End Function

    '
    ' GET: /Customer/Details/5
    Function Details(ByVal id As Integer) As ActionResult

        Return View(_customerHelper.GetCustomerNetworkById(id))
    End Function


    '
    ' GET: /Customer/Create
    Function Create() As ActionResult
        Dim customerNetwork As New CustomerNetwork
        

        Return View(customerNetwork)
    End Function

    '
    ' POST: /Customer/Create
    <HttpPost()> _
    Function Create(customerNetwork As CustomerNetwork) As ActionResult
        Try

            _customerHelper.CreateCustomerNetwork(customerNetwork)

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function



    '
    ' GET: /Customer/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        Dim customerNetwork = _customerHelper.GetCustomerNetworkById(id)

        ViewData("GarantieArt") = New SelectList(_customerHelper.GetWarantyInfo().Select(Function(x) New SelectListItem() With {.Selected = (x.WarantyId = customerNetwork.Waranty.WarantyId), .Text = x.WarantyDescr, .Value = x.WarantyId.ToString()}))
        'If IsNothing(customerNetwork) Then
        '    Return HttpNotFound()
        'End If

        Return View(customerNetwork)
    End Function

    '
    ' POST: /Customer/Edit/5
    <HttpPost()> _
    Function Edit(ByVal id As Integer, customerNetwork As CustomerNetwork) As ActionResult
        Try


            _customerHelper.UpdateCustomerNetwork(customerNetwork)

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' GET: /Customer/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult

        Return View(_customerHelper.GetCustomerNetworkById(id))
    End Function

    '
    ' POST: /Customer/Delete/5
    <HttpPost()> _
    Function Delete(ByVal id As Integer, customerNetwork As CustomerNetwork) As ActionResult
        Try
            _customerHelper.DeleteCustomerNetwork(customerNetwork)

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class