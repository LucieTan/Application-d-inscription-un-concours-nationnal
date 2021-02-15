<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modification_options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modification_options))
        Me.LbPrenom = New System.Windows.Forms.Label()
        Me.Lb_Nom = New System.Windows.Forms.Label()
        Me.Gb_ep_écrites = New System.Windows.Forms.GroupBox()
        Me.CK_12 = New System.Windows.Forms.CheckBox()
        Me.CK_11 = New System.Windows.Forms.CheckBox()
        Me.CK_10 = New System.Windows.Forms.CheckBox()
        Me.CK_9 = New System.Windows.Forms.CheckBox()
        Me.CK_8 = New System.Windows.Forms.CheckBox()
        Me.CK_7 = New System.Windows.Forms.CheckBox()
        Me.CK_6 = New System.Windows.Forms.CheckBox()
        Me.CK_5 = New System.Windows.Forms.CheckBox()
        Me.CK_4 = New System.Windows.Forms.CheckBox()
        Me.CK_3 = New System.Windows.Forms.CheckBox()
        Me.CK_2 = New System.Windows.Forms.CheckBox()
        Me.CK_1 = New System.Windows.Forms.CheckBox()
        Me.Gb_ep_orales = New System.Windows.Forms.GroupBox()
        Me.CK_17 = New System.Windows.Forms.CheckBox()
        Me.CK_19 = New System.Windows.Forms.CheckBox()
        Me.CK_13 = New System.Windows.Forms.CheckBox()
        Me.CK_21 = New System.Windows.Forms.CheckBox()
        Me.CK_20 = New System.Windows.Forms.CheckBox()
        Me.CK_18 = New System.Windows.Forms.CheckBox()
        Me.CK_16 = New System.Windows.Forms.CheckBox()
        Me.CK_15 = New System.Windows.Forms.CheckBox()
        Me.CK_14 = New System.Windows.Forms.CheckBox()
        Me.RegionCbBar = New System.Windows.Forms.ComboBox()
        Me.Prénom = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.Label()
        Me.btn_valide = New System.Windows.Forms.Button()
        Me.Btn_abandon = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_inscription = New System.Windows.Forms.Label()
        Me.Gb_ep_écrites.SuspendLayout()
        Me.Gb_ep_orales.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbPrenom
        '
        Me.LbPrenom.AutoSize = True
        Me.LbPrenom.BackColor = System.Drawing.Color.Transparent
        Me.LbPrenom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbPrenom.Location = New System.Drawing.Point(96, 197)
        Me.LbPrenom.Name = "LbPrenom"
        Me.LbPrenom.Size = New System.Drawing.Size(49, 13)
        Me.LbPrenom.TabIndex = 35
        Me.LbPrenom.Text = "Prénom :"
        '
        'Lb_Nom
        '
        Me.Lb_Nom.AutoSize = True
        Me.Lb_Nom.BackColor = System.Drawing.Color.Transparent
        Me.Lb_Nom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lb_Nom.Location = New System.Drawing.Point(110, 148)
        Me.Lb_Nom.Name = "Lb_Nom"
        Me.Lb_Nom.Size = New System.Drawing.Size(35, 13)
        Me.Lb_Nom.TabIndex = 34
        Me.Lb_Nom.Text = "Nom :"
        '
        'Gb_ep_écrites
        '
        Me.Gb_ep_écrites.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Gb_ep_écrites.Controls.Add(Me.CK_12)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_11)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_10)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_9)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_8)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_7)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_6)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_5)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_4)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_3)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_2)
        Me.Gb_ep_écrites.Controls.Add(Me.CK_1)
        Me.Gb_ep_écrites.Location = New System.Drawing.Point(196, 112)
        Me.Gb_ep_écrites.Name = "Gb_ep_écrites"
        Me.Gb_ep_écrites.Size = New System.Drawing.Size(297, 193)
        Me.Gb_ep_écrites.TabIndex = 33
        Me.Gb_ep_écrites.TabStop = False
        Me.Gb_ep_écrites.Text = "Epreuves écrites :"
        '
        'CK_12
        '
        Me.CK_12.AutoSize = True
        Me.CK_12.BackColor = System.Drawing.Color.Transparent
        Me.CK_12.Location = New System.Drawing.Point(163, 149)
        Me.CK_12.Name = "CK_12"
        Me.CK_12.Size = New System.Drawing.Size(111, 17)
        Me.CK_12.TabIndex = 14
        Me.CK_12.Text = "Visual Basic .NET"
        Me.CK_12.UseVisualStyleBackColor = False
        '
        'CK_11
        '
        Me.CK_11.AutoSize = True
        Me.CK_11.BackColor = System.Drawing.Color.Transparent
        Me.CK_11.Location = New System.Drawing.Point(163, 126)
        Me.CK_11.Name = "CK_11"
        Me.CK_11.Size = New System.Drawing.Size(66, 17)
        Me.CK_11.TabIndex = 13
        Me.CK_11.Text = "Système"
        Me.CK_11.UseVisualStyleBackColor = False
        '
        'CK_10
        '
        Me.CK_10.AutoSize = True
        Me.CK_10.BackColor = System.Drawing.Color.Transparent
        Me.CK_10.Location = New System.Drawing.Point(163, 103)
        Me.CK_10.Name = "CK_10"
        Me.CK_10.Size = New System.Drawing.Size(63, 17)
        Me.CK_10.TabIndex = 12
        Me.CK_10.Text = "Réseau"
        Me.CK_10.UseVisualStyleBackColor = False
        '
        'CK_9
        '
        Me.CK_9.AutoSize = True
        Me.CK_9.BackColor = System.Drawing.Color.Transparent
        Me.CK_9.Location = New System.Drawing.Point(163, 80)
        Me.CK_9.Name = "CK_9"
        Me.CK_9.Size = New System.Drawing.Size(122, 17)
        Me.CK_9.TabIndex = 11
        Me.CK_9.Text = "Programmation Web"
        Me.CK_9.UseVisualStyleBackColor = False
        '
        'CK_8
        '
        Me.CK_8.AutoSize = True
        Me.CK_8.BackColor = System.Drawing.Color.Transparent
        Me.CK_8.Location = New System.Drawing.Point(163, 54)
        Me.CK_8.Name = "CK_8"
        Me.CK_8.Size = New System.Drawing.Size(98, 17)
        Me.CK_8.TabIndex = 10
        Me.CK_8.Text = "Mathématiques"
        Me.CK_8.UseVisualStyleBackColor = False
        '
        'CK_7
        '
        Me.CK_7.AutoSize = True
        Me.CK_7.BackColor = System.Drawing.Color.Transparent
        Me.CK_7.Location = New System.Drawing.Point(163, 31)
        Me.CK_7.Name = "CK_7"
        Me.CK_7.Size = New System.Drawing.Size(94, 17)
        Me.CK_7.TabIndex = 9
        Me.CK_7.Text = "Langage Java"
        Me.CK_7.UseVisualStyleBackColor = False
        '
        'CK_6
        '
        Me.CK_6.AutoSize = True
        Me.CK_6.BackColor = System.Drawing.Color.Transparent
        Me.CK_6.Location = New System.Drawing.Point(7, 146)
        Me.CK_6.Name = "CK_6"
        Me.CK_6.Size = New System.Drawing.Size(78, 17)
        Me.CK_6.TabIndex = 8
        Me.CK_6.Text = "Langage C"
        Me.CK_6.UseVisualStyleBackColor = False
        '
        'CK_5
        '
        Me.CK_5.AutoSize = True
        Me.CK_5.BackColor = System.Drawing.Color.Transparent
        Me.CK_5.Location = New System.Drawing.Point(7, 123)
        Me.CK_5.Name = "CK_5"
        Me.CK_5.Size = New System.Drawing.Size(62, 17)
        Me.CK_5.TabIndex = 7
        Me.CK_5.Text = "Gestion"
        Me.CK_5.UseVisualStyleBackColor = False
        '
        'CK_4
        '
        Me.CK_4.AutoSize = True
        Me.CK_4.BackColor = System.Drawing.Color.Transparent
        Me.CK_4.Location = New System.Drawing.Point(7, 100)
        Me.CK_4.Name = "CK_4"
        Me.CK_4.Size = New System.Drawing.Size(77, 17)
        Me.CK_4.TabIndex = 6
        Me.CK_4.Text = "Expression"
        Me.CK_4.UseVisualStyleBackColor = False
        '
        'CK_3
        '
        Me.CK_3.AutoSize = True
        Me.CK_3.BackColor = System.Drawing.Color.Transparent
        Me.CK_3.Location = New System.Drawing.Point(7, 77)
        Me.CK_3.Name = "CK_3"
        Me.CK_3.Size = New System.Drawing.Size(48, 17)
        Me.CK_3.TabIndex = 5
        Me.CK_3.Text = "Droit"
        Me.CK_3.UseVisualStyleBackColor = False
        '
        'CK_2
        '
        Me.CK_2.AutoSize = True
        Me.CK_2.BackColor = System.Drawing.Color.Transparent
        Me.CK_2.Location = New System.Drawing.Point(7, 54)
        Me.CK_2.Name = "CK_2"
        Me.CK_2.Size = New System.Drawing.Size(109, 17)
        Me.CK_2.TabIndex = 4
        Me.CK_2.Text = "Base de données"
        Me.CK_2.UseVisualStyleBackColor = False
        '
        'CK_1
        '
        Me.CK_1.AutoSize = True
        Me.CK_1.BackColor = System.Drawing.Color.Transparent
        Me.CK_1.Location = New System.Drawing.Point(7, 31)
        Me.CK_1.Name = "CK_1"
        Me.CK_1.Size = New System.Drawing.Size(89, 17)
        Me.CK_1.TabIndex = 3
        Me.CK_1.Text = "Algorithmique"
        Me.CK_1.UseVisualStyleBackColor = False
        '
        'Gb_ep_orales
        '
        Me.Gb_ep_orales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Gb_ep_orales.Controls.Add(Me.CK_17)
        Me.Gb_ep_orales.Controls.Add(Me.CK_19)
        Me.Gb_ep_orales.Controls.Add(Me.CK_13)
        Me.Gb_ep_orales.Controls.Add(Me.CK_21)
        Me.Gb_ep_orales.Controls.Add(Me.CK_20)
        Me.Gb_ep_orales.Controls.Add(Me.CK_18)
        Me.Gb_ep_orales.Controls.Add(Me.CK_16)
        Me.Gb_ep_orales.Controls.Add(Me.CK_15)
        Me.Gb_ep_orales.Controls.Add(Me.CK_14)
        Me.Gb_ep_orales.Location = New System.Drawing.Point(515, 112)
        Me.Gb_ep_orales.Name = "Gb_ep_orales"
        Me.Gb_ep_orales.Size = New System.Drawing.Size(276, 157)
        Me.Gb_ep_orales.TabIndex = 32
        Me.Gb_ep_orales.TabStop = False
        Me.Gb_ep_orales.Text = "Epreuves orales :"
        '
        'CK_17
        '
        Me.CK_17.AutoSize = True
        Me.CK_17.BackColor = System.Drawing.Color.Transparent
        Me.CK_17.Location = New System.Drawing.Point(12, 121)
        Me.CK_17.Name = "CK_17"
        Me.CK_17.Size = New System.Drawing.Size(60, 17)
        Me.CK_17.TabIndex = 23
        Me.CK_17.Text = "Chinois"
        Me.CK_17.UseVisualStyleBackColor = False
        '
        'CK_19
        '
        Me.CK_19.AutoSize = True
        Me.CK_19.BackColor = System.Drawing.Color.Transparent
        Me.CK_19.Location = New System.Drawing.Point(168, 55)
        Me.CK_19.Name = "CK_19"
        Me.CK_19.Size = New System.Drawing.Size(70, 17)
        Me.CK_19.TabIndex = 22
        Me.CK_19.Text = "Espagnol"
        Me.CK_19.UseVisualStyleBackColor = False
        '
        'CK_13
        '
        Me.CK_13.AutoSize = True
        Me.CK_13.BackColor = System.Drawing.Color.Transparent
        Me.CK_13.Location = New System.Drawing.Point(13, 29)
        Me.CK_13.Name = "CK_13"
        Me.CK_13.Size = New System.Drawing.Size(60, 17)
        Me.CK_13.TabIndex = 21
        Me.CK_13.Text = "Anglais"
        Me.CK_13.UseVisualStyleBackColor = False
        '
        'CK_21
        '
        Me.CK_21.AutoSize = True
        Me.CK_21.BackColor = System.Drawing.Color.Transparent
        Me.CK_21.Location = New System.Drawing.Point(168, 101)
        Me.CK_21.Name = "CK_21"
        Me.CK_21.Size = New System.Drawing.Size(66, 17)
        Me.CK_21.TabIndex = 20
        Me.CK_21.Text = "Système"
        Me.CK_21.UseVisualStyleBackColor = False
        '
        'CK_20
        '
        Me.CK_20.AutoSize = True
        Me.CK_20.BackColor = System.Drawing.Color.Transparent
        Me.CK_20.Location = New System.Drawing.Point(168, 78)
        Me.CK_20.Name = "CK_20"
        Me.CK_20.Size = New System.Drawing.Size(63, 17)
        Me.CK_20.TabIndex = 19
        Me.CK_20.Text = "Réseau"
        Me.CK_20.UseVisualStyleBackColor = False
        '
        'CK_18
        '
        Me.CK_18.AutoSize = True
        Me.CK_18.BackColor = System.Drawing.Color.Transparent
        Me.CK_18.Location = New System.Drawing.Point(168, 29)
        Me.CK_18.Name = "CK_18"
        Me.CK_18.Size = New System.Drawing.Size(98, 17)
        Me.CK_18.TabIndex = 18
        Me.CK_18.Text = "Mathématiques"
        Me.CK_18.UseVisualStyleBackColor = False
        '
        'CK_16
        '
        Me.CK_16.AutoSize = True
        Me.CK_16.BackColor = System.Drawing.Color.Transparent
        Me.CK_16.Location = New System.Drawing.Point(12, 98)
        Me.CK_16.Name = "CK_16"
        Me.CK_16.Size = New System.Drawing.Size(62, 17)
        Me.CK_16.TabIndex = 17
        Me.CK_16.Text = "Gestion"
        Me.CK_16.UseVisualStyleBackColor = False
        '
        'CK_15
        '
        Me.CK_15.AutoSize = True
        Me.CK_15.BackColor = System.Drawing.Color.Transparent
        Me.CK_15.Location = New System.Drawing.Point(12, 75)
        Me.CK_15.Name = "CK_15"
        Me.CK_15.Size = New System.Drawing.Size(77, 17)
        Me.CK_15.TabIndex = 16
        Me.CK_15.Text = "Expression"
        Me.CK_15.UseVisualStyleBackColor = False
        '
        'CK_14
        '
        Me.CK_14.AutoSize = True
        Me.CK_14.BackColor = System.Drawing.Color.Transparent
        Me.CK_14.Location = New System.Drawing.Point(12, 52)
        Me.CK_14.Name = "CK_14"
        Me.CK_14.Size = New System.Drawing.Size(48, 17)
        Me.CK_14.TabIndex = 15
        Me.CK_14.Text = "Droit"
        Me.CK_14.UseVisualStyleBackColor = False
        '
        'RegionCbBar
        '
        Me.RegionCbBar.FormattingEnabled = True
        Me.RegionCbBar.Items.AddRange(New Object() {"Auverge", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"})
        Me.RegionCbBar.Location = New System.Drawing.Point(14, 243)
        Me.RegionCbBar.Name = "RegionCbBar"
        Me.RegionCbBar.Size = New System.Drawing.Size(149, 21)
        Me.RegionCbBar.TabIndex = 31
        '
        'Prénom
        '
        Me.Prénom.AutoSize = True
        Me.Prénom.BackColor = System.Drawing.Color.Transparent
        Me.Prénom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Prénom.Location = New System.Drawing.Point(25, 197)
        Me.Prénom.Name = "Prénom"
        Me.Prénom.Size = New System.Drawing.Size(49, 13)
        Me.Prénom.TabIndex = 30
        Me.Prénom.Text = "Prénom :"
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.BackColor = System.Drawing.Color.Transparent
        Me.Nom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Nom.Location = New System.Drawing.Point(36, 148)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(35, 13)
        Me.Nom.TabIndex = 29
        Me.Nom.Text = "Nom :"
        '
        'btn_valide
        '
        Me.btn_valide.Location = New System.Drawing.Point(619, 383)
        Me.btn_valide.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_valide.Name = "btn_valide"
        Me.btn_valide.Size = New System.Drawing.Size(80, 40)
        Me.btn_valide.TabIndex = 48
        Me.btn_valide.Text = "Valider"
        Me.btn_valide.UseVisualStyleBackColor = True
        '
        'Btn_abandon
        '
        Me.Btn_abandon.Location = New System.Drawing.Point(484, 383)
        Me.Btn_abandon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_abandon.Name = "Btn_abandon"
        Me.Btn_abandon.Size = New System.Drawing.Size(80, 40)
        Me.Btn_abandon.TabIndex = 47
        Me.Btn_abandon.Text = "Abandonner"
        Me.Btn_abandon.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Algorithmique", "Base de données", "Droit", "Expression", "Gestion", "Langage C", "Langage Java", "Mathématiques", "Programmation Web", "Réseau", "Système", "Visual Basic .NET", "Anglais", "Chinois", "Espagnol"})
        Me.ComboBox1.Location = New System.Drawing.Point(284, 370)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 46
        Me.ComboBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(59, 373)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "S'inscrire à une épreuve facultative :"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(682, 283)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "compteur oral"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(383, 319)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "compteur ecrit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(531, 283)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nbre d'épreuves restantes :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(245, 319)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nbre d'épreuves restantes :"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton2.Location = New System.Drawing.Point(178, 411)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton2.TabIndex = 40
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Non"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton1.Location = New System.Drawing.Point(114, 411)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton1.TabIndex = 39
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Oui"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(-6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(810, 24)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "________________________________________________________________________________"
        '
        'label_inscription
        '
        Me.label_inscription.AutoSize = True
        Me.label_inscription.BackColor = System.Drawing.Color.Transparent
        Me.label_inscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_inscription.Location = New System.Drawing.Point(309, 22)
        Me.label_inscription.Name = "label_inscription"
        Me.label_inscription.Size = New System.Drawing.Size(184, 25)
        Me.label_inscription.TabIndex = 49
        Me.label_inscription.Text = "Choix des options"
        '
        'modification_options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label_inscription)
        Me.Controls.Add(Me.btn_valide)
        Me.Controls.Add(Me.Btn_abandon)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LbPrenom)
        Me.Controls.Add(Me.Lb_Nom)
        Me.Controls.Add(Me.Gb_ep_écrites)
        Me.Controls.Add(Me.Gb_ep_orales)
        Me.Controls.Add(Me.RegionCbBar)
        Me.Controls.Add(Me.Prénom)
        Me.Controls.Add(Me.Nom)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "modification_options"
        Me.Text = "modification_options"
        Me.Gb_ep_écrites.ResumeLayout(False)
        Me.Gb_ep_écrites.PerformLayout()
        Me.Gb_ep_orales.ResumeLayout(False)
        Me.Gb_ep_orales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbPrenom As Label
    Friend WithEvents Lb_Nom As Label
    Friend WithEvents Gb_ep_écrites As GroupBox
    Friend WithEvents CK_12 As CheckBox
    Friend WithEvents CK_11 As CheckBox
    Friend WithEvents CK_10 As CheckBox
    Friend WithEvents CK_9 As CheckBox
    Friend WithEvents CK_8 As CheckBox
    Friend WithEvents CK_7 As CheckBox
    Friend WithEvents CK_6 As CheckBox
    Friend WithEvents CK_5 As CheckBox
    Friend WithEvents CK_4 As CheckBox
    Friend WithEvents CK_3 As CheckBox
    Friend WithEvents CK_2 As CheckBox
    Friend WithEvents CK_1 As CheckBox
    Friend WithEvents Gb_ep_orales As GroupBox
    Friend WithEvents CK_17 As CheckBox
    Friend WithEvents CK_19 As CheckBox
    Friend WithEvents CK_13 As CheckBox
    Friend WithEvents CK_21 As CheckBox
    Friend WithEvents CK_20 As CheckBox
    Friend WithEvents CK_18 As CheckBox
    Friend WithEvents CK_16 As CheckBox
    Friend WithEvents CK_15 As CheckBox
    Friend WithEvents CK_14 As CheckBox
    Friend WithEvents RegionCbBar As ComboBox
    Friend WithEvents Prénom As Label
    Friend WithEvents Nom As Label
    Friend WithEvents btn_valide As Button
    Friend WithEvents Btn_abandon As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents label_inscription As Label
End Class
