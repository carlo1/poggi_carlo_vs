Public Class FormA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        opzioni.Show()
        Close()

    End Sub

    Private Sub FormA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'Db_allara_bollaDataSet.a_tab_autista'. È possibile spostarla o rimuoverla se necessario.
        Me.A_tab_autistaTableAdapter.Fill(Me.Db_allara_bollaDataSet.a_tab_autista)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class