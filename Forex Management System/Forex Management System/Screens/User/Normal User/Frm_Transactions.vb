Imports System.Data.Odbc

Public Class Frm_Transactions

    Private Sub Frm_Transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub loaddata()
        sql = "select TransactionID,RFC_No,Withdrawal,Deposit from transaction where RFC_No='" & txt_rfcno.Text & "' order by TransactionID desc"
        dml = New OdbcCommand(sql, conn)
        da.SelectCommand = dml
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView_balance.DataSource = bs
        da.Update(dt)
        DataGridView_balance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btn_check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_check.Click
        'sql = "select TransactionID,RFC_No,Withdrawal,Deposit from transaction where RFC_No='" & txt_rfcno.Text & "' order by TransactionID desc"
        'dml = New OdbcCommand(sql, conn)
        'da.SelectCommand = dml
        'da.Fill(dt)
        'bs.DataSource = dt
        'DataGridView_balance.DataSource = bs
        'da.Update(dt)
        'DataGridView_balance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        loaddata()


    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        DataGridView_balance.DataSource = Nothing
        DataGridView_balance.Refresh()
        dt.Clear()
        txt_rfcno.Clear()

    End Sub
End Class