<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_importDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_importDetails_close = New System.Windows.Forms.Button()
        Me.txt__eefcno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView_import = New System.Windows.Forms.DataGridView()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView_import, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_importDetails_close
        '
        Me.btn_importDetails_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_importDetails_close.BackColor = System.Drawing.SystemColors.Window
        Me.btn_importDetails_close.FlatAppearance.BorderSize = 0
        Me.btn_importDetails_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_importDetails_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_importDetails_close.ForeColor = System.Drawing.Color.Black
        Me.btn_importDetails_close.Location = New System.Drawing.Point(552, 1)
        Me.btn_importDetails_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_importDetails_close.Name = "btn_importDetails_close"
        Me.btn_importDetails_close.Size = New System.Drawing.Size(38, 32)
        Me.btn_importDetails_close.TabIndex = 57
        Me.btn_importDetails_close.Text = "<"
        Me.btn_importDetails_close.UseVisualStyleBackColor = False
        '
        'txt__eefcno
        '
        Me.txt__eefcno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt__eefcno.Location = New System.Drawing.Point(157, 103)
        Me.txt__eefcno.Name = "txt__eefcno"
        Me.txt__eefcno.Size = New System.Drawing.Size(134, 26)
        Me.txt__eefcno.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "EEFC A/c No"
        '
        'DataGridView_import
        '
        Me.DataGridView_import.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_import.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_import.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_import.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_import.Location = New System.Drawing.Point(53, 242)
        Me.DataGridView_import.Name = "DataGridView_import"
        Me.DataGridView_import.Size = New System.Drawing.Size(456, 280)
        Me.DataGridView_import.TabIndex = 60
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_show.FlatAppearance.BorderSize = 0
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_show.Location = New System.Drawing.Point(157, 168)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(134, 29)
        Me.btn_show.TabIndex = 63
        Me.btn_show.Text = "Show"
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(168, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(235, 32)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Import Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 10)
        Me.Panel1.TabIndex = 142
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 537)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(589, 10)
        Me.Panel3.TabIndex = 143
        '
        'Frm_importDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 547)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_importDetails_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.DataGridView_import)
        Me.Controls.Add(Me.txt__eefcno)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_importDetails"
        Me.Text = "Frm_importDetails"
        CType(Me.DataGridView_import, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_importDetails_close As System.Windows.Forms.Button
    Friend WithEvents txt__eefcno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_import As System.Windows.Forms.DataGridView
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
