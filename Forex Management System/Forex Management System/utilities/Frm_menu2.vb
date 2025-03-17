Imports System.Runtime.InteropServices

Public Class Frm_menu2
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_exit_bt.Click
        End
    End Sub
    Private Sub hideSubmenu()
        menu_bank_panel.Visible = False
        menu__broker_panel.Visible = False
        menu_company_panel.Visible = False
        menu_users_panel.Visible = False
        If slidepanel.Width = 220 Then
            tmOCULTAR.Enabled = True
        End If

    End Sub
    Private Sub Frm_menu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        slidepanel.Width = 60
        menu__broker_panel.Visible = False
        menu_bank_panel.Visible = False
        menu_company_panel.Visible = False
        menu_users_panel.Visible = False
        menu_bt11.Visible = False
        menu_bt8.Visible = False
    End Sub
    Private Sub tmOCULTAR_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmOCULTAR.Tick
        If slidepanel.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.slidepanel.Width = slidepanel.Width - 5
        End If
    End Sub

    Private Sub tmMOSTRAR_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmMOSTRAR.Tick
        If slidepanel.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.slidepanel.Width = slidepanel.Width + 5
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub menu_bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt1.Click
        If menu_bank_panel.Visible = False Then
            menu_bank_panel.Visible = True
        Else
            menu_bank_panel.Visible = False
        End If

    End Sub

    Private Sub menu_bt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt4.Click
        If menu__broker_panel.Visible = False Then
            menu__broker_panel.Visible = True
        Else
            menu__broker_panel.Visible = False
        End If
    End Sub

    Private Sub menu_bt7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt7.Click
        If menu_bt8.Visible = False Then
            menu_bt8.Visible = True
        Else
            menu_bt8.Visible = False
        End If
        If menu_bt11.Visible = False Then
            menu_bt11.Visible = True
        Else
            menu_bt11.Visible = False
        End If

    End Sub

    Private Sub menu_bt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt8.Click
        If menu_company_panel.Visible = False Then
            menu_company_panel.Visible = True
        Else
            menu_company_panel.Visible = False
        End If
    End Sub

    Private Sub menu_bt11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt11.Click
        If menu_users_panel.Visible = False Then
            menu_users_panel.Visible = True
        Else
            menu_users_panel.Visible = False
        End If
    End Sub

   
    Private Sub barpanel_Mousedown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles barpanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Frm_menu2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If slidepanel.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf slidepanel.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub menu_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_minimize.Click
        Me.WindowState = FormWindowState.Normal
        menu_minimize.Visible = False
        menu_maximizer.Visible = True
    End Sub

    Private Sub menu_maximizer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_maximizer.Click
        menu_maximizer.Visible = False
        menu_minimize.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub formoverpanel(ByVal overpanel As Object)
        If Me.datapanel.Controls.Count > 0 Then Me.datapanel.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(overpanel, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.datapanel.Controls.Add(fh)
        Me.datapanel.Tag = fh
        fh.Show()
    End Sub

    Private Sub menu_bt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt2.Click
        formoverpanel(New Frm_BankUser)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub menu_bt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt5.Click
        formoverpanel(New Frm_brokerEx)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub menu_bt10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt10.Click
        formoverpanel(New Frm_CompanyUser)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub menu_bt12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt12.Click
        formoverpanel(New Frm_NormalUser)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub datapanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles datapanel.Paint

    End Sub

    Private Sub menu_bt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt3.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub menu_bt6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt6.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub menu_bt9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt9.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub menu_bt13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_bt13.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub
    Private Sub Frm_menu2_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub btn_logout_Click(sender As System.Object, e As System.EventArgs) Handles btn_logout.Click
        Application.Exit()
    End Sub
End Class