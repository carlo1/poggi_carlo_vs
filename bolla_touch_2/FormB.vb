Public Class FormB
    Private Sub FormB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'Db_allara_bollaDataSet.b_tab_mezzo'. È possibile spostarla o rimuoverla se necessario.
        Me.B_tab_mezzoTableAdapter.Fill(Me.Db_allara_bollaDataSet.b_tab_mezzo)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        opzioni.Show()
        Close()

    End Sub
End Class