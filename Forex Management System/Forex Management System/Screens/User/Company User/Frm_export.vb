Imports System.Data.Odbc

Public Class Frm_export

    Private Sub btn_ExportExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()

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
            combox_cmpnytype.Text = dr.GetValue(2)
            txt_cmpnyname.Text = dr.GetValue(1)
            rtxt_adrs.Text = dr.GetValue(5)

        End If
    End Sub

    Private Sub Frm_export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub
End Class