<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_exportDetails
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_exportDetails_close = New System.Windows.Forms.Button()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.DataGridView_expot = New System.Windows.Forms.DataGridView()
        Me.txt_eefcno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView_expot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(203, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(227, 32)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Export Details"
        '
        'btn_exportDetails_close
        '
        Me.btn_exportDetails_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exportDetails_close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_exportDetails_close.FlatAppearance.BorderSize = 0
        Me.btn_exportDetails_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exportDetails_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exportDetails_close.ForeColor = System.Drawing.Color.Black
        Me.btn_exportDetails_close.Location = New System.Drawing.Point(551, 1)
        Me.btn_exportDetails_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exportDetails_close.Name = "btn_exportDetails_close"
        Me.btn_exportDetails_close.Size = New System.Drawing.Size(38, 32)
        Me.btn_exportDetails_close.TabIndex = 66
        Me.btn_exportDetails_close.Text = "<"
        Me.btn_exportDetails_close.UseVisualStyleBackColor = False
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btn_show.FlatAppearance.BorderSize = 0
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_show.Location = New System.Drawing.Point(170, 167)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(134, 29)
        Me.btn_show.TabIndex = 72
        Me.btn_show.Text = "Show"
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'DataGridView_expot
        '
        Me.DataGridView_expot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_expot.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView_expot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_expot.Location = New System.Drawing.Point(66, 241)
        Me.DataGridView_expot.Name = "DataGridView_expot"
        Me.DataGridView_expot.Size = New System.Drawing.Size(456, 280)
        Me.DataGridView_expot.TabIndex = 69
        '
        'txt_eefcno
        '
        Me.txt_eefcno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_eefcno.Location = New System.Drawing.Point(170, 102)
        Me.txt_eefcno.Name = "txt_eefcno"
        Me.txt_eefcno.Size = New System.Drawing.Size(134, 26)
        Me.txt_eefcno.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "EEFC A/c No"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 537)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(589, 10)
        Me.Panel3.TabIndex = 117
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(589, 10)
        Me.Panel2.TabIndex = 143
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 10)
        Me.Panel1.TabIndex = 143
        '
        'Frm_exportDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(589, 547)
        Me.Controls.Add(Me.btn_exportDetails_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.DataGridView_expot)
        Me.Controls.Add(Me.txt_eefcno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_exportDetails"
        Me.Text = "Frm_exportDetails"
        CType(Me.DataGridView_expot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_exportDetails_close As System.Windows.Forms.Button
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents DataGridView_expot As System.Windows.Forms.DataGridView
    Friend WithEvents txt_eefcno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
