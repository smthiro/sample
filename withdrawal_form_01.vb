Public Class withdrawal_form_01

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str0 As String = kaiin_id.Text
        For i = 0 To 10
            If main_form.kaiin_id(i) = str0 Then
                Dim str As String
                str = "会員番号:" & main_form.kaiin_id(i) & vbCrLf & "---" & vbCrLf & _
            "身分証番号:" & main_form.mibun_id(i) & vbCrLf & "身分証種別:" & main_form.mibun_syubetsu(i) & vbCrLf & _
            "氏名:" & main_form.shimei(i) & vbCrLf & "性別:" & main_form.gender(i) & vbCrLf & "生年月日:" & main_form.birthday(i) & _
             vbCrLf & "電話番号:" & main_form.tel(i) & vbCrLf & "郵便番号:" & main_form.zip_code(i) & vbCrLf & _
            "住所:" & main_form.address(i) & vbCrLf & "---" & vbCrLf & "以上の情報を解約してよろしいですか？"
                If MessageBox.Show(str, "会員情報確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Me.Hide()
                    str = "退会処理を行いました."
                    MessageBox.Show(str, "退会終了", MessageBoxButtons.OK)
                    main_form.Show()
                    Return
                End If
            Else



            End If
        Next
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        withdrawal_form_main.Show()

    End Sub

    Private Sub withdrawal_form_01_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class