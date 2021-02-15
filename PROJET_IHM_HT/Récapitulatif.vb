Public Class Récapitulatif

    Private Sub btn_valid_Click(sender As Object, e As EventArgs) Handles btn_valid.Click
        'Candidat.sauv()
        MsgBox("Voici votre Id : " + CStr(Candidat.getNb_Candidat() + 1))
        Me.Close()
        Accueil.Show()

        Candidat.AjouterCandidat()

    End Sub

    Private Sub Récapitulatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_prénom.Text = Candidat.getnom(Candidat.getNb_Candidat())
        lb_nom.Text = Candidat.getprenom(Candidat.getNb_Candidat())
        lb_age.Text = Candidat.getage(Candidat.getNb_Candidat())
        lb_ville.Text = Candidat.getville(Candidat.getNb_Candidat())
        lb_adr.Text = Candidat.getadresse(Candidat.getNb_Candidat())
        code.Text = Candidat.getcode_p(Candidat.getNb_Candidat())
        lb_epr1.Text = Candidat.getEpreEcrite(Candidat.getNb_Candidat(), 0)
        lb_epr2.Text = Candidat.getEpreEcrite(Candidat.getNb_Candidat(), 1)
        lb_epr3.Text = Candidat.getEpreEcrite(Candidat.getNb_Candidat(), 2)
        lb_epr4.Text = Candidat.getEpreEcrite(Candidat.getNb_Candidat(), 3)
        Lb_oral1.Text = Candidat.getEpreOral(Candidat.getNb_Candidat(), 0)
        Lb_oral2.Text = Candidat.getEpreOral(Candidat.getNb_Candidat(), 1)
        Lb_oral3.Text = Candidat.getEpreOral(Candidat.getNb_Candidat(), 2)
        lb_eprv_facul.Text = Candidat.getEpreFacultative(Candidat.getNb_Candidat())





        Pl_eprv.BackColor = Color.FromArgb(100, 192, 192, 192)
        Pl_etat.BackColor = Color.FromArgb(100, 192, 192, 192)
        Pl_adr.BackColor = Color.FromArgb(100, 192, 192, 192)
    End Sub

    Private Sub btn_abandon_Click(sender As Object, e As EventArgs) Handles btn_abandon.Click

        Dim style As MsgBoxStyle = MsgBoxStyle.YesNo
        Dim reponse = MsgBox("Etes-vous sûr d'abandonner votre inscription ?", style, "Abandon de l'inscription en cours")
        If reponse = MsgBoxResult.Yes Then
            Me.Close()
            Accueil.Show()
        Else
            Me.Show()
        End If
    End Sub
End Class