Public Class Bilan_candidat

    Private Sub Bilan_candidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lb_prénom.Text = Candidat.getnom(Etat_des_candidatures.nom_prénom.SelectedIndex)
        lb_nom.Text = Candidat.getprenom(Etat_des_candidatures.nom_prénom.SelectedIndex)
        lb_age.Text = Candidat.getage(Etat_des_candidatures.nom_prénom.SelectedIndex)
        lb_ville.Text = Candidat.getville(Etat_des_candidatures.nom_prénom.SelectedIndex)
        lb_adr.Text = Candidat.getadresse(Etat_des_candidatures.nom_prénom.SelectedIndex)
        code.Text = Candidat.getcode_p(Etat_des_candidatures.nom_prénom.SelectedIndex)
        lb_epr1.Text = Candidat.getEpreEcrite(Etat_des_candidatures.nom_prénom.SelectedIndex, 0)
        lb_epr2.Text = Candidat.getEpreEcrite(Etat_des_candidatures.nom_prénom.SelectedIndex, 1)
        lb_epr3.Text = Candidat.getEpreEcrite(Etat_des_candidatures.nom_prénom.SelectedIndex, 2)
        lb_epr4.Text = Candidat.getEpreEcrite(Etat_des_candidatures.nom_prénom.SelectedIndex, 3)
        Lb_oral1.Text = Candidat.getEpreOral(Etat_des_candidatures.nom_prénom.SelectedIndex, 0)
        Lb_oral2.Text = Candidat.getEpreOral(Etat_des_candidatures.nom_prénom.SelectedIndex, 1)
        Lb_oral3.Text = Candidat.getEpreOral(Etat_des_candidatures.nom_prénom.SelectedIndex, 2)
        lb_eprv_facul.Text = Candidat.getEpreFacultative(Etat_des_candidatures.nom_prénom.SelectedIndex)

        Pl_eprv.BackColor = Color.FromArgb(100, 192, 192, 192)
        Pl_etat.BackColor = Color.FromArgb(100, 192, 192, 192)
        Pl_adr.BackColor = Color.FromArgb(100, 192, 192, 192)

    End Sub
    Private Sub Btn_return_Click(sender As Object, e As EventArgs) Handles Btn_return.Click
        Me.Close()
        Etat_des_candidatures.Show()
    End Sub

    Private Sub btn_accueil_Click(sender As Object, e As EventArgs) Handles btn_accueil.Click
        Me.Close()
        Etat_des_candidatures.Close()
        Accueil.Show()
    End Sub


End Class