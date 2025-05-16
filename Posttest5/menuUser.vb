Public Class MenuUser

    ' Track login state and userId
    Private isLoggedIn As Boolean = False
    Private currentUserId As Integer = -1
    Private currentUsername As String = ""

    Private Sub ShowWelcomeMessage(username As String)
        Label2.Text = $"Halo, {username}!"
        ' Update posisi jika ukuran label berubah
        Label2.Left = loginBtn.Left - Label2.Width - 10
        Label2.Top = loginBtn.Top + (loginBtn.Height - Label2.Height) \ 2
    End Sub

    Private Sub MenuUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbfunc.InnitDatabase()
        SetLoginState(False)
        Label2.Text = ""
        ' Atur ukuran font kecil
        Label2.Font = New Font(Label2.Font.FontFamily, 9, FontStyle.Regular)
        Label2.BackColor = Color.AntiqueWhite

        ' Tempatkan Label2 di kiri loginBtn
        Label2.Top = loginBtn.Top + (loginBtn.Height - Label2.Height) \ 2
        Label2.Left = loginBtn.Left - Label2.Width - 10 ' 10px jarak dari loginBtn
    End Sub

    ' Handle Reservasi menu and submenus
    Private Sub BuatReservasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatReservasiToolStripMenuItem.Click
        If Not isLoggedIn Then
            MessageBox.Show("Anda harus login terlebih dahulu untuk mengakses menu ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Me.Hide()
            reservasiUser.Show()
        End If
    End Sub

    Private Sub CetakBuktiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakBuktiToolStripMenuItem.Click
        If Not isLoggedIn Then
            MessageBox.Show("Anda harus login terlebih dahulu untuk mengakses menu ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Me.Hide()
            cetakBukti.Show()
        End If

    End Sub

    ' Login/Logout button logic
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Me.Hide()
        If isLoggedIn Then
            ' Logout
            SetLoginState(False)
            MessageBox.Show("Anda telah logout.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Show()
        Else
            ' Show login form as dialog
            Dim loginForm As New LoginForm()
            If loginForm.ShowDialog() = DialogResult.OK Then
                If loginForm.UserRole = 2 Then ' Role user
                    currentUsername = loginForm.UsernameValue
                    SetLoginState(True, loginForm.UserId)
                    ShowWelcomeMessage(currentUsername)
                Else
                    MessageBox.Show("Hanya user yang dapat mengakses menu ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    ' Helper to set login state and update UI
    Private Sub SetLoginState(loggedIn As Boolean, Optional userId As Integer = -1)
        isLoggedIn = loggedIn
        currentUserId = If(loggedIn, userId, -1)
        loginBtn.Text = If(loggedIn, "Logout", "Login")
        If Not loggedIn Then
            Label2.Text = ""
        End If
        ' Sembunyikan label jika logout
        Label2.Visible = loggedIn
    End Sub
    ' Optional: Prevent Reservasi menu from being accessed by keyboard
    Private Sub MenuStrip1_MenuActivate(sender As Object, e As EventArgs) Handles MenuStrip1.MenuActivate
        ' Example: disable menu if not logged in
        BuatReservasiToolStripMenuItem.Enabled = isLoggedIn
        CetakBuktiToolStripMenuItem.Enabled = isLoggedIn
    End Sub

    Private Sub TentangKamiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangKamiToolStripMenuItem.Click
        ' ...
    End Sub

    Private Sub BantuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem.Click
        ' ...
    End Sub


End Class