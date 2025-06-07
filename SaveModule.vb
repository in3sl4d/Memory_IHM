Module SaveModule
    Structure Scores
        Dim nom As String
        Dim tmps As String
        Dim nbCarresTrouv As Integer
        Dim nbParties As Integer
    End Structure

    Public ScoresJoueur() As Scores
    Public DernierScore As Scores

    Public Sub nouvJoueur(nom As String, temps As String, carres As Integer)
        If ScoresJoueur Is Nothing Then
            ReDim ScoresJoueur(0)
            ScoresJoueur(0).nom = nom
            ScoresJoueur(0).tmps = temps
            ScoresJoueur(0).nbCarresTrouv = carres
            ScoresJoueur(0).nbParties = 1
            DernierScore = ScoresJoueur(0)
            Return
        End If


        For i As Integer = 0 To ScoresJoueur.Length - 1
            If ScoresJoueur(i).nom = nom Then

                If carres > ScoresJoueur(i).nbCarresTrouv Then
                    ScoresJoueur(i).nbCarresTrouv = carres
                    ScoresJoueur(i).tmps = temps
                    ScoresJoueur(i).nbParties += 1
                End If
                DernierScore = ScoresJoueur(i)
                Return
            End If
        Next


        ReDim Preserve ScoresJoueur(ScoresJoueur.Length)
        Dim idx As Integer = ScoresJoueur.Length - 1
        ScoresJoueur(idx).nom = nom
        ScoresJoueur(idx).tmps = temps
        ScoresJoueur(idx).nbCarresTrouv = carres
        ScoresJoueur(idx).nbParties += 1
        DernierScore = ScoresJoueur(idx)
    End Sub

End Module
