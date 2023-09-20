Imports DataManagerLayer
Imports EntityLayer

Public Class C_SISTEMA_BL
    'declarar y crear un objeto a patir del DML 
    Dim oTipSistemaDML As New C_SISTEMA_DML
    'funcion que retorna las filas 
    Public Function listarSistema() As DataTable
        Return oTipSistemaDML.SelectAllSistema
    End Function
    'funcion para contador de datos 
    Public Function Contador() As DataTable
        Return oTipSistemaDML.ContadorDatosSistema
    End Function
    'funcion para Insertar un registro y devuelve un emsaje 
    Public Function Insertar(oEnt As CSistemaEL) As String
        Return oTipSistemaDML.Insert(oEnt)
    End Function
    Public Function Eliminar(pId As String) As String
        Return oTipSistemaDML.Delete(pId)
    End Function
    'funcion para Editar un registro y devuelve un emsaje 
    Public Function Editar(oEnt As CSistemaEL) As String
        Return oTipSistemaDML.Update(oEnt)
    End Function
    Public Function SeleccionarxSistemaID(pId As String) As DataTable
        Return oTipSistemaDML.SelectSistemaByID(pId)
    End Function
End Class
