<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        btnRegister = New Button()
        Label3 = New Label()
        Label2 = New Label()
        password = New TextBox()
        username = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        btnShowPassword = New Button()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Black
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(70, 319)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(132, 41)
        btnRegister.TabIndex = 17
        btnRegister.Text = "Registrasi"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(70, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 16
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(70, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 15
        Label2.Text = "Username"
        ' 
        ' password
        ' 
        password.Font = New Font("Segoe UI", 12.096F)
        password.Location = New Point(70, 255)
        password.Name = "password"
        password.Size = New Size(273, 35)
        password.TabIndex = 14
        password.UseSystemPasswordChar = True
        ' 
        ' username
        ' 
        username.Font = New Font("Segoe UI", 12.096F)
        username.Location = New Point(70, 178)
        username.Name = "username"
        username.Size = New Size(273, 35)
        username.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 35)
        Label1.TabIndex = 12
        Label1.Text = "Registrasi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(251, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 21)
        Label4.TabIndex = 20
        Label4.Text = "di sini"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(70, 380)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 21)
        Label5.TabIndex = 19
        Label5.Text = "Sudah ada akun?"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(171, 374)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 32)
        Button2.TabIndex = 18
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnShowPassword
        ' 
        btnShowPassword.BackColor = Color.Transparent
        btnShowPassword.BackgroundImage = CType(resources.GetObject("btnShowPassword.BackgroundImage"), Image)
        btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom
        btnShowPassword.FlatAppearance.BorderSize = 0
        btnShowPassword.FlatStyle = FlatStyle.Flat
        btnShowPassword.Location = New Point(351, 258)
        btnShowPassword.Name = "btnShowPassword"
        btnShowPassword.Size = New Size(34, 31)
        btnShowPassword.TabIndex = 21
        btnShowPassword.UseVisualStyleBackColor = False
        ' 
        ' Daftar
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Blue_and_White_Modern_Login_and_Sign_up_Website_Page_UI_Desktop_Prototype__1_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(915, 486)
        Controls.Add(btnShowPassword)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(btnRegister)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label1)
        Name = "Daftar"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnShowPassword As Button
End Class
