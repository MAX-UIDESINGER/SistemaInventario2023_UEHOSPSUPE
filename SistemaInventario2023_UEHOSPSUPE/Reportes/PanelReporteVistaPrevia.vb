Imports BussinessLayer
Imports CrystalDecisions.CrystalReports.Engine

Public Class PanelReporteVistaPrevia
    'Crear un Odjeto a partir del ReportDocument
    Dim oRepoDoc As ReportDocument
    'Procedimiento Publico para la impresion
    Public Sub VerReporte(nRepo As Byte)
        'Variable de tipo Datatable
        Dim oDt As New DataTable

        'Evaluasion del nro de Reporte
        Select Case nRepo
            Case 1 'Equipos
                Dim oBL As New C_EQUIPO_BL
                oDt = oBL.listarEquipo
                'Instanciamos el reporte 
                oRepoDoc = New rptEquipos

            Case 2 'Descripcion de Equipo
                Dim oBL As New C_EQUIPO_BL
                oDt = oBL.listarDescEquipo
                'Instanciamos el reporte 
                oRepoDoc = New rptDescEquipos

            Case 3 'Equipo Deshabilitado
                Dim oBL As New C_EQUIPO_BL
                oDt = oBL.EquipDeshabilitado
                'Instanciamos el reporte 
                oRepoDoc = New rptDeshabilitadoEquipos

            Case 4 'SIstema
                Dim oBL As New C_SISTEMA_BL
                oDt = oBL.listarSistema
                'Instanciamos el reporte 
                oRepoDoc = New rptSistema

            Case 5 'Usuario
                Dim oBL As New C_USUARIO_BL
                oDt = oBL.ListarUsuario
                'Instanciamos el reporte 
                oRepoDoc = New rptUsuario

        End Select
        'Ver el Reporte
        oRepoDoc.SetDataSource(oDt)
        CrystalReportViewer1.ReportSource = oRepoDoc
        oDt.Clear()
    End Sub

    Private Sub PanelReporteVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerReporte(nReporte)
        'ver el titulo
        'lblTitulo.Text = TituloReporte.ToString
    End Sub
End Class