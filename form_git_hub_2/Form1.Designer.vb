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
        Dim C1GaugeRange3 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange()
        Dim C1GaugeMarks3 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks()
        Dim C1GaugeLabels3 As C1.Win.C1Gauge.C1GaugeLabels = New C1.Win.C1Gauge.C1GaugeLabels()
        Dim C1GaugeCaption3 As C1.Win.C1Gauge.C1GaugeCaption = New C1.Win.C1Gauge.C1GaugeCaption()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1Gauge1 = New C1.Win.C1Gauge.C1Gauge()
        Me.c1RadialGauge6 = New C1.Win.C1Gauge.C1RadialGauge()
        CType(Me.C1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(114, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 77)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(308, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(315, 134)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'C1Gauge1
        '
        Me.C1Gauge1.Gauges.AddRange(New C1.Win.C1Gauge.C1GaugeBase() {Me.c1RadialGauge6})
        Me.C1Gauge1.Location = New System.Drawing.Point(168, 136)
        Me.C1Gauge1.Name = "C1Gauge1"
        Me.C1Gauge1.Size = New System.Drawing.Size(656, 293)
        Me.C1Gauge1.TabIndex = 5
        Me.C1Gauge1.ViewTag = CType(636765558741457788, Long)
        '
        'c1RadialGauge6
        '
        Me.c1RadialGauge6.Cap.Filling.Color = System.Drawing.Color.Black
        C1GaugeRange3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeRange3.Border.Color = System.Drawing.Color.Black
        C1GaugeRange3.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeRange3.Filling.Color = System.Drawing.Color.Red
        C1GaugeRange3.Filling.Color2 = System.Drawing.Color.Lime
        C1GaugeRange3.Filling.SwapColors = True
        C1GaugeRange3.Location = 98.0R
        C1GaugeRange3.Shadow.Visible = True
        C1GaugeRange3.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0R, -1, System.Drawing.Color.Green, 1.0R, CType(666031857402460765, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(70.0R, -1, System.Drawing.Color.Yellow, 1.0R, CType(666313332388692373, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(90.0R, -1, System.Drawing.Color.Red, 1.0R, CType(666594807369003389, Long))})
        C1GaugeRange3.ViewTag = CType(665468900867481363, Long)
        C1GaugeRange3.Width = 20.0R
        C1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks3.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks3.Interval = 5.0R
        C1GaugeMarks3.Length = 10.0R
        C1GaugeMarks3.Location = 100.0R
        C1GaugeMarks3.ViewTag = CType(665750375874035003, Long)
        C1GaugeMarks3.Width = 1.0R
        C1GaugeLabels3.FontSize = 9.0R
        C1GaugeLabels3.Interval = 10.0R
        C1GaugeLabels3.Location = 118.0R
        C1GaugeLabels3.ViewTag = CType(666876287038393266, Long)
        Me.c1RadialGauge6.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeRange3, C1GaugeMarks3, C1GaugeLabels3})
        C1GaugeCaption3.CenterPointY = 0.88R
        C1GaugeCaption3.FontSize = 12.0R
        C1GaugeCaption3.Text = "C1Gauge"
        Me.c1RadialGauge6.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeCaption3})
        Me.c1RadialGauge6.Name = "c1RadialGauge6"
        Me.c1RadialGauge6.Pointer.CustomShape.EndAngle = 70.0R
        Me.c1RadialGauge6.Pointer.CustomShape.EndSwellWidth = 6.0R
        Me.c1RadialGauge6.Pointer.CustomShape.EndWidth = 9.0R
        Me.c1RadialGauge6.Pointer.CustomShape.StartWidth = 9.0R
        Me.c1RadialGauge6.Pointer.Filling.Color = System.Drawing.Color.Black
        Me.c1RadialGauge6.Pointer.Offset = 0R
        Me.c1RadialGauge6.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom
        Me.c1RadialGauge6.Pointer.Value = 60.0R
        Me.c1RadialGauge6.PointerOriginY = 0.55R
        Me.c1RadialGauge6.Radius = 0.43R
        Me.c1RadialGauge6.Viewport.AspectPinY = 0.5R
        Me.c1RadialGauge6.Viewport.AspectRatio = 1.12R
        Me.c1RadialGauge6.ViewTag = CType(664905950787987445, Long)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 459)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C1Gauge1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents C1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Friend WithEvents c1RadialGauge6 As C1.Win.C1Gauge.C1RadialGauge
End Class
