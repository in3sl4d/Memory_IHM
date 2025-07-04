﻿Public Class Scores
    Dim pictureBox1 As New PictureBox

    Dim victory As New Media.SoundPlayer("Music\victoryPoke.wav")
    Dim ordreCroissant As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        victory.PlayLooping()
        ChargerListe()
    End Sub

    Public Function scoreMax() As Integer
        If ScoresJoueur Is Nothing OrElse ScoresJoueur.Count = 0 Then
            Return 0
        End If
        Return ScoresJoueur.Max(Function(j) j.nbCarresTrouv)
    End Function

    Private Sub ChargerListe()
        ListBox1.Items.Clear() ' noms
        ListBox2.Items.Clear() ' score max
        ListBox3.Items.Clear() ' temps min
        ListBox4.Items.Clear() ' parties
        ListBox5.Items.Clear()

        For Each joueur As SaveModule.Scores In ScoresJoueur
            ListBox1.Items.Add(joueur.nom)
            ListBox2.Items.Add(joueur.nbCarresTrouv)
            ListBox3.Items.Add(joueur.tmpsMin)
            ListBox4.Items.Add(joueur.nbParties)
            ListBox5.Items.Add(joueur.cumulTmps)
        Next
    End Sub

    ' Synchroniser ComboBox lorsqu’un nom est sélectionné dans les listes
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim i As Integer = ListBox1.SelectedIndex
        If i >= 0 Then
            ListBox2.SelectedIndex = i
            ListBox3.SelectedIndex = i
            ListBox4.SelectedIndex = i
            ListBox5.SelectedIndex = i
            ComboBox1.Text = ListBox1.Items(i).ToString()
        End If
    End Sub


    ' Bouton pour trier
    Private Sub btnTrier_Click(sender As Object, e As EventArgs) Handles btnTrier.Click
        ordreCroissant = Not ordreCroissant
        ChargerListe()
    End Sub

    ' Bouton pour afficher les infos du joueur sélectionné dans la ComboBox
    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        Dim nomRecherche = ComboBox1.Text
        Dim joueur = ScoresJoueur.FirstOrDefault(Function(j) j.nom = nomRecherche)
        If joueur.nom <> "" Then
            MsgBox("Nom : " & joueur.nom & vbCrLf &
                   "Score max : " & joueur.nbCarresTrouv & vbCrLf &
                   "Temps min : " & joueur.tmpsMin & " sec" & vbCrLf &
                   "Parties : " & joueur.nbParties & vbCrLf, MsgBoxStyle.Information)
        Else
            MsgBox("Joueur non trouvé.")
        End If
    End Sub

    Private Sub btnRetour_Click_1(sender As Object, e As EventArgs) Handles btnRetour.Click
        Form1.Show()
        victory.Stop()
        Me.Close()
    End Sub

End Class
