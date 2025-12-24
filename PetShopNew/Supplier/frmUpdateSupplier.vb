Public Class frmUpdateSupplier
    Dim DTSupplier As New DataTable
    Dim Supplier As Supplier
    Dim MyParent As frmMainSupplier

    'Sub New()
    '    InitializeComponent()

    '    DTSupplier = My.Application.DBA.SupplierList

    'End Sub

    Sub New(MyParent As frmMainSupplier, Supplier As Supplier)
        InitializeComponent()

        Me.MyParent = MyParent
        Me.Supplier = Supplier

        mtbNama.Text = Supplier.NamaSupplier
        mtbEmail.Text = Supplier.EmailSupplier

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SupplierNew As New Supplier

        SupplierNew.IdSupplier = Supplier.IdSupplier
        SupplierNew.NamaSupplier = Trim(mtbNama.Text)
        SupplierNew.EmailSupplier = Trim(mtbEmail.Text)


        Dim hasil As String = My.Application.DBA.SupplierUpdate(SupplierNew)
        If hasil = "Sukses" Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Error Ubah Supplier", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class