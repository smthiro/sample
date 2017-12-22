Public Class withdrawal_form_02

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mibunsho_id As String = mibun_id.Text
        For i = 0 To 10
            If main_form.mibun_id(i) = mibunsho_id Or mibun_syubetsu.Text = main_form.mibun_syubetsu(i) Or shimei.Text = main_form.shimei(i) Then
                Dim str As String
                str = "会員番号:" & main_form.kaiin_id(i) & vbCrLf & "---" & vbCrLf & _
            "身分証番号:" & main_form.mibun_id(i) & vbCrLf & "身分証種別:" & main_form.mibun_syubetsu(i) & vbCrLf & _
            "氏名:" & main_form.shimei(i) & vbCrLf & "性別:" & main_form.gender(i) & vbCrLf & "生年月日:" & main_form.birthday(i) & _
             vbCrLf & "電話番号:" & main_form.tel(i) & vbCrLf & "郵便番号:" & main_form.zip_code(i) & vbCrLf & _
            "住所:" & main_form.address(i) & vbCrLf & "---" & vbCrLf & "以上の情報を解約してよろしいですか？"
                If MessageBox.Show(str, "会員情報確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    str = "退会処理を行いました."
                    MessageBox.Show(str, "退会終了", MessageBoxButtons.OK)
                    Me.Close()
                    main_form.Show()
                    Return
                Else
                    Return
                End If

               
            End If
        Next
        Me.Close()
        main_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        withdrawal_form_main.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mibun_syubetsu.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles shimei.TextChanged

    End Sub
End Class