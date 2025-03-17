Imports System.Data.Odbc

Public Class Frm_Curconverter

    Private Sub Frm_Curconverter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        sql = "select * from rfc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim rfc As Long

        While dr.Read
            rfc = dr.GetValue(0)
            combox_RFC.Items.Add(rfc)

        End While
    End Sub

    Private Sub btn_retrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_retrieve.Click
        If (combox_RFC.Text = "") Then
            MsgBox("Kindly enter Rfc account number")
        End If
        sql = "select * from RFC_Creation WHERE RFC_No='" & combox_RFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_currency.Text = dr.GetValue(9)
            Txt_Fname.Text = dr.GetValue(1)
            Txt_Lname.Text = dr.GetValue(2)
        End If
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()

    End Sub

    Private Sub btn_convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_convert.Click
        Dim usrate As Integer = 82
        Dim brrate As Integer = 98
        Dim yrate As Integer = 2
        Dim rnrate As Integer = 12
        Dim eurate As Integer = 88
        Dim convrtAmt As Long
        Dim us As String = "USD"
        Dim br As String = "POUND"
        Dim y As String = "YEN"
        Dim r As String = "RNB"
        Dim eu As String = "EURO"
        Dim type As String = "ConversionDeposit"

        If txt_currency.Text = us Then
            convrtAmt = Val(txt_Amt.Text) \ usrate
            txt_currencyconv.Text = convrtAmt
        ElseIf txt_currency.Text = br Then
            convrtAmt = Val(txt_Amt.Text) \ brrate
            txt_currencyconv.Text = convrtAmt
        ElseIf txt_currency.Text = y Then
            convrtAmt = Val(txt_Amt.Text) \ yrate
            txt_currencyconv.Text = convrtAmt
        ElseIf txt_currency.Text = r Then
            convrtAmt = Val(txt_Amt.Text) \ rnrate
            txt_currencyconv.Text = convrtAmt
        ElseIf txt_currency.Text = eu Then
            convrtAmt = Val(txt_Amt.Text) \ eurate
            txt_currencyconv.Text = convrtAmt
        End If

        Dim b As String
        Dim b1 As Double
        Dim b2 As Double

        Call conn1()
        b = "select count(*) from transaction where RFC_NO='" & combox_RFC.Text & "'"
        dml = New OdbcCommand(b, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            b2 = dr.GetValue(0)
        End If


        If b2 = 0 Then
            b1 = b1 + txt_currencyconv.Text
            b1.ToString()
            sql = "insert into transaction(RFC_No,TransactionType,RAmount,Converted_Amt,Deposit,Balance) values('" & combox_RFC.Text & "','" & type & "','" & txt_Amt.Text & "','" & txt_currencyconv.Text & "','" & txt_currencyconv.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("First Deposit done successfully")
        Else
            b = "select * from transaction where RFC_No='" & combox_RFC.Text & "' order by TransactionID desc"
            dml = New OdbcCommand(b, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                b2 = dr.GetValue(7)
            End If
            b1 = b2 + Val(txt_currencyconv.Text)
            b1.ToString()
            sql = "insert into transaction(RFC_No,TransactionType,RAmount,Converted_Amt,Deposit,Balance) values('" & combox_RFC.Text & "','" & type & "','" & txt_Amt.Text & "','" & txt_currencyconv.Text & "','" & txt_currencyconv.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Amount Deposited Successfully")
            Call conn1()
        End If

    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        txt_Amt.Clear()
        txt_currency.Clear()
        txt_currencyconv.Clear()
        combox_RFC.Text = ""
        Txt_Fname.Clear()
        Txt_Lname.Clear()

    End Sub
End Class