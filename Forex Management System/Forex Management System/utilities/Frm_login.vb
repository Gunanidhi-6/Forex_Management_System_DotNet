Public Class Frm_login

    Private Sub Button1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Btn_login.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Btn_login.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        Btn_login.Region = New Region(buttonPath)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Password" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Password"
            TextBox1.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.UseSystemPasswordChar = True
        CheckBox1.Checked = False
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "User Name" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "User Name"
            TextBox2.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = "User Name"
        TextBox2.ForeColor = Color.DimGray
        TextBox1.Text = "Password"
        TextBox1.ForeColor = Color.DimGray
    End Sub

    Private Sub Btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_login.Click
        Frm_loading.Show()
    End Sub
End Class