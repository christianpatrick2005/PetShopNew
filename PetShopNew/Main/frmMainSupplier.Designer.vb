<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainSupplier
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mbClose = New MaterialSkin.Controls.MaterialButton()
        Me.mbtTambahSupplier = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.IdSupplierCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSupplierCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailSupplierCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mbClose
        '
        Me.mbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbClose.Depth = 0
        Me.mbClose.HighEmphasis = True
        Me.mbClose.Icon = Nothing
        Me.mbClose.Location = New System.Drawing.Point(883, 566)
        Me.mbClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbClose.Name = "mbClose"
        Me.mbClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbClose.Size = New System.Drawing.Size(66, 36)
        Me.mbClose.TabIndex = 20
        Me.mbClose.Text = "close"
        Me.mbClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbClose.UseAccentColor = False
        Me.mbClose.UseVisualStyleBackColor = True
        '
        'mbtTambahSupplier
        '
        Me.mbtTambahSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mbtTambahSupplier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.mbtTambahSupplier.Depth = 0
        Me.mbtTambahSupplier.HighEmphasis = True
        Me.mbtTambahSupplier.Icon = Nothing
        Me.mbtTambahSupplier.Location = New System.Drawing.Point(722, 566)
        Me.mbtTambahSupplier.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mbtTambahSupplier.MouseState = MaterialSkin.MouseState.HOVER
        Me.mbtTambahSupplier.Name = "mbtTambahSupplier"
        Me.mbtTambahSupplier.NoAccentTextColor = System.Drawing.Color.Empty
        Me.mbtTambahSupplier.Size = New System.Drawing.Size(153, 36)
        Me.mbtTambahSupplier.TabIndex = 18
        Me.mbtTambahSupplier.Text = "Tambah Supplier"
        Me.mbtTambahSupplier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.mbtTambahSupplier.UseAccentColor = False
        Me.mbtTambahSupplier.UseVisualStyleBackColor = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.dgvSupplier)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(7, 185)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(942, 361)
        Me.MaterialCard1.TabIndex = 43
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSupplier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSupplierCol, Me.Status, Me.NamaSupplierCol, Me.EmailSupplierCol})
        Me.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSupplier.Location = New System.Drawing.Point(14, 14)
        Me.dgvSupplier.MultiSelect = False
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowHeadersVisible = False
        Me.dgvSupplier.RowHeadersWidth = 51
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSupplier.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSupplier.RowTemplate.Height = 24
        Me.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplier.Size = New System.Drawing.Size(914, 333)
        Me.dgvSupplier.TabIndex = 0
        '
        'IdSupplierCol
        '
        Me.IdSupplierCol.DataPropertyName = "IdSupplier"
        Me.IdSupplierCol.HeaderText = "ID"
        Me.IdSupplierCol.MinimumWidth = 6
        Me.IdSupplierCol.Name = "IdSupplierCol"
        Me.IdSupplierCol.ReadOnly = True
        Me.IdSupplierCol.Visible = False
        Me.IdSupplierCol.Width = 125
        '
        'Status
        '
        Me.Status.DataPropertyName = "StatusSupplier"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Visible = False
        Me.Status.Width = 125
        '
        'NamaSupplierCol
        '
        Me.NamaSupplierCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaSupplierCol.DataPropertyName = "NamaSupplier"
        Me.NamaSupplierCol.HeaderText = "Nama Supplier"
        Me.NamaSupplierCol.MinimumWidth = 6
        Me.NamaSupplierCol.Name = "NamaSupplierCol"
        Me.NamaSupplierCol.ReadOnly = True
        '
        'EmailSupplierCol
        '
        Me.EmailSupplierCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailSupplierCol.DataPropertyName = "EmailSupplier"
        Me.EmailSupplierCol.HeaderText = "Email"
        Me.EmailSupplierCol.MinimumWidth = 6
        Me.EmailSupplierCol.Name = "EmailSupplierCol"
        Me.EmailSupplierCol.ReadOnly = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-4, 108)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(965, 10)
        Me.MaterialDivider1.TabIndex = 44
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.Location = New System.Drawing.Point(6, 76)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(195, 29)
        Me.MaterialLabel1.TabIndex = 45
        Me.MaterialLabel1.Text = "Informasi Supplier"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahSupplierToolStripMenuItem, Me.UpdateSupplierToolStripMenuItem, Me.DeleteSupplierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 76)
        '
        'TambahSupplierToolStripMenuItem
        '
        Me.TambahSupplierToolStripMenuItem.Name = "TambahSupplierToolStripMenuItem"
        Me.TambahSupplierToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.TambahSupplierToolStripMenuItem.Text = "Tambah Supplier"
        '
        'UpdateSupplierToolStripMenuItem
        '
        Me.UpdateSupplierToolStripMenuItem.Name = "UpdateSupplierToolStripMenuItem"
        Me.UpdateSupplierToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.UpdateSupplierToolStripMenuItem.Text = "Update Supplier"
        '
        'DeleteSupplierToolStripMenuItem
        '
        Me.DeleteSupplierToolStripMenuItem.Name = "DeleteSupplierToolStripMenuItem"
        Me.DeleteSupplierToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.DeleteSupplierToolStripMenuItem.Text = "Delete Supplier"
        '
        'frmMainSupplier
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(957, 611)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.mbClose)
        Me.Controls.Add(Me.mbtTambahSupplier)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMASI SUPPLIER"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mbClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mbtTambahSupplier As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents IdSupplierCol As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents NamaSupplierCol As DataGridViewTextBoxColumn
    Friend WithEvents EmailSupplierCol As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TambahSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSupplierToolStripMenuItem As ToolStripMenuItem
End Class
