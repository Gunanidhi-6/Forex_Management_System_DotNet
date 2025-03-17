<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EEFC
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combox_cmpnytype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cmpnyname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtxt_adrs = New System.Windows.Forms.RichTextBox()
        Me.txt_panno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_mobno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.combox_currency = New System.Windows.Forms.ComboBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Combo_Bname = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Combo_NoB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exchange Earners Foreign Currency A/c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EEFC A/c No"
        '
        'txt_cid
        '
        Me.txt_cid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cid.Location = New System.Drawing.Point(208, 74)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(134, 26)
        Me.txt_cid.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(406, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Bank Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Type of Company"
        '
        'combox_cmpnytype
        '
        Me.combox_cmpnytype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_cmpnytype.FormattingEnabled = True
        Me.combox_cmpnytype.Items.AddRange(New Object() {"Single ownership", "Partnership"})
        Me.combox_cmpnytype.Location = New System.Drawing.Point(504, 122)
        Me.combox_cmpnytype.Name = "combox_cmpnytype"
        Me.combox_cmpnytype.Size = New System.Drawing.Size(141, 27)
        Me.combox_cmpnytype.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Name of Company"
        '
        'txt_cmpnyname
        '
        Me.txt_cmpnyname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cmpnyname.Location = New System.Drawing.Point(208, 123)
        Me.txt_cmpnyname.Name = "txt_cmpnyname"
        Me.txt_cmpnyname.Size = New System.Drawing.Size(134, 26)
        Me.txt_cmpnyname.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address"
        '
        'rtxt_adrs
        '
        Me.rtxt_adrs.Location = New System.Drawing.Point(208, 183)
        Me.rtxt_adrs.Name = "rtxt_adrs"
        Me.rtxt_adrs.Size = New System.Drawing.Size(134, 57)
        Me.rtxt_adrs.TabIndex = 10
        Me.rtxt_adrs.Text = ""
        '
        'txt_panno
        '
        Me.txt_panno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_panno.Location = New System.Drawing.Point(504, 183)
        Me.txt_panno.Name = "txt_panno"
        Me.txt_panno.Size = New System.Drawing.Size(141, 26)
        Me.txt_panno.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(386, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "PAN No"
        '
        'txt_mobno
        '
        Me.txt_mobno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mobno.Location = New System.Drawing.Point(207, 274)
        Me.txt_mobno.Name = "txt_mobno"
        Me.txt_mobno.Size = New System.Drawing.Size(135, 26)
        Me.txt_mobno.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Mobile No"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(504, 272)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(141, 26)
        Me.txt_email.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Email address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(83, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Currency of A/c"
        '
        'combox_currency
        '
        Me.combox_currency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_currency.FormattingEnabled = True
        Me.combox_currency.Items.AddRange(New Object() {"USD", "EURO", "POUND", "YEN", "RNB"})
        Me.combox_currency.Location = New System.Drawing.Point(207, 326)
        Me.combox_currency.Name = "combox_currency"
        Me.combox_currency.Size = New System.Drawing.Size(134, 27)
        Me.combox_currency.TabIndex = 18
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_create.Location = New System.Drawing.Point(337, 449)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 27)
        Me.btn_create.TabIndex = 23
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(220, 449)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 27)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancel.Location = New System.Drawing.Point(450, 449)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_cancel.TabIndex = 25
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(714, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 26
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 10)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 535)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(751, 10)
        Me.Panel2.TabIndex = 92
        '
        'Combo_Bname
        '
        Me.Combo_Bname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Bname.FormattingEnabled = True
        Me.Combo_Bname.Items.AddRange(New Object() {"HDFC Bank", "ICICI Bank", "Canara Bank", "Karnataka Bank", "Punjab National Bank"})
        Me.Combo_Bname.Location = New System.Drawing.Point(504, 72)
        Me.Combo_Bname.Name = "Combo_Bname"
        Me.Combo_Bname.Size = New System.Drawing.Size(141, 27)
        Me.Combo_Bname.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(389, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 38)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Nature of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "business"
        '
        'Combo_NoB
        '
        Me.Combo_NoB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_NoB.FormattingEnabled = True
        Me.Combo_NoB.Items.AddRange(New Object() {"Import", "Export", "Both"})
        Me.Combo_NoB.Location = New System.Drawing.Point(504, 324)
        Me.Combo_NoB.Name = "Combo_NoB"
        Me.Combo_NoB.Size = New System.Drawing.Size(141, 27)
        Me.Combo_NoB.TabIndex = 94
        '
        'Frm_EEFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(751, 545)
        Me.Controls.Add(Me.Combo_NoB)
        Me.Controls.Add(Me.Combo_Bname)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.combox_currency)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_mobno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_panno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rtxt_adrs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_cmpnyname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combox_cmpnytype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_EEFC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_EEFC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents combox_cmpnytype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cmpnyname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtxt_adrs As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_panno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_mobno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents combox_currency As System.Windows.Forms.ComboBox
    Friend WithEvents btn_create As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Combo_Bname As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Combo_NoB As System.Windows.Forms.ComboBox
End Class
