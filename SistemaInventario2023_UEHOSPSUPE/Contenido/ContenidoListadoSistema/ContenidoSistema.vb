Imports BussinessLayer
Imports SupportLayer

Public Class ContenidoSistema
    '-----------------------------------'
    'Objeto a partir de CArticuloBL'
    Dim oTipoSistemaBL As New C_SISTEMA_BL
    '------------------------------------'
    'Validar para recuperar el ID de la fila Seleccionada'
    Dim pId As String
    '------------------------------------'
    Dim oDv As New DataView
    '------------------------------------'
    Private Sub cargarRegistros()
        'pasar el datatable al dataview'
        oDv = oTipoSistemaBL.listarSistema().DefaultView
        dgvListadoSistema.DataSource = oDv
    End Sub
    Private Sub AgregarRegistro()
        Dim oFrm As New ModalSistema
        oFrm.lbTitulo.Text = "Agregar Datos de Sistema"
        oFrm.nuevo = True
        oFrm.dtpFechaReg.Value = Today()
        oFrm.CargarComboTiposSistema()
        oFrm.CargarComboEstado()
        '------------------------------------'
        oFrm.combosSelect()
        oFrm.ShowDialog()
        cargarRegistros()
        ContadorDatos()
    End Sub
    Private Sub ContadorDatos()
        Dim contador As DataRow = oTipoSistemaBL.Contador().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_SISTE"))
        labTotal.Text = "(" + DatoContador + ")"
    End Sub

    Private Sub editarRegistroSistema()
        If dgvListadoSistema.Rows.Count = 0 Then
            MessageBox.Show("No hay Registro", "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim oFrm As New ModalSistema
            oFrm.lbTitulo.Text = "Editar Datos de Sistema"
            oFrm.nuevo = False
            pId = dgvListadoSistema.Rows(dgvListadoSistema.CurrentRow.Index).Cells(0).Value
            Dim oDr As DataRow = oTipoSistemaBL.SeleccionarxSistemaID(pId).Rows(0)
            oFrm.txtId_Sistema.Text = oDr("ID_SISTE")
            oFrm.txtIp.Text = oDr("IP_SISTE")
            oFrm.txtNombreEquipo.Text = oDr("NOMB_SISTE")
            oFrm.txtGrupoTrabajo.Text = oDr("GRUPO_SISTE")
            oFrm.txtOffice.Text = oDr("OFFICE_SISTE")
            oFrm.txtSistAplica.Text = oDr("SISTEMA_SISTE")
            oFrm.dtpFechaReg.Value = oDr("FECHA_REG_SISTE")
            '-----------------------------------------------------------
            oFrm.CargarComboTiposSistema()
            oFrm.CargarComboEstado()
            oFrm.cboTipSistema.SelectedValue = oDr("ID_TIP_SISTE")
            oFrm.cboEstado.SelectedValue = oDr("ID_ESTADO")
            '-----------------------------------------------------------
            oFrm.txtUsuario.Text = oDr("ID_USUARIO")
            '-----------------------------------------------------------
            oFrm.ShowDialog()
            cargarRegistros()
            ContadorDatos()
        End If
    End Sub

    Sub eliminarRegistroSistema()
        If dgvListadoSistema.Rows.Count = 0 Then
            MessageBox.Show("No hay Registro", "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Dim result As DialogResult
        result = MessageBox.Show("¿Seguro de Eliminar el Registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            pId = dgvListadoSistema.Rows(dgvListadoSistema.CurrentRow.Index).Cells(0).Value
            Dim msg As String = ""
            msg = oTipoSistemaBL.Eliminar(pId)
            cargarRegistros()
            ContadorDatos()
            MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub realizarBusquedadSistema()
        'evaluar la opcion'
        Select Case cboOpcionEquipo.SelectedIndex
            Case 0
                oDv.RowFilter = String.Format("DESC_SISTE LIKE '%{0}%'", txtBuscarSistema.Text)
            Case 1
                oDv.RowFilter = String.Format("IP_SISTE LIKE '%{0}%'", txtBuscarSistema.Text)
            Case 2
                oDv.RowFilter = String.Format("NOMB_SISTE LIKE '%{0}%'", txtBuscarSistema.Text)
            Case 3
                oDv.RowFilter = String.Format("GRUPO_SISTE LIKE '%{0}%'", txtBuscarSistema.Text)
            Case 4
                oDv.RowFilter = String.Format("OFFICE_SISTE LIKE '%{0}%'", txtBuscarSistema.Text)
            Case 5
                oDv.RowFilter = String.Format("SISTEMA_SISTE LIKE '%{0}%'", txtBuscarSistema.Text)
            Case 6
                oDv.RowFilter = String.Format("DESC_ESTADO LIKE '%{0}%'", txtBuscarSistema.Text)

        End Select
    End Sub
    Private Sub ContenidoSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros()
        ContadorDatos()
        'obsion del combobox
        cargarComboSelected()
        '------------------------
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
        cboOpcionEquipo.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarRegistro()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarRegistroSistema()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarRegistroSistema()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim oFrm1 As New PanelReporteVistaPrevia
        oFrm1.lbTitulo.Text = "Reporte Sistema"
        nReporte = 4
        PanelReporteVistaPrevia.ShowDialog()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        txtBuscarSistema.Text = ""
    End Sub

    Private Sub txtBuscarSistema_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarSistema.TextChanged
        If txtBuscarSistema.TextLength > 0 Then
            realizarBusquedadSistema()
        Else
            oDv.RowFilter = Nothing
        End If

    End Sub

    Private Sub btnFiltarFecha_Click(sender As Object, e As EventArgs) Handles btnFiltarFecha.Click
        If dtpFecha.TextRenderingHint > 0 Then
            oDv.RowFilter = String.Format("CONVERT(FECHA_REG_SISTE, System.String) LIKE '%{0}%'", dtpFecha.Value.ToString("dd/MM/yyyy"))
        Else
            oDv.RowFilter = Nothing
        End If
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        cargarRegistros()
    End Sub
End Class