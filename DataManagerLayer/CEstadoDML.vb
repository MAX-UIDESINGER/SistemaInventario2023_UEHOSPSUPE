Imports DataAccessLayer
Public Class CEstadoDML
    Dim oConn As New CConnection
    Public Function SelectAllEstado() As DataTable
        Return oConn.RowsList("SP_TB_ESTADO_SelectAll")
    End Function
End Class
