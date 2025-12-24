Public Class frmMainSupplier

    Dim DTSupplier As New DataTable
    Dim Supplier As Supplier

    Sub New()
        InitializeComponent()

        DTSupplier = My.Application.DBA.SupplierList
        dgvSupplier.DataSource = DTSupplier

    End Sub

    Public Sub RefreshData()
        DTSupplier = My.Application.DBA.SupplierList
        dgvSupplier.DataSource = DTSupplier
    End Sub

    Private Sub dgvSupplier_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSupplier.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = dgvSupplier.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then

                Supplier.IdSupplier = dgvSupplier.Item(0, HT.RowIndex).Value
                Supplier.NamaSupplier = dgvSupplier.Item("NamaSupplierCol", HT.RowIndex).Value
                Supplier.EmailSupplier = dgvSupplier.Item("EmailSupplierCol", HT.RowIndex).Value

                'Produk.NoRakProduk = If(IsDBNull(dgvSupplier.Item("NoRakProdukCol", HT.RowIndex).Value), 0,
                '                dgvSupplier.Item("NoRakProdukCol", HT.RowIndex).Value)

                'Produk.KategoriProduk = dgvSupplier.Item("KategoriProdukIntCol", HT.RowIndex).Value
                'Produk.SupplierProduk = dgvSupplier.Item("SupplierProdukIntCol", HT.RowIndex).Value

                dgvSupplier.Rows(HT.RowIndex).Selected = True
                dgvSupplier.ContextMenuStrip = ContextMenuStrip1
            Else
                dgvSupplier.ContextMenuStrip = Nothing
            End If
        Else
            dgvSupplier.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub DeleteSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSupplierToolStripMenuItem.Click
        MessageBox.Show(My.Application.DBA.SupplierDelete(Supplier.IdSupplier))
        RefreshData()
    End Sub

    Private Sub TambahSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahSupplierToolStripMenuItem.Click
        Dim fTambahSupplier As New frmTambahSupplier(Me)
        fTambahSupplier.ShowDialog()
    End Sub

    Private Sub mbtTambahSupplier_Click(sender As Object, e As EventArgs) Handles mbtTambahSupplier.Click
        Dim fTambahSupplier As New frmTambahSupplier(Me)
        fTambahSupplier.ShowDialog()
    End Sub

    Private Sub UpdateSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateSupplierToolStripMenuItem.Click
        Dim fUpdateSupplier As New frmUpdateSupplier(Me, Supplier)
        fUpdateSupplier.ShowDialog()
    End Sub

    Private Sub mbClose_Click(sender As Object, e As EventArgs) Handles mbClose.Click
        Close()
    End Sub
End Class