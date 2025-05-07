Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=dbhotel")
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim loginForm As New LoginForm()
        Dim loginResult As DialogResult = loginForm.ShowDialog()

        If loginResult = DialogResult.OK Then
            Me.Show()
            LoadTipeKamar()
            TampilkanData()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub LoadTipeKamar()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "SELECT NamaTipe FROM tbTipeKamar"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While dr.Read()
                ComboBox1.Items.Add(dr("NamaTipe").ToString())
            End While
        Catch ex As Exception
            MsgBox("Gagal memuat data tipe kamar: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' tambah
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "INSERT INTO tbPelanggan (NoIdentitas, Nama, NoTlp, TipeKamar, TglCheckIn, TglCheckOut, JumlahTamu) VALUES (@NoIdentitas, @Nama, @NoTlp, @TipeKamar, @TglCheckIn, @TglCheckOut, @JumlahTamu)"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@NoIdentitas", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Nama", TextBox2.Text)
            cmd.Parameters.AddWithValue("@NoTlp", TextBox3.Text)
            cmd.Parameters.AddWithValue("@TipeKamar", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@TglCheckIn", DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@TglCheckOut", DateTimePicker2.Value)
            cmd.Parameters.AddWithValue("@JumlahTamu", TextBox5.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan.")
            TampilkanData()

        Catch ex As Exception
            MsgBox("Gagal tambah: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    ' update
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "UPDATE tbPelanggan SET Nama=@Nama, NoTlp=@NoTlp, TipeKamar=@TipeKamar, TglCheckIn=@TglCheckIn, TglCheckOut=@TglCheckOut, JumlahTamu=@JumlahTamu WHERE NoIdentitas=@NoIdentitas"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Nama", TextBox2.Text)
            cmd.Parameters.AddWithValue("@NoTlp", TextBox3.Text)
            cmd.Parameters.AddWithValue("@TipeKamar", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@TglCheckIn", DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@TglCheckOut", DateTimePicker2.Value)
            cmd.Parameters.AddWithValue("@JumlahTamu", TextBox5.Text)
            cmd.Parameters.AddWithValue("@NoIdentitas", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diperbarui.")
            TampilkanData()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    ' hapus
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "DELETE FROM tbPelanggan WHERE NoIdentitas=@NoIdentitas"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@NoIdentitas", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus.")
            TampilkanData()

        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    ' cari
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "SELECT * FROM tbPelanggan WHERE Nama LIKE @Nama"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Nama", "%" & TextBox4.Text & "%")
            dr = cmd.ExecuteReader
            If dr.Read() Then
                TextBox1.Text = dr("NoIdentitas")
                TextBox2.Text = dr("Nama")
                TextBox3.Text = dr("NoTlp")
                ComboBox1.Text = dr("TipeKamar")
                DateTimePicker1.Value = dr("TglCheckIn")
                DateTimePicker2.Value = dr("TglCheckOut")
                TextBox5.Text = dr("JumlahTamu").ToString
                MsgBox("Data ditemukan.")
            Else
                MsgBox("Data tidak ditemukan.")
            End If
        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    ' tampilkan data
    Sub TampilkanData()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "SELECT * FROM tbPelanggan"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
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



End Class
