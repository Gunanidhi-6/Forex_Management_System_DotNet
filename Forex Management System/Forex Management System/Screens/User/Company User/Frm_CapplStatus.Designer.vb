<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CapplStatus
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
        Me.ListView_applic = New System.Windows.Forms.ListView()
        Me.Label_Capli = New System.Windows.Forms.Label()
        Me.txt_applicno = New System.Windows.Forms.TextBox()
        Me.btn_Caplistatus_close = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_check.FlatAppearance.BorderSize = 0
        Me.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_check.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_check.Location = New System.Drawing.Point(321, 63)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 32)
        Me.btn_check.TabIndex = 161
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'ListView_applic
        '
        Me.ListView_applic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_applic.Location = New System.Drawing.Point(47, 122)
        Me.ListView_applic.Name = "ListView_applic"
        Me.ListView_applic.Size = New System.Drawing.Size(349, 257)
        Me.ListView_applic.TabIndex = 160
        Me.ListView_applic.UseCompatibleStateImageBehavior = False
        '
        'Label_Capli
        '
        Me.Label_Capli.AutoSize = True
        Me.Label_Capli.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Capli.Location = New System.Drawing.Point(43, 68)
        Me.Label_Capli.Name = "Label_Capli"
        Me.Label_Capli.Size = New System.Drawing.Size(102, 19)
        Me.Label_Capli.TabIndex = 158
        Me.Label_Capli.Text = "Application No"
        '
        'txt_applicno
        '
        Me.txt_applicno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_applicno.Location = New System.Drawing.Point(155, 67)
        Me.txt_applicno.Name = "txt_applicno"
        Me.txt_applicno.Size = New System.Drawing.Size(142, 26)
        Me.txt_applicno.TabIndex = 159
        '
        'btn_Caplistatus_close
        '
        Me.btn_Caplistatus_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Caplistatus_close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_Caplistatus_close.FlatAppearance.BorderSize = 0
        Me.btn_Caplistatus_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Caplistatus_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Caplistatus_close.ForeColor = System.Drawing.Color.Black
        Me.btn_Caplistatus_close.Location = New System.Drawing.Point(400, 1)
        Me.btn_Caplistatus_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Caplistatus_close.Name = "btn_Caplistatus_close"
        Me.btn_Caplistatus_close.Size = New System.Drawing.Size(38, 32)
        Me.btn_Caplistatus_close.TabIndex = 162
        Me.btn_Caplistatus_close.Text = "<"
        Me.btn_Caplistatus_close.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(438, 10)
        Me.Panel3.TabIndex = 163
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 10)
        Me.Panel2.TabIndex = 164
        '
        'Frm_CapplStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(438, 406)
        Me.Controls.Add(Me.btn_Caplistatus_close)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.ListView_applic)
        Me.Controls.Add(Me.Label_Capli)
        Me.Controls.Add(Me.txt_applicno)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_CapplStatus"
        Me.Text = "Frm_CapplStatus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents ListView_applic As System.Windows.Forms.ListView
    Friend WithEvents Label_Capli As System.Windows.Forms.Label
    Friend WithEvents txt_applicno As System.Windows.Forms.TextBox
    Friend WithEvents btn_Caplistatus_close As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
