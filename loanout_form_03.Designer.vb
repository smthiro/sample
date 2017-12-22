<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loanout_form_03
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
        Me.video_id = New System.Windows.Forms.GroupBox()
        Me.henkyaku_label = New System.Windows.Forms.Label()
        Me.name_label = New System.Windows.Forms.Label()
        Me.kaiin_id_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.video_id.SuspendLayout()
        Me.SuspendLayout()
        '
        'video_id
        '
        Me.video_id.Controls.Add(Me.henkyaku_label)
        Me.video_id.Controls.Add(Me.name_label)
        Me.video_id.Controls.Add(Me.kaiin_id_label)
        Me.video_id.Controls.Add(Me.Label3)
        Me.video_id.Controls.Add(Me.Label2)
        Me.video_id.Controls.Add(Me.Label1)
        Me.video_id.Location = New System.Drawing.Point(13, 13)
        Me.video_id.Name = "video_id"
        Me.video_id.Size = New System.Drawing.Size(259, 151)
        Me.video_id.TabIndex = 0
        Me.video_id.TabStop = False
        Me.video_id.Text = "ビデオID:123456"
        '
        'henkyaku_label
        '
        Me.henkyaku_label.AutoSize = True
        Me.henkyaku_label.Location = New System.Drawing.Point(115, 112)
        Me.henkyaku_label.Name = "henkyaku_label"
        Me.henkyaku_label.Size = New System.Drawing.Size(0, 12)
        Me.henkyaku_label.TabIndex = 5
        '
        'name_label
        '
        Me.name_label.AutoSize = True
        Me.name_label.Location = New System.Drawing.Point(113, 73)
        Me.name_label.Name = "name_label"
        Me.name_label.Size = New System.Drawing.Size(73, 12)
        Me.name_label.TabIndex = 4
        Me.name_label.Text = "神奈川　太郎"
        '
        'kaiin_id_label
        '
        Me.kaiin_id_label.AutoSize = True
        Me.kaiin_id_label.Location = New System.Drawing.Point(111, 35)
        Me.kaiin_id_label.Name = "kaiin_id_label"
        Me.kaiin_id_label.Size = New System.Drawing.Size(41, 12)
        Me.kaiin_id_label.TabIndex = 3
        Me.kaiin_id_label.Text = "123456"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "返却予定日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "氏名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "会員ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 12)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "上記内容を確認してください."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(116, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'loanout_form_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 255)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.video_id)
        Me.Name = "loanout_form_03"
        Me.Text = "貸出情報確認"
        Me.video_id.ResumeLayout(False)
        Me.video_id.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents video_id As System.Windows.Forms.GroupBox
    Friend WithEvents henkyaku_label As System.Windows.Forms.Label
    Friend WithEvents name_label As System.Windows.Forms.Label
    Friend WithEvents kaiin_id_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
