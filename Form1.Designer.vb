<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CBNom = New System.Windows.Forms.ComboBox()
        Me.lbNomJoueur = New System.Windows.Forms.Label()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnarret = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerCut = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBNom
        '
        Me.CBNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CBNom.FormattingEnabled = True
        Me.CBNom.Location = New System.Drawing.Point(261, 106)
        Me.CBNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNom.Name = "CBNom"
        Me.CBNom.Size = New System.Drawing.Size(193, 24)
        Me.CBNom.TabIndex = 0
        '
        'lbNomJoueur
        '
        Me.lbNomJoueur.AutoSize = True
        Me.lbNomJoueur.BackColor = System.Drawing.Color.Transparent
        Me.lbNomJoueur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbNomJoueur.Location = New System.Drawing.Point(35, 110)
        Me.lbNomJoueur.Name = "lbNomJoueur"
        Me.lbNomJoueur.Size = New System.Drawing.Size(165, 26)
        Me.lbNomJoueur.TabIndex = 1
        Me.lbNomJoueur.Text = "Entrez votre nom :"
        '
        'btnScore
        '
        Me.btnScore.AutoSize = True
        Me.btnScore.BackColor = System.Drawing.Color.Transparent
        Me.btnScore.FlatAppearance.BorderSize = 0
        Me.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScore.Image = CType(resources.GetObject("btnScore.Image"), System.Drawing.Image)
        Me.btnScore.Location = New System.Drawing.Point(237, 210)
        Me.btnScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(259, 64)
        Me.btnScore.TabIndex = 2
        Me.btnScore.Text = "Scores"
        Me.btnScore.UseVisualStyleBackColor = False
        '
        'btnJouer
        '
        Me.btnJouer.AutoSize = True
        Me.btnJouer.BackColor = System.Drawing.Color.Transparent
        Me.btnJouer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnJouer.FlatAppearance.BorderSize = 0
        Me.btnJouer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnJouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJouer.Image = CType(resources.GetObject("btnJouer.Image"), System.Drawing.Image)
        Me.btnJouer.Location = New System.Drawing.Point(237, 143)
        Me.btnJouer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(259, 64)
        Me.btnJouer.TabIndex = 3
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnarret
        '
        Me.btnarret.AutoSize = True
        Me.btnarret.BackColor = System.Drawing.Color.Transparent
        Me.btnarret.FlatAppearance.BorderSize = 0
        Me.btnarret.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnarret.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnarret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarret.Image = CType(resources.GetObject("btnarret.Image"), System.Drawing.Image)
        Me.btnarret.Location = New System.Drawing.Point(237, 279)
        Me.btnarret.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnarret.Name = "btnarret"
        Me.btnarret.Size = New System.Drawing.Size(259, 64)
        Me.btnarret.TabIndex = 4
        Me.btnarret.Text = "Quitter"
        Me.btnarret.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.InitialImage = Nothing
        Me.picLogo.Location = New System.Drawing.Point(123, 12)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(432, 62)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 5
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(187, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliquez sur le logo du jeu pour lancer la musique."
        '
        'Wmp
        '
        Me.Wmp.Enabled = True
        Me.Wmp.Location = New System.Drawing.Point(486, 138)
        Me.Wmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Wmp.Name = "Wmp"
        Me.Wmp.OcxState = CType(resources.GetObject("Wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Wmp.Size = New System.Drawing.Size(172, 193)
        Me.Wmp.TabIndex = 6
        Me.Wmp.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(261, 348)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TimerCut
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Wmp)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnarret)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.lbNomJoueur)
        Me.Controls.Add(Me.CBNom)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBNom As ComboBox
    Friend WithEvents lbNomJoueur As Label
    Friend WithEvents btnScore As Button
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnarret As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerCut As Timer
End Class
