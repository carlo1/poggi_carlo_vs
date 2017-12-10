<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bolla_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseRel2DataSet = New WindowsApp14.DatabaseRel2DataSet()
        Me.numerobolla = New System.Windows.Forms.Label()
        Me.annobolla = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.elenco_cod_autista = New System.Windows.Forms.Label()
        Me.elenco_cognome = New System.Windows.Forms.Label()
        Me.bollaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bollaTableAdapter = New WindowsApp14.DatabaseRel2DataSetTableAdapters.bollaTableAdapter()
        Me.bolla_QueryTableAdapter = New WindowsApp14.DatabaseRel2DataSetTableAdapters.bolla_QueryTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.bolla_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseRel2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bollaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bolla_QueryBindingSource
        '
        Me.bolla_QueryBindingSource.DataMember = "bolla Query"
        Me.bolla_QueryBindingSource.DataSource = Me.DatabaseRel2DataSet
        '
        'DatabaseRel2DataSet
        '
        Me.DatabaseRel2DataSet.DataSetName = "DatabaseRel2DataSet"
        Me.DatabaseRel2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numerobolla
        '
        Me.numerobolla.AutoSize = True
        Me.numerobolla.Location = New System.Drawing.Point(23, 102)
        Me.numerobolla.Name = "numerobolla"
        Me.numerobolla.Size = New System.Drawing.Size(13, 13)
        Me.numerobolla.TabIndex = 7
        Me.numerobolla.Text = "0"
        '
        'annobolla
        '
        Me.annobolla.AutoSize = True
        Me.annobolla.Location = New System.Drawing.Point(23, 59)
        Me.annobolla.Name = "annobolla"
        Me.annobolla.Size = New System.Drawing.Size(31, 13)
        Me.annobolla.TabIndex = 8
        Me.annobolla.Text = "anno"
        '
        'data
        '
        Me.data.AutoSize = True
        Me.data.Location = New System.Drawing.Point(23, 26)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(67, 13)
        Me.data.TabIndex = 9
        Me.data.Text = "datacorrente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp14.My.Resources.Resources.elenco_3
        Me.PictureBox1.Location = New System.Drawing.Point(1439, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 782)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(524, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 94)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(846, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 86)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Conferma"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'elenco_cod_autista
        '
        Me.elenco_cod_autista.AutoSize = True
        Me.elenco_cod_autista.Location = New System.Drawing.Point(23, 141)
        Me.elenco_cod_autista.Name = "elenco_cod_autista"
        Me.elenco_cod_autista.Size = New System.Drawing.Size(62, 13)
        Me.elenco_cod_autista.TabIndex = 16
        Me.elenco_cod_autista.Text = "cod_autista"
        '
        'elenco_cognome
        '
        Me.elenco_cognome.AutoSize = True
        Me.elenco_cognome.Location = New System.Drawing.Point(22, 173)
        Me.elenco_cognome.Name = "elenco_cognome"
        Me.elenco_cognome.Size = New System.Drawing.Size(51, 13)
        Me.elenco_cognome.TabIndex = 17
        Me.elenco_cognome.Text = "cognome"
        '
        'bollaBindingSource
        '
        Me.bollaBindingSource.DataMember = "bolla"
        Me.bollaBindingSource.DataSource = Me.DatabaseRel2DataSet
        '
        'bollaTableAdapter
        '
        Me.bollaTableAdapter.ClearBeforeFill = True
        '
        'bolla_QueryTableAdapter
        '
        Me.bolla_QueryTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.bolla_QueryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApp14.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(162, 26)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(582, 269)
        Me.ReportViewer2.TabIndex = 19
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1596, 861)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.elenco_cognome)
        Me.Controls.Add(Me.elenco_cod_autista)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.numerobolla)
        Me.Controls.Add(Me.annobolla)
        Me.Controls.Add(Me.data)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bolla_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseRel2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bollaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numerobolla As Label
    Friend WithEvents annobolla As Label
    Friend WithEvents data As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents elenco_cod_autista As Label
    Friend WithEvents elenco_cognome As Label
    Friend WithEvents bollaBindingSource As BindingSource
    Friend WithEvents DatabaseRel2DataSet As DatabaseRel2DataSet
    Friend WithEvents bollaTableAdapter As DatabaseRel2DataSetTableAdapters.bollaTableAdapter
    Friend WithEvents bolla_QueryBindingSource As BindingSource
    Friend WithEvents bolla_QueryTableAdapter As DatabaseRel2DataSetTableAdapters.bolla_QueryTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
