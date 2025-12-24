<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProdukGambar
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.pbProduk = New System.Windows.Forms.PictureBox()
        Me.mtbHarga = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbNoRak = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbGambar = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbNama = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.mbClose = New MaterialSkin.Controls.MaterialButton()
        Me.mbSimpan = New MaterialSkin.Controls.MaterialButton()
        Me.mbElipsis = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.pbProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.pbProduk)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(17, 78)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(284, 355)
        Me.MaterialCard1.TabIndex = 0
        '
        'pbProduk
        '
        Me.pbProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbProduk.Location = New System.Drawing.Point(14, 14)
        Me.pbProduk.Name = "pbProduk"
        Me.pbProduk.Size = New System.Drawing.Size(256, 327)
        Me.pbProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProduk.TabIndex = 0
        Me.pbProduk.TabStop = False
        '
        'mtbHarga
        '
        Me.mtbHarga.AnimateReadOnly = False
        Me.mtbHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbHarga.Depth = 0
        Me.mtbHarga.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbHarga.LeadingIcon = Nothing
        Me.mtbHarga.Location = New System.Drawing.Point(415, 186)
        Me.mtbHarga.MaxLength = 50
        Me.mtbHarga.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbHarga.Multiline = False
        Me.mtbHarga.Name = "mtbHarga"
        Me.mtbHarga.Size = New System.Drawing.Size(272, 50)
        Me.mtbHarga.TabIndex = 17
        Me.mtbHarga.Text = ""
        Me.mtbHarga.TrailingIcon = Nothing
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel7.Location = New System.Drawing.Point(318, 199)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(55, 24)
        Me.MaterialLabel7.TabIndex = 16
        Me.MaterialLabel7.Text = "Harga"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel6.Location = New System.Drawing.Point(316, 105)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(54, 24)
        Me.MaterialLabel6.TabIndex = 14
        Me.MaterialLabel6.Text = "Nama"
        '
        'mtbNoRak
        '
        Me.mtbNoRak.AnimateReadOnly = False
        Me.mtbNoRak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNoRak.Depth = 0
        Me.mtbNoRak.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbNoRak.LeadingIcon = Nothing
        Me.mtbNoRak.Location = New System.Drawing.Point(415, 242)
        Me.mtbNoRak.MaxLength = 50
        Me.mtbNoRak.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbNoRak.Multiline = False
        Me.mtbNoRak.Name = "mtbNoRak"
        Me.mtbNoRak.Size = New System.Drawing.Size(116, 50)
        Me.mtbNoRak.TabIndex = 19
        Me.mtbNoRak.Text = ""
        Me.mtbNoRak.TrailingIcon = Nothing
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel5.Location = New System.Drawing.Point(318, 255)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(64, 24)
        Me.MaterialLabel5.TabIndex = 18
        Me.MaterialLabel5.Text = "No Rak"
        '
        'mtbGambar
        '
        Me.mtbGambar.AnimateReadOnly = False
        Me.mtbGambar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbGambar.Depth = 0
        Me.mtbGambar.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbGambar.LeadingIcon = Nothing
        Me.mtbGambar.Location = New System.Drawing.Point(415, 298)
        Me.mtbGambar.MaxLength = 50
        Me.mtbGambar.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbGambar.Multiline = False
        Me.mtbGambar.Name = "mtbGambar"
        Me.mtbGambar.Size = New System.Drawing.Size(295, 50)
        Me.mtbGambar.TabIndex = 21
        Me.mtbGambar.Text = ""
        Me.mtbGambar.TrailingIcon = Nothing
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel1.Location = New System.Drawing.Point(318, 311)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(72, 24)
        Me.MaterialLabel1.TabIndex = 20
        Me.MaterialLabel1.Text = "Gambar"
        '
        'mtbNama
        '
        Me.mtbNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtbNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNama.Depth = 0
        Me.mtbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtbNama.Location = New System.Drawing.Point(413, 98)
        Me.mtbNama.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtbNama.Name = "mtbNama"
        Me.mtbNama.Size = New System.Drawing.Size(371, 71)
        Me.mtbNama.TabIndex = 22
        Me.mtbNama.Text = ""
        '
        'mbClose
        '
        Me.mbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbClose.Depth = 0
        Me.mbClose.HighEmphasis = True
        Me.mbClose.Icon = Nothing
        Me.mbClose.Location = New System.Drawing.Point(718, 405)
        Me.mbClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbClose.Name = "mbClose"
        Me.mbClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbClose.Size = New System.Drawing.Size(66, 36)
        Me.mbClose.TabIndex = 23
        Me.mbClose.Text = "CLOSE"
        Me.mbClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbClose.UseAccentColor = False
        Me.mbClose.UseVisualStyleBackColor = True
        '
        'mbSimpan
        '
        Me.mbSimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbSimpan.Depth = 0
        Me.mbSimpan.HighEmphasis = True
        Me.mbSimpan.Icon = Nothing
        Me.mbSimpan.Location = New System.Drawing.Point(633, 405)
        Me.mbSimpan.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbSimpan.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbSimpan.Name = "mbSimpan"
        Me.mbSimpan.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbSimpan.Size = New System.Drawing.Size(77, 36)
        Me.mbSimpan.TabIndex = 24
        Me.mbSimpan.Text = "SIMPAN"
        Me.mbSimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbSimpan.UseAccentColor = False
        Me.mbSimpan.UseVisualStyleBackColor = True
        '
        'mbElipsis
        '
        Me.mbElipsis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbElipsis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbElipsis.Depth = 0
        Me.mbElipsis.HighEmphasis = True
        Me.mbElipsis.Icon = Nothing
        Me.mbElipsis.Location = New System.Drawing.Point(720, 304)
        Me.mbElipsis.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbElipsis.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbElipsis.Name = "mbElipsis"
        Me.mbElipsis.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbElipsis.Size = New System.Drawing.Size(64, 36)
        Me.mbElipsis.TabIndex = 25
        Me.mbElipsis.Text = "..."
        Me.mbElipsis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbElipsis.UseAccentColor = False
        Me.mbElipsis.UseVisualStyleBackColor = True
        '
        'frmProdukGambar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mbElipsis)
        Me.Controls.Add(Me.mbSimpan)
        Me.Controls.Add(Me.mbClose)
        Me.Controls.Add(Me.mtbNama)
        Me.Controls.Add(Me.mtbGambar)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.mtbNoRak)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.mtbHarga)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdukGambar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | Pilih Gambar"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.pbProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pbProduk As PictureBox
    Friend WithEvents mtbHarga As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbNoRak As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbGambar As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbNama As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents mbClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mbSimpan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mbElipsis As MaterialSkin.Controls.MaterialButton
End Class
