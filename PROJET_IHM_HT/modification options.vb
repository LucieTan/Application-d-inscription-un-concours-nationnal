Public Class modification_options

    Dim Maxi_Eprv As Integer = 4
    Dim Lim_Eprv_Orale As Integer = 3

    Private Sub Form_Opt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LbPrenom.Text = Inscription_form.txt_prenom.Text
        Lb_Nom.Text = Inscription_form.txt_Nom.Text
        Label2.Text = Maxi_Eprv
        Label4.Text = Lim_Eprv_Orale
        Gb_ep_écrites.BackColor = Color.FromArgb(100, 192, 192, 192)
        Gb_ep_orales.BackColor = Color.FromArgb(100, 192, 192, 192)


    End Sub

    'Mise en place du compteur


    Private Sub epreuve_restante_ecrite_CheckedChanged(sender As Object, e As EventArgs) Handles CK_4.CheckedChanged, CK_3.CheckedChanged, CK_5.CheckedChanged,
            CK_8.CheckedChanged, CK_10.CheckedChanged, CK_11.CheckedChanged, CK_1.CheckedChanged, CK_2.CheckedChanged, CK_6.CheckedChanged, CK_7.CheckedChanged,
            CK_9.CheckedChanged, CK_12.CheckedChanged
        If sender.Checked = True Then
            Maxi_Eprv -= 1
            Label2.Text = Maxi_Eprv
            ComboBox1.Items.Remove(sender.text)
        End If
        If sender.Checked = False Then
            Maxi_Eprv += 1
            Label2.Text = Maxi_Eprv
            ComboBox1.Items.Add(sender.text)
        End If
        If Maxi_Eprv < 0 Then
            MsgBox("4 epreuves max")
            sender.Checked = False
        End If
        If Maxi_Eprv = 0 And Lim_Eprv_Orale = 0 Then

            RadioButton1.Visible = True
            RadioButton2.Visible = True
            Label5.Visible = True

        End If

    End Sub

    Private Sub Nb_epreuve_restante_oral_CheckedChanged(sender As Object, e As EventArgs) Handles CK_14.CheckedChanged, CK_15.CheckedChanged, CK_16.CheckedChanged,
            CK_18.CheckedChanged, CK_20.CheckedChanged, CK_21.CheckedChanged, CK_13.CheckedChanged, CK_19.CheckedChanged, CK_17.CheckedChanged
        If sender.Checked = True Then
            Lim_Eprv_Orale -= 1
            Label4.Text = Lim_Eprv_Orale
            ComboBox1.Items.Remove(sender.text)
        End If
        If sender.Checked = False Then
            Lim_Eprv_Orale += 1
            Label4.Text = Lim_Eprv_Orale
            ComboBox1.Items.Add(sender.text)
        End If
        If Lim_Eprv_Orale < 0 Then
            MsgBox("3 epreuves max")
            sender.Checked = False
        End If
        If Maxi_Eprv = 0 And Lim_Eprv_Orale = 0 Then
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            Label5.Visible = True
        End If

    End Sub

    Private Sub Ck_Expression_CheckedChanged(sender As Object, e As EventArgs) Handles CK_4.CheckedChanged
        If CK_4.Checked = True Then
            CK_15.Enabled = False
        End If
        If CK_4.Checked = False Then
            CK_15.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CK_15.CheckedChanged
        If CK_15.Checked = True Then
            CK_4.Enabled = False
        End If
        If CK_15.Checked = False Then
            CK_4.Enabled = True
        End If
    End Sub

    Private Sub Ck_droit_CheckedChanged(sender As Object, e As EventArgs) Handles CK_3.CheckedChanged
        If CK_3.Checked = True Then
            CK_14.Enabled = False
        End If
        If CK_3.Checked = False Then
            CK_14.Enabled = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CK_14.CheckedChanged
        If CK_14.Checked = True Then
            CK_3.Enabled = False
        End If
        If CK_14.Checked = False Then
            CK_3.Enabled = True
        End If
    End Sub

    Private Sub Ck_Gestion_CheckedChanged(sender As Object, e As EventArgs) Handles CK_5.CheckedChanged
        If CK_5.Checked = True Then
            CK_16.Enabled = False
        End If
        If CK_5.Checked = False Then
            CK_16.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CK_16.CheckedChanged
        If CK_16.Checked = True Then
            CK_5.Enabled = False
        End If
        If CK_16.Checked = False Then
            CK_5.Enabled = True
        End If
    End Sub

    Private Sub Ck_Maths_CheckedChanged(sender As Object, e As EventArgs) Handles CK_8.CheckedChanged
        If CK_8.Checked = True Then
            CK_18.Enabled = False
        End If
        If CK_8.Checked = False Then
            CK_18.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CK_18.CheckedChanged
        If CK_18.Checked = True Then
            CK_8.Enabled = False
        End If
        If CK_18.Checked = False Then
            CK_8.Enabled = True
        End If
    End Sub

    Private Sub Ck_reseau_CheckedChanged(sender As Object, e As EventArgs) Handles CK_10.CheckedChanged
        If CK_10.Checked = True Then
            CK_20.Enabled = False
        End If
        If CK_10.Checked = False Then
            CK_20.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CK_20.CheckedChanged
        If CK_20.Checked = True Then
            CK_10.Enabled = False
        End If
        If CK_20.Checked = False Then
            CK_10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CK_11.CheckedChanged
        If CK_11.Checked = True Then
            CK_21.Enabled = False
        End If
        If CK_11.Checked = False Then
            CK_21.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CK_21.CheckedChanged
        If CK_21.Checked = True Then
            CK_11.Enabled = False
        End If
        If CK_21.Checked = False Then
            CK_11.Enabled = True
        End If
    End Sub

    Private Sub btn_abandon_Click(sender As Object, e As EventArgs) Handles Btn_abandon.Click

        Dim style As MsgBoxStyle = MsgBoxStyle.YesNo
        Dim reponse = MsgBox("Etes-vous sûr d'abandonner votre inscription ?", style, "Abandon de l'inscription en cours")
        If reponse = MsgBoxResult.Yes Then
            Me.Close()
            Accueil.Show()
        Else
            Me.Show()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox1.Visible = True
        CK_4.Enabled = False
        CK_15.Enabled = False
        CK_14.Enabled = False
        CK_3.Enabled = False
        CK_16.Enabled = False
        CK_5.Enabled = False
        CK_18.Enabled = False
        CK_8.Enabled = False
        CK_20.Enabled = False
        CK_10.Enabled = False
        CK_21.Enabled = False
        CK_11.Enabled = False
        CK_2.Enabled = False
        CK_1.Enabled = False
        CK_6.Enabled = False
        CK_9.Enabled = False
        CK_13.Enabled = False
        CK_19.Enabled = False
        CK_17.Enabled = False
        CK_7.Enabled = False
        CK_12.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        CK_4.Enabled = True
        CK_15.Enabled = True
        CK_14.Enabled = True
        CK_3.Enabled = True
        CK_16.Enabled = True
        CK_5.Enabled = True
        CK_18.Enabled = True
        CK_8.Enabled = True
        CK_20.Enabled = True
        CK_10.Enabled = True
        CK_21.Enabled = True
        CK_11.Enabled = True
        CK_2.Enabled = True
        CK_1.Enabled = True
        CK_6.Enabled = True
        CK_9.Enabled = True
        CK_13.Enabled = True
        CK_19.Enabled = True
        CK_17.Enabled = True
        CK_7.Enabled = True
        CK_12.Enabled = True
    End Sub

    Private Sub btn_valide_Click(sender As Object, e As EventArgs) Handles btn_valide.Click
        Dim erreur As Integer = 0

        With RegionCbBar
            If RegionCbBar.Text = "" Then
                MsgBox("Sélectionner une région svp")
                .BackColor = Color.IndianRed
                erreur += 1
                .Focus()
            End If

        End With
        With Maxi_Eprv
            If Maxi_Eprv <> 0 Then
                MsgBox("le nbre d'épreuve est insuffisant")
                Label1.ForeColor = Color.Red
                Label2.ForeColor = Color.Red
                erreur += 1
            End If
        End With

        With Lim_Eprv_Orale
            If Lim_Eprv_Orale <> 0 Then
                MsgBox("le nbre d'épreuve est insuffisant")
                erreur += 1
                Label3.ForeColor = Color.Red
                Label4.ForeColor = Color.Red
            End If
        End With

        With Label5

        End With

        If erreur = 0 Then
            Candidat.majOption()
            Récapitulatif.Show()
            Candidat.sauv()
            Me.Close()



        End If


    End Sub
End Class