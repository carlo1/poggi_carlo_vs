'Imports Microsoft.Reporting.WinForms

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.bolla_Query'. È possibile spostarla o rimuoverla se necessario.
        Me.bolla_QueryTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla_Query)
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.bolla'. È possibile spostarla o rimuoverla se necessario.
        Me.bollaTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla)
        data.Text = Module1.DataCorrente
        annobolla.Text = Module1.annobolla
        numerobolla.Text = Module1.Numerobolla
        elenco_cod_autista.Text = Module1.bolla_codice_autista
        elenco_cognome.Text = Module1.bolla_cognome

        ' Dim esp_report_bolla As New ReportParameter("Report_numero_bolla", numerobolla.Text)






        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("da fare")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'torna alla home


        Form1.Show()
        Me.Close()
    End Sub
End Class