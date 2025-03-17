Imports System.Data.Odbc

Public Class Frm_TransactionsCompany

    Private Sub btn_Cbalc_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cbalc_Close.Click
        Me.Dispose()
    End Sub

    Private Sub btn_Cbalc_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_CompanyUser.Show()
    End Sub

    Private Sub Frm_TransactionsCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btn_check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_check.Click
        sql = "select * from ctransaction where EEFC_No='" & Combo_EEFC.Text & "' order by TID desc"
        dml = New OdbcCommand(sql, conn)
        da.SelectCommand = dml
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView_balance.DataSource = bs
        da.Update(dt)
        DataGridView_balance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        DataGridView_balance.DataSource = Nothing
        DataGridView_balance.Refresh()
        dt.Clear()
        Combo_EEFC.Text = ""

    End Sub
End Class