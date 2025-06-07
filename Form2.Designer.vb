<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lblChrono
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblChrono))
        Me.nomJoueur = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Wmp2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        CType(Me.Wmp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomJoueur
        '
        Me.nomJoueur.AutoSize = True
        Me.nomJoueur.Location = New System.Drawing.Point(93, 16)
        Me.nomJoueur.Name = "nomJoueur"
        Me.nomJoueur.Size = New System.Drawing.Size(0, 16)
        Me.nomJoueur.TabIndex = 1
        '
        'Timer1
        '
        '
        'btnAbandon
        '
        Me.btnAbandon.Location = New System.Drawing.Point(780, 16)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(164, 27)
        Me.btnAbandon.TabIndex = 3
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "leviator.jpg")
        Me.ImageList1.Images.SetKeyName(1, "chelours.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Nymphali.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Brindibou.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Brasegali.jpg")
        Me.ImageList1.Images.SetKeyName(5, "dosdecarte.jpg")
        '
        'Wmp2
        '
        Me.Wmp2.Enabled = True
        Me.Wmp2.Location = New System.Drawing.Point(780, 126)
        Me.Wmp2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Wmp2.Name = "Wmp2"
        Me.Wmp2.OcxState = CType(resources.GetObject("Wmp2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Wmp2.Size = New System.Drawing.Size(164, 151)
        Me.Wmp2.TabIndex = 4
        Me.Wmp2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.BackColor = System.Drawing.Color.Transparent
        Me.lblNomJoueur.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJoueur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNomJoueur.Location = New System.Drawing.Point(193, 11)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(80, 30)
        Me.lblNomJoueur.TabIndex = 6
        Me.lblNomJoueur.Text = "Sasha"
        '
        'lblChrono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(967, 624)
        Me.Controls.Add(Me.lblNomJoueur)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Wmp2)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.nomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "lblChrono"
        Me.Text = "Form2"
        CType(Me.Wmp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomJoueur As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAbandon As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Wmp2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNomJoueur As Label
End Class
