<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WithdrawCompany
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
        Me.Label_EEFC = New System.Windows.Forms.Label()
        Me.btn_Withdraw = New System.Windows.Forms.Button()
        Me.txt_Wamt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView_withdrawl = New System.Windows.Forms.DataGridView()
        Me.btn_Cwithdraw_close = New System.Windows.Forms.Button()
        Me.Label_Cwithdraw = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_CBalc = New System.Windows.Forms.Button()
        Me.Combo_EEFC = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView_withdrawl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_EEFC
        '
        Me.Label_EEFC.AutoSize = True
        Me.Label_EEFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_EEFC.Location = New System.Drawing.Point(48, 76)
        Me.Label_EEFC.Name = "Label_EEFC"
        Me.Label_EEFC.Size = New System.Drawing.Size(96, 19)
        Me.Label_EEFC.TabIndex = 0
        Me.Label_EEFC.Text = "EEFC A/c No"
        '
        'btn_Withdraw
        '
        Me.btn_Withdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Withdraw.Enabled = False
        Me.btn_Withdraw.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Withdraw.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Withdraw.Location = New System.Drawing.Point(317, 432)
        Me.btn_Withdraw.Name = "btn_Withdraw"
        Me.btn_Withdraw.Size = New System.Drawing.Size(113, 31)
        Me.btn_Withdraw.TabIndex = 1
        Me.btn_Withdraw.Text = "Withdraw"
        Me.btn_Withdraw.UseVisualStyleBackColor = False
        '
        'txt_Wamt
        '
        Me.txt_Wamt.Enabled = False
        Me.txt_Wamt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Wamt.Location = New System.Drawing.Point(150, 436)
        Me.txt_Wamt.Name = "txt_Wamt"
        Me.txt_Wamt.Size = New System.Drawing.Size(142, 26)
        Me.txt_Wamt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Amount"
        '
        'DataGridView_withdrawl
        '
        Me.DataGridView_withdrawl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_withdrawl.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView_withdrawl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_withdrawl.Location = New System.Drawing.Point(52, 132)
        Me.DataGridView_withdrawl.Name = "DataGridView_withdrawl"
        Me.DataGridView_withdrawl.Size = New System.Drawing.Size(416, 257)
        Me.DataGridView_withdrawl.TabIndex = 7
        '
        'btn_Cwithdraw_close
        '
        Me.btn_Cwithdraw_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cwithdraw_close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_Cwithdraw_close.FlatAppearance.BorderSize = 0
        Me.btn_Cwithdraw_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cwithdraw_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cwithdraw_close.ForeColor = System.Drawing.Color.Black
        Me.btn_Cwithdraw_close.Location = New System.Drawing.Point(483, 1)
        Me.btn_Cwithdraw_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Cwithdraw_close.Name = "btn_Cwithdraw_close"
        Me.btn_Cwithdraw_close.Size = New System.Drawing.Size(38, 32)
        Me.btn_Cwithdraw_close.TabIndex = 68
        Me.btn_Cwithdraw_close.Text = "<"
        Me.btn_Cwithdraw_close.UseVisualStyleBackColor = False
        '
        'Label_Cwithdraw
        '
        Me.Label_Cwithdraw.AutoSize = True
        Me.Label_Cwithdraw.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Cwithdraw.Location = New System.Drawing.Point(170, 9)
        Me.Label_Cwithdraw.Name = "Label_Cwithdraw"
        Me.Label_Cwithdraw.Size = New System.Drawing.Size(188, 32)
        Me.Label_Cwithdraw.TabIndex = 134
        Me.Label_Cwithdraw.Text = "Withdrawal"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 10)
        Me.Panel1.TabIndex = 141
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 504)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 10)
        Me.Panel3.TabIndex = 142
        '
        'btn_CBalc
        '
        Me.btn_CBalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_CBalc.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CBalc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_CBalc.Location = New System.Drawing.Point(319, 68)
        Me.btn_CBalc.Name = "btn_CBalc"
        Me.btn_CBalc.Size = New System.Drawing.Size(111, 31)
        Me.btn_CBalc.TabIndex = 143
        Me.btn_CBalc.Text = "Check Balance"
        Me.btn_CBalc.UseVisualStyleBackColor = False
        '
        'Combo_EEFC
        '
        Me.Combo_EEFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_EEFC.FormattingEnabled = True
        Me.Combo_EEFC.Location = New System.Drawing.Point(150, 73)
        Me.Combo_EEFC.Name = "Combo_EEFC"
        Me.Combo_EEFC.Size = New System.Drawing.Size(142, 27)
        Me.Combo_EEFC.TabIndex = 144
        '
        'Frm_WithdrawCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(520, 514)
        Me.Controls.Add(Me.Combo_EEFC)
        Me.Controls.Add(Me.btn_CBalc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_Cwithdraw_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label_Cwithdraw)
        Me.Controls.Add(Me.DataGridView_withdrawl)
        Me.Controls.Add(Me.txt_Wamt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Withdraw)
        Me.Controls.Add(Me.Label_EEFC)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_WithdrawCompany"
        Me.Text = "Frm_WithdrawCompany"
        CType(Me.DataGridView_withdrawl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_EEFC As System.Windows.Forms.Label
    Friend WithEvents btn_Withdraw As System.Windows.Forms.Button
    Friend WithEvents txt_Wamt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_withdrawl As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Cwithdraw_close As System.Windows.Forms.Button
    Friend WithEvents Label_Cwithdraw As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_CBalc As System.Windows.Forms.Button
    Friend WithEvents Combo_EEFC As System.Windows.Forms.ComboBox
End Class
