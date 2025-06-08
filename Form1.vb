Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim pika As New Media.SoundPlayer("Music\SFX\Pika.wav")
    Dim persona_line As New Media.SoundPlayer("Music\SFX\persona_line.wav")
    Dim cut As Integer = 1
    Dim cheminFichier As String = "joueurs.txt"


    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnarret.Click
        Dim rep = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            SaveInFile("joueurs.txt")
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveInFile("scores.txt")
        Wmp.Ctlcontrols.stop()
    End Sub

    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click

        Dim nomJoueur = CBNom.Text.Trim()

        If nomJoueur <> "" AndAlso Not CBNom.Items.Contains(nomJoueur) Then
            CBNom.Items.Add(nomJoueur)
            File.AppendAllText(cheminFichier, nomJoueur & Environment.NewLine)

            CBNom.AutoCompleteCustomSource.Add(nomJoueur)
        End If



        If CBNom.Text.Length > 3 Then
            Dim fJeu As New lblChrono()
            fJeu.NomDuJoueur = CBNom.Text.Trim()
            fJeu.Show()
            Wmp.Ctlcontrols.stop()
            Me.Hide()
        End If

    End Sub
    Private Sub CBNom_TextUpdate(sender As Object, e As EventArgs) Handles CBNom.TextUpdate
        If CBNom.Text.Length > 3 Then
            btnJouer.Enabled() = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromFile("scores.txt")
        If File.Exists(cheminFichier) Then
            Dim noms = File.ReadAllLines(cheminFichier).ToList()
            CBNom.Items.AddRange(noms.ToArray())


            Dim source As New AutoCompleteStringCollection()
            source.AddRange(noms.ToArray())
            CBNom.AutoCompleteCustomSource = source

            Wmp.URL = "Music\Driftveil.wav"
            Wmp.settings.setMode("loop", True)
            Wmp.settings.volume = 30
            Wmp.Ctlcontrols.play()
            picLogo.Image = Image.FromFile("Image\MemoryLogo.png")
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        pika.Play()
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Dim formScore As New Scores()
        formScore.Show()
        Wmp.Ctlcontrols.stop()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        persona_line.Play()
        persona.Show()
        TimerCut.Interval = 1000
        TimerCut.Start()
    End Sub

    Private Sub TimerCut_Tick(sender As Object, e As EventArgs) Handles TimerCut.Tick
        cut -= 1
        If cut <= 0 Then
            TimerCut.Stop()
            persona.Close()
            Wmp.Ctlcontrols.stop()
            Me.Hide()
            persona_edition.Show()
        End If
    End Sub
End Class
