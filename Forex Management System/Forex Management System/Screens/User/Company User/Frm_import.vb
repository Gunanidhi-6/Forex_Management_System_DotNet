Imports System.Data.Odbc

Public Class frm_import

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()

    End Sub


    Private Sub txt_sname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sname.TextChanged

    End Sub

    Private Sub frm_import_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        sql = "select * from eefc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim eefc As Long

        While dr.Read
            eefc = dr.GetValue(0)
            Combo_EEFC.Items.Add(eefc)

        End While
    End Sub

    Private Sub combox_trancountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rtxt_adrs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtxt_adrs.TextChanged

    End Sub


    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Combo_EEFC.Text = ""
        txt_bname.Clear()
        combox_typecmpny.Text = ""
        txt_cmpnyname.Clear()
        txt_PAN.Clear()
        rtxt_adrs.Clear()

    End Sub


    Private Sub btn_getdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_getdata.Click
        If (Combo_EEFC.Text = "") Then
            MsgBox("Kindly enter EEFC account number")
        End If
        sql = "select * from EEFC_Creation WHERE `EEFC No`='" & Combo_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_bname.Text = dr.GetValue(3)
            combox_typecmpny.Text = dr.GetValue(2)
            txt_cmpnyname.Text = dr.GetValue(1)
            rtxt_adrs.Text = dr.GetValue(5)
            txt_PAN.Text = dr.GetValue(4)

        End If
    End Sub
End Class