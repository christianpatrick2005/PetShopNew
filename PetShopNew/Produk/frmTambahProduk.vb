Public Class frmTambahProduk

    Dim MyParent As frmMainProduk
    Dim DTKategori As New DataTable
    Dim DTSupplier As New DataTable

    Sub New(MyParent As frmMainProduk)
        InitializeComponent()

        Me.MyParent = MyParent

        DTKategori = My.Application.DBA.KategoriList
        With mcbKategori
            .DataSource = DTKategori
            .DisplayMember = "NamaKategori"
            .ValueMember = "IdKategori"
        End With

        DTSupplier = My.Application.DBA.SupplierList
        With mcbSupplier
            .DataSource = DTSupplier
            .DisplayMember = "NamaSupplier"
            .ValueMember = "IdSupplier"
        End With


    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Produk As New Produk
        Dim Hasil As String

        Try
            Produk.NamaProduk = Trim(mtbNama.Text)
            Produk.JumlahProduk = Trim(mtbJumlah.Text)
            Produk.KategoriProduk = mcbKategori.SelectedValue
            Produk.SupplierProduk = mcbSupplier.SelectedValue
            Produk.NoRakProduk = Val(Trim(mtbNoRak.Text))
            Produk.Harga = Val(Trim(mtbHarga.Text))

            Hasil = My.Application.DBA.ProdukInsert(Produk)
            If Hasil = "Sukses" Then
                MyParent.RefreshData()
                Close()
            Else
                MessageBox.Show("Error Tambah Produk", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class