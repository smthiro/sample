<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class withdrawal_form_02
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mibun_id = New System.Windows.Forms.TextBox()
        Me.shimei = New System.Windows.Forms.TextBox()
        Me.mibun_syubetsu = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "身分証情報を入力してください."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "身分証番号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "身分証種別"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "氏名"
        '
        'mibun_id
        '
        Me.mibun_id.Location = New System.Drawing.Point(109, 46)
        Me.mibun_id.Name = "mibun_id"
        Me.mibun_id.Size = New System.Drawing.Size(148, 19)
        Me.mibun_id.TabIndex = 4
        '
        'shimei
        '
        Me.shimei.Location = New System.Drawing.Point(109, 124)
        Me.shimei.Name = "shimei"
        Me.shimei.Size = New System.Drawing.Size(148, 19)
        Me.shimei.TabIndex = 5
        '
        'mibun_syubetsu
        '
        Me.mibun_syubetsu.FormattingEnabled = True
        Me.mibun_syubetsu.Items.AddRange(New Object() {"保険証", "免許証"})
        Me.mibun_syubetsu.Location = New System.Drawing.Point(109, 86)
        Me.mibun_syubetsu.Name = "mibun_syubetsu"
        Me.mibun_syubetsu.Size = New System.Drawing.Size(148, 20)
        Me.mibun_syubetsu.TabIndex = 6
        Me.mibun_syubetsu.Text = "保険証"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(182, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'withdrawal_form_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 204)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mibun_syubetsu)
        Me.Controls.Add(Me.shimei)
        Me.Controls.Add(Me.mibun_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "withdrawal_form_02"
        Me.Text = "身分証退会"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mibun_id As System.Windows.Forms.TextBox
    Friend WithEvents shimei As System.Windows.Forms.TextBox
    Friend WithEvents mibun_syubetsu As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
