<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookHotel
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
        Me.Clear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComLayan = New System.Windows.Forms.ComboBox()
        Me.Sewa = New System.Windows.Forms.TextBox()
        Me.ComKam = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoHp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Noiden = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Red
        Me.Clear.Font = New System.Drawing.Font("Poppins ExtraBold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.White
        Me.Clear.Location = New System.Drawing.Point(212, 470)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 28)
        Me.Clear.TabIndex = 6
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Poppins ExtraBold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(190, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cetak Faktur"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComLayan)
        Me.GroupBox2.Controls.Add(Me.Sewa)
        Me.GroupBox2.Controls.Add(Me.ComKam)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(70, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 174)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hotel"
        '
        'ComLayan
        '
        Me.ComLayan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComLayan.FormattingEnabled = True
        Me.ComLayan.Items.AddRange(New Object() {"Include Breakfast", "Tanpa Breakfast", " "})
        Me.ComLayan.Location = New System.Drawing.Point(120, 65)
        Me.ComLayan.Name = "ComLayan"
        Me.ComLayan.Size = New System.Drawing.Size(121, 21)
        Me.ComLayan.TabIndex = 1
        '
        'Sewa
        '
        Me.Sewa.Location = New System.Drawing.Point(120, 98)
        Me.Sewa.Name = "Sewa"
        Me.Sewa.Size = New System.Drawing.Size(53, 20)
        Me.Sewa.TabIndex = 1
        '
        'ComKam
        '
        Me.ComKam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComKam.FormattingEnabled = True
        Me.ComKam.Items.AddRange(New Object() {"Standard Room", "Superior Room", "Deluxe Room", "Suite Room", " "})
        Me.ComKam.Location = New System.Drawing.Point(120, 32)
        Me.ComKam.Name = "ComKam"
        Me.ComKam.Size = New System.Drawing.Size(121, 21)
        Me.ComKam.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jenis Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Layanan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Lama Menginap"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(259, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Rp."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Rp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Hari"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NoHp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Noiden)
        Me.GroupBox1.Controls.Add(Me.Nama)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(70, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 140)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Penyewa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No.Identitas"
        '
        'NoHp
        '
        Me.NoHp.Location = New System.Drawing.Point(120, 87)
        Me.NoHp.Name = "NoHp"
        Me.NoHp.Size = New System.Drawing.Size(121, 20)
        Me.NoHp.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No. Hp"
        '
        'Noiden
        '
        Me.Noiden.Location = New System.Drawing.Point(120, 58)
        Me.Noiden.Name = "Noiden"
        Me.Noiden.Size = New System.Drawing.Size(121, 20)
        Me.Noiden.TabIndex = 1
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(120, 31)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(121, 20)
        Me.Nama.TabIndex = 1
        '
        'BookHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(485, 535)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookHotel"
        Me.Text = "Sewa Hotel"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComLayan As ComboBox
    Friend WithEvents Sewa As TextBox
    Friend WithEvents ComKam As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NoHp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Noiden As TextBox
    Friend WithEvents Nama As TextBox
End Class
