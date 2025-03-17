<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ComConverter
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
        Me.btn_Creqcur_Close = New System.Windows.Forms.Button()
        Me.Label_Cwithdraw = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_Toc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Cname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_retrieve = New System.Windows.Forms.Button()
        Me.txt_currency = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Amt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_convert = New System.Windows.Forms.Button()
        Me.txt_currencyconv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combox_EEFC = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Bname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Creqcur_Close
        '
        Me.btn_Creqcur_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Creqcur_Close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_Creqcur_Close.FlatAppearance.BorderSize = 0
        Me.btn_Creqcur_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Creqcur_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Creqcur_Close.ForeColor = System.Drawing.Color.Black
        Me.btn_Creqcur_Close.Location = New System.Drawing.Point(585, -1)
        Me.btn_Creqcur_Close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Creqcur_Close.Name = "btn_Creqcur_Close"
        Me.btn_Creqcur_Close.Size = New System.Drawing.Size(38, 32)
        Me.btn_Creqcur_Close.TabIndex = 173
        Me.btn_Creqcur_Close.Text = "<"
        Me.btn_Creqcur_Close.UseVisualStyleBackColor = False
        '
        'Label_Cwithdraw
        '
        Me.Label_Cwithdraw.AutoSize = True
        Me.Label_Cwithdraw.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Cwithdraw.Location = New System.Drawing.Point(167, 13)
        Me.Label_Cwithdraw.Name = "Label_Cwithdraw"
        Me.Label_Cwithdraw.Size = New System.Drawing.Size(310, 32)
        Me.Label_Cwithdraw.TabIndex = 175
        Me.Label_Cwithdraw.Text = "Currency Converter"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 10)
        Me.Panel2.TabIndex = 176
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 501)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 10)
        Me.Panel1.TabIndex = 177
        '
        'Txt_Toc
        '
        Me.Txt_Toc.Enabled = False
        Me.Txt_Toc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Toc.Location = New System.Drawing.Point(440, 136)
        Me.Txt_Toc.Name = "Txt_Toc"
        Me.Txt_Toc.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Toc.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(319, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 19)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Type of Company"
        '
        'Txt_Cname
        '
        Me.Txt_Cname.Enabled = False
        Me.Txt_Cname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cname.Location = New System.Drawing.Point(151, 139)
        Me.Txt_Cname.Name = "Txt_Cname"
        Me.Txt_Cname.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Cname.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Company Name"
        '
        'btn_retrieve
        '
        Me.btn_retrieve.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_retrieve.FlatAppearance.BorderSize = 0
        Me.btn_retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retrieve.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retrieve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_retrieve.Location = New System.Drawing.Point(322, 80)
        Me.btn_retrieve.Name = "btn_retrieve"
        Me.btn_retrieve.Size = New System.Drawing.Size(94, 32)
        Me.btn_retrieve.TabIndex = 188
        Me.btn_retrieve.Text = "Display "
        Me.btn_retrieve.UseVisualStyleBackColor = False
        '
        'txt_currency
        '
        Me.txt_currency.Enabled = False
        Me.txt_currency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currency.Location = New System.Drawing.Point(151, 200)
        Me.txt_currency.Name = "txt_currency"
        Me.txt_currency.Size = New System.Drawing.Size(139, 26)
        Me.txt_currency.TabIndex = 187
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "Currency"
        '
        'txt_Amt
        '
        Me.txt_Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amt.Location = New System.Drawing.Point(151, 251)
        Me.txt_Amt.Name = "txt_Amt"
        Me.txt_Amt.Size = New System.Drawing.Size(139, 26)
        Me.txt_Amt.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "Enter Amount"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_reset.FlatAppearance.BorderSize = 0
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_reset.Location = New System.Drawing.Point(164, 325)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(88, 32)
        Me.btn_reset.TabIndex = 183
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_convert
        '
        Me.btn_convert.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_convert.FlatAppearance.BorderSize = 0
        Me.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_convert.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_convert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_convert.Location = New System.Drawing.Point(277, 325)
        Me.btn_convert.Name = "btn_convert"
        Me.btn_convert.Size = New System.Drawing.Size(88, 32)
        Me.btn_convert.TabIndex = 182
        Me.btn_convert.Text = "Convert"
        Me.btn_convert.UseVisualStyleBackColor = False
        '
        'txt_currencyconv
        '
        Me.txt_currencyconv.Enabled = False
        Me.txt_currencyconv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currencyconv.Location = New System.Drawing.Point(440, 248)
        Me.txt_currencyconv.Name = "txt_currencyconv"
        Me.txt_currencyconv.Size = New System.Drawing.Size(139, 26)
        Me.txt_currencyconv.TabIndex = 181
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(301, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 19)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "Currency Converted"
        '
        'combox_EEFC
        '
        Me.combox_EEFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_EEFC.FormattingEnabled = True
        Me.combox_EEFC.Location = New System.Drawing.Point(151, 84)
        Me.combox_EEFC.Name = "combox_EEFC"
        Me.combox_EEFC.Size = New System.Drawing.Size(139, 27)
        Me.combox_EEFC.TabIndex = 179
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "EEFC A/c No"
        '
        'Txt_Bname
        '
        Me.Txt_Bname.Enabled = False
        Me.Txt_Bname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Bname.Location = New System.Drawing.Point(440, 196)
        Me.Txt_Bname.Name = "Txt_Bname"
        Me.Txt_Bname.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Bname.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "Bank Name"
        '
        'Frm_ComConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(624, 511)
        Me.Controls.Add(Me.Txt_Bname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Toc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Cname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_retrieve)
        Me.Controls.Add(Me.txt_currency)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Amt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_convert)
        Me.Controls.Add(Me.txt_currencyconv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combox_EEFC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Creqcur_Close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label_Cwithdraw)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ComConverter"
        Me.Text = "Frm_Crequestcurrency"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Creqcur_Close As System.Windows.Forms.Button
    Friend WithEvents Label_Cwithdraw As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txt_Toc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Cname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_retrieve As System.Windows.Forms.Button
    Friend WithEvents txt_currency As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Amt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_convert As System.Windows.Forms.Button
    Friend WithEvents txt_currencyconv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combox_EEFC As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Bname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
