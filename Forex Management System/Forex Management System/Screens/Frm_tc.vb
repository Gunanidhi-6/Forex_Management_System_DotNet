Imports System.Data.Odbc


Public Class frm_tc


    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub frm_tc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        sql = "select * from rfc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim rfc As Long

        While dr.Read
            rfc = dr.GetValue(0)
            Combo_RFC.Items.Add(rfc)

        End While
    End Sub

    Private Sub btn_getTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_getTC.Click
        If (Combo_RFC.Text = "") Then
            MsgBox("Kindly enter Rfc account number")
        End If
        sql = "select * from RFC_Creation WHERE `RFC A/c No`='" & Combo_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_fname.Text = dr.GetValue(1)
            txt_lname.Text = dr.GetValue(2)
            txt_Bname.Text = dr.GetValue(3)
            txt_passport.Text = dr.GetValue(4)
            Dtp_doi.Text = dr.GetValue(5)
            txt_validupto.Text = dr.GetValue(6)
            txt_dob.Text = dr.GetValue(7)
            combox_currency.Text = dr.GetValue(9)
            rtxtbox_adrs.Text = dr.GetValue(14)
        End If
    End Sub

   
    Private Sub txt_mobno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mobno.KeyPress
        numberonly(e)
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click

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