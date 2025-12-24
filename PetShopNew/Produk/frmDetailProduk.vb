Imports System.IO

Public Class frmDetailProduk
    Dim MyParent As MainMenu
    Dim DTKategori As New DataTable
    Dim DTSupplier As New DataTable
    Dim Produk As Produk
    ReadOnly IdProduk As Integer

    Sub New(MyParent As MainMenu, ByVal IdProduk As Integer, Produk As Produk)
        InitializeComponent()

        Me.MyParent = MyParent
        Me.Produk = Produk
        Me.IdProduk = IdProduk

        Dim DataFoto As Byte() = My.Application.DBA.ProdukGambar(IdProduk)
        If Not DataFoto Is Nothing Then
            Using MemoryStream As New MemoryStream(DataFoto, 0, DataFoto.Length)
                MemoryStream.Write(DataFoto, 0, DataFoto.Length)
                pbProduk.Image = Image.FromStream(MemoryStream)
            End Using
        End If

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

    Private Sub mbClose_Click(sender As Object, e As EventArgs) Handles mbClose.Click
        Close()
    End Sub

End Class