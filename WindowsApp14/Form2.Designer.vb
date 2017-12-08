<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numerobolla = New System.Windows.Forms.Label()
        Me.annobolla = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cod_autista = New System.Windows.Forms.TextBox()
        Me.num1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.num2 = New System.Windows.Forms.Button()
        Me.num3 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.UtenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseRel2DataSet = New WindowsApp14.DatabaseRel2DataSet()
        Me.UtenteTableAdapter = New WindowsApp14.DatabaseRel2DataSetTableAdapters.UtenteTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CognomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodutenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtenteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cognome = New System.Windows.Forms.Label()
        Me.num5 = New System.Windows.Forms.Button()
        Me.num4 = New System.Windows.Forms.Button()
        Me.num6 = New System.Windows.Forms.Button()
        Me.num7 = New System.Windows.Forms.Button()
        Me.num8 = New System.Windows.Forms.Button()
        Me.num9 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseRel2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtenteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(450, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codice Autista"
        '
        'numerobolla
        '
        Me.numerobolla.AutoSize = True
        Me.numerobolla.Location = New System.Drawing.Point(26, 109)
        Me.numerobolla.Name = "numerobolla"
        Me.numerobolla.Size = New System.Drawing.Size(13, 13)
        Me.numerobolla.TabIndex = 7
        Me.numerobolla.Text = "0"
        '
        'annobolla
        '
        Me.annobolla.AutoSize = True
        Me.annobolla.Location = New System.Drawing.Point(26, 66)
        Me.annobolla.Name = "annobolla"
        Me.annobolla.Size = New System.Drawing.Size(31, 13)
        Me.annobolla.TabIndex = 8
        Me.annobolla.Text = "anno"
        '
        'data
        '
        Me.data.AutoSize = True
        Me.data.Location = New System.Drawing.Point(26, 33)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(67, 13)
        Me.data.TabIndex = 9
        Me.data.Text = "datacorrente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(781, 640)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 86)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Conferma"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(29, 741)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 94)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cod_autista
        '
        Me.cod_autista.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_autista.Location = New System.Drawing.Point(721, 65)
        Me.cod_autista.MaxLength = 3
        Me.cod_autista.Name = "cod_autista"
        Me.cod_autista.Size = New System.Drawing.Size(258, 65)
        Me.cod_autista.TabIndex = 14
        Me.cod_autista.Text = "0"
        Me.cod_autista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num1
        '
        Me.num1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.ForeColor = System.Drawing.Color.Gray
        Me.num1.Location = New System.Drawing.Point(527, 222)
        Me.num1.Name = "num1"
        Me.num1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num1.Size = New System.Drawing.Size(105, 98)
        Me.num1.TabIndex = 15
        Me.num1.Text = "1"
        Me.num1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp14.My.Resources.Resources.MAN3
        Me.PictureBox2.Location = New System.Drawing.Point(1012, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(236, 252)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.WindowsApp14.My.Resources.Resources.elenco_2
        Me.PictureBox1.Location = New System.Drawing.Point(1427, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 747)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'num2
        '
        Me.num2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.ForeColor = System.Drawing.Color.Gray
        Me.num2.Location = New System.Drawing.Point(651, 222)
        Me.num2.Name = "num2"
        Me.num2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num2.Size = New System.Drawing.Size(105, 98)
        Me.num2.TabIndex = 16
        Me.num2.Text = "2"
        Me.num2.UseVisualStyleBackColor = True
        '
        'num3
        '
        Me.num3.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num3.ForeColor = System.Drawing.Color.Gray
        Me.num3.Location = New System.Drawing.Point(781, 222)
        Me.num3.Name = "num3"
        Me.num3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num3.Size = New System.Drawing.Size(105, 98)
        Me.num3.TabIndex = 17
        Me.num3.Text = "3"
        Me.num3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(482, 640)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(247, 86)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "ANNULLA"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gray
        Me.Button4.Location = New System.Drawing.Point(914, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(105, 98)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "0"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'UtenteBindingSource
        '
        Me.UtenteBindingSource.DataMember = "Utente"
        Me.UtenteBindingSource.DataSource = Me.DatabaseRel2DataSet
        '
        'DatabaseRel2DataSet
        '
        Me.DatabaseRel2DataSet.DataSetName = "DatabaseRel2DataSet"
        Me.DatabaseRel2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtenteTableAdapter
        '
        Me.UtenteTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.CognomeDataGridViewTextBoxColumn, Me.EtaDataGridViewTextBoxColumn, Me.CodutenteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UtenteBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(746, 741)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(616, 122)
        Me.DataGridView1.TabIndex = 21
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'EtaDataGridViewTextBoxColumn
        '
        Me.EtaDataGridViewTextBoxColumn.DataPropertyName = "eta"
        Me.EtaDataGridViewTextBoxColumn.HeaderText = "eta"
        Me.EtaDataGridViewTextBoxColumn.Name = "EtaDataGridViewTextBoxColumn"
        '
        'CodutenteDataGridViewTextBoxColumn
        '
        Me.CodutenteDataGridViewTextBoxColumn.DataPropertyName = "cod_utente"
        Me.CodutenteDataGridViewTextBoxColumn.HeaderText = "cod_utente"
        Me.CodutenteDataGridViewTextBoxColumn.Name = "CodutenteDataGridViewTextBoxColumn"
        '
        'UtenteBindingSource1
        '
        Me.UtenteBindingSource1.DataMember = "Utente"
        Me.UtenteBindingSource1.DataSource = Me.DatabaseRel2DataSet
        '
        'cognome
        '
        Me.cognome.AutoSize = True
        Me.cognome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtenteBindingSource1, "cognome", True))
        Me.cognome.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cognome.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cognome.Location = New System.Drawing.Point(524, 158)
        Me.cognome.Name = "cognome"
        Me.cognome.Size = New System.Drawing.Size(124, 45)
        Me.cognome.TabIndex = 22
        Me.cognome.Text = "Label2"
        '
        'num5
        '
        Me.num5.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num5.ForeColor = System.Drawing.Color.Gray
        Me.num5.Location = New System.Drawing.Point(651, 339)
        Me.num5.Name = "num5"
        Me.num5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num5.Size = New System.Drawing.Size(105, 98)
        Me.num5.TabIndex = 23
        Me.num5.Text = "5"
        Me.num5.UseVisualStyleBackColor = True
        '
        'num4
        '
        Me.num4.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num4.ForeColor = System.Drawing.Color.Gray
        Me.num4.Location = New System.Drawing.Point(527, 339)
        Me.num4.Name = "num4"
        Me.num4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num4.Size = New System.Drawing.Size(105, 98)
        Me.num4.TabIndex = 24
        Me.num4.Text = "4"
        Me.num4.UseVisualStyleBackColor = True
        '
        'num6
        '
        Me.num6.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num6.ForeColor = System.Drawing.Color.Gray
        Me.num6.Location = New System.Drawing.Point(781, 339)
        Me.num6.Name = "num6"
        Me.num6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num6.Size = New System.Drawing.Size(105, 98)
        Me.num6.TabIndex = 25
        Me.num6.Text = "6"
        Me.num6.UseVisualStyleBackColor = True
        '
        'num7
        '
        Me.num7.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num7.ForeColor = System.Drawing.Color.Gray
        Me.num7.Location = New System.Drawing.Point(527, 464)
        Me.num7.Name = "num7"
        Me.num7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num7.Size = New System.Drawing.Size(105, 98)
        Me.num7.TabIndex = 26
        Me.num7.Text = "7"
        Me.num7.UseVisualStyleBackColor = True
        '
        'num8
        '
        Me.num8.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num8.ForeColor = System.Drawing.Color.Gray
        Me.num8.Location = New System.Drawing.Point(651, 464)
        Me.num8.Name = "num8"
        Me.num8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num8.Size = New System.Drawing.Size(105, 98)
        Me.num8.TabIndex = 27
        Me.num8.Text = "8"
        Me.num8.UseVisualStyleBackColor = True
        '
        'num9
        '
        Me.num9.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num9.ForeColor = System.Drawing.Color.Gray
        Me.num9.Location = New System.Drawing.Point(781, 464)
        Me.num9.Name = "num9"
        Me.num9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num9.Size = New System.Drawing.Size(105, 98)
        Me.num9.TabIndex = 28
        Me.num9.Text = "9"
        Me.num9.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1596, 873)
        Me.Controls.Add(Me.num9)
        Me.Controls.Add(Me.num8)
        Me.Controls.Add(Me.num7)
        Me.Controls.Add(Me.num6)
        Me.Controls.Add(Me.num4)
        Me.Controls.Add(Me.num5)
        Me.Controls.Add(Me.cognome)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.cod_autista)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numerobolla)
        Me.Controls.Add(Me.annobolla)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseRel2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtenteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numerobolla As Label
    Friend WithEvents annobolla As Label
    Friend WithEvents data As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cod_autista As TextBox
    Friend WithEvents num1 As Button
    Friend WithEvents num2 As Button
    Friend WithEvents num3 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DatabaseRel2DataSet As DatabaseRel2DataSet
    Friend WithEvents UtenteBindingSource As BindingSource
    Friend WithEvents UtenteTableAdapter As DatabaseRel2DataSetTableAdapters.UtenteTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CognomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodutenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UtenteBindingSource1 As BindingSource
    Friend WithEvents cognome As Label
    Friend WithEvents num5 As Button
    Friend WithEvents num4 As Button
    Friend WithEvents num6 As Button
    Friend WithEvents num7 As Button
    Friend WithEvents num8 As Button
    Friend WithEvents num9 As Button
End Class
