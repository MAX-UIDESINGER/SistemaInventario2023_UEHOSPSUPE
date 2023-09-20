Imports System.Data.SqlClient
Imports System.Configuration

Public Class CConnection
    Dim cadConexion As String
    Dim oConexion As SqlConnection

    'FUNCION QUE DEVUELVE LA CONEXION
    Public Function getConnection() As SqlConnection
        'leer archivo de configuracon
        cadConexion = ConfigurationManager.ConnectionStrings("myconn").ConnectionString
        'crear un objeto a partir de la conexion
        oConexion = New SqlConnection(cadConexion)
        oConexion.Open()
        'retorna
        Return oConexion
    End Function

    Public Function RowsList(name_sp As String) As DataTable
        Using oConn As SqlConnection = getConnection()
            'utilizar comandos cmd
            Using oCmd As SqlCommand = New SqlCommand(name_sp, oConn)
                'indicamos el tipo de comandos
                oCmd.CommandType = CommandType.StoredProcedure
                'adaptador de datos
                Dim oDa As New SqlDataAdapter(oCmd)
                'tabla temporal
                Dim oDt As New DataTable
                'cargamos la tabla
                oDa.Fill(oDt)
                'cerrar la conexion
                oConn.Close()
                'retornar la tabla de datos
                Return oDt

            End Using
        End Using
    End Function
    Public Function FilterRowsList(name_sp As String, parametros As List(Of SqlParameter)) As DataTable
        Using oConn As SqlConnection = getConnection()
            Using oCmd As SqlCommand = New SqlCommand(name_sp, oConn)
                oCmd.CommandType = CommandType.StoredProcedure
                For Each parametro As SqlParameter In parametros
                    oCmd.Parameters.Add(parametro)
                Next
                Dim oDa As New SqlDataAdapter(oCmd)
                Dim oDt As New DataTable
                oDa.Fill(oDt)
                oConn.Close()
                Return oDt
            End Using
        End Using
    End Function

End Class
