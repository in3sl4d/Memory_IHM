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

    Public Function joueurExiste(joueur As Scores)
        If ScoresJoueur.Count > 0 Then
            For i As Integer = 0 To ScoresJoueur.Count - 1
                If ScoresJoueur(i).nom = joueur.nom Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    Public Sub nouvJoueur(nom As String, temps As Integer, carres As Integer)
        Dim joueur As Scores
        joueur.nom = nom
        If (joueurExiste(joueur) = False) Then
            joueur.tmpsMin = temps
            joueur.nbCarresTrouv = carres
            joueur.nbParties = 1
            joueur.cumulTmps = temps
            DernierScore = joueur
            Return
        Else
            For i As Integer = 0 To ScoresJoueur.Count - 1
                If ScoresJoueur(i).nom = nom Then
                    joueur = ScoresJoueur(i)
                    If carres > joueur.nbCarresTrouv Then
                        joueur.nbCarresTrouv = carres
                        joueur.tmpsMin = temps
                    End If
                    joueur.nbParties += 1
                    joueur.cumulTmps += temps
                    ScoresJoueur(i) = joueur
                    DernierScore = ScoresJoueur(i)
                    Return
                End If
            Next
        End If

        Dim idx As Integer = ScoresJoueur.Count - 1
        ScoresJoueur(idx) = joueur
        DernierScore = ScoresJoueur(idx)
    End Sub

End Module
