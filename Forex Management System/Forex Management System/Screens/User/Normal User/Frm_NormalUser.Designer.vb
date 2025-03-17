<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NormalUser
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
        Me.Panel_normaluser = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxService = New System.Windows.Forms.GroupBox()
        Me.btn_StudentLoan = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_import = New System.Windows.Forms.Button()
        Me.btn_withdrawal = New System.Windows.Forms.Button()
        Me.btn_balance = New System.Windows.Forms.Button()
        Me.btn_deposit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_normaluser.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxService.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_normaluser
        '
        Me.Panel_normaluser.AutoScroll = True
        Me.Panel_normaluser.Controls.Add(Me.btn_exit)
        Me.Panel_normaluser.Controls.Add(Me.PictureBox1)
        Me.Panel_normaluser.Controls.Add(Me.TextBox2)
        Me.Panel_normaluser.Controls.Add(Me.Label3)
        Me.Panel_normaluser.Controls.Add(Me.GroupBoxService)
        Me.Panel_normaluser.Controls.Add(Me.Label2)
        Me.Panel_normaluser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_normaluser.Location = New System.Drawing.Point(0, 0)
        Me.Panel_normaluser.Name = "Panel_normaluser"
        Me.Panel_normaluser.Size = New System.Drawing.Size(923, 532)
        Me.Panel_normaluser.TabIndex = 0
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(874, 11)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 151
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Forex_Management_System.My.Resources.Resources.e
        Me.PictureBox1.Location = New System.Drawing.Point(797, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 407)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(258, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 26)
        Me.TextBox2.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 32)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "User" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBoxService
        '
        Me.GroupBoxService.Controls.Add(Me.btn_StudentLoan)
        Me.GroupBoxService.Controls.Add(Me.btn_export)
        Me.GroupBoxService.Controls.Add(Me.btn_import)
        Me.GroupBoxService.Controls.Add(Me.btn_withdrawal)
        Me.GroupBoxService.Controls.Add(Me.btn_balance)
        Me.GroupBoxService.Controls.Add(Me.btn_deposit)
        Me.GroupBoxService.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxService.Location = New System.Drawing.Point(226, 158)
        Me.GroupBoxService.Name = "GroupBoxService"
        Me.GroupBoxService.Size = New System.Drawing.Size(541, 232)
        Me.GroupBoxService.TabIndex = 110
        Me.GroupBoxService.TabStop = False
        Me.GroupBoxService.Text = "Services"
        '
        'btn_StudentLoan
        '
        Me.btn_StudentLoan.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_StudentLoan.FlatAppearance.BorderSize = 0
        Me.btn_StudentLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_StudentLoan.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_StudentLoan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_StudentLoan.Location = New System.Drawing.Point(389, 140)
        Me.btn_StudentLoan.Name = "btn_StudentLoan"
        Me.btn_StudentLoan.Size = New System.Drawing.Size(117, 73)
        Me.btn_StudentLoan.TabIndex = 5
        Me.btn_StudentLoan.Text = "Education Exchange Loan"
        Me.btn_StudentLoan.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_StudentLoan.UseVisualStyleBackColor = False
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_export.FlatAppearance.BorderSize = 0
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_export.Location = New System.Drawing.Point(206, 140)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(117, 64)
        Me.btn_export.TabIndex = 4
        Me.btn_export.Text = "Application status"
        Me.btn_export.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'btn_import
        '
        Me.btn_import.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_import.FlatAppearance.BorderSize = 0
        Me.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_import.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_import.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_import.Location = New System.Drawing.Point(14, 140)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(117, 64)
        Me.btn_import.TabIndex = 3
        Me.btn_import.Text = "Request currency"
        Me.btn_import.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_import.UseVisualStyleBackColor = False
        '
        'btn_withdrawal
        '
        Me.btn_withdrawal.BackColor = System.Drawing.Color.MediumOrchid
        Me.btn_withdrawal.FlatAppearance.BorderSize = 0
        Me.btn_withdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_withdrawal.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_withdrawal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_withdrawal.Location = New System.Drawing.Point(206, 47)
        Me.btn_withdrawal.Name = "btn_withdrawal"
        Me.btn_withdrawal.Size = New System.Drawing.Size(117, 64)
        Me.btn_withdrawal.TabIndex = 2
        Me.btn_withdrawal.Text = "Withdrawal"
        Me.btn_withdrawal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_withdrawal.UseVisualStyleBackColor = False
        '
        'btn_balance
        '
        Me.btn_balance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_balance.FlatAppearance.BorderSize = 0
        Me.btn_balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_balance.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_balance.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_balance.Location = New System.Drawing.Point(389, 47)
        Me.btn_balance.Name = "btn_balance"
        Me.btn_balance.Size = New System.Drawing.Size(117, 64)
        Me.btn_balance.TabIndex = 1
        Me.btn_balance.Text = "Balance"
        Me.btn_balance.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_balance.UseVisualStyleBackColor = False
        '
        'btn_deposit
        '
        Me.btn_deposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_deposit.FlatAppearance.BorderSize = 0
        Me.btn_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deposit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deposit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_deposit.Location = New System.Drawing.Point(14, 47)
        Me.btn_deposit.Name = "btn_deposit"
        Me.btn_deposit.Size = New System.Drawing.Size(117, 64)
        Me.btn_deposit.TabIndex = 0
        Me.btn_deposit.Text = "Deposit"
        Me.btn_deposit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_deposit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "RFC A/c No"
        '
        'Frm_NormalUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(923, 532)
        Me.Controls.Add(Me.Panel_normaluser)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_NormalUser"
        Me.Text = "i"
        Me.Panel_normaluser.ResumeLayout(False)
        Me.Panel_normaluser.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxService.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_normaluser As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxService As System.Windows.Forms.GroupBox
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_import As System.Windows.Forms.Button
    Friend WithEvents btn_withdrawal As System.Windows.Forms.Button
    Friend WithEvents btn_balance As System.Windows.Forms.Button
    Friend WithEvents btn_deposit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_StudentLoan As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
End Class
