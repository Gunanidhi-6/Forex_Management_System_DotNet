

Public Class Frm_Register

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        Frm_login.TopLevel = False
        Panel2.Controls.Add(Frm_login)
        Frm_login.BringToFront()
        Frm_login.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_register.Click
        Frm_CreateUser.TopLevel = False
        Panel2.Controls.Add(Frm_CreateUser)
        Frm_CreateUser.BringToFront()
        Frm_CreateUser.Show()

    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub btn_register_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btn_register.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn_register.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        btn_register.Region = New Region(buttonPath)
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Dim panelpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Panel2.ClientRectangle
        myRectangle.Inflate(0, 0)
        panelpath.AddEllipse(myRectangle)
        Panel2.Region = New Region(panelpath)
    End Sub
End Class

