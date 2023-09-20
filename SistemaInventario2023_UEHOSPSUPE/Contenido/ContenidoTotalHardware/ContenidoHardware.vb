Imports BussinessLayer

Public Class ContenidoHardware
    '-----------------------------------'
    'Objeto a partir de CArticuloBL'
    Dim oTipoHardwareBL As New C_HARDWARE_BL
    '------------------------------------'
    'Validar para recuperar el ID de la fila Seleccionada'
    Dim pId As String
    '------------------------------------'
    Dim oDv As New DataView
    '------------------------------------'
    Private Sub cargarRegistros()
        'pasar el datatable al dataview'
        oDv = oTipoHardwareBL.listarHarware().DefaultView
        dgvListadoHardware.DataSource = oDv
    End Sub

    Private Sub Contador()
        Dim contador As DataRow = oTipoHardwareBL.Contador().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_EQUI"))
        labTotal.Text = "(" + DatoContador + ")"
    End Sub
    '------------------------------------'
    Private Sub ContadorDatosCPU()
        Dim contador As DataRow = oTipoHardwareBL.ContadorCPU().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalCPU.Text = DatoContador
    End Sub

    Private Sub ContadorDatosLAPTOP()
        Dim contador As DataRow = oTipoHardwareBL.ContadorLaptop().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalLaptop.Text = DatoContador
    End Sub

    Private Sub ContadorDatosSERVIDOR()
        Dim contador As DataRow = oTipoHardwareBL.ContadorServidor().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalServidores.Text = DatoContador
    End Sub
    '------------------------------------'
    Private Sub ContadorDatosMONITOR()
        Dim contador As DataRow = oTipoHardwareBL.ContadorMonitor().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalMonitor.Text = DatoContador
    End Sub

    Private Sub ContadorDatosTECLADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorTeclado().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalTeclado.Text = DatoContador
    End Sub

    Private Sub ContadorDatosMAUSE()
        Dim contador As DataRow = oTipoHardwareBL.ContadorMause.Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalMause.Text = DatoContador
    End Sub
    Private Sub ContadorDatosESTABILIZADOR()
        Dim contador As DataRow = oTipoHardwareBL.ContadorEstabilizador.Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalEstabilizador.Text = DatoContador
    End Sub
    Private Sub ContadorDatosIMPRESORA()
        Dim contador As DataRow = oTipoHardwareBL.ContadorImpresora.Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        lbTotalImpresora.Text = DatoContador
    End Sub

    'Equipos desahabilitados
    '-----------------------------
    Private Sub ContadorDatosCPUD_ESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorCPU_DESHABILITADO().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        CPUdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub

    Private Sub ContadorDatosLAPTOP_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorLaptop_DESHABILITADO().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        LAPTOPdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub

    Private Sub ContadorDatosSERVIDOR_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorServidor_DESHABILITADO().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        SERVIDORdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub

    '------------------------------------'

    Private Sub ContadorDatosMONITOR_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorMonitor_DESHABILITADO().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        MONITORdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub

    Private Sub ContadorDatosTECLADO_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorTeclado_DESHABILITADO().Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        TECLADOdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub

    Private Sub ContadorDatosMAUSE_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorMause_DESHABILITADO.Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        MAUSEdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub
    Private Sub ContadorDatosESTABILIZADOR_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorEstabilizador_DESHABILITADO.Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        ESTABILIZADORdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub
    Private Sub ContadorDatosIMPRESORA_DESHABILITADO()
        Dim contador As DataRow = oTipoHardwareBL.ContadorImpresora_DESHABILITADO.Rows(0)
        Dim DatoContador As String
        DatoContador = Convert.ToString(contador("ID_TIP_EQUI"))
        IMPRESORAdeshabilitado.Text = "+" + DatoContador + " deshabilitado"
    End Sub


    Private Sub ContadorACTIVO()
        ContadorDatosCPU()
        ContadorDatosLAPTOP()
        ContadorDatosSERVIDOR()
        '----------------------------
        ContadorDatosMONITOR()
        ContadorDatosTECLADO()
        ContadorDatosMAUSE()
        ContadorDatosESTABILIZADOR()
        ContadorDatosIMPRESORA()
    End Sub

    Private Sub ContadorDESHABILITADO()
        ContadorDatosCPUD_ESHABILITADO()
        ContadorDatosLAPTOP_DESHABILITADO()
        ContadorDatosSERVIDOR_DESHABILITADO()
        '----------------------------
        ContadorDatosMONITOR_DESHABILITADO()
        ContadorDatosTECLADO_DESHABILITADO()
        ContadorDatosMAUSE_DESHABILITADO()
        ContadorDatosESTABILIZADOR_DESHABILITADO()
        ContadorDatosIMPRESORA_DESHABILITADO()
    End Sub

    Private Sub cargarComboSelected()
        dtpFecha.Value = Today()
        cboOpcionEquipo.SelectedIndex = 0
    End Sub
    Sub realizarBusquedadEquipo()
        'evaluar la opcion'
        Select Case cboOpcionEquipo.SelectedIndex
            Case 0
                oDv.RowFilter = String.Format("COD_PAT_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 1
                oDv.RowFilter = String.Format("DESC_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 2
                oDv.RowFilter = String.Format("MARCA_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 3
                oDv.RowFilter = String.Format("MODELO_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 4
                oDv.RowFilter = String.Format("SERIE_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 5
                oDv.RowFilter = String.Format("PROC_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 6
                oDv.RowFilter = String.Format("RAM_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 7
                oDv.RowFilter = String.Format("NOMB_AREA LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 8
                oDv.RowFilter = String.Format("NOMB_UBIC LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 9
                oDv.RowFilter = String.Format("DESC_ESTADO LIKE '%{0}%'", txtBuscarEquipo.Text)
            Case 10
                oDv.RowFilter = String.Format("ACTIVIDA_EQUI LIKE '%{0}%'", txtBuscarEquipo.Text)
        End Select
    End Sub

    Private Sub btnFiltarFecha_Click(sender As Object, e As EventArgs) Handles btnFiltarFecha.Click
        If dtpFecha.TextRenderingHint > 0 Then
            oDv.RowFilter = String.Format("CONVERT(FECHA_REG_EQUI, System.String) LIKE '%{0}%'", dtpFecha.Value.ToString("dd/MM/yyyy"))
        Else
            oDv.RowFilter = Nothing
        End If

    End Sub

    Private Sub Guna2CircleButton9_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton9.Click
        txtBuscarEquipo.Text = ""
    End Sub

    Private Sub txtBuscarEquipo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEquipo.TextChanged
        If txtBuscarEquipo.TextLength > 0 Then
            realizarBusquedadEquipo()
        Else
            oDv.RowFilter = Nothing
        End If
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        Contador()
        cargarRegistros()
        ContadorACTIVO()
        ContadorDESHABILITADO()
    End Sub

    Private Sub ContenidoHardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contador()
        ContadorACTIVO()
        ContadorDESHABILITADO()
        '----------------------------
        cargarRegistros()
        cargarComboSelected()
    End Sub


End Class