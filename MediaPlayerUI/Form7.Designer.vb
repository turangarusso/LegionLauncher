<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaaPreloader1 = New SaaUI.SaaPreloader()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(62, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sviluppato da:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(282, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruxo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(62, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Per Legion RP"
        '
        'SaaPreloader1
        '
        Me.SaaPreloader1.BackColor = System.Drawing.Color.Transparent
        Me.SaaPreloader1.DashCap = System.Drawing.Drawing2D.DashCap.Round
        Me.SaaPreloader1.DashOffset = 0!
        Me.SaaPreloader1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.SaaPreloader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaaPreloader1.LineEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.SaaPreloader1.LineStart = System.Drawing.Drawing2D.LineCap.Round
        Me.SaaPreloader1.LoaderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaaPreloader1.LoaderWidth = 5
        Me.SaaPreloader1.Location = New System.Drawing.Point(0, 0)
        Me.SaaPreloader1.MaxAngle = 360
        Me.SaaPreloader1.MinAngle = 0
        Me.SaaPreloader1.Name = "SaaPreloader1"
        Me.SaaPreloader1.Reverse = False
        Me.SaaPreloader1.Size = New System.Drawing.Size(800, 800)
        Me.SaaPreloader1.SpeedInMilliSeconds = 20
        Me.SaaPreloader1.Start = True
        Me.SaaPreloader1.StepDown = 4
        Me.SaaPreloader1.StepUp = 4
        Me.SaaPreloader1.TabIndex = 37
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaaPreloader1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaaPreloader1 As SaaUI.SaaPreloader
End Class
