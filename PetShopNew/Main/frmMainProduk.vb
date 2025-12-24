Public Class frmMainProduk
    Dim DTProduk As New DataTable
    Dim DTKategori As New DataTable
    Dim Produk As Produk
    Sub New()
        InitializeComponent()

        DTProduk = My.Application.DBA.ProdukListDetil
        dgvDaftarProduk.DataSource = DTProduk

        'dgvDaftarProduk.Columns["IdProduk"].Visible = False;
        'If dgvDaftarProduk.Columns("").Visible = True Then
        '    dgvDaftarProduk.Columns("IdProdukCol").Visible = False
        'End If

        DTKategori = My.Application.DBA.KategoriList
        Dim DRow As DataRow = DTKategori.NewRow()
        DRow("IdKategori") = 0
        DRow("NamaKategori") = "All Categories"
        DTKategori.Rows.Add(DRow)

        With mcbKategori
            .DataSource = DTKategori
            .DisplayMember = "NamaKategori"
            .ValueMember = "IdKategori"
            .SelectedValue = 0
        End With
    End Sub

    Public Sub RefreshData()
        DTProduk = My.Application.DBA.ProdukListDetil
        dgvDaftarProduk.DataSource = DTProduk
    End Sub


    Private Sub Search()
        If mcbKategori.SelectedValue IsNot Nothing AndAlso
       Not TypeOf mcbKategori.SelectedValue Is DataRowView Then

            Dim selectedKategori As Integer = Convert.ToInt32(mcbKategori.SelectedValue)

            If mcbKategori.SelectedValue > 0 Then
                If Not String.IsNullOrEmpty(mtbSearch.Text) And
                Not String.IsNullOrWhiteSpace(mtbSearch.Text) Then

                    DTProduk.DefaultView.RowFilter =
                    "IdKategoriProduk = " & selectedKategori &
                    " AND (NamaProduk LIKE '%" & mtbSearch.Text &
                    "%' OR SupplierProduk LIKE '%" & mtbSearch.Text & "%')"

                Else
                    DTProduk.DefaultView.RowFilter =
                    "IdKategoriProduk=" & selectedKategori & ""
                End If
            Else
                If Not String.IsNullOrEmpty(mtbSearch.Text) And
                Not String.IsNullOrWhiteSpace(mtbSearch.Text) Then

                    DTProduk.DefaultView.RowFilter = "NamaProduk LIKE '%" & mtbSearch.Text &
                    "%' OR SupplierProduk LIKE '%" & mtbSearch.Text & "%'"
                Else
                    DTProduk.DefaultView.RowFilter = ""
                End If

            End If

        End If
    End Sub

    Private Sub mbTambah_Click(sender As Object, e As EventArgs) Handles mbTambah.Click
        Dim ftambahProduk As New frmTambahProduk(Me)
        ftambahProduk.ShowDialog()
    End Sub

    Private Sub mcbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbKategori.SelectedIndexChanged
        Search()
    End Sub

    Private Sub mtbSearch_TextChanged(sender As Object, e As EventArgs) Handles mtbSearch.TextChanged
        Search()
    End Sub

    Private Sub TambahProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahProdukToolStripMenuItem.Click
        Dim ftambahProduk As New frmTambahProduk(Me)
        ftambahProduk.ShowDialog()
    End Sub

    Private Sub UpdateProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProdukToolStripMenuItem.Click
        Dim fupdateProduk As New frmUpdateProduk(Me, Produk)
        fupdateProduk.ShowDialog()
    End Sub

    Private Sub dgvDaftarProduk_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvDaftarProduk.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = dgvDaftarProduk.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then

                Produk.IdProduk = dgvDaftarProduk.Item(0, HT.RowIndex).Value
                Produk.NamaProduk = dgvDaftarProduk.Item("NamaProdukCol", HT.RowIndex).Value
                Produk.JumlahProduk = dgvDaftarProduk.Item("JumlahProdukCol", HT.RowIndex).Value

                Produk.NoRakProduk = If(IsDBNull(dgvDaftarProduk.Item("NoRakProdukCol", HT.RowIndex).Value), 0,
                                dgvDaftarProduk.Item("NoRakProdukCol", HT.RowIndex).Value)

                Produk.KategoriProduk = dgvDaftarProduk.Item("KategoriProdukIntCol", HT.RowIndex).Value
                Produk.SupplierProduk = dgvDaftarProduk.Item("SupplierProdukIntCol", HT.RowIndex).Value
                Produk.Harga = dgvDaftarProduk.Item("HargaCol", HT.RowIndex).Value



                dgvDaftarProduk.Rows(HT.RowIndex).Selected = True
                dgvDaftarProduk.ContextMenuStrip = ContextMenuStrip1
            Else
                dgvDaftarProduk.ContextMenuStrip = Nothing
            End If
        Else
            dgvDaftarProduk.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub mbClose_Click(sender As Object, e As EventArgs) Handles mbClose.Click
        Close()
    End Sub


    Private Sub DeleteProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProdukToolStripMenuItem.Click
        MessageBox.Show(My.Application.DBA.ProdukDelete(Produk.IdProduk))
        RefreshData()
    End Sub


    Private Sub GambarProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GambarProdukToolStripMenuItem.Click
        Dim fGambarProduk As New frmProdukGambar(Produk.IdProduk, Produk.NamaProduk, Produk.Harga, Produk.NoRakProduk)
        fGambarProduk.ShowDialog()
    End Sub

    Private Sub DetailProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailProdukToolStripMenuItem.Click
        Dim fDetailProduk As New frmDetailProduk(MainMenu, Produk.IdProduk, Produk)
        fDetailProduk.ShowDialog()
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        Dim reportBuku As New LaporanExcel()
        reportBuku.DaftarProduk(DTProduk)
    End Sub
End Class