<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormA))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.C1FlexGridClassic1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Db_allara_bollaDataSet = New bolla_touch_2.Db_allara_bollaDataSet()
        Me.AtabautistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.A_tab_autistaTableAdapter = New bolla_touch_2.Db_allara_bollaDataSetTableAdapters.a_tab_autistaTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_allara_bollaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtabautistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 688)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 688)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 82)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Menu Opzioni"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.C1FlexGridClassic1.Cols = 7
        Me.C1FlexGridClassic1.ColumnInfo = resources.GetString("C1FlexGridClassic1.ColumnInfo")
        Me.C1FlexGridClassic1.DataSource = Me.AtabautistaBindingSource
        Me.C1FlexGridClassic1.Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
        Me.C1FlexGridClassic1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FlexGridClassic1.ForeColor = System.Drawing.Color.DarkGray
        Me.C1FlexGridClassic1.ForeColorFixed = System.Drawing.Color.Black
        Me.C1FlexGridClassic1.ForeColorSel = System.Drawing.Color.DarkSlateBlue
        Me.C1FlexGridClassic1.GridColor = System.Drawing.Color.Wheat
        Me.C1FlexGridClassic1.GridColorFixed = System.Drawing.Color.Black
        Me.C1FlexGridClassic1.Location = New System.Drawing.Point(484, 308)
        Me.C1FlexGridClassic1.Name = "C1FlexGridClassic1"
        Me.C1FlexGridClassic1.NodeClosedPicture = Nothing
        Me.C1FlexGridClassic1.NodeOpenPicture = Nothing
        Me.C1FlexGridClassic1.OutlineCol = -1
        Me.C1FlexGridClassic1.RowHeightMax = 100
        Me.C1FlexGridClassic1.RowHeightMin = 40
        Me.C1FlexGridClassic1.Rows = 1
        Me.C1FlexGridClassic1.Size = New System.Drawing.Size(984, 461)
        Me.C1FlexGridClassic1.StyleInfo = resources.GetString("C1FlexGridClassic1.StyleInfo")
        Me.C1FlexGridClassic1.TabIndex = 2
        Me.C1FlexGridClassic1.TreeColor = System.Drawing.Color.DarkGray
        '
        'Db_allara_bollaDataSet
        '
        Me.Db_allara_bollaDataSet.DataSetName = "Db_allara_bollaDataSet"
        Me.Db_allara_bollaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AtabautistaBindingSource
        '
        Me.AtabautistaBindingSource.DataMember = "a_tab_autista"
        Me.AtabautistaBindingSource.DataSource = Me.Db_allara_bollaDataSet
        '
        'A_tab_autistaTableAdapter
        '
        Me.A_tab_autistaTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.bolla_touch_2.My.Resources.Resources.Cattura7
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(48, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 102)
        Me.Button3.TabIndex = 3
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Salva"
        '
        'FormA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1596, 873)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C1FlexGridClassic1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormA"
        Me.Text = "FormA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_allara_bollaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtabautistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents C1FlexGridClassic1 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents Db_allara_bollaDataSet As Db_allara_bollaDataSet
    Friend WithEvents AtabautistaBindingSource As BindingSource
    Friend WithEvents A_tab_autistaTableAdapter As Db_allara_bollaDataSetTableAdapters.a_tab_autistaTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
