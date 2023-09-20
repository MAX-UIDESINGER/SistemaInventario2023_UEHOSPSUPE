Imports Guna.UI2.WinForms
Imports SupportLayer
Public Class PanelPrincipal

    Private currentChildForm As Form
    Public DIR As Integer
    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(childForm)
        PanelContenedor.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnEquipos_Click(sender As Object, e As EventArgs) Handles btnEquipos.Click
        Titulo_lab.Text = "Equipos"
        OpenChildForm(New ListadoEquipo())
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        Titulo_lab.Text = "Total de Datos"
        OpenChildForm(New ListadoTotalHarware())
    End Sub

    Private Sub btnSistema_Click(sender As Object, e As EventArgs) Handles btnSistema.Click
        Titulo_lab.Text = "Sistema"
        OpenChildForm(New ListadoSistemas())
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Titulo_lab.Text = "Usuario"
        OpenChildForm(New ListadoUsuarios())
    End Sub

    Private Sub PanelPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tiempo 
        ProgressBar.Value = 0
        Timer1.Start()
        '---------------------------------
        cargarRegistroUsuario()
        userMethods()
    End Sub
    Private Sub userMethods()
        If UsuarioDatos.Acceso = PrivilegiosUsuario.usuario Then
            btnUsuario.Visible = False
            LabelUsuario.Visible = False
            SeparatorUsuario.Visible = False
        End If
        If UsuarioDatos.Acceso = PrivilegiosUsuario.administrador Then
            btnUsuario.Visible = True
            LabelUsuario.Visible = True
            SeparatorUsuario.Visible = True
        End If
    End Sub
    Private Sub cargarRegistroUsuario()
        lbNombreUsuario.Text = UsuarioDatos.Nombre
        lbAcceso.Text = UsuarioDatos.Acceso
    End Sub

    Private Sub btn_Slider_Click(sender As Object, e As EventArgs) Handles btn_Slider.Click
        If PanelSlider.Width = 49 Then
            LabelHardware.Visible = True
            LabelSoftware.Visible = True
            LabelUsuario.Visible = True

            PanelSlider.Visible = False
            PanelSlider.Width = 196
            Guna2Transition1.ShowSync(PanelSlider)
        Else
            LabelHardware.Visible = False
            LabelSoftware.Visible = False
            LabelUsuario.Visible = False

            PanelSlider.Visible = False
            PanelSlider.Width = 49
            Guna2Transition2.ShowSync(PanelSlider)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)
        'conteo.Text = ProgressBar.ProgressPercentText
        If ProgressBar.Value = 80 Then
            DIR = -1 'reducir 
            ProgressBar.AnimationSpeed = 4
        ElseIf ProgressBar.Value = 20 Then
            DIR = +1 'expandir 
            ProgressBar.AnimationSpeed = 1
        End If
        ProgressBar.Value += DIR
        OpenChildForm(New ListadoEquipo)
        Timer1.[Stop]()
    End Sub

    Private Sub btnFiltarFecha_Click(sender As Object, e As EventArgs) Handles btnFiltarFecha.Click
        Dim oFrm As New PanelLogin
        Dim Result As DialogResult
        Result = MessageBox.Show("Quiere Cerrar Sesión", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Dim p_principal As New PanelPrincipal
            Me.Close()
        End If
    End Sub
End Class




