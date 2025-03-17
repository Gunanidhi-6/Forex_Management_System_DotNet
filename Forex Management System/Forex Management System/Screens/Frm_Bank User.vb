Imports System.Data.Odbc

Public Class Frm_BankUser

    Private currentForm As Form = Nothing
    Private Sub openChildForm(ByVal childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.Controls.Add(childForm)
        Me.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Frm_Curconverter.TopLevel = False
        Me.Controls.Add(Frm_Curconverter)
        Frm_Curconverter.Dock = DockStyle.Fill
        Frm_Curconverter.BringToFront()
        Frm_Curconverter.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Frm_BankUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conn1()

    End Sub


    Private Sub btn_RFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RFC.Click
        openChildForm(New Frm_rfc())
    End Sub

    Private Sub btn_EEFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EEFC.Click
        openChildForm(New Frm_EEFC())
    End Sub

    Private Sub btn_RFCManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RFCManage.Click
        openChildForm(New Frm_Nusermanage())
    End Sub

    Private Sub btn_EEFCManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EEFCManage.Click
        openChildForm(New Frm_EEFCManage())
    End Sub

    Private Sub btn_RFCTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RFCTrans.Click
        openChildForm(New Frm_Transactions())
    End Sub



    Private Sub btn_EEFCTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EEFCTrans.Click
        openChildForm(New Frm_TransactionsCompany())

    End Sub

    Private Sub GroupBoxService_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBoxService.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class