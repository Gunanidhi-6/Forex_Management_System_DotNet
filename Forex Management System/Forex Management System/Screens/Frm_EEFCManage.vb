Imports System.Data.Odbc

Public Class Frm_EEFCManage

    Private Sub EEFCManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        sql = "select * from eefc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim eefc As Long

        While dr.Read
            eefc = dr.GetValue(0)
            combox_EEFC.Items.Add(eefc)

        End While
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        combox_EEFC.Text = ""
        Txt_Bname.Clear()
        txt_Cname.Clear()
        Txt_Toc.Clear()

    End Sub

   

    Private Sub btn_Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Find.Click
        If (combox_EEFC.Text = "") Then
            MsgBox("EEFC A/c No is required")
        End If

        sql = "select * from EEFC_Creation WHERE EEFC_No='" & combox_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_bname.Text = dr.GetValue(3)
            txt_Cname.Text = dr.GetValue(1)
            Txt_Toc.Text = dr.GetValue(2)
            Txt_Pan.Text = dr.GetValue(1)
            Combo_currency.Text = dr.GetValue(8)
            Combo_Business.Text = dr.GetValue(9)
            Txt_mobno.Text = dr.GetValue(6)
            Txt_email.Text = dr.GetValue(7)
            Rtxt_address.Text = dr.GetValue(5)

        End If

        Combo_Business.Enabled = True
        Combo_currency.Enabled = True
        Txt_email.Enabled = True
        Txt_mobno.Enabled = True
        Rtxt_address.Enabled = True
        btn_update.Enabled = True
        btn_delete.Enabled = True
        btn_clear.Enabled = True

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        sql = "update EEFC_Creation set Currency='" & Combo_currency.Text & "',Business='" & Combo_Business.Text & "',MobileNo='" & Txt_mobno.Text & "',Email='" & Txt_email.Text & "',Address='" & Rtxt_address.Text & "' where EEFC_No='" & combox_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Company data updated successfully")


        btn_update.Enabled = False
        btn_delete.Enabled = False



    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        sql = "delete from ctransaction where EEFC_No='" & combox_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        Call conn1()

        sql = "delete from EEFC_Creation where EEFC_No='" & combox_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("data deleted successfully")



        btn_update.Enabled = False
        btn_delete.Enabled = False



    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Combo_Business.Text = ""
        Combo_currency.Text = ""
        combox_EEFC.Text = ""
        txt_bname.Clear()
        txt_Cname.Clear()
        Txt_email.Clear()
        Txt_mobno.Clear()
        Txt_Pan.Clear()
        Txt_Toc.Clear()
        Rtxt_address.Clear()

    End Sub
End Class