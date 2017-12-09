<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BollaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodutenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodmezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesolordoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BollaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseRel2DataSet = New WindowsApp14.DatabaseRel2DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BollaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DittaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PortataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CognomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesolordoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NettoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BollaQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.data = New System.Windows.Forms.Label()
        Me.annobolla = New System.Windows.Forms.Label()
        Me.numerobolla = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BollaTableAdapter = New WindowsApp14.DatabaseRel2DataSetTableAdapters.bollaTableAdapter()
        Me.Bolla_QueryTableAdapter = New WindowsApp14.DatabaseRel2DataSetTableAdapters.bolla_QueryTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BollaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseRel2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BollaQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BollaDataGridViewTextBoxColumn, Me.CodutenteDataGridViewTextBoxColumn, Me.CodmezzoDataGridViewTextBoxColumn, Me.PesolordoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BollaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(577, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(583, 128)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BollaDataGridViewTextBoxColumn
        '
        Me.BollaDataGridViewTextBoxColumn.DataPropertyName = "bolla"
        Me.BollaDataGridViewTextBoxColumn.HeaderText = "bolla"
        Me.BollaDataGridViewTextBoxColumn.Name = "BollaDataGridViewTextBoxColumn"
        '
        'CodutenteDataGridViewTextBoxColumn
        '
        Me.CodutenteDataGridViewTextBoxColumn.DataPropertyName = "cod_utente"
        Me.CodutenteDataGridViewTextBoxColumn.HeaderText = "cod_utente"
        Me.CodutenteDataGridViewTextBoxColumn.Name = "CodutenteDataGridViewTextBoxColumn"
        '
        'CodmezzoDataGridViewTextBoxColumn
        '
        Me.CodmezzoDataGridViewTextBoxColumn.DataPropertyName = "cod_mezzo"
        Me.CodmezzoDataGridViewTextBoxColumn.HeaderText = "cod_mezzo"
        Me.CodmezzoDataGridViewTextBoxColumn.Name = "CodmezzoDataGridViewTextBoxColumn"
        '
        'PesolordoDataGridViewTextBoxColumn
        '
        Me.PesolordoDataGridViewTextBoxColumn.DataPropertyName = "peso_lordo"
        Me.PesolordoDataGridViewTextBoxColumn.HeaderText = "peso_lordo"
        Me.PesolordoDataGridViewTextBoxColumn.Name = "PesolordoDataGridViewTextBoxColumn"
        '
        'BollaBindingSource
        '
        Me.BollaBindingSource.DataMember = "bolla"
        Me.BollaBindingSource.DataSource = Me.DatabaseRel2DataSet
        '
        'DatabaseRel2DataSet
        '
        Me.DatabaseRel2DataSet.DataSetName = "DatabaseRel2DataSet"
        Me.DatabaseRel2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1197, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BollaDataGridViewTextBoxColumn1, Me.TargaDataGridViewTextBoxColumn, Me.DittaDataGridViewTextBoxColumn, Me.PortataDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.CognomeDataGridViewTextBoxColumn, Me.PesolordoDataGridViewTextBoxColumn1, Me.NettoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BollaQueryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(577, 194)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(840, 123)
        Me.DataGridView2.TabIndex = 2
        '
        'BollaDataGridViewTextBoxColumn1
        '
        Me.BollaDataGridViewTextBoxColumn1.DataPropertyName = "bolla"
        Me.BollaDataGridViewTextBoxColumn1.HeaderText = "bolla"
        Me.BollaDataGridViewTextBoxColumn1.Name = "BollaDataGridViewTextBoxColumn1"
        '
        'TargaDataGridViewTextBoxColumn
        '
        Me.TargaDataGridViewTextBoxColumn.DataPropertyName = "targa"
        Me.TargaDataGridViewTextBoxColumn.HeaderText = "targa"
        Me.TargaDataGridViewTextBoxColumn.Name = "TargaDataGridViewTextBoxColumn"
        '
        'DittaDataGridViewTextBoxColumn
        '
        Me.DittaDataGridViewTextBoxColumn.DataPropertyName = "ditta"
        Me.DittaDataGridViewTextBoxColumn.HeaderText = "ditta"
        Me.DittaDataGridViewTextBoxColumn.Name = "DittaDataGridViewTextBoxColumn"
        '
        'PortataDataGridViewTextBoxColumn
        '
        Me.PortataDataGridViewTextBoxColumn.DataPropertyName = "portata"
        Me.PortataDataGridViewTextBoxColumn.HeaderText = "portata"
        Me.PortataDataGridViewTextBoxColumn.Name = "PortataDataGridViewTextBoxColumn"
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'CognomeDataGridViewTextBoxColumn
        '
        Me.CognomeDataGridViewTextBoxColumn.DataPropertyName = "cognome"
        Me.CognomeDataGridViewTextBoxColumn.HeaderText = "cognome"
        Me.CognomeDataGridViewTextBoxColumn.Name = "CognomeDataGridViewTextBoxColumn"
        '
        'PesolordoDataGridViewTextBoxColumn1
        '
        Me.PesolordoDataGridViewTextBoxColumn1.DataPropertyName = "peso_lordo"
        Me.PesolordoDataGridViewTextBoxColumn1.HeaderText = "peso_lordo"
        Me.PesolordoDataGridViewTextBoxColumn1.Name = "PesolordoDataGridViewTextBoxColumn1"
        '
        'NettoDataGridViewTextBoxColumn
        '
        Me.NettoDataGridViewTextBoxColumn.DataPropertyName = "netto"
        Me.NettoDataGridViewTextBoxColumn.HeaderText = "netto"
        Me.NettoDataGridViewTextBoxColumn.Name = "NettoDataGridViewTextBoxColumn"
        Me.NettoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BollaQueryBindingSource
        '
        Me.BollaQueryBindingSource.DataMember = "bolla Query"
        Me.BollaQueryBindingSource.DataSource = Me.DatabaseRel2DataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(859, 323)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(112, 194)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(336, 102)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Inizia Bolla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'data
        '
        Me.data.AutoSize = True
        Me.data.Location = New System.Drawing.Point(54, 30)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(67, 13)
        Me.data.TabIndex = 6
        Me.data.Text = "datacorrente"
        '
        'annobolla
        '
        Me.annobolla.AutoSize = True
        Me.annobolla.Location = New System.Drawing.Point(54, 63)
        Me.annobolla.Name = "annobolla"
        Me.annobolla.Size = New System.Drawing.Size(31, 13)
        Me.annobolla.TabIndex = 6
        Me.annobolla.Text = "anno"
        '
        'numerobolla
        '
        Me.numerobolla.AutoSize = True
        Me.numerobolla.Location = New System.Drawing.Point(54, 106)
        Me.numerobolla.Name = "numerobolla"
        Me.numerobolla.Size = New System.Drawing.Size(13, 13)
        Me.numerobolla.TabIndex = 6
        Me.numerobolla.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp14.My.Resources.Resources.elenco_1
        Me.PictureBox1.Location = New System.Drawing.Point(1439, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 782)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BollaTableAdapter
        '
        Me.BollaTableAdapter.ClearBeforeFill = True
        '
        'Bolla_QueryTableAdapter
        '
        Me.Bolla_QueryTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 56)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1588, 861)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.numerobolla)
        Me.Controls.Add(Me.annobolla)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BollaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseRel2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BollaQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents data As Label
    Friend WithEvents annobolla As Label
    Friend WithEvents numerobolla As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DatabaseRel2DataSet As DatabaseRel2DataSet
    Friend WithEvents BollaTableAdapter As DatabaseRel2DataSetTableAdapters.bollaTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BollaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodutenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodmezzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesolordoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BollaBindingSource As BindingSource
    Friend WithEvents BollaQueryBindingSource As BindingSource
    Friend WithEvents Bolla_QueryTableAdapter As DatabaseRel2DataSetTableAdapters.bolla_QueryTableAdapter
    Friend WithEvents BollaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DittaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PortataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CognomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesolordoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NettoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
