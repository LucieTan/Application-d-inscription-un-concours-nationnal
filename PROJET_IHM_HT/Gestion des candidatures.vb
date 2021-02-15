Public Class Gestion_candidatures
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Candidat.Combo()
        PL.BackColor = Color.FromArgb(100, 192, 192, 192)
    End Sub

    Private Sub Cb_Recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Recherche.SelectedIndexChanged
        Label7.Text = Candidat.getnom(Cb_Recherche.SelectedIndex)
        Label12.Text = Candidat.getprenom(Cb_Recherche.SelectedIndex)
        Label11.Text = Cb_Recherche.SelectedIndex + 1
        Label10.Text = Candidat.getEpreEcrite(Cb_Recherche.SelectedIndex, 0) + ", " + Candidat.getEpreEcrite(Cb_Recherche.SelectedIndex, 1) + ", " + Candidat.getEpreEcrite(Cb_Recherche.SelectedIndex, 2) _
            + ", " + Candidat.getEpreEcrite(Cb_Recherche.SelectedIndex, 3)
        Label9.Text = Candidat.getEpreOral(Cb_Recherche.SelectedIndex, 0) + ", " + Candidat.getEpreOral(Cb_Recherche.SelectedIndex, 1) + ", " + Candidat.getEpreOral(Cb_Recherche.SelectedIndex, 2)
        Label8.Text = Candidat.getEpreFacultative(Cb_Recherche.SelectedIndex)
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Dim Warning = MsgBox("Etes-vous sûr de vouloir supprimer cette candidature ?", vbCritical + vbYesNo, "Suppression d'une candidature")
        If (Warning = vbYes) Then
            Candidat.Supp(Cb_Recherche.SelectedIndex)
            Cb_Recherche.Items.RemoveAt(Cb_Recherche.SelectedIndex)
            Label7.Text = ""
            Label12.Text = ""
            Label11.Text = ""
            Label10.Text = ""
            Label9.Text = ""
            Label8.Text = ""
            MsgBox("Cette candidature a bien été supprimée")
        Else
            MsgBox("Suppression annulée")
        End If

    End Sub

    Private Sub Btn_modif_Click(sender As Object, e As EventArgs) Handles Btn_modif.Click
        Me.Close()
        Modification_candidats.Show()
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        Accueil.Show()
    End Sub
End Class