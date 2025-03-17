Imports System.Data.Odbc

Public Class Frm_CreateUser

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_pword.UseSystemPasswordChar = False
        Else
            txt_pword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click
        sql = "insert into login values('" & Txt_Uname.Text & "','" & txt_pword.Text & "','" & Combo_role.Text & "')"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Account created successfully")

        Me.Dispose()
    End Sub

    Private Sub Button1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btn_create.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn_create.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        btn_create.Region = New Region(buttonPath)
    End Sub

    Private Sub btn_back_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btn_back.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn_back.ClientRectangle
        myRectangle.Inflate(0, 0)
        buttonPath.AddEllipse(myRectangle)
        btn_back.Region = New Region(buttonPath)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pword.TextChanged
        txt_pword.UseSystemPasswordChar = True
        CheckBox1.Checked = False
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()

    End Sub
End Class