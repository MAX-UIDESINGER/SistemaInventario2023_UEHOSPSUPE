Public Class ListadoUsuarios
    Private currentChildForm As Form

    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContendio.Controls.Add(childForm)
        PanelContendio.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub ListadoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tiempo
        ProgressBar.Value = 0
        Timer1.Start()
    End Sub

    Private Sub navUsuario_Click(sender As Object, e As EventArgs) Handles navUsuario.Click
        OpenChildForm(New ContenidoUsuarios())
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)
        If ProgressBar.Value = 80 Then
            ProgressBar.AnimationSpeed = 20
            OpenChildForm(New ContenidoUsuarios)
            ProgressBar.Visible = False
            Timer1.[Stop]()
        End If
    End Sub
End Class