<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContenido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormContenido))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.LogoImg = New System.Windows.Forms.PictureBox()
        Me.PanelContendido01 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LogoImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContendido01.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(517, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sistema Inventario"
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(477, 234)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(246, 47)
        Me.label1.TabIndex = 13
        Me.label1.Text = "UEHOSPSUPE"
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar.Animated = True
        Me.ProgressBar.FillColor = System.Drawing.Color.White
        Me.ProgressBar.FillThickness = 15
        Me.ProgressBar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ProgressBar.ForeColor = System.Drawing.Color.White
        Me.ProgressBar.Location = New System.Drawing.Point(564, 369)
        Me.ProgressBar.Minimum = 0
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.ProgressBar.ProgressThickness = 15
        Me.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProgressBar.Size = New System.Drawing.Size(90, 90)
        Me.ProgressBar.TabIndex = 15
        Me.ProgressBar.Text = "Guna2CircleProgressBar1"
        Me.ProgressBar.Value = 20
        '
        'LogoImg
        '
        Me.LogoImg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoImg.Image = Global.SistemaInventario2023_UEHOSPSUPE.My.Resources.Resources.icono_png
        Me.LogoImg.Location = New System.Drawing.Point(546, 118)
        Me.LogoImg.Name = "LogoImg"
        Me.LogoImg.Size = New System.Drawing.Size(115, 113)
        Me.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoImg.TabIndex = 2
        Me.LogoImg.TabStop = False
        '
        'PanelContendido01
        '
        Me.PanelContendido01.Controls.Add(Me.LogoImg)
        Me.PanelContendido01.Controls.Add(Me.ProgressBar)
        Me.PanelContendido01.Controls.Add(Me.label1)
        Me.PanelContendido01.Controls.Add(Me.Label4)
        Me.PanelContendido01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContendido01.Location = New System.Drawing.Point(0, 0)
        Me.PanelContendido01.Name = "PanelContendido01"
        Me.PanelContendido01.Size = New System.Drawing.Size(1184, 615)
        Me.PanelContendido01.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'FormContenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 615)
        Me.Controls.Add(Me.PanelContendido01)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormContenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UEHOSPSUPE"
        CType(Me.LogoImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContendido01.ResumeLayout(False)
        Me.PanelContendido01.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents LogoImg As PictureBox
    Private WithEvents Label4 As Label
    Private WithEvents label1 As Label
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents PanelContendido01 As Panel
    Friend WithEvents Timer1 As Timer
End Class
