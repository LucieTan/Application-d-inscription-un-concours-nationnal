Public Class Accueil
    Private Sub Btn_open_form1_Click(sender As Object, e As EventArgs) Handles Btn_open_form1.Click
        Inscription_form.Show()
        Panel1.BackColor = Color.FromArgb(100, 192, 192, 192)
        Me.Hide()


    End Sub

    Private Sub Btn_gere_inscriptions_Click(sender As Object, e As EventArgs) Handles Btn_gere_inscriptions.Click
        Gestion_candidatures.Show()
        Me.Hide()
    End Sub

    Private Sub btn_provisoire_Click(sender As Object, e As EventArgs) Handles btn_provisoire.Click
        Etat_des_candidatures.Show()
        Me.Hide()
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Candidat.sauv()
        Me.Close()
    End Sub
End Class