<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_importCredit
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.txt_cancel = New System.Windows.Forms.Button()
        Me.btn = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_value = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_item = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combox_trancurrency = New System.Windows.Forms.ComboBox()
        Me.txt_subankname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_bsinessname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combox_trancountry = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_suname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.iecode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtxt_adrs = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmpnyname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combox_cmpnytype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_bname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(667, 3)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 89
        Me.btn_exit.Text = "X"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'txt_cancel
        '
        Me.txt_cancel.FlatAppearance.BorderSize = 0
        Me.txt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cancel.Location = New System.Drawing.Point(354, 535)
        Me.txt_cancel.Name = "txt_cancel"
        Me.txt_cancel.Size = New System.Drawing.Size(75, 29)
        Me.txt_cancel.TabIndex = 88
        Me.txt_cancel.Text = "Cancel"
        Me.txt_cancel.UseVisualStyleBackColor = True
        '
        'btn
        '
        Me.btn.FlatAppearance.BorderSize = 0
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(145, 535)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 29)
        Me.btn.TabIndex = 87
        Me.btn.Text = "Clear"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(252, 535)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 29)
        Me.btn_submit.TabIndex = 86
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(301, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 24)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Import Credit"
        '
        'txt_value
        '
        Me.txt_value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_value.Location = New System.Drawing.Point(468, 464)
        Me.txt_value.Name = "txt_value"
        Me.txt_value.Size = New System.Drawing.Size(135, 26)
        Me.txt_value.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(344, 469)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 19)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Value(in Rs)"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(166, 466)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(135, 26)
        Me.txt_quantity.TabIndex = 82
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(42, 471)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 19)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Quantity"
        '
        'txt_item
        '
        Me.txt_item.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item.Location = New System.Drawing.Point(469, 397)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(135, 26)
        Me.txt_item.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Name of the item"
        '
        'combox_trancurrency
        '
        Me.combox_trancurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_trancurrency.FormattingEnabled = True
        Me.combox_trancurrency.Items.AddRange(New Object() {"USD", "EURO", "POUND", "YEN", "RNB"})
        Me.combox_trancurrency.Location = New System.Drawing.Point(469, 283)
        Me.combox_trancurrency.Name = "combox_trancurrency"
        Me.combox_trancurrency.Size = New System.Drawing.Size(134, 27)
        Me.combox_trancurrency.TabIndex = 78
        '
        'txt_subankname
        '
        Me.txt_subankname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subankname.Location = New System.Drawing.Point(165, 397)
        Me.txt_subankname.Name = "txt_subankname"
        Me.txt_subankname.Size = New System.Drawing.Size(135, 26)
        Me.txt_subankname.TabIndex = 77
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 400)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 38)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Supplier's Bank " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'txt_bsinessname
        '
        Me.txt_bsinessname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bsinessname.Location = New System.Drawing.Point(469, 336)
        Me.txt_bsinessname.Name = "txt_bsinessname"
        Me.txt_bsinessname.Size = New System.Drawing.Size(135, 26)
        Me.txt_bsinessname.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(345, 341)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 19)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Nature of business"
        '
        'combox_trancountry
        '
        Me.combox_trancountry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_trancountry.FormattingEnabled = True
        Me.combox_trancountry.Items.AddRange(New Object() {"USD", "EURO", "POUND", "YEN", "RNB"})
        Me.combox_trancountry.Location = New System.Drawing.Point(165, 288)
        Me.combox_trancountry.Name = "combox_trancountry"
        Me.combox_trancountry.Size = New System.Drawing.Size(134, 27)
        Me.combox_trancountry.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Supplier's Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(345, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 38)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Currency"
        '
        'txt_suname
        '
        Me.txt_suname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_suname.Location = New System.Drawing.Point(164, 343)
        Me.txt_suname.Name = "txt_suname"
        Me.txt_suname.Size = New System.Drawing.Size(135, 26)
        Me.txt_suname.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 38)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Transaction " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Country"
        '
        'iecode
        '
        Me.iecode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iecode.Location = New System.Drawing.Point(469, 196)
        Me.iecode.Name = "iecode"
        Me.iecode.Size = New System.Drawing.Size(135, 26)
        Me.iecode.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(345, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "IE Code"
        '
        'rtxt_adrs
        '
        Me.rtxt_adrs.Location = New System.Drawing.Point(167, 196)
        Me.rtxt_adrs.Name = "rtxt_adrs"
        Me.rtxt_adrs.Size = New System.Drawing.Size(134, 57)
        Me.rtxt_adrs.TabIndex = 66
        Me.rtxt_adrs.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Address"
        '
        'cmpnyname
        '
        Me.cmpnyname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpnyname.Location = New System.Drawing.Point(469, 140)
        Me.cmpnyname.Name = "cmpnyname"
        Me.cmpnyname.Size = New System.Drawing.Size(135, 26)
        Me.cmpnyname.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(345, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Name of Company"
        '
        'combox_cmpnytype
        '
        Me.combox_cmpnytype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_cmpnytype.FormattingEnabled = True
        Me.combox_cmpnytype.Items.AddRange(New Object() {"Single ownership", "Partnership"})
        Me.combox_cmpnytype.Location = New System.Drawing.Point(167, 140)
        Me.combox_cmpnytype.Name = "combox_cmpnytype"
        Me.combox_cmpnytype.Size = New System.Drawing.Size(134, 27)
        Me.combox_cmpnytype.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Type of Company"
        '
        'txt_bname
        '
        Me.txt_bname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bname.Location = New System.Drawing.Point(469, 86)
        Me.txt_bname.Name = "txt_bname"
        Me.txt_bname.Size = New System.Drawing.Size(135, 26)
        Me.txt_bname.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Bank Name"
        '
        'txt_cid
        '
        Me.txt_cid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cid.Location = New System.Drawing.Point(167, 87)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(134, 26)
        Me.txt_cid.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Customer ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 10)
        Me.Panel1.TabIndex = 90
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 566)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(707, 10)
        Me.Panel2.TabIndex = 91
        '
        'Frm_importCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(707, 576)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_cancel)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_value)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_item)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combox_trancurrency)
        Me.Controls.Add(Me.txt_subankname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_bsinessname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.combox_trancountry)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_suname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.iecode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rtxt_adrs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmpnyname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combox_cmpnytype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_bname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cid)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_importCredit"
        Me.Text = "Frm_importCredit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents txt_cancel As System.Windows.Forms.Button
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_value As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_item As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combox_trancurrency As System.Windows.Forms.ComboBox
    Friend WithEvents txt_subankname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_bsinessname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents combox_trancountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_suname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents iecode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rtxt_adrs As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmpnyname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combox_cmpnytype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_bname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
