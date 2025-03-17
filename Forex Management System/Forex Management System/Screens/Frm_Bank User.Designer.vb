<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BankUser
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.GroupBoxService = New System.Windows.Forms.GroupBox()
        Me.btn_EEFCTrans = New System.Windows.Forms.Button()
        Me.btn_EEFCManage = New System.Windows.Forms.Button()
        Me.btn_Cexport = New System.Windows.Forms.Button()
        Me.btn_Cimport = New System.Windows.Forms.Button()
        Me.btn_LoC = New System.Windows.Forms.Button()
        Me.btn_CapliStatus = New System.Windows.Forms.Button()
        Me.btn_RFCManage = New System.Windows.Forms.Button()
        Me.btn_EEFC = New System.Windows.Forms.Button()
        Me.btn_RFCTrans = New System.Windows.Forms.Button()
        Me.btn_RFC = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxService.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(793, 9)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 150
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'GroupBoxService
        '
        Me.GroupBoxService.Controls.Add(Me.btn_EEFCTrans)
        Me.GroupBoxService.Controls.Add(Me.btn_EEFCManage)
        Me.GroupBoxService.Controls.Add(Me.btn_Cexport)
        Me.GroupBoxService.Controls.Add(Me.btn_Cimport)
        Me.GroupBoxService.Controls.Add(Me.btn_LoC)
        Me.GroupBoxService.Controls.Add(Me.btn_CapliStatus)
        Me.GroupBoxService.Controls.Add(Me.btn_RFCManage)
        Me.GroupBoxService.Controls.Add(Me.btn_EEFC)
        Me.GroupBoxService.Controls.Add(Me.btn_RFCTrans)
        Me.GroupBoxService.Controls.Add(Me.btn_RFC)
        Me.GroupBoxService.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxService.Location = New System.Drawing.Point(135, 78)
        Me.GroupBoxService.Name = "GroupBoxService"
        Me.GroupBoxService.Size = New System.Drawing.Size(541, 349)
        Me.GroupBoxService.TabIndex = 156
        Me.GroupBoxService.TabStop = False
        Me.GroupBoxService.Text = "Services"
        '
        'btn_EEFCTrans
        '
        Me.btn_EEFCTrans.BackColor = System.Drawing.Color.MediumOrchid
        Me.btn_EEFCTrans.FlatAppearance.BorderSize = 0
        Me.btn_EEFCTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EEFCTrans.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EEFCTrans.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_EEFCTrans.Location = New System.Drawing.Point(15, 118)
        Me.btn_EEFCTrans.Name = "btn_EEFCTrans"
        Me.btn_EEFCTrans.Size = New System.Drawing.Size(114, 64)
        Me.btn_EEFCTrans.TabIndex = 10
        Me.btn_EEFCTrans.Text = "EEFC Transactions"
        Me.btn_EEFCTrans.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_EEFCTrans.UseVisualStyleBackColor = False
        '
        'btn_EEFCManage
        '
        Me.btn_EEFCManage.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_EEFCManage.FlatAppearance.BorderSize = 0
        Me.btn_EEFCManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EEFCManage.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EEFCManage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_EEFCManage.Location = New System.Drawing.Point(389, 119)
        Me.btn_EEFCManage.Name = "btn_EEFCManage"
        Me.btn_EEFCManage.Size = New System.Drawing.Size(114, 64)
        Me.btn_EEFCManage.TabIndex = 9
        Me.btn_EEFCManage.Text = "EEFC A/c Manager"
        Me.btn_EEFCManage.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_EEFCManage.UseVisualStyleBackColor = False
        '
        'btn_Cexport
        '
        Me.btn_Cexport.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_Cexport.FlatAppearance.BorderSize = 0
        Me.btn_Cexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cexport.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cexport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cexport.Location = New System.Drawing.Point(389, 197)
        Me.btn_Cexport.Name = "btn_Cexport"
        Me.btn_Cexport.Size = New System.Drawing.Size(114, 64)
        Me.btn_Cexport.TabIndex = 8
        Me.btn_Cexport.Text = "Export details"
        Me.btn_Cexport.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Cexport.UseVisualStyleBackColor = False
        '
        'btn_Cimport
        '
        Me.btn_Cimport.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_Cimport.FlatAppearance.BorderSize = 0
        Me.btn_Cimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cimport.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cimport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cimport.Location = New System.Drawing.Point(206, 196)
        Me.btn_Cimport.Name = "btn_Cimport"
        Me.btn_Cimport.Size = New System.Drawing.Size(114, 64)
        Me.btn_Cimport.TabIndex = 7
        Me.btn_Cimport.Text = "Import details"
        Me.btn_Cimport.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_Cimport.UseVisualStyleBackColor = False
        '
        'btn_LoC
        '
        Me.btn_LoC.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn_LoC.FlatAppearance.BorderSize = 0
        Me.btn_LoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LoC.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LoC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_LoC.Location = New System.Drawing.Point(16, 196)
        Me.btn_LoC.Name = "btn_LoC"
        Me.btn_LoC.Size = New System.Drawing.Size(114, 64)
        Me.btn_LoC.TabIndex = 6
        Me.btn_LoC.Text = "Letter of Credit"
        Me.btn_LoC.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_LoC.UseVisualStyleBackColor = False
        '
        'btn_CapliStatus
        '
        Me.btn_CapliStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_CapliStatus.FlatAppearance.BorderSize = 0
        Me.btn_CapliStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CapliStatus.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CapliStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_CapliStatus.Location = New System.Drawing.Point(17, 271)
        Me.btn_CapliStatus.Name = "btn_CapliStatus"
        Me.btn_CapliStatus.Size = New System.Drawing.Size(114, 64)
        Me.btn_CapliStatus.TabIndex = 4
        Me.btn_CapliStatus.Text = "Application Approval"
        Me.btn_CapliStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_CapliStatus.UseVisualStyleBackColor = False
        '
        'btn_RFCManage
        '
        Me.btn_RFCManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_RFCManage.FlatAppearance.BorderSize = 0
        Me.btn_RFCManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RFCManage.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RFCManage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_RFCManage.Location = New System.Drawing.Point(206, 118)
        Me.btn_RFCManage.Name = "btn_RFCManage"
        Me.btn_RFCManage.Size = New System.Drawing.Size(114, 64)
        Me.btn_RFCManage.TabIndex = 3
        Me.btn_RFCManage.Text = "RFC A/c Manager"
        Me.btn_RFCManage.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_RFCManage.UseVisualStyleBackColor = False
        '
        'btn_EEFC
        '
        Me.btn_EEFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_EEFC.FlatAppearance.BorderSize = 0
        Me.btn_EEFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EEFC.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EEFC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_EEFC.Location = New System.Drawing.Point(206, 47)
        Me.btn_EEFC.Name = "btn_EEFC"
        Me.btn_EEFC.Size = New System.Drawing.Size(114, 64)
        Me.btn_EEFC.TabIndex = 2
        Me.btn_EEFC.Text = "Create EEFC A/c"
        Me.btn_EEFC.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_EEFC.UseVisualStyleBackColor = False
        '
        'btn_RFCTrans
        '
        Me.btn_RFCTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_RFCTrans.FlatAppearance.BorderSize = 0
        Me.btn_RFCTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RFCTrans.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RFCTrans.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_RFCTrans.Location = New System.Drawing.Point(389, 47)
        Me.btn_RFCTrans.Name = "btn_RFCTrans"
        Me.btn_RFCTrans.Size = New System.Drawing.Size(114, 64)
        Me.btn_RFCTrans.TabIndex = 1
        Me.btn_RFCTrans.Text = "RFC Transactions"
        Me.btn_RFCTrans.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_RFCTrans.UseVisualStyleBackColor = False
        '
        'btn_RFC
        '
        Me.btn_RFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_RFC.FlatAppearance.BorderSize = 0
        Me.btn_RFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RFC.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RFC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_RFC.Location = New System.Drawing.Point(14, 47)
        Me.btn_RFC.Name = "btn_RFC"
        Me.btn_RFC.Size = New System.Drawing.Size(114, 64)
        Me.btn_RFC.TabIndex = 0
        Me.btn_RFC.Text = "Create RFC A/c"
        Me.btn_RFC.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_RFC.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 32)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Bank"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Forex_Management_System.My.Resources.Resources._4
        Me.PictureBox1.Location = New System.Drawing.Point(717, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 407)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 158
        Me.PictureBox1.TabStop = False
        '
        'Frm_BankUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(852, 539)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBoxService)
        Me.Controls.Add(Me.btn_exit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_BankUser"
        Me.Text = "Frm_requestcurrency"
        Me.GroupBoxService.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents GroupBoxService As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cexport As System.Windows.Forms.Button
    Friend WithEvents btn_Cimport As System.Windows.Forms.Button
    Friend WithEvents btn_LoC As System.Windows.Forms.Button
    Friend WithEvents btn_CapliStatus As System.Windows.Forms.Button
    Friend WithEvents btn_RFCManage As System.Windows.Forms.Button
    Friend WithEvents btn_EEFC As System.Windows.Forms.Button
    Friend WithEvents btn_RFCTrans As System.Windows.Forms.Button
    Friend WithEvents btn_RFC As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_EEFCManage As System.Windows.Forms.Button
    Friend WithEvents btn_EEFCTrans As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
