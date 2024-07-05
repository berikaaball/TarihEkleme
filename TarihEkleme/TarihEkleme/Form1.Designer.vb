<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPİlkTarih = New System.Windows.Forms.DateTimePicker()
        Me.DTPSonTarih = New System.Windows.Forms.DateTimePicker()
        Me.TBoxVeri = New System.Windows.Forms.TextBox()
        Me.CBoxTip = New System.Windows.Forms.ComboBox()
        Me.BtnTarihEkle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "İlk Tarih:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Eklenecek Veri:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Eklenecek Veri Tipi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sonuç Tarih:"
        '
        'DTPİlkTarih
        '
        Me.DTPİlkTarih.Location = New System.Drawing.Point(181, 66)
        Me.DTPİlkTarih.Name = "DTPİlkTarih"
        Me.DTPİlkTarih.Size = New System.Drawing.Size(200, 22)
        Me.DTPİlkTarih.TabIndex = 4
        '
        'DTPSonTarih
        '
        Me.DTPSonTarih.Location = New System.Drawing.Point(181, 219)
        Me.DTPSonTarih.Name = "DTPSonTarih"
        Me.DTPSonTarih.Size = New System.Drawing.Size(200, 22)
        Me.DTPSonTarih.TabIndex = 5
        '
        'TBoxVeri
        '
        Me.TBoxVeri.Location = New System.Drawing.Point(181, 116)
        Me.TBoxVeri.Name = "TBoxVeri"
        Me.TBoxVeri.Size = New System.Drawing.Size(100, 22)
        Me.TBoxVeri.TabIndex = 6
        '
        'CBoxTip
        '
        Me.CBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxTip.FormattingEnabled = True
        Me.CBoxTip.Location = New System.Drawing.Point(181, 168)
        Me.CBoxTip.Name = "CBoxTip"
        Me.CBoxTip.Size = New System.Drawing.Size(121, 24)
        Me.CBoxTip.TabIndex = 7
        '
        'BtnTarihEkle
        '
        Me.BtnTarihEkle.Location = New System.Drawing.Point(181, 285)
        Me.BtnTarihEkle.Name = "BtnTarihEkle"
        Me.BtnTarihEkle.Size = New System.Drawing.Size(121, 49)
        Me.BtnTarihEkle.TabIndex = 8
        Me.BtnTarihEkle.Text = "Tarih Ekle"
        Me.BtnTarihEkle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTarihEkle)
        Me.Controls.Add(Me.CBoxTip)
        Me.Controls.Add(Me.TBoxVeri)
        Me.Controls.Add(Me.DTPSonTarih)
        Me.Controls.Add(Me.DTPİlkTarih)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarih Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPİlkTarih As DateTimePicker
    Friend WithEvents DTPSonTarih As DateTimePicker
    Friend WithEvents TBoxVeri As TextBox
    Friend WithEvents CBoxTip As ComboBox
    Friend WithEvents BtnTarihEkle As Button
End Class
