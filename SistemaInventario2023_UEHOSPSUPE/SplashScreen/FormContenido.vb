Imports BussinessLayer
Public Class FormContenido
    Dim usuario As New C_USUARIO_BL()
    '-----------------------------------
    Private currentChildForm As Form
    Private Sub FormContenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oFrm As New PanelLogin
        My.Settings.correo = oFrm.txtCorreo.Text
        My.Settings.contrasena = oFrm.txtContra.Text
        My.Settings.Save()
        'tiempo 
        ProgressBar.Value = 0
        Timer1.Start()
    End Sub
    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContendido01.Controls.Add(childForm)
        PanelContendido01.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim oFrm As New PanelLogin
        Dim validarLogin = usuario.LoginUsuario(My.Settings.correo = oFrm.txtCorreo.Text, My.Settings.contrasena = oFrm.txtContra.Text)
        If validarLogin = True Then
            OpenChildForm(New PanelPrincipal())
        Else
            ProgressBar.Increment(1)
            If ProgressBar.Value > 80 Then
                ProgressBar.AnimationSpeed = 20
                OpenChildForm(New PanelLogin())
                Timer1.[Stop]()
            End If
        End If

    End Sub
End Class