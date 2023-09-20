Imports DataAccessLayer
Public Class CTiposEquiposDML
    Dim oConn As New CConnection
    Public Function SelectAllTiposEquipos() As DataTable
        Return oConn.RowsList("SP_TB_TIPOS_EQUIPOS_SelectAll")
    End Function
End Class
