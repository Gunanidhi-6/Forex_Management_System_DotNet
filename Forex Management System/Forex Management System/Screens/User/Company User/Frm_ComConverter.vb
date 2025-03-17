Imports System.Data.Odbc

Public Class Frm_ComConverter

    Private Sub btn_Creqcur_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Creqcur_Close.Click
        Me.Dispose()
    End Sub

    Private Sub btn_Creqcur_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_CompanyUser.Show()
    End Sub

    

    Private Sub LinkLabel_click_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Frm_Curconverter.TopLevel = False
        Me.Controls.Add(Frm_Curconverter)
        Frm_Curconverter.Dock = DockStyle.Fill
        Frm_Curconverter.BringToFront()
        Frm_Curconverter.Show()
    End Sub


    Private Sub Frm_ComConverter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        sql = "select * from eefc_creation"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim eefc As Long

        While dr.Read
            eefc = dr.GetValue(0)
            combox_EEFC.Items.Add(eefc)

        End While
    End Sub

    Private Sub btn_retrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_retrieve.Click
        If (combox_EEFC.Text = "") Then
            MsgBox("Kindly enter EEfc account number")
        End If
        sql = "select * from EEFC_Creation WHERE EEFC_No='" & combox_EEFC.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            txt_currency.Text = dr.GetValue(8)
            Txt_Cname.Text = dr.GetValue(1)
            Txt_Bname.Text = dr.GetValue(3)
            Txt_Toc.Text = dr.GetValue(2)

        End If
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
        Dim type As String = "ConversionDepositC"

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
        b = "select count(*) from ctransaction where EEFC_NO='" & combox_EEFC.Text & "'"
        dml = New OdbcCommand(b, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            b2 = dr.GetValue(0)
        End If


        If b2 = 0 Then
            b1 = b1 + txt_currencyconv.Text
            b1.ToString()
            sql = "insert into ctransaction(EEFC_No,TransactionType,RAmount,ConvertedAmt,Deposit,Balance) values('" & combox_EEFC.Text & "','" & type & "','" & txt_Amt.Text & "','" & txt_currencyconv.Text & "','" & txt_currencyconv.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("First Deposit done successfully")
        Else
            b = "select * from ctransaction where EEFC_No='" & combox_EEFC.Text & "' order by TID desc"
            dml = New OdbcCommand(b, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                b2 = dr.GetValue(7)
            End If
            b1 = b2 + Val(txt_currencyconv.Text)
            b1.ToString()
            sql = "insert into ctransaction(EEFC_No,TransactionType,RAmount,ConvertedAmt,Deposit,Balance) values('" & combox_EEFC.Text & "','" & type & "','" & txt_Amt.Text & "','" & txt_currencyconv.Text & "','" & txt_currencyconv.Text & "','" & b1 & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Amount Deposited Successfully")
            Call conn1()
        End If
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        combox_EEFC.Text = ""
        txt_Amt.Clear()
        Txt_Bname.Clear()
        txt_currency.Clear()
        txt_currencyconv.Clear()
        Txt_Toc.Clear()
        Txt_Cname.Clear()

    End Sub
End Class