<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoEquipo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.navEquipo = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelContendio = New System.Windows.Forms.Panel()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.SeparatorUsuario = New Guna.UI2.WinForms.Guna2Separator()
        Me.navDescripEqui = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeshabilitado = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContendio.SuspendLayout()
        Me.SuspendLayout()
        '
        'navEquipo
        '
        Me.navEquipo.Animated = True
        Me.navEquipo.BackColor = System.Drawing.Color.White
        Me.navEquipo.BorderRadius = 8
        Me.navEquipo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.navEquipo.Checked = True
        Me.navEquipo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.navEquipo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.navEquipo.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.navEquipo.DisabledState.BorderColor = System.Drawing.Color.White
        Me.navEquipo.DisabledState.CustomBorderColor = System.Drawing.Color.White
        Me.navEquipo.DisabledState.FillColor = System.Drawing.Color.White
        Me.navEquipo.DisabledState.ForeColor = System.Drawing.Color.White
        Me.navEquipo.FillColor = System.Drawing.Color.White
        Me.navEquipo.FocusedColor = System.Drawing.Color.White
        Me.navEquipo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.navEquipo.ForeColor = System.Drawing.Color.Black
        Me.navEquipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navEquipo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navEquipo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navEquipo.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.navEquipo.Location = New System.Drawing.Point(18, 23)
        Me.navEquipo.Name = "navEquipo"
        Me.navEquipo.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navEquipo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navEquipo.Size = New System.Drawing.Size(116, 36)
        Me.navEquipo.TabIndex = 211
        Me.navEquipo.Text = "Equipos"
        '
        'PanelContendio
        '
        Me.PanelContendio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContendio.Controls.Add(Me.ProgressBar)
        Me.PanelContendio.Location = New System.Drawing.Point(18, 84)
        Me.PanelContendio.Name = "PanelContendio"
        Me.PanelContendio.Size = New System.Drawing.Size(936, 435)
        Me.PanelContendio.TabIndex = 210
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar.Animated = True
        Me.ProgressBar.FillColor = System.Drawing.Color.White
        Me.ProgressBar.FillThickness = 12
        Me.ProgressBar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ProgressBar.ForeColor = System.Drawing.Color.White
        Me.ProgressBar.Location = New System.Drawing.Point(428, 152)
        Me.ProgressBar.Minimum = 0
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar.ProgressThickness = 12
        Me.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProgressBar.Size = New System.Drawing.Size(81, 81)
        Me.ProgressBar.TabIndex = 17
        Me.ProgressBar.Text = "Guna2CircleProgressBar1"
        Me.ProgressBar.Value = 20
        '
        'SeparatorUsuario
        '
        Me.SeparatorUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.SeparatorUsuario.Location = New System.Drawing.Point(18, 57)
        Me.SeparatorUsuario.Name = "SeparatorUsuario"
        Me.SeparatorUsuario.Size = New System.Drawing.Size(924, 11)
        Me.SeparatorUsuario.TabIndex = 209
        '
        'navDescripEqui
        '
        Me.navDescripEqui.Animated = True
        Me.navDescripEqui.BackColor = System.Drawing.Color.White
        Me.navDescripEqui.BorderRadius = 8
        Me.navDescripEqui.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.navDescripEqui.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.navDescripEqui.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.navDescripEqui.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.navDescripEqui.DisabledState.BorderColor = System.Drawing.Color.White
        Me.navDescripEqui.DisabledState.CustomBorderColor = System.Drawing.Color.White
        Me.navDescripEqui.DisabledState.FillColor = System.Drawing.Color.White
        Me.navDescripEqui.DisabledState.ForeColor = System.Drawing.Color.White
        Me.navDescripEqui.FillColor = System.Drawing.Color.White
        Me.navDescripEqui.FocusedColor = System.Drawing.Color.White
        Me.navDescripEqui.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.navDescripEqui.ForeColor = System.Drawing.Color.Black
        Me.navDescripEqui.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navDescripEqui.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navDescripEqui.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navDescripEqui.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.navDescripEqui.Location = New System.Drawing.Point(140, 23)
        Me.navDescripEqui.Name = "navDescripEqui"
        Me.navDescripEqui.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navDescripEqui.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navDescripEqui.Size = New System.Drawing.Size(158, 36)
        Me.navDescripEqui.TabIndex = 212
        Me.navDescripEqui.Text = "Descripción de Equipos"
        '
        'btnDeshabilitado
        '
        Me.btnDeshabilitado.Animated = True
        Me.btnDeshabilitado.BackColor = System.Drawing.Color.White
        Me.btnDeshabilitado.BorderRadius = 8
        Me.btnDeshabilitado.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnDeshabilitado.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDeshabilitado.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDeshabilitado.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnDeshabilitado.DisabledState.BorderColor = System.Drawing.Color.White
        Me.btnDeshabilitado.DisabledState.CustomBorderColor = System.Drawing.Color.White
        Me.btnDeshabilitado.DisabledState.FillColor = System.Drawing.Color.White
        Me.btnDeshabilitado.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnDeshabilitado.FillColor = System.Drawing.Color.White
        Me.btnDeshabilitado.FocusedColor = System.Drawing.Color.White
        Me.btnDeshabilitado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDeshabilitado.ForeColor = System.Drawing.Color.Black
        Me.btnDeshabilitado.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeshabilitado.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeshabilitado.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeshabilitado.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnDeshabilitado.Location = New System.Drawing.Point(304, 23)
        Me.btnDeshabilitado.Name = "btnDeshabilitado"
        Me.btnDeshabilitado.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeshabilitado.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeshabilitado.Size = New System.Drawing.Size(154, 36)
        Me.btnDeshabilitado.TabIndex = 213
        Me.btnDeshabilitado.Text = "Equipos Deshabilitado "
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'ListadoEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 543)
        Me.Controls.Add(Me.btnDeshabilitado)
        Me.Controls.Add(Me.navDescripEqui)
        Me.Controls.Add(Me.navEquipo)
        Me.Controls.Add(Me.PanelContendio)
        Me.Controls.Add(Me.SeparatorUsuario)
        Me.Name = "ListadoEquipo"
        Me.Text = "ListadoEquipo"
        Me.PanelContendio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navEquipo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelContendio As Panel
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents SeparatorUsuario As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents navDescripEqui As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeshabilitado As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
