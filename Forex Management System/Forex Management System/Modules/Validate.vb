Module Validate

        Public allSet As Boolean
        '
    'This will check for empty textboxes 
        Function IsEmpty(ByVal portion As Control) As Boolean
            Dim ctrl As New Control
            'Focus TextBox
            Dim text As New TextBox
            For Each ctrl In portion.Controls.OfType(Of TextBox)()
            text = TryCast(ctrl, TextBox)
                If text.Text = "" Then
                    text.Focus()
                text.BackColor = Color.Red
                    allSet = True
                Else
                    text.BackColor = Color.White
                    allSet = False
                End If
            Next
            For Each ctrl In portion.Controls.OfType(Of ComboBox)()
                'Focus Combobox
                Dim combo As New ComboBox
                combo = TryCast(ctrl, ComboBox)
                If combo.Text = "-Select-" Or combo.Text = "" Then
                    combo.Focus()
                combo.BackColor = Color.Red
                    allSet = True
                    combo.Text = "-Select-"
                Else
                    combo.BackColor = Color.White
                    allSet = False
                End If

            Next
            Return allSet
        End Function

    End Module
