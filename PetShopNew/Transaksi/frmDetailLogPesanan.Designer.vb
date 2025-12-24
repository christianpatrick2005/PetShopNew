<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailLogPesanan
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
        Me.dgvDetailLog = New System.Windows.Forms.DataGridView()
        Me.IDHPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.dgvDetailLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.dgvDetailLog)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(17, 78)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(806, 404)
        Me.MaterialCard1.TabIndex = 0
        '
        'dgvDetailLog
        '
        Me.dgvDetailLog.AllowUserToAddRows = False
        Me.dgvDetailLog.AllowUserToDeleteRows = False
        Me.dgvDetailLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDHPesanan, Me.IDDPesanan, Me.NamaProduk, Me.HargaProduk, Me.JumlahProduk, Me.SubTotal})
        Me.dgvDetailLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetailLog.Location = New System.Drawing.Point(14, 14)
        Me.dgvDetailLog.Name = "dgvDetailLog"
        Me.dgvDetailLog.ReadOnly = True
        Me.dgvDetailLog.RowHeadersVisible = False
        Me.dgvDetailLog.RowHeadersWidth = 51
        Me.dgvDetailLog.RowTemplate.Height = 24
        Me.dgvDetailLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetailLog.Size = New System.Drawing.Size(778, 376)
        Me.dgvDetailLog.TabIndex = 0
        '
        'IDHPesanan
        '
        Me.IDHPesanan.DataPropertyName = "IDHPesanan"
        Me.IDHPesanan.HeaderText = "ID HPesanan"
        Me.IDHPesanan.MinimumWidth = 6
        Me.IDHPesanan.Name = "IDHPesanan"
        Me.IDHPesanan.ReadOnly = True
        Me.IDHPesanan.Visible = False
        Me.IDHPesanan.Width = 125
        '
        'IDDPesanan
        '
        Me.IDDPesanan.DataPropertyName = "IDDPesanan"
        Me.IDDPesanan.HeaderText = "ID DPesanan"
        Me.IDDPesanan.MinimumWidth = 6
        Me.IDDPesanan.Name = "IDDPesanan"
        Me.IDDPesanan.ReadOnly = True
        Me.IDDPesanan.Visible = False
        Me.IDDPesanan.Width = 125
        '
        'NamaProduk
        '
        Me.NamaProduk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaProduk.DataPropertyName = "NamaProduk"
        Me.NamaProduk.HeaderText = "Nama Produk"
        Me.NamaProduk.MinimumWidth = 6
        Me.NamaProduk.Name = "NamaProduk"
        Me.NamaProduk.ReadOnly = True
        '
        'HargaProduk
        '
        Me.HargaProduk.DataPropertyName = "HargaProduk"
        Me.HargaProduk.HeaderText = "Harga"
        Me.HargaProduk.MinimumWidth = 6
        Me.HargaProduk.Name = "HargaProduk"
        Me.HargaProduk.ReadOnly = True
        Me.HargaProduk.Width = 125
        '
        'JumlahProduk
        '
        Me.JumlahProduk.DataPropertyName = "JumlahProduk"
        Me.JumlahProduk.HeaderText = "Jumlah"
        Me.JumlahProduk.MinimumWidth = 6
        Me.JumlahProduk.Name = "JumlahProduk"
        Me.JumlahProduk.ReadOnly = True
        Me.JumlahProduk.Width = 125
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotal"
        Me.SubTotal.HeaderText = "Subtotal"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 125
        '
        'frmDetailLogPesanan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(840, 499)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailLogPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | Detail Log"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.dgvDetailLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents dgvDetailLog As DataGridView
    Friend WithEvents IDHPesanan As DataGridViewTextBoxColumn
    Friend WithEvents IDDPesanan As DataGridViewTextBoxColumn
    Friend WithEvents NamaProduk As DataGridViewTextBoxColumn
    Friend WithEvents HargaProduk As DataGridViewTextBoxColumn
    Friend WithEvents JumlahProduk As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
End Class
