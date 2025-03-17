Imports System.Data.Odbc

Public Class Frm_WithdrawCompany

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_withdrawl.CellContentClick

    End Sub

    Private Sub btn_Cwithdraw_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cwithdraw_close.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Frm_WithdrawCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        txt_Wamt.Enabled = False
        btn_Withdraw.Enabled = False

        sql = "select * from eefc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim eefc As Long

        While dr.Read
            eefc = dr.GetValue(0)
            Combo_EEFC.Items.Add(eefc)

        End While
    End Sub

    Private Sub btn_CBalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CBalc.Click
        If (Combo_EEFC.Text <> "") Then
            txt_Wamt.Enabled = True
            btn_Withdraw.Enabled = True
        End If
        sql = "select EEFC_No,MAX(Balance) from ctransaction where EEFC_No='" & Combo_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        da.SelectCommand = dml
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView_withdrawl.DataSource = bs
        da.Update(dt)
        DataGridView_withdrawl.AllowUserToAddRows = False
    End Sub

    Private Sub btn_Withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Withdraw.Click
        Dim balc As Double
        Dim b As Double
        Dim type As String
        type = "CWithdrawal"
        sql = "select MAX(Balance) from ctransaction where EEFC_No='" & Combo_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            balc = dr.GetValue(0)

        End If
        If txt_Wamt.Text > balc Then
            MsgBox("Insufficient Balance")
            txt_Wamt.Clear()

        Else
            b = balc - txt_Wamt.Text
            b.ToString()
            sql = "insert into ctransaction(EEFC_No,TransactionType,Withdrawal,Balance) values('" & Combo_EEFC.Text & "','" & type & "','" & txt_Wamt.Text & "','" & b & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Amount Withdrawn Successfully")
        End If

        Call conn1()
    End Sub

    Private Sub Label_Cwithdraw_Click(sender As System.Object, e As System.EventArgs) Handles Label_Cwithdraw.Click

    End Sub
End Class