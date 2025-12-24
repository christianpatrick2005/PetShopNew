<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogPesanan
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
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.IdPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UangDibayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetailPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.dgvLog)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(17, 78)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(808, 410)
        Me.MaterialCard1.TabIndex = 0
        '
        'dgvLog
        '
        Me.dgvLog.AllowUserToAddRows = False
        Me.dgvLog.AllowUserToDeleteRows = False
        Me.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPesanan, Me.TglPesanan, Me.Invoice, Me.TotalHarga, Me.UangDibayar, Me.Kembalian})
        Me.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLog.Location = New System.Drawing.Point(14, 14)
        Me.dgvLog.Name = "dgvLog"
        Me.dgvLog.ReadOnly = True
        Me.dgvLog.RowHeadersVisible = False
        Me.dgvLog.RowHeadersWidth = 51
        Me.dgvLog.RowTemplate.Height = 24
        Me.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLog.Size = New System.Drawing.Size(780, 382)
        Me.dgvLog.TabIndex = 0
        '
        'IdPesanan
        '
        Me.IdPesanan.DataPropertyName = "IdPesanan"
        Me.IdPesanan.HeaderText = "ID"
        Me.IdPesanan.MinimumWidth = 6
        Me.IdPesanan.Name = "IdPesanan"
        Me.IdPesanan.ReadOnly = True
        Me.IdPesanan.Visible = False
        Me.IdPesanan.Width = 125
        '
        'TglPesanan
        '
        Me.TglPesanan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TglPesanan.DataPropertyName = "TglPesanan"
        Me.TglPesanan.HeaderText = "Tgl Pesanan"
        Me.TglPesanan.MinimumWidth = 6
        Me.TglPesanan.Name = "TglPesanan"
        Me.TglPesanan.ReadOnly = True
        '
        'Invoice
        '
        Me.Invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Invoice.DataPropertyName = "Invoice"
        Me.Invoice.HeaderText = "No Invoice"
        Me.Invoice.MinimumWidth = 6
        Me.Invoice.Name = "Invoice"
        Me.Invoice.ReadOnly = True
        '
        'TotalHarga
        '
        Me.TotalHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalHarga.DataPropertyName = "TotalHarga"
        Me.TotalHarga.HeaderText = "Nominal Pesanan"
        Me.TotalHarga.MinimumWidth = 6
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.ReadOnly = True
        '
        'UangDibayar
        '
        Me.UangDibayar.DataPropertyName = "UangDibayar"
        Me.UangDibayar.HeaderText = "Pembayaran"
        Me.UangDibayar.MinimumWidth = 6
        Me.UangDibayar.Name = "UangDibayar"
        Me.UangDibayar.ReadOnly = True
        Me.UangDibayar.Width = 125
        '
        'Kembalian
        '
        Me.Kembalian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Kembalian.DataPropertyName = "Kembalian"
        Me.Kembalian.HeaderText = "Uang Kembalian"
        Me.Kembalian.MinimumWidth = 6
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailPesananToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 56)
        '
        'DetailPesananToolStripMenuItem
        '
        Me.DetailPesananToolStripMenuItem.Name = "DetailPesananToolStripMenuItem"
        Me.DetailPesananToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.DetailPesananToolStripMenuItem.Text = "Detail Pesanan"
        '
        'frmLogPesanan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(842, 505)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | LOG Pesanan"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents dgvLog As DataGridView
    Friend WithEvents IdPesanan As DataGridViewTextBoxColumn
    Friend WithEvents TglPesanan As DataGridViewTextBoxColumn
    Friend WithEvents Invoice As DataGridViewTextBoxColumn
    Friend WithEvents TotalHarga As DataGridViewTextBoxColumn
    Friend WithEvents UangDibayar As DataGridViewTextBoxColumn
    Friend WithEvents Kembalian As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DetailPesananToolStripMenuItem As ToolStripMenuItem
End Class
