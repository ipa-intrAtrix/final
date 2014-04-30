Imports NHibernate.Criterion
Imports ipa_intrAtrix.Models.Contracts
Imports NHibernate

Namespace Models
    Public Class UserHelper
        Public Function GetUserData() As IList(Of Users)

            Dim users As IList(Of Users)
            Using session As ISession = NHibernateHelper.GetCurrentSession()

                Dim criteria As ICriteria = session.CreateCriteria(GetType(Users))
                users = criteria.List(Of Users)()
            End Using

            Return users
        End Function



       
    End Class
End Namespace