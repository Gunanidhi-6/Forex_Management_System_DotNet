<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Transactions
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
        Me.btn_check = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rfcno = New System.Windows.Forms.TextBox()
        Me.DataGridView_balance = New System.Windows.Forms.DataGridView()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        CType(Me.DataGridView_balance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_check.FlatAppearance.BorderSize = 0
        Me.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_check.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_check.Location = New System.Drawing.Point(209, 122)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 32)
        Me.btn_check.TabIndex = 133
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "RFC A/c No"
        '
        'txt_rfcno
        '
        Me.txt_rfcno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rfcno.Location = New System.Drawing.Point(150, 63)
        Me.txt_rfcno.Name = "txt_rfcno"
        Me.txt_rfcno.Size = New System.Drawing.Size(142, 26)
        Me.txt_rfcno.TabIndex = 132
        '
        'DataGridView_balance
        '
        Me.DataGridView_balance.AllowUserToAddRows = False
        Me.DataGridView_balance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_balance.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView_balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_balance.Location = New System.Drawing.Point(42, 186)
        Me.DataGridView_balance.Name = "DataGridView_balance"
        Me.DataGridView_balance.Size = New System.Drawing.Size(441, 282)
        Me.DataGridView_balance.TabIndex = 136
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(509, 1)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 138
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 10)
        Me.Panel1.TabIndex = 140
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 535)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(549, 10)
        Me.Panel3.TabIndex = 141
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 32)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Transaction Details"
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_Clear.FlatAppearance.BorderSize = 0
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Clear.Location = New System.Drawing.Point(106, 122)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 32)
        Me.btn_Clear.TabIndex = 143
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'Frm_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(549, 545)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView_balance)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_rfcno)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Transactions"
        Me.Text = "Frm_balance"
        CType(Me.DataGridView_balance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rfcno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView_balance As System.Windows.Forms.DataGridView
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
End Class
