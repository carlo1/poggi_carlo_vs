<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Db_allara_bollaDataSet = New bolla_touch_2.Db_allara_bollaDataSet()
        Me.TabbollaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_bollaTableAdapter = New bolla_touch_2.Db_allara_bollaDataSetTableAdapters.tab_bollaTableAdapter()
        Me.IDnumerobollaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BcodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CcodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FcodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesolordoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabbollaQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_bolla_QueryTableAdapter = New bolla_touch_2.Db_allara_bollaDataSetTableAdapters.tab_bolla_QueryTableAdapter()
        Me.IDnumerobollaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcognomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BragioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CragioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DdescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElocalitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesolordoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NettoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_allara_bollaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbollaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbollaQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 66)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDnumerobollaDataGridViewTextBoxColumn, Me.AnnoDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.OraDataGridViewTextBoxColumn, Me.AcodDataGridViewTextBoxColumn, Me.BcodDataGridViewTextBoxColumn, Me.CcodDataGridViewTextBoxColumn, Me.DcodDataGridViewTextBoxColumn, Me.EcodDataGridViewTextBoxColumn, Me.FcodDataGridViewTextBoxColumn, Me.PesolordoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabbollaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1273, 156)
        Me.DataGridView1.TabIndex = 2
        '
        'Db_allara_bollaDataSet
        '
        Me.Db_allara_bollaDataSet.DataSetName = "Db_allara_bollaDataSet"
        Me.Db_allara_bollaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabbollaBindingSource
        '
        Me.TabbollaBindingSource.DataMember = "tab_bolla"
        Me.TabbollaBindingSource.DataSource = Me.Db_allara_bollaDataSet
        '
        'Tab_bollaTableAdapter
        '
        Me.Tab_bollaTableAdapter.ClearBeforeFill = True
        '
        'IDnumerobollaDataGridViewTextBoxColumn
        '
        Me.IDnumerobollaDataGridViewTextBoxColumn.DataPropertyName = "ID_numero_bolla"
        Me.IDnumerobollaDataGridViewTextBoxColumn.HeaderText = "ID_numero_bolla"
        Me.IDnumerobollaDataGridViewTextBoxColumn.Name = "IDnumerobollaDataGridViewTextBoxColumn"
        '
        'AnnoDataGridViewTextBoxColumn
        '
        Me.AnnoDataGridViewTextBoxColumn.DataPropertyName = "anno"
        Me.AnnoDataGridViewTextBoxColumn.HeaderText = "anno"
        Me.AnnoDataGridViewTextBoxColumn.Name = "AnnoDataGridViewTextBoxColumn"
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'OraDataGridViewTextBoxColumn
        '
        Me.OraDataGridViewTextBoxColumn.DataPropertyName = "ora"
        Me.OraDataGridViewTextBoxColumn.HeaderText = "ora"
        Me.OraDataGridViewTextBoxColumn.Name = "OraDataGridViewTextBoxColumn"
        '
        'AcodDataGridViewTextBoxColumn
        '
        Me.AcodDataGridViewTextBoxColumn.DataPropertyName = "a_cod"
        Me.AcodDataGridViewTextBoxColumn.HeaderText = "a_cod"
        Me.AcodDataGridViewTextBoxColumn.Name = "AcodDataGridViewTextBoxColumn"
        '
        'BcodDataGridViewTextBoxColumn
        '
        Me.BcodDataGridViewTextBoxColumn.DataPropertyName = "b_cod"
        Me.BcodDataGridViewTextBoxColumn.HeaderText = "b_cod"
        Me.BcodDataGridViewTextBoxColumn.Name = "BcodDataGridViewTextBoxColumn"
        '
        'CcodDataGridViewTextBoxColumn
        '
        Me.CcodDataGridViewTextBoxColumn.DataPropertyName = "c_cod"
        Me.CcodDataGridViewTextBoxColumn.HeaderText = "c_cod"
        Me.CcodDataGridViewTextBoxColumn.Name = "CcodDataGridViewTextBoxColumn"
        '
        'DcodDataGridViewTextBoxColumn
        '
        Me.DcodDataGridViewTextBoxColumn.DataPropertyName = "d_cod"
        Me.DcodDataGridViewTextBoxColumn.HeaderText = "d_cod"
        Me.DcodDataGridViewTextBoxColumn.Name = "DcodDataGridViewTextBoxColumn"
        '
        'EcodDataGridViewTextBoxColumn
        '
        Me.EcodDataGridViewTextBoxColumn.DataPropertyName = "e_cod"
        Me.EcodDataGridViewTextBoxColumn.HeaderText = "e_cod"
        Me.EcodDataGridViewTextBoxColumn.Name = "EcodDataGridViewTextBoxColumn"
        '
        'FcodDataGridViewTextBoxColumn
        '
        Me.FcodDataGridViewTextBoxColumn.DataPropertyName = "f_cod"
        Me.FcodDataGridViewTextBoxColumn.HeaderText = "f_cod"
        Me.FcodDataGridViewTextBoxColumn.Name = "FcodDataGridViewTextBoxColumn"
        '
        'PesolordoDataGridViewTextBoxColumn
        '
        Me.PesolordoDataGridViewTextBoxColumn.DataPropertyName = "peso_lordo"
        Me.PesolordoDataGridViewTextBoxColumn.HeaderText = "peso_lordo"
        Me.PesolordoDataGridViewTextBoxColumn.Name = "PesolordoDataGridViewTextBoxColumn"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDnumerobollaDataGridViewTextBoxColumn1, Me.AnnoDataGridViewTextBoxColumn1, Me.DataDataGridViewTextBoxColumn1, Me.OraDataGridViewTextBoxColumn1, Me.AnomeDataGridViewTextBoxColumn, Me.AcognomeDataGridViewTextBoxColumn, Me.BtargaDataGridViewTextBoxColumn, Me.BtaraDataGridViewTextBoxColumn, Me.BragioneDataGridViewTextBoxColumn, Me.CragioneDataGridViewTextBoxColumn, Me.DdescrizioneDataGridViewTextBoxColumn, Me.EsitoDataGridViewTextBoxColumn, Me.ElocalitaDataGridViewTextBoxColumn, Me.FnomeDataGridViewTextBoxColumn, Me.PesolordoDataGridViewTextBoxColumn1, Me.NettoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TabbollaQueryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 291)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1705, 78)
        Me.DataGridView2.TabIndex = 3
        '
        'TabbollaQueryBindingSource
        '
        Me.TabbollaQueryBindingSource.DataMember = "tab_bolla_Query"
        Me.TabbollaQueryBindingSource.DataSource = Me.Db_allara_bollaDataSet
        '
        'Tab_bolla_QueryTableAdapter
        '
        Me.Tab_bolla_QueryTableAdapter.ClearBeforeFill = True
        '
        'IDnumerobollaDataGridViewTextBoxColumn1
        '
        Me.IDnumerobollaDataGridViewTextBoxColumn1.DataPropertyName = "ID_numero_bolla"
        Me.IDnumerobollaDataGridViewTextBoxColumn1.HeaderText = "ID_numero_bolla"
        Me.IDnumerobollaDataGridViewTextBoxColumn1.Name = "IDnumerobollaDataGridViewTextBoxColumn1"
        '
        'AnnoDataGridViewTextBoxColumn1
        '
        Me.AnnoDataGridViewTextBoxColumn1.DataPropertyName = "anno"
        Me.AnnoDataGridViewTextBoxColumn1.HeaderText = "anno"
        Me.AnnoDataGridViewTextBoxColumn1.Name = "AnnoDataGridViewTextBoxColumn1"
        '
        'DataDataGridViewTextBoxColumn1
        '
        Me.DataDataGridViewTextBoxColumn1.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn1.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn1.Name = "DataDataGridViewTextBoxColumn1"
        '
        'OraDataGridViewTextBoxColumn1
        '
        Me.OraDataGridViewTextBoxColumn1.DataPropertyName = "ora"
        Me.OraDataGridViewTextBoxColumn1.HeaderText = "ora"
        Me.OraDataGridViewTextBoxColumn1.Name = "OraDataGridViewTextBoxColumn1"
        '
        'AnomeDataGridViewTextBoxColumn
        '
        Me.AnomeDataGridViewTextBoxColumn.DataPropertyName = "a_nome"
        Me.AnomeDataGridViewTextBoxColumn.HeaderText = "a_nome"
        Me.AnomeDataGridViewTextBoxColumn.Name = "AnomeDataGridViewTextBoxColumn"
        '
        'AcognomeDataGridViewTextBoxColumn
        '
        Me.AcognomeDataGridViewTextBoxColumn.DataPropertyName = "a_cognome"
        Me.AcognomeDataGridViewTextBoxColumn.HeaderText = "a_cognome"
        Me.AcognomeDataGridViewTextBoxColumn.Name = "AcognomeDataGridViewTextBoxColumn"
        '
        'BtargaDataGridViewTextBoxColumn
        '
        Me.BtargaDataGridViewTextBoxColumn.DataPropertyName = "b_targa"
        Me.BtargaDataGridViewTextBoxColumn.HeaderText = "b_targa"
        Me.BtargaDataGridViewTextBoxColumn.Name = "BtargaDataGridViewTextBoxColumn"
        '
        'BtaraDataGridViewTextBoxColumn
        '
        Me.BtaraDataGridViewTextBoxColumn.DataPropertyName = "b_tara"
        Me.BtaraDataGridViewTextBoxColumn.HeaderText = "b_tara"
        Me.BtaraDataGridViewTextBoxColumn.Name = "BtaraDataGridViewTextBoxColumn"
        '
        'BragioneDataGridViewTextBoxColumn
        '
        Me.BragioneDataGridViewTextBoxColumn.DataPropertyName = "b_ragione"
        Me.BragioneDataGridViewTextBoxColumn.HeaderText = "b_ragione"
        Me.BragioneDataGridViewTextBoxColumn.Name = "BragioneDataGridViewTextBoxColumn"
        '
        'CragioneDataGridViewTextBoxColumn
        '
        Me.CragioneDataGridViewTextBoxColumn.DataPropertyName = "c_ragione"
        Me.CragioneDataGridViewTextBoxColumn.HeaderText = "c_ragione"
        Me.CragioneDataGridViewTextBoxColumn.Name = "CragioneDataGridViewTextBoxColumn"
        '
        'DdescrizioneDataGridViewTextBoxColumn
        '
        Me.DdescrizioneDataGridViewTextBoxColumn.DataPropertyName = "d_descrizione"
        Me.DdescrizioneDataGridViewTextBoxColumn.HeaderText = "d_descrizione"
        Me.DdescrizioneDataGridViewTextBoxColumn.Name = "DdescrizioneDataGridViewTextBoxColumn"
        '
        'EsitoDataGridViewTextBoxColumn
        '
        Me.EsitoDataGridViewTextBoxColumn.DataPropertyName = "e_sito"
        Me.EsitoDataGridViewTextBoxColumn.HeaderText = "e_sito"
        Me.EsitoDataGridViewTextBoxColumn.Name = "EsitoDataGridViewTextBoxColumn"
        '
        'ElocalitaDataGridViewTextBoxColumn
        '
        Me.ElocalitaDataGridViewTextBoxColumn.DataPropertyName = "e_localita"
        Me.ElocalitaDataGridViewTextBoxColumn.HeaderText = "e_localita"
        Me.ElocalitaDataGridViewTextBoxColumn.Name = "ElocalitaDataGridViewTextBoxColumn"
        '
        'FnomeDataGridViewTextBoxColumn
        '
        Me.FnomeDataGridViewTextBoxColumn.DataPropertyName = "f_nome"
        Me.FnomeDataGridViewTextBoxColumn.HeaderText = "f_nome"
        Me.FnomeDataGridViewTextBoxColumn.Name = "FnomeDataGridViewTextBoxColumn"
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
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 51)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Opzioni"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1596, 558)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_allara_bollaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbollaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbollaQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Db_allara_bollaDataSet As Db_allara_bollaDataSet
    Friend WithEvents TabbollaBindingSource As BindingSource
    Friend WithEvents Tab_bollaTableAdapter As Db_allara_bollaDataSetTableAdapters.tab_bollaTableAdapter
    Friend WithEvents IDnumerobollaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BcodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CcodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DcodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EcodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FcodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesolordoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabbollaQueryBindingSource As BindingSource
    Friend WithEvents Tab_bolla_QueryTableAdapter As Db_allara_bollaDataSetTableAdapters.tab_bolla_QueryTableAdapter
    Friend WithEvents IDnumerobollaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AnnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AnomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcognomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtaraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BragioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CragioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DdescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ElocalitaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesolordoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NettoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
