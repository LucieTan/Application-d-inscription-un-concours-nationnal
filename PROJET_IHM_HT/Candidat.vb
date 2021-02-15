Module Candidat
    Structure CANDIDATURE
        Dim nom As String
        Dim prenom As String
        Dim Id_Inst As String
        Dim Num_Inst As Integer
        Dim code_post As String
        Dim Ville As String
        Dim Adresse As String
        Dim Age As String
        Dim Epr_ecrite() As String
        Dim Epr_oral() As String
        Dim Epr_fac As String
        Dim Region As String

    End Structure
    Dim Candidats As CANDIDATURE()
    Dim nbCandidats As Integer = 0
    Dim CExist As Boolean = False
    Dim indice As Integer

    Sub init()
        ReDim Preserve Candidats(nbCandidats)
    End Sub
    Sub AjouterCandidat()
        nbCandidats += 1
        ReDim Preserve Candidats(nbCandidats)
    End Sub

    Sub ajout(c As CANDIDATURE)
        Candidats(nbCandidats) = c
    End Sub

    Sub Supp(c As Integer)
        Dim CandidatsT(nbCandidats) As CANDIDATURE
        For i = 0 To nbCandidats
            CandidatsT(i) = Candidats(i)
        Next
        For i = 0 To nbCandidats - 1
            If i >= c Then
                Candidats(i) = CandidatsT(i + 1)
            Else
                Candidats(i) = CandidatsT(i)
            End If
        Next
    End Sub

    Sub majInscription()
        For i As Integer = 0 To (nbCandidats - 1)
            If Inscription_form.txt_Nom.Text = Candidats(i).nom Then
                CExist = True
                indice = i
            Else CExist = False
            End If
        Next i
        If CExist = True Then
            Candidats(indice).nom = Modification_candidats.getnom()
            Candidats(indice).prenom = Modification_candidats.getprenom()
            Candidats(indice).Adresse = Modification_candidats.getadresse()
            Candidats(indice).Age = Modification_candidats.getage()
            Candidats(indice).Ville = Modification_candidats.getville()
            Candidats(indice).code_post = Modification_candidats.getcode_p()

        Else

            Dim C As CANDIDATURE
            C.nom = Inscription_form.txt_Nom.Text
            C.prenom = Inscription_form.txt_prenom.Text
            C.Adresse = Inscription_form.txt_adr.Text
            C.Age = Inscription_form.txt_age.Text
            C.Ville = Inscription_form.txt_ville.Text
            C.code_post = Inscription_form.txt_code_postal.Text

            Candidat.ajout(C)

        End If
    End Sub

    Sub majOption()
        Dim C As CANDIDATURE
        Dim cpt As Integer
        cpt = 0
        C = Candidats(nbCandidats)
        ReDim C.Epr_ecrite(3)
        ReDim C.Epr_oral(2)

        If Form_Opt.CK_1.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_1.Text
            cpt += 1
        End If
        If Form_Opt.CK_2.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_2.Text
            cpt += 1
        End If
        If Form_Opt.CK_3.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_3.Text
            cpt += 1
        End If
        If Form_Opt.CK_4.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_4.Text
            cpt += 1
        End If
        If Form_Opt.CK_5.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_5.Text
            cpt += 1
        End If
        If Form_Opt.CK_6.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_6.Text
            cpt += 1
        End If
        If Form_Opt.CK_7.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_7.Text
            cpt += 1
        End If
        If Form_Opt.CK_8.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_8.Text
            cpt += 1
        End If
        If Form_Opt.CK_9.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_9.Text
            cpt += 1
        End If
        If Form_Opt.CK_10.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_10.Text
            cpt += 1
        End If
        If Form_Opt.CK_11.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_11.Text
            cpt += 1
        End If
        If Form_Opt.CK_12.Checked = True Then
            C.Epr_ecrite(cpt) = Form_Opt.CK_12.Text
            cpt += 1
        End If

        cpt = 0

        If Form_Opt.CK_13.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_13.Text
            cpt += 1
        End If
        If Form_Opt.CK_14.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_14.Text
            cpt += 1
        End If
        If Form_Opt.CK_15.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_15.Text
            cpt += 1
        End If
        If Form_Opt.CK_16.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_16.Text
            cpt += 1
        End If
        If Form_Opt.CK_17.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_17.Text
            cpt += 1
        End If
        If Form_Opt.CK_18.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_18.Text
            cpt += 1
        End If
        If Form_Opt.CK_19.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_19.Text
            cpt += 1
        End If
        If Form_Opt.CK_20.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_20.Text
            cpt += 1
        End If
        If Form_Opt.CK_21.Checked = True Then
            C.Epr_oral(cpt) = Form_Opt.CK_21.Text
            cpt += 1
        End If

        If Form_Opt.RadioButton1.Checked = True Then
            C.Epr_fac = Form_Opt.ComboBox1.SelectedItem.ToString

        Else
            C.Epr_fac = "Pas d'épreuves"
        End If

        C.Region = Form_Opt.RegionCbBar.SelectedItem.ToString

        C.Num_Inst = nbCandidats + 1
        Candidat.ajout(C)

    End Sub

    Sub sauv()
        Dim stock As Integer = FreeFile()
        FileOpen(stock, "D:\LUCIE\IUT\Période D\IHM\PROJET_IHM_HT\PROJET_IHM_HT\Recap_inscription\inscriptions.txt", OpenMode.Output) 'Attention au chemin d'accès :)
        For i As Integer = 0 To nbCandidats - 1
            Write(stock, Candidats(i).Num_Inst)
            Write(stock, Candidats(i).nom)
            Write(stock, Candidats(i).prenom)
            Write(stock, Candidats(i).Age)
            Write(stock, Candidats(i).Adresse)
            Write(stock, Candidats(i).code_post)
            Write(stock, Candidats(i).Ville)


        Next i
        FileClose(stock)
    End Sub

    'Listes
    Sub listId()
        For i As Integer = 0 To nbCandidats - 1
            Etat_des_candidatures.ListBox_Id.Items.Add(Candidats(i).Num_Inst)
            Etat_des_candidatures.ListBox_Id.Items.Add("")

        Next i
    End Sub
    Sub listNP()
        For i As Integer = 0 To nbCandidats - 1
            Etat_des_candidatures.ListBox_Nom_Prenom.Items.Add(Candidats(i).nom + " " + Candidats(i).prenom)
            Etat_des_candidatures.ListBox_Nom_Prenom.Items.Add("")
        Next i
    End Sub


    Sub listecritorale()
        For i As Integer = 0 To nbCandidats - 1
            Etat_des_candidatures.ListBox2.Items.Add("(écrites) " + Candidats(i).Epr_ecrite(0) + "," + Candidats(i).Epr_ecrite(1) + "," + Candidats(i).Epr_ecrite(2) _
                                                               + "," + Candidats(i).Epr_ecrite(3))
            Etat_des_candidatures.ListBox2.Items.Add("(orales) " + Candidats(i).Epr_oral(0) + "," + Candidats(i).Epr_oral(1) +
                                                               "," + Candidats(i).Epr_oral(2))
        Next i
    End Sub

    Sub listEprFac()
        For i As Integer = 0 To nbCandidats - 1
            Etat_des_candidatures.ListBox3.Items.Add(Candidats(i).Epr_fac)
            Etat_des_candidatures.ListBox3.Items.Add("")

        Next i
    End Sub

    'Combobox des autres formulaires
    Sub Combo()
        For i As Integer = 0 To nbCandidats - 1
            Gestion_candidatures.Cb_Recherche.Items.Add(CStr(Candidats(i).Num_Inst) + " " + Candidats(i).nom + " " + Candidats(i).prenom)
        Next
    End Sub
    Sub Combobilan()
        For i As Integer = 0 To nbCandidats - 1
            Etat_des_candidatures.nom_prénom.Items.Add(Candidats(i).nom + " " + Candidats(i).prenom)
        Next
    End Sub

    Function matiere(val As String, i As Integer)

        If Candidats(i).Epr_ecrite(0) = val Or Candidats(i).Epr_ecrite(1) = val Or Candidats(i).Epr_ecrite(2) = val Or Candidats(i).Epr_ecrite(3) = val Or
                Candidats(i).Epr_oral(0) = val Or Candidats(i).Epr_oral(1) = val Or Candidats(i).Epr_oral(2) = val Or Candidats(i).Epr_fac = val Then
            Return True

        End If


        Return False


    End Function

    Function getnom(c As Integer)
        Return Candidats(c).nom
    End Function
    Function getprenom(c As Integer)
        Return Candidats(c).prenom
    End Function
    Function getadresse(c As Integer)
        Return Candidats(c).Adresse
    End Function
    Function getage(c As Integer)
        Return Candidats(c).Age
    End Function

    Function getville(c As Integer)
        Return Candidats(c).Ville
    End Function

    Function getcode_p(c As Integer)
        Return Candidats(c).code_post
    End Function

    Function getEpreEcrite(c As Integer, i As Integer)
        Return Candidats(c).Epr_ecrite(i)
    End Function

    Function getEpreOral(c As Integer, i As Integer)
        Return Candidats(c).Epr_oral(i)
    End Function

    Function getEpreFacultative(c As Integer)
        Return Candidats(c).Epr_fac
    End Function

    Function getNb_Candidat()
        Return nbCandidats
    End Function
    Function getNum_inst(c As Integer)
        Return Candidats(c).Num_Inst
    End Function
End Module
