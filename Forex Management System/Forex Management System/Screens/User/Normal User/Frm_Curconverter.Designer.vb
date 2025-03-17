<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Curconverter
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
        Me.combox_RFC = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_currencyconv = New System.Windows.Forms.TextBox()
        Me.btn_convert = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_Amt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_currency = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_retrieve = New System.Windows.Forms.Button()
        Me.Txt_Fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Lname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Converter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RFC A/c No"
        '
        'combox_RFC
        '
        Me.combox_RFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combox_RFC.FormattingEnabled = True
        Me.combox_RFC.Location = New System.Drawing.Point(120, 86)
        Me.combox_RFC.Name = "combox_RFC"
        Me.combox_RFC.Size = New System.Drawing.Size(139, 27)
        Me.combox_RFC.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(273, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Currency Converted"
        '
        'txt_currencyconv
        '
        Me.txt_currencyconv.Enabled = False
        Me.txt_currencyconv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currencyconv.Location = New System.Drawing.Point(412, 223)
        Me.txt_currencyconv.Name = "txt_currencyconv"
        Me.txt_currencyconv.Size = New System.Drawing.Size(136, 26)
        Me.txt_currencyconv.TabIndex = 9
        '
        'btn_convert
        '
        Me.btn_convert.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_convert.FlatAppearance.BorderSize = 0
        Me.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_convert.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_convert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_convert.Location = New System.Drawing.Point(246, 265)
        Me.btn_convert.Name = "btn_convert"
        Me.btn_convert.Size = New System.Drawing.Size(92, 32)
        Me.btn_convert.TabIndex = 10
        Me.btn_convert.Text = "Convert"
        Me.btn_convert.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_reset.FlatAppearance.BorderSize = 0
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_reset.Location = New System.Drawing.Point(133, 266)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(92, 32)
        Me.btn_reset.TabIndex = 11
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(568, 2)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 41
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(607, 10)
        Me.Panel2.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 358)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(607, 10)
        Me.Panel3.TabIndex = 43
        '
        'txt_Amt
        '
        Me.txt_Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amt.Location = New System.Drawing.Point(123, 223)
        Me.txt_Amt.Name = "txt_Amt"
        Me.txt_Amt.Size = New System.Drawing.Size(136, 26)
        Me.txt_Amt.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Enter Amount"
        '
        'txt_currency
        '
        Me.txt_currency.Enabled = False
        Me.txt_currency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currency.Location = New System.Drawing.Point(120, 176)
        Me.txt_currency.Name = "txt_currency"
        Me.txt_currency.Size = New System.Drawing.Size(139, 26)
        Me.txt_currency.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Currency"
        '
        'btn_retrieve
        '
        Me.btn_retrieve.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_retrieve.FlatAppearance.BorderSize = 0
        Me.btn_retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retrieve.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retrieve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_retrieve.Location = New System.Drawing.Point(291, 82)
        Me.btn_retrieve.Name = "btn_retrieve"
        Me.btn_retrieve.Size = New System.Drawing.Size(82, 32)
        Me.btn_retrieve.TabIndex = 48
        Me.btn_retrieve.Text = "Display "
        Me.btn_retrieve.UseVisualStyleBackColor = False
        '
        'Txt_Fname
        '
        Me.Txt_Fname.Enabled = False
        Me.Txt_Fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Fname.Location = New System.Drawing.Point(120, 131)
        Me.Txt_Fname.Name = "Txt_Fname"
        Me.Txt_Fname.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Fname.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "First Name"
        '
        'Txt_Lname
        '
        Me.Txt_Lname.Enabled = False
        Me.Txt_Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Lname.Location = New System.Drawing.Point(409, 127)
        Me.Txt_Lname.Name = "Txt_Lname"
        Me.Txt_Lname.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Lname.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 19)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Last Name"
        '
        'Frm_Curconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(607, 368)
        Me.Controls.Add(Me.Txt_Lname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Fname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_retrieve)
        Me.Controls.Add(Me.txt_currency)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Amt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_convert)
        Me.Controls.Add(Me.txt_currencyconv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combox_RFC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Curconverter"
        Me.Text = "Frm_Curconverter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combox_RFC As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_currencyconv As System.Windows.Forms.TextBox
    Friend WithEvents btn_convert As System.Windows.Forms.Button
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_Amt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_currency As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_retrieve As System.Windows.Forms.Button
    Friend WithEvents Txt_Fname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Lname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
