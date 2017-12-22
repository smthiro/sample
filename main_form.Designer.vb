<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.date_time = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "貸出業務"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "会員管理"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "返却業務"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(177, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "商品管理"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'date_time
        '
        Me.date_time.AutoSize = True
        Me.date_time.Location = New System.Drawing.Point(156, 109)
        Me.date_time.Name = "date_time"
        Me.date_time.Size = New System.Drawing.Size(38, 12)
        Me.date_time.TabIndex = 4
        Me.date_time.Text = "Label1"
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 137)
        Me.Controls.Add(Me.date_time)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "main_form"
        Me.Text = "ビデオレンタルシステム メインメニュー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents date_time As System.Windows.Forms.Label

End Class
