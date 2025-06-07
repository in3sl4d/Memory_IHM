<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.Location = New System.Drawing.Point(29, 18)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(54, 16)
        Me.lblNomJoueur.TabIndex = 21
        Me.lblNomJoueur.Text = "Joueur :"
        '
        'btnAbandon
        '
        Me.btnAbandon.Location = New System.Drawing.Point(671, 12)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(164, 27)
        Me.btnAbandon.TabIndex = 22
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 23
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 526)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.lblNomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNomJoueur As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAbandon As Button
    Friend WithEvents Label1 As Label
End Class
