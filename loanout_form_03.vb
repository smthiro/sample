Public Class loanout_form_03
    '期限外
    'Public henkyaku As DateTime = CDate("2017/12/1")
    '期限内
    'Public henkyaku As DateTime = CDate("2017/12/20")

    Public NowDate As DateTime = DateTime.Now
    Public video_code(10) As String
    Public kaiin_id(10) As String
    Public henkyaku(10) As DateTime
    Public i As Integer
    Public index As Integer

    Private Sub loanout_form_03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        video_code(0) = "010101"
        kaiin_id(0) = "123456"
        henkyaku(0) = CDate("2017/12/17")
        video_code(1) = "210301"
        henkyaku(1) = CDate("2017/12/20")
        kaiin_id(1) = "123456"
        video_id.Text = "ビデオID:" & loanout_form_02.video_id
        For i = 0 To 10

            If loanout_form_02.video_id_text.Text = video_code(i) Then
                For j = 0 To 10
                    If kaiin_id(i) = main_form.kaiin_id(j) Then
                        kaiin_id_label.Text = kaiin_id(i)
                        name_label.Text = main_form.shimei(0)
                        henkyaku_label.Text = henkyaku(i).ToString("yyyy-MM-dd")
                        index = i
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        loanout_form_02.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles video_id.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Str As String
        'tourokubi.Text = NowDate.ToString("yyyy-MM-dd")
        If NowDate < henkyaku(index) Then
            Str = "返却処理を行います" & vbCrLf & "以下の内容でよろしいですか？" & vbCrLf & "---" & vbCrLf & "ビデオID:" & video_id.Text
            Dim result As DialogResult = MessageBox.Show(Str, "期限内返却", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Hide()
                Str = "返却完了" & vbCrLf & "---" & vbCrLf & "ビデオID:" & loanout_form_02.video_id_text.Text
                If MessageBox.Show(Str, "返却処理完了", MessageBoxButtons.OK) = Windows.Forms.DialogResult.OK Then
                    loanout_form_02.Close()
                    Me.Close()
                    main_form.Show()
                Else
                    Me.Show()
                End If
            Else
                Me.Show()
            End If
        Else

            Me.Hide()
            Str = "以下の内容を確認後,延滞料を徴収してください." & vbCrLf & "----" & vbCrLf & "返却予定日:" & henkyaku_label.Text & vbCrLf & "延滞料:300円"
            If MessageBox.Show(Str, "遅延返却", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Str = "返却完了" & vbCrLf & "---" & vbCrLf & "ビデオID:" & loanout_form_02.video_id_text.Text
                MessageBox.Show(Str, "返却処理完了", MessageBoxButtons.OK)
                Me.Close()
                loanout_form_02.Close()
                main_form.Show()
            Else
                Me.Show()
            End If
        End If

    End Sub

    Private Sub henkyaku_label_Click(sender As Object, e As EventArgs) Handles henkyaku_label.Click

    End Sub
End Class