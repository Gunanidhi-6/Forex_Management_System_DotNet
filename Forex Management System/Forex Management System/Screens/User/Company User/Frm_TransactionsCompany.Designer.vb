<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TransactionsCompany
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
        Me.DataGridView_balance = New System.Windows.Forms.DataGridView()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_CBalance = New System.Windows.Forms.Label()
        Me.btn_Cbalc_Close = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Combo_EEFC = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        CType(Me.DataGridView_balance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_balance
        '
        Me.DataGridView_balance.AllowUserToAddRows = False
        Me.DataGridView_balance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_balance.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView_balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_balance.Location = New System.Drawing.Point(50, 177)
        Me.DataGridView_balance.Name = "DataGridView_balance"
        Me.DataGridView_balance.Size = New System.Drawing.Size(441, 303)
        Me.DataGridView_balance.TabIndex = 142
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_check.FlatAppearance.BorderSize = 0
        Me.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_check.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_check.Location = New System.Drawing.Point(219, 120)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 34)
        Me.btn_check.TabIndex = 139
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "EEFC A/c No"
        '
        'Label_CBalance
        '
        Me.Label_CBalance.AutoSize = True
        Me.Label_CBalance.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CBalance.Location = New System.Drawing.Point(172, 13)
        Me.Label_CBalance.Name = "Label_CBalance"
        Me.Label_CBalance.Size = New System.Drawing.Size(208, 32)
        Me.Label_CBalance.TabIndex = 143
        Me.Label_CBalance.Text = "Transactions"
        '
        'btn_Cbalc_Close
        '
        Me.btn_Cbalc_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cbalc_Close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_Cbalc_Close.FlatAppearance.BorderSize = 0
        Me.btn_Cbalc_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cbalc_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cbalc_Close.ForeColor = System.Drawing.Color.Black
        Me.btn_Cbalc_Close.Location = New System.Drawing.Point(522, 1)
        Me.btn_Cbalc_Close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Cbalc_Close.Name = "btn_Cbalc_Close"
        Me.btn_Cbalc_Close.Size = New System.Drawing.Size(38, 32)
        Me.btn_Cbalc_Close.TabIndex = 144
        Me.btn_Cbalc_Close.Text = "<"
        Me.btn_Cbalc_Close.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 10)
        Me.Panel2.TabIndex = 146
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 491)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(560, 10)
        Me.Panel3.TabIndex = 164
        '
        'Combo_EEFC
        '
        Me.Combo_EEFC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_EEFC.FormattingEnabled = True
        Me.Combo_EEFC.Location = New System.Drawing.Point(191, 60)
        Me.Combo_EEFC.Name = "Combo_EEFC"
        Me.Combo_EEFC.Size = New System.Drawing.Size(142, 27)
        Me.Combo_EEFC.TabIndex = 165
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(124, 120)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 34)
        Me.btn_clear.TabIndex = 166
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Frm_TransactionsCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(560, 501)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Combo_EEFC)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_Cbalc_Close)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label_CBalance)
        Me.Controls.Add(Me.DataGridView_balance)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_TransactionsCompany"
        Me.Text = "Frm_BalanceCompany"
        CType(Me.DataGridView_balance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_balance As System.Windows.Forms.DataGridView
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_CBalance As System.Windows.Forms.Label
    Friend WithEvents btn_Cbalc_Close As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Combo_EEFC As System.Windows.Forms.ComboBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
