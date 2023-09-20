Imports DataAccessLayer
Public Class C_HARDWARE_DML
    Dim oConn As New CConnection
    'Funcion que retorna las filas 
    Public Function SelectAll() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_SelectAll")
    End Function
    Public Function Contador() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador")
    End Function

    'Funcion para contar los datos Equipos  DE HARDWARE 'ACTIVO'
    Public Function ContadorHardwareCPUActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_CPU_ACTIVO")
    End Function
    Public Function ContadorHardwareLaptopActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_LAPTOP_ACTIVO")
    End Function

    Public Function ContadorHardwareServidorActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_SERVIDOR_ACTIVO")
    End Function

    'Funcion para contar los datos Perifericos DE HARDWARE 'ACTIVO'
    Public Function ContadorHardwareMonitorActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_MONITOR_ACTIVO")
    End Function

    Public Function ContadorHardwareTecladoActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_TECLADO_ACTIVO")
    End Function


    Public Function ContadorHardwareMauseActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_MOUSE_ACTIVO")
    End Function


    Public Function ContadorHardwareEstabilizarActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_ESTABILIZADOR_ACTIVO")
    End Function

    Public Function ContadorHardwareImpresoraActivo() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_IMPRESORA_ACTIVO")
    End Function


    'Funcion para contar los datos Equipos  DE HARDWARE 'DESHABILITADO'
    Public Function ContadorHardwareCPUDeshabilitado() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_CPU_DESHABILITADO")
    End Function
    Public Function ContadorHardwareLaptopDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_LAPTOP_DESHABILITADO")
    End Function

    Public Function ContadorHardwareServidorDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_SERVIDOR_DESHABILITADO")
    End Function

    'Funcion para contar los datos Perifericos DE HARDWARE 'DESHABILITADO'
    Public Function ContadorHardwareMonitorDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_MONITOR_DESHABILITADO")
    End Function

    Public Function ContadorHardwareTecladoDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_TECLADO_DESHABILITADO")
    End Function


    Public Function ContadorHardwareMauseDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_MOUSE_DESHABILITADO")
    End Function


    Public Function ContadorHardwareEstabilizarDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_ESTABILIZADOR_DESHABILITADO")
    End Function

    Public Function ContadorHardwareImpresoraDeshabilitad() As DataTable
        Return oConn.RowsList("SP_TB_HARDWARE_Contador_IMPRESORA_DESHABILITADO")
    End Function

End Class
