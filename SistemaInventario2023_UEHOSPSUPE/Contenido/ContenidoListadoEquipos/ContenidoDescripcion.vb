﻿Imports BussinessLayer
Imports SupportLayer

Public Class ContenidoDescripcion
    '-----------------------------------'
    'Objeto a partir de CArticuloBL'
    Dim oTipoEquipoBL As New C_EQUIPO_BL
    '------------------------------------'
    'Validar para recuperar el ID de la fila Seleccionada'
    Dim pId As String
    '------------------------------------'
    Dim oDv As New DataView
    Private Sub cargarRegistros()
        'pasar el datatable al dataview'
        oDv = oTipoEquipoBL.listarDescEquipo().DefaultView
        dgvListadoDescripcion.DataSource = oDv
    End Sub

    Private Sub AgregarRegistro()
        Dim oFrm As New ModalEquipos
        oFrm.lbTitulo.Text = "Agregar Datos de Equipos"
        oFrm.nuevo = True
        oFrm.dtpFechaReg.Value = Today()
        oFrm.CargarComboTiposEquipos()
        oFrm.CargarComboAreas()
        oFrm.CargarComboUbicacion()
        oFrm.CargarComboEstado()
        '------------------------------------'
        oFrm.combosSelect()
        oFrm.ShowDialog()
        cargarRegistros()
    End Sub
    Private Sub ContadorDatos()
        Dim contador As DataRow = oTipoEquipoBL.Contador().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ACTIVIDA_EQUI"))
        labTotal.Text = "(" + DatoContador + ")"
    End Sub
    Private Sub editarRegistro()
        If dgvListadoDescripcion.Rows.Count = 0 Then
            MessageBox.Show("No hay Registro", "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim oFrm As New ModalEquipos
            oFrm.lbTitulo.Text = "Editar Datos de Equipos"
            oFrm.nuevo = False
            pId = dgvListadoDescripcion.Rows(dgvListadoDescripcion.CurrentRow.Index).Cells(0).Value
            Dim oDr As DataRow = oTipoEquipoBL.SeleccionarxID(pId).Rows(0)
            oFrm.txtIdequipo.Text = oDr("ID_EQUI")
            oFrm.txtCodigoPatri.Text = oDr("COD_PAT_EQUI")
            oFrm.txtMarca.Text = oDr("MARCA_EQUI")
            oFrm.txtModelo.Text = oDr("MODELO_EQUI")
            oFrm.txtColor.Text = oDr("COLOR_EQUI")
            oFrm.txtSeries.Text = oDr("SERIE_EQUI")
            oFrm.txtPlacaMadre.Text = oDr("PLACA_EQUI")
            oFrm.txtProcesador.Text = oDr("PROC_EQUI")
            oFrm.txtMemoriaRam.Text = oDr("RAM_EQUI")
            oFrm.txtDisco.Text = oDr("DISCO_EQUI")
            oFrm.txttargevideo.Text = oDr("TAR_VID_EQUI")
            oFrm.txttargRed.Text = oDr("TAR_RED_EQUI")
            oFrm.txtPila.Text = oDr("PILA_EQUI")
            oFrm.txtFuentePoder.Text = oDr("FUNTE_ALIME_EQUI")
            oFrm.dtpFechaReg.Value = oDr("FECHA_REG_EQUI")
            '-----------------------------------------------------------
            oFrm.CargarComboTiposEquipos()
            oFrm.CargarComboAreas()
            oFrm.CargarComboUbicacion()
            oFrm.CargarComboEstado()

            oFrm.cboTipEquipos.SelectedValue = oDr("ID_TIP_EQUI")
            oFrm.cboArea.SelectedValue = oDr("ID_AREA")
            oFrm.CboUbicacion.SelectedValue = oDr("ID_UBIC")
            oFrm.cboEstado.SelectedValue = oDr("ID_ESTADO")
            '-----------------------------------------------------------
            oFrm.cboActivida.Text = oDr("ACTIVIDA_EQUI")
            oFrm.txtDescripcion.Text = oDr("DESCRIP_EQUI")
            '-----------------------------------------------------------
            oFrm.txtUsuario.Text = oDr("ID_USUARIO")
            '-----------------------------------------------------------
            oFrm.ShowDialog()
            cargarRegistros()
            ContadorDatos()
        End If
    End Sub
    Sub eliminarRegistro()
        If dgvListadoDescripcion.Rows.Count = 0 Then
            MessageBox.Show("No hay Registro", "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Dim result As DialogResult
        result = MessageBox.Show("¿Seguro de Eliminar el Registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            pId = dgvListadoDescripcion.Rows(dgvListadoDescripcion.CurrentRow.Index).Cells(0).Value
            Dim msg As String = ""
            msg = oTipoEquipoBL.Eliminar(pId)
            cargarRegistros()
            ContadorDatos()
            MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub realizarBusquedad()
        'evaluar la opcion'
        Select Case cboOpcion.SelectedIndex
            Case 0
                oDv.RowFilter = String.Format("DESC_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 1
                oDv.RowFilter = String.Format("COD_PAT_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 2
                oDv.RowFilter = String.Format("MARCA_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 3
                oDv.RowFilter = String.Format("COLOR_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 4
                oDv.RowFilter = String.Format("MODELO_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 5
                oDv.RowFilter = String.Format("SERIE_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 6
                oDv.RowFilter = String.Format("PROC_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 7
                oDv.RowFilter = String.Format("RAM_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 8
                oDv.RowFilter = String.Format("PLACA_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 9
                oDv.RowFilter = String.Format("DISCO_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 10
                oDv.RowFilter = String.Format("PILA_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 11
                oDv.RowFilter = String.Format("FUNTE_ALIME LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 12
                oDv.RowFilter = String.Format("TAR_VID_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 13
                oDv.RowFilter = String.Format("TAR_RED_EQUI  LIKE '%{0}%'", txtBuscarEquipo.Text)
        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarRegistro()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarRegistro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarRegistro()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim oFrm1 As New PanelReporteVistaPrevia
        oFrm1.lbTitulo.Text = "Reporte Descripcion Equipos"
        nReporte = 2
        PanelReporteVistaPrevia.ShowDialog()
    End Sub
    Private Sub ContenidoDescripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros()
        ContadorDatos()
        'obsion del combobox
        cargarComboSelected()
        userMethods()
    End Sub

    Private Sub userMethods()

        If UsuarioDatos.Acceso = PrivilegiosUsuario.usuario Then
            btnEliminar.Visible = False
        End If
        If UsuarioDatos.Acceso = PrivilegiosUsuario.administrador Then
            btnEliminar.Visible = True
        End If

    End Sub

    Private Sub cargarComboSelected()
        dtpFecha.Value = Today()
        cboOpcion.SelectedIndex = 1
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        txtBuscarEquipo.Text = ""
    End Sub

    Private Sub txtBuscarEquipo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEquipo.TextChanged
        If txtBuscarEquipo.TextLength > 0 Then
            realizarBusquedad()
        Else
            oDv.RowFilter = Nothing
        End If
    End Sub

    Private Sub btnFiltarFecha_Click(sender As Object, e As EventArgs) Handles btnFiltarFecha.Click
        If dtpFecha.TextRenderingHint > 0 Then
            oDv.RowFilter = String.Format("CONVERT(FECHA_REG_EQUI, System.String) LIKE '%{0}%'", dtpFecha.Value.ToString("dd/MM/yyyy"))
        Else
            oDv.RowFilter = Nothing
        End If
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        cargarRegistros()
    End Sub
End Class