<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_depositCompany
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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Label_Amount = New System.Windows.Forms.Label()
        Me.txt_Amt_depositC = New System.Windows.Forms.TextBox()
        Me.txt_Cname = New System.Windows.Forms.TextBox()
        Me.Label_CName = New System.Windows.Forms.Label()
        Me.Label_RFC = New System.Windows.Forms.Label()
        Me.Label_depositC = New System.Windows.Forms.Label()
        Me.txt_ToC = New System.Windows.Forms.TextBox()
        Me.Label_ToC = New System.Windows.Forms.Label()
        Me.btn_depositC_Close = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_ComDetail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Bname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_currency = New System.Windows.Forms.TextBox()
        Me.Combo_EEFC = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancel.Location = New System.Drawing.Point(374, 321)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(79, 32)
        Me.btn_cancel.TabIndex = 145
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
        Me.btn_clear.Location = New System.Drawing.Point(142, 321)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(79, 32)
        Me.btn_clear.TabIndex = 144
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_submit.Location = New System.Drawing.Point(255, 321)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(79, 32)
        Me.btn_submit.TabIndex = 143
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'Label_Amount
        '
        Me.Label_Amount.AutoSize = True
        Me.Label_Amount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Amount.Location = New System.Drawing.Point(43, 270)
        Me.Label_Amount.Name = "Label_Amount"
        Me.Label_Amount.Size = New System.Drawing.Size(92, 19)
        Me.Label_Amount.TabIndex = 142
        Me.Label_Amount.Text = "Enter Amount"
        '
        'txt_Amt_depositC
        '
        Me.txt_Amt_depositC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amt_depositC.Location = New System.Drawing.Point(155, 270)
        Me.txt_Amt_depositC.Name = "txt_Amt_depositC"
        Me.txt_Amt_depositC.Size = New System.Drawing.Size(142, 26)
        Me.txt_Amt_depositC.TabIndex = 141
        '
        'txt_Cname
        '
        Me.txt_Cname.Enabled = False
        Me.txt_Cname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cname.Location = New System.Drawing.Point(155, 177)
        Me.txt_Cname.Name = "txt_Cname"
        Me.txt_Cname.Size = New System.Drawing.Size(142, 26)
        Me.txt_Cname.TabIndex = 138
        '
        'Label_CName
        '
        Me.Label_CName.AutoSize = True
        Me.Label_CName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CName.Location = New System.Drawing.Point(43, 177)
        Me.Label_CName.Name = "Label_CName"
        Me.Label_CName.Size = New System.Drawing.Size(109, 19)
        Me.Label_CName.TabIndex = 137
        Me.Label_CName.Text = "Company Name"
        '
        'Label_RFC
        '
        Me.Label_RFC.AutoSize = True
        Me.Label_RFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RFC.Location = New System.Drawing.Point(43, 121)
        Me.Label_RFC.Name = "Label_RFC"
        Me.Label_RFC.Size = New System.Drawing.Size(96, 19)
        Me.Label_RFC.TabIndex = 132
        Me.Label_RFC.Text = "EEFC A/c No"
        '
        'Label_depositC
        '
        Me.Label_depositC.AutoSize = True
        Me.Label_depositC.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_depositC.Location = New System.Drawing.Point(250, 13)
        Me.Label_depositC.Name = "Label_depositC"
        Me.Label_depositC.Size = New System.Drawing.Size(130, 32)
        Me.Label_depositC.TabIndex = 133
        Me.Label_depositC.Text = "Deposit"
        '
        'txt_ToC
        '
        Me.txt_ToC.Enabled = False
        Me.txt_ToC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToC.Location = New System.Drawing.Point(447, 174)
        Me.txt_ToC.Name = "txt_ToC"
        Me.txt_ToC.Size = New System.Drawing.Size(142, 26)
        Me.txt_ToC.TabIndex = 147
        '
        'Label_ToC
        '
        Me.Label_ToC.AutoSize = True
        Me.Label_ToC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ToC.Location = New System.Drawing.Point(323, 177)
        Me.Label_ToC.Name = "Label_ToC"
        Me.Label_ToC.Size = New System.Drawing.Size(118, 19)
        Me.Label_ToC.TabIndex = 146
        Me.Label_ToC.Text = "Type of Company"
        '
        'btn_depositC_Close
        '
        Me.btn_depositC_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_depositC_Close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_depositC_Close.FlatAppearance.BorderSize = 0
        Me.btn_depositC_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_depositC_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_depositC_Close.ForeColor = System.Drawing.Color.Black
        Me.btn_depositC_Close.Location = New System.Drawing.Point(583, 1)
        Me.btn_depositC_Close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_depositC_Close.Name = "btn_depositC_Close"
        Me.btn_depositC_Close.Size = New System.Drawing.Size(38, 32)
        Me.btn_depositC_Close.TabIndex = 148
        Me.btn_depositC_Close.Text = "<"
        Me.btn_depositC_Close.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 10)
        Me.Panel1.TabIndex = 153
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 449)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 10)
        Me.Panel2.TabIndex = 154
        '
        'btn_ComDetail
        '
        Me.btn_ComDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_ComDetail.FlatAppearance.BorderSize = 0
        Me.btn_ComDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ComDetail.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ComDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_ComDetail.Location = New System.Drawing.Point(316, 99)
        Me.btn_ComDetail.Name = "btn_ComDetail"
        Me.btn_ComDetail.Size = New System.Drawing.Size(160, 47)
        Me.btn_ComDetail.TabIndex = 155
        Me.btn_ComDetail.Text = "Get Company Details"
        Me.btn_ComDetail.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Bank Name"
        '
        'Txt_Bname
        '
        Me.Txt_Bname.Enabled = False
        Me.Txt_Bname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Bname.Location = New System.Drawing.Point(155, 224)
        Me.Txt_Bname.Name = "Txt_Bname"
        Me.Txt_Bname.Size = New System.Drawing.Size(142, 26)
        Me.Txt_Bname.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Currency"
        '
        'Txt_currency
        '
        Me.Txt_currency.Enabled = False
        Me.Txt_currency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_currency.Location = New System.Drawing.Point(447, 224)
        Me.Txt_currency.Name = "Txt_currency"
        Me.Txt_currency.Size = New System.Drawing.Size(142, 26)
        Me.Txt_currency.TabIndex = 158
        '
        'Combo_EEFC
        '
        Me.Combo_EEFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_EEFC.FormattingEnabled = True
        Me.Combo_EEFC.Location = New System.Drawing.Point(155, 114)
        Me.Combo_EEFC.Name = "Combo_EEFC"
        Me.Combo_EEFC.Size = New System.Drawing.Size(142, 27)
        Me.Combo_EEFC.TabIndex = 160
        '
        'Frm_depositCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(621, 459)
        Me.Controls.Add(Me.Combo_EEFC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_currency)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Bname)
        Me.Controls.Add(Me.btn_ComDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_depositC_Close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_ToC)
        Me.Controls.Add(Me.Label_ToC)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Label_Amount)
        Me.Controls.Add(Me.txt_Amt_depositC)
        Me.Controls.Add(Me.txt_Cname)
        Me.Controls.Add(Me.Label_CName)
        Me.Controls.Add(Me.Label_RFC)
        Me.Controls.Add(Me.Label_depositC)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_depositCompany"
        Me.Text = "Frm_deposit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents Label_Amount As System.Windows.Forms.Label
    Friend WithEvents txt_Amt_depositC As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cname As System.Windows.Forms.TextBox
    Friend WithEvents Label_CName As System.Windows.Forms.Label
    Friend WithEvents Label_RFC As System.Windows.Forms.Label
    Friend WithEvents Label_depositC As System.Windows.Forms.Label
    Friend WithEvents txt_ToC As System.Windows.Forms.TextBox
    Friend WithEvents Label_ToC As System.Windows.Forms.Label
    Friend WithEvents btn_depositC_Close As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_ComDetail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Bname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_currency As System.Windows.Forms.TextBox
    Friend WithEvents Combo_EEFC As System.Windows.Forms.ComboBox
End Class
