Public Class frmTambahSupplier

    Dim DTSupplier As New DataTable
    Dim MyParent As frmMainSupplier
    Dim Supplier As Supplier

    Sub New(MyParent As frmMainSupplier)
        InitializeComponent()
        Me.MyParent = MyParent
        DTSupplier = My.Application.DBA.SupplierList
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Supplier As New Supplier
        Dim Hasil As String

        Supplier.NamaSupplier = Trim(mtbNama.Text)
        Supplier.EmailSupplier = Trim(mtbEmail.Text)

        Hasil = My.Application.DBA.SupplierInsert(Supplier)
        If Hasil = "Sukses" Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Error Tambah Supplier", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub
End Class