Imports System.Data.SqlClient
Imports DataAccessLayer
Imports EntityLayer
Imports SupportLayer

Public Class C_USUARIO_DML
    Dim oConn As New CConnection
    'Funcion que retorna las filas 
    Public Function SelectAllUsuario() As DataTable
        Return oConn.RowsList("SP_TB_USUARIO_SelectAll")
    End Function

    Public Function ContadorUsuario() As DataTable
        Return oConn.RowsList("SP_TB_USUARIO_Contador")
    End Function

    Public Function Insert(oEnt As CUsuarioEL) As String
        Try
            Using conexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand
                    oCmd.Connection = conexion
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "SP_TB_USUARIO_insert"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@NOMB_USU", SqlDbType.VarChar, 50).Value = oEnt.NOMB_USU1
                    oCmd.Parameters.Add("@APELL_USU", SqlDbType.VarChar, 50).Value = oEnt.APELL_USU1
                    oCmd.Parameters.Add("@CORREO_USU", SqlDbType.VarChar, 50).Value = oEnt.CORREO_USU1
                    oCmd.Parameters.Add("@PASS_USU", SqlDbType.VarChar, 50).Value = oEnt.PASS_USU1
                    oCmd.Parameters.Add("@ACCESO_USU", SqlDbType.VarChar, 50).Value = oEnt.ACCESO_USU1
                    oCmd.Parameters.Add("@FECHA_REC_USU", SqlDbType.Date).Value = oEnt.FECHA_REC_USU1
                    oCmd.ExecuteNonQuery()
                    conexion.Close()
                    Return "Inserción de Usuario OK"
                End Using
            End Using
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function Update(oEnt As CUsuarioEL) As String
        Try
            Using oConexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand()
                    oCmd.Connection = oConexion
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "SP_TB_USUARIO_Update"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 4).Value = oEnt.ID_USUARIO1
                    oCmd.Parameters.Add("@NOMB_USU", SqlDbType.VarChar, 50).Value = oEnt.NOMB_USU1
                    oCmd.Parameters.Add("@APELL_USU", SqlDbType.VarChar, 50).Value = oEnt.APELL_USU1
                    oCmd.Parameters.Add("@CORREO_USU", SqlDbType.VarChar, 50).Value = oEnt.CORREO_USU1
                    oCmd.Parameters.Add("@PASS_USU", SqlDbType.VarChar, 50).Value = oEnt.PASS_USU1
                    oCmd.Parameters.Add("@ACCESO_USU", SqlDbType.VarChar, 50).Value = oEnt.ACCESO_USU1
                    oCmd.Parameters.Add("@FECHA_REC_USU", SqlDbType.Date).Value = oEnt.FECHA_REC_USU1
                    oCmd.ExecuteNonQuery()
                    oConexion.Close()
                    Return "Actualización de Usuario ok"
                End Using
            End Using
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function Delete(pArticuloId As String) As String
        Try
            Using oConexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand()
                    'indicar la conexion
                    oCmd.Connection = oConexion
                    'indicar el tipo de comando
                    oCmd.CommandType = CommandType.StoredProcedure
                    'indicar el nombre del SP
                    oCmd.CommandText = "SP_TB_USUARIO_Delete"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 4).Value = pArticuloId
                    oCmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                    'ejecutar
                    oCmd.ExecuteNonQuery()
                    'obtener el emsnaje
                    Dim msg As String = oCmd.Parameters("@mensaje").Value.ToString()
                    'cierre conexion            
                    oConexion.Close()
                    'Registro Borrado
                    Return msg
                End Using
            End Using

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function LoginUsuario(Gmail As String, Pass As String) As Boolean
        Using oConexion As SqlConnection = oConn.getConnection
            Using oCmd As SqlCommand = New SqlCommand()
                oCmd.Connection = oConexion
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.CommandText = "SP_TB_USUARIO_Login"
                oCmd.Parameters.AddWithValue("@CORREO_USU", Gmail)
                oCmd.Parameters.AddWithValue("@PASS_USU", Pass)
                Dim reader = oCmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        UsuarioDatos.idUsuario = reader.GetString(0)
                        UsuarioDatos.Nombre = reader.GetString(1)
                        UsuarioDatos.Apellidos = reader.GetString(2)
                        UsuarioDatos.Email = reader.GetString(3)
                        UsuarioDatos.Acceso = reader.GetString(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function SelectUsuarioByID(pArticuloId As String) As DataTable
        'creamos la lista dinamica de parametros
        Dim lista As New List(Of SqlParameter)
        'establecemos los parametros
        Dim paramID As New SqlParameter("@ID_USUARIO", pArticuloId)
        'agregamos a la lista 
        lista.Add(paramID)
        'retornar
        Return oConn.FilterRowsList("SP_TB_USUARIO_SelectByID", lista)
    End Function

End Class
