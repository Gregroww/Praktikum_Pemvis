Imports System.Data.SQLite
Imports System.Drawing.Printing

Public Class cetakBukti
    Private dataCetak As Dictionary(Of String, String)

    Private Sub cetakBukti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanReservasiUser()
    End Sub

    Private Sub TampilkanReservasiUser()
        FlowLayoutPanel1.Controls.Clear()
        Dim userId As Integer = LoginForm.LoggedInUserId

        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "SELECT * FROM tbPelanggan WHERE userId = @userId"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    Using dr As SQLiteDataReader = cmd.ExecuteReader()
                        Dim idx As Integer = 1
                        While dr.Read()
                            Dim gb As New GroupBox()
                            gb.Text = $"Reservasi #{idx}"
                            gb.Width = 900
                            gb.Height = 180
                            gb.Margin = New Padding(10)
                            gb.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                            ' label informasi
                            Dim lblNama As New Label()
                            lblNama.Text = $"Nama: {dr("Nama")}"
                            lblNama.Location = New Point(20, 30)
                            lblNama.AutoSize = True
                            lblNama.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            Dim lblIdentitas As New Label()
                            lblIdentitas.Text = $"No Identitas: {dr("NoIdentitas")}"
                            lblIdentitas.Location = New Point(20, 60)
                            lblIdentitas.AutoSize = True
                            lblIdentitas.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            Dim lblTipeKamar As New Label()
                            lblTipeKamar.Text = $"Tipe Kamar: {dr("TipeKamar")}"
                            lblTipeKamar.Location = New Point(20, 90)
                            lblTipeKamar.AutoSize = True
                            lblTipeKamar.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            Dim lblCheckIn As New Label()
                            lblCheckIn.Text = $"Check In: {Convert.ToDateTime(dr("TglCheckIn")).ToString("dd MMM yyyy")}"
                            lblCheckIn.Location = New Point(350, 30)
                            lblCheckIn.AutoSize = True
                            lblCheckIn.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            Dim lblCheckOut As New Label()
                            lblCheckOut.Text = $"Check Out: {Convert.ToDateTime(dr("TglCheckOut")).ToString("dd MMM yyyy")}"
                            lblCheckOut.Location = New Point(350, 60)
                            lblCheckOut.AutoSize = True
                            lblCheckOut.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            Dim lblJumlahTamu As New Label()
                            lblJumlahTamu.Text = $"Jumlah Tamu: {dr("JumlahTamu")}"
                            lblJumlahTamu.Location = New Point(350, 90)
                            lblJumlahTamu.AutoSize = True
                            lblJumlahTamu.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            Dim lblNoTlp As New Label()
                            lblNoTlp.Text = $"No Telepon: {dr("NoTlp")}"
                            lblNoTlp.Location = New Point(650, 30)
                            lblNoTlp.AutoSize = True
                            lblNoTlp.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                            ' tombol cetak - di bawah semua label
                            Dim btnCetak As New Button()
                            btnCetak.Text = "Cetak Bukti"
                            btnCetak.Width = 120
                            btnCetak.Height = 35
                            btnCetak.Location = New Point(20, 130)
                            btnCetak.Tag = dr("NoIdentitas").ToString()
                            AddHandler btnCetak.Click, AddressOf CetakBukti_Click

                            ' tambahkan ke groupbox
                            gb.Controls.Add(lblNama)
                            gb.Controls.Add(lblIdentitas)
                            gb.Controls.Add(lblTipeKamar)
                            gb.Controls.Add(lblCheckIn)
                            gb.Controls.Add(lblCheckOut)
                            gb.Controls.Add(lblJumlahTamu)
                            gb.Controls.Add(lblNoTlp)
                            gb.Controls.Add(btnCetak)

                            FlowLayoutPanel1.Controls.Add(gb)
                            idx += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CetakBukti_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim noIdentitas As String = btn.Tag.ToString()

        ' ambil data 
        dataCetak = New Dictionary(Of String, String)
        Try
            Using conn As New SQLiteConnection("Data Source=dbhotel.db;Version=3;")
                conn.Open()
                Dim sql As String = "SELECT * FROM tbPelanggan WHERE NoIdentitas = @NoIdentitas"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@NoIdentitas", noIdentitas)
                    Using dr As SQLiteDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            dataCetak("Nama") = dr("Nama").ToString()
                            dataCetak("NoIdentitas") = dr("NoIdentitas").ToString()
                            dataCetak("TipeKamar") = dr("TipeKamar").ToString()
                            dataCetak("TglCheckIn") = Convert.ToDateTime(dr("TglCheckIn")).ToString("dd MMM yyyy")
                            dataCetak("TglCheckOut") = Convert.ToDateTime(dr("TglCheckOut")).ToString("dd MMM yyyy")
                            dataCetak("JumlahTamu") = dr("JumlahTamu").ToString()
                            dataCetak("NoTlp") = dr("NoTlp").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data untuk cetak: " & ex.Message)
            Return
        End Try

        PrintPreviewDialog1.Document = PrintDocument1
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDoc_PrintPage
        PrintPreviewDialog1.ShowDialog()
        RemoveHandler PrintDocument1.PrintPage, AddressOf PrintDoc_PrintPage
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g = e.Graphics

        ' boundary
        Dim bounds = e.MarginBounds
        Dim pageWidth = bounds.Width
        Dim leftMargin = bounds.Left
        Dim topMargin = bounds.Top

        ' topo
        Dim fontHotel As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim fontTitle As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim fontLabel As New Font("Segoe UI", 11, FontStyle.Regular)
        Dim fontFooter As New Font("Segoe UI", 10, FontStyle.Italic)
        Dim y As Integer = topMargin + 20
        Dim contentLeft = leftMargin + 20
        Dim contentWidth = pageWidth - 40

        Dim hotelName As String = "Hotel Ritz Carlton"
        Dim hotelNameSize = g.MeasureString(hotelName, fontHotel)
        g.DrawString(hotelName, fontHotel, Brushes.Black, contentLeft + (contentWidth - hotelNameSize.Width) / 2, y)
        y += CInt(hotelNameSize.Height) + 10
        g.DrawLine(Pens.Black, contentLeft, y, contentLeft + contentWidth, y)
        y += 15

        ' header
        Dim title As String = "BUKTI RESERVASI"
        Dim titleSize = g.MeasureString(title, fontTitle)
        g.DrawString(title, fontTitle, Brushes.Black, contentLeft + (contentWidth - titleSize.Width) / 2, y)
        y += CInt(titleSize.Height) + 15

        Dim labelPad = 120 ' Jarak label dan nilai
        g.DrawString("Nama", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("Nama"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 25
        g.DrawString("No Identitas", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("NoIdentitas"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 25
        g.DrawString("Tipe Kamar", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("TipeKamar"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 25
        g.DrawString("Check In", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("TglCheckIn"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 25
        g.DrawString("Check Out", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("TglCheckOut"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 25
        g.DrawString("Jumlah Tamu", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("JumlahTamu"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 25
        g.DrawString("No Telepon", fontLabel, Brushes.Black, contentLeft, y)
        g.DrawString(": " & dataCetak("NoTlp"), fontLabel, Brushes.Black, contentLeft + labelPad, y)
        y += 35
        g.DrawLine(Pens.Black, contentLeft, y, contentLeft + contentWidth, y)
        y += 20

        ' footer
        Dim footer As String = "Terima kasih telah melakukan reservasi di Hotel Ritz Carlton."
        Dim footerSize = g.MeasureString(footer, fontFooter)
        g.DrawString(footer, fontFooter, Brushes.Black, contentLeft + (contentWidth - footerSize.Width) / 2, y)
        y += CInt(footerSize.Height) + 10
        Dim borderHeight = y - (topMargin + 20)
        g.DrawRectangle(Pens.Black, contentLeft - 10, topMargin + 10, contentWidth + 20, borderHeight + 10)
    End Sub
    Private Sub LandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingToolStripMenuItem.Click
        Me.Hide()
        menuUser.Show()
    End Sub

    Private Sub BuatReservasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatReservasiToolStripMenuItem.Click
        Me.Hide()
        reservasiUser.Show()
    End Sub
End Class