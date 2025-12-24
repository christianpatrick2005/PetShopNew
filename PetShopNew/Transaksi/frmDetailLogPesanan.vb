Public Class frmDetailLogPesanan

    Sub New(IDHPesanan As Integer)
        InitializeComponent()

        'MessageBox.Show("ID yang diterima Form Detail adalah: " & IDHPesanan)

        Dim DTDetailPesanan As New DataTable
        DTDetailPesanan = My.Application.DBA.DetailPesananList(IDHPesanan)
        dgvDetailLog.DataSource = DTDetailPesanan
    End Sub

End Class