
Imports DataManagerLayer

Public Class C_HARDWARE_BL
    'declarar y crear un objeto a patir del DML 
    Dim oTipHardwareDML As New C_HARDWARE_DML
    'funcion que retorna las filas 
    Public Function listarHarware() As DataTable
        Return oTipHardwareDML.SelectAll
    End Function
    Public Function Contador() As DataTable
        Return oTipHardwareDML.Contador
    End Function

    'funcion para contador de datos Equipos 'ACTIVO'
    Public Function ContadorCPU() As DataTable
        Return oTipHardwareDML.ContadorHardwareCPUActivo
    End Function
    Public Function ContadorLaptop() As DataTable
        Return oTipHardwareDML.ContadorHardwareLaptopActivo
    End Function
    Public Function ContadorServidor() As DataTable
        Return oTipHardwareDML.ContadorHardwareServidorActivo
    End Function

    'funcion para contador de datos Perifericos 'ACTIVO'
    Public Function ContadorMonitor() As DataTable
        Return oTipHardwareDML.ContadorHardwareMonitorActivo
    End Function
    Public Function ContadorTeclado() As DataTable
        Return oTipHardwareDML.ContadorHardwareTecladoActivo
    End Function
    Public Function ContadorMause() As DataTable
        Return oTipHardwareDML.ContadorHardwareMauseActivo
    End Function
    Public Function ContadorEstabilizador() As DataTable
        Return oTipHardwareDML.ContadorHardwareEstabilizarActivo
    End Function

    Public Function ContadorImpresora() As DataTable
        Return oTipHardwareDML.ContadorHardwareImpresoraActivo
    End Function

    'funcion para contador de datos 'DESHABILITADO' 

    Public Function ContadorCPU_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareCPUDeshabilitado
    End Function
    Public Function ContadorLaptop_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareLaptopDeshabilitad
    End Function
    Public Function ContadorServidor_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareServidorDeshabilitad
    End Function

    'funcion para contador de datos Perifericos 'DESHABILITADO'
    Public Function ContadorMonitor_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareMonitorDeshabilitad
    End Function
    Public Function ContadorTeclado_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareTecladoDeshabilitad
    End Function
    Public Function ContadorMause_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareMauseDeshabilitad
    End Function
    Public Function ContadorEstabilizador_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareEstabilizarDeshabilitad
    End Function

    Public Function ContadorImpresora_DESHABILITADO() As DataTable
        Return oTipHardwareDML.ContadorHardwareImpresoraDeshabilitad
    End Function

End Class
