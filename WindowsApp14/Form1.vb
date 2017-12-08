Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.bolla_Query'. È possibile spostarla o rimuoverla se necessario.
        Me.Bolla_QueryTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla_Query)
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.bolla'. È possibile spostarla o rimuoverla se necessario.
        Me.BollaTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla)
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.bolla_Query'. È possibile spostarla o rimuoverla se necessario.
        Me.Bolla_QueryTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla_Query)
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.bolla'. È possibile spostarla o rimuoverla se necessario.
        Me.BollaTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla)


        data.Text = Module1.DataCorrente
        annobolla.Text = Module1.annobolla
        numerobolla.Text = 2200 'numero ultima bolla + 1 (da fare)




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            BollaBindingSource.EndEdit()
            BollaTableAdapter.Update(DatabaseRel2DataSet.bolla)

            Me.BollaTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla)
            Me.Bolla_QueryTableAdapter.Fill(Me.DatabaseRel2DataSet.bolla_Query)

        Catch ex As System.Data.OleDb.OleDbException
            MsgBox(“Si è verificato un errore: ” & ex.Message)
        End Try





    End Sub

    Private Sub BollaBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim SEARCH As Integer = TextBox1.Text
        'Dim SEARCH As STRING = "%" + TextBox1.Text + "%"

        Me.BollaTableAdapter.FillBySearch(DatabaseRel2DataSet.bolla, SEARCH)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Module1.Numerobolla = numerobolla.Text


        Form2.Show()
        Me.Close()





        'UserForm1.Hide


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
