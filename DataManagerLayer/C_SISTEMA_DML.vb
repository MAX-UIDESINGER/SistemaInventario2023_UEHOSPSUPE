Imports System.Data.SqlClient
Imports DataAccessLayer
Imports EntityLayer
Public Class C_SISTEMA_DML
    Dim oConn As New CConnection
    'Funcion que retorna las filas 
    Public Function SelectAllSistema() As DataTable
        Return oConn.RowsList("SP_TB_SISTEMA_SelectAll")
    End Function

    'Funcion para contar los datos de Perifericos 
    Public Function ContadorDatosSistema() As DataTable
        Return oConn.RowsList("SP_TB_SISTEMA_Contador")
    End Function

    Public Function Insert(oEnt As CSistemaEL) As String
        Try
            Using conexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand
                    oCmd.Connection = conexion
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "SP_TB_SISTEMA_insert"
                    oCmd.Parameters.Add("@ID_TIP_SISTE", SqlDbType.Char, 4).Value = oEnt.ID_TIP_SISTE1
                    oCmd.Parameters.Add("@IP_SISTE", SqlDbType.VarChar, 50).Value = oEnt.IP_SISTE1
                    oCmd.Parameters.Add("@NOMB_SISTE", SqlDbType.VarChar, 50).Value = oEnt.NOMB_SISTE1
                    oCmd.Parameters.Add("@GRUPO_SISTE", SqlDbType.VarChar, 50).Value = oEnt.GRUPO_SISTE1
                    oCmd.Parameters.Add("@OFFICE_SISTE", SqlDbType.VarChar, 50).Value = oEnt.OFFICE_SISTE1
                    oCmd.Parameters.Add("@SISTEMA_SISTE", SqlDbType.VarChar, 50).Value = oEnt.SISTEMA_SISTE1
                    oCmd.Parameters.Add("@ID_ESTADO", SqlDbType.Char, 4).Value = oEnt.ID_ESTADO1
                    oCmd.Parameters.Add("@FECHA_REG_SISTE", SqlDbType.Date).Value = oEnt.FECHA_REG_SISTE1
                    oCmd.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 6).Value = oEnt.ID_USUARIO1
                    oCmd.ExecuteNonQuery()
                    conexion.Close()
                    Return "Inserción OK"
                End Using
            End Using
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Update(oEnt As CSistemaEL) As String
        Try
            Using oConexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand()
                    oCmd.Connection = oConexion
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "SP_TB_SISTEMA_Update"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@ID_SISTE", SqlDbType.Char, 6).Value = oEnt.ID_SISTE1
                    oCmd.Parameters.Add("@ID_TIP_SISTE", SqlDbType.Char, 4).Value = oEnt.ID_TIP_SISTE1
                    oCmd.Parameters.Add("@IP_SISTE", SqlDbType.VarChar, 50).Value = oEnt.IP_SISTE1
                    oCmd.Parameters.Add("@NOMB_SISTE", SqlDbType.VarChar, 50).Value = oEnt.NOMB_SISTE1
                    oCmd.Parameters.Add("@GRUPO_SISTE", SqlDbType.VarChar, 50).Value = oEnt.GRUPO_SISTE1
                    oCmd.Parameters.Add("@OFFICE_SISTE", SqlDbType.VarChar, 50).Value = oEnt.OFFICE_SISTE1
                    oCmd.Parameters.Add("@SISTEMA_SISTE", SqlDbType.VarChar, 50).Value = oEnt.SISTEMA_SISTE1
                    oCmd.Parameters.Add("@ID_ESTADO", SqlDbType.Char, 4).Value = oEnt.ID_ESTADO1
                    oCmd.Parameters.Add("@FECHA_REG_SISTE", SqlDbType.Date).Value = oEnt.FECHA_REG_SISTE1
                    oCmd.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 6).Value = oEnt.ID_USUARIO1
                    oCmd.ExecuteNonQuery()
                    oConexion.Close()
                    Return "Actualización ok"
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
                    oCmd.CommandText = "SP_TB_SISTEMA_Delete"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@ID_SISTE", SqlDbType.Char, 6).Value = pArticuloId
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

    Public Function SelectSistemaByID(pArticuloId As String) As DataTable
        'creamos la lista dinamica de parametros
        Dim lista As New List(Of SqlParameter)
        'establecemos los parametros
        Dim paramID As New SqlParameter("@ID_SISTE", pArticuloId)
        'agregamos a la lista 
        lista.Add(paramID)
        'retornar
        Return oConn.FilterRowsList("SP_TB_SISTEMA_SelectByID", lista)
    End Function
End Class
