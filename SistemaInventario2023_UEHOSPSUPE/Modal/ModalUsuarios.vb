Imports BussinessLayer
Imports EntityLayer

Public Class ModalUsuarios
    '-----------------------------------------------'
    'crar objeto para llamar a las clases bussiLayer Y EntytiLayer'
    Dim oTipUsuarioBL As New C_USUARIO_BL
    Dim oTipUsduarioEL As New CUsuarioEL
    '-------------------------------'
    'validar para Conocer si es un nuevo registro o una actualizacion'
    Public nuevo As Boolean = False

    Private Function ValidarCampos() As Boolean

        If txtApellido.Text = "" Then
            MessageBox.Show("Ingrese su Apellido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtApellido.Focus()
            Return False
        End If
        If txtNombre.Text = "" Then
            MessageBox.Show("Ingrese su Nombre", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.BorderColor = Color.FromArgb(217, 83, 79)
            txtNombre.Focus()
            Return False
        End If
        If txtCorreo.Text = "" Then
            MessageBox.Show("Ingrese su Correo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCorreo.BorderColor = Color.FromArgb(217, 83, 79)
            txtCorreo.Focus()
            Return False
        End If
        If txtContraseña.Text = "" Then
            MessageBox.Show("Ingrese su Contraseña", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContraseña.BorderColor = Color.FromArgb(217, 83, 79)
            txtContraseña.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarCambios()
        If ValidarCampos() Then
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Seguro de Guardar los cambios?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = DialogResult.Yes Then
                oTipUsduarioEL = New CUsuarioEL
                oTipUsduarioEL.NOMB_USU1 = txtNombre.Text
                oTipUsduarioEL.APELL_USU1 = txtApellido.Text
                oTipUsduarioEL.CORREO_USU1 = txtCorreo.Text
                oTipUsduarioEL.PASS_USU1 = txtContraseña.Text
                oTipUsduarioEL.FECHA_REC_USU1 = dtpFechaReg.Value
                '-----------------------------------------------------------
                oTipUsduarioEL.ACCESO_USU1 = CboAcceso.Text

                'Evaluar segun la accion inserta y actualizar'
                Dim msg As String = ""
                If nuevo Then
                    'Insertar: enviar los datos y recepcionar la repuesta'
                    msg = oTipUsuarioBL.Insertar(oTipUsduarioEL)
                Else
                    'ACTUALIZAR'
                    oTipUsduarioEL.ID_USUARIO1 = txtIdUsuario.Text
                    msg = oTipUsuarioBL.Editar(oTipUsduarioEL)
                End If
                MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub ModalUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub combosSelect()
        CboAcceso.SelectedIndex = 0
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