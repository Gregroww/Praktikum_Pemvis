<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuUser
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        loginBtn = New Button()
        Label4 = New Label()
        MenuStrip1 = New MenuStrip()
        TentangKamiToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BuatReservasiToolStripMenuItem = New ToolStripMenuItem()
        CetakBuktiToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Image = My.Resources.Resources.rz_jktrt_larger_room_00390625_26511_Classic_Hor
        PictureBox1.Location = New Point(0, 206)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1116, 736)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("JetBrains Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(365, 64)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 43)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME TO"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(loginBtn)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1116, 170)
        Panel1.TabIndex = 2
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(26), CByte(10))
        loginBtn.ForeColor = SystemColors.ControlText
        loginBtn.Location = New Point(992, 47)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(112, 34)
        loginBtn.TabIndex = 5
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("JetBrains Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(487, 109)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(361, 43)
        Label4.TabIndex = 3
        Label4.Text = "HOTEL RITZ CARLTON"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Olive
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TentangKamiToolStripMenuItem, BantuanToolStripMenuItem, BantuanToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1116, 33)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TentangKamiToolStripMenuItem
        ' 
        TentangKamiToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        TentangKamiToolStripMenuItem.Name = "TentangKamiToolStripMenuItem"
        TentangKamiToolStripMenuItem.Size = New Size(134, 29)
        TentangKamiToolStripMenuItem.Text = "Tentang Kami"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BuatReservasiToolStripMenuItem, CetakBuktiToolStripMenuItem})
        BantuanToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(100, 29)
        BantuanToolStripMenuItem.Text = "Reservasi"
        ' 
        ' BuatReservasiToolStripMenuItem
        ' 
        BuatReservasiToolStripMenuItem.Name = "BuatReservasiToolStripMenuItem"
        BuatReservasiToolStripMenuItem.Size = New Size(226, 34)
        BuatReservasiToolStripMenuItem.Text = "Buat Reservasi"
        ' 
        ' CetakBuktiToolStripMenuItem
        ' 
        CetakBuktiToolStripMenuItem.Name = "CetakBuktiToolStripMenuItem"
        CetakBuktiToolStripMenuItem.Size = New Size(226, 34)
        CetakBuktiToolStripMenuItem.Text = "Cetak Bukti"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(92, 29)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("JetBrains Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(407, 329)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 43)
        Label2.TabIndex = 6
        ' 
        ' menuUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1116, 942)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "menuUser"
        Text = "menuUser"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TentangKamiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatReservasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakBuktiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents loginBtn As Button
    Friend WithEvents Label2 As Label
End Class
