Imports System.Data.SQLite

Public Class LoginForm
    Private passwordVisible As Boolean = False
    Public Property UsernameValue As String
    Public Property UserRole As Integer
    Public Property UserId As Integer

    Public Shared LoggedInUserId As Integer = -1

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim createTableQuery As String = "
                CREATE TABLE IF NOT EXISTS tbUser (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL UNIQUE,
                    password TEXT NOT NULL,
                    role INT NOT NULL
                );"
                Using cmd As New SQLiteCommand(createTableQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using

                Dim checkQuery As String = "SELECT COUNT(*) FROM tbUser"
                Using checkCmd As New SQLiteCommand(checkQuery, conn)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count = 0 Then
                        Dim insertQuery As String = "INSERT INTO tbUser (username, password, role) VALUES 
                        ('admin', 'admin', 1), 
                        ('user', 'user', 2);"
                        Using insertCmd As New SQLiteCommand(insertQuery, conn)
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal membuat tabel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(username.Text) OrElse String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Silakan isi Username dan Password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                ' username tidak case sensitive
                Dim cmd As New SQLiteCommand("SELECT * FROM tbUser WHERE LOWER(username)=LOWER(@user) AND password=@pass", conn)
                cmd.Parameters.AddWithValue("@user", username.Text)
                cmd.Parameters.AddWithValue("@pass", password.Text)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        UserRole = Convert.ToInt32(reader("role"))
                        UserId = Convert.ToInt32(reader("id"))
                        LoggedInUserId = UserId
                        UsernameValue = reader("username").ToString()
                        MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        Me.DialogResult = DialogResult.OK
                        If UserRole = 1 Then
                            Dim mainForm As New homeForm()
                            mainForm.Show()
                        ElseIf UserRole = 2 Then
                            menuUser.Show()
                        Else
                            MessageBox.Show("Role tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Username atau password salah.", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Regis_Click(sender As Object, e As EventArgs) Handles regis.Click
        Me.Close()
        Dim r As New registerForm
        r.Show()
    End Sub

    Private Sub BtnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        passwordVisible = Not passwordVisible
        password.UseSystemPasswordChar = Not passwordVisible
    End Sub
End Class