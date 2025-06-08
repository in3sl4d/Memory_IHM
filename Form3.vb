Public Class Scores
    Dim pictureBox1 As New PictureBox

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim joueur = SaveModule.DernierScore

        If joueur.nom <> "" Then
            lblNom.Text = "Nom : " & joueur.nom
            lblTemps.Text = "Tu as gagné la partie à (gros nul): " & joueur.tmpsMin
            lblPaires.Text = "Paires trouvées : " & joueur.nbCarresTrouv
        Else
            lblNom.Text = "Nom : Aucun score disponible"
            lblTemps.Text = "Temps : --"
            lblPaires.Text = "Paires trouvées : --"
        End If

    End Sub

    Private Sub btnRetour_Click_1(sender As Object, e As EventArgs) Handles btnRetour.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
