Imports DataManagerLayer

Public Class CEstadoBL
    Dim oEstadoDML As New CEstadoDML
    Public Function ListarEstado() As DataTable
        Return oEstadoDML.SelectAllEstado()
    End Function
End Class
