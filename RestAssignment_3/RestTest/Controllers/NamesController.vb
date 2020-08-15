Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class NameController
        Inherits ApiController

        ' GET: api/Names
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"Jhon", "Nick", "Richard", "Nell"}
        End Function


    End Class
End Namespace