<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelLogin
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
        Me.btn_Iniciar = New Guna.UI2.WinForms.Guna2Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SwifRecuperar = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.panelContedido = New System.Windows.Forms.Panel()
        Me.btnOjo = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtContra = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelContedido.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Iniciar.BorderRadius = 20
        Me.btn_Iniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Iniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Iniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Iniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Iniciar.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn_Iniciar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Iniciar.ForeColor = System.Drawing.Color.White
        Me.btn_Iniciar.Location = New System.Drawing.Point(321, 389)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(355, 54)
        Me.btn_Iniciar.TabIndex = 0
        Me.btn_Iniciar.Text = "iniciar sesión"
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(369, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(258, 50)
        Me.label3.TabIndex = 2
        Me.label3.Text = " iniciar sesión"
        '
        'linkLabel1
        '
        Me.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.BackColor = System.Drawing.Color.White
        Me.linkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel1.ForeColor = System.Drawing.Color.Black
        Me.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel1.LinkColor = System.Drawing.Color.Black
        Me.linkLabel1.Location = New System.Drawing.Point(498, 314)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(178, 17)
        Me.linkLabel1.TabIndex = 14
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Has olvidado tu contraseña ?"
        Me.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(55, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(376, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Recuérdame"
        '
        'SwifRecuperar
        '
        Me.SwifRecuperar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SwifRecuperar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SwifRecuperar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SwifRecuperar.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwifRecuperar.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SwifRecuperar.Location = New System.Drawing.Point(335, 314)
        Me.SwifRecuperar.Name = "SwifRecuperar"
        Me.SwifRecuperar.Size = New System.Drawing.Size(35, 20)
        Me.SwifRecuperar.TabIndex = 22
        Me.SwifRecuperar.UncheckedState.BorderColor = System.Drawing.Color.DarkGray
        Me.SwifRecuperar.UncheckedState.FillColor = System.Drawing.Color.DarkGray
        Me.SwifRecuperar.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwifRecuperar.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'panelContedido
        '
        Me.panelContedido.Controls.Add(Me.btnOjo)
        Me.panelContedido.Controls.Add(Me.label3)
        Me.panelContedido.Controls.Add(Me.txtContra)
        Me.panelContedido.Controls.Add(Me.btn_Iniciar)
        Me.panelContedido.Controls.Add(Me.SwifRecuperar)
        Me.panelContedido.Controls.Add(Me.txtCorreo)
        Me.panelContedido.Controls.Add(Me.Label1)
        Me.panelContedido.Controls.Add(Me.linkLabel1)
        Me.panelContedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContedido.Location = New System.Drawing.Point(0, 0)
        Me.panelContedido.Name = "panelContedido"
        Me.panelContedido.Size = New System.Drawing.Size(996, 554)
        Me.panelContedido.TabIndex = 24
        '
        'btnOjo
        '
        Me.btnOjo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOjo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOjo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOjo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOjo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOjo.FillColor = System.Drawing.Color.White
        Me.btnOjo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOjo.ForeColor = System.Drawing.Color.White
        Me.btnOjo.HoverState.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.ojo_visible
        Me.btnOjo.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.ojo_invisible
        Me.btnOjo.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btnOjo.Location = New System.Drawing.Point(632, 262)
        Me.btnOjo.Name = "btnOjo"
        Me.btnOjo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnOjo.Size = New System.Drawing.Size(28, 26)
        Me.btnOjo.TabIndex = 24
        Me.btnOjo.Text = "11"
        '
        'txtContra
        '
        Me.txtContra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContra.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtContra.BorderRadius = 17
        Me.txtContra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContra.DefaultText = "Contraseña"
        Me.txtContra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContra.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtContra.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContra.IconLeft = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.contraseña
        Me.txtContra.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtContra.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtContra.Location = New System.Drawing.Point(321, 251)
        Me.txtContra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContra.PlaceholderText = ""
        Me.txtContra.SelectedText = ""
        Me.txtContra.Size = New System.Drawing.Size(355, 44)
        Me.txtContra.TabIndex = 23
        Me.txtContra.TextOffset = New System.Drawing.Point(6, 0)
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtCorreo.BorderRadius = 17
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = "Correo Electrónico"
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.IconLeft = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.correo
        Me.txtCorreo.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtCorreo.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtCorreo.Location = New System.Drawing.Point(321, 192)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.Size = New System.Drawing.Size(355, 44)
        Me.txtCorreo.TabIndex = 3
        Me.txtCorreo.TextOffset = New System.Drawing.Point(6, 0)
        '
        'PanelLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 554)
        Me.Controls.Add(Me.panelContedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelLogin"
        Me.Text = "PanelLogin"
        Me.panelContedido.ResumeLayout(False)
        Me.panelContedido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Iniciar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label3 As Label
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents Label1 As Label
    Friend WithEvents SwifRecuperar As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtContra As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelContedido As Panel
    Friend WithEvents btnOjo As Guna.UI2.WinForms.Guna2CircleButton
End Class
