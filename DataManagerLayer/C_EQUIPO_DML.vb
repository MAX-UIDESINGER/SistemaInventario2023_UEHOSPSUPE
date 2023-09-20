Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports DataAccessLayer
Imports EntityLayer
Public Class C_EQUIPO_DML
    Dim oConn As New CConnection
    'Funcion que retorna las filas 
    Public Function SelectAllEquipo() As DataTable
        Return oConn.RowsList("SP_TB_EQUIPOS_SelectAll")
    End Function
    Public Function SelectAllDescEquipo() As DataTable
        Return oConn.RowsList("SP_TB_DESC_EQUIPOS_SelectAll")
    End Function
    Public Function SelectAllEquipoDeshabilitado() As DataTable
        Return oConn.RowsList("SP_TB_EQUIPOS_Deshabilitado_SelectAll")
    End Function
    'Funcion para contar los datos DE EQUIPOS 
    Public Function ContadorDatosEquipos() As DataTable
        Return oConn.RowsList("SP_TB_EQUIPOS_Contador")
    End Function
    Public Function ContadorEquiposDeshabilitado() As DataTable
        Return oConn.RowsList("SP_TB_EQUIPOS_Contador_deshabilitado")
    End Function

    Public Function Insert(oEnt As CEquipoEL) As String
        Try
            Using conexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand
                    oCmd.Connection = conexion
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "SP_TB_EQUIPOS_insert"
                    oCmd.Parameters.Add("@COD_PAT_EQUI", SqlDbType.VarChar, 50).Value = oEnt.COD_PAT_EQUI1
                    oCmd.Parameters.Add("@MARCA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.MARCA_EQUI1
                    oCmd.Parameters.Add("@MODELO_EQUI", SqlDbType.VarChar, 50).Value = oEnt.MODELO_EQUI1
                    oCmd.Parameters.Add("@COLOR_EQUI", SqlDbType.VarChar, 50).Value = oEnt.COLOR_EQUI1
                    oCmd.Parameters.Add("@SERIE_EQUI", SqlDbType.VarChar, 50).Value = oEnt.SERIE_EQUI1
                    oCmd.Parameters.Add("@PLACA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.PLACA_EQUI1
                    oCmd.Parameters.Add("@PROC_EQUI", SqlDbType.VarChar, 50).Value = oEnt.PROC_EQUI1
                    oCmd.Parameters.Add("@RAM_EQUI", SqlDbType.VarChar, 50).Value = oEnt.RAM_EQUI1
                    oCmd.Parameters.Add("@DISCO_EQUI", SqlDbType.VarChar, 50).Value = oEnt.DISCO_EQUI1
                    oCmd.Parameters.Add("@TAR_VID_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TAR_VID_EQUI1
                    oCmd.Parameters.Add("@TAR_RED_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TAR_RED_EQUI1
                    oCmd.Parameters.Add("@PILA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.PILA_EQUI1
                    oCmd.Parameters.Add("@TONER_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TONER_EQUI1
                    oCmd.Parameters.Add("@TINTA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TINTA_EQUI1
                    oCmd.Parameters.Add("@OTRO_EQUI", SqlDbType.VarChar, 50).Value = oEnt.OTRO_EQUI1
                    oCmd.Parameters.Add("@FUNTE_ALIME_EQUI", SqlDbType.VarChar, 50).Value = oEnt.FUNTE_ALIME_EQUI1
                    oCmd.Parameters.Add("@FECHA_REG_EQUI", SqlDbType.Date).Value = oEnt.FECHA_REG_EQUI1
                    oCmd.Parameters.Add("@ID_ESTADO", SqlDbType.VarChar, 50).Value = oEnt.ID_ESTADO1
                    oCmd.Parameters.Add("@ID_TIP_EQUI", SqlDbType.Char, 4).Value = oEnt.ID_TIP_EQUI1
                    oCmd.Parameters.Add("@ID_AREA", SqlDbType.Char, 4).Value = oEnt.ID_AREA1
                    oCmd.Parameters.Add("@ID_UBIC", SqlDbType.Char, 4).Value = oEnt.ID_UBIC1
                    oCmd.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 6).Value = oEnt.ID_USUARIO1
                    oCmd.Parameters.Add("@ACTIVIDA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.ACTIVIDA_EQUI1
                    oCmd.Parameters.Add("@DESCRIP_EQUI", SqlDbType.VarChar, 150).Value = oEnt.DESCRIP_EQUI1
                    oCmd.ExecuteNonQuery()
                    conexion.Close()
                    Return "Inserción OK"
                End Using
            End Using
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Update(oEnt As CEquipoEL) As String
        Try
            Using oConexion As SqlConnection = oConn.getConnection
                Using oCmd As SqlCommand = New SqlCommand()
                    oCmd.Connection = oConexion
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.CommandText = "SP_TB_EQUIPOS_Update"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@ID_EQUI", SqlDbType.Char, 6).Value = oEnt.ID_EQUI1
                    oCmd.Parameters.Add("@COD_PAT_EQUI", SqlDbType.VarChar, 50).Value = oEnt.COD_PAT_EQUI1
                    oCmd.Parameters.Add("@MARCA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.MARCA_EQUI1
                    oCmd.Parameters.Add("@MODELO_EQUI", SqlDbType.VarChar, 50).Value = oEnt.MODELO_EQUI1
                    oCmd.Parameters.Add("@COLOR_EQUI", SqlDbType.VarChar, 50).Value = oEnt.COLOR_EQUI1
                    oCmd.Parameters.Add("@SERIE_EQUI", SqlDbType.VarChar, 50).Value = oEnt.SERIE_EQUI1
                    oCmd.Parameters.Add("@PLACA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.PLACA_EQUI1
                    oCmd.Parameters.Add("@PROC_EQUI", SqlDbType.VarChar, 50).Value = oEnt.PROC_EQUI1
                    oCmd.Parameters.Add("@RAM_EQUI", SqlDbType.VarChar, 50).Value = oEnt.RAM_EQUI1
                    oCmd.Parameters.Add("@DISCO_EQUI", SqlDbType.VarChar, 50).Value = oEnt.DISCO_EQUI1
                    oCmd.Parameters.Add("@TAR_VID_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TAR_VID_EQUI1
                    oCmd.Parameters.Add("@TAR_RED_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TAR_RED_EQUI1
                    oCmd.Parameters.Add("@PILA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.PILA_EQUI1
                    oCmd.Parameters.Add("@TONER_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TONER_EQUI1
                    oCmd.Parameters.Add("@TINTA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.TINTA_EQUI1
                    oCmd.Parameters.Add("@OTRO_EQUI", SqlDbType.VarChar, 50).Value = oEnt.OTRO_EQUI1
                    oCmd.Parameters.Add("@FUNTE_ALIME_EQUI", SqlDbType.VarChar, 50).Value = oEnt.FUNTE_ALIME_EQUI1
                    oCmd.Parameters.Add("@FECHA_REG_EQUI", SqlDbType.Date).Value = oEnt.FECHA_REG_EQUI1
                    oCmd.Parameters.Add("@ID_ESTADO", SqlDbType.VarChar, 50).Value = oEnt.ID_ESTADO1
                    oCmd.Parameters.Add("@ID_TIP_EQUI", SqlDbType.Char, 4).Value = oEnt.ID_TIP_EQUI1
                    oCmd.Parameters.Add("@ID_AREA", SqlDbType.Char, 4).Value = oEnt.ID_AREA1
                    oCmd.Parameters.Add("@ID_UBIC", SqlDbType.Char, 4).Value = oEnt.ID_UBIC1
                    oCmd.Parameters.Add("@ID_USUARIO", SqlDbType.Char, 6).Value = oEnt.ID_USUARIO1
                    oCmd.Parameters.Add("@ACTIVIDA_EQUI", SqlDbType.VarChar, 50).Value = oEnt.ACTIVIDA_EQUI1
                    oCmd.Parameters.Add("@DESCRIP_EQUI", SqlDbType.VarChar, 150).Value = oEnt.DESCRIP_EQUI1
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
                    oCmd.CommandText = "SP_TB_EQUIPOS_Delete"
                    'Establecer los parametros'
                    oCmd.Parameters.Add("@ID_EQUI", SqlDbType.Char, 6).Value = pArticuloId
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

    Public Function SelectByID(pArticuloId As String) As DataTable
        'creamos la lista dinamica de parametros
        Dim lista As New List(Of SqlParameter)
        'establecemos los parametros
        Dim paramID As New SqlParameter("@ID_EQUI", pArticuloId)
        'agregamos a la lista 
        lista.Add(paramID)
        'retornar
        Return oConn.FilterRowsList("SP_TB_EQUIPOS_SelectByID", lista)
    End Function
End Class
