Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'Db_allara_bollaDataSet.tab_bolla_Query'. È possibile spostarla o rimuoverla se necessario.
        Me.Tab_bolla_QueryTableAdapter.Fill(Me.Db_allara_bollaDataSet.tab_bolla_Query)
        'TODO: questa riga di codice carica i dati nella tabella 'Db_allara_bollaDataSet.tab_bolla'. È possibile spostarla o rimuoverla se necessario.
        Me.Tab_bollaTableAdapter.Fill(Me.Db_allara_bollaDataSet.tab_bolla)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabbollaBindingSource.EndEdit()
        Tab_bollaTableAdapter.Update(Db_allara_bollaDataSet.tab_bolla)
        Me.Tab_bollaTableAdapter.Fill(Me.Db_allara_bollaDataSet.tab_bolla)
        Me.Tab_bolla_QueryTableAdapter.Fill(Me.Db_allara_bollaDataSet.tab_bolla_Query)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        opzioni.Show()
        Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormSFONDO.Show()
        Close()

    End Sub
End Class
