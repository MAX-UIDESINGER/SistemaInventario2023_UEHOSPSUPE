Imports DataManagerLayer
Imports EntityLayer
Public Class C_USUARIO_BL
    Dim oUsuarioDML As New C_USUARIO_DML
    Public Function ListarUsuario() As DataTable
        Return oUsuarioDML.SelectAllUsuario()
    End Function
    Public Function contador() As DataTable
        Return oUsuarioDML.ContadorUsuario()
    End Function

    Public Function Insertar(oEnt As CUsuarioEL) As String
        Return oUsuarioDML.Insert(oEnt)
    End Function
    Public Function Editar(oEnt As CUsuarioEL) As String
        Return oUsuarioDML.Update(oEnt)
    End Function
    Public Function Eliminar(pId As String) As String
        Return oUsuarioDML.Delete(pId)
    End Function
    Public Function SeleccionarxID(pId As String) As DataTable
        Return oUsuarioDML.SelectUsuarioByID(pId)
    End Function
    Public Function LoginUsuario(Gmail As String, Pass As String) As Boolean
        Return oUsuarioDML.LoginUsuario(Gmail, Pass)
    End Function
End Class
