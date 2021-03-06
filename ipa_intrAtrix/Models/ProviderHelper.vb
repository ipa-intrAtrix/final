﻿Imports NHibernate.Criterion
Imports ipa_intrAtrix.Models.Contracts
Imports NHibernate

Namespace Models
    Public Class ProviderHelper
        Public Function GetProviders() As IList(Of Providers)
            Dim providers As IList(Of Providers)
            Using session As ISession = NHibernateHelper.GetCurrentSession()

                Dim criteria As ICriteria = session.CreateCriteria(GetType(Providers))
                providers = criteria.List(Of Providers)()
            End Using

            Return providers
        End Function

        Public Function GetProviderById(id As Integer) As Providers
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Return session.CreateCriteria(Of Providers)().Add(Restrictions.Eq("ProviderId", id)).UniqueResult(Of Providers)()
            End Using
        End Function

        Public Function CreateProvider(providers As Providers) As Integer
            Dim providerNo As Integer
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Save(providers)
                    trans.Commit()
                End Using
            End Using
            Return providerNo
        End Function

        Public Sub UpdateProvider(providers As Providers)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Update(providers)
                    trans.Commit()
                End Using
            End Using
        End Sub

        Public Sub DeleteProvider(providers As Providers)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Delete(providers)
                    trans.Commit()
                End Using
            End Using
        End Sub
    End Class
End Namespace