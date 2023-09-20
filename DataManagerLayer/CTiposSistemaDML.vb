Imports DataAccessLayer
Public Class CTiposSistemaDML
    Dim oConn As New CConnection
    Public Function SelectAllTiposSistema() As DataTable
        Return oConn.RowsList("SP_TB_TIPOS_SISTEMA_SelectAll")
    End Function
End Class
