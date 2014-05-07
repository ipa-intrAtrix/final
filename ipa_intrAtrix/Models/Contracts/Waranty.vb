Imports System.ComponentModel.DataAnnotations

Namespace Models.Contracts

    <Bind(Exclude:="WarantyId")>
    Public Class Waranty


        Private _warantyId As Integer
        Private _warantyDescr As String
        Private _customerNetworks As IList(Of CustomerNetwork)

        Public Sub New()
            CustomerNetworks = New List(Of CustomerNetwork)
        End Sub


        <ScaffoldColumn(False)>
        Public Overridable Property WarantyId() As Integer
            Get
                Return _warantyId
            End Get
            Set(value As Integer)
                _warantyId = value
            End Set
        End Property

        Public Overridable Property WarantyDescr() As String
            Get
                Return _warantyDescr
            End Get
            Set(value As String)
                _warantyDescr = value
            End Set
        End Property

        Public Overridable Property CustomerNetworks() As IList(Of CustomerNetwork)
            Get
                Return _customerNetworks
            End Get
            Set(value As IList(Of CustomerNetwork))
                _customerNetworks = value
            End Set
        End Property

    End Class
End Namespace