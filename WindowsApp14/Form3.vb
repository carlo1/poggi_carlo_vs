Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data.Text = Module1.DataCorrente
        annobolla.Text = Module1.annobolla
        numerobolla.Text = Module1.Numerobolla
        elenco_cod_autista.Text = Module1.bolla_codice_autista
        elenco_cognome.Text = Module1.bolla_cognome


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