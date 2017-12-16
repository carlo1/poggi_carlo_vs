Imports System.Drawing.Printing

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




        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Try
            AtabautistaBindingSource.EndEdit()
            A_tab_autistaTableAdapter.Update(Db_allara_bollaDataSet.a_tab_autista)
            Me.A_tab_autistaTableAdapter.Fill(Me.Db_allara_bollaDataSet.a_tab_autista)


        Catch ex As System.Data.ConstraintException
            MsgBox(“IL CODICE AUTISTA E' GIA PRESENTE , INSERIRE UN CODICE DIVERSO !!! ”)

            Me.A_tab_autistaTableAdapter.Fill(Me.Db_allara_bollaDataSet.a_tab_autista)
        End Try






    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AtabautistaBindingSource.AddNew()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox5.TextChanged

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub TextBoxCERCA_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCERCA.TextChanged
        A_tab_autistaTableAdapter.FillByRICERCANOMECOGNOME(Db_allara_bollaDataSet.a_tab_autista, TextBoxCERCA.Text)
    End Sub


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.A_tab_autistaTableAdapter.Fill(Me.Db_allara_bollaDataSet.a_tab_autista)

        '  TextBoxCERCA.Text = ""

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ReportViewer1.Visible = True

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        ReportViewer1.PrintDialog()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        C1QRCode1.Text = TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + "#"
        Label13.Text = TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + "#"
        TextBox6.Select()

    End Sub

    Private Sub C1QRCode1_Click(sender As Object, e As EventArgs) Handles C1QRCode1.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


        Dim qcode() As String
        qcode = Split(Label13.Text, ",")

        Label9.Text = qcode(0)
        Label10.Text = qcode(1)
        Label11.Text = qcode(2)




    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        '  TextBox1.TextChanged()
        Dim str As String
        str = TextBox6.Text
        If str.IndexOf("#") <> -1 Then
            Dim qcode() As String
            qcode = Split(Label13.Text, ",")

            Label9.Text = qcode(0)
            Label10.Text = qcode(1)
            Label11.Text = qcode(2)


            TextBox6.Text = ""
            TextBox6.Select()
            '  MsgBox("cambio il valore")
            '  TextBox1.Text = Replace(TextBox1.Text, "@", "_")
            '  TextBox1.SelectionStart = TextBox1.TextLength
        End If




    End Sub

    Private Sub TextBox6_TextAlignChanged(sender As Object, e As EventArgs) Handles TextBox6.TextAlignChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim qcode() As String
        qcode = Split(TextBox6.Text, ",")

        Label9.Text = qcode(0)
        Label10.Text = qcode(1)
        Label11.Text = qcode(2)
        TextBox6.Text = ""
        TextBox6.Select()

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        '  Comando copia tutto


        Clipboard.Clear() 'cancella appunti
        Clipboard.SetText(TextBox3.Text)
        'inserimento testo negli appunti

        ' Comando incolla tutto


        '    Testo.Text = "" 'eliminazione testo destinazione
        '   Testo.Text = Clipboard.GetText 'inserimento testo dagli appunti

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox6.Text = ""
        TextBox6.Text = Clipboard.GetText

    End Sub
End Class