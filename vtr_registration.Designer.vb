<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vtr_registration
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titele = New System.Windows.Forms.TextBox()
        Me.genre_label = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.honsu_label = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nyuukabi_label = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.video_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.honsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nyukabi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "タイトル"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ジャンル"
        '
        'titele
        '
        Me.titele.Location = New System.Drawing.Point(61, 10)
        Me.titele.Name = "titele"
        Me.titele.Size = New System.Drawing.Size(434, 19)
        Me.titele.TabIndex = 2
        '
        'genre_label
        '
        Me.genre_label.FormattingEnabled = True
        Me.genre_label.Items.AddRange(New Object() {"アクション", "アニメ", "SF", "戦争", "テレビドラマ", "名作", "ラブロマンス", "ラブストーリー", "ホラー", "アクション(R)", "戦争(R)", "ホラー(R)", "その他"})
        Me.genre_label.Location = New System.Drawing.Point(61, 39)
        Me.genre_label.Name = "genre_label"
        Me.genre_label.Size = New System.Drawing.Size(121, 20)
        Me.genre_label.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "本数"
        '
        'honsu_label
        '
        Me.honsu_label.Location = New System.Drawing.Point(249, 38)
        Me.honsu_label.Name = "honsu_label"
        Me.honsu_label.Size = New System.Drawing.Size(42, 19)
        Me.honsu_label.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "入荷日"
        '
        'nyuukabi_label
        '
        Me.nyuukabi_label.Location = New System.Drawing.Point(376, 38)
        Me.nyuukabi_label.Name = "nyuukabi_label"
        Me.nyuukabi_label.Size = New System.Drawing.Size(119, 19)
        Me.nyuukabi_label.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.video_id, Me.genre, Me.title, Me.honsu, Me.nyukabi})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(589, 131)
        Me.DataGridView1.TabIndex = 10
        '
        'video_id
        '
        Me.video_id.HeaderText = "ビデオID"
        Me.video_id.Name = "video_id"
        '
        'genre
        '
        Me.genre.HeaderText = "ジャンル"
        Me.genre.Name = "genre"
        '
        'title
        '
        Me.title.HeaderText = "タイトル"
        Me.title.Name = "title"
        Me.title.Width = 200
        '
        'honsu
        '
        Me.honsu.HeaderText = "本数"
        Me.honsu.Name = "honsu"
        Me.honsu.Width = 60
        '
        'nyukabi
        '
        Me.nyukabi.HeaderText = "入荷日"
        Me.nyukabi.Name = "nyukabi"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(526, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "削除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(445, 303)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "登録"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(526, 303)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "キャンセル"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'vtr_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 338)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nyuukabi_label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.honsu_label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.genre_label)
        Me.Controls.Add(Me.titele)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "vtr_registration"
        Me.Text = "商品登録"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents titele As System.Windows.Forms.TextBox
    Friend WithEvents genre_label As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents honsu_label As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nyuukabi_label As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents video_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents honsu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nyukabi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
