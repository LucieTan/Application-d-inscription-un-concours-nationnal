<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Récapitulatif
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Récapitulatif))
        Me.lb_eprv_facul = New System.Windows.Forms.Label()
        Me.lb_prénom = New System.Windows.Forms.Label()
        Me.lb_nom = New System.Windows.Forms.Label()
        Me.Labelfacul = New System.Windows.Forms.Label()
        Me.label_epr_oral = New System.Windows.Forms.Label()
        Me.label_eprecrites = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_abandon = New System.Windows.Forms.Button()
        Me.btn_valid = New System.Windows.Forms.Button()
        Me.label_inscription = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_age = New System.Windows.Forms.Label()
        Me.lb_adr = New System.Windows.Forms.Label()
        Me.label_adresse = New System.Windows.Forms.Label()
        Me.lb_ville = New System.Windows.Forms.Label()
        Me.lbville = New System.Windows.Forms.Label()
        Me.Btn_return = New System.Windows.Forms.Button()
        Me.Pl_eprv = New System.Windows.Forms.Panel()
        Me.lb_epr4 = New System.Windows.Forms.Label()
        Me.lb_epr3 = New System.Windows.Forms.Label()
        Me.lb_epr2 = New System.Windows.Forms.Label()
        Me.lb_epr1 = New System.Windows.Forms.Label()
        Me.code = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pl_etat = New System.Windows.Forms.Panel()
        Me.Pl_adr = New System.Windows.Forms.Panel()
        Me.Lb_oral3 = New System.Windows.Forms.Label()
        Me.Lb_oral2 = New System.Windows.Forms.Label()
        Me.Lb_oral1 = New System.Windows.Forms.Label()
        Me.Pl_eprv.SuspendLayout()
        Me.Pl_etat.SuspendLayout()
        Me.Pl_adr.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_eprv_facul
        '
        Me.lb_eprv_facul.AutoSize = True
        Me.lb_eprv_facul.BackColor = System.Drawing.Color.Transparent
        Me.lb_eprv_facul.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_eprv_facul.Location = New System.Drawing.Point(22, 216)
        Me.lb_eprv_facul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_eprv_facul.Name = "lb_eprv_facul"
        Me.lb_eprv_facul.Size = New System.Drawing.Size(93, 13)
        Me.lb_eprv_facul.TabIndex = 22
        Me.lb_eprv_facul.Text = "Epreuve facultatif "
        '
        'lb_prénom
        '
        Me.lb_prénom.AutoSize = True
        Me.lb_prénom.BackColor = System.Drawing.Color.Transparent
        Me.lb_prénom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_prénom.Location = New System.Drawing.Point(138, 59)
        Me.lb_prénom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_prénom.Name = "lb_prénom"
        Me.lb_prénom.Size = New System.Drawing.Size(46, 13)
        Me.lb_prénom.TabIndex = 19
        Me.lb_prénom.Text = "Prénom "
        '
        'lb_nom
        '
        Me.lb_nom.AutoSize = True
        Me.lb_nom.BackColor = System.Drawing.Color.Transparent
        Me.lb_nom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_nom.Location = New System.Drawing.Point(138, 23)
        Me.lb_nom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(32, 13)
        Me.lb_nom.TabIndex = 18
        Me.lb_nom.Text = "Nom "
        '
        'Labelfacul
        '
        Me.Labelfacul.AutoSize = True
        Me.Labelfacul.BackColor = System.Drawing.Color.Transparent
        Me.Labelfacul.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Labelfacul.Location = New System.Drawing.Point(22, 190)
        Me.Labelfacul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelfacul.Name = "Labelfacul"
        Me.Labelfacul.Size = New System.Drawing.Size(96, 13)
        Me.Labelfacul.TabIndex = 17
        Me.Labelfacul.Text = "Epreuve facultatif :"
        '
        'label_epr_oral
        '
        Me.label_epr_oral.AutoSize = True
        Me.label_epr_oral.BackColor = System.Drawing.Color.Transparent
        Me.label_epr_oral.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.label_epr_oral.Location = New System.Drawing.Point(22, 118)
        Me.label_epr_oral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_epr_oral.Name = "label_epr_oral"
        Me.label_epr_oral.Size = New System.Drawing.Size(89, 13)
        Me.label_epr_oral.TabIndex = 16
        Me.label_epr_oral.Text = "Epreuves orales :"
        '
        'label_eprecrites
        '
        Me.label_eprecrites.AutoSize = True
        Me.label_eprecrites.BackColor = System.Drawing.Color.Transparent
        Me.label_eprecrites.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.label_eprecrites.Location = New System.Drawing.Point(22, 19)
        Me.label_eprecrites.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_eprecrites.Name = "label_eprecrites"
        Me.label_eprecrites.Size = New System.Drawing.Size(92, 13)
        Me.label_eprecrites.TabIndex = 15
        Me.label_eprecrites.Text = "Epreuves écrites :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Prénom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nom :"
        '
        'btn_abandon
        '
        Me.btn_abandon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_abandon.Location = New System.Drawing.Point(318, 363)
        Me.btn_abandon.Name = "btn_abandon"
        Me.btn_abandon.Size = New System.Drawing.Size(138, 65)
        Me.btn_abandon.TabIndex = 24
        Me.btn_abandon.Text = "Abandonner"
        Me.btn_abandon.UseVisualStyleBackColor = True
        '
        'btn_valid
        '
        Me.btn_valid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_valid.Location = New System.Drawing.Point(50, 363)
        Me.btn_valid.Name = "btn_valid"
        Me.btn_valid.Size = New System.Drawing.Size(138, 65)
        Me.btn_valid.TabIndex = 23
        Me.btn_valid.Text = "Valider"
        Me.btn_valid.UseVisualStyleBackColor = True
        '
        'label_inscription
        '
        Me.label_inscription.AutoSize = True
        Me.label_inscription.BackColor = System.Drawing.Color.Transparent
        Me.label_inscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_inscription.Location = New System.Drawing.Point(325, 27)
        Me.label_inscription.Name = "label_inscription"
        Me.label_inscription.Size = New System.Drawing.Size(145, 29)
        Me.label_inscription.TabIndex = 25
        Me.label_inscription.Text = "Récapitulatif"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(-5, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(810, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "________________________________________________________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(263, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Âge :"
        '
        'lb_age
        '
        Me.lb_age.AutoSize = True
        Me.lb_age.BackColor = System.Drawing.Color.Transparent
        Me.lb_age.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_age.Location = New System.Drawing.Point(328, 39)
        Me.lb_age.Name = "lb_age"
        Me.lb_age.Size = New System.Drawing.Size(29, 13)
        Me.lb_age.TabIndex = 28
        Me.lb_age.Text = "Âge "
        '
        'lb_adr
        '
        Me.lb_adr.AutoSize = True
        Me.lb_adr.BackColor = System.Drawing.Color.Transparent
        Me.lb_adr.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_adr.Location = New System.Drawing.Point(137, 7)
        Me.lb_adr.Name = "lb_adr"
        Me.lb_adr.Size = New System.Drawing.Size(45, 13)
        Me.lb_adr.TabIndex = 30
        Me.lb_adr.Text = "Adresse"
        '
        'label_adresse
        '
        Me.label_adresse.AutoSize = True
        Me.label_adresse.BackColor = System.Drawing.Color.Transparent
        Me.label_adresse.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.label_adresse.Location = New System.Drawing.Point(13, 7)
        Me.label_adresse.Name = "label_adresse"
        Me.label_adresse.Size = New System.Drawing.Size(54, 13)
        Me.label_adresse.TabIndex = 29
        Me.label_adresse.Text = "Adresse : "
        '
        'lb_ville
        '
        Me.lb_ville.AutoSize = True
        Me.lb_ville.BackColor = System.Drawing.Color.Transparent
        Me.lb_ville.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_ville.Location = New System.Drawing.Point(137, 44)
        Me.lb_ville.Name = "lb_ville"
        Me.lb_ville.Size = New System.Drawing.Size(26, 13)
        Me.lb_ville.TabIndex = 32
        Me.lb_ville.Text = "Ville"
        '
        'lbville
        '
        Me.lbville.AutoSize = True
        Me.lbville.BackColor = System.Drawing.Color.Transparent
        Me.lbville.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbville.Location = New System.Drawing.Point(13, 44)
        Me.lbville.Name = "lbville"
        Me.lbville.Size = New System.Drawing.Size(32, 13)
        Me.lbville.TabIndex = 31
        Me.lbville.Text = "Ville :"
        '
        'Btn_return
        '
        Me.Btn_return.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_return.Location = New System.Drawing.Point(581, 363)
        Me.Btn_return.Name = "Btn_return"
        Me.Btn_return.Size = New System.Drawing.Size(138, 65)
        Me.Btn_return.TabIndex = 33
        Me.Btn_return.Text = "Retour en arrière"
        Me.Btn_return.UseVisualStyleBackColor = True
        '
        'Pl_eprv
        '
        Me.Pl_eprv.BackColor = System.Drawing.Color.Transparent
        Me.Pl_eprv.Controls.Add(Me.Lb_oral3)
        Me.Pl_eprv.Controls.Add(Me.Lb_oral2)
        Me.Pl_eprv.Controls.Add(Me.Lb_oral1)
        Me.Pl_eprv.Controls.Add(Me.lb_epr4)
        Me.Pl_eprv.Controls.Add(Me.lb_epr3)
        Me.Pl_eprv.Controls.Add(Me.lb_epr2)
        Me.Pl_eprv.Controls.Add(Me.lb_epr1)
        Me.Pl_eprv.Controls.Add(Me.lb_eprv_facul)
        Me.Pl_eprv.Controls.Add(Me.Labelfacul)
        Me.Pl_eprv.Controls.Add(Me.label_epr_oral)
        Me.Pl_eprv.Controls.Add(Me.label_eprecrites)
        Me.Pl_eprv.ForeColor = System.Drawing.Color.Transparent
        Me.Pl_eprv.Location = New System.Drawing.Point(556, 97)
        Me.Pl_eprv.Name = "Pl_eprv"
        Me.Pl_eprv.Size = New System.Drawing.Size(180, 247)
        Me.Pl_eprv.TabIndex = 36
        '
        'lb_epr4
        '
        Me.lb_epr4.AutoSize = True
        Me.lb_epr4.BackColor = System.Drawing.Color.Transparent
        Me.lb_epr4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_epr4.Location = New System.Drawing.Point(22, 81)
        Me.lb_epr4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_epr4.Name = "lb_epr4"
        Me.lb_epr4.Size = New System.Drawing.Size(33, 13)
        Me.lb_epr4.TabIndex = 26
        Me.lb_epr4.Text = "ecrit4"
        '
        'lb_epr3
        '
        Me.lb_epr3.AutoSize = True
        Me.lb_epr3.BackColor = System.Drawing.Color.Transparent
        Me.lb_epr3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_epr3.Location = New System.Drawing.Point(22, 68)
        Me.lb_epr3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_epr3.Name = "lb_epr3"
        Me.lb_epr3.Size = New System.Drawing.Size(30, 13)
        Me.lb_epr3.TabIndex = 25
        Me.lb_epr3.Text = "ecri3"
        '
        'lb_epr2
        '
        Me.lb_epr2.AutoSize = True
        Me.lb_epr2.BackColor = System.Drawing.Color.Transparent
        Me.lb_epr2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_epr2.Location = New System.Drawing.Point(22, 55)
        Me.lb_epr2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_epr2.Name = "lb_epr2"
        Me.lb_epr2.Size = New System.Drawing.Size(33, 13)
        Me.lb_epr2.TabIndex = 24
        Me.lb_epr2.Text = "ecrit2"
        '
        'lb_epr1
        '
        Me.lb_epr1.AutoSize = True
        Me.lb_epr1.BackColor = System.Drawing.Color.Transparent
        Me.lb_epr1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lb_epr1.Location = New System.Drawing.Point(22, 42)
        Me.lb_epr1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_epr1.Name = "lb_epr1"
        Me.lb_epr1.Size = New System.Drawing.Size(33, 13)
        Me.lb_epr1.TabIndex = 23
        Me.lb_epr1.Text = "ecrit1"
        '
        'code
        '
        Me.code.AutoSize = True
        Me.code.BackColor = System.Drawing.Color.Transparent
        Me.code.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.code.Location = New System.Drawing.Point(137, 82)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(31, 13)
        Me.code.TabIndex = 38
        Me.code.Text = "code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(13, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Code postal :"
        '
        'Pl_etat
        '
        Me.Pl_etat.BackColor = System.Drawing.Color.Transparent
        Me.Pl_etat.Controls.Add(Me.lb_age)
        Me.Pl_etat.Controls.Add(Me.Label7)
        Me.Pl_etat.Controls.Add(Me.lb_prénom)
        Me.Pl_etat.Controls.Add(Me.lb_nom)
        Me.Pl_etat.Controls.Add(Me.Label2)
        Me.Pl_etat.Controls.Add(Me.Label1)
        Me.Pl_etat.Location = New System.Drawing.Point(65, 97)
        Me.Pl_etat.Name = "Pl_etat"
        Me.Pl_etat.Size = New System.Drawing.Size(427, 93)
        Me.Pl_etat.TabIndex = 39
        '
        'Pl_adr
        '
        Me.Pl_adr.BackColor = System.Drawing.Color.Transparent
        Me.Pl_adr.Controls.Add(Me.code)
        Me.Pl_adr.Controls.Add(Me.Label5)
        Me.Pl_adr.Controls.Add(Me.lb_ville)
        Me.Pl_adr.Controls.Add(Me.lbville)
        Me.Pl_adr.Controls.Add(Me.lb_adr)
        Me.Pl_adr.Controls.Add(Me.label_adresse)
        Me.Pl_adr.Location = New System.Drawing.Point(66, 215)
        Me.Pl_adr.Name = "Pl_adr"
        Me.Pl_adr.Size = New System.Drawing.Size(425, 111)
        Me.Pl_adr.TabIndex = 40
        '
        'Lb_oral3
        '
        Me.Lb_oral3.AutoSize = True
        Me.Lb_oral3.BackColor = System.Drawing.Color.Transparent
        Me.Lb_oral3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_oral3.Location = New System.Drawing.Point(22, 167)
        Me.Lb_oral3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_oral3.Name = "Lb_oral3"
        Me.Lb_oral3.Size = New System.Drawing.Size(33, 13)
        Me.Lb_oral3.TabIndex = 29
        Me.Lb_oral3.Text = "ecrit4"
        '
        'Lb_oral2
        '
        Me.Lb_oral2.AutoSize = True
        Me.Lb_oral2.BackColor = System.Drawing.Color.Transparent
        Me.Lb_oral2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_oral2.Location = New System.Drawing.Point(22, 154)
        Me.Lb_oral2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_oral2.Name = "Lb_oral2"
        Me.Lb_oral2.Size = New System.Drawing.Size(30, 13)
        Me.Lb_oral2.TabIndex = 28
        Me.Lb_oral2.Text = "ecri3"
        '
        'Lb_oral1
        '
        Me.Lb_oral1.AutoSize = True
        Me.Lb_oral1.BackColor = System.Drawing.Color.Transparent
        Me.Lb_oral1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lb_oral1.Location = New System.Drawing.Point(22, 141)
        Me.Lb_oral1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_oral1.Name = "Lb_oral1"
        Me.Lb_oral1.Size = New System.Drawing.Size(33, 13)
        Me.Lb_oral1.TabIndex = 27
        Me.Lb_oral1.Text = "ecrit2"
        '
        'Récapitulatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pl_adr)
        Me.Controls.Add(Me.Pl_etat)
        Me.Controls.Add(Me.Pl_eprv)
        Me.Controls.Add(Me.Btn_return)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label_inscription)
        Me.Controls.Add(Me.btn_abandon)
        Me.Controls.Add(Me.btn_valid)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Récapitulatif"
        Me.Text = "Récapitulatif"
        Me.Pl_eprv.ResumeLayout(False)
        Me.Pl_eprv.PerformLayout()
        Me.Pl_etat.ResumeLayout(False)
        Me.Pl_etat.PerformLayout()
        Me.Pl_adr.ResumeLayout(False)
        Me.Pl_adr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_eprv_facul As Label
    Friend WithEvents lb_prénom As Label
    Friend WithEvents lb_nom As Label
    Friend WithEvents Labelfacul As Label
    Friend WithEvents label_epr_oral As Label
    Friend WithEvents label_eprecrites As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_abandon As Button
    Friend WithEvents btn_valid As Button
    Friend WithEvents label_inscription As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_age As Label
    Friend WithEvents lb_adr As Label
    Friend WithEvents label_adresse As Label
    Friend WithEvents lb_ville As Label
    Friend WithEvents lbville As Label
    Friend WithEvents Btn_return As Button
    Friend WithEvents Pl_eprv As Panel
    Friend WithEvents code As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Pl_etat As Panel
    Friend WithEvents Pl_adr As Panel
    Friend WithEvents lb_epr4 As Label
    Friend WithEvents lb_epr3 As Label
    Friend WithEvents lb_epr2 As Label
    Friend WithEvents lb_epr1 As Label
    Friend WithEvents Lb_oral3 As Label
    Friend WithEvents Lb_oral2 As Label
    Friend WithEvents Lb_oral1 As Label
End Class
