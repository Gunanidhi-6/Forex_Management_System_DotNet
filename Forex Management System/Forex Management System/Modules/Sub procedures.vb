Module Sub_procedures

    'sub to validate numbers only
    Public Sub numberonly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc((e.KeyChar)) >= 48 And Asc((e.KeyChar)) <= 57 Or Asc((e.KeyChar)) = 8 Then

        Else
            MsgBox("only numbers allowed")
            e.Handled = True
        End If

    End Sub

    'sub to validate character only
    Public Sub characteronly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc((e.KeyChar)) >= 65 And Asc((e.KeyChar)) <= 90 Or Asc((e.KeyChar)) >= 97 And Asc((e.KeyChar)) <= 122 Or Asc((e.KeyChar)) = 8 Then
        Else
            MsgBox("this field accepts only character")
            e.Handled = True

        End If
    End Sub
End Module
