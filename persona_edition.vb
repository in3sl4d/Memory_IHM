﻿Imports System.IO

Public Class persona_edition

    Dim cheminFichier As String = "joueurs.txt"

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WPersona.Ctlcontrols.stop()
        Me.Close()
        persona_scores.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WPersona.Ctlcontrols.stop()
        Me.Close()
        PersonaJeu.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim rep = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            SaveInFile(cheminFichier)
            Application.Exit()
        End If
    End Sub

    Private Sub persona_edition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromFile("scores.txt")
        If (Form1.CBNom.Text <> "") Then
            CBNom.Text = Form1.CBNom.Text
        End If
        With WPersona
            .URL = "Music\Persona_mode\Color Your Night.wav"
            .settings.setMode("loop", True)  ' Lecture en boucle
            .settings.volume = 30            ' Volume entre 0 et 100
            .Ctlcontrols.play()
        End With
    End Sub

    Private Sub persona_edition_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveInFile("scores.txt")
    End Sub

    Private Sub CBNom_TextChanged(sender As Object, e As EventArgs) Handles CBNom.TextChanged
        If (CBNom.Text.Length >= 3) Then
            PictureBox2.Enabled = True
        End If
    End Sub
End Class