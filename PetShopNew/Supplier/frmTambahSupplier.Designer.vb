<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTambahSupplier
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
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnTambah = New MaterialSkin.Controls.MaterialButton()
        Me.mtbEmail = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtbNama = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Nothing
        Me.btnClose.Location = New System.Drawing.Point(407, 275)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(66, 36)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnClose.UseAccentColor = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTambah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnTambah.Depth = 0
        Me.btnTambah.HighEmphasis = True
        Me.btnTambah.Icon = Nothing
        Me.btnTambah.Location = New System.Drawing.Point(317, 275)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTambah.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnTambah.Size = New System.Drawing.Size(82, 36)
        Me.btnTambah.TabIndex = 31
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnTambah.UseAccentColor = False
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'mtbEmail
        '
        Me.mtbEmail.AnimateReadOnly = False
        Me.mtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbEmail.Depth = 0
        Me.mtbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbEmail.LeadingIcon = Nothing
        Me.mtbEmail.Location = New System.Drawing.Point(115, 200)
        Me.mtbEmail.MaxLength = 50
        Me.mtbEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbEmail.Multiline = False
        Me.mtbEmail.Name = "mtbEmail"
        Me.mtbEmail.Size = New System.Drawing.Size(358, 50)
        Me.mtbEmail.TabIndex = 47
        Me.mtbEmail.Text = ""
        Me.mtbEmail.TrailingIcon = Nothing
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel7.Location = New System.Drawing.Point(22, 210)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(50, 24)
        Me.MaterialLabel7.TabIndex = 46
        Me.MaterialLabel7.Text = "Email"
        '
        'mtbNama
        '
        Me.mtbNama.AnimateReadOnly = False
        Me.mtbNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNama.Depth = 0
        Me.mtbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtbNama.LeadingIcon = Nothing
        Me.mtbNama.Location = New System.Drawing.Point(115, 126)
        Me.mtbNama.MaxLength = 50
        Me.mtbNama.MouseState = MaterialSkin.MouseState.OUT
        Me.mtbNama.Multiline = False
        Me.mtbNama.Name = "mtbNama"
        Me.mtbNama.Size = New System.Drawing.Size(358, 50)
        Me.mtbNama.TabIndex = 45
        Me.mtbNama.Text = ""
        Me.mtbNama.TrailingIcon = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel6.Location = New System.Drawing.Point(18, 139)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(54, 24)
        Me.MaterialLabel6.TabIndex = 44
        Me.MaterialLabel6.Text = "Nama"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(6, 110)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(467, 10)
        Me.MaterialDivider1.TabIndex = 43
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.Location = New System.Drawing.Point(17, 78)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(180, 29)
        Me.MaterialLabel1.TabIndex = 42
        Me.MaterialLabel1.Text = "Tambah Supplier"
        '
        'frmTambahSupplier
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(486, 322)
        Me.Controls.Add(Me.mtbEmail)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.mtbNama)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTambah)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTambahSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URBAN PET SHOP | Tambah Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnTambah As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mtbEmail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtbNama As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
