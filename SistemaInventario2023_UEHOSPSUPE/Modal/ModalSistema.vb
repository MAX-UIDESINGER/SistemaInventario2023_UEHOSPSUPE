Imports BussinessLayer
Imports EntityLayer
Imports SupportLayer

Public Class ModalSistema
    'Validar el cabo para los combobox'
    Dim oTiposSistemaBL As New CTiposSistemaBL
    Dim oEstadoBL As New CEstadoBL
    '-----------------------------------------------'
    'crar objeto para llamar a las clases bussiLayer Y EntytiLayer'
    Dim oTipSistemaBL As New C_SISTEMA_BL
    Dim oTipSistemaEL As New CSistemaEL
    '-------------------------------'
    'validar para Conocer si es un nuevo registro o una actualizacion'
    Public nuevo As Boolean = False
    Public Sub CargarComboTiposSistema()
        cboTipSistema.DataSource = oTiposSistemaBL.ListarTiposSistema
        cboTipSistema.DisplayMember = "DESC_SISTE"
        cboTipSistema.ValueMember = "ID_TIP_SISTE"
        cboTipSistema.SelectedIndex = -1
    End Sub

    Public Sub CargarComboEstado()
        cboEstado.DataSource = oEstadoBL.ListarEstado
        cboEstado.DisplayMember = "DESC_ESTADO"
        cboEstado.ValueMember = "ID_ESTADO"
        cboEstado.SelectedIndex = -1
    End Sub

    Private Function ValidarCampos() As Boolean
        If cboTipSistema.SelectedIndex = -1 Then
            MessageBox.Show("Seleccionar su Sistema Operativo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboTipSistema.Focus()
            Return False
        End If
        If txtIp.Text = "" Then
            MessageBox.Show("Ingrese su Ip", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtIp.Focus()
            Return False
        End If
        If txtNombreEquipo.Text = "" Then
            MessageBox.Show("Ingrese su Nombre de Equipo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombreEquipo.BorderColor = Color.FromArgb(217, 83, 79)
            txtNombreEquipo.Focus()
            Return False
        End If
        If txtGrupoTrabajo.Text = "" Then
            MessageBox.Show("Ingrese su Trabajo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGrupoTrabajo.BorderColor = Color.FromArgb(217, 83, 79)
            txtGrupoTrabajo.Focus()
            Return False
        End If
        If txtOffice.Text = "" Then
            MessageBox.Show("Ingrese su Office", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtOffice.BorderColor = Color.FromArgb(217, 83, 79)
            txtOffice.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarCambios()
        If ValidarCampos() Then
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Seguro de Guardar los cambios?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = DialogResult.Yes Then
                oTipSistemaEL = New CSistemaEL
                oTipSistemaEL.IP_SISTE1 = txtIp.Text
                oTipSistemaEL.NOMB_SISTE1 = txtNombreEquipo.Text
                oTipSistemaEL.GRUPO_SISTE1 = txtGrupoTrabajo.Text
                oTipSistemaEL.OFFICE_SISTE1 = txtOffice.Text
                oTipSistemaEL.SISTEMA_SISTE1 = txtSistAplica.Text
                oTipSistemaEL.FECHA_REG_SISTE1 = dtpFechaReg.Value
                '-----------------------------------------------------------
                oTipSistemaEL.ID_ESTADO1 = cboEstado.SelectedValue
                oTipSistemaEL.ID_TIP_SISTE1 = cboTipSistema.SelectedValue
                '-----------------------------------------------------------
                oTipSistemaEL.ID_USUARIO1 = txtUsuario.Text
                'Evaluar segun la accion inserta y actualizar'
                Dim msg As String = ""
                If nuevo Then
                    'Insertar: enviar los datos y recepcionar la repuesta'
                    msg = oTipSistemaBL.Insertar(oTipSistemaEL)
                Else
                    'ACTUALIZAR'
                    oTipSistemaEL.ID_SISTE1 = txtId_Sistema.Text
                    msg = oTipSistemaBL.Editar(oTipSistemaEL)
                End If
                MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub ModalSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistroUsuario()
    End Sub

    Private Sub cargarRegistroUsuario()
        txtUsuario.Text = UsuarioDatos.idUsuario
    End Sub

    Public Sub combosSelect()
        cboTipSistema.SelectedIndex = 8
        cboEstado.SelectedIndex = 1
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
End Class