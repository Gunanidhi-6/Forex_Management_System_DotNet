<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LoC
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cmpnyname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combox_trancurrency = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_subankname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txt_value = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.btn_LoC_close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_Bname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn_FC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EEFC A/c No"
        '
        'txt_cmpnyname
        '
        Me.txt_cmpnyname.Enabled = False
        Me.txt_cmpnyname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cmpnyname.Location = New System.Drawing.Point(138, 155)
        Me.txt_cmpnyname.Name = "txt_cmpnyname"
        Me.txt_cmpnyname.Size = New System.Drawing.Size(135, 26)
        Me.txt_cmpnyname.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Name of Company"
        '
        'combox_trancurrency
        '
        Me.combox_trancurrency.Enabled = False
        Me.combox_trancurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_trancurrency.FormattingEnabled = True
        Me.combox_trancurrency.Items.AddRange(New Object() {"USD", "EURO", "POUND", "YEN", "RNB"})
        Me.combox_trancurrency.Location = New System.Drawing.Point(138, 214)
        Me.combox_trancurrency.Name = "combox_trancurrency"
        Me.combox_trancurrency.Size = New System.Drawing.Size(135, 27)
        Me.combox_trancurrency.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 38)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Currency"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(138, 345)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(135, 26)
        Me.txt_quantity.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 348)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 19)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Quantity"
        '
        'txt_subankname
        '
        Me.txt_subankname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subankname.Location = New System.Drawing.Point(138, 288)
        Me.txt_subankname.Name = "txt_subankname"
        Me.txt_subankname.Size = New System.Drawing.Size(135, 26)
        Me.txt_subankname.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 38)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Supplier's Bank " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(281, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Supplier's Name"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(402, 217)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(134, 26)
        Me.TextBox5.TabIndex = 50
        '
        'txt_value
        '
        Me.txt_value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_value.Location = New System.Drawing.Point(401, 347)
        Me.txt_value.Name = "txt_value"
        Me.txt_value.Size = New System.Drawing.Size(135, 26)
        Me.txt_value.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 19)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Value(in Rs)"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(402, 288)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(135, 26)
        Me.TextBox6.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Name of the item"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancel.Location = New System.Drawing.Point(344, 426)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 29)
        Me.btn_cancel.TabIndex = 62
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(135, 426)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 29)
        Me.btn_clear.TabIndex = 61
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_Pay
        '
        Me.btn_Pay.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_Pay.FlatAppearance.BorderSize = 0
        Me.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pay.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Pay.Location = New System.Drawing.Point(242, 426)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(75, 29)
        Me.btn_Pay.TabIndex = 60
        Me.btn_Pay.Text = "Pay"
        Me.btn_Pay.UseVisualStyleBackColor = False
        '
        'btn_LoC_close
        '
        Me.btn_LoC_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LoC_close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_LoC_close.FlatAppearance.BorderSize = 0
        Me.btn_LoC_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LoC_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LoC_close.ForeColor = System.Drawing.Color.Black
        Me.btn_LoC_close.Location = New System.Drawing.Point(546, 1)
        Me.btn_LoC_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_LoC_close.Name = "btn_LoC_close"
        Me.btn_LoC_close.Size = New System.Drawing.Size(38, 32)
        Me.btn_LoC_close.TabIndex = 67
        Me.btn_LoC_close.Text = "<"
        Me.btn_LoC_close.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 32)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Letter of Credit"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 472)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(584, 10)
        Me.Panel3.TabIndex = 116
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 10)
        Me.Panel1.TabIndex = 142
        '
        'Txt_Bname
        '
        Me.Txt_Bname.Enabled = False
        Me.Txt_Bname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Bname.Location = New System.Drawing.Point(401, 155)
        Me.Txt_Bname.Name = "Txt_Bname"
        Me.Txt_Bname.Size = New System.Drawing.Size(134, 26)
        Me.Txt_Bname.TabIndex = 144
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Bank Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(138, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 27)
        Me.ComboBox1.TabIndex = 145
        '
        'btn_FC
        '
        Me.btn_FC.FlatAppearance.BorderSize = 0
        Me.btn_FC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FC.Location = New System.Drawing.Point(288, 103)
        Me.btn_FC.Name = "btn_FC"
        Me.btn_FC.Size = New System.Drawing.Size(116, 29)
        Me.btn_FC.TabIndex = 146
        Me.btn_FC.Text = "Find Company"
        Me.btn_FC.UseVisualStyleBackColor = True
        '
        'Frm_LoC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(584, 482)
        Me.Controls.Add(Me.btn_FC)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txt_Bname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_LoC_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_Pay)
        Me.Controls.Add(Me.txt_value)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_subankname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.combox_trancurrency)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_cmpnyname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_LoC"
        Me.Text = "Frm_LoC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cmpnyname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combox_trancurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_subankname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_value As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_Pay As System.Windows.Forms.Button
    Friend WithEvents btn_LoC_close As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txt_Bname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_FC As System.Windows.Forms.Button
End Class
