<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormB))
        Me.C1FlexGridClassic1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Db_allara_bollaDataSet = New bolla_touch_2.Db_allara_bollaDataSet()
        Me.BtabmezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_tab_mezzoTableAdapter = New bolla_touch_2.Db_allara_bollaDataSetTableAdapters.b_tab_mezzoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_allara_bollaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtabmezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGridClassic1
        '
        Me.C1FlexGridClassic1.AllowAddNew = True
        Me.C1FlexGridClassic1.AllowDelete = True
        Me.C1FlexGridClassic1.AllowFiltering = True
        Me.C1FlexGridClassic1.BackColor = System.Drawing.Color.White
        Me.C1FlexGridClassic1.BackColorAlternate = System.Drawing.Color.White
        Me.C1FlexGridClassic1.BackColorBkg = System.Drawing.Color.Ivory
        Me.C1FlexGridClassic1.BackColorFixed = System.Drawing.Color.CadetBlue
        Me.C1FlexGridClassic1.BackColorSel = System.Drawing.Color.Wheat
        Me.C1FlexGridClassic1.Cols = 18
        Me.C1FlexGridClassic1.ColumnInfo = resources.GetString("C1FlexGridClassic1.ColumnInfo")
        Me.C1FlexGridClassic1.DataSource = Me.BtabmezzoBindingSource
        Me.C1FlexGridClassic1.Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
        Me.C1FlexGridClassic1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGridClassic1.ForeColor = System.Drawing.Color.Gray
        Me.C1FlexGridClassic1.ForeColorFixed = System.Drawing.Color.Black
        Me.C1FlexGridClassic1.ForeColorSel = System.Drawing.Color.DarkSlateBlue
        Me.C1FlexGridClassic1.GridColor = System.Drawing.Color.Wheat
        Me.C1FlexGridClassic1.GridColorFixed = System.Drawing.Color.Black
        Me.C1FlexGridClassic1.Location = New System.Drawing.Point(39, 236)
        Me.C1FlexGridClassic1.Name = "C1FlexGridClassic1"
        Me.C1FlexGridClassic1.NodeClosedPicture = Nothing
        Me.C1FlexGridClassic1.NodeOpenPicture = Nothing
        Me.C1FlexGridClassic1.OutlineCol = -1
        Me.C1FlexGridClassic1.RowHeightMax = 100
        Me.C1FlexGridClassic1.RowHeightMin = 40
        Me.C1FlexGridClassic1.Rows = 1
        Me.C1FlexGridClassic1.Size = New System.Drawing.Size(1531, 462)
        Me.C1FlexGridClassic1.StyleInfo = resources.GetString("C1FlexGridClassic1.StyleInfo")
        Me.C1FlexGridClassic1.TabIndex = 3
        Me.C1FlexGridClassic1.TreeColor = System.Drawing.Color.DarkGray
        '
        'Db_allara_bollaDataSet
        '
        Me.Db_allara_bollaDataSet.DataSetName = "Db_allara_bollaDataSet"
        Me.Db_allara_bollaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtabmezzoBindingSource
        '
        Me.BtabmezzoBindingSource.DataMember = "b_tab_mezzo"
        Me.BtabmezzoBindingSource.DataSource = Me.Db_allara_bollaDataSet
        '
        'B_tab_mezzoTableAdapter
        '
        Me.B_tab_mezzoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 723)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 74)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 723)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 74)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "menu opzioni"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1596, 873)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C1FlexGridClassic1)
        Me.Name = "FormB"
        Me.Text = "FormB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_allara_bollaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtabmezzoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1FlexGridClassic1 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents Db_allara_bollaDataSet As Db_allara_bollaDataSet
    Friend WithEvents BtabmezzoBindingSource As BindingSource
    Friend WithEvents B_tab_mezzoTableAdapter As Db_allara_bollaDataSetTableAdapters.b_tab_mezzoTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
