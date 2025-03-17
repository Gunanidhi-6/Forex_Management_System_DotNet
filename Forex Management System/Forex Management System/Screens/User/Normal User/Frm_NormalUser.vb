Public Class Frm_NormalUser

    Private currentForm As Form = Nothing
    Private Sub openChildForm(ByVal childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel_normaluser.Controls.Add(childForm)
        Panel_normaluser.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btn_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deposit.Click
        openChildForm(New Frm_acceptCurrency())
    End Sub

    Private Sub btn_withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_withdrawal.Click
        openChildForm(New Frm_withdrawal())
    End Sub

    Private Sub btn_balance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_balance.Click
        openChildForm(New Frm_Transactions())
    End Sub

    Private Sub btn_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_import.Click
        openChildForm(New Frm_BankUser())
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        openChildForm(New Frm_applStatus())
    End Sub

    Private Sub btn_StudentLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StudentLoan.Click
        openChildForm(New Frm_StudLoan())
    End Sub

    Private Sub btn_exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub
End Class