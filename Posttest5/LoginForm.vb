Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=dbhotel")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM tbUser WHERE username=@user AND password=@pass"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", TextBox1.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                ' Login berhasil
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Login gagal. Periksa username dan password!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Gagal login: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
