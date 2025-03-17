<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CompanyUser
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
        Me.btn_CompanyUser_close = New System.Windows.Forms.Button()
        Me.panel_companyuser = New System.Windows.Forms.Panel()
        Me.GroupBoxService = New System.Windows.Forms.GroupBox()
        Me.btn_Cexport = New System.Windows.Forms.Button()
        Me.btn_Cimport = New System.Windows.Forms.Button()
        Me.btn_LoC = New System.Windows.Forms.Button()
        Me.btn_CapliStatus = New System.Windows.Forms.Button()
        Me.btn_Creqcur = New System.Windows.Forms.Button()
        Me.btn_withdrawal = New System.Windows.Forms.Button()
        Me.btn_balance = New System.Windows.Forms.Button()
        Me.btn_deposit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.panel_companyuser.SuspendLayout()
        Me.GroupBoxService.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_CompanyUser_close
        '
        Me.btn_CompanyUser_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CompanyUser_close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_CompanyUser_close.FlatAppearance.BorderSize = 0
        Me.btn_CompanyUser_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CompanyUser_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CompanyUser_close.ForeColor = System.Drawing.Color.Black
        Me.btn_CompanyUser_close.Location = New System.Drawing.Point(831, 0)
        Me.btn_CompanyUser_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CompanyUser_close.Name = "btn_CompanyUser_close"
        Me.btn_CompanyUser_close.Size = New System.Drawing.Size(38, 32)
        Me.btn_CompanyUser_close.TabIndex = 116
        Me.btn_CompanyUser_close.Text = "<"
        Me.btn_CompanyUser_close.UseVisualStyleBackColor = False
        '
        'panel_companyuser
        '
        Me.panel_companyuser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.panel_companyuser.Controls.Add(Me.GroupBoxService)
        Me.panel_companyuser.Controls.Add(Me.Label2)
        Me.panel_companyuser.Controls.Add(Me.Label3)
        Me.panel_companyuser.Controls.Add(Me.TextBox2)
        Me.panel_companyuser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_companyuser.Location = New System.Drawing.Point(0, 0)
        Me.panel_companyuser.Name = "panel_companyuser"
        Me.panel_companyuser.Size = New System.Drawing.Size(869, 491)
        Me.panel_companyuser.TabIndex = 117
        '
        'GroupBoxService
        '
        Me.GroupBoxService.Controls.Add(Me.btn_Cexport)
        Me.GroupBoxService.Controls.Add(Me.btn_Cimport)
        Me.GroupBoxService.Controls.Add(Me.btn_LoC)
        Me.GroupBoxService.Controls.Add(Me.btn_CapliStatus)
        Me.GroupBoxService.Controls.Add(Me.btn_Creqcur)
        Me.GroupBoxService.Controls.Add(Me.btn_withdrawal)
        Me.GroupBoxService.Controls.Add(Me.btn_balance)
        Me.GroupBoxService.Controls.Add(Me.btn_deposit)
        Me.GroupBoxService.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxService.Location = New System.Drawing.Point(190, 168)
        Me.GroupBoxService.Name = "GroupBoxService"
        Me.GroupBoxService.Size = New System.Drawing.Size(541, 294)
        Me.GroupBoxService.TabIndex = 117
        Me.GroupBoxService.TabStop = False
        Me.GroupBoxService.Text = "Services"
        '
        'btn_Cexport
        '
        Me.btn_Cexport.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_Cexport.FlatAppearance.BorderSize = 0
        Me.btn_Cexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cexport.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cexport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cexport.Location = New System.Drawing.Point(206, 207)
        Me.btn_Cexport.Name = "btn_Cexport"
        Me.btn_Cexport.Size = New System.Drawing.Size(119, 63)
        Me.btn_Cexport.TabIndex = 8
        Me.btn_Cexport.Text = "Export details"
        Me.btn_Cexport.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Cexport.UseVisualStyleBackColor = False
        '
        'btn_Cimport
        '
        Me.btn_Cimport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_Cimport.FlatAppearance.BorderSize = 0
        Me.btn_Cimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cimport.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cimport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cimport.Location = New System.Drawing.Point(23, 207)
        Me.btn_Cimport.Name = "btn_Cimport"
        Me.btn_Cimport.Size = New System.Drawing.Size(119, 63)
        Me.btn_Cimport.TabIndex = 7
        Me.btn_Cimport.Text = "Import details"
        Me.btn_Cimport.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Cimport.UseVisualStyleBackColor = False
        '
        'btn_LoC
        '
        Me.btn_LoC.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_LoC.FlatAppearance.BorderSize = 0
        Me.btn_LoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LoC.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LoC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_LoC.Location = New System.Drawing.Point(23, 125)
        Me.btn_LoC.Name = "btn_LoC"
        Me.btn_LoC.Size = New System.Drawing.Size(119, 63)
        Me.btn_LoC.TabIndex = 6
        Me.btn_LoC.Text = "Letter of Credit"
        Me.btn_LoC.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_LoC.UseVisualStyleBackColor = False
        '
        'btn_CapliStatus
        '
        Me.btn_CapliStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_CapliStatus.FlatAppearance.BorderSize = 0
        Me.btn_CapliStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CapliStatus.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CapliStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_CapliStatus.Location = New System.Drawing.Point(206, 125)
        Me.btn_CapliStatus.Name = "btn_CapliStatus"
        Me.btn_CapliStatus.Size = New System.Drawing.Size(119, 63)
        Me.btn_CapliStatus.TabIndex = 4
        Me.btn_CapliStatus.Text = "Application status"
        Me.btn_CapliStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_CapliStatus.UseVisualStyleBackColor = False
        '
        'btn_Creqcur
        '
        Me.btn_Creqcur.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Creqcur.FlatAppearance.BorderSize = 0
        Me.btn_Creqcur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Creqcur.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Creqcur.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Creqcur.Location = New System.Drawing.Point(389, 125)
        Me.btn_Creqcur.Name = "btn_Creqcur"
        Me.btn_Creqcur.Size = New System.Drawing.Size(119, 63)
        Me.btn_Creqcur.TabIndex = 3
        Me.btn_Creqcur.Text = "Request currency"
        Me.btn_Creqcur.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Creqcur.UseVisualStyleBackColor = False
        '
        'btn_withdrawal
        '
        Me.btn_withdrawal.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_withdrawal.FlatAppearance.BorderSize = 0
        Me.btn_withdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_withdrawal.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_withdrawal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_withdrawal.Location = New System.Drawing.Point(206, 47)
        Me.btn_withdrawal.Name = "btn_withdrawal"
        Me.btn_withdrawal.Size = New System.Drawing.Size(119, 63)
        Me.btn_withdrawal.TabIndex = 2
        Me.btn_withdrawal.Text = "Withdrawal"
        Me.btn_withdrawal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_withdrawal.UseVisualStyleBackColor = False
        '
        'btn_balance
        '
        Me.btn_balance.BackColor = System.Drawing.Color.MediumOrchid
        Me.btn_balance.FlatAppearance.BorderSize = 0
        Me.btn_balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_balance.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_balance.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_balance.Location = New System.Drawing.Point(389, 47)
        Me.btn_balance.Name = "btn_balance"
        Me.btn_balance.Size = New System.Drawing.Size(119, 63)
        Me.btn_balance.TabIndex = 1
        Me.btn_balance.Text = "Balance"
        Me.btn_balance.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_balance.UseVisualStyleBackColor = False
        '
        'btn_deposit
        '
        Me.btn_deposit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_deposit.FlatAppearance.BorderSize = 0
        Me.btn_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deposit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deposit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_deposit.Location = New System.Drawing.Point(23, 47)
        Me.btn_deposit.Name = "btn_deposit"
        Me.btn_deposit.Size = New System.Drawing.Size(119, 63)
        Me.btn_deposit.TabIndex = 0
        Me.btn_deposit.Text = "Deposit"
        Me.btn_deposit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_deposit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "EEFC A/c No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 32)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Company User"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(259, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 26)
        Me.TextBox2.TabIndex = 119
        '
        'Frm_CompanyUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 491)
        Me.Controls.Add(Me.panel_companyuser)
        Me.Controls.Add(Me.btn_CompanyUser_close)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_CompanyUser"
        Me.Text = "Frm_CompanyUser"
        Me.panel_companyuser.ResumeLayout(False)
        Me.panel_companyuser.PerformLayout()
        Me.GroupBoxService.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_CompanyUser_close As System.Windows.Forms.Button
    Friend WithEvents panel_companyuser As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxService As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cexport As System.Windows.Forms.Button
    Friend WithEvents btn_Cimport As System.Windows.Forms.Button
    Friend WithEvents btn_LoC As System.Windows.Forms.Button
    Friend WithEvents btn_CapliStatus As System.Windows.Forms.Button
    Friend WithEvents btn_Creqcur As System.Windows.Forms.Button
    Friend WithEvents btn_withdrawal As System.Windows.Forms.Button
    Friend WithEvents btn_balance As System.Windows.Forms.Button
    Friend WithEvents btn_deposit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
