
Public Class IntranetHelper
    Public Function GetName(initials As String) As String
        Dim name As String = ""

        Select Case initials
            Case "so"
                name = "Sakir Olgun"
            Case "dg"
                name = "Dominik Gobet"
            Case "us"
                name = "Ursula Schellenberger"
            Case "mp"
                name = "Manuel Prukner"
            Case "jp"
                name = "Jeanpierre 'Cheffe' Rosano"
            Case "km"
                name = "Kevin Macias"
            Case "ds"
                name = "Dave Stettler"
            Case "ic"
                name = "Ivan Cuk"
        End Select

        Return name

    End Function
End Class