<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetailProduk
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
        Me.mbClose = New MaterialSkin.Controls.MaterialButton()
        Me.mtbNama = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbNoRak = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbHarga = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.pbProduk = New System.Windows.Forms.PictureBox()
        Me.mtbJumlah = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.mcbSupplier = New MaterialSkin.Controls.MaterialComboBox()
        Me.mcbKategori = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.pbProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mbClose
        '
        Me.mbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbClose.Depth = 0
        Me.mbClose.HighEmphasis = True
        Me.mbClose.Icon = Nothing
        Me.mbClose.Location = New System.Drawing.Point(727, 429)
        Me.mbClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbClose.Name = "mbClose"
        Me.mbClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbClose.Size = New System.Drawing.Size(66, 36)
        Me.mbClose.TabIndex = 35
        Me.mbClose.Text = "CLOSE"
        Me.mbClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbClose.UseAccentColor = False
        Me.mbClose.UseVisualStyleBackColor = True
        '
        'mtbNama
        '
        Me.mtbNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtbNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNama.Depth = 0
        Me.mtbNama.Enabled = False
        Me.mtbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtbNama.Location = New System.Drawing.Point(413, 98)
        Me.mtbNama.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtbNama.Name = "mtbNama"
        Me.mtbNama.ReadOnly = True
        Me.mtbNama.Size = New System.Drawing.Size(380, 71)
        Me.mtbNama.TabIndex = 34
        Me.mtbNama.Text = ""
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
        Me.MaterialLabel1.Size = New System.Drawing.Size(77, 24)
        Me.MaterialLabel1.TabIndex = 32
        Me.MaterialLabel1.Text = "Kategori"
        '
        'mtbNoRak
        '
        Me.mtbNoRak.AnimateReadOnly = False
        Me.mtbNoRak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNoRak.Depth = 0
        Me.mtbNoRak.Enabled = False
        Me.mtbNoRak.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbNoRak.LeadingIcon = Nothing
        Me.mtbNoRak.Location = New System.Drawing.Point(415, 242)
        Me.mtbNoRak.MaxLength = 50
        Me.mtbNoRak.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbNoRak.Multiline = False
        Me.mtbNoRak.Name = "mtbNoRak"
        Me.mtbNoRak.ReadOnly = True
        Me.mtbNoRak.Size = New System.Drawing.Size(116, 50)
        Me.mtbNoRak.TabIndex = 31
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
        Me.MaterialLabel5.TabIndex = 30
        Me.MaterialLabel5.Text = "No Rak"
        '
        'mtbHarga
        '
        Me.mtbHarga.AnimateReadOnly = False
        Me.mtbHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbHarga.Depth = 0
        Me.mtbHarga.Enabled = False
        Me.mtbHarga.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbHarga.LeadingIcon = Nothing
        Me.mtbHarga.Location = New System.Drawing.Point(415, 186)
        Me.mtbHarga.MaxLength = 50
        Me.mtbHarga.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbHarga.Multiline = False
        Me.mtbHarga.Name = "mtbHarga"
        Me.mtbHarga.ReadOnly = True
        Me.mtbHarga.Size = New System.Drawing.Size(378, 50)
        Me.mtbHarga.TabIndex = 29
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
        Me.MaterialLabel7.TabIndex = 28
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
        Me.MaterialLabel6.TabIndex = 27
        Me.MaterialLabel6.Text = "Nama"
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
        Me.MaterialCard1.TabIndex = 26
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
        'mtbJumlah
        '
        Me.mtbJumlah.AnimateReadOnly = False
        Me.mtbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbJumlah.Depth = 0
        Me.mtbJumlah.Enabled = False
        Me.mtbJumlah.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbJumlah.LeadingIcon = Nothing
        Me.mtbJumlah.Location = New System.Drawing.Point(653, 242)
        Me.mtbJumlah.MaxLength = 50
        Me.mtbJumlah.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbJumlah.Multiline = False
        Me.mtbJumlah.Name = "mtbJumlah"
        Me.mtbJumlah.ReadOnly = True
        Me.mtbJumlah.Size = New System.Drawing.Size(140, 50)
        Me.mtbJumlah.TabIndex = 37
        Me.mtbJumlah.Text = ""
        Me.mtbJumlah.TrailingIcon = Nothing
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel2.Location = New System.Drawing.Point(556, 255)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(67, 24)
        Me.MaterialLabel2.TabIndex = 36
        Me.MaterialLabel2.Text = "Jumlah"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel3.Location = New System.Drawing.Point(316, 367)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(74, 24)
        Me.MaterialLabel3.TabIndex = 38
        Me.MaterialLabel3.Text = "Supplier"
        '
        'mcbSupplier
        '
        Me.mcbSupplier.AutoResize = False
        Me.mcbSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mcbSupplier.Depth = 0
        Me.mcbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.mcbSupplier.DropDownHeight = 174
        Me.mcbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mcbSupplier.DropDownWidth = 121
        Me.mcbSupplier.Enabled = False
        Me.mcbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.mcbSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcbSupplier.FormattingEnabled = True
        Me.mcbSupplier.IntegralHeight = False
        Me.mcbSupplier.ItemHeight = 43
        Me.mcbSupplier.Location = New System.Drawing.Point(415, 353)
        Me.mcbSupplier.MaxDropDownItems = 4
        Me.mcbSupplier.MouseState = MaterialSkin.MouseState.OUT
        Me.mcbSupplier.Name = "mcbSupplier"
        Me.mcbSupplier.Size = New System.Drawing.Size(378, 49)
        Me.mcbSupplier.StartIndex = 0
        Me.mcbSupplier.TabIndex = 40
        '
        'mcbKategori
        '
        Me.mcbKategori.AutoResize = False
        Me.mcbKategori.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mcbKategori.Depth = 0
        Me.mcbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.mcbKategori.DropDownHeight = 174
        Me.mcbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mcbKategori.DropDownWidth = 121
        Me.mcbKategori.Enabled = False
        Me.mcbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.mcbKategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcbKategori.FormattingEnabled = True
        Me.mcbKategori.IntegralHeight = False
        Me.mcbKategori.ItemHeight = 43
        Me.mcbKategori.Location = New System.Drawing.Point(415, 298)
        Me.mcbKategori.MaxDropDownItems = 4
        Me.mcbKategori.MouseState = MaterialSkin.MouseState.OUT
        Me.mcbKategori.Name = "mcbKategori"
        Me.mcbKategori.Size = New System.Drawing.Size(378, 49)
        Me.mcbKategori.StartIndex = 0
        Me.mcbKategori.TabIndex = 39
        '
        'frmDetailProduk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 474)
        Me.Controls.Add(Me.mcbSupplier)
        Me.Controls.Add(Me.mcbKategori)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.mtbJumlah)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.mbClose)
        Me.Controls.Add(Me.mtbNama)
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
        Me.Name = "frmDetailProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | Detail Produk"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.pbProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mbClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mtbNama As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbNoRak As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbHarga As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pbProduk As PictureBox
    Friend WithEvents mtbJumlah As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mcbSupplier As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents mcbKategori As MaterialSkin.Controls.MaterialComboBox
End Class
