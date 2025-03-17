Imports System.Data.Odbc

Public Class Frm_acceptCurrency

    Private Sub Frm_AcceptCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        Txt_Dtype.Text = "Normal Deposit"
        sql = "select * from rfc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim rfc As Long

        While dr.Read
            rfc = dr.GetValue(0)
            Combo_RFC.Items.Add(rfc)

        End While
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Frm_Curconverter.TopLevel = False
        Me.Controls.Add(Frm_Curconverter)
        Frm_Curconverter.Dock = DockStyle.Fill
        Frm_Curconverter.BringToFront()
        Frm_Curconverter.Show()
    End Sub

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()

    End Sub

  

    Private Sub btn_getAccHolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_getAccHolder.Click
        If (Combo_RFC.Text = "") Then
            MsgBox("Kindly enter Rfc account number")
        End If
        sql = "select * from RFC_Creation WHERE RFC_No='" & Combo_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_fname.Text = dr.GetValue(1)
            Txt_lname.Text = dr.GetValue(2)
            txt_bname.Text = dr.GetValue(3)
            txt_passport.Text = dr.GetValue(4)
            Txt_doi.Text = dr.GetValue(5)
            txt_valid.Text = dr.GetValue(6)
            txt_dob.Text = dr.GetValue(7)
            txt_currency.Text = dr.GetValue(9)
        End If
        Call conn1()

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Combo_RFC.Text = ""
        txt_bname.Clear()
        txt_currency.Clear()
        txt_dob.Clear()
        Txt_doi.Clear()
        txt_fname.Clear()
        Txt_lname.Clear()
        txt_passport.Clear()
        txt_valid.Clear()
        txt_amt.Clear()


    End Sub

   
    Private Sub btn_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deposit.Click
        Dim b As String
        Dim b1 As Double
        Dim b2 As Double

        Call conn1()
        b = "select count(*) from transaction where RFC_NO='" & Combo_RFC.Text & "'"
        dml = New OdbcCommand(b, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            b2 = dr.GetValue(0)
        End If
       

        If b2 = 0 Then
            b1 = b1 + txt_amt.Text
            b1.ToString()
            sql = "insert into transaction(RFC_No,TransactionType,Deposit,Balance) values('" & Combo_RFC.Text & "','" & Txt_Dtype.Text & "','" & txt_amt.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("First Deposit done successfully")
        Else
            b = "select * from transaction where RFC_No='" & Combo_RFC.Text & "' order by TransactionID desc"
            dml = New OdbcCommand(b, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                b2 = dr.GetValue(7)
            End If
            b1 = b2 + Val(txt_amt.Text)
            b1.ToString()
            sql = "insert into transaction(RFC_No,TransactionType,Deposit,Balance) values('" & Combo_RFC.Text & "','" & Txt_Dtype.Text & "','" & txt_amt.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Amount Deposited Successfully")
            Call conn1()
        End If


    End Sub
End Class