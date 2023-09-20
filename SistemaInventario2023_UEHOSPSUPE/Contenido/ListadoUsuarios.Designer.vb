<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SeparatorUsuario = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelContendio = New System.Windows.Forms.Panel()
        Me.navUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContendio.SuspendLayout()
        Me.SuspendLayout()
        '
        'SeparatorUsuario
        '
        Me.SeparatorUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.SeparatorUsuario.Location = New System.Drawing.Point(18, 50)
        Me.SeparatorUsuario.Name = "SeparatorUsuario"
        Me.SeparatorUsuario.Size = New System.Drawing.Size(924, 11)
        Me.SeparatorUsuario.TabIndex = 1
        '
        'PanelContendio
        '
        Me.PanelContendio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContendio.Controls.Add(Me.ProgressBar)
        Me.PanelContendio.Location = New System.Drawing.Point(18, 77)
        Me.PanelContendio.Name = "PanelContendio"
        Me.PanelContendio.Size = New System.Drawing.Size(936, 435)
        Me.PanelContendio.TabIndex = 2
        '
        'navUsuario
        '
        Me.navUsuario.Animated = True
        Me.navUsuario.BackColor = System.Drawing.Color.White
        Me.navUsuario.BorderRadius = 8
        Me.navUsuario.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.navUsuario.Checked = True
        Me.navUsuario.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.navUsuario.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.navUsuario.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.navUsuario.DisabledState.BorderColor = System.Drawing.Color.White
        Me.navUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.White
        Me.navUsuario.DisabledState.FillColor = System.Drawing.Color.White
        Me.navUsuario.DisabledState.ForeColor = System.Drawing.Color.White
        Me.navUsuario.FillColor = System.Drawing.Color.White
        Me.navUsuario.FocusedColor = System.Drawing.Color.White
        Me.navUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.navUsuario.ForeColor = System.Drawing.Color.Black
        Me.navUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navUsuario.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navUsuario.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navUsuario.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.navUsuario.Location = New System.Drawing.Point(18, 16)
        Me.navUsuario.Name = "navUsuario"
        Me.navUsuario.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navUsuario.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navUsuario.Size = New System.Drawing.Size(116, 36)
        Me.navUsuario.TabIndex = 208
        Me.navUsuario.Text = "Usuarios"
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
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'ListadoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 543)
        Me.Controls.Add(Me.navUsuario)
        Me.Controls.Add(Me.PanelContendio)
        Me.Controls.Add(Me.SeparatorUsuario)
        Me.Name = "ListadoUsuarios"
        Me.Text = "ListadoUsuarios"
        Me.PanelContendio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SeparatorUsuario As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelContendio As Panel
    Friend WithEvents navUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer1 As Timer
End Class
