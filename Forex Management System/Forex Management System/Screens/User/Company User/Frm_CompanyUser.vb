Public Class Frm_CompanyUser
    Private currentForm As Form = Nothing
    Private Sub openChildForm(ByVal childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panel_companyuser.Controls.Add(childForm)
        panel_companyuser.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    
    Private Sub btn_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deposit.Click
        openChildForm(New Frm_depositCompany())
    End Sub

    Private Sub btn_withdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_withdrawal.Click
        openChildForm(New Frm_WithdrawCompany())
    End Sub

    Private Sub btn_balance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_balance.Click
        openChildForm(New Frm_TransactionsCompany())
    End Sub

    Private Sub btn_LoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LoC.Click
        openChildForm(New Frm_LoC())
    End Sub

    Private Sub btn_CapliStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CapliStatus.Click
        openChildForm(New Frm_CapplStatus())
    End Sub

    Private Sub btn_Creqcur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Creqcur.Click
        openChildForm(New Frm_ComConverter())
    End Sub

    Private Sub btn_Cimport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cimport.Click
        openChildForm(New Frm_importDetails())
    End Sub

    Private Sub btn_Cexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cexport.Click
        openChildForm(New Frm_exportDetails())
    End Sub
End Class