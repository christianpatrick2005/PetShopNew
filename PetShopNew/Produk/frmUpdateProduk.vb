Public Class frmUpdateProduk

    Dim MyParent As frmMainProduk
    Dim DTKategori As New DataTable
    Dim DTSupplier As New DataTable
    Dim Produk As Produk

    Sub New(MyParent As frmMainProduk, Produk As Produk)
        InitializeComponent()

        Me.MyParent = MyParent
        Me.Produk = Produk

        DTKategori = My.Application.DBA.KategoriList
        With mcbKategori
            .DataSource = DTKategori
            .DisplayMember = "NamaKategori"
            .ValueMember = "IdKategori"
            .SelectedValue = Produk.KategoriProduk
        End With

        DTSupplier = My.Application.DBA.SupplierList
        With mcbSupplier
            .DataSource = DTSupplier
            .DisplayMember = "NamaSupplier"
            .ValueMember = "IdSupplier"
            .SelectedValue = Produk.SupplierProduk
        End With

        mtbNama.Text = Produk.NamaProduk
        mtbJumlah.Text = Produk.JumlahProduk
        mtbHarga.Text = Produk.Harga
        mtbNoRak.Text = Produk.NoRakProduk

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ProdukNew As New Produk

        ProdukNew.IdProduk = Produk.IdProduk
        ProdukNew.NamaProduk = Trim(mtbNama.Text)
        ProdukNew.JumlahProduk = Val(mtbJumlah.Text)
        ProdukNew.Harga = Val(mtbHarga.Text)
        ProdukNew.NoRakProduk = Val(mtbNoRak.Text)
        ProdukNew.KategoriProduk = Convert.ToInt32(mcbKategori.SelectedValue)
        ProdukNew.SupplierProduk = Convert.ToInt32(mcbSupplier.SelectedValue)

        Dim hasil As String = My.Application.DBA.ProdukUpdate(ProdukNew)
        If hasil = "Sukses" Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Error Ubah Produk", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub


End Class