Imports DataManagerLayer
Public Class CTiposEquiposBL
    Dim oTiposEquiposDML As New CTiposEquiposDML
    Public Function ListarTiposEquipos() As DataTable
        Return oTiposEquiposDML.SelectAllTiposEquipos()
    End Function
End Class
