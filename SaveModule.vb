Module SaveModule
    Structure Scores
        Dim nom As String
        Dim tmpsMin As Integer
        Dim nbCarresTrouv As Integer
        Dim nbParties As Integer
        Dim cumulTmps As Integer
    End Structure

    Public ScoresJoueur() As Scores
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
            ReDim ScoresJoueur(0)
            ScoresJoueur(0).nom = nom
            ScoresJoueur(0).tmpsMin = temps
            ScoresJoueur(0).nbCarresTrouv = carres
            ScoresJoueur(0).nbParties = 1
            ScoresJoueur(0).cumulTmps = temps
            DernierScore = ScoresJoueur(0)
            Return
        Else
            For i As Integer = 0 To ScoresJoueur.Length - 1
                If ScoresJoueur(i).nom = nom Then
                    If carres > ScoresJoueur(i).nbCarresTrouv Then
                        ScoresJoueur(i).nbCarresTrouv = carres
                        ScoresJoueur(i).tmpsMin = temps
                        ScoresJoueur(i).nbParties += 1
                    End If
                    ScoresJoueur(i).cumulTmps += temps
                    DernierScore = ScoresJoueur(i)
                    Return
                End If
            Next
        End If


        ReDim Preserve ScoresJoueur(ScoresJoueur.Length)
        Dim idx As Integer = ScoresJoueur.Length - 1
        ScoresJoueur(idx).nom = nom
        ScoresJoueur(idx).tmpsMin = temps
        ScoresJoueur(idx).nbCarresTrouv = carres
        ScoresJoueur(idx).nbParties += 1
        DernierScore = ScoresJoueur(idx)
    End Sub

End Module
