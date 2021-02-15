Public Class Etat_des_candidatures

    Dim val As String
    Private Sub Etat_des_candidatures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nom_prénom.Items.Clear()
        Candidat.Combobilan()
        Candidat.listEprFac()
        Candidat.listId()
        Candidat.listNP()
        Candidat.listecritorale()


    End Sub

    Private Sub nom_prénom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nom_prénom.SelectedIndexChanged

    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub Btn_candidat_Click(sender As Object, e As EventArgs) Handles Btn_candidat.Click
        Me.Hide()
        Bilan_candidat.Show()
    End Sub

    Private Sub Cb_matiières_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_matiières.SelectedIndexChanged
        val = Cb_matiières.SelectedIndex.ToString
        For i = 0 To Candidat.getNb_Candidat - 1
            If Candidat.matiere(val, i) Then
                ListBox_Id.Items.Add(Candidat.getNum_inst(i))
                ListBox_Nom_Prenom.Items.Add(Candidat.getnom(i) + " " + Candidat.getprenom(i))
                'ListBox_Id.Items.Add(Candidat.getNum_inst(i))
                'ListBox_Id.Items.Add(Candidat.getNum_inst(i))
            End If
        Next


    End Sub

End Class