Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DatabaseRel2DataSet.Utente'. È possibile spostarla o rimuoverla se necessario.
        Me.UtenteTableAdapter.Fill(Me.DatabaseRel2DataSet.Utente)

        data.Text = Module1.DataCorrente
        annobolla.Text = Module1.annobolla
        numerobolla.Text = Module1.Numerobolla

        Module1.bolla_codice_autista = ""



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Module1.bolla_codice_autista = cod_autista.Text
        Module1.bolla_cognome = cognome.Text
        ' va alla form3
        ' porta nella variabile il valore acquisito nella form esempio numero bolla
        'Module1.Numerobolla = numerobolla.Text


        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'torna alla home


        Form1.Show()
        Me.Close()
    End Sub

    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click


        If Len(cod_autista.Text) < 3 Then
            cod_autista.Text = Module1.codice_autista + "1"

        End If

        Module1.codice_autista = cod_autista.Text





    End Sub

    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click

        If Len(cod_autista.Text) < 3 Then
            cod_autista.Text = Module1.codice_autista + "2"

        End If


        Module1.codice_autista = cod_autista.Text
    End Sub

    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click


        If Len(cod_autista.Text) < 3 Then
            cod_autista.Text = Module1.codice_autista + "3"

        End If
        Module1.codice_autista = cod_autista.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cod_autista.Text = ""
        Module1.codice_autista = cod_autista.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Len(cod_autista.Text) < 3 Then
            cod_autista.Text = Module1.codice_autista + "0"



        End If
        Module1.codice_autista = cod_autista.Text
    End Sub

    Private Sub cod_autista_TextChanged(sender As Object, e As EventArgs) Handles cod_autista.TextChanged
        If cod_autista.Text <> "" Then
            Dim SEARCH2 As String = cod_autista.Text

            Me.UtenteTableAdapter.Fillcognome(DatabaseRel2DataSet.Utente, SEARCH2)

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles num5.Click

    End Sub
End Class