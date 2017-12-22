Public Class loanout_form_main
    Public member_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        member_id = kaiin_id.Text
        'loanout_form_01.Show()
        'Me.Hide()

        For i = 0 To 9
            If main_form.kaiin_id(i) = member_id Then
                loanout_form_01.Show()
                Me.Hide()
                Return
            Else
                MessageBox.Show("エラー(会員番号が存在しません)", "エラー", MessageBoxButtons.OK)
                Return
            End If
        Next
    End Sub

    Private Sub loanout_form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        main_form.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles kaiin_id.TextChanged

    End Sub
End Class