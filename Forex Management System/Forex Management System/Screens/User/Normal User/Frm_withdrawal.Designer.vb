<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_withdrawal
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
        Me.DataGridView_withdraw = New System.Windows.Forms.DataGridView()
        Me.btn_Withdraw = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_amt = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Cbalc = New System.Windows.Forms.Button()
        Me.Combo_RFC = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView_withdraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "RFC A/c No"
        '
        'DataGridView_withdraw
        '
        Me.DataGridView_withdraw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_withdraw.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView_withdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_withdraw.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView_withdraw.Name = "DataGridView_withdraw"
        Me.DataGridView_withdraw.Size = New System.Drawing.Size(504, 258)
        Me.DataGridView_withdraw.TabIndex = 122
        '
        'btn_Withdraw
        '
        Me.btn_Withdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Withdraw.FlatAppearance.BorderSize = 0
        Me.btn_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Withdraw.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Withdraw.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Withdraw.Location = New System.Drawing.Point(318, 393)
        Me.btn_Withdraw.Name = "btn_Withdraw"
        Me.btn_Withdraw.Size = New System.Drawing.Size(109, 32)
        Me.btn_Withdraw.TabIndex = 130
        Me.btn_Withdraw.Text = "Withdraw"
        Me.btn_Withdraw.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Enter Amount"
        '
        'txt_amt
        '
        Me.txt_amt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amt.Location = New System.Drawing.Point(157, 397)
        Me.txt_amt.Name = "txt_amt"
        Me.txt_amt.Size = New System.Drawing.Size(142, 26)
        Me.txt_amt.TabIndex = 134
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(476, -1)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 135
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Window
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(-638, -1)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 32)
        Me.Button7.TabIndex = 137
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 32)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Withdrawal"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 10)
        Me.Panel2.TabIndex = 139
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 522)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(514, 10)
        Me.Panel3.TabIndex = 140
        '
        'btn_Cbalc
        '
        Me.btn_Cbalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_Cbalc.FlatAppearance.BorderSize = 0
        Me.btn_Cbalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cbalc.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cbalc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cbalc.Location = New System.Drawing.Point(318, 50)
        Me.btn_Cbalc.Name = "btn_Cbalc"
        Me.btn_Cbalc.Size = New System.Drawing.Size(109, 32)
        Me.btn_Cbalc.TabIndex = 141
        Me.btn_Cbalc.Text = "Check Balance"
        Me.btn_Cbalc.UseVisualStyleBackColor = False
        '
        'Combo_RFC
        '
        Me.Combo_RFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_RFC.FormattingEnabled = True
        Me.Combo_RFC.Location = New System.Drawing.Point(157, 52)
        Me.Combo_RFC.Name = "Combo_RFC"
        Me.Combo_RFC.Size = New System.Drawing.Size(142, 27)
        Me.Combo_RFC.TabIndex = 142
        '
        'Frm_withdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(514, 532)
        Me.Controls.Add(Me.Combo_RFC)
        Me.Controls.Add(Me.btn_Cbalc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_amt)
        Me.Controls.Add(Me.btn_Withdraw)
        Me.Controls.Add(Me.DataGridView_withdraw)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_withdrawal"
        Me.Text = "Frm_withdrawal"
        CType(Me.DataGridView_withdraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_withdraw As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Withdraw As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_amt As System.Windows.Forms.TextBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cbalc As System.Windows.Forms.Button
    Friend WithEvents Combo_RFC As System.Windows.Forms.ComboBox
End Class
