Imports System.Data.SQLite

Public Class reservasiUser
    Private ReadOnly Property UserId As Integer
        Get
            Return LoginForm.LoggedInUserId
        End Get
    End Property

    Private Sub reservasiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTipeKamar()
        TampilkanData()
        DateTimePicker1.MinDate = DateTime.Today
        DateTimePicker2.MinDate = DateTime.Today
    End Sub

    Private Sub LoadTipeKamar()
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "SELECT NamaTipe FROM tbTipeKamar"
                Using cmd As New SQLiteCommand(sql, conn)
                    Using dr As SQLiteDataReader = cmd.ExecuteReader()
                        ComboBox1.Items.Clear()
                        While dr.Read()
                            ComboBox1.Items.Add(dr("NamaTipe").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal memuat data tipe kamar: " & ex.Message)
        End Try
    End Sub

    Private Sub TampilkanData()
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "SELECT * FROM tbPelanggan WHERE userId = @userId"
                Using da As New SQLiteDataAdapter(sql, conn)
                    da.SelectCommand.Parameters.AddWithValue("@userId", UserId)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message)
        End Try
    End Sub

    ' tambah
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' validasi parameter kosong
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
           ComboBox1.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' validasi tanggal checkout harus setelah check-in
        If DateTimePicker2.Value <= DateTimePicker1.Value Then
            MsgBox("Tanggal check-out harus setelah tanggal check-in!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "INSERT INTO tbPelanggan (NoIdentitas, Nama, NoTlp, TipeKamar, TglCheckIn, TglCheckOut, JumlahTamu, userId) VALUES (@NoIdentitas, @Nama, @NoTlp, @TipeKamar, @TglCheckIn, @TglCheckOut, @JumlahTamu, @id) "
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@NoIdentitas", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Nama", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@NoTlp", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@TipeKamar", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@TglCheckIn", DateTimePicker1.Value)
                    cmd.Parameters.AddWithValue("@TglCheckOut", DateTimePicker2.Value)
                    cmd.Parameters.AddWithValue("@JumlahTamu", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@id", UserId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Data berhasil ditambahkan.")
            TampilkanData()
        Catch ex As Exception
            MsgBox("Gagal tambah: " & ex.Message)
        End Try
    End Sub

    ' update
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Validasi field kosong
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
           ComboBox1.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validasi tanggal checkout harus setelah check-in
        If DateTimePicker2.Value <= DateTimePicker1.Value Then
            MsgBox("Tanggal check-out harus setelah tanggal check-in!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "UPDATE tbPelanggan SET Nama=@Nama, NoTlp=@NoTlp, TipeKamar=@TipeKamar, TglCheckIn=@TglCheckIn, TglCheckOut=@TglCheckOut, JumlahTamu=@JumlahTamu WHERE NoIdentitas=@NoIdentitas"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Nama", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@NoTlp", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@TipeKamar", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@TglCheckIn", DateTimePicker1.Value)
                    cmd.Parameters.AddWithValue("@TglCheckOut", DateTimePicker2.Value)
                    cmd.Parameters.AddWithValue("@JumlahTamu", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@NoIdentitas", TextBox1.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Data berhasil diperbarui.")
            TampilkanData()
        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        End Try
    End Sub

    ' hapus
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Validasi field NoIdentitas tidak kosong
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("No Identitas harus diisi untuk menghapus data!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "DELETE FROM tbPelanggan WHERE NoIdentitas=@NoIdentitas"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@NoIdentitas", TextBox1.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Data berhasil dihapus.")
            TampilkanData()
        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        End Try
    End Sub

    ' cari
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "SELECT * FROM tbPelanggan WHERE Nama LIKE @Nama AND userId = @userId"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Nama", "%" & TextBox4.Text & "%")
                    cmd.Parameters.AddWithValue("@userId", UserId)
                    Using dr As SQLiteDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            TextBox1.Text = dr("NoIdentitas")
                            TextBox2.Text = dr("Nama")
                            TextBox3.Text = dr("NoTlp")
                            ComboBox1.Text = dr("TipeKamar")
                            DateTimePicker1.Value = Convert.ToDateTime(dr("TglCheckIn"))
                            DateTimePicker2.Value = Convert.ToDateTime(dr("TglCheckOut"))
                            TextBox5.Text = dr("JumlahTamu").ToString
                            MsgBox("Data ditemukan.")
                        Else
                            MsgBox("Data tidak ditemukan.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message)
        End Try
    End Sub

    ' refresh
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    ' menampilkan data ke textbox
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("NoIdentitas").Value.ToString()
            TextBox2.Text = row.Cells("Nama").Value.ToString()
            TextBox3.Text = row.Cells("NoTlp").Value.ToString()
            ComboBox1.Text = row.Cells("TipeKamar").Value.ToString()
            DateTimePicker1.Value = Convert.ToDateTime(row.Cells("TglCheckIn").Value)
            DateTimePicker2.Value = Convert.ToDateTime(row.Cells("TglCheckOut").Value)
            TextBox5.Text = row.Cells("JumlahTamu").Value.ToString()
        End If
    End Sub

    ' Hanya izinkan angka untuk nomor telepon
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Hanya izinkan angka untuk jumlah penghuni
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Set MinDate checkout ke hari setelah check-in
        DateTimePicker2.MinDate = DateTimePicker1.Value.AddDays(1)
        ' Jika checkout <= check-in, otomatis set checkout ke hari setelah check-in
        If DateTimePicker2.Value <= DateTimePicker1.Value Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddDays(1)
        End If
    End Sub

    Private Sub LandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingToolStripMenuItem.Click
        Me.Hide()
        menuUser.Show()
    End Sub

    Private Sub CetakBuktiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakBuktiToolStripMenuItem.Click
        Me.Hide()
        cetakBukti.Show()
    End Sub
End Class