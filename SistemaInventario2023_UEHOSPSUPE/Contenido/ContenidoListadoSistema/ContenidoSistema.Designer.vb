﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenidoSistema
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
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDatos = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvListadoSistema = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnFiltarFecha = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnReporte = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnEliminar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnEditar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnAgregar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cboOpcionEquipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpFecha = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtBuscarSistema = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDatos
        '
        Me.btnDatos.Animated = True
        Me.btnDatos.BackColor = System.Drawing.Color.White
        Me.btnDatos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnDatos.BorderRadius = 8
        Me.btnDatos.BorderThickness = 1
        Me.btnDatos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDatos.CustomImages.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.reiniciar_datos
        Me.btnDatos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDatos.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnDatos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.FillColor = System.Drawing.Color.White
        Me.btnDatos.FocusedColor = System.Drawing.Color.White
        Me.btnDatos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDatos.ForeColor = System.Drawing.Color.Black
        Me.btnDatos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnDatos.Location = New System.Drawing.Point(521, 16)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.PressedColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDatos.Size = New System.Drawing.Size(110, 36)
        Me.btnDatos.TabIndex = 555
        Me.btnDatos.Text = "Actualizar"
        Me.btnDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDatos.TextOffset = New System.Drawing.Point(30, 0)
        '
        'dgvListadoSistema
        '
        Me.dgvListadoSistema.AllowUserToAddRows = False
        Me.dgvListadoSistema.AllowUserToDeleteRows = False
        Me.dgvListadoSistema.AllowUserToResizeRows = False
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.White
        Me.dgvListadoSistema.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvListadoSistema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoSistema.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.dgvListadoSistema.ColumnHeadersHeight = 50
        Me.dgvListadoSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvListadoSistema.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoSistema.DefaultCellStyle = DataGridViewCellStyle39
        Me.dgvListadoSistema.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvListadoSistema.Location = New System.Drawing.Point(16, 127)
        Me.dgvListadoSistema.Name = "dgvListadoSistema"
        Me.dgvListadoSistema.ReadOnly = True
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoSistema.RowHeadersDefaultCellStyle = DataGridViewCellStyle40
        Me.dgvListadoSistema.RowHeadersVisible = False
        Me.dgvListadoSistema.RowTemplate.Height = 45
        Me.dgvListadoSistema.Size = New System.Drawing.Size(900, 253)
        Me.dgvListadoSistema.TabIndex = 554
        Me.dgvListadoSistema.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvListadoSistema.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvListadoSistema.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvListadoSistema.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvListadoSistema.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvListadoSistema.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvListadoSistema.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvListadoSistema.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgvListadoSistema.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListadoSistema.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListadoSistema.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListadoSistema.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvListadoSistema.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvListadoSistema.ThemeStyle.ReadOnly = True
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.Height = 45
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgvListadoSistema.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnFiltarFecha
        '
        Me.btnFiltarFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFiltarFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFiltarFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFiltarFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFiltarFecha.FillColor = System.Drawing.Color.White
        Me.btnFiltarFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFiltarFecha.ForeColor = System.Drawing.Color.White
        Me.btnFiltarFecha.HoverState.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.filtrar_fecha_2
        Me.btnFiltarFecha.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.filtrar_fecha
        Me.btnFiltarFecha.Location = New System.Drawing.Point(683, 64)
        Me.btnFiltarFecha.Name = "btnFiltarFecha"
        Me.btnFiltarFecha.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnFiltarFecha.Size = New System.Drawing.Size(40, 40)
        Me.btnFiltarFecha.TabIndex = 553
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReporte)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEditar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAgregar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(728, 17)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(188, 48)
        Me.FlowLayoutPanel1.TabIndex = 552
        '
        'btnReporte
        '
        Me.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReporte.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReporte.ForeColor = System.Drawing.Color.White
        Me.btnReporte.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.reporte_de_negocios_48
        Me.btnReporte.Location = New System.Drawing.Point(145, 3)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnReporte.Size = New System.Drawing.Size(40, 40)
        Me.btnReporte.TabIndex = 543
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.eliminar_48
        Me.btnEliminar.Location = New System.Drawing.Point(99, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 543
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditar.FillColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.editar_48
        Me.btnEditar.Location = New System.Drawing.Point(53, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 543
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgregar.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.agregar
        Me.btnAgregar.Location = New System.Drawing.Point(7, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnAgregar.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregar.TabIndex = 542
        '
        'cboOpcionEquipo
        '
        Me.cboOpcionEquipo.BackColor = System.Drawing.Color.Transparent
        Me.cboOpcionEquipo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cboOpcionEquipo.BorderRadius = 8
        Me.cboOpcionEquipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOpcionEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcionEquipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboOpcionEquipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboOpcionEquipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboOpcionEquipo.ForeColor = System.Drawing.Color.Black
        Me.cboOpcionEquipo.ItemHeight = 30
        Me.cboOpcionEquipo.Items.AddRange(New Object() {"Sistema Operativo", "IP", "Nombre del Equipo", "Grupo de Trabajo", "Office", "Sistema o Aplicativos", "Estado"})
        Me.cboOpcionEquipo.Location = New System.Drawing.Point(328, 16)
        Me.cboOpcionEquipo.Name = "cboOpcionEquipo"
        Me.cboOpcionEquipo.Size = New System.Drawing.Size(187, 36)
        Me.cboOpcionEquipo.TabIndex = 551
        '
        'dtpFecha
        '
        Me.dtpFecha.Checked = True
        Me.dtpFecha.CheckedState.FillColor = System.Drawing.Color.White
        Me.dtpFecha.FillColor = System.Drawing.Color.White
        Me.dtpFecha.FocusedColor = System.Drawing.Color.White
        Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFecha.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpFecha.Location = New System.Drawing.Point(448, 68)
        Me.dtpFecha.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(236, 36)
        Me.dtpFecha.TabIndex = 550
        Me.dtpFecha.Value = New Date(2023, 1, 31, 18, 34, 48, 965)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(305, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 549
        Me.Label6.Text = "Estado del Equipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(255, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 548
        Me.Label7.Text = "Funcion:"
        '
        'labTotal
        '
        Me.labTotal.AutoSize = True
        Me.labTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.labTotal.ForeColor = System.Drawing.Color.Black
        Me.labTotal.Location = New System.Drawing.Point(186, 76)
        Me.labTotal.Name = "labTotal"
        Me.labTotal.Size = New System.Drawing.Size(44, 17)
        Me.labTotal.TabIndex = 547
        Me.labTotal.Text = "(2000)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 17)
        Me.Label5.TabIndex = 546
        Me.Label5.Text = "Total de Equipos Registrados:"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 8
        Me.Guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtBuscarSistema)
        Me.Guna2GroupBox1.Controls.Add(Me.PictureBox2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Empty
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(7, 16)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(315, 36)
        Me.Guna2GroupBox1.TabIndex = 545
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.eliminardato
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(279, 3)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2CircleButton1.TabIndex = 542
        '
        'txtBuscarSistema
        '
        Me.txtBuscarSistema.BackColor = System.Drawing.Color.White
        Me.txtBuscarSistema.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscarSistema.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarSistema.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarSistema.Location = New System.Drawing.Point(45, 8)
        Me.txtBuscarSistema.Name = "txtBuscarSistema"
        Me.txtBuscarSistema.Size = New System.Drawing.Size(224, 22)
        Me.txtBuscarSistema.TabIndex = 359
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.búsqueda
        Me.PictureBox2.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 357
        Me.PictureBox2.TabStop = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_SISTE"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DESC_SISTE"
        Me.Column2.HeaderText = "Sistema Operativo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "IP_SISTE"
        Me.Column3.HeaderText = "IP"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "NOMB_SISTE"
        Me.Column4.HeaderText = "Nombre del Equipo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "GRUPO_SISTE"
        Me.Column5.HeaderText = "Grupo de Trabajo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "OFFICE_SISTE"
        Me.Column6.HeaderText = "Office"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "SISTEMA_SISTE"
        Me.Column7.HeaderText = "Sistema o Aplicativos"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "DESC_ESTADO"
        Me.Column8.HeaderText = "Estado "
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "FECHA_REG_SISTE"
        Me.Column9.HeaderText = "Fecha de Registro"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'ContenidoSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 396)
        Me.Controls.Add(Me.btnDatos)
        Me.Controls.Add(Me.dgvListadoSistema)
        Me.Controls.Add(Me.btnFiltarFecha)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cboOpcionEquipo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.labTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ContenidoSistema"
        Me.Text = "ContenidoSistema"
        CType(Me.dgvListadoSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDatos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvListadoSistema As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnFiltarFecha As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnReporte As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnEliminar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnEditar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnAgregar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cboOpcionEquipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpFecha As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents labTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtBuscarSistema As TextBox
    Private WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
