Imports System.Data.SQLite

Module dbfunc
    Public Sub InnitDatabase()
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()

                ' Buat tabel tbTipeKamar
                Dim sqlTipeKamar As String = "
                CREATE TABLE IF NOT EXISTS tbTipeKamar (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    NamaTipe TEXT NOT NULL
                );"
                Using cmd As New SQLiteCommand(sqlTipeKamar, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Cek apakah tipe kamar sudah ada
                Dim count As Integer
                Using countCmd As New SQLiteCommand("SELECT COUNT(*) FROM tbTipeKamar", conn)
                    count = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using
                If count = 0 Then
                    Dim tipeKamar() As String = {"Standard", "Deluxe", "Suite", "Family", "Presidential"}
                    For Each tipe In tipeKamar
                        Using insertTipe As New SQLiteCommand("INSERT INTO tbTipeKamar (NamaTipe) VALUES (@tipe)", conn)
                            insertTipe.Parameters.AddWithValue("@tipe", tipe)
                            insertTipe.ExecuteNonQuery()
                        End Using
                    Next
                End If

                ' Buat tabel tbPelanggan
                Dim sqlPelanggan As String = "
                CREATE TABLE IF NOT EXISTS tbPelanggan (
                    NoIdentitas TEXT PRIMARY KEY,
                    Nama TEXT,
                    NoTlp TEXT,
                    TipeKamar TEXT,
                    TglCheckIn TEXT,
                    TglCheckOut TEXT,
                    JumlahTamu INTEGER,
                    userId INTEGER REFERENCES tbUser(id) ON DELETE CASCADE 
                );"
                Using cmd As New SQLiteCommand(sqlPelanggan, conn)
                    cmd.ExecuteNonQuery()
                End Using
                ' Cek apakah ada data pelanggan
                Dim jumlahPelanggan As Integer
                Using countPelanggan As New SQLiteCommand("SELECT COUNT(*) FROM tbPelanggan", conn)
                    jumlahPelanggan = Convert.ToInt32(countPelanggan.ExecuteScalar())
                End Using
                If jumlahPelanggan = 0 Then
                    Dim rand As New Random()
                    Dim namaDepan() As String = {"Budi", "Siti", "Andi", "Rina", "Tono", "Dewi", "Rudi", "Tina", "Ali", "Maya"}
                    Dim tipeKamar() As String = {"Standard", "Deluxe", "Suite", "Family", "Presidential"}

                    For i As Integer = 1 To 20
                        Dim noId As String = "ID" & i.ToString("000")
                        Dim nama As String = namaDepan(rand.Next(namaDepan.Length)) & " " & namaDepan(rand.Next(namaDepan.Length))
                        Dim noTlp As String = "08" & rand.Next(100000000, 999999999).ToString()
                        Dim tipe As String = tipeKamar(rand.Next(tipeKamar.Length))
                        Dim checkIn As DateTime = DateTime.Today.AddDays(-rand.Next(0, 10))
                        Dim checkOut As DateTime = checkIn.AddDays(rand.Next(1, 5))
                        Dim jumlahTamu As Integer = rand.Next(1, 5)
                        Dim id As Integer = 0

                        Using insertPelanggan As New SQLiteCommand("
                        INSERT INTO tbPelanggan (NoIdentitas, Nama, NoTlp, TipeKamar, TglCheckIn, TglCheckOut, JumlahTamu, userID)
                        VALUES (@NoIdentitas, @Nama, @NoTlp, @TipeKamar, @TglCheckIn, @TglCheckOut, @JumlahTamu, @id)", conn)
                            insertPelanggan.Parameters.AddWithValue("@NoIdentitas", noId)
                            insertPelanggan.Parameters.AddWithValue("@Nama", nama)
                            insertPelanggan.Parameters.AddWithValue("@NoTlp", noTlp)
                            insertPelanggan.Parameters.AddWithValue("@TipeKamar", tipe)
                            insertPelanggan.Parameters.AddWithValue("@TglCheckIn", checkIn)
                            insertPelanggan.Parameters.AddWithValue("@TglCheckOut", checkOut)
                            insertPelanggan.Parameters.AddWithValue("@JumlahTamu", jumlahTamu)
                            insertPelanggan.Parameters.AddWithValue("@id", id)
                            insertPelanggan.ExecuteNonQuery()
                        End Using
                    Next
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal inisialisasi database: " & ex.Message)
        End Try
    End Sub
End Module
