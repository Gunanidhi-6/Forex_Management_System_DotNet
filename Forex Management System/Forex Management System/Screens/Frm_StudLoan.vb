Imports System.Data.Odbc


Public Class Frm_StudLoan

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_insno.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub txt_currac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_currency.TextChanged

    End Sub

    Private Sub Frm_StudLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn1()
        sql = "select * from rfc_creation where age<18"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim rfc As Long

        While dr.Read
            rfc = dr.GetValue(0)
            Combo_RFC.Items.Add(rfc)

        End While

    End Sub

    Private Sub btn_getStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_getStud.Click
        If (Combo_RFC.Text = "") Then
            MsgBox("Kindly enter Rfc account number")
        End If
        sql = "select * from RFC_Creation WHERE RFC_No='" & Combo_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_fname.Text = dr.GetValue(1)
            txt_lname.Text = dr.GetValue(2)
            txt_bname.Text = dr.GetValue(3)
            txt_passport.Text = dr.GetValue(4)
            txt_dob.Text = dr.GetValue(7)
            txt_currency.Text = dr.GetValue(9)
            txt_parentname.Text = dr.GetValue(15)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is ComboBox Then
                x.Text = Nothing
            End If
        Next
    End Sub
End Class