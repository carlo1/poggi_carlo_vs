Module Module1
    'Public numero1 As Integer


    Public DataCorrente As String = Format(Date.Today, "dd/MM/yyyy") 'formato data
    Public Numerobolla As Integer
    Public annobolla As String = Format(Date.Today, "yyyy") 'formato data

    Public codice_autista As String = Form2.cod_autista.Text
    Public bolla_cognome As String
    Public bolla_codice_autista As String


    ' ORA DA USARE ALLA FINE
    ' Public OraCorrente As String = Format(DateTime.Now, "HH:mm") 'formato ora
End Module
