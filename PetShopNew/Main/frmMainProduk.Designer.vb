<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainProduk
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.mcbKategori = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.mtbSearch = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.dgvDaftarProduk = New System.Windows.Forms.DataGridView()
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
        Me.mbTambah = New MaterialSkin.Controls.MaterialButton()
        Me.mbClose = New MaterialSkin.Controls.MaterialButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GambarProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Cetak = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.dgvDaftarProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel2.Location = New System.Drawing.Point(752, 76)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(75, 29)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "Search"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.Location = New System.Drawing.Point(353, 76)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(91, 29)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "Kategori"
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.mcbKategori)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(344, 109)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(334, 74)
        Me.MaterialCard3.TabIndex = 9
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
        Me.mcbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.mcbKategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcbKategori.FormattingEnabled = True
        Me.mcbKategori.IntegralHeight = False
        Me.mcbKategori.ItemHeight = 43
        Me.mcbKategori.Location = New System.Drawing.Point(14, 14)
        Me.mcbKategori.MaxDropDownItems = 4
        Me.mcbKategori.MouseState = MaterialSkin.MouseState.OUT
        Me.mcbKategori.Name = "mcbKategori"
        Me.mcbKategori.Size = New System.Drawing.Size(303, 49)
        Me.mcbKategori.StartIndex = 0
        Me.mcbKategori.TabIndex = 0
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.mtbSearch)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(735, 109)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(405, 74)
        Me.MaterialCard2.TabIndex = 8
        '
        'mtbSearch
        '
        Me.mtbSearch.AnimateReadOnly = False
        Me.mtbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbSearch.Depth = 0
        Me.mtbSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtbSearch.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbSearch.LeadingIcon = Nothing
        Me.mtbSearch.Location = New System.Drawing.Point(14, 14)
        Me.mtbSearch.MaxLength = 50
        Me.mtbSearch.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbSearch.Multiline = False
        Me.mtbSearch.Name = "mtbSearch"
        Me.mtbSearch.Size = New System.Drawing.Size(377, 50)
        Me.mtbSearch.TabIndex = 0
        Me.mtbSearch.Text = ""
        Me.mtbSearch.TrailingIcon = Nothing
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.dgvDaftarProduk)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(18, 207)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(1122, 327)
        Me.MaterialCard1.TabIndex = 7
        '
        'dgvDaftarProduk
        '
        Me.dgvDaftarProduk.AllowUserToAddRows = False
        Me.dgvDaftarProduk.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDaftarProduk.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDaftarProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProdukCol, Me.KategoriProdukIntCol, Me.SupplierProdukIntCol, Me.NamaProdukCol, Me.KategoriProdukCol, Me.JumlahProdukCol, Me.SupplierProdukCol, Me.NoRakProdukCol, Me.HargaCol, Me.StatusCol})
        Me.dgvDaftarProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDaftarProduk.EnableHeadersVisualStyles = False
        Me.dgvDaftarProduk.Location = New System.Drawing.Point(14, 14)
        Me.dgvDaftarProduk.MultiSelect = False
        Me.dgvDaftarProduk.Name = "dgvDaftarProduk"
        Me.dgvDaftarProduk.ReadOnly = True
        Me.dgvDaftarProduk.RowHeadersVisible = False
        Me.dgvDaftarProduk.RowHeadersWidth = 51
        Me.dgvDaftarProduk.RowTemplate.Height = 24
        Me.dgvDaftarProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaftarProduk.Size = New System.Drawing.Size(1094, 299)
        Me.dgvDaftarProduk.TabIndex = 0
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
        'mbTambah
        '
        Me.mbTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbTambah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbTambah.Depth = 0
        Me.mbTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mbTambah.HighEmphasis = True
        Me.mbTambah.Icon = Nothing
        Me.mbTambah.Location = New System.Drawing.Point(968, 554)
        Me.mbTambah.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbTambah.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbTambah.Name = "mbTambah"
        Me.mbTambah.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbTambah.Size = New System.Drawing.Size(82, 36)
        Me.mbTambah.TabIndex = 14
        Me.mbTambah.Text = "Tambah"
        Me.mbTambah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbTambah.UseAccentColor = False
        Me.mbTambah.UseVisualStyleBackColor = True
        '
        'mbClose
        '
        Me.mbClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.mbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbClose.Depth = 0
        Me.mbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mbClose.HighEmphasis = True
        Me.mbClose.Icon = Nothing
        Me.mbClose.Location = New System.Drawing.Point(1074, 554)
        Me.mbClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbClose.Name = "mbClose"
        Me.mbClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbClose.Size = New System.Drawing.Size(66, 36)
        Me.mbClose.TabIndex = 13
        Me.mbClose.Text = "Close"
        Me.mbClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbClose.UseAccentColor = False
        Me.mbClose.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahProdukToolStripMenuItem, Me.UpdateProdukToolStripMenuItem, Me.DeleteProdukToolStripMenuItem, Me.ToolStripSeparator1, Me.GambarProdukToolStripMenuItem, Me.DetailProdukToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 130)
        '
        'TambahProdukToolStripMenuItem
        '
        Me.TambahProdukToolStripMenuItem.Name = "TambahProdukToolStripMenuItem"
        Me.TambahProdukToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.TambahProdukToolStripMenuItem.Text = "Tambah Produk"
        '
        'UpdateProdukToolStripMenuItem
        '
        Me.UpdateProdukToolStripMenuItem.Name = "UpdateProdukToolStripMenuItem"
        Me.UpdateProdukToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.UpdateProdukToolStripMenuItem.Text = "Update Produk"
        '
        'DeleteProdukToolStripMenuItem
        '
        Me.DeleteProdukToolStripMenuItem.Name = "DeleteProdukToolStripMenuItem"
        Me.DeleteProdukToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.DeleteProdukToolStripMenuItem.Text = "Delete Produk"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'GambarProdukToolStripMenuItem
        '
        Me.GambarProdukToolStripMenuItem.Name = "GambarProdukToolStripMenuItem"
        Me.GambarProdukToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.GambarProdukToolStripMenuItem.Text = "Gambar Produk"
        '
        'DetailProdukToolStripMenuItem
        '
        Me.DetailProdukToolStripMenuItem.Name = "DetailProdukToolStripMenuItem"
        Me.DetailProdukToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.DetailProdukToolStripMenuItem.Text = "Detail Produk"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PetShopNew.My.Resources.Resources.Screenshot_2025_09_30_193827
        Me.PictureBox1.Location = New System.Drawing.Point(18, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_Cetak
        '
        Me.btn_Cetak.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Cetak.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_Cetak.Depth = 0
        Me.btn_Cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cetak.HighEmphasis = True
        Me.btn_Cetak.Icon = Nothing
        Me.btn_Cetak.Location = New System.Drawing.Point(18, 557)
        Me.btn_Cetak.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_Cetak.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_Cetak.Size = New System.Drawing.Size(138, 36)
        Me.btn_Cetak.TabIndex = 19
        Me.btn_Cetak.Text = "Cetak Laporan"
        Me.btn_Cetak.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_Cetak.UseAccentColor = False
        Me.btn_Cetak.UseVisualStyleBackColor = True
        '
        'frmMainProduk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1158, 611)
        Me.Controls.Add(Me.btn_Cetak)
        Me.Controls.Add(Me.mbTambah)
        Me.Controls.Add(Me.mbClose)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialCard3)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMASI PRODUK"
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.dgvDaftarProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents mcbKategori As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents mtbSearch As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents dgvDaftarProduk As DataGridView
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
    Friend WithEvents mbTambah As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mbClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TambahProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GambarProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_Cetak As MaterialSkin.Controls.MaterialButton
End Class
