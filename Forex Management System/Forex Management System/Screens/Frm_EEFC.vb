Imports System.Data.Odbc

Public Class Frm_EEFC

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Frm_EEFC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()

    End Sub

    Private Sub btn_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click
        sql = "insert into EEFC_Creation(EEFC_No,CompanyName,TypeofCompany,BankName,PAN,Address,MobileNo,Email,Currency,Business) values('" & txt_cid.Text & "','" & txt_cmpnyname.Text & "','" & combox_cmpnytype.Text & "','" & Combo_Bname.Text & "','" & txt_panno.Text & "','" & rtxt_adrs.Text & "','" & txt_mobno.Text & "','" & txt_email.Text & "','" & combox_currency.Text & "','" & Combo_NoB.Text & "')"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("data saved successfully")
    End Sub

   
    Private Sub txt_cmpnyname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cmpnyname.KeyPress
        characteronly(e)

    End Sub

    
    Private Sub txt_cid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cid.KeyPress
        numberonly(e)

    End Sub

    Private Sub txt_mobno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mobno.KeyPress
        numberonly(e)

    End Sub
End Class