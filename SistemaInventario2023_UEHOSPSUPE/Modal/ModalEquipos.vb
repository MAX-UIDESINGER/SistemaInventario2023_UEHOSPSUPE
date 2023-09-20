Imports BussinessLayer
Imports EntityLayer
Imports SupportLayer

Public Class ModalEquipos
    'Validar el cabo para los combobox'
    Dim oTiposEquiposBL As New CTiposEquiposBL
    Dim oAreasBL As New CAreasBL
    Dim oUbicacionBL As New CUbicacionBL
    Dim oEstadoBL As New CEstadoBL
    '-----------------------------------------------'
    'crar objeto para llamar a las clases bussiLayer Y EntytiLayer'
    Dim oTipEquiposBL As New C_EQUIPO_BL
    Dim oTipEquiposEL As New CEquipoEL
    '-------------------------------'
    'validar para Conocer si es un nuevo registro o una actualizacion'
    Public nuevo As Boolean = False

    Public Sub CargarComboTiposEquipos()
        cboTipEquipos.DataSource = oTiposEquiposBL.ListarTiposEquipos
        cboTipEquipos.DisplayMember = "DESC_EQUI"
        cboTipEquipos.ValueMember = "ID_TIP_EQUI"
        cboTipEquipos.SelectedIndex = -1
    End Sub

    Public Sub CargarComboAreas()
        cboArea.DataSource = oAreasBL.ListarAreas
        cboArea.DisplayMember = "NOMB_AREA"
        cboArea.ValueMember = "ID_AREA"
        cboArea.SelectedIndex = -1
    End Sub

    Public Sub CargarComboUbicacion()
        CboUbicacion.DataSource = oUbicacionBL.ListarUbicacion
        CboUbicacion.DisplayMember = "NOMB_UBIC"
        CboUbicacion.ValueMember = "ID_UBIC"
        CboUbicacion.SelectedIndex = -1
    End Sub
    Public Sub CargarComboEstado()
        cboEstado.DataSource = oEstadoBL.ListarEstado
        cboEstado.DisplayMember = "DESC_ESTADO"
        cboEstado.ValueMember = "ID_ESTADO"
        cboEstado.SelectedIndex = -1
    End Sub


    Private Function ValidarCampos() As Boolean
        If cboTipEquipos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccionar su Tipo de Equipo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboTipEquipos.Focus()
            Return False
        End If
        If txtCodigoPatri.Text = "" Then
            MessageBox.Show("Ingrese su Codigo Patrimonial", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodigoPatri.Focus()
            Return False
        End If
        If txtMarca.Text = "" Then
            MessageBox.Show("Ingrese su Marca", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMarca.BorderColor = Color.FromArgb(217, 83, 79)
            txtMarca.Focus()
            Return False
        End If
        If txtColor.Text = "" Then
            MessageBox.Show("Ingrese su Color", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtColor.BorderColor = Color.FromArgb(217, 83, 79)
            txtColor.Focus()
            Return False
        End If
        If txtModelo.Text = "" Then
            MessageBox.Show("Ingrese su Modelo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtModelo.BorderColor = Color.FromArgb(217, 83, 79)
            txtModelo.Focus()
            Return False
        End If
        If txtSeries.Text = "" Then
            MessageBox.Show("Ingrese su Serie", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSeries.BorderColor = Color.FromArgb(217, 83, 79)
            txtSeries.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GuardarCambios()
        If ValidarCampos() Then
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Seguro de Guardar los cambios?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = DialogResult.Yes Then
                oTipEquiposEL = New CEquipoEL
                oTipEquiposEL.COD_PAT_EQUI1 = txtCodigoPatri.Text
                oTipEquiposEL.MARCA_EQUI1 = txtMarca.Text
                oTipEquiposEL.MODELO_EQUI1 = txtModelo.Text
                oTipEquiposEL.COLOR_EQUI1 = txtColor.Text
                oTipEquiposEL.SERIE_EQUI1 = txtSeries.Text
                oTipEquiposEL.PLACA_EQUI1 = txtPlacaMadre.Text
                oTipEquiposEL.PROC_EQUI1 = txtProcesador.Text
                oTipEquiposEL.RAM_EQUI1 = txtMemoriaRam.Text
                oTipEquiposEL.DISCO_EQUI1 = txtDisco.Text
                oTipEquiposEL.TAR_VID_EQUI1 = txttargevideo.Text
                oTipEquiposEL.TAR_RED_EQUI1 = txttargRed.Text
                oTipEquiposEL.PILA_EQUI1 = txtPila.Text
                oTipEquiposEL.FUNTE_ALIME_EQUI1 = txtFuentePoder.Text
                oTipEquiposEL.FECHA_REG_EQUI1 = dtpFechaReg.Value
                oTipEquiposEL.ID_ESTADO1 = cboEstado.SelectedValue
                '-----------------------------------------------------------
                oTipEquiposEL.TONER_EQUI1 = txtToner.Text
                oTipEquiposEL.TINTA_EQUI1 = txtTinta.Text
                oTipEquiposEL.OTRO_EQUI1 = txtOtros.Text
                '-----------------------------------------------------------
                oTipEquiposEL.ID_TIP_EQUI1 = cboTipEquipos.SelectedValue
                oTipEquiposEL.ID_AREA1 = cboArea.SelectedValue
                oTipEquiposEL.ID_UBIC1 = CboUbicacion.SelectedValue
                '-----------------------------------------------------------
                oTipEquiposEL.ACTIVIDA_EQUI1 = cboActivida.Text
                oTipEquiposEL.DESCRIP_EQUI1 = txtDescripcion.Text
                oTipEquiposEL.ID_UBIC1 = CboUbicacion.SelectedValue
                '-----------------------------------------------------------
                oTipEquiposEL.ID_USUARIO1 = txtUsuario.Text

                'Evaluar segun la accion inserta y actualizar'
                Dim msg As String = ""
                If nuevo Then
                    'Insertar: enviar los datos y recepcionar la repuesta'
                    msg = oTipEquiposBL.Insertar(oTipEquiposEL)
                Else
                    'ACTUALIZAR'
                    oTipEquiposEL.ID_EQUI1 = txtIdequipo.Text
                    msg = oTipEquiposBL.Editar(oTipEquiposEL)
                End If
                MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub
    Private Sub ModalEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistroUsuario()
    End Sub
    Private Sub cargarRegistroUsuario()
        txtUsuario.Text = UsuarioDatos.idUsuario
    End Sub
    Public Sub combosSelect()
        cboTipEquipos.SelectedIndex = 0
        cboArea.SelectedIndex = 0
        cboActivida.SelectedIndex = 0
        cboEstado.SelectedIndex = 1
        CboUbicacion.SelectedIndex = 0
        cboActivida.SelectedIndex = 0
        dtpFechaReg.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarCambios()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Seguro de Cerrar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCodigoPatri_Enter(sender As Object, e As EventArgs) Handles txtCodigoPatri.Enter
        If txtCodigoPatri.Text = "S/C" Then
            txtCodigoPatri.Text = ""
            txtCodigoPatri.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCodigoPatri_Leave(sender As Object, e As EventArgs) Handles txtCodigoPatri.Leave
        If txtCodigoPatri.Text = "" Then
            txtCodigoPatri.Text = "S/C"
            txtCodigoPatri.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDescripcion_Enter(sender As Object, e As EventArgs) Handles txtDescripcion.Enter
        If txtDescripcion.Text = "¡Explicacion!" Then
            txtDescripcion.Text = ""
            txtDescripcion.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDescripcion_Leave(sender As Object, e As EventArgs) Handles txtDescripcion.Leave
        If txtDescripcion.Text = "" Then
            txtDescripcion.Text = "¡Explicacion!"
            txtDescripcion.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cboTipEquipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipEquipos.SelectedIndexChanged
        realizarFiltradiTiposEquipos()
    End Sub
    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        realizarFiltradoEstado()
    End Sub
    Private Sub cboActivida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActivida.SelectedIndexChanged
        realizarFiltradoActividad()
    End Sub

    Private Sub realizarFiltradiTiposEquipos()
        Dim SUbmenu As String
        SUbmenu = cboTipEquipos.SelectedIndex
        If SUbmenu = 0 Then
            showSubmenuPC()
        ElseIf SUbmenu = 1 Then
            hideSubtextoLAPTOP()
        ElseIf SUbmenu = 2 Then
            showSubmenuPC()
            '--------------------------------
        ElseIf SUbmenu = 3 Then
            hideSubtextoComponentes()
        ElseIf SUbmenu = 4 Then
            hideSubtextoComponentes()
        ElseIf SUbmenu = 5 Then
            hideSubtextoComponentes()
        ElseIf SUbmenu = 6 Then
            hideSubtextoComponentes()
        ElseIf SUbmenu = 7 Then
            hideSubtextoImpresora()
        End If
    End Sub

    Private Sub hideSubtextoLAPTOP()
        PanelProcesador.Visible = True
        PanelDisco.Visible = True
        PanelMemoriaRam.Visible = True
        PanelPlacaMadre.Visible = True
        '--------------------------------
        'PC

        PanelFuentePoder.Visible = False
        PanelTargetaVideo.Visible = False
        PanelTargetaRed.Visible = False
        PanelPila.Visible = False

        '--------------------------------
        'impresora

        PanelToner.Visible = False
        PanelTinta.Visible = False
        PanelOtros.Visible = False
        '----------------------------------
    End Sub

    Private Sub showSubmenuPC()
        '--------------------------------
        'Laptop

        PanelProcesador.Visible = True
        PanelDisco.Visible = True
        PanelMemoriaRam.Visible = True
        PanelPlacaMadre.Visible = True

        '--------------------------------
        'PC

        PanelFuentePoder.Visible = True
        PanelTargetaVideo.Visible = True
        PanelTargetaRed.Visible = True
        PanelPila.Visible = True

        '--------------------------------
        'impresora

        PanelToner.Visible = False
        PanelTinta.Visible = False
        PanelOtros.Visible = False
        '----------------------------------

    End Sub

    Private Sub hideSubtextoImpresora()
        '--------------------------------
        'Laptop

        PanelProcesador.Visible = False
        PanelDisco.Visible = False
        PanelMemoriaRam.Visible = False
        PanelPlacaMadre.Visible = False
        '--------------------------------
        'PC

        PanelFuentePoder.Visible = False
        PanelTargetaVideo.Visible = False
        PanelTargetaRed.Visible = False
        PanelPila.Visible = False

        '--------------------------------
        'impresora

        PanelToner.Visible = True
        PanelTinta.Visible = True
        PanelOtros.Visible = True
        '----------------------------------
    End Sub

    Private Sub hideSubtextoComponentes()

        '--------------------------------
        'Laptop

        PanelProcesador.Visible = False
        PanelDisco.Visible = False
        PanelMemoriaRam.Visible = False
        PanelPlacaMadre.Visible = False
        '--------------------------------
        'PC

        PanelFuentePoder.Visible = False
        PanelTargetaVideo.Visible = False
        PanelTargetaRed.Visible = False
        PanelPila.Visible = False

        '--------------------------------
        'impresora

        PanelToner.Visible = False
        PanelTinta.Visible = False
        PanelOtros.Visible = False
        '----------------------------------

    End Sub

    Private Sub realizarFiltradoEstado()
        Dim SUbmenuEstado As String
        SUbmenuEstado = cboEstado.SelectedIndex
        If SUbmenuEstado = 0 Then
            cboActivida.SelectedIndex = 0
            PanelContendio3.Visible = False
        ElseIf SUbmenuEstado = 1 Then
            cboActivida.SelectedIndex = 0
            PanelContendio3.Visible = False
        ElseIf SUbmenuEstado = 2 Then
            cboActivida.SelectedIndex = 1
            PanelContendio3.Visible = True
        End If
    End Sub

    Private Sub realizarFiltradoActividad()
        Select Case cboActivida.SelectedIndex
            Case 0
                cboEstado.SelectedIndex = 1
                txtDescripcion.Text = "-"
                PanelContendio3.Visible = False

            Case 1
                cboEstado.SelectedIndex = 2
                PanelContendio3.Visible = True
                txtDescripcion.Text = "¡Explicacion!"
        End Select
    End Sub
End Class