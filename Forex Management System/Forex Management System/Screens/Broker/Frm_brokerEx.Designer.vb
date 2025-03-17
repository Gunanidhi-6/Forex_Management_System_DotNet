<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_brokerEx
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
        Me.Panel_brokerex = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxService = New System.Windows.Forms.GroupBox()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_import = New System.Windows.Forms.Button()
        Me.btn_convertRupee = New System.Windows.Forms.Button()
        Me.btn_convertFC = New System.Windows.Forms.Button()
        Me.btn_deposit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_tvcheque = New System.Windows.Forms.Button()
        Me.Panel_brokerex.SuspendLayout()
        Me.GroupBoxService.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_brokerex
        '
        Me.Panel_brokerex.Controls.Add(Me.btn_exit)
        Me.Panel_brokerex.Controls.Add(Me.Panel3)
        Me.Panel_brokerex.Controls.Add(Me.Label3)
        Me.Panel_brokerex.Controls.Add(Me.GroupBoxService)
        Me.Panel_brokerex.Controls.Add(Me.Panel2)
        Me.Panel_brokerex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_brokerex.Location = New System.Drawing.Point(0, 0)
        Me.Panel_brokerex.Name = "Panel_brokerex"
        Me.Panel_brokerex.Size = New System.Drawing.Size(976, 623)
        Me.Panel_brokerex.TabIndex = 0
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(938, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(38, 32)
        Me.btn_exit.TabIndex = 101
        Me.btn_exit.Text = "<"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 613)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(976, 10)
        Me.Panel3.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 26)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Broker"
        '
        'GroupBoxService
        '
        Me.GroupBoxService.Controls.Add(Me.btn_tvcheque)
        Me.GroupBoxService.Controls.Add(Me.btn_export)
        Me.GroupBoxService.Controls.Add(Me.btn_import)
        Me.GroupBoxService.Controls.Add(Me.btn_convertRupee)
        Me.GroupBoxService.Controls.Add(Me.btn_convertFC)
        Me.GroupBoxService.Controls.Add(Me.btn_deposit)
        Me.GroupBoxService.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxService.Location = New System.Drawing.Point(176, 140)
        Me.GroupBoxService.Name = "GroupBoxService"
        Me.GroupBoxService.Size = New System.Drawing.Size(541, 232)
        Me.GroupBoxService.TabIndex = 106
        Me.GroupBoxService.TabStop = False
        Me.GroupBoxService.Text = "Services"
        '
        'btn_export
        '
        Me.btn_export.FlatAppearance.BorderSize = 0
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Location = New System.Drawing.Point(206, 140)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(114, 64)
        Me.btn_export.TabIndex = 4
        Me.btn_export.Text = "Export Billing"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'btn_import
        '
        Me.btn_import.FlatAppearance.BorderSize = 0
        Me.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_import.Location = New System.Drawing.Point(14, 140)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(114, 64)
        Me.btn_import.TabIndex = 3
        Me.btn_import.Text = "Import Credit"
        Me.btn_import.UseVisualStyleBackColor = True
        '
        'btn_convertRupee
        '
        Me.btn_convertRupee.FlatAppearance.BorderSize = 0
        Me.btn_convertRupee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_convertRupee.Location = New System.Drawing.Point(206, 47)
        Me.btn_convertRupee.Name = "btn_convertRupee"
        Me.btn_convertRupee.Size = New System.Drawing.Size(114, 64)
        Me.btn_convertRupee.TabIndex = 2
        Me.btn_convertRupee.Text = "Conversion Fc to Rupee"
        Me.btn_convertRupee.UseVisualStyleBackColor = True
        '
        'btn_convertFC
        '
        Me.btn_convertFC.FlatAppearance.BorderSize = 0
        Me.btn_convertFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_convertFC.Location = New System.Drawing.Point(399, 47)
        Me.btn_convertFC.Name = "btn_convertFC"
        Me.btn_convertFC.Size = New System.Drawing.Size(114, 64)
        Me.btn_convertFC.TabIndex = 1
        Me.btn_convertFC.Text = "Conversion Rs to FC"
        Me.btn_convertFC.UseVisualStyleBackColor = True
        '
        'btn_deposit
        '
        Me.btn_deposit.FlatAppearance.BorderSize = 0
        Me.btn_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deposit.Location = New System.Drawing.Point(14, 47)
        Me.btn_deposit.Name = "btn_deposit"
        Me.btn_deposit.Size = New System.Drawing.Size(114, 64)
        Me.btn_deposit.TabIndex = 0
        Me.btn_deposit.Text = "Deposit"
        Me.btn_deposit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 10)
        Me.Panel2.TabIndex = 109
        '
        'btn_tvcheque
        '
        Me.btn_tvcheque.FlatAppearance.BorderSize = 0
        Me.btn_tvcheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tvcheque.Location = New System.Drawing.Point(399, 140)
        Me.btn_tvcheque.Name = "btn_tvcheque"
        Me.btn_tvcheque.Size = New System.Drawing.Size(114, 64)
        Me.btn_tvcheque.TabIndex = 5
        Me.btn_tvcheque.Text = "Travellers Cheque"
        Me.btn_tvcheque.UseVisualStyleBackColor = True
        '
        'Frm_brokerEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(976, 623)
        Me.Controls.Add(Me.Panel_brokerex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_brokerEx"
        Me.Text = "Frm_brokerEx"
        Me.Panel_brokerex.ResumeLayout(False)
        Me.Panel_brokerex.PerformLayout()
        Me.GroupBoxService.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_brokerex As System.Windows.Forms.Panel
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxService As System.Windows.Forms.GroupBox
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_import As System.Windows.Forms.Button
    Friend WithEvents btn_convertRupee As System.Windows.Forms.Button
    Friend WithEvents btn_convertFC As System.Windows.Forms.Button
    Friend WithEvents btn_deposit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_tvcheque As System.Windows.Forms.Button
End Class
