Imports System.ComponentModel.DataAnnotations

Namespace Models.Contracts

    <Bind(Exclude:="LoginDataId")>
    Public Class LoginData
        Private _loginDataId As Integer
        Private _username As String
        Private _password As String
        Private _provider As IList(Of Providers)

        Public Sub New()
            Me.Provider = New List(Of Providers)
        End Sub

        <ScaffoldColumn(False)>
        Public Overridable Property LoginDataId() As Integer
            Get
                Return _loginDataId
            End Get
            Set(value As Integer)
                _loginDataId = value
            End Set
        End Property

        Public Overridable Property Username() As String
            Get
                Return _username
            End Get
            Set(value As String)
                _username = value
            End Set
        End Property

        <DataType(DataType.Password)>
        Public Overridable Property Password() As String
            Get
                Return _password
            End Get
            Set(value As String)
                _password = value
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