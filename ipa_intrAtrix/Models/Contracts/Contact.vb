Imports System.ComponentModel.DataAnnotations

Namespace Models.Contracts

    <Bind(Exclude:="ContactId")>
    Public Class Contact
        Private _contactId As Integer
        Private _name As String
        Private _lastname As String
        Private _branch As String
        Private _phone As Integer
        Private _email As String
        Private _provider As IList(Of Providers)


        Public Sub New()
            Provider = New List(Of Providers)()
        End Sub

        <ScaffoldColumn(False)>
        Public Overridable Property ContactId() As Integer
            Get
                Return _contactId
            End Get
            Set(value As Integer)
                _contactId = value
            End Set
        End Property

        Public Overridable Property Name() As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Overridable Property Lastname() As String
            Get
                Return _lastname
            End Get
            Set(value As String)
                _lastname = value
            End Set
        End Property

        Public Overridable Property Branch() As String
            Get
                Return _branch
            End Get
            Set(value As String)
                _branch = value
            End Set
        End Property

        Public Overridable Property Phone() As String
            Get
                Return _phone
            End Get
            Set(value As String)
                _phone = value
            End Set
        End Property

        Public Overridable Property Email() As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
            End Set
        End Property

        Public Overridable Property Provider() As IList(Of Providers)
            Get
                Return _provider
            End Get
            Set(value As IList(Of Providers))
                _provider = value
            End Set
        End Property

    End Class
End Namespace