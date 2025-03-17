Public Class Frm_convertFCtoRupee

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_currency.TextChanged

    End Sub

    Private Sub txt_amt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amt.TextChanged

    End Sub

    Private Sub linklabel_convert_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linklabel_convert.LinkClicked
        Frm_Curconverter.TopLevel = False
        Me.Controls.Add(Frm_Curconverter)
        Frm_Curconverter.Dock = DockStyle.Fill
        Frm_Curconverter.BringToFront()
        Frm_Curconverter.Show()
    End Sub

    Private Sub Frm_convertFCtoRupee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class