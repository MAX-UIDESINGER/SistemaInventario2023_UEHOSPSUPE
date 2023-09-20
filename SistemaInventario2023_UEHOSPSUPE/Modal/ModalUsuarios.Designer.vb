<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModalUsuarios))
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.PanelContendio4 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CboAcceso = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpFechaReg = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelBarra.SuspendLayout()
        Me.PanelContendio4.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarra
        '
        Me.PanelBarra.Controls.Add(Me.txtIdUsuario)
        Me.PanelBarra.Controls.Add(Me.lbTitulo)
        Me.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarra.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(521, 41)
        Me.PanelBarra.TabIndex = 3
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdUsuario.Enabled = False
        Me.txtIdUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdUsuario.Location = New System.Drawing.Point(311, 12)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.ReadOnly = True
        Me.txtIdUsuario.Size = New System.Drawing.Size(178, 16)
        Me.txtIdUsuario.TabIndex = 457
        Me.txtIdUsuario.Visible = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Black
        Me.lbTitulo.Location = New System.Drawing.Point(12, 0)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(221, 25)
        Me.lbTitulo.TabIndex = 456
        Me.lbTitulo.Text = "Editar Datos de Usuario"
        '
        'PanelContendio4
        '
        Me.PanelContendio4.Controls.Add(Me.btnCerrar)
        Me.PanelContendio4.Controls.Add(Me.btnGuardar)
        Me.PanelContendio4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContendio4.Location = New System.Drawing.Point(0, 379)
        Me.PanelContendio4.Name = "PanelContendio4"
        Me.PanelContendio4.Size = New System.Drawing.Size(521, 58)
        Me.PanelContendio4.TabIndex = 555
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnCerrar.BorderRadius = 20
        Me.btnCerrar.BorderThickness = 1
        Me.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrar.FillColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI Historic", 11.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(240, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(136, 43)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BorderRadius = 20
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Historic", 11.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(382, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 43)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtContraseña.BorderRadius = 8
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.DefaultText = ""
        Me.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtContraseña.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtContraseña.Location = New System.Drawing.Point(284, 166)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña.PlaceholderText = ""
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.Size = New System.Drawing.Size(205, 37)
        Me.txtContraseña.TabIndex = 594
        Me.txtContraseña.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(86, 84)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 17)
        Me.Label34.TabIndex = 592
        Me.Label34.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(346, 84)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 17)
        Me.Label33.TabIndex = 591
        Me.Label33.Text = "*"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(365, 146)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 17)
        Me.Label29.TabIndex = 590
        Me.Label29.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(147, 142)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 17)
        Me.Label27.TabIndex = 589
        Me.Label27.Text = "*"
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Guna2GroupBox4.BorderRadius = 8
        Me.Guna2GroupBox4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GroupBox4.Controls.Add(Me.CboAcceso)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Empty
        Me.Guna2GroupBox4.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(22, 236)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(236, 37)
        Me.Guna2GroupBox4.TabIndex = 587
        '
        'CboAcceso
        '
        Me.CboAcceso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboAcceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboAcceso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAcceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CboAcceso.FormattingEnabled = True
        Me.CboAcceso.Items.AddRange(New Object() {"Administrador", "Invitada"})
        Me.CboAcceso.Location = New System.Drawing.Point(6, 6)
        Me.CboAcceso.Name = "CboAcceso"
        Me.CboAcceso.Size = New System.Drawing.Size(220, 25)
        Me.CboAcceso.TabIndex = 1
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtCorreo.BorderRadius = 8
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtCorreo.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtCorreo.Location = New System.Drawing.Point(22, 166)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.Size = New System.Drawing.Size(245, 37)
        Me.txtCorreo.TabIndex = 579
        Me.txtCorreo.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(22, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 584
        Me.Label6.Text = "Correo Electrónico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(284, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 583
        Me.Label5.Text = "Contraseña "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(284, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 582
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(22, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 581
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 580
        Me.Label1.Text = "Descripción "
        '
        'txtApellido
        '
        Me.txtApellido.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtApellido.BorderRadius = 8
        Me.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido.DefaultText = ""
        Me.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtApellido.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtApellido.Location = New System.Drawing.Point(284, 104)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.Size = New System.Drawing.Size(205, 37)
        Me.txtApellido.TabIndex = 577
        Me.txtApellido.TextOffset = New System.Drawing.Point(6, 0)
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dtpFechaReg.BorderRadius = 8
        Me.dtpFechaReg.BorderThickness = 1
        Me.dtpFechaReg.Checked = True
        Me.dtpFechaReg.CheckedState.FillColor = System.Drawing.Color.White
        Me.dtpFechaReg.FillColor = System.Drawing.Color.White
        Me.dtpFechaReg.FocusedColor = System.Drawing.Color.White
        Me.dtpFechaReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFechaReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReg.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpFechaReg.Location = New System.Drawing.Point(286, 314)
        Me.dtpFechaReg.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaReg.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(203, 37)
        Me.dtpFechaReg.TabIndex = 596
        Me.dtpFechaReg.Value = New Date(2023, 1, 31, 18, 34, 48, 965)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(286, 294)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 17)
        Me.Label25.TabIndex = 595
        Me.Label25.Text = "Fecha de Registro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(147, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 598
        Me.Label4.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(22, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 17)
        Me.Label7.TabIndex = 597
        Me.Label7.Text = "Acceso o Permisos "
        '
        'txtNombre
        '
        Me.txtNombre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtNombre.BorderRadius = 8
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.DefaultText = ""
        Me.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtNombre.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtNombre.Location = New System.Drawing.Point(22, 105)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(245, 37)
        Me.txtNombre.TabIndex = 599
        Me.txtNombre.TextOffset = New System.Drawing.Point(6, 0)
        '
        'ModalUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 437)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechaReg)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Guna2GroupBox4)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.PanelContendio4)
        Me.Controls.Add(Me.PanelBarra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(537, 476)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(537, 476)
        Me.Name = "ModalUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuario"
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelBarra.PerformLayout()
        Me.PanelContendio4.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarra As Panel
    Public WithEvents lbTitulo As Label
    Friend WithEvents PanelContendio4 As Panel
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Public WithEvents txtIdUsuario As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents CboAcceso As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Public WithEvents txtContraseña As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents dtpFechaReg As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
