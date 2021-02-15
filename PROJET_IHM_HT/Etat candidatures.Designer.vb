<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Etat_des_candidatures
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Etat_des_candidatures))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox_Id = New System.Windows.Forms.ListBox()
        Me.ListBox_Nom_Prenom = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label_epreuves = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label_facult = New System.Windows.Forms.Label()
        Me.nom_prénom = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cb_matiières = New System.Windows.Forms.ComboBox()
        Me.Btn_candidat = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_inscription = New System.Windows.Forms.Label()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_région = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(72, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Candidat"
        '
        'ListBox_Id
        '
        Me.ListBox_Id.FormattingEnabled = True
        Me.ListBox_Id.Location = New System.Drawing.Point(72, 131)
        Me.ListBox_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_Id.Name = "ListBox_Id"
        Me.ListBox_Id.Size = New System.Drawing.Size(63, 199)
        Me.ListBox_Id.TabIndex = 1
        '
        'ListBox_Nom_Prenom
        '
        Me.ListBox_Nom_Prenom.FormattingEnabled = True
        Me.ListBox_Nom_Prenom.Location = New System.Drawing.Point(150, 131)
        Me.ListBox_Nom_Prenom.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_Nom_Prenom.Name = "ListBox_Nom_Prenom"
        Me.ListBox_Nom_Prenom.Size = New System.Drawing.Size(137, 199)
        Me.ListBox_Nom_Prenom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(190, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(301, 131)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(198, 199)
        Me.ListBox2.TabIndex = 5
        '
        'Label_epreuves
        '
        Me.Label_epreuves.AutoSize = True
        Me.Label_epreuves.BackColor = System.Drawing.Color.Transparent
        Me.Label_epreuves.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_epreuves.Location = New System.Drawing.Point(298, 106)
        Me.Label_epreuves.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_epreuves.Name = "Label_epreuves"
        Me.Label_epreuves.Size = New System.Drawing.Size(119, 13)
        Me.Label_epreuves.TabIndex = 4
        Me.Label_epreuves.Text = "Epreuves écrites/orales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(159, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nom et Prénom"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(522, 131)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(137, 199)
        Me.ListBox3.TabIndex = 8
        '
        'Label_facult
        '
        Me.Label_facult.AutoSize = True
        Me.Label_facult.BackColor = System.Drawing.Color.Transparent
        Me.Label_facult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_facult.Location = New System.Drawing.Point(519, 106)
        Me.Label_facult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_facult.Name = "Label_facult"
        Me.Label_facult.Size = New System.Drawing.Size(99, 13)
        Me.Label_facult.TabIndex = 7
        Me.Label_facult.Text = "Epreuve facultative"
        '
        'nom_prénom
        '
        Me.nom_prénom.FormattingEnabled = True
        Me.nom_prénom.Location = New System.Drawing.Point(483, 381)
        Me.nom_prénom.Margin = New System.Windows.Forms.Padding(2)
        Me.nom_prénom.Name = "nom_prénom"
        Me.nom_prénom.Size = New System.Drawing.Size(154, 21)
        Me.nom_prénom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(480, 355)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nom et Prénom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(72, 355)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Matières"
        '
        'Cb_matiières
        '
        Me.Cb_matiières.FormattingEnabled = True
        Me.Cb_matiières.Items.AddRange(New Object() {"Algorithmique", "Base de données", "Droit", "Expression", "Gestion", "Langage C", "Langage Java", "Mathématiques", "Programmation Web", "Réseau", "Système", "Visual Basic .NET", "Anglais", "Chinois", "Espagnol"})
        Me.Cb_matiières.Location = New System.Drawing.Point(75, 379)
        Me.Cb_matiières.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_matiières.Name = "Cb_matiières"
        Me.Cb_matiières.Size = New System.Drawing.Size(154, 21)
        Me.Cb_matiières.TabIndex = 11
        '
        'Btn_candidat
        '
        Me.Btn_candidat.Location = New System.Drawing.Point(657, 373)
        Me.Btn_candidat.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_candidat.Name = "Btn_candidat"
        Me.Btn_candidat.Size = New System.Drawing.Size(91, 34)
        Me.Btn_candidat.TabIndex = 13
        Me.Btn_candidat.Text = "Candidats"
        Me.Btn_candidat.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(-2, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(810, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "________________________________________________________________________________"
        '
        'label_inscription
        '
        Me.label_inscription.AutoSize = True
        Me.label_inscription.BackColor = System.Drawing.Color.Transparent
        Me.label_inscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_inscription.Location = New System.Drawing.Point(372, 26)
        Me.label_inscription.Name = "label_inscription"
        Me.label_inscription.Size = New System.Drawing.Size(60, 25)
        Me.label_inscription.TabIndex = 18
        Me.label_inscription.Text = "Bilan"
        '
        'btn_retour
        '
        Me.btn_retour.Location = New System.Drawing.Point(659, 24)
        Me.btn_retour.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(107, 34)
        Me.btn_retour.TabIndex = 20
        Me.btn_retour.Text = "Retour à l'accueil"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(280, 355)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Région"
        '
        'cb_région
        '
        Me.cb_région.FormattingEnabled = True
        Me.cb_région.Items.AddRange(New Object() {"Auverge", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"})
        Me.cb_région.Location = New System.Drawing.Point(283, 379)
        Me.cb_région.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_région.Name = "cb_région"
        Me.cb_région.Size = New System.Drawing.Size(154, 21)
        Me.cb_région.TabIndex = 21
        '
        'Etat_des_candidatures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_région)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label_inscription)
        Me.Controls.Add(Me.Btn_candidat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cb_matiières)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nom_prénom)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label_facult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label_epreuves)
        Me.Controls.Add(Me.ListBox_Nom_Prenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox_Id)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Etat_des_candidatures"
        Me.Text = "Etat des candidatures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox_Id As ListBox
    Friend WithEvents ListBox_Nom_Prenom As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label_epreuves As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label_facult As Label
    Friend WithEvents nom_prénom As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cb_matiières As ComboBox
    Friend WithEvents Btn_candidat As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents label_inscription As Label
    Friend WithEvents btn_retour As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_région As ComboBox
End Class
