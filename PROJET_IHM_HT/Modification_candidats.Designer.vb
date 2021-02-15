<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification_candidats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modification_candidats))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_inscription = New System.Windows.Forms.Label()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.txt_ville = New System.Windows.Forms.TextBox()
        Me.txt_code_postal = New System.Windows.Forms.TextBox()
        Me.txt_adr = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label_nom = New System.Windows.Forms.Label()
        Me.Label_prenom = New System.Windows.Forms.Label()
        Me.Label_adr = New System.Windows.Forms.Label()
        Me.Label_ville = New System.Windows.Forms.Label()
        Me.Label_code_postal = New System.Windows.Forms.Label()
        Me.Label_age = New System.Windows.Forms.Label()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.btn_valid = New System.Windows.Forms.Button()
        Me.btn_abandon = New System.Windows.Forms.Button()
        Me.label_oblg = New System.Windows.Forms.Label()
        Me.obligatoire2 = New System.Windows.Forms.Label()
        Me.obligatoire3 = New System.Windows.Forms.Label()
        Me.obligatoire4 = New System.Windows.Forms.Label()
        Me.obligatoire5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Agescroll = New System.Windows.Forms.HScrollBar()
        Me.PL = New System.Windows.Forms.Panel()
        Me.PL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(-5, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(810, 24)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "________________________________________________________________________________"
        '
        'label_inscription
        '
        Me.label_inscription.AutoSize = True
        Me.label_inscription.BackColor = System.Drawing.Color.Transparent
        Me.label_inscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_inscription.Location = New System.Drawing.Point(295, 14)
        Me.label_inscription.Name = "label_inscription"
        Me.label_inscription.Size = New System.Drawing.Size(264, 29)
        Me.label_inscription.TabIndex = 48
        Me.label_inscription.Text = "Formulaire d'inscription"
        '
        'txt_Nom
        '
        Me.txt_Nom.Location = New System.Drawing.Point(188, 40)
        Me.txt_Nom.MaxLength = 15
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(95, 20)
        Me.txt_Nom.TabIndex = 1
        '
        'txt_ville
        '
        Me.txt_ville.Location = New System.Drawing.Point(69, 207)
        Me.txt_ville.MaxLength = 15
        Me.txt_ville.Name = "txt_ville"
        Me.txt_ville.Size = New System.Drawing.Size(95, 20)
        Me.txt_ville.TabIndex = 5
        '
        'txt_code_postal
        '
        Me.txt_code_postal.Location = New System.Drawing.Point(188, 140)
        Me.txt_code_postal.MaxLength = 5
        Me.txt_code_postal.Name = "txt_code_postal"
        Me.txt_code_postal.Size = New System.Drawing.Size(69, 20)
        Me.txt_code_postal.TabIndex = 4
        '
        'txt_adr
        '
        Me.txt_adr.Location = New System.Drawing.Point(70, 140)
        Me.txt_adr.MaxLength = 30
        Me.txt_adr.Name = "txt_adr"
        Me.txt_adr.Size = New System.Drawing.Size(95, 20)
        Me.txt_adr.TabIndex = 3
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(69, 40)
        Me.txt_prenom.MaxLength = 20
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(95, 20)
        Me.txt_prenom.TabIndex = 0
        '
        'Label_nom
        '
        Me.Label_nom.AutoSize = True
        Me.Label_nom.BackColor = System.Drawing.Color.Transparent
        Me.Label_nom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_nom.Location = New System.Drawing.Point(185, 20)
        Me.Label_nom.Name = "Label_nom"
        Me.Label_nom.Size = New System.Drawing.Size(35, 13)
        Me.Label_nom.TabIndex = 33
        Me.Label_nom.Text = "Nom :"
        '
        'Label_prenom
        '
        Me.Label_prenom.AutoSize = True
        Me.Label_prenom.BackColor = System.Drawing.Color.Transparent
        Me.Label_prenom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_prenom.Location = New System.Drawing.Point(66, 20)
        Me.Label_prenom.Name = "Label_prenom"
        Me.Label_prenom.Size = New System.Drawing.Size(49, 13)
        Me.Label_prenom.TabIndex = 34
        Me.Label_prenom.Text = "Prénom :"
        '
        'Label_adr
        '
        Me.Label_adr.AutoSize = True
        Me.Label_adr.BackColor = System.Drawing.Color.Transparent
        Me.Label_adr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_adr.Location = New System.Drawing.Point(67, 119)
        Me.Label_adr.Name = "Label_adr"
        Me.Label_adr.Size = New System.Drawing.Size(51, 13)
        Me.Label_adr.TabIndex = 36
        Me.Label_adr.Text = "Adresse :"
        '
        'Label_ville
        '
        Me.Label_ville.AutoSize = True
        Me.Label_ville.BackColor = System.Drawing.Color.Transparent
        Me.Label_ville.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_ville.Location = New System.Drawing.Point(66, 186)
        Me.Label_ville.Name = "Label_ville"
        Me.Label_ville.Size = New System.Drawing.Size(32, 13)
        Me.Label_ville.TabIndex = 37
        Me.Label_ville.Text = "Ville :"
        '
        'Label_code_postal
        '
        Me.Label_code_postal.AutoSize = True
        Me.Label_code_postal.BackColor = System.Drawing.Color.Transparent
        Me.Label_code_postal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_code_postal.Location = New System.Drawing.Point(185, 119)
        Me.Label_code_postal.Name = "Label_code_postal"
        Me.Label_code_postal.Size = New System.Drawing.Size(69, 13)
        Me.Label_code_postal.TabIndex = 38
        Me.Label_code_postal.Text = "Code postal :"
        '
        'Label_age
        '
        Me.Label_age.AutoSize = True
        Me.Label_age.BackColor = System.Drawing.Color.Transparent
        Me.Label_age.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_age.Location = New System.Drawing.Point(395, 42)
        Me.Label_age.Name = "Label_age"
        Me.Label_age.Size = New System.Drawing.Size(32, 13)
        Me.Label_age.TabIndex = 39
        Me.Label_age.Text = "Âge :"
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(430, 40)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(42, 20)
        Me.txt_age.TabIndex = 2
        '
        'btn_valid
        '
        Me.btn_valid.Location = New System.Drawing.Point(419, 271)
        Me.btn_valid.Name = "btn_valid"
        Me.btn_valid.Size = New System.Drawing.Size(138, 65)
        Me.btn_valid.TabIndex = 40
        Me.btn_valid.Text = "Valider"
        Me.btn_valid.UseVisualStyleBackColor = True
        '
        'btn_abandon
        '
        Me.btn_abandon.Location = New System.Drawing.Point(145, 271)
        Me.btn_abandon.Name = "btn_abandon"
        Me.btn_abandon.Size = New System.Drawing.Size(138, 65)
        Me.btn_abandon.TabIndex = 41
        Me.btn_abandon.Text = "Abandonner"
        Me.btn_abandon.UseVisualStyleBackColor = True
        '
        'label_oblg
        '
        Me.label_oblg.AutoSize = True
        Me.label_oblg.BackColor = System.Drawing.Color.Transparent
        Me.label_oblg.ForeColor = System.Drawing.Color.Red
        Me.label_oblg.Location = New System.Drawing.Point(209, 20)
        Me.label_oblg.Name = "label_oblg"
        Me.label_oblg.Size = New System.Drawing.Size(11, 13)
        Me.label_oblg.TabIndex = 42
        Me.label_oblg.Text = "*"
        '
        'obligatoire2
        '
        Me.obligatoire2.AutoSize = True
        Me.obligatoire2.BackColor = System.Drawing.Color.Transparent
        Me.obligatoire2.ForeColor = System.Drawing.Color.Red
        Me.obligatoire2.Location = New System.Drawing.Point(106, 20)
        Me.obligatoire2.Name = "obligatoire2"
        Me.obligatoire2.Size = New System.Drawing.Size(11, 13)
        Me.obligatoire2.TabIndex = 43
        Me.obligatoire2.Text = "*"
        '
        'obligatoire3
        '
        Me.obligatoire3.AutoSize = True
        Me.obligatoire3.BackColor = System.Drawing.Color.Transparent
        Me.obligatoire3.ForeColor = System.Drawing.Color.Red
        Me.obligatoire3.Location = New System.Drawing.Point(88, 186)
        Me.obligatoire3.Name = "obligatoire3"
        Me.obligatoire3.Size = New System.Drawing.Size(11, 13)
        Me.obligatoire3.TabIndex = 44
        Me.obligatoire3.Text = "*"
        '
        'obligatoire4
        '
        Me.obligatoire4.AutoSize = True
        Me.obligatoire4.BackColor = System.Drawing.Color.Transparent
        Me.obligatoire4.ForeColor = System.Drawing.Color.Red
        Me.obligatoire4.Location = New System.Drawing.Point(246, 119)
        Me.obligatoire4.Name = "obligatoire4"
        Me.obligatoire4.Size = New System.Drawing.Size(11, 13)
        Me.obligatoire4.TabIndex = 45
        Me.obligatoire4.Text = "*"
        '
        'obligatoire5
        '
        Me.obligatoire5.AutoSize = True
        Me.obligatoire5.BackColor = System.Drawing.Color.Transparent
        Me.obligatoire5.ForeColor = System.Drawing.Color.Red
        Me.obligatoire5.Location = New System.Drawing.Point(416, 42)
        Me.obligatoire5.Name = "obligatoire5"
        Me.obligatoire5.Size = New System.Drawing.Size(11, 13)
        Me.obligatoire5.TabIndex = 46
        Me.obligatoire5.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(564, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "* champs obligatoires"
        '
        'Agescroll
        '
        Me.Agescroll.LargeChange = 1
        Me.Agescroll.Location = New System.Drawing.Point(392, 77)
        Me.Agescroll.Maximum = 55
        Me.Agescroll.Minimum = 18
        Me.Agescroll.Name = "Agescroll"
        Me.Agescroll.Size = New System.Drawing.Size(237, 22)
        Me.Agescroll.TabIndex = 50
        Me.Agescroll.Value = 18
        '
        'PL
        '
        Me.PL.BackColor = System.Drawing.Color.Transparent
        Me.PL.Controls.Add(Me.Agescroll)
        Me.PL.Controls.Add(Me.Label2)
        Me.PL.Controls.Add(Me.obligatoire5)
        Me.PL.Controls.Add(Me.obligatoire4)
        Me.PL.Controls.Add(Me.obligatoire3)
        Me.PL.Controls.Add(Me.obligatoire2)
        Me.PL.Controls.Add(Me.label_oblg)
        Me.PL.Controls.Add(Me.btn_abandon)
        Me.PL.Controls.Add(Me.btn_valid)
        Me.PL.Controls.Add(Me.txt_age)
        Me.PL.Controls.Add(Me.Label_age)
        Me.PL.Controls.Add(Me.Label_code_postal)
        Me.PL.Controls.Add(Me.Label_ville)
        Me.PL.Controls.Add(Me.Label_adr)
        Me.PL.Controls.Add(Me.Label_prenom)
        Me.PL.Controls.Add(Me.Label_nom)
        Me.PL.Controls.Add(Me.txt_prenom)
        Me.PL.Controls.Add(Me.txt_adr)
        Me.PL.Controls.Add(Me.txt_code_postal)
        Me.PL.Controls.Add(Me.txt_ville)
        Me.PL.Controls.Add(Me.txt_Nom)
        Me.PL.Location = New System.Drawing.Point(51, 81)
        Me.PL.Name = "PL"
        Me.PL.Size = New System.Drawing.Size(706, 357)
        Me.PL.TabIndex = 51
        '
        'Modification_candidats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_inscription)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Modification_candidats"
        Me.Text = "Modification candidats"
        Me.PL.ResumeLayout(False)
        Me.PL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents label_inscription As Label
    Friend WithEvents txt_Nom As TextBox
    Friend WithEvents txt_ville As TextBox
    Friend WithEvents txt_code_postal As TextBox
    Friend WithEvents txt_adr As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents Label_nom As Label
    Friend WithEvents Label_prenom As Label
    Friend WithEvents Label_adr As Label
    Friend WithEvents Label_ville As Label
    Friend WithEvents Label_code_postal As Label
    Friend WithEvents Label_age As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents btn_valid As Button
    Friend WithEvents btn_abandon As Button
    Friend WithEvents label_oblg As Label
    Friend WithEvents obligatoire2 As Label
    Friend WithEvents obligatoire3 As Label
    Friend WithEvents obligatoire4 As Label
    Friend WithEvents obligatoire5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Agescroll As HScrollBar
    Friend WithEvents PL As Panel
End Class
