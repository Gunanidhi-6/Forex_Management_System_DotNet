Public NotInheritable Class Frm_loading

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim panelpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Panel1.ClientRectangle()
        myRectangle.Inflate(0, 30)
        panelpath.AddEllipse(myRectangle)
        Panel1.Region = New Region(panelpath)
    End Sub

    Private Sub loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DoubleBuffered = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Frm_menu2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        Dim panelpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = ProgressBar1.ClientRectangle()
        myRectangle.Inflate(0, 80)
        panelpath.AddEllipse(myRectangle)
        ProgressBar1.Region = New Region(panelpath)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
