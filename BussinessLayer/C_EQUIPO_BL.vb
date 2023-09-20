Imports DataManagerLayer
Imports EntityLayer
Public Class C_EQUIPO_BL
    'declarar y crear un objeto a patir del DML 
    Dim oTipEquipoDML As New C_EQUIPO_DML
    'funcion que retorna las filas 
    Public Function listarEquipo() As DataTable
        Return oTipEquipoDML.SelectAllEquipo
    End Function
    Public Function listarDescEquipo() As DataTable
        Return oTipEquipoDML.SelectAllDescEquipo
    End Function
    Public Function EquipDeshabilitado() As DataTable
        Return oTipEquipoDML.SelectAllEquipoDeshabilitado
    End Function
    'funcion para contador de datos 
    Public Function Contador() As DataTable
        Return oTipEquipoDML.ContadorDatosEquipos
    End Function
    Public Function ContadorDeshabilitado() As DataTable
        Return oTipEquipoDML.ContadorEquiposDeshabilitado
    End Function
    'funcion para Insertar un registro y devuelve un emsaje 
    Public Function Insertar(oEnt As CEquipoEL) As String
        Return oTipEquipoDML.Insert(oEnt)
    End Function
    Public Function Eliminar(pId As String) As String
        Return oTipEquipoDML.Delete(pId)
    End Function
    'funcion para Editar un registro y devuelve un emsaje 
    Public Function Editar(oEnt As CEquipoEL) As String
        Return oTipEquipoDML.Update(oEnt)
    End Function

    Public Function SeleccionarxID(pId As String) As DataTable
        Return oTipEquipoDML.SelectByID(pId)
    End Function


End Class
