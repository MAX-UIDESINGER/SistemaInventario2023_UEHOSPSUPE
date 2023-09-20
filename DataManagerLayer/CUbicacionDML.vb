Imports DataAccessLayer
Public Class CUbicacionDML
    Dim oConn As New CConnection
    Public Function SelectAllUbicacion() As DataTable
        Return oConn.RowsList("SP_TB_UBICACION_SelectAll")
    End Function
End Class
