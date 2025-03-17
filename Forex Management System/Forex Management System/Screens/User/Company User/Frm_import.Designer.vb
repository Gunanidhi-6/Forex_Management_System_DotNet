<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_import
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_sname = New System.Windows.Forms.TextBox()
        Me.rtxt_adrs = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cmpnyname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combox_typecmpny = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_bname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combox_transcurrency = New System.Windows.Forms.ComboBox()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_Tamount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_getdata = New System.Windows.Forms.Button()
        Me.txt_PAN = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Combo_EEFC = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Supplier's Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 38)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Currency"
        '
        'txt_sname
        '
        Me.txt_sname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sname.Location = New System.Drawing.Point(200, 376)
        Me.txt_sname.Name = "txt_sname"
        Me.txt_sname.Size = New System.Drawing.Size(137, 26)
        Me.txt_sname.TabIndex = 36
        '
        'rtxt_adrs
        '
        Me.rtxt_adrs.Enabled = False
        Me.rtxt_adrs.Location = New System.Drawing.Point(203, 190)
        Me.rtxt_adrs.Name = "rtxt_adrs"
        Me.rtxt_adrs.Size = New System.Drawing.Size(134, 57)
        Me.rtxt_adrs.TabIndex = 32
        Me.rtxt_adrs.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Address"
        '
        'txt_cmpnyname
        '
        Me.txt_cmpnyname.Enabled = False
        Me.txt_cmpnyname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cmpnyname.Location = New System.Drawing.Point(505, 134)
        Me.txt_cmpnyname.Name = "txt_cmpnyname"
        Me.txt_cmpnyname.Size = New System.Drawing.Size(135, 26)
        Me.txt_cmpnyname.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Name of Company"
        '
        'combox_typecmpny
        '
        Me.combox_typecmpny.Enabled = False
        Me.combox_typecmpny.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_typecmpny.FormattingEnabled = True
        Me.combox_typecmpny.Location = New System.Drawing.Point(203, 134)
        Me.combox_typecmpny.Name = "combox_typecmpny"
        Me.combox_typecmpny.Size = New System.Drawing.Size(134, 27)
        Me.combox_typecmpny.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Type of Company"
        '
        'txt_bname
        '
        Me.txt_bname.Enabled = False
        Me.txt_bname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bname.Location = New System.Drawing.Point(505, 80)
        Me.txt_bname.Name = "txt_bname"
        Me.txt_bname.Size = New System.Drawing.Size(135, 26)
        Me.txt_bname.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Bank Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "EEFC A/c No"
        '
        'combox_transcurrency
        '
        Me.combox_transcurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_transcurrency.FormattingEnabled = True
        Me.combox_transcurrency.Location = New System.Drawing.Point(199, 297)
        Me.combox_transcurrency.Name = "combox_transcurrency"
        Me.combox_transcurrency.Size = New System.Drawing.Size(134, 27)
        Me.combox_transcurrency.TabIndex = 45
        '
        'txt_itemname
        '
        Me.txt_itemname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemname.Location = New System.Drawing.Point(504, 376)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(135, 26)
        Me.txt_itemname.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Name of the item"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(200, 440)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(137, 26)
        Me.txt_quantity.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(75, 444)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 19)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(343, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 32)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Import"
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_submit.Location = New System.Drawing.Point(367, 546)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 29)
        Me.btn_submit.TabIndex = 53
        Me.btn_submit.Text = "Pay"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(260, 546)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 29)
        Me.btn_clear.TabIndex = 54
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancel.Location = New System.Drawing.Point(469, 546)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 29)
        Me.btn_cancel.TabIndex = 55
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(796, 1)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 56
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 10)
        Me.Panel1.TabIndex = 57
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 597)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 10)
        Me.Panel2.TabIndex = 58
        '
        'txt_Tamount
        '
        Me.txt_Tamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tamount.Location = New System.Drawing.Point(500, 441)
        Me.txt_Tamount.Name = "txt_Tamount"
        Me.txt_Tamount.Size = New System.Drawing.Size(139, 26)
        Me.txt_Tamount.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(375, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 19)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Total Amount"
        '
        'btn_getdata
        '
        Me.btn_getdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_getdata.FlatAppearance.BorderSize = 0
        Me.btn_getdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_getdata.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getdata.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_getdata.Location = New System.Drawing.Point(661, 75)
        Me.btn_getdata.Name = "btn_getdata"
        Me.btn_getdata.Size = New System.Drawing.Size(80, 29)
        Me.btn_getdata.TabIndex = 63
        Me.btn_getdata.Text = "Getdata"
        Me.btn_getdata.UseVisualStyleBackColor = False
        '
        'txt_PAN
        '
        Me.txt_PAN.Enabled = False
        Me.txt_PAN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PAN.Location = New System.Drawing.Point(505, 190)
        Me.txt_PAN.Name = "txt_PAN"
        Me.txt_PAN.Size = New System.Drawing.Size(135, 26)
        Me.txt_PAN.TabIndex = 65
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(419, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 19)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "PAN No"
        '
        'Combo_EEFC
        '
        Me.Combo_EEFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_EEFC.FormattingEnabled = True
        Me.Combo_EEFC.Location = New System.Drawing.Point(203, 82)
        Me.Combo_EEFC.Name = "Combo_EEFC"
        Me.Combo_EEFC.Size = New System.Drawing.Size(134, 27)
        Me.Combo_EEFC.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 38)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Supplier's Bank " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"JP Morgan Bank", "Bank of America", "HSBC Bank", "Citi Bank", "Capital One Bank"})
        Me.ComboBox1.Location = New System.Drawing.Point(504, 294)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 27)
        Me.ComboBox1.TabIndex = 68
        '
        'frm_import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(834, 607)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Combo_EEFC)
        Me.Controls.Add(Me.txt_PAN)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btn_getdata)
        Me.Controls.Add(Me.txt_Tamount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_itemname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combox_transcurrency)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_sname)
        Me.Controls.Add(Me.rtxt_adrs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_cmpnyname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combox_typecmpny)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_bname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_import"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_sname As System.Windows.Forms.TextBox
    Friend WithEvents rtxt_adrs As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cmpnyname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combox_typecmpny As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_bname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combox_transcurrency As System.Windows.Forms.ComboBox
    Friend WithEvents txt_itemname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_Tamount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_getdata As System.Windows.Forms.Button
    Friend WithEvents txt_PAN As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Combo_EEFC As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
