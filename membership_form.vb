Public Class membership_form

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main_form.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        membership_registration.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        withdrawal_form_main.Show()
        Me.Hide()

    End Sub

    Private Sub membership_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class