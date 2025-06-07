<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonaJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonaJeu))
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WmPersona2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.nomDuJoueur = New System.Windows.Forms.Label()
        CType(Me.WmPersona2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAbandon
        '
        Me.btnAbandon.BackColor = System.Drawing.Color.Transparent
        Me.btnAbandon.Location = New System.Drawing.Point(766, 11)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(164, 27)
        Me.btnAbandon.TabIndex = 4
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = False
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.BackColor = System.Drawing.Color.Transparent
        Me.lblNomJoueur.Font = New System.Drawing.Font("FOT-ロダン Pro EB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJoueur.ForeColor = System.Drawing.Color.White
        Me.lblNomJoueur.Location = New System.Drawing.Point(37, 19)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(99, 22)
        Me.lblNomJoueur.TabIndex = 5
        Me.lblNomJoueur.Text = "JOUEUR :"
        '
        'Timer1
        '
        '
        'WmPersona2
        '
        Me.WmPersona2.Enabled = True
        Me.WmPersona2.Location = New System.Drawing.Point(29, 64)
        Me.WmPersona2.Name = "WmPersona2"
        Me.WmPersona2.OcxState = CType(resources.GetObject("WmPersona2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WmPersona2.Size = New System.Drawing.Size(75, 23)
        Me.WmPersona2.TabIndex = 6
        Me.WmPersona2.Visible = False
        '
        'nomDuJoueur
        '
        Me.nomDuJoueur.AutoSize = True
        Me.nomDuJoueur.BackColor = System.Drawing.Color.Transparent
        Me.nomDuJoueur.Font = New System.Drawing.Font("FOT-ロダン Pro EB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomDuJoueur.ForeColor = System.Drawing.Color.White
        Me.nomDuJoueur.Location = New System.Drawing.Point(156, 19)
        Me.nomDuJoueur.Name = "nomDuJoueur"
        Me.nomDuJoueur.Size = New System.Drawing.Size(211, 22)
        Me.nomDuJoueur.TabIndex = 7
        Me.nomDuJoueur.Text = "Makoto (default name)"
        '
        'PersonaJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(953, 554)
        Me.Controls.Add(Me.nomDuJoueur)
        Me.Controls.Add(Me.WmPersona2)
        Me.Controls.Add(Me.lblNomJoueur)
        Me.Controls.Add(Me.btnAbandon)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PersonaJeu"
        Me.Text = "PersonaJeu"
        CType(Me.WmPersona2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbandon As Button
    Friend WithEvents lblNomJoueur As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WmPersona2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents nomDuJoueur As Label
End Class
