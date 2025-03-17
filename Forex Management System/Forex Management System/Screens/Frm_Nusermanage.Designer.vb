<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Nusermanage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dtp_validupto = New System.Windows.Forms.DateTimePicker()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_mobno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Rtxt_address = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Combo_currency = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Dtp_doi = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Passport = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Find = New System.Windows.Forms.Button()
        Me.combox_RFC = New System.Windows.Forms.ComboBox()
        Me.Txt_lname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_bname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RFC Account Manager"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_update.Enabled = False
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(338, 518)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 35)
        Me.btn_update.TabIndex = 34
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delete.Location = New System.Drawing.Point(229, 518)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 35)
        Me.btn_delete.TabIndex = 35
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(449, 518)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 35)
        Me.btn_clear.TabIndex = 36
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(741, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 37
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 10)
        Me.Panel2.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 652)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 10)
        Me.Panel1.TabIndex = 39
        '
        'Dtp_validupto
        '
        Me.Dtp_validupto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_validupto.Location = New System.Drawing.Point(214, 298)
        Me.Dtp_validupto.Name = "Dtp_validupto"
        Me.Dtp_validupto.Size = New System.Drawing.Size(141, 26)
        Me.Dtp_validupto.TabIndex = 82
        Me.Dtp_validupto.Value = New Date(2023, 1, 12, 0, 0, 0, 0)
        '
        'Txt_email
        '
        Me.Txt_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_email.Location = New System.Drawing.Point(515, 356)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(141, 26)
        Me.Txt_email.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(413, 361)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 19)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Email address"
        '
        'Txt_mobno
        '
        Me.Txt_mobno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mobno.Location = New System.Drawing.Point(214, 361)
        Me.Txt_mobno.MaxLength = 10
        Me.Txt_mobno.Name = "Txt_mobno"
        Me.Txt_mobno.Size = New System.Drawing.Size(141, 26)
        Me.Txt_mobno.TabIndex = 74
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(96, 361)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 19)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Mobile No"
        '
        'Rtxt_address
        '
        Me.Rtxt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Rtxt_address.Location = New System.Drawing.Point(214, 430)
        Me.Rtxt_address.Name = "Rtxt_address"
        Me.Rtxt_address.Size = New System.Drawing.Size(141, 54)
        Me.Rtxt_address.TabIndex = 70
        Me.Rtxt_address.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(96, 447)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 19)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Address"
        '
        'Combo_currency
        '
        Me.Combo_currency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_currency.FormattingEnabled = True
        Me.Combo_currency.Items.AddRange(New Object() {"USD", "EURO", "POUND", "YEN", "RNB"})
        Me.Combo_currency.Location = New System.Drawing.Point(515, 293)
        Me.Combo_currency.Name = "Combo_currency"
        Me.Combo_currency.Size = New System.Drawing.Size(141, 27)
        Me.Combo_currency.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(397, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 19)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Currency of A/c"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(100, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Valid upto"
        '
        'Dtp_doi
        '
        Me.Dtp_doi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_doi.Location = New System.Drawing.Point(515, 241)
        Me.Dtp_doi.Name = "Dtp_doi"
        Me.Dtp_doi.Size = New System.Drawing.Size(141, 26)
        Me.Dtp_doi.TabIndex = 64
        Me.Dtp_doi.Value = New Date(2023, 1, 12, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(413, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Date of Issue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(100, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Passport No"
        '
        'Txt_Passport
        '
        Me.Txt_Passport.Enabled = False
        Me.Txt_Passport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Passport.Location = New System.Drawing.Point(214, 241)
        Me.Txt_Passport.Name = "Txt_Passport"
        Me.Txt_Passport.Size = New System.Drawing.Size(141, 26)
        Me.Txt_Passport.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(96, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "RFC A/c No"
        '
        'btn_Find
        '
        Me.btn_Find.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_Find.FlatAppearance.BorderSize = 0
        Me.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Find.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Find.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Find.Location = New System.Drawing.Point(373, 82)
        Me.btn_Find.Name = "btn_Find"
        Me.btn_Find.Size = New System.Drawing.Size(75, 35)
        Me.btn_Find.TabIndex = 83
        Me.btn_Find.Text = "Find"
        Me.btn_Find.UseVisualStyleBackColor = False
        '
        'combox_RFC
        '
        Me.combox_RFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_RFC.FormattingEnabled = True
        Me.combox_RFC.Location = New System.Drawing.Point(214, 82)
        Me.combox_RFC.Name = "combox_RFC"
        Me.combox_RFC.Size = New System.Drawing.Size(141, 27)
        Me.combox_RFC.TabIndex = 84
        '
        'Txt_lname
        '
        Me.Txt_lname.Enabled = False
        Me.Txt_lname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lname.Location = New System.Drawing.Point(515, 178)
        Me.Txt_lname.Name = "Txt_lname"
        Me.Txt_lname.Size = New System.Drawing.Size(141, 26)
        Me.Txt_lname.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Last Name"
        '
        'txt_fname
        '
        Me.txt_fname.Enabled = False
        Me.txt_fname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(214, 178)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(141, 26)
        Me.txt_fname.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "First Name"
        '
        'txt_bname
        '
        Me.txt_bname.Enabled = False
        Me.txt_bname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bname.Location = New System.Drawing.Point(214, 130)
        Me.txt_bname.Name = "txt_bname"
        Me.txt_bname.Size = New System.Drawing.Size(141, 26)
        Me.txt_bname.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Bank Name"
        '
        'Frm_Nusermanage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(779, 662)
        Me.Controls.Add(Me.txt_bname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_lname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combox_RFC)
        Me.Controls.Add(Me.btn_Find)
        Me.Controls.Add(Me.Dtp_validupto)
        Me.Controls.Add(Me.Txt_email)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Txt_mobno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Rtxt_address)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Combo_currency)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Dtp_doi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_Passport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Nusermanage"
        Me.Text = "Frm_remittance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Dtp_validupto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_mobno As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Rtxt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Combo_currency As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Dtp_doi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_Passport As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Find As System.Windows.Forms.Button
    Friend WithEvents combox_RFC As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_bname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
