Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class UserController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /UserData
    Function Index() As ActionResult
        Return View()
    End Function


    '
    ' GET: /UserData/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function


    '
    ' GET: /UserData/Create
    Function Create() As ActionResult
        Dim userData As New Users
        Return View(userData)
    End Function


    '
    ' POST: /UserData/Create
    <HttpPost()> _
    Function Create(userData As Users) As ActionResult
        Try
            Dim userHelper As New UserHelper
            userHelper.CreateUser(userData)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function


    '
    ' GET: /UserData/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        Dim userHelper As New UserHelper
        Dim userData = userHelper.GetUserById(id)

        If IsNothing(userData) Then
            Return HttpNotFound()
        End If

        Return View(userData)
    End Function


    '
    ' POST: /UserData/Edit/5
    <HttpPost()> _
    Function Edit(ByVal id As Integer, users As Users) As ActionResult
        Try
            Dim userHelper As New UserHelper
            userHelper.UpdateUser(users)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function


    '
    ' GET: /UserData/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult
        Dim userHelper As New UserHelper

        Return View(userHelper.GetUserById(id))
    End Function


    '
    ' POST: /UserData/Delete/5
    <HttpPost()> _
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            Dim userHelper As New UserHelper
            Dim userData = userHelper.GetUserById(id)
            userHelper.DeleteUser(userData)
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class