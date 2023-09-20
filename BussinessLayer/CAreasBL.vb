Imports DataManagerLayer
Public Class CAreasBL
    Dim oAreasDML As New CAreasDML
    Public Function ListarAreas() As DataTable
        Return oAreasDML.SelectAllAreas()
    End Function
End Class
