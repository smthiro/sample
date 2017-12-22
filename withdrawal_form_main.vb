Public Class withdrawal_form_main

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        membership_form.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        withdrawal_form_01.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        withdrawal_form_02.Show()

    End Sub

    Private Sub withdrawal_form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class