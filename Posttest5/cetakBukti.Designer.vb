<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cetakBukti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cetakBukti))
        Label8 = New Label()
        stripMenu = New MenuStrip()
        LandingToolStripMenuItem = New ToolStripMenuItem()
        RiwayatToolStripMenuItem = New ToolStripMenuItem()
        BuatReservasiToolStripMenuItem = New ToolStripMenuItem()
        CetakBuktiToolStripMenuItem = New ToolStripMenuItem()
        ReservasiToolStripMenuItem = New ToolStripMenuItem()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        stripMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Wheat
        Label8.Font = New Font("Calisto MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(220, 56)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(773, 50)
        Label8.TabIndex = 21
        Label8.Text = "CETAK BUKTI RESERVASI HOTEL"
        ' 
        ' stripMenu
        ' 
        stripMenu.BackColor = Color.Olive
        stripMenu.BackgroundImageLayout = ImageLayout.Stretch
        stripMenu.ImageScalingSize = New Size(24, 24)
        stripMenu.Items.AddRange(New ToolStripItem() {LandingToolStripMenuItem, RiwayatToolStripMenuItem, ReservasiToolStripMenuItem})
        stripMenu.Location = New Point(0, 0)
        stripMenu.Name = "stripMenu"
        stripMenu.Size = New Size(1191, 33)
        stripMenu.TabIndex = 26
        stripMenu.Text = "MenuStrip1"
        ' 
        ' LandingToolStripMenuItem
        ' 
        LandingToolStripMenuItem.ForeColor = SystemColors.ButtonFace
        LandingToolStripMenuItem.Name = "LandingToolStripMenuItem"
        LandingToolStripMenuItem.Size = New Size(91, 29)
        LandingToolStripMenuItem.Text = "Landing"
        ' 
        ' RiwayatToolStripMenuItem
        ' 
        RiwayatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BuatReservasiToolStripMenuItem, CetakBuktiToolStripMenuItem})
        RiwayatToolStripMenuItem.ForeColor = SystemColors.ButtonFace
        RiwayatToolStripMenuItem.Name = "RiwayatToolStripMenuItem"
        RiwayatToolStripMenuItem.Size = New Size(100, 29)
        RiwayatToolStripMenuItem.Text = "Reservasi"
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
        ' ReservasiToolStripMenuItem
        ' 
        ReservasiToolStripMenuItem.ForeColor = SystemColors.ButtonFace
        ReservasiToolStripMenuItem.Name = "ReservasiToolStripMenuItem"
        ReservasiToolStripMenuItem.Size = New Size(92, 29)
        ReservasiToolStripMenuItem.Text = "Bantuan"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.FloralWhite
        FlowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D
        FlowLayoutPanel1.Location = New Point(146, 142)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(946, 674)
        FlowLayoutPanel1.TabIndex = 27
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' cetakBukti
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        BackgroundImage = My.Resources.Resources.rz_jktrt_larger_room_00390625_26511_Classic_Hor
        ClientSize = New Size(1191, 870)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(stripMenu)
        Controls.Add(Label8)
        Margin = New Padding(4, 5, 4, 5)
        Name = "cetakBukti"
        Text = "Reservasi"
        stripMenu.ResumeLayout(False)
        stripMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents stripMenu As MenuStrip
    Friend WithEvents LandingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiwayatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BuatReservasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakBuktiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
