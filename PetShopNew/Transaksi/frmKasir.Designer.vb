<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKasir
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.IdProdukCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriProdukIntCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierProdukIntCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaProdukCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriProdukCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahProdukCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierProdukCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoRakProdukCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.dgvPesanan = New System.Windows.Forms.DataGridView()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbTotal = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnMasuk = New MaterialSkin.Controls.MaterialButton()
        Me.btnOut = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.nupJumlah = New System.Windows.Forms.NumericUpDown()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbPembayaran = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbKembalian = New MaterialSkin.Controls.MaterialTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tbNoNota = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.mbtnLog = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.dgvProduk)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(17, 126)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(573, 395)
        Me.MaterialCard1.TabIndex = 0
        '
        'dgvProduk
        '
        Me.dgvProduk.AllowUserToAddRows = False
        Me.dgvProduk.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvProduk.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProdukCol, Me.KategoriProdukIntCol, Me.SupplierProdukIntCol, Me.NamaProdukCol, Me.KategoriProdukCol, Me.JumlahProdukCol, Me.SupplierProdukCol, Me.NoRakProdukCol, Me.HargaCol, Me.StatusCol})
        Me.dgvProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduk.EnableHeadersVisualStyles = False
        Me.dgvProduk.Location = New System.Drawing.Point(14, 14)
        Me.dgvProduk.MultiSelect = False
        Me.dgvProduk.Name = "dgvProduk"
        Me.dgvProduk.ReadOnly = True
        Me.dgvProduk.RowHeadersVisible = False
        Me.dgvProduk.RowHeadersWidth = 51
        Me.dgvProduk.RowTemplate.Height = 24
        Me.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduk.Size = New System.Drawing.Size(545, 367)
        Me.dgvProduk.TabIndex = 1
        '
        'IdProdukCol
        '
        Me.IdProdukCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IdProdukCol.DataPropertyName = "IdProduk"
        Me.IdProdukCol.HeaderText = "ID"
        Me.IdProdukCol.MinimumWidth = 6
        Me.IdProdukCol.Name = "IdProdukCol"
        Me.IdProdukCol.ReadOnly = True
        Me.IdProdukCol.Visible = False
        Me.IdProdukCol.Width = 125
        '
        'KategoriProdukIntCol
        '
        Me.KategoriProdukIntCol.DataPropertyName = "IdKategoriProduk"
        Me.KategoriProdukIntCol.HeaderText = "Id Kategori"
        Me.KategoriProdukIntCol.MinimumWidth = 6
        Me.KategoriProdukIntCol.Name = "KategoriProdukIntCol"
        Me.KategoriProdukIntCol.ReadOnly = True
        Me.KategoriProdukIntCol.Visible = False
        Me.KategoriProdukIntCol.Width = 125
        '
        'SupplierProdukIntCol
        '
        Me.SupplierProdukIntCol.DataPropertyName = "IdSupplierProduk"
        Me.SupplierProdukIntCol.HeaderText = "Id Supplier"
        Me.SupplierProdukIntCol.MinimumWidth = 6
        Me.SupplierProdukIntCol.Name = "SupplierProdukIntCol"
        Me.SupplierProdukIntCol.ReadOnly = True
        Me.SupplierProdukIntCol.Visible = False
        Me.SupplierProdukIntCol.Width = 125
        '
        'NamaProdukCol
        '
        Me.NamaProdukCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaProdukCol.DataPropertyName = "NamaProduk"
        Me.NamaProdukCol.HeaderText = "Nama Produk"
        Me.NamaProdukCol.MinimumWidth = 6
        Me.NamaProdukCol.Name = "NamaProdukCol"
        Me.NamaProdukCol.ReadOnly = True
        '
        'KategoriProdukCol
        '
        Me.KategoriProdukCol.DataPropertyName = "KategoriProduk"
        Me.KategoriProdukCol.HeaderText = "Kategori"
        Me.KategoriProdukCol.MinimumWidth = 6
        Me.KategoriProdukCol.Name = "KategoriProdukCol"
        Me.KategoriProdukCol.ReadOnly = True
        Me.KategoriProdukCol.Visible = False
        Me.KategoriProdukCol.Width = 125
        '
        'JumlahProdukCol
        '
        Me.JumlahProdukCol.DataPropertyName = "JumlahProduk"
        Me.JumlahProdukCol.HeaderText = "Jumlah"
        Me.JumlahProdukCol.MinimumWidth = 6
        Me.JumlahProdukCol.Name = "JumlahProdukCol"
        Me.JumlahProdukCol.ReadOnly = True
        Me.JumlahProdukCol.Width = 125
        '
        'SupplierProdukCol
        '
        Me.SupplierProdukCol.DataPropertyName = "SupplierProduk"
        Me.SupplierProdukCol.HeaderText = "Supplier"
        Me.SupplierProdukCol.MinimumWidth = 6
        Me.SupplierProdukCol.Name = "SupplierProdukCol"
        Me.SupplierProdukCol.ReadOnly = True
        Me.SupplierProdukCol.Visible = False
        Me.SupplierProdukCol.Width = 125
        '
        'NoRakProdukCol
        '
        Me.NoRakProdukCol.DataPropertyName = "NoRakProduk"
        Me.NoRakProdukCol.HeaderText = "Nomor Rak"
        Me.NoRakProdukCol.MinimumWidth = 6
        Me.NoRakProdukCol.Name = "NoRakProdukCol"
        Me.NoRakProdukCol.ReadOnly = True
        Me.NoRakProdukCol.Width = 125
        '
        'HargaCol
        '
        Me.HargaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HargaCol.DataPropertyName = "Harga"
        Me.HargaCol.FillWeight = 60.0!
        Me.HargaCol.HeaderText = "Harga "
        Me.HargaCol.MinimumWidth = 6
        Me.HargaCol.Name = "HargaCol"
        Me.HargaCol.ReadOnly = True
        '
        'StatusCol
        '
        Me.StatusCol.DataPropertyName = "StatusProduk"
        Me.StatusCol.FillWeight = 80.0!
        Me.StatusCol.HeaderText = "Status"
        Me.StatusCol.MinimumWidth = 6
        Me.StatusCol.Name = "StatusCol"
        Me.StatusCol.ReadOnly = True
        Me.StatusCol.Visible = False
        Me.StatusCol.Width = 125
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.Location = New System.Drawing.Point(22, 83)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(226, 29)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Produk yang tersedia"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.dgvPesanan)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(694, 126)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(552, 395)
        Me.MaterialCard2.TabIndex = 1
        '
        'dgvPesanan
        '
        Me.dgvPesanan.AllowUserToAddRows = False
        Me.dgvPesanan.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPesanan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPesanan.EnableHeadersVisualStyles = False
        Me.dgvPesanan.Location = New System.Drawing.Point(14, 14)
        Me.dgvPesanan.MultiSelect = False
        Me.dgvPesanan.Name = "dgvPesanan"
        Me.dgvPesanan.ReadOnly = True
        Me.dgvPesanan.RowHeadersVisible = False
        Me.dgvPesanan.RowHeadersWidth = 51
        Me.dgvPesanan.RowTemplate.Height = 24
        Me.dgvPesanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPesanan.Size = New System.Drawing.Size(524, 367)
        Me.dgvPesanan.TabIndex = 2
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel2.Location = New System.Drawing.Point(22, 544)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(154, 29)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Total Pesanan"
        '
        'tbTotal
        '
        Me.tbTotal.AnimateReadOnly = False
        Me.tbTotal.BackColor = System.Drawing.SystemColors.Control
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTotal.Depth = 0
        Me.tbTotal.Enabled = False
        Me.tbTotal.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbTotal.LeadingIcon = Nothing
        Me.tbTotal.Location = New System.Drawing.Point(182, 533)
        Me.tbTotal.MaxLength = 50
        Me.tbTotal.MouseState = MaterialSkin.MouseState.OUT
        Me.tbTotal.Multiline = False
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(408, 50)
        Me.tbTotal.TabIndex = 3
        Me.tbTotal.Text = ""
        Me.tbTotal.TrailingIcon = Nothing
        '
        'btnMasuk
        '
        Me.btnMasuk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMasuk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnMasuk.Depth = 0
        Me.btnMasuk.HighEmphasis = True
        Me.btnMasuk.Icon = Nothing
        Me.btnMasuk.Location = New System.Drawing.Point(612, 229)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnMasuk.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnMasuk.Size = New System.Drawing.Size(64, 36)
        Me.btnMasuk.TabIndex = 4
        Me.btnMasuk.Text = ">>"
        Me.btnMasuk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnMasuk.UseAccentColor = False
        Me.btnMasuk.UseVisualStyleBackColor = True
        '
        'btnOut
        '
        Me.btnOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnOut.Depth = 0
        Me.btnOut.HighEmphasis = True
        Me.btnOut.Icon = Nothing
        Me.btnOut.Location = New System.Drawing.Point(612, 343)
        Me.btnOut.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnOut.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOut.Name = "btnOut"
        Me.btnOut.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnOut.Size = New System.Drawing.Size(64, 36)
        Me.btnOut.TabIndex = 5
        Me.btnOut.Text = "<<"
        Me.btnOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnOut.UseAccentColor = False
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(951, 692)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(206, 36)
        Me.MaterialButton1.TabIndex = 6
        Me.MaterialButton1.Text = "Buat Pesanan dan Nota"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(1165, 692)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(67, 36)
        Me.MaterialButton2.TabIndex = 7
        Me.MaterialButton2.Text = "Batal"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel3.Location = New System.Drawing.Point(689, 83)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(223, 29)
        Me.MaterialLabel3.TabIndex = 8
        Me.MaterialLabel3.Text = "Produk yang dipesan"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel4.Location = New System.Drawing.Point(689, 544)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(80, 29)
        Me.MaterialLabel4.TabIndex = 9
        Me.MaterialLabel4.Text = "Jumlah"
        '
        'nupJumlah
        '
        Me.nupJumlah.Location = New System.Drawing.Point(786, 544)
        Me.nupJumlah.Name = "nupJumlah"
        Me.nupJumlah.Size = New System.Drawing.Size(460, 30)
        Me.nupJumlah.TabIndex = 10
        Me.nupJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel5.Location = New System.Drawing.Point(22, 619)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(230, 29)
        Me.MaterialLabel5.TabIndex = 11
        Me.MaterialLabel5.Text = "Nominal Pembayaran"
        '
        'tbPembayaran
        '
        Me.tbPembayaran.AnimateReadOnly = False
        Me.tbPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPembayaran.Depth = 0
        Me.tbPembayaran.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbPembayaran.LeadingIcon = Nothing
        Me.tbPembayaran.Location = New System.Drawing.Point(258, 608)
        Me.tbPembayaran.MaxLength = 50
        Me.tbPembayaran.MouseState = MaterialSkin.MouseState.OUT
        Me.tbPembayaran.Multiline = False
        Me.tbPembayaran.Name = "tbPembayaran"
        Me.tbPembayaran.Size = New System.Drawing.Size(332, 50)
        Me.tbPembayaran.TabIndex = 12
        Me.tbPembayaran.Text = "0"
        Me.tbPembayaran.TrailingIcon = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel6.Location = New System.Drawing.Point(22, 692)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(114, 29)
        Me.MaterialLabel6.TabIndex = 13
        Me.MaterialLabel6.Text = "Kembalian"
        '
        'tbKembalian
        '
        Me.tbKembalian.AnimateReadOnly = False
        Me.tbKembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbKembalian.Depth = 0
        Me.tbKembalian.Enabled = False
        Me.tbKembalian.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbKembalian.LeadingIcon = Nothing
        Me.tbKembalian.Location = New System.Drawing.Point(142, 681)
        Me.tbKembalian.MaxLength = 50
        Me.tbKembalian.MouseState = MaterialSkin.MouseState.OUT
        Me.tbKembalian.Multiline = False
        Me.tbKembalian.Name = "tbKembalian"
        Me.tbKembalian.ReadOnly = True
        Me.tbKembalian.Size = New System.Drawing.Size(448, 50)
        Me.tbKembalian.TabIndex = 14
        Me.tbKembalian.Text = ""
        Me.tbKembalian.TrailingIcon = Nothing
        '
        'tbNoNota
        '
        Me.tbNoNota.AnimateReadOnly = False
        Me.tbNoNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNoNota.Depth = 0
        Me.tbNoNota.Enabled = False
        Me.tbNoNota.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbNoNota.LeadingIcon = Nothing
        Me.tbNoNota.Location = New System.Drawing.Point(828, 598)
        Me.tbNoNota.MaxLength = 50
        Me.tbNoNota.MouseState = MaterialSkin.MouseState.OUT
        Me.tbNoNota.Multiline = False
        Me.tbNoNota.Name = "tbNoNota"
        Me.tbNoNota.Size = New System.Drawing.Size(418, 50)
        Me.tbNoNota.TabIndex = 16
        Me.tbNoNota.Text = ""
        Me.tbNoNota.TrailingIcon = Nothing
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel7.Location = New System.Drawing.Point(689, 609)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(133, 29)
        Me.MaterialLabel7.TabIndex = 15
        Me.MaterialLabel7.Text = "Nomor Nota"
        '
        'mbtnLog
        '
        Me.mbtnLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbtnLog.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbtnLog.Depth = 0
        Me.mbtnLog.HighEmphasis = True
        Me.mbtnLog.Icon = Nothing
        Me.mbtnLog.Location = New System.Drawing.Point(1126, 76)
        Me.mbtnLog.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbtnLog.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbtnLog.Name = "mbtnLog"
        Me.mbtnLog.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbtnLog.Size = New System.Drawing.Size(120, 36)
        Me.mbtnLog.TabIndex = 17
        Me.mbtnLog.Text = "Log Pesanan"
        Me.mbtnLog.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbtnLog.UseAccentColor = False
        Me.mbtnLog.UseVisualStyleBackColor = True
        '
        'frmKasir
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1263, 747)
        Me.Controls.Add(Me.mbtnLog)
        Me.Controls.Add(Me.tbNoNota)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.tbKembalian)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.tbPembayaran)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.nupJumlah)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialButton2)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | KASIR"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbTotal As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnMasuk As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnOut As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents nupJumlah As NumericUpDown
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbPembayaran As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbKembalian As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents IdProdukCol As DataGridViewTextBoxColumn
    Friend WithEvents KategoriProdukIntCol As DataGridViewTextBoxColumn
    Friend WithEvents SupplierProdukIntCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaProdukCol As DataGridViewTextBoxColumn
    Friend WithEvents KategoriProdukCol As DataGridViewTextBoxColumn
    Friend WithEvents JumlahProdukCol As DataGridViewTextBoxColumn
    Friend WithEvents SupplierProdukCol As DataGridViewTextBoxColumn
    Friend WithEvents NoRakProdukCol As DataGridViewTextBoxColumn
    Friend WithEvents HargaCol As DataGridViewTextBoxColumn
    Friend WithEvents StatusCol As DataGridViewTextBoxColumn
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbNoNota As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mbtnLog As MaterialSkin.Controls.MaterialButton
End Class
