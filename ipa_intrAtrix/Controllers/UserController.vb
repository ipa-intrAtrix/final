Imports ipa_intrAtrix.Models.Contracts
Imports ipa_intrAtrix.Models

Public Class UserController
    Inherits System.Web.Mvc.Controller

    Dim _userHelper As UserHelper

    Public Sub New()
        _userHelper = New UserHelper
    End Sub

    '
    ' GET: /UserData
    Function Index() As ActionResult
        Dim userData = _userHelper.GetUserData()



        Return View(userData)
    End Function


    '
    ' GET: /UserData/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function


End Class