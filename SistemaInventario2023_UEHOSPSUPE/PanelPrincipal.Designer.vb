<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelPrincipal
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
        Dim Animation8 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation7 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelPrincipal))
        Me.PanelSlider = New System.Windows.Forms.Panel()
        Me.btnSistema = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDatos = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEquipos = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Slider = New Guna.UI2.WinForms.Guna2Button()
        Me.LabelHardware = New System.Windows.Forms.Label()
        Me.LabelSoftware = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.SeparatorUsuario = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFiltarFecha = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lbAcceso = New System.Windows.Forms.Label()
        Me.lbNombreUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Titulo_lab = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Transition2 = New Guna.UI2.WinForms.Guna2Transition()
        Me.PanelSlider.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSlider
        '
        Me.PanelSlider.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelSlider.Controls.Add(Me.btnSistema)
        Me.PanelSlider.Controls.Add(Me.btnUsuario)
        Me.PanelSlider.Controls.Add(Me.btnDatos)
        Me.PanelSlider.Controls.Add(Me.btnEquipos)
        Me.PanelSlider.Controls.Add(Me.btn_Slider)
        Me.PanelSlider.Controls.Add(Me.LabelHardware)
        Me.PanelSlider.Controls.Add(Me.LabelSoftware)
        Me.PanelSlider.Controls.Add(Me.LabelUsuario)
        Me.PanelSlider.Controls.Add(Me.SeparatorUsuario)
        Me.Guna2Transition2.SetDecoration(Me.PanelSlider, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.PanelSlider, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSlider.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSlider.Location = New System.Drawing.Point(0, 0)
        Me.PanelSlider.Name = "PanelSlider"
        Me.PanelSlider.Size = New System.Drawing.Size(196, 633)
        Me.PanelSlider.TabIndex = 0
        '
        'btnSistema
        '
        Me.btnSistema.Animated = True
        Me.btnSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.BorderRadius = 8
        Me.btnSistema.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSistema.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSistema.CustomImages.HoveredImage = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.sistema_2
        Me.btnSistema.CustomImages.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.sistema_1
        Me.btnSistema.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSistema.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Transition2.SetDecoration(Me.btnSistema, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.btnSistema, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnSistema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSistema.ForeColor = System.Drawing.Color.Black
        Me.btnSistema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnSistema.Location = New System.Drawing.Point(14, 215)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSistema.Size = New System.Drawing.Size(162, 40)
        Me.btnSistema.TabIndex = 210
        Me.btnSistema.Text = " Sistema"
        Me.btnSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSistema.TextOffset = New System.Drawing.Point(30, 0)
        Me.ToolTip1.SetToolTip(Me.btnSistema, "Sistema")
        '
        'btnUsuario
        '
        Me.btnUsuario.Animated = True
        Me.btnUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.BorderRadius = 8
        Me.btnUsuario.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnUsuario.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnUsuario.CustomImages.HoveredImage = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.usuario2_48
        Me.btnUsuario.CustomImages.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.usuario_48
        Me.btnUsuario.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsuario.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Transition2.SetDecoration(Me.btnUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.btnUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUsuario.ForeColor = System.Drawing.Color.Black
        Me.btnUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnUsuario.Location = New System.Drawing.Point(12, 311)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUsuario.Size = New System.Drawing.Size(162, 40)
        Me.btnUsuario.TabIndex = 209
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsuario.TextOffset = New System.Drawing.Point(30, 0)
        Me.ToolTip1.SetToolTip(Me.btnUsuario, "Usuario")
        '
        'btnDatos
        '
        Me.btnDatos.Animated = True
        Me.btnDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.BorderRadius = 8
        Me.btnDatos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnDatos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDatos.CustomImages.HoveredImage = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.database_2
        Me.btnDatos.CustomImages.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.database_11
        Me.btnDatos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDatos.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Transition2.SetDecoration(Me.btnDatos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.btnDatos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDatos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDatos.ForeColor = System.Drawing.Color.Black
        Me.btnDatos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnDatos.Location = New System.Drawing.Point(12, 119)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.Size = New System.Drawing.Size(162, 40)
        Me.btnDatos.TabIndex = 208
        Me.btnDatos.Text = "Total de Datos"
        Me.btnDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDatos.TextOffset = New System.Drawing.Point(30, 0)
        Me.ToolTip1.SetToolTip(Me.btnDatos, "Total de Datos")
        '
        'btnEquipos
        '
        Me.btnEquipos.Animated = True
        Me.btnEquipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.BorderRadius = 8
        Me.btnEquipos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnEquipos.Checked = True
        Me.btnEquipos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEquipos.CustomImages.HoveredImage = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.Equipo1
        Me.btnEquipos.CustomImages.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.Equipo
        Me.btnEquipos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEquipos.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Transition2.SetDecoration(Me.btnEquipos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.btnEquipos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnEquipos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEquipos.ForeColor = System.Drawing.Color.Black
        Me.btnEquipos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnEquipos.Location = New System.Drawing.Point(14, 73)
        Me.btnEquipos.Name = "btnEquipos"
        Me.btnEquipos.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnEquipos.Size = New System.Drawing.Size(159, 40)
        Me.btnEquipos.TabIndex = 207
        Me.btnEquipos.Text = "Equipos "
        Me.btnEquipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEquipos.TextOffset = New System.Drawing.Point(30, 0)
        Me.ToolTip1.SetToolTip(Me.btnEquipos, "Equipos")
        '
        'btn_Slider
        '
        Me.Guna2Transition2.SetDecoration(Me.btn_Slider, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.btn_Slider, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_Slider.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Slider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Slider.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Slider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Slider.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_Slider.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Slider.ForeColor = System.Drawing.Color.White
        Me.btn_Slider.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.menú
        Me.btn_Slider.Location = New System.Drawing.Point(0, 0)
        Me.btn_Slider.Name = "btn_Slider"
        Me.btn_Slider.Size = New System.Drawing.Size(49, 39)
        Me.btn_Slider.TabIndex = 206
        Me.btn_Slider.Visible = False
        '
        'LabelHardware
        '
        Me.LabelHardware.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LabelHardware, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.LabelHardware, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LabelHardware.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHardware.ForeColor = System.Drawing.Color.Black
        Me.LabelHardware.Location = New System.Drawing.Point(11, 35)
        Me.LabelHardware.Name = "LabelHardware"
        Me.LabelHardware.Size = New System.Drawing.Size(81, 17)
        Me.LabelHardware.TabIndex = 205
        Me.LabelHardware.Text = "HARDWARE"
        '
        'LabelSoftware
        '
        Me.LabelSoftware.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LabelSoftware, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.LabelSoftware, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LabelSoftware.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSoftware.ForeColor = System.Drawing.Color.Black
        Me.LabelSoftware.Location = New System.Drawing.Point(11, 175)
        Me.LabelSoftware.Name = "LabelSoftware"
        Me.LabelSoftware.Size = New System.Drawing.Size(76, 17)
        Me.LabelSoftware.TabIndex = 204
        Me.LabelSoftware.Text = "SOFTWARE"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LabelUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.LabelUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LabelUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.Color.Black
        Me.LabelUsuario.Location = New System.Drawing.Point(12, 275)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(64, 17)
        Me.LabelUsuario.TabIndex = 203
        Me.LabelUsuario.Text = "USUARIO"
        '
        'SeparatorUsuario
        '
        Me.Guna2Transition2.SetDecoration(Me.SeparatorUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.SeparatorUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SeparatorUsuario.Location = New System.Drawing.Point(14, 295)
        Me.SeparatorUsuario.Name = "SeparatorUsuario"
        Me.SeparatorUsuario.Size = New System.Drawing.Size(160, 10)
        Me.SeparatorUsuario.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnFiltarFecha)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel2.Controls.Add(Me.lbAcceso)
        Me.Panel2.Controls.Add(Me.lbNombreUsuario)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Titulo_lab)
        Me.Guna2Transition2.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(196, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 51)
        Me.Panel2.TabIndex = 1
        '
        'btnFiltarFecha
        '
        Me.btnFiltarFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition2.SetDecoration(Me.btnFiltarFecha, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.btnFiltarFecha, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnFiltarFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFiltarFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFiltarFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFiltarFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFiltarFecha.FillColor = System.Drawing.Color.White
        Me.btnFiltarFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFiltarFecha.ForeColor = System.Drawing.Color.White
        Me.btnFiltarFecha.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.salida_48
        Me.btnFiltarFecha.Location = New System.Drawing.Point(949, 10)
        Me.btnFiltarFecha.Name = "btnFiltarFecha"
        Me.btnFiltarFecha.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnFiltarFecha.Size = New System.Drawing.Size(30, 30)
        Me.btnFiltarFecha.TabIndex = 554
        Me.ToolTip1.SetToolTip(Me.btnFiltarFecha, "Cerrar Sesion")
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition2.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox1.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.usuariogeneral
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(903, 6)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'lbAcceso
        '
        Me.lbAcceso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAcceso.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lbAcceso, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.lbAcceso, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lbAcceso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAcceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lbAcceso.Location = New System.Drawing.Point(716, 26)
        Me.lbAcceso.Name = "lbAcceso"
        Me.lbAcceso.Size = New System.Drawing.Size(99, 17)
        Me.lbAcceso.TabIndex = 354
        Me.lbAcceso.Text = "Administrador "
        '
        'lbNombreUsuario
        '
        Me.lbNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbNombreUsuario.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lbNombreUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.lbNombreUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lbNombreUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lbNombreUsuario.Location = New System.Drawing.Point(789, 7)
        Me.lbNombreUsuario.Name = "lbNombreUsuario"
        Me.lbNombreUsuario.Size = New System.Drawing.Size(104, 17)
        Me.lbNombreUsuario.TabIndex = 353
        Me.lbNombreUsuario.Text = "Usuario General"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(716, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 352
        Me.Label4.Text = "Bienvenido:"
        '
        'Titulo_lab
        '
        Me.Titulo_lab.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Titulo_lab, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.Titulo_lab, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Titulo_lab.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo_lab.ForeColor = System.Drawing.Color.Black
        Me.Titulo_lab.Location = New System.Drawing.Point(9, 7)
        Me.Titulo_lab.Name = "Titulo_lab"
        Me.Titulo_lab.Size = New System.Drawing.Size(125, 37)
        Me.Titulo_lab.TabIndex = 351
        Me.Titulo_lab.Text = "Equipos "
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.ProgressBar)
        Me.Guna2Transition2.SetDecoration(Me.PanelContenedor, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.PanelContenedor, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(196, 51)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(988, 582)
        Me.PanelContenedor.TabIndex = 2
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Transition2.SetDecoration(Me.ProgressBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.ProgressBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ProgressBar.FillColor = System.Drawing.Color.White
        Me.ProgressBar.FillThickness = 12
        Me.ProgressBar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ProgressBar.ForeColor = System.Drawing.Color.White
        Me.ProgressBar.Location = New System.Drawing.Point(449, 246)
        Me.ProgressBar.Minimum = 0
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar.ProgressThickness = 12
        Me.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProgressBar.Size = New System.Drawing.Size(90, 90)
        Me.ProgressBar.TabIndex = 16
        Me.ProgressBar.Text = "Guna2CircleProgressBar1"
        Me.ProgressBar.Value = 20
        '
        'Timer1
        '
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation8
        '
        'Guna2Transition2
        '
        Me.Guna2Transition2.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.Guna2Transition2.DefaultAnimation = Animation7
        '
        'PanelPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 633)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSlider)
        Me.Guna2Transition2.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "PanelPrincipal"
        Me.Text = "PanelPrincipal"
        Me.PanelSlider.ResumeLayout(False)
        Me.PanelSlider.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSlider As Panel
    Friend WithEvents btn_Slider As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LabelHardware As Label
    Friend WithEvents LabelSoftware As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents SeparatorUsuario As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Titulo_lab As Label
    Friend WithEvents btnEquipos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSistema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDatos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents lbAcceso As Label
    Friend WithEvents lbNombreUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Transition2 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents btnFiltarFecha As Guna.UI2.WinForms.Guna2CircleButton
End Class
