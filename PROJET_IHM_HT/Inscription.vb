Public Class Inscription_form
    'Déclaration des variables
    Dim cpt As Integer = 0
    Dim decompte As Integer = 60
    Dim c As CANDIDATURE

    'Chargement du formulaire, ts les champs sont vides 
    Private Sub Inscription_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chrono.Start()
        Agescroll.Minimum = 18
        Agescroll.Maximum = 55
        backpanel.BackColor = Color.FromArgb(100, 192, 192, 192)
        Candidat.init()
    End Sub

    'Abandon du formulaire & retour sur le menu principal
    Private Sub btn_abandon_Click(sender As Object, e As EventArgs) Handles btn_abandon.Click
        Chrono.Stop()
        Dim style As MsgBoxStyle = MsgBoxStyle.YesNo
        Dim reponse = MsgBox("Etes-vous sûr d'abandonner votre inscription ?", style, "Abandon de l'inscription en cours")
        If reponse = MsgBoxResult.Yes Then
            Me.Close()
            Accueil.Show()
        Else
            Me.Show()
            Chrono.Start()
        End If
    End Sub

    ' Condition pour valider le formulaire 
    Private Sub btn_valid_Click(sender As Object, e As EventArgs) Handles btn_valid.Click
        Dim erreur As Integer = 0
        With txt_Nom
            If String.IsNullOrEmpty(.Text) Then
                .BackColor = Color.Red
                erreur += 1
                .Focus()
            End If
        End With

        With txt_prenom
            If String.IsNullOrEmpty(.Text) Then
                .BackColor = Color.Red
                erreur += 1
                .Focus()
            End If
        End With

        With txt_ville
            If String.IsNullOrEmpty(.Text) Then
                .BackColor = Color.Red
                erreur += 1
                .Focus()
            End If
        End With

        With txt_code_postal
            If txt_code_postal.Visible = True And (Not txt_code_postal.Text.Length = 5 OrElse txt_code_postal.Text.Substring(0, 2) = "00") Then
                Label_code_postal.ForeColor = Color.Red
                MsgBox("Le format du code postal incorrect")
                erreur += 1
            Else
                Label_code_postal.ForeColor = SystemColors.ControlText
            End If
        End With

        With txt_age
            If String.IsNullOrEmpty(.Text) Then
                .BackColor = Color.Red
                erreur += 1
                .Focus()
            End If
        End With

        With txt_adr
            If String.IsNullOrEmpty(.Text) Then
                txt_adr.Text = "Non renseigné"
            End If
        End With

        If erreur = 0 Then
            Dim réponse As String = MsgBox("Cool t'as tout rempli :)")
            Candidat.majInscription()
            Form_Opt.Show()
            Me.Close()

        End If


    End Sub

    'Condition sur les champs
    Private Sub txt_Nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Nom.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txt_prenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prenom.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txt_code_postal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_code_postal.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = Chr(0)

        End If
    End Sub

    Private Sub txt_ville_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ville.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = Chr(0)
        End If


    End Sub

    ' Syntaxe sur les champs 
    Private Sub txt_nom_LostFocus(sender As Object, e As EventArgs) Handles txt_Nom.LostFocus
        Me.txt_Nom.Text = UCase(txt_Nom.Text)
    End Sub

    Private Sub txt_prenom_LostFocus(sender As Object, e As EventArgs) Handles txt_prenom.LostFocus
        Me.txt_prenom.Text = Microsoft.VisualBasic.StrConv(Me.txt_prenom.Text, VbStrConv.ProperCase)
    End Sub
    Private Sub txt_ville_LostFocus(sender As Object, e As EventArgs) Handles txt_ville.LostFocus
        Me.txt_ville.Text = Microsoft.VisualBasic.StrConv(Me.txt_ville.Text, VbStrConv.ProperCase)
    End Sub


    'Mise en place du compteur
    Private Sub Chrono_Tick(sender As Object, e As EventArgs) Handles Chrono.Tick
        decompte = 60 - cpt
        If cpt <= 60 Then
            cpt += 1
            LabelTimer.Text = "temps restant : " & decompte
            Me.Text = "Inscription " & TimeOfDay & " Temps restant: " & decompte
        Else
            Chrono.Stop()
        End If
        If cpt > 45 Then
            LabelTimer.ForeColor = Color.Red
        End If
        If decompte = 0 Then
            MsgBox("Temps écoulé")
            Accueil.Show()
            Me.Close()
        End If

        label_heure.Text = DateTime.Now
    End Sub

    'Barre verticale pour indiquer l'âge du candidat
    Private Sub HscrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Agescroll.Scroll
        txt_age.Text = Agescroll.Value & " ans"
    End Sub

    Function getcode()
        Return txt_code_postal
    End Function


End Class
