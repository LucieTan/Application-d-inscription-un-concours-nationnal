<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.Btn_open_form1 = New System.Windows.Forms.Button()
        Me.Btn_gere_inscriptions = New System.Windows.Forms.Button()
        Me.btn_provisoire = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_inscription = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_open_form1
        '
        Me.Btn_open_form1.BackColor = System.Drawing.Color.White
        Me.Btn_open_form1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Btn_open_form1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_open_form1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_open_form1.Location = New System.Drawing.Point(63, 29)
        Me.Btn_open_form1.Name = "Btn_open_form1"
        Me.Btn_open_form1.Size = New System.Drawing.Size(150, 50)
        Me.Btn_open_form1.TabIndex = 0
        Me.Btn_open_form1.Text = "Inscription au concours "
        Me.Btn_open_form1.UseVisualStyleBackColor = False
        '
        'Btn_gere_inscriptions
        '
        Me.Btn_gere_inscriptions.BackColor = System.Drawing.Color.White
        Me.Btn_gere_inscriptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Btn_gere_inscriptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_gere_inscriptions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_gere_inscriptions.Location = New System.Drawing.Point(63, 96)
        Me.Btn_gere_inscriptions.Name = "Btn_gere_inscriptions"
        Me.Btn_gere_inscriptions.Size = New System.Drawing.Size(150, 50)
        Me.Btn_gere_inscriptions.TabIndex = 1
        Me.Btn_gere_inscriptions.Text = "Gérer les candidatures"
        Me.Btn_gere_inscriptions.UseVisualStyleBackColor = False
        '
        'btn_provisoire
        '
        Me.btn_provisoire.BackColor = System.Drawing.Color.White
        Me.btn_provisoire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_provisoire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_provisoire.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_provisoire.Location = New System.Drawing.Point(63, 163)
        Me.btn_provisoire.Name = "btn_provisoire"
        Me.btn_provisoire.Size = New System.Drawing.Size(150, 50)
        Me.btn_provisoire.TabIndex = 2
        Me.btn_provisoire.Text = "Bilan provisoire"
        Me.btn_provisoire.UseVisualStyleBackColor = False
        '
        'btn_quitter
        '
        Me.btn_quitter.BackColor = System.Drawing.Color.Transparent
        Me.btn_quitter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Image = CType(resources.GetObject("btn_quitter.Image"), System.Drawing.Image)
        Me.btn_quitter.Location = New System.Drawing.Point(694, 26)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(30, 30)
        Me.btn_quitter.TabIndex = 3
        Me.btn_quitter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(-4, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(810, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "________________________________________________________________________________"
        '
        'label_inscription
        '
        Me.label_inscription.AutoSize = True
        Me.label_inscription.BackColor = System.Drawing.Color.Transparent
        Me.label_inscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inscription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_inscription.Location = New System.Drawing.Point(348, 31)
        Me.label_inscription.Name = "label_inscription"
        Me.label_inscription.Size = New System.Drawing.Size(97, 29)
        Me.label_inscription.TabIndex = 18
        Me.label_inscription.Text = "Accueil "
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.BackColor = System.Drawing.Color.Transparent
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.description.Location = New System.Drawing.Point(64, 96)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(616, 24)
        Me.description.TabIndex = 20
        Me.description.Text = "Bienvenue sur l'application d'inscription pour un concours international ! "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(435, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 222)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_provisoire)
        Me.Panel1.Controls.Add(Me.Btn_gere_inscriptions)
        Me.Panel1.Controls.Add(Me.Btn_open_form1)
        Me.Panel1.Location = New System.Drawing.Point(53, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 277)
        Me.Panel1.TabIndex = 22
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_inscription)
        Me.Controls.Add(Me.btn_quitter)
        Me.Name = "Accueil"
        Me.Text = "formAcc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_open_form1 As Button
    Friend WithEvents Btn_gere_inscriptions As Button
    Friend WithEvents btn_provisoire As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents label_inscription As Label
    Friend WithEvents description As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
