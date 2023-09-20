Imports DataAccessLayer
Public Class CAreasDML
    Dim oConn As New CConnection
    Public Function SelectAllAreas() As DataTable
        Return oConn.RowsList("SP_TB_AREAS_SelectAll")
    End Function
End Class
