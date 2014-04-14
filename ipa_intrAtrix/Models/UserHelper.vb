Imports NHibernate.Criterion
Imports ipa_intrAtrix.Models.Contracts
Imports NHibernate

Namespace Models
    Public Class UserHelper
        Public Function GetUsers() As IList(Of Users)
            Dim users As IList(Of Users)
            Using session As ISession = NHibernateHelper.GetCurrentSession()

                Dim criteria As ICriteria = session.CreateCriteria(GetType(Users))
                users = criteria.List(Of Users)()
            End Using

            Return users
        End Function

        Public Function GetUserById(id As Integer) As Users
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Return session.CreateCriteria(Of Users)().Add(Restrictions.Eq("UserId", id)).UniqueResult(Of Users)()
            End Using
        End Function

        Public Function CreateUser(user As Users) As Integer
            Dim userNo As Integer
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Save(user)
                    trans.Commit()
                End Using
            End Using
            Return userNo
        End Function

        Public Sub UpdateUser(user As Users)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Update(user)
                    trans.Commit()
                End Using
            End Using
        End Sub

        Public Sub DeleteUser(user As Users)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Delete(user)
                    trans.Commit()
                End Using
            End Using
        End Sub
    End Class
End Namespace