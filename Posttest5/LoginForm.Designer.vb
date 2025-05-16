<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        btnLogin = New Button()
        Label3 = New Label()
        Label2 = New Label()
        password = New TextBox()
        username = New TextBox()
        Label1 = New Label()
        regis = New Button()
        Label5 = New Label()
        Label4 = New Label()
        btnShowPassword = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Black
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(83, 380)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(147, 49)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(83, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 10
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(83, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 9
        Label2.Text = "Username"
        ' 
        ' password
        ' 
        password.Font = New Font("Segoe UI", 12.096F)
        password.Location = New Point(83, 304)
        password.Margin = New Padding(3, 4, 3, 4)
        password.Name = "password"
        password.Size = New Size(303, 40)
        password.TabIndex = 8
        password.UseSystemPasswordChar = True
        ' 
        ' username
        ' 
        username.Font = New Font("Segoe UI", 12.096F)
        username.Location = New Point(83, 212)
        username.Margin = New Padding(3, 4, 3, 4)
        username.Name = "username"
        username.Size = New Size(303, 40)
        username.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(74, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 40)
        Label1.TabIndex = 6
        Label1.Text = "Log in"
        ' 
        ' regis
        ' 
        regis.BackColor = Color.Transparent
        regis.FlatAppearance.BorderSize = 0
        regis.FlatStyle = FlatStyle.Flat
        regis.Font = New Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regis.Location = New Point(218, 452)
        regis.Margin = New Padding(0)
        regis.Name = "regis"
        regis.Size = New Size(116, 38)
        regis.TabIndex = 13
        regis.Text = "Registrasi"
        regis.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(88, 458)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 25)
        Label5.TabIndex = 14
        Label5.Text = "Belum ada akun?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(319, 458)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 15
        Label4.Text = "di sini"
        ' 
        ' btnShowPassword
        ' 
        btnShowPassword.BackColor = Color.Transparent
        btnShowPassword.BackgroundImage = My.Resources.Resources.Blue_and_White_Modern_Login_and_Sign_up_Website_Page_UI_Desktop_Prototype__2_
        btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom
        btnShowPassword.FlatAppearance.BorderSize = 0
        btnShowPassword.FlatStyle = FlatStyle.Flat
        btnShowPassword.Location = New Point(392, 306)
        btnShowPassword.Margin = New Padding(3, 4, 3, 4)
        btnShowPassword.Name = "btnShowPassword"
        btnShowPassword.Size = New Size(38, 37)
        btnShowPassword.TabIndex = 16
        btnShowPassword.UseVisualStyleBackColor = False
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Blue_and_White_Modern_Login_and_Sign_up_Website_Page_UI_Desktop_Prototype__1_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1017, 579)
        Controls.Add(btnShowPassword)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(regis)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "loginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents regis As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShowPassword As Button

End Class
