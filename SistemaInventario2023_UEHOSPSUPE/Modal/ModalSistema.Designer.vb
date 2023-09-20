<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModalSistema))
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.txtId_Sistema = New System.Windows.Forms.TextBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.PanelContendio1 = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtOffice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSistAplica = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cboTipSistema = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreEquipo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGrupoTrabajo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelContendio4 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpFechaReg = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PanelBarra.SuspendLayout()
        Me.PanelContendio1.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.PanelContendio4.SuspendLayout()
        Me.Guna2GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarra
        '
        Me.PanelBarra.Controls.Add(Me.txtId_Sistema)
        Me.PanelBarra.Controls.Add(Me.lbTitulo)
        Me.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarra.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(558, 41)
        Me.PanelBarra.TabIndex = 4
        '
        'txtId_Sistema
        '
        Me.txtId_Sistema.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Sistema.Enabled = False
        Me.txtId_Sistema.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Sistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtId_Sistema.Location = New System.Drawing.Point(370, 8)
        Me.txtId_Sistema.Name = "txtId_Sistema"
        Me.txtId_Sistema.ReadOnly = True
        Me.txtId_Sistema.Size = New System.Drawing.Size(178, 16)
        Me.txtId_Sistema.TabIndex = 347
        Me.txtId_Sistema.Visible = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Black
        Me.lbTitulo.Location = New System.Drawing.Point(12, 0)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(220, 25)
        Me.lbTitulo.TabIndex = 456
        Me.lbTitulo.Text = "Editar Datos de Sistema"
        '
        'PanelContendio1
        '
        Me.PanelContendio1.Controls.Add(Me.txtUsuario)
        Me.PanelContendio1.Controls.Add(Me.txtOffice)
        Me.PanelContendio1.Controls.Add(Me.txtSistAplica)
        Me.PanelContendio1.Controls.Add(Me.Label34)
        Me.PanelContendio1.Controls.Add(Me.Label33)
        Me.PanelContendio1.Controls.Add(Me.Label31)
        Me.PanelContendio1.Controls.Add(Me.Label29)
        Me.PanelContendio1.Controls.Add(Me.Label28)
        Me.PanelContendio1.Controls.Add(Me.Label27)
        Me.PanelContendio1.Controls.Add(Me.Label26)
        Me.PanelContendio1.Controls.Add(Me.Guna2Separator2)
        Me.PanelContendio1.Controls.Add(Me.Guna2Separator1)
        Me.PanelContendio1.Controls.Add(Me.Guna2GroupBox4)
        Me.PanelContendio1.Controls.Add(Me.Label9)
        Me.PanelContendio1.Controls.Add(Me.Label8)
        Me.PanelContendio1.Controls.Add(Me.txtNombreEquipo)
        Me.PanelContendio1.Controls.Add(Me.txtGrupoTrabajo)
        Me.PanelContendio1.Controls.Add(Me.Label6)
        Me.PanelContendio1.Controls.Add(Me.Label5)
        Me.PanelContendio1.Controls.Add(Me.Label3)
        Me.PanelContendio1.Controls.Add(Me.Label2)
        Me.PanelContendio1.Controls.Add(Me.Label1)
        Me.PanelContendio1.Controls.Add(Me.txtIp)
        Me.PanelContendio1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelContendio1.Location = New System.Drawing.Point(0, 41)
        Me.PanelContendio1.Name = "PanelContendio1"
        Me.PanelContendio1.Size = New System.Drawing.Size(558, 231)
        Me.PanelContendio1.TabIndex = 553
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(370, 3)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(178, 20)
        Me.txtUsuario.TabIndex = 576
        Me.txtUsuario.Visible = False
        '
        'txtOffice
        '
        Me.txtOffice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtOffice.BorderRadius = 8
        Me.txtOffice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOffice.DefaultText = ""
        Me.txtOffice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOffice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOffice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOffice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOffice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOffice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtOffice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOffice.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtOffice.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtOffice.Location = New System.Drawing.Point(330, 173)
        Me.txtOffice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOffice.PlaceholderText = ""
        Me.txtOffice.SelectedText = ""
        Me.txtOffice.Size = New System.Drawing.Size(207, 37)
        Me.txtOffice.TabIndex = 575
        Me.txtOffice.TextOffset = New System.Drawing.Point(6, 0)
        '
        'txtSistAplica
        '
        Me.txtSistAplica.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtSistAplica.BorderRadius = 8
        Me.txtSistAplica.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSistAplica.DefaultText = ""
        Me.txtSistAplica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSistAplica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSistAplica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSistAplica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSistAplica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSistAplica.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSistAplica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtSistAplica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSistAplica.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtSistAplica.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtSistAplica.Location = New System.Drawing.Point(17, 173)
        Me.txtSistAplica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSistAplica.Name = "txtSistAplica"
        Me.txtSistAplica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSistAplica.PlaceholderText = ""
        Me.txtSistAplica.SelectedText = ""
        Me.txtSistAplica.Size = New System.Drawing.Size(293, 37)
        Me.txtSistAplica.TabIndex = 574
        Me.txtSistAplica.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(187, 31)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 17)
        Me.Label34.TabIndex = 573
        Me.Label34.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(351, 27)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 17)
        Me.Label33.TabIndex = 572
        Me.Label33.Text = "*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(558, 153)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 17)
        Me.Label31.TabIndex = 570
        Me.Label31.Text = "*"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(375, 153)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 17)
        Me.Label29.TabIndex = 568
        Me.Label29.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(453, 89)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 17)
        Me.Label28.TabIndex = 567
        Me.Label28.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(141, 89)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 17)
        Me.Label27.TabIndex = 566
        Me.Label27.Text = "*"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(160, 154)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 17)
        Me.Label26.TabIndex = 565
        Me.Label26.Text = "*"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Guna2Separator2.Location = New System.Drawing.Point(0, 1)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(558, 1)
        Me.Guna2Separator2.TabIndex = 564
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(558, 1)
        Me.Guna2Separator1.TabIndex = 563
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Guna2GroupBox4.BorderRadius = 8
        Me.Guna2GroupBox4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GroupBox4.Controls.Add(Me.cboTipSistema)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Empty
        Me.Guna2GroupBox4.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(17, 51)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(291, 37)
        Me.Guna2GroupBox4.TabIndex = 562
        '
        'cboTipSistema
        '
        Me.cboTipSistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipSistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipSistema.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboTipSistema.FormattingEnabled = True
        Me.cboTipSistema.Location = New System.Drawing.Point(5, 5)
        Me.cboTipSistema.Name = "cboTipSistema"
        Me.cboTipSistema.Size = New System.Drawing.Size(276, 25)
        Me.cboTipSistema.TabIndex = 561
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(330, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 465
        Me.Label9.Text = "Grupos de Trabajo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(17, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 17)
        Me.Label8.TabIndex = 464
        Me.Label8.Text = "Sistemas o Aplicativos"
        '
        'txtNombreEquipo
        '
        Me.txtNombreEquipo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtNombreEquipo.BorderRadius = 8
        Me.txtNombreEquipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreEquipo.DefaultText = ""
        Me.txtNombreEquipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreEquipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreEquipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEquipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEquipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreEquipo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEquipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtNombreEquipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreEquipo.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtNombreEquipo.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtNombreEquipo.Location = New System.Drawing.Point(17, 113)
        Me.txtNombreEquipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEquipo.Name = "txtNombreEquipo"
        Me.txtNombreEquipo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreEquipo.PlaceholderText = ""
        Me.txtNombreEquipo.SelectedText = ""
        Me.txtNombreEquipo.Size = New System.Drawing.Size(293, 37)
        Me.txtNombreEquipo.TabIndex = 31
        Me.txtNombreEquipo.TextOffset = New System.Drawing.Point(6, 0)
        '
        'txtGrupoTrabajo
        '
        Me.txtGrupoTrabajo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtGrupoTrabajo.BorderRadius = 8
        Me.txtGrupoTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGrupoTrabajo.DefaultText = ""
        Me.txtGrupoTrabajo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGrupoTrabajo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGrupoTrabajo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGrupoTrabajo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGrupoTrabajo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrupoTrabajo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupoTrabajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtGrupoTrabajo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrupoTrabajo.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtGrupoTrabajo.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtGrupoTrabajo.Location = New System.Drawing.Point(330, 113)
        Me.txtGrupoTrabajo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrupoTrabajo.Name = "txtGrupoTrabajo"
        Me.txtGrupoTrabajo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrupoTrabajo.PlaceholderText = ""
        Me.txtGrupoTrabajo.SelectedText = ""
        Me.txtGrupoTrabajo.Size = New System.Drawing.Size(207, 37)
        Me.txtGrupoTrabajo.TabIndex = 30
        Me.txtGrupoTrabajo.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(17, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 17)
        Me.Label6.TabIndex = 462
        Me.Label6.Text = "Nombre del Equipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(330, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 461
        Me.Label5.Text = "Office"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(330, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 17)
        Me.Label3.TabIndex = 459
        Me.Label3.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(17, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 17)
        Me.Label2.TabIndex = 458
        Me.Label2.Text = "Tipo de Sistema Operativo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 457
        Me.Label1.Text = "Descripción "
        '
        'txtIp
        '
        Me.txtIp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.txtIp.BorderRadius = 8
        Me.txtIp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIp.DefaultText = ""
        Me.txtIp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtIp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIp.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtIp.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtIp.Location = New System.Drawing.Point(330, 51)
        Me.txtIp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIp.PlaceholderText = ""
        Me.txtIp.SelectedText = ""
        Me.txtIp.Size = New System.Drawing.Size(207, 37)
        Me.txtIp.TabIndex = 24
        Me.txtIp.TextOffset = New System.Drawing.Point(6, 0)
        '
        'PanelContendio4
        '
        Me.PanelContendio4.Controls.Add(Me.btnCerrar)
        Me.PanelContendio4.Controls.Add(Me.btnGuardar)
        Me.PanelContendio4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContendio4.Location = New System.Drawing.Point(0, 377)
        Me.PanelContendio4.Name = "PanelContendio4"
        Me.PanelContendio4.Size = New System.Drawing.Size(558, 58)
        Me.PanelContendio4.TabIndex = 554
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
        Me.btnCerrar.Location = New System.Drawing.Point(270, 8)
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
        Me.btnGuardar.Location = New System.Drawing.Point(412, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 43)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
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
        Me.dtpFechaReg.Location = New System.Drawing.Point(346, 312)
        Me.dtpFechaReg.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaReg.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(191, 37)
        Me.dtpFechaReg.TabIndex = 564
        Me.dtpFechaReg.Value = New Date(2023, 1, 31, 18, 34, 48, 965)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(349, 292)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 17)
        Me.Label25.TabIndex = 563
        Me.Label25.Text = "Fecha de Registro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(73, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 573
        Me.Label11.Text = "*"
        '
        'Guna2GroupBox5
        '
        Me.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Guna2GroupBox5.BorderRadius = 8
        Me.Guna2GroupBox5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GroupBox5.Controls.Add(Me.cboEstado)
        Me.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.Empty
        Me.Guna2GroupBox5.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox5.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox5.Location = New System.Drawing.Point(22, 318)
        Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
        Me.Guna2GroupBox5.Size = New System.Drawing.Size(197, 37)
        Me.Guna2GroupBox5.TabIndex = 572
        '
        'cboEstado
        '
        Me.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(3, 6)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(191, 25)
        Me.cboEstado.TabIndex = 543
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(19, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 571
        Me.Label12.Text = "Estado"
        '
        'ModalSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(558, 435)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Guna2GroupBox5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpFechaReg)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.PanelContendio4)
        Me.Controls.Add(Me.PanelContendio1)
        Me.Controls.Add(Me.PanelBarra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 474)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 474)
        Me.Name = "ModalSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sistema"
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelBarra.PerformLayout()
        Me.PanelContendio1.ResumeLayout(False)
        Me.PanelContendio1.PerformLayout()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.PanelContendio4.ResumeLayout(False)
        Me.Guna2GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarra As Panel
    Public WithEvents txtId_Sistema As TextBox
    Public WithEvents lbTitulo As Label
    Friend WithEvents PanelContendio1 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Public WithEvents cboTipSistema As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents PanelContendio4 As Panel
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2GroupBox5 As Guna.UI2.WinForms.Guna2GroupBox
    Public WithEvents cboEstado As ComboBox
    Friend WithEvents Label12 As Label
    Public WithEvents txtUsuario As TextBox
    Public WithEvents txtNombreEquipo As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtGrupoTrabajo As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtIp As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtOffice As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtSistAplica As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents dtpFechaReg As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
