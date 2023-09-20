Imports DataManagerLayer
Public Class CTiposSistemaBL
    Dim oTiposSistemaDML As New CTiposSistemaDML
    Public Function ListarTiposSistema() As DataTable
        Return oTiposSistemaDML.SelectAllTiposSistema()
    End Function
End Class
