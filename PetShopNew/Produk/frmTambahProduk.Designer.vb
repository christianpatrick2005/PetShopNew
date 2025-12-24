<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTambahProduk
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.mcbKategori = New MaterialSkin.Controls.MaterialComboBox()
        Me.mcbSupplier = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbNoRak = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbJumlah = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbHarga = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbNama = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.btnTambah = New MaterialSkin.Controls.MaterialButton()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.Location = New System.Drawing.Point(17, 76)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(170, 29)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Tambah Produk"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(6, 108)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(783, 10)
        Me.MaterialDivider1.TabIndex = 1
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel2.Location = New System.Drawing.Point(18, 137)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(77, 24)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Kategori"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel3.Location = New System.Drawing.Point(18, 188)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(74, 24)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "Supplier"
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
        Me.mcbKategori.Location = New System.Drawing.Point(115, 124)
        Me.mcbKategori.MaxDropDownItems = 4
        Me.mcbKategori.MouseState = MaterialSkin.MouseState.OUT
        Me.mcbKategori.Name = "mcbKategori"
        Me.mcbKategori.Size = New System.Drawing.Size(272, 49)
        Me.mcbKategori.StartIndex = 0
        Me.mcbKategori.TabIndex = 4
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
        Me.mcbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.mcbSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcbSupplier.FormattingEnabled = True
        Me.mcbSupplier.IntegralHeight = False
        Me.mcbSupplier.ItemHeight = 43
        Me.mcbSupplier.Location = New System.Drawing.Point(115, 179)
        Me.mcbSupplier.MaxDropDownItems = 4
        Me.mcbSupplier.MouseState = MaterialSkin.MouseState.OUT
        Me.mcbSupplier.Name = "mcbSupplier"
        Me.mcbSupplier.Size = New System.Drawing.Size(272, 49)
        Me.mcbSupplier.StartIndex = 0
        Me.mcbSupplier.TabIndex = 5
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel4.Location = New System.Drawing.Point(18, 247)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(54, 24)
        Me.MaterialLabel4.TabIndex = 6
        Me.MaterialLabel4.Text = "Nama"
        '
        'mtbNoRak
        '
        Me.mtbNoRak.AnimateReadOnly = False
        Me.mtbNoRak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNoRak.Depth = 0
        Me.mtbNoRak.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbNoRak.LeadingIcon = Nothing
        Me.mtbNoRak.Location = New System.Drawing.Point(115, 370)
        Me.mtbNoRak.MaxLength = 50
        Me.mtbNoRak.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbNoRak.Multiline = False
        Me.mtbNoRak.Name = "mtbNoRak"
        Me.mtbNoRak.Size = New System.Drawing.Size(116, 50)
        Me.mtbNoRak.TabIndex = 9
        Me.mtbNoRak.Text = ""
        Me.mtbNoRak.TrailingIcon = Nothing
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel5.Location = New System.Drawing.Point(18, 383)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(64, 24)
        Me.MaterialLabel5.TabIndex = 8
        Me.MaterialLabel5.Text = "No Rak"
        '
        'mtbJumlah
        '
        Me.mtbJumlah.AnimateReadOnly = False
        Me.mtbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbJumlah.Depth = 0
        Me.mtbJumlah.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbJumlah.LeadingIcon = Nothing
        Me.mtbJumlah.Location = New System.Drawing.Point(507, 124)
        Me.mtbJumlah.MaxLength = 50
        Me.mtbJumlah.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbJumlah.Multiline = False
        Me.mtbJumlah.Name = "mtbJumlah"
        Me.mtbJumlah.Size = New System.Drawing.Size(272, 50)
        Me.mtbJumlah.TabIndex = 11
        Me.mtbJumlah.Text = ""
        Me.mtbJumlah.TrailingIcon = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel6.Location = New System.Drawing.Point(410, 137)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(67, 24)
        Me.MaterialLabel6.TabIndex = 10
        Me.MaterialLabel6.Text = "Jumlah"
        '
        'mtbHarga
        '
        Me.mtbHarga.AnimateReadOnly = False
        Me.mtbHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbHarga.Depth = 0
        Me.mtbHarga.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbHarga.LeadingIcon = Nothing
        Me.mtbHarga.Location = New System.Drawing.Point(507, 180)
        Me.mtbHarga.MaxLength = 50
        Me.mtbHarga.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbHarga.Multiline = False
        Me.mtbHarga.Name = "mtbHarga"
        Me.mtbHarga.Size = New System.Drawing.Size(272, 50)
        Me.mtbHarga.TabIndex = 13
        Me.mtbHarga.Text = ""
        Me.mtbHarga.TrailingIcon = Nothing
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel7.Location = New System.Drawing.Point(410, 193)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(55, 24)
        Me.MaterialLabel7.TabIndex = 12
        Me.MaterialLabel7.Text = "Harga"
        '
        'mtbNama
        '
        Me.mtbNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtbNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNama.Depth = 0
        Me.mtbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtbNama.Location = New System.Drawing.Point(115, 247)
        Me.mtbNama.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtbNama.Name = "mtbNama"
        Me.mtbNama.Size = New System.Drawing.Size(664, 112)
        Me.mtbNama.TabIndex = 14
        Me.mtbNama.Text = ""
        '
        'btnTambah
        '
        Me.btnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTambah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnTambah.Depth = 0
        Me.btnTambah.HighEmphasis = True
        Me.btnTambah.Icon = Nothing
        Me.btnTambah.Location = New System.Drawing.Point(607, 443)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTambah.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnTambah.Size = New System.Drawing.Size(82, 36)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnTambah.UseAccentColor = False
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Nothing
        Me.btnClose.Location = New System.Drawing.Point(697, 443)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(66, 36)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnClose.UseAccentColor = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmTambahProduk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.mtbNama)
        Me.Controls.Add(Me.mtbHarga)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.mtbJumlah)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.mtbNoRak)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.mcbSupplier)
        Me.Controls.Add(Me.mcbKategori)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTambahProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | Tambah Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mcbKategori As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents mcbSupplier As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbNoRak As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbJumlah As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbHarga As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbNama As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents btnTambah As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
End Class
