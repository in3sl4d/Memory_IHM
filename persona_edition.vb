Public Class persona_edition

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WPersona.Ctlcontrols.stop()
        Me.Hide()
        persona_scores.Show()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles WPersona.Enter

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WPersona.Ctlcontrols.stop()
        Me.Hide()
        PersonaJeu.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim rep = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub persona_edition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Form1.CBNom.Text <> "") Then
            CBNom.Text = Form1.CBNom.Text
        End If
        With WPersona
            .URL = "Music\Color Your Night.wav"
            .settings.setMode("loop", True)  ' Lecture en boucle
            .settings.volume = 30            ' Volume entre 0 et 100
            .Ctlcontrols.play()
        End With
    End Sub

    Private Sub CBNom_TextChanged(sender As Object, e As EventArgs) Handles CBNom.TextChanged

    End Sub
End Class