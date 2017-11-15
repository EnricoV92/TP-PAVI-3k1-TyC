Imports Microsoft.Reporting.WinForms
Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Torneos._Torneos' Puede moverla o quitarla según sea necesario.
        Me.TorneosTableAdapter1.getTorneos(Me.Torneos._Torneos)
        cbo_torneos.SelectedValue = -1
        'TODO: esta línea de código carga datos en la tabla 'reporteTorneo1.Torneos' Puede moverla o quitarla según sea necesario.
        'Me.TorneosTableAdapter.verPartidosxFechas(Me.reporteTorneo1.Torneos)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cbo_torneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_torneos.SelectedIndexChanged
        rpv_fechas.LocalReport.SetParameters({New ReportParameter("nombreTorneo", cbo_torneos.Text.ToString)})
        Me.TorneosTableAdapter.verFechasconTorneoParametro(Me.reporteTorneo1.Torneos, cbo_torneos.SelectedValue)
        Me.rpv_fechas.RefreshReport()
    End Sub

    Private Sub btn_verTorneos_Click(sender As Object, e As EventArgs) Handles btn_verTorneos.Click
        'Me.TorneosTableAdapter.verPartidosxFechas(Me.reporteTorneo1.Torneos)
        'Me.rpv_fechas.RefreshReport()
    End Sub
End Class