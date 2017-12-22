Public Class membership_registration
   

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        membership_form.Show()
        Me.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles tourokubi.TextChanged

    End Sub

    Private Sub membership_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NowDate As DateTime = DateTime.Now
        tourokubi.Text = NowDate.ToString("yyyy-MM-dd")

        For i = 1917 To NowDate.Year
            year.Items.Add(i)
        Next
        For i = 1 To 12
            month.Items.Add(i)
        Next
        For i = 1 To 31
            day.Items.Add(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        Dim gender As String
        Dim mydate As String = CStr(year.Text & "/" & month.Text & "/" & day.Text)
        Dim mybirthday As Date = CDate(mydate)
        If RadioButton1.Checked = True Then
            gender = "男"
        ElseIf RadioButton2.Checked = True Then
            gender = "女"
        End If
        str = "登録日:" & tourokubi.Text & vbCrLf & "---" & vbCrLf & _
            "身分証番号:" & mibun_id.Text & vbCrLf & "身分証種別:" & mibunsho_syubetsu.Text & vbCrLf & _
            "氏名:" & shimei.Text & vbCrLf & "性別:" & gender & vbCrLf & "生年月日:" & year.Text & "年" & month.Text & "年" & _
            day.Text & "日" & vbCrLf & "電話番号:" & tel_number.Text & vbCrLf & "郵便番号:" & zip_code.Text & vbCrLf & _
            "住所:" & address.Text & vbCrLf & "---" & vbCrLf & "以上の情報で登録してよろしいですか？"
        Dim result As DialogResult = MessageBox.Show(str, "会員情報登録", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim kakunin As String
            main_form.set_record(main_form.j, mibun_id.Text, mibunsho_syubetsu.Text, shimei.Text, gender, mybirthday, tel_number.Text, zip_code.Text, address.Text)
            kakunin = "会員番号:123456" & vbCrLf & "会員を追加しました"
            MessageBox.Show(kakunin, "会員登録終了", MessageBoxButtons.OK)
            Me.Close()
            main_form.Show()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month.SelectedIndexChanged

    End Sub




End Class