Imports System.Data.Odbc

Public Class Frm_withdrawal


    Private Sub Frm_withdrawal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
       
        txt_amt.Enabled = False
        btn_Withdraw.Enabled = False
        sql = "select * from rfc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim rfc As Long

        While dr.Read
            rfc = dr.GetValue(0)
            Combo_RFC.Items.Add(rfc)

        End While

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_NormalUser.Show()
    End Sub

    Private Sub btn_Cbalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cbalc.Click
        If (Combo_RFC.Text <> "") Then
            txt_amt.Enabled = True
            btn_Withdraw.Enabled = True
        End If
        sql = "select RFC_No,MAX(Balance) from transaction where RFC_No='" & Combo_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        da.SelectCommand = dml
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView_withdraw.DataSource = bs
        da.Update(dt)
        DataGridView_withdraw.AllowUserToAddRows = False

    End Sub

    Private Sub btn_Withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Withdraw.Click
        Dim balc As Double
        Dim b As Double
        Dim type As String
        type = "Withdraw"
        sql = "select MAX(Balance) from transaction where RFC_No='" & Combo_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            balc = dr.GetValue(0)

        End If
        If txt_amt.Text > balc Then
            MsgBox("Insufficient Balance")
            txt_amt.Clear()

        Else
            b = balc - txt_amt.Text
            b.ToString()
            sql = "insert into transaction(RFC_No,TransactionType,Withdrawal,Balance) values('" & Combo_RFC.Text & "','" & type & "','" & txt_amt.Text & "','" & b & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Amount Withdrawn Successfully")
        End If

        Call conn1()
    End Sub
End Class