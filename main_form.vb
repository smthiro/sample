Public Class main_form
    Public Sub kaiin_syokika()

        kaiin_id(j) = 123456
        mibun_id(j) = 234567
        mibun_syubetsu(j) = "免許証"
        shimei(j) = "山田太郎"
        gender(j) = "男"
        birthday(j) = "2001/1/23"
        tel(j) = "080-1234-7789"
        zip_code(j) = "680-1357"
        address(j) = "神奈川県厚木市"
        j = j + 1
    End Sub

    Public kaiin_id(10) As Integer
    Public mibun_id(10) As String
    Public mibun_syubetsu(10) As String
    Public shimei(10) As String
    Public gender(10) As String
    Public birthday(10) As Date
    Public tel(10) As String
    Public zip_code(10) As String
    Public address(10) As String
    Public j As Integer = 0
    Public Class kashidashi
        Public video_code(10) As String
        Public kaiin_id(10) As String
        '貸出期間が01の時当日,02の時2泊3日,03の時6泊7日,11の時延滞金,12の時会員登録
        Public kikan(10) As String
        Public video_title(10) As String
        Public seigen(10) As String
        Public henkyaku_day(10) As DateTime
        Public Sub syokika()
            video_code(0) = "010101"
            kaiin_id(0) = "123456"
            henkyaku_day(0) = CDate("2017/12/1")
            kikan(0) = "2"
            video_title(0) = "○○○○"
            video_code(1) = "020201"
            kaiin_id(1) = "12345"
            henkyaku_day(1) = CDate("2017/12/20")
            kikan(1) = "2"
            video_title(1) = "✕✕✕✕"
            video_code(2) = "210301"
            kaiin_id(2) = "12345"
            kikan(2) = "2"
            video_title(2) = "△△△△"
            video_code(3) = "220301"
            video_title(3) = "○✕○✕"
            video_code(4) = "230401"
            video_title(4) = "△○△○"

        End Sub

    End Class
    Public Sub set_record(j As Integer, id As String, syubetsu As String, name As String, seibetsu As String, my_birthday As Date, phone_number As String, zip As String, jusyo As String)
        kaiin_id(j) = kaiin_id(j - 1) + 1
        mibun_id(j) = id
        mibun_syubetsu(j) = syubetsu
        shimei(j) = name
        gender(j) = seibetsu
        birthday(j) = my_birthday
        tel(j) = phone_number
        zip_code(j) = zip
        address(j) = jusyo
        j = j + 1
    End Sub
    Public Sub delete_record(id)
        For i = 0 To 10
            If id = kaiin_id Then
                kaiin_id(j) = Nothing
                mibun_id(j) = Nothing
                mibun_syubetsu(j) = Nothing
                shimei(j) = Nothing
                gender(j) = Nothing
                birthday(j) = Nothing
                tel(j) = Nothing
                zip_code(j) = Nothing
                address(j) = Nothing
                j = j - 1
                Exit Sub
            End If
        Next
    End Sub
    Public kashidashi_data As New kashidashi

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_time.Text = Date.Now
        kaiin_syokika()
        kashidashi_data.syokika()






    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        membership_form.Show()
        Me.Hide()


    End Sub

    Private Sub datetime_Click(sender As Object, e As EventArgs) Handles date_time.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loanout_form_main.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loanout_form_02.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        vtr_registration.Show()
    End Sub
End Class
