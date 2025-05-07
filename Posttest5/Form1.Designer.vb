<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox4 = New TextBox()
        Button5 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(235, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(306, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(235, 95)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(306, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(235, 124)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(306, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(235, 248)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(43, 23)
        TextBox5.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(235, 182)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(306, 23)
        DateTimePicker1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nomor Identitas (KTP)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 7
        Label2.Text = "Nama Lengkap"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 8
        Label3.Text = "Nomor Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 9
        Label4.Text = "Tipe Kamar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 10
        Label5.Text = "Tanggal Check In"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 15)
        Label6.TabIndex = 11
        Label6.Text = "Jumlah Tamu"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Deluxe", "Superior", "Executive"})
        ComboBox1.Location = New Point(235, 153)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(306, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(235, 290)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 23)
        Button1.TabIndex = 13
        Button1.Text = "Tambahkan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(341, 290)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 23)
        Button3.TabIndex = 15
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(451, 290)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 23)
        Button4.TabIndex = 16
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(602, 180)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(186, 23)
        TextBox4.TabIndex = 17
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(698, 212)
        Button5.Name = "Button5"
        Button5.Size = New Size(90, 23)
        Button5.TabIndex = 18
        Button5.Text = "Cari"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(602, 162)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 15)
        Label7.TabIndex = 19
        Label7.Text = "Cari Pelanggan "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Wheat
        Label8.Font = New Font("Calisto MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(247, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(294, 32)
        Label8.TabIndex = 21
        Label8.Text = "RESERVASI HOTEL"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(53, 220)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 15)
        Label9.TabIndex = 22
        Label9.Text = "Tanggal Check Out"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(235, 214)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(306, 23)
        DateTimePicker2.TabIndex = 23
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(53, 330)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(735, 175)
        DataGridView1.TabIndex = 24
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(713, 290)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 25
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(834, 522)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button5)
        Controls.Add(TextBox4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button

End Class
