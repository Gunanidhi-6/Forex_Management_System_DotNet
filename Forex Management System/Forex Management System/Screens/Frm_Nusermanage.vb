Imports System.Data.Odbc

Public Class Frm_Nusermanage

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Find.Click
        If (combox_RFC.Text = "") Then
            MsgBox("RFC A/c No is required")
        End If

        sql = "select * from RFC_Creation WHERE RFC_No='" & combox_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            Txt_Bname.Text = dr.GetValue(3)
            txt_fname.Text = dr.GetValue(1)
            Txt_lname.Text = dr.GetValue(2)
            Txt_Passport.Text = dr.GetValue(4)
            Dtp_doi.Text = dr.GetValue(5)
            Dtp_validupto.Text = dr.GetValue(6)
            Combo_currency.Text = dr.GetValue(9)
            Txt_email.Text = dr.GetValue(10)
            Txt_mobno.Text = dr.GetValue(11)
            Rtxt_address.Text = dr.GetValue(14)
        End If
        btn_update.Enabled = True
        btn_delete.Enabled = True

        Txt_mobno.Enabled = True
        Dtp_doi.Enabled = True
        Dtp_validupto.Enabled = True
        Txt_email.Enabled = True
        Rtxt_address.Enabled = True
        Combo_currency.Enabled = True


    End Sub

    Private Sub Frm_Nusermanage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()

        sql = "select * from rfc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim rfc As Long

        While dr.Read
            rfc = dr.GetValue(0)
            combox_RFC.Items.Add(rfc)

        End While


        Dtp_doi.Format = DateTimePickerFormat.Custom
        Dtp_doi.CustomFormat = "yyyy-MM-dd"
        Dtp_validupto.Format = DateTimePickerFormat.Custom
        Dtp_validupto.CustomFormat = "yyyy-MM-dd"


        Txt_mobno.Enabled = False
        Dtp_doi.Enabled = False
        Dtp_validupto.Enabled = False
        Txt_email.Enabled = False
        Rtxt_address.Enabled = False
        Combo_currency.Enabled = False




    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        sql = "update RFC_Creation set IssueDate='" & Dtp_doi.Text & "',ValidUpto='" & Dtp_validupto.Text & "',Currency='" & Combo_currency.Text & "',MobileNo='" & Txt_mobno.Text & "',Email='" & Txt_email.Text & "',Address='" & Rtxt_address.Text & "' where RFC_No='" & combox_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("data updated successfully")

        btn_update.Enabled = False
        btn_delete.Enabled = False


    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        sql = "delete from transaction where RFC_No='" & combox_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        Call conn1()

        sql = "delete from RFC_Creation where RFC_No='" & combox_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("data deleted successfully")

        btn_update.Enabled = False
        btn_delete.Enabled = False


    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click


        txt_bname.Clear()
        Combo_currency.Text = ""
        Txt_email.Clear()
        txt_fname.Clear()
        Txt_lname.Clear()
        Txt_mobno.Clear()
        Txt_Passport.Clear()
        combox_RFC.Text = ""
        Rtxt_address.Clear()


    End Sub
End Class