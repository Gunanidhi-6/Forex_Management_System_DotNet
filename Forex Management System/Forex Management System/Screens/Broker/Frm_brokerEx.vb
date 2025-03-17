Public Class Frm_brokerEx

    Private currentForm As Form = Nothing
    Private Sub openChildForm(ByVal childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panel_brokerex.Controls.Add(childForm)
        panel_brokerex.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btn_deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deposit.Click
        openChildForm(New Frm_acceptCurrency())
    End Sub

    Private Sub btn_convertRupee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_convertRupee.Click
        openChildForm(New Frm_convertFCtoRupee())
    End Sub

    Private Sub btn_convertFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_convertFC.Click
        openChildForm(New Frm_convertFC())
    End Sub

    Private Sub btn_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_import.Click
        openChildForm(New Frm_importCredit())
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        openChildForm(New Frm_exportBroker())
    End Sub

    Private Sub btn_tvcheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tvcheque.Click
        openChildForm(New frm_tc())
    End Sub
End Class