Public Class loanout_form_02
    Public video_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        video_id = video_id_text.Text
        loanout_form_03.Show()
        Me.Hide()

    End Sub

    Private Sub loanout_form_02_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        main_form.Show()
        Me.Hide()

    End Sub
End Class