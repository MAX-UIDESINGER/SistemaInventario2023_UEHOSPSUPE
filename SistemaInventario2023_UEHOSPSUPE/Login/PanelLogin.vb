Imports BussinessLayer
Public Class PanelLogin
    Private currentChildForm As Form
    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelContedido.Controls.Add(childForm)
        panelContedido.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Sub validarCambiosTrabajor()
        Dim usuario As New C_USUARIO_BL()

        Dim validarLogin = usuario.LoginUsuario(txtCorreo.Text, txtContra.Text)

        If validarLogin = True Then
            OpenChildForm(New PanelPrincipal())
            If SwifRecuperar.Checked Then
                My.Settings.correo = txtCorreo.Text
                My.Settings.contrasena = txtContra.Text
                My.Settings.Save()
            Else
                txtCorreo.Text = "Correo Electrónico"
                txtContra.Text = "Contraseña"
                txtContra.UseSystemPasswordChar = False
            End If
        Else
            MessageBox.Show("Datos ingresados incorrectamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContra.Text = ""
            txtCorreo.Text = ""
            txtContra.Focus()
        End If
    End Sub
    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        validarCambiosTrabajor()
    End Sub

    Private Sub SwifRecuperar_CheckedChanged(sender As Object, e As EventArgs) Handles SwifRecuperar.CheckedChanged
        If SwifRecuperar.Checked Then
            My.Settings.correo = txtCorreo.Text
            My.Settings.contrasena = txtContra.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnOjo_Click(sender As Object, e As EventArgs) Handles btnOjo.Click
        If txtContra.UseSystemPasswordChar = True Then
            txtContra.UseSystemPasswordChar = False
        Else
            txtContra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtCorreo_Enter(sender As Object, e As EventArgs) Handles txtCorreo.Enter
        If txtCorreo.Text = "Correo Electrónico" Then
            txtCorreo.Text = ""
            txtCorreo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCorreo_Leave(sender As Object, e As EventArgs) Handles txtCorreo.Leave
        If txtCorreo.Text = "" Then
            txtCorreo.Text = "Correo Electrónico"
            txtCorreo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtContra_Enter(sender As Object, e As EventArgs) Handles txtContra.Enter
        If txtContra.Text = "Contraseña" Then
            txtContra.Text = ""
            txtContra.ForeColor = Color.Black
            txtContra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtContra_Leave(sender As Object, e As EventArgs) Handles txtContra.Leave
        If txtContra.Text = "" Then
            txtContra.Text = "Contraseña"
            txtContra.ForeColor = Color.Black
            txtContra.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub panelContedido_Paint(sender As Object, e As PaintEventArgs) Handles panelContedido.Paint

    End Sub
End Class