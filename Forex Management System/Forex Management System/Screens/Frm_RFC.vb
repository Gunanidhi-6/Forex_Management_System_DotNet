Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class Frm_rfc

    Dim gender As String

    Private Sub Frm_rfc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()
        txt_parent.Enabled = False
        Combo_proof.Enabled = False
        Txt_IdNo.Enabled = False
        Rb_Father.Enabled = False
        Rb_Guardian.Enabled = False
        Rb_Mother.Enabled = False
        Dtp_doi.Format = DateTimePickerFormat.Custom
        Dtp_doi.CustomFormat = "yyyy-MM-dd"
        Dtp_dob.Format = DateTimePickerFormat.Custom
        Dtp_dob.CustomFormat = "yyyy-MM-dd"
        Dtp_validupto.Format = DateTimePickerFormat.Custom
        Dtp_validupto.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub btn_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click

        If (Txt_age.Text < 18) Then
            sql = "insert into RFC_Creation(RFC_No,FirstName,LastName,BankName,PassportNo,IssueDate,Validupto,DOB,age,Currency,Email,MobileNo,occupation,PAN,Address,ParentName,Relationship,Proof,IdNo) values('" & Txt_RFCNo.Text & "','" & Txt_Fname.Text & "','" & Txt_Lname.Text & "','" & Combo_Bname.Text & "','" & Txt_Passport.Text & "','" & Dtp_doi.Text & "','" & Dtp_validupto.Text & "','" & Dtp_dob.Text & "','" & Txt_age.Text & "','" & Combo_currency.Text & "','" & Txt_email.Text & "','" & Txt_mobno.Text & "','" & Txt_occupation.Text & "','" & Txt_Pno.Text & "','" & Rtxt_address.Text & "','" & txt_parent.Text & "','" & gender & "','" & Combo_proof.Text & "','" & Txt_IdNo.Text & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data saved successfully")

            Txt_age.Clear()
            Txt_email.Clear()
            Txt_Fname.Clear()
            Txt_IdNo.Clear()
            Txt_Lname.Clear()
            Txt_mobno.Clear()
            Txt_occupation.Clear()
            txt_parent.Clear()
            Txt_Passport.Clear()
            Txt_Pno.Clear()
            Txt_RFCNo.Clear()
            txt_parent.Clear()
            Rb_Father.Text = ""
            Rb_Mother.Text = ""
            Rb_Guardian.Text = ""
            Rtxt_address.Clear()
            Combo_Bname.Text = ""
            Combo_currency.Text = ""
            Combo_proof.Text = ""

        Else
            sql = "insert into RFC_Creation(RFC_No,FirstName,LastName,BankName,PassportNo,IssueDate,Validupto,DOB,age,Currency,Email,MobileNo,occupation,PAN,Address) values('" & Txt_RFCNo.Text & "','" & Txt_Fname.Text & "','" & Txt_Lname.Text & "','" & Combo_Bname.Text & "','" & Txt_Passport.Text & "','" & Dtp_doi.Text & "','" & Dtp_validupto.Text & "','" & Dtp_dob.Text & "','" & Txt_age.Text & "','" & Combo_currency.Text & "','" & Txt_email.Text & "','" & Txt_mobno.Text & "','" & Txt_occupation.Text & "','" & Txt_Pno.Text & "','" & Rtxt_address.Text & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data saved successfully")
            Txt_age.Clear()
            Txt_email.Clear()
            Txt_Fname.Clear()
            Txt_Lname.Clear()
            Txt_mobno.Clear()
            Txt_occupation.Clear()
            Txt_Passport.Clear()
            Txt_Pno.Clear()
            Txt_RFCNo.Clear()
            Rtxt_address.Clear()
            Combo_Bname.Text = ""
            Combo_currency.Text = ""
            txt_parent.Enabled = False
            Txt_IdNo.Enabled = False
            Combo_proof.Enabled = False
            Rb_Father.Enabled = False
            Rb_Guardian.Enabled = False
            Rb_Mother.Enabled = False


        End If
    End Sub


    Private Sub Dtp_dob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_dob.ValueChanged
        Dim today, dob, age As Integer
        today = Date.Today.Year
        dob = Dtp_dob.Value.Year
        age = today - dob
        Txt_age.Text = age
    End Sub

    Private Sub Txt_age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_age.TextChanged
        Dim age As String = "18"

        If (Txt_age.Text < age) Then
            txt_parent.Enabled = True
            Combo_proof.Enabled = True
            Txt_IdNo.Enabled = True
            Rb_Father.Enabled = True
            Rb_Mother.Enabled = True
            Rb_Guardian.Enabled = True

        Else
            txt_parent.Enabled = False
            Combo_proof.Enabled = False
            Txt_IdNo.Enabled = False
            Rb_Father.Enabled = False
            Rb_Mother.Enabled = False
            Rb_Guardian.Enabled = False

        End If
    End Sub

    

    Private Sub Combo_proof_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_proof.SelectedIndexChanged
        If (Combo_proof.SelectedIndex = 0) Then
            Lbl_IdNo.Text = "AADHAR No"
        Else
            Lbl_IdNo.Text = "PAN No"
        End If
    End Sub

    
    Private Sub Txt_Fname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Fname.KeyPress
        characteronly(e)

    End Sub

    Private Sub Txt_Lname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Lname.KeyPress
        characteronly(e)

    End Sub

    Private Sub Txt_mobno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_mobno.KeyPress
        numberonly(e)
    End Sub

   
    Private Sub Txt_occupation_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_occupation.KeyPress
        characteronly(e)

    End Sub

    Private Sub txt_parent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_parent.KeyPress
        characteronly(e)
    End Sub

   
    Private Sub Rb_Father_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_Father.CheckedChanged
        gender = "Father"
    End Sub

    Private Sub Rb_Mother_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_Mother.CheckedChanged
        gender = "Mother"
    End Sub

    Private Sub Rb_Guardian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_Guardian.CheckedChanged
        gender = "Guardian"
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Txt_age.Clear()
        Txt_email.Clear()
        Txt_Fname.Clear()
        Txt_IdNo.Clear()
        Txt_Lname.Clear()
        Txt_mobno.Clear()
        Txt_occupation.Clear()
        txt_parent.Clear()
        Txt_Passport.Clear()
        Txt_Pno.Clear()
        Txt_RFCNo.Clear()
        txt_parent.Clear()
        Rb_Father.Text = ""
        Rb_Mother.Text = ""
        Rb_Guardian.Text = ""

    End Sub

    Private Sub Txt_email_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_email.Validated
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(Txt_email.Text.Trim)
        If Not isvalid Then
            MsgBox("Enter valid email address eg. abc@gmail.com")
        End If
    End Sub
End Class
