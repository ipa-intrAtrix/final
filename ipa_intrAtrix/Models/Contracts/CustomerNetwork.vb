﻿Imports System.ComponentModel.DataAnnotations

Namespace Models.Contracts

    <Bind(Exclude:="CustId")>
    Public Class CustomerNetwork

        Private _custId As Integer
        Private _spiderId As String
        Private _internalDescr As String
        Private _schema As String
        Private _starting As Date?
        Private _shutdown As Date?
        Private _warantyExp As Date?
        Private _waranty As Waranty
        Private _elements As IList(Of Element)


        Public Sub New()
            Elements = New List(Of Element)
        End Sub


        <ScaffoldColumn(False)>
        Public Overridable Property CustId() As Integer
            Get
                Return _custId
            End Get
            Set(value As Integer)
                _custId = value
            End Set
        End Property

        <Required()>
        Public Overridable Property SpiderId() As String
            Get
                Return _spiderId
            End Get
            Set(value As String)
                _spiderId = value
            End Set
        End Property

        <Required()>
        Public Overridable Property InternalDescr() As String
            Get
                Return _internalDescr
            End Get
            Set(value As String)
                _internalDescr = value
            End Set
        End Property

        Public Overridable Property Schema() As String
            Get
                Return _schema
            End Get
            Set(value As String)
                _schema = value
            End Set
        End Property



        <DataType(DataType.Date), DisplayFormat(DataFormatString:="{0:d}")>
        Public Overridable Property Starting() As Date?
            Get
                Return _starting
            End Get
            Set(value As Date?)
                _starting = value
            End Set
        End Property


        <DataType(DataType.Date), DisplayFormat(DataFormatString:="{0:d}")>
        Public Overridable Property Shutdown() As Date?
            Get
                Return _shutdown
            End Get
            Set(value As Date?)
                _shutdown = value
            End Set
        End Property


        <DataType(DataType.Date), DisplayFormat(DataFormatString:="{0:d}")>
        Public Overridable Property WarantyExp() As Date?
            Get
                Return _warantyExp
            End Get
            Set(value As Date?)
                _warantyExp = value
            End Set
        End Property

        Public Overridable Property Waranty() As Waranty
            Get
                Return _waranty
            End Get
            Set(value As Waranty)
                _waranty = value
            End Set
        End Property

        Public Overridable Property Elements() As IList(Of Element)
            Get
                Return _elements
            End Get
            Set(value As IList(Of Element))
                _elements = value
            End Set
        End Property


    End Class
End Namespace