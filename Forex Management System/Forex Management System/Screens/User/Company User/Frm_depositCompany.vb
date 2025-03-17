Imports System.Data.Odbc


Public Class Frm_depositCompany

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label_RFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_RFC.Click

    End Sub

    Private Sub btn_depositC_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_depositC_Close.Click
        Me.Dispose()
    End Sub

    Private Sub btn_DepositC_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Frm_depositCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub txt_ToC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToC.TextChanged

    End Sub

    Private Sub txt_Cname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Cname.TextChanged

    End Sub

    Private Sub txt_cId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_ComDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ComDetail.Click
        If (Combo_EEFC.Text = "") Then
            MsgBox("EEFC A/c No is required")
        End If

        sql = "select * from EEFC_Creation WHERE EEFC_No='" & Combo_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_Cname.Text = dr.GetValue(1)
            txt_ToC.Text = dr.GetValue(2)
            Txt_Bname.Text = dr.GetValue(3)
            Txt_currency.Text = dr.GetValue(8)
        End If
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Combo_EEFC.Text = ""
        txt_Cname.Clear()
        txt_ToC.Clear()
        Txt_Bname.Clear()
        Txt_currency.Clear()
        txt_Amt_depositC.Clear()

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub

    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        Dim b As String
        Dim b1 As Double
        Dim b2 As Double
        Dim type As String = "CDeposit"
        Call conn1()
        b = "select count(*) from ctransaction where EEFC_NO='" & Combo_EEFC.Text & "'"
        dml = New OdbcCommand(b, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            b2 = dr.GetValue(0)
        End If


        If b2 = 0 Then
            b1 = b1 + txt_Amt_depositC.Text
            b1.ToString()
            sql = "insert into ctransaction(EEFC_No,TransactionType,Deposit,Balance) values('" & Combo_EEFC.Text & "','" & type & "','" & txt_Amt_depositC.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("First Deposit done successfully")
        Else
            b = "select * from ctransaction where EEFC_No='" & Combo_EEFC.Text & "' order by TID desc"
            dml = New OdbcCommand(b, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                b2 = dr.GetValue(5)
            End If
            b1 = b2 + Val(txt_Amt_depositC.Text)
            b1.ToString()
            sql = "insert into ctransaction(EEFC_No,TransactionType,Deposit,Balance) values('" & Combo_EEFC.Text & "','" & type & "','" & txt_Amt_depositC.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Amount Deposited Successfully")
            Call conn1()
        End If
    End Sub
End Class