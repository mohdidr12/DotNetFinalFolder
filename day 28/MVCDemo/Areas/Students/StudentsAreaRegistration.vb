Imports System.Web.Mvc

Namespace Areas.Students
    Public Class StudentsAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Students"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As AreaRegistrationContext)
            context.MapRoute(
                "Students_default",
                "Students/{controller}/{action}/{id}",
                New With {.action = "Index", .id = UrlParameter.Optional}
            )
        End Sub
    End Class
End Namespace