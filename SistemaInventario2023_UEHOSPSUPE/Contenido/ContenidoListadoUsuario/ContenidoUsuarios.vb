Imports BussinessLayer

Public Class ContenidoUsuarios
    '-----------------------------------'
    'Objeto a partir de CArticuloBL'
    Dim oTipoUsuarioBL As New C_USUARIO_BL
    '------------------------------------'
    'Validar para recuperar el ID de la fila Seleccionada'
    Dim pId As String
    '------------------------------------'
    Dim oDv As New DataView
    '------------------------------------'
    Private Sub cargarRegistros()
        'pasar el datatable al dataview'
        oDv = oTipoUsuarioBL.ListarUsuario().DefaultView
        dgvListadoUsuario.DataSource = oDv
    End Sub

    Private Sub AgregarRegistro()
        Dim oFrm As New ModalUsuarios
        oFrm.lbTitulo.Text = "Agregar Datos de Usuario"
        oFrm.nuevo = True
        oFrm.dtpFechaReg.Value = Today()
        '------------------------------------'
        oFrm.combosSelect()
        oFrm.ShowDialog()
        cargarRegistros()
        ContadorDatos()
    End Sub

    Private Sub ContadorDatos()
        Dim contador As DataRow = oTipoUsuarioBL.contador().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_USUARIO"))
        labTotal.Text = "(" + DatoContador + ")"
    End Sub
    Private Sub editarRegistroEquipo()
        If dgvListadoUsuario.Rows.Count = 0 Then
            MessageBox.Show("No hay Registro", "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim oFrm As New ModalUsuarios
            oFrm.lbTitulo.Text = "Editar Datos de Usuario"
            oFrm.nuevo = False
            pId = dgvListadoUsuario.Rows(dgvListadoUsuario.CurrentRow.Index).Cells(0).Value
            Dim oDr As DataRow = oTipoUsuarioBL.SeleccionarxID(pId).Rows(0)
            oFrm.txtIdUsuario.Text = oDr("ID_USUARIO")
            oFrm.txtNombre.Text = oDr("NOMB_USU")
            oFrm.txtApellido.Text = oDr("APELL_USU")
            oFrm.txtCorreo.Text = oDr("CORREO_USU")
            oFrm.txtContraseña.Text = oDr("PASS_USU")
            oFrm.CboAcceso.Text = oDr("ACCESO_USU")
            oFrm.dtpFechaReg.Value = oDr("FECHA_REC_USU")
            oFrm.ShowDialog()
            cargarRegistros()
            ContadorDatos()
        End If
    End Sub

    Sub eliminarRegistroEquipo()
        If dgvListadoUsuario.Rows.Count = 0 Then
            MessageBox.Show("No hay Registro", "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Dim result As DialogResult
        result = MessageBox.Show("¿Seguro de Eliminar el Registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            pId = dgvListadoUsuario.Rows(dgvListadoUsuario.CurrentRow.Index).Cells(0).Value
            Dim msg As String = ""
            msg = oTipoUsuarioBL.Eliminar(pId)
            cargarRegistros()
            ContadorDatos()
            MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub realizarBusquedadEquipo()
        'evaluar la opcion'
        Select Case cboOpcionEquipo.SelectedIndex
            Case 0
                oDv.RowFilter = String.Format("NOMB_USU LIKE '%{0}%'", txtBuscarUsuario.Text)
            Case 1
                oDv.RowFilter = String.Format("APELL_USU LIKE '%{0}%'", txtBuscarUsuario.Text)
            Case 2
                oDv.RowFilter = String.Format("CORREO_USU LIKE '%{0}%'", txtBuscarUsuario.Text)
            Case 3
                oDv.RowFilter = String.Format("PASS_USU LIKE '%{0}%'", txtBuscarUsuario.Text)
            Case 4
                oDv.RowFilter = String.Format("ACCESO_USU LIKE '%{0}%'", txtBuscarUsuario.Text)
        End Select
    End Sub
    Private Sub ContenidoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros()
        ContadorDatos()
        'obsion del combobox
        cargarComboSelected()
    End Sub
    Private Sub cargarComboSelected()
        dtpFecha.Value = Today()
        cboOpcionEquipo.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarRegistro()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarRegistroEquipo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarRegistroEquipo()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim oFrm1 As New PanelReporteVistaPrevia
        oFrm1.lbTitulo.Text = "Reporte Usuario"
        nReporte = 5
        PanelReporteVistaPrevia.ShowDialog()

    End Sub

    Private Sub btnLimpiarBuscar_Click(sender As Object, e As EventArgs) Handles btnLimpiarBuscar.Click
        txtBuscarUsuario.Text = ""
    End Sub

    Private Sub txtBuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarUsuario.TextChanged
        If txtBuscarUsuario.TextLength > 0 Then
            realizarBusquedadEquipo()
        Else
            oDv.RowFilter = Nothing
        End If
    End Sub

    Private Sub btnFiltarFecha_Click(sender As Object, e As EventArgs) Handles btnFiltarFecha.Click
        If dtpFecha.TextRenderingHint > 0 Then
            oDv.RowFilter = String.Format("CONVERT(FECHA_REC_USU, System.String) LIKE '%{0}%'", dtpFecha.Value.ToString("dd/MM/yyyy"))
        Else
            oDv.RowFilter = Nothing
        End If
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        cargarRegistros()
    End Sub
End Class