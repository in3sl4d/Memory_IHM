Imports System.Media
Imports System.ComponentModel
Imports System.IO.Directory
Imports AxWMPLib
Imports System.IO

Public Class lblChrono

    Public Property NomDuJoueur As String

    'Structure cartePoke
    'Dim carte As Image
    'Dim carteID As String
    'End Structure

    Dim carre As New Media.SoundPlayer("Music\SFX\carreSFX.wav")


    Dim cartesIDs(jeuCartes - 1) As String
    Dim cartesImages(jeuCartes - 1) As Image
    Dim cartesRetournees As New List(Of PictureBox)()
    Dim cartesDejaTrouvees As New List(Of PictureBox)()
    Dim tableauCartes(3, 4) As PictureBox
    Dim rng As New Random()
    Const carreCartes = 4
    Const jeuCartes = 20
    Const nbCarres = 5
    'Dim score As Integer = 0
    Dim pairesTrouvees As Integer = 0

    Const tempsDep As Integer = 60
    Dim tempsRestant As Integer = tempsDep
    Dim Tempstot As Integer

    Dim player As SoundPlayer
    Private Sub playMusic()
        Dim dossierPlaylist As String = Application.StartupPath & "\Music\"
        Dim playlist() As String = GetFiles(dossierPlaylist, "*.wav")
        Dim rnd As New Random()
        Dim cheminMusiqueChoisie As String = playlist(rnd.Next(playlist.Length))
        player = New SoundPlayer(cheminMusiqueChoisie)
        With Wmp2
            .URL = cheminMusiqueChoisie
            .settings.setMode("loop", True)  ' Lecture en boucle
            .settings.volume = 30            ' Volume entre 0 et 100
            .Ctlcontrols.play()
        End With
        player.PlayLooping()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Wmp2.URL = "Music\City Ruins - 8 bit.wav"
        'Wmp2.settings.setMode("loop", True)
        'Wmp2.Ctlcontrols.play()
        playMusic()
        'Wmp2.settings.volume = 30
        Me.Text = "Temps restant : " & tempsRestant & "s"
        lblNomJoueur.Text = NomDuJoueur
        ChargerImages()
        MélangerCartes()
        InitialiserGrille()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempsRestant -= 1
        Me.Text = "Temps restant : " & tempsRestant & "s"

        If tempsRestant <= 0 Then
            Timer1.Stop()
            MessageBox.Show("Temps écoulé ! Vous avez trouvé : " & pairesTrouvees & " carrés !", "Fin du jeu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim accueil As New Form1()
            player.Stop()
            nouvJoueur(NomDuJoueur, 0, pairesTrouvees)
            Me.Close()
            accueil.Show()

            Wmp2.Ctlcontrols.stop()
        End If
    End Sub

    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim rep = MsgBox("Voulez-vous vraiment quitter ? ", MsgBoxStyle.YesNo, "Quitter")
        If rep = MsgBoxResult.No Then
            Exit Sub
        Else
            newPartie()
        End If
    End Sub

    Public Function ChargerImage(nomFichier As String) As Image
        Dim chemin As String = IO.Path.Combine(Application.StartupPath, "Image", nomFichier)
        If Not IO.File.Exists(chemin) Then
            MessageBox.Show("Image introuvable : " & chemin)
            Throw New IO.FileNotFoundException("Image manquante", chemin)
        End If
        Return Image.FromFile(chemin)
    End Function

    Public Function ChargerImages()

        Dim idsPossibles() As String = {"Brasegali", "Brindibou", "Chelours", "Leviator", "Nymphali"}

        For i = 0 To idsPossibles.Length - 1
            Dim imagePath As String = "Images\" & idsPossibles(i) & ".jpg"
            For j = 0 To carreCartes - 1
                Dim index As Integer = i * carreCartes + j
                cartesImages(index) = ChargerImage(imagePath)
                cartesIDs(index) = idsPossibles(i)
            Next
        Next
    End Function

    Public Function MélangerCartes()
        ' On mélange les cartes
        Dim indices = Enumerable.Range(0, cartesImages.Length).OrderBy(Function(x) rng.Next()).ToArray()
        Dim imagesMélangées(jeuCartes - 1) As Image
        Dim idsMélangés(jeuCartes - 1) As String

        For i = 0 To jeuCartes - 1
            imagesMélangées(i) = cartesImages(indices(i))
            idsMélangés(i) = cartesIDs(indices(i))
        Next

        cartesImages = imagesMélangées
        cartesIDs = idsMélangés
    End Function

    Private Sub InitialiserGrille()
        Dim dosCarte As Image = ChargerImage("Images\dosdecarte.jpg")
        Dim largeur As Integer = 100
        Dim hauteur As Integer = 100
        Dim espacement As Integer = 10
        Dim posX As Integer = 30
        Dim posY As Integer = 30
        Dim compteur As Integer = 0

        For ligne As Integer = 0 To 3
            For col As Integer = 0 To 4
                Dim carte As New PictureBox()
                carte.Width = largeur
                carte.Height = hauteur
                carte.Left = posX + col * (largeur + espacement)
                carte.Top = posY + ligne * (hauteur + espacement)
                carte.SizeMode = PictureBoxSizeMode.StretchImage
                carte.Image = dosCarte
                carte.Tag = compteur
                AddHandler carte.Click, AddressOf CarteCliquee
                Me.Controls.Add(carte)
                tableauCartes(ligne, col) = carte
                compteur += 1
            Next
        Next
    End Sub

    Public Sub CarteCliquee(sender As Object, e As EventArgs)


        Timer1.Interval = 1000
        Timer1.Start()

        Dim carte As PictureBox = CType(sender, PictureBox)
        Dim index As Integer = CInt(carte.Tag)

        If cartesRetournees.Contains(carte) OrElse cartesRetournees.Count >= 4 Then
            Return
        End If
        If (cartesDejaTrouvees.Contains(carte) = False) Then
            carte.Image = cartesImages(index)
            cartesRetournees.Add(carte)
        End If

        ' Si c’est la 2e, 3e ou 4e carte, on compare à la première
        If cartesRetournees.Count > 1 Then
            Dim refID As String = cartesIDs(CInt(cartesRetournees(0).Tag)) 'On récupère et stocke l'identifiant de la première carte
            Dim dernierID As String = cartesIDs(index) 'On stocke l'ID de la carte retournée

            If refID <> dernierID Then 'Si les IDs sont différents
                'On désactive toute interaction avec le formulaire 
                Me.Enabled = False
                'On active uniquement le bouton Abandon (ne fonctionne pas, à vérifier) ?
                btnAbandon.Enabled = True
                'On retourne toutes les cartes en 1 seconde
                Dim t As New Timer With {.Interval = 500}
                AddHandler t.Tick, Sub()
                                       For Each pb In cartesRetournees
                                           pb.Image = ChargerImage("Images\dosdecarte.jpg")
                                       Next
                                       cartesRetournees.Clear()
                                       t.Stop()
                                       Me.Enabled = True
                                   End Sub
                t.Start()
                Return
            End If

        End If

        ' Si 4 cartes identiques sont retournées
        If cartesRetournees.Count = carreCartes Then

            carre.Play()

            pairesTrouvees += 1
            'Pour toutes les cartes retournées
            For i = 0 To cartesRetournees.Count - 1
                'On les grise
                cartesRetournees(i).Enabled = False
                cartesRetournees(i).ForeColor = Color.Gray
                cartesDejaTrouvees.Add(cartesRetournees(i))

            Next
            cartesRetournees.Clear()

            If pairesTrouvees = nbCarres Then ' 5 groupes de 4 cartes = victoire
                Timer1.Stop()
                MessageBox.Show("Bravo, vous avez gagné !", "Victoire", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tempstot = tempsDep - tempsRestant
                SaveModule.nouvJoueur(NomDuJoueur, Tempstot, pairesTrouvees)

                'EnregistrerScore(NomDuJoueur, tempsRestant & "s", pairesTrouvees)
                Wmp2.Ctlcontrols.stop()
                player.Stop()
                newPartie()
            End If
        End If
    End Sub

    Private Sub newPartie()
        Me.Hide()
        Form1.Show()
    End Sub

End Class