Public Class Frm_startscreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim form1 As New Frm_Register
        form1.Show()
        Me.Dispose()
    End Sub
End Class