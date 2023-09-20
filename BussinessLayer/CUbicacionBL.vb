Imports DataManagerLayer
Public Class CUbicacionBL
    Dim oUbicacionDML As New CUbicacionDML
    Public Function ListarUbicacion() As DataTable
        Return oUbicacionDML.SelectAllUbicacion()
    End Function
End Class
