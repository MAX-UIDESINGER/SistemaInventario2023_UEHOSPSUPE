<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoTotalHarware
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
        Me.navHardware = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelContendio = New System.Windows.Forms.Panel()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.SeparatorUsuario = New Guna.UI2.WinForms.Guna2Separator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContendio.SuspendLayout()
        Me.SuspendLayout()
        '
        'navHardware
        '
        Me.navHardware.Animated = True
        Me.navHardware.BackColor = System.Drawing.Color.White
        Me.navHardware.BorderRadius = 8
        Me.navHardware.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.navHardware.Checked = True
        Me.navHardware.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.navHardware.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.navHardware.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.navHardware.DisabledState.BorderColor = System.Drawing.Color.White
        Me.navHardware.DisabledState.CustomBorderColor = System.Drawing.Color.White
        Me.navHardware.DisabledState.FillColor = System.Drawing.Color.White
        Me.navHardware.DisabledState.ForeColor = System.Drawing.Color.White
        Me.navHardware.FillColor = System.Drawing.Color.White
        Me.navHardware.FocusedColor = System.Drawing.Color.White
        Me.navHardware.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.navHardware.ForeColor = System.Drawing.Color.Black
        Me.navHardware.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navHardware.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navHardware.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navHardware.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.navHardware.Location = New System.Drawing.Point(18, 23)
        Me.navHardware.Name = "navHardware"
        Me.navHardware.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navHardware.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.navHardware.Size = New System.Drawing.Size(116, 36)
        Me.navHardware.TabIndex = 219
        Me.navHardware.Text = "Hardware"
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
        Me.PanelContendio.TabIndex = 218
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
        Me.SeparatorUsuario.TabIndex = 217
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'ListadoTotalHarware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 543)
        Me.Controls.Add(Me.navHardware)
        Me.Controls.Add(Me.PanelContendio)
        Me.Controls.Add(Me.SeparatorUsuario)
        Me.Name = "ListadoTotalHarware"
        Me.Text = "ListadoTotalHarware"
        Me.PanelContendio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navHardware As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelContendio As Panel
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents SeparatorUsuario As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Timer1 As Timer
End Class
