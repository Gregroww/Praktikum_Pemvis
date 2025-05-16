Imports System.Data.SQLite

Public Class RegisterForm

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validasi input kosong
        If String.IsNullOrWhiteSpace(username.Text) OrElse String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi panjang username dan password
        If username.Text.Length < 4 OrElse password.Text.Length < 6 Then
            MessageBox.Show("Username dan Password minimal 4 dan 6 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()

                ' Cek apakah username sudah ada
                Using cekCmd As New SQLiteCommand("SELECT * FROM tbUser WHERE username=@user", conn)
                    cekCmd.Parameters.AddWithValue("@user", username.Text)
                    Using cekReader As SQLiteDataReader = cekCmd.ExecuteReader()
                        If cekReader.HasRows Then
                            MessageBox.Show("Username sudah terdaftar.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Insert user baru dengan role 2 (user biasa)
                Using cmd As New SQLiteCommand("INSERT INTO tbUser(username, password, role) VALUES(@user, @pass, @role)", conn)
                    cmd.Parameters.AddWithValue("@user", username.Text)
                    cmd.Parameters.AddWithValue("@pass", password.Text)
                    cmd.Parameters.AddWithValue("@role", 2) ' 2 = user biasa
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Akun berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                LoginForm.Show()
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("Kesalahan database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class
