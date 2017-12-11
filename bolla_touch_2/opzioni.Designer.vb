<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opzioni
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(310, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tabella Autisti"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(325, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(310, 62)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Tabella Mezzi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(325, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(310, 62)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Tabella Clienti"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(325, 230)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(310, 62)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Tabella Materiali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(325, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(310, 62)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Tabella Destinazioni"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(325, 366)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(310, 62)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Tabella Gestore"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(25, 448)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(152, 62)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "home"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'opzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 522)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Name = "opzioni"
        Me.Text = "opzioni"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
