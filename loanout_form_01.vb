Public Class loanout_form_01
    Dim NowDate As DateTime = DateTime.Now
    Dim today As String = NowDate.ToString("yyyy-MM-dd")
    Dim birthday As DateTime
    Dim age As Integer
    Dim sum As Integer = 0
    Dim honsuu As Integer
    Dim error_message As String = Nothing

    Public Sub honsuu_sum()
        honsuu = 0
        If title_1.Text <> "-" Then
            honsuu += 1
        End If
        If title_2.Text <> "-" Then
            honsuu += 1
        End If
        If title_3.Text <> "-" Then
            honsuu += 1
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub loanout_form_01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        message_label.Text = Nothing
        kaiin_id_label.Text = loanout_form_main.member_id
        message_label.ForeColor = Color.Red
        Dim kaiin_id As String = loanout_form_main.kaiin_id.Text
        Dim now As Date = Date.Now
        Dim today As String = String.Format("{0:yyyyMMdd}", now)
        ryokin_1.Text = "-"
        '年齡計算

        For i = 0 To 9
            If main_form.kaiin_id(i) = kaiin_id_label.Text Then
                name_label.Text = main_form.shimei(i)
                birthday = CDate(main_form.birthday(i))
                age = NowDate.Year - birthday.Year
                If NowDate.Month < birthday.Month And NowDate.Day < birthday.Day Then
                    age -= 1
                End If
            
            End If
            age_label.Text = age
        Next
        gokei.Text = sum
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles message.Paint

    End Sub

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim str As String
        str = "貸出処理完了しました."
        MessageBox.Show(str, "貸出処理終了", MessageBoxButtons.OK)
        main_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        loanout_form_main.Show()

    End Sub

    Private Sub video_id_1_TextChanged(sender As Object, e As EventArgs) Handles video_id_1.TextChanged
        '年齢制限
        If video_id_1.Text = Nothing Then
            title_1.Text = "-"
            seigen_1.Text = Nothing
            today_1.Text = Nothing
            kikan_1.Text = Nothing
            henkyaku_1.Text = Nothing
            message_label.Text = Nothing
            ryokin_1.Text = "0"
            honsuu_sum()
            honsu.Text = honsuu
            'gokei.Text = CInt(ryokin_1.Text) + CInt(ryokin_2.Text) + CInt(ryokin_3.Text)
            Return
        End If

        For j = 0 To 10
            If video_id_1.Text = main_form.kashidashi_data.video_code(j) Then
                title_1.Text = main_form.kashidashi_data.video_title(j)
                seigen_1.Text = main_form.kashidashi_data.seigen(j)
                today_1.Text = today
                If main_form.kashidashi_data.video_code(j).Substring(0, 2) = 21 Then
                    seigen_1.ForeColor = Color.Red
                    seigen_1.Text = "15禁"
                    If age < 15 Then
                        error_message = "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_1.Text
                        message_label.Text = error_message
                    End If
                ElseIf main_form.kashidashi_data.video_code(j).Substring(0, 2) = 22 Then
                    seigen_1.ForeColor = Color.Red
                    seigen_1.Text = "18禁"
                    If age < 18 Then
                        error_message = "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_1.Text
                        message_label.Text = error_message
                    End If
                ElseIf main_form.kashidashi_data.video_code(j).Substring(0, 2) = 23 Then
                    seigen_1.ForeColor = Color.Red
                    seigen_1.Text = "18禁"
                    If age < 18 Then
                        error_message = "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_1.Text
                        message_label.Text = error_message
                    End If
                Else
                    seigen_1.ForeColor = Color.Black
                    seigen_1.Text = "なし"
                End If
                If kikan_1.Text = "当日" Then
                    Dim ts As New TimeSpan(0, 0, 0)
                    henkyaku_1.Text = (NowDate + ts).ToString("yyyy-MM-dd")
                End If
            End If
        Next
        '本数計算
        honsuu_sum()
        honsu.Text = honsuu
    End Sub

    Private Sub seigen3_Click(sender As Object, e As EventArgs) Handles seigen_3.Click

    End Sub

    Private Sub kikan_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kikan_1.SelectedIndexChanged
        If kikan_1.Text = "当日" Then
            Dim ts As New TimeSpan(0, 0, 0, 0, 0)
            henkyaku_1.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_1.Text = 200
        ElseIf kikan_1.Text = "2泊3日" Then
            Dim ts As New TimeSpan(3, 0, 0, 0, 0)
            henkyaku_1.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_1.Text = 300
        ElseIf kikan_1.Text = "6泊7日" Then
            Dim ts As New TimeSpan(7, 0, 0, 0, 0)
            henkyaku_1.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_1.Text = 400
        End If

        gokei.Text = CInt(ryokin_1.Text) + CInt(ryokin_2.Text) + CInt(ryokin_3.Text)
    End Sub


    Private Sub mesasge_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub video_id_2_TextChanged(sender As Object, e As EventArgs) Handles video_id_2.TextChanged
        '年齢制限
        If video_id_2.Text = Nothing Then
            title_2.Text = "-"
            seigen_2.Text = Nothing
            today_2.Text = Nothing
            kikan_2.Text = Nothing
            henkyaku_2.Text = Nothing
            message_label.Text = Nothing
            ryokin_2.Text = "0"
            honsuu_sum()
            honsu.Text = honsuu
            'gokei.Text = CInt(ryokin_1.Text) + CInt(ryokin_2.Text) + CInt(ryokin_3.Text)
            Return
        End If

        For j = 0 To 10
            If video_id_2.Text = main_form.kashidashi_data.video_code(j) Then
                title_2.Text = main_form.kashidashi_data.video_title(j)
                seigen_2.Text = main_form.kashidashi_data.seigen(j)
                today_2.Text = today
                If main_form.kashidashi_data.video_code(j).Substring(0, 2) = 21 Then
                    seigen_2.ForeColor = Color.Red
                    seigen_2.Text = "15禁"
                    If age < 15 Then
                        error_message = vbCrLf & "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_2.Text
                        'message_label.Text = Nothing
                        message_label.Text = error_message
                    End If
                ElseIf main_form.kashidashi_data.video_code(j).Substring(0, 2) = 22 Then
                    seigen_2.ForeColor = Color.Red
                    seigen_2.Text = "18禁"
                    If age < 18 Then
                        error_message = vbCrLf & "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_2.Text
                        'message_label.Text = Nothing
                        message_label.Text = error_message
                    End If
                ElseIf main_form.kashidashi_data.video_code(j).Substring(0, 2) = 23 Then
                    seigen_2.ForeColor = Color.Red
                    seigen_2.Text = "18禁"
                    If age < 18 Then
                        error_message = vbCrLf & "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_2.Text
                        'message_label.Text = Nothing
                        message_label.Text = error_message
                    End If
                Else
                    seigen_2.ForeColor = Color.Black
                    seigen_2.Text = "なし"
                End If
                If kikan_2.Text = "当日" Then
                    Dim ts As New TimeSpan(0, 0, 0)
                    henkyaku_2.Text = (NowDate + ts).ToString("yyyy-MM-dd")
                End If
            End If
        Next
        '本数計算
        honsuu_sum()
        honsu.Text = honsuu
    End Sub

    Private Sub kikan_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kikan_2.SelectedIndexChanged
        If kikan_2.Text = "当日" Then
            Dim ts As New TimeSpan(0, 0, 0, 0, 0)
            henkyaku_2.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_2.Text = 200
        ElseIf kikan_2.Text = "2泊3日" Then
            Dim ts As New TimeSpan(3, 0, 0, 0, 0)
            henkyaku_2.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_2.Text = 300
        ElseIf kikan_2.Text = "6泊7日" Then
            Dim ts As New TimeSpan(7, 0, 0, 0, 0)
            henkyaku_2.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_2.Text = 400
        End If
        gokei.Text = CInt(ryokin_1.Text) + CInt(ryokin_2.Text) + CInt(ryokin_3.Text)
    End Sub

    Private Sub video_id_3_TextChanged(sender As Object, e As EventArgs) Handles video_id_3.TextChanged
        '年齢制限
        If video_id_3.Text = Nothing Then
            title_3.Text = "-"
            seigen_3.Text = Nothing
            today_3.Text = Nothing
            kikan_3.Text = Nothing
            henkyaku_3.Text = Nothing
            message_label.Text = Nothing
            ryokin_3.Text = "0"
            honsuu_sum()
            honsu.Text = honsuu
            'gokei.Text = CInt(ryokin_1.Text) + CInt(ryokin_2.Text) + CInt(ryokin_3.Text)
            Return
        End If

        For j = 0 To 10
            If video_id_3.Text = main_form.kashidashi_data.video_code(j) Then
                title_3.Text = main_form.kashidashi_data.video_title(j)
                seigen_3.Text = main_form.kashidashi_data.seigen(j)
                today_3.Text = today
                If main_form.kashidashi_data.video_code(j).Substring(0, 2) = 21 Then
                    seigen_3.ForeColor = Color.Red
                    seigen_3.Text = "15禁"
                    If age < 15 Then
                        error_message = vbCrLf & "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_3.Text
                        'message_label = Nothing
                        message_label.Text = error_message
                    End If
                ElseIf main_form.kashidashi_data.video_code(j).Substring(0, 2) = 22 Then
                    seigen_3.ForeColor = Color.Red
                    seigen_3.Text = "18禁"
                    If age < 18 Then
                        error_message = vbCrLf & "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_3.Text
                        'message_label = Nothing
                        message_label.Text = error_message
                    End If
                ElseIf main_form.kashidashi_data.video_code(j).Substring(0, 2) = 23 Then
                    seigen_3.ForeColor = Color.Red
                    seigen_3.Text = "18禁"
                    If age < 18 Then
                        error_message = vbCrLf & "年齢制限のため,レンタルできません" & vbCrLf & "ビデオID:" & video_id_3.Text
                        'message_label.Text = Nothing
                        message_label.Text = error_message
                    End If
                Else
                    seigen_3.ForeColor = Color.Black
                    seigen_3.Text = "なし"
                End If
                If kikan_2.Text = "当日" Then
                    Dim ts As New TimeSpan(0, 0, 0)
                    henkyaku_2.Text = (NowDate + ts).ToString("yyyy-MM-dd")
                End If
            End If
        Next
        '本数計算
        honsuu_sum()
        honsu.Text = honsuu

    End Sub

    Private Sub kikan_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kikan_3.SelectedIndexChanged
        If kikan_3.Text = "当日" Then
            Dim ts As New TimeSpan(0, 0, 0, 0, 0)
            henkyaku_3.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_3.Text = 200
        ElseIf kikan_3.Text = "2泊3日" Then
            Dim ts As New TimeSpan(3, 0, 0, 0, 0)
            henkyaku_3.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_3.Text = 300
        ElseIf kikan_3.Text = "6泊7日" Then
            Dim ts As New TimeSpan(7, 0, 0, 0, 0)
            henkyaku_3.Text = (NowDate + ts).ToString("yyyy-MM-dd")
            ryokin_3.Text = 400
        End If
        gokei.Text = CInt(ryokin_1.Text) + CInt(ryokin_2.Text) + CInt(ryokin_3.Text)

    End Sub
End Class