Module SaveModule
    Structure Scores
        Dim nom As String
        Dim tmpsMin As Integer
        Dim nbCarresTrouv As Integer
        Dim nbParties As Integer
        Dim cumulTmps As Integer
    End Structure

    Public ScoresJoueur As New List(Of Scores)
    Public DernierScore As Scores

    Public Function joueurExiste(nom As String) As Boolean
        For Each j As Scores In ScoresJoueur
            If j.nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub nouvJoueur(nom As String, temps As Integer, carres As Integer)
        If Not joueurExiste(nom) Then
            Dim nouveauJoueur As New Scores With {
                .nom = nom,
                .tmpsMin = temps,
                .nbCarresTrouv = carres,
                .nbParties = 1,
                .cumulTmps = temps
            }
            ScoresJoueur.Add(nouveauJoueur)
            DernierScore = nouveauJoueur
        Else
            For i As Integer = 0 To ScoresJoueur.Count - 1
                If ScoresJoueur(i).nom = nom Then
                    Dim joueur As Scores = ScoresJoueur(i)
                    If carres > joueur.nbCarresTrouv Then
                        joueur.nbCarresTrouv = carres
                        joueur.tmpsMin = temps
                    End If
                    joueur.nbParties += 1
                    joueur.cumulTmps += temps
                    ScoresJoueur(i) = joueur
                    DernierScore = joueur
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub SaveInFile(cheminFichier As String)
        Using writer As New IO.StreamWriter(cheminFichier)
            For Each joueur As Scores In ScoresJoueur
                writer.WriteLine($"{joueur.nom};{joueur.tmpsMin};{joueur.nbCarresTrouv};{joueur.nbParties};{joueur.cumulTmps}")
            Next
        End Using
    End Sub

    Public Sub LoadFromFile(cheminFichier As String)
        If IO.File.Exists(cheminFichier) Then
            ScoresJoueur.Clear()
            Dim lignes = IO.File.ReadAllLines(cheminFichier)
            For Each ligne In lignes
                Dim parties = ligne.Split(";"c)
                If parties.Length = 5 Then
                    Dim joueur As New Scores With {
                    .nom = parties(0),
                    .tmpsMin = Integer.Parse(parties(1)), 'on convertit les str en integer
                    .nbCarresTrouv = Integer.Parse(parties(2)),
                    .nbParties = Integer.Parse(parties(3)),
                    .cumulTmps = Integer.Parse(parties(4))
                }
                    ScoresJoueur.Add(joueur)
                    DernierScore = joueur
                End If
            Next
        End If
    End Sub

End Module
