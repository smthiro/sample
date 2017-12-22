Public Class vtr_registration
    Public id As String
    Public genre_code As String
    Public title_code As Integer = 1

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        main_form.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If genre_label.Text = "アクション" Then
            genre_code = "01"
        ElseIf genre_label.Text = "アニメ" Then
            genre_code = "02"
        ElseIf genre_label.Text = "SF" Then
            genre_code = "03"
        ElseIf genre_label.Text = "戦争" Then
            genre_code = "04"
        ElseIf genre_label.Text = "テレビドラマ" Then
            genre_code = "05"
        ElseIf genre_label.Text = "名作" Then
            genre_code = "06"
        ElseIf genre_label.Text = "ラブロマンス" Then
            genre_code = "07"
        ElseIf genre_label.Text = "ラブストーリー" Then
            genre_code = "08"
        ElseIf genre_label.Text = "ホラー" Then
            genre_code = "09"
        ElseIf genre_label.Text = "アクション(R)" Then
            genre_code = "21"
        ElseIf genre_label.Text = "戦争(R)" Then
            genre_code = "22"
        ElseIf genre_label.Text = "ホラー(R)" Then
            genre_code = "23"
        ElseIf genre_label.Text = "その他" Then
            genre_code = "99"
        End If

        id = genre_code + title_code.ToString("D2")
        DataGridView1.Rows.Add(id, genre_label.Text, titele.Text, honsu_label.Text, nyuukabi_label.Text)
        titele.Text = Nothing
        nyuukabi_label.Text = Nothing
        honsu_label.Text = Nothing
        title_code += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
        Dim str As String
        str = "新規タイトルを登録しました"
        MessageBox.Show(str, "商品登録終了", MessageBoxButtons.OK)
        Me.Close()
        main_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
    End Sub
End Class