Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class frmKasir

    Dim DTProduk As New DataTable
    Dim Produk As Produk
    Dim DTPesanan As New DataTable
    Dim NomorInvoice As String

    Sub New()
        InitializeComponent()

        DTProduk = My.Application.DBA.ProdukListDetil
        dgvProduk.DataSource = DTProduk

        ' Buat kolom pada DataTable
        DTPesanan.Columns.Add("IdProduk", GetType(Integer))
        DTPesanan.Columns.Add("NamaProduk", GetType(String))
        DTPesanan.Columns.Add("Jumlah", GetType(Integer))
        DTPesanan.Columns.Add("Harga", GetType(Integer))
        DTPesanan.Columns.Add("Subtotal", GetType(Integer))

        dgvPesanan.DataSource = DTPesanan

        dgvPesanan.Columns("NamaProduk").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvPesanan.Columns("Jumlah").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns("Harga").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns("Subtotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Dim IdHPesanan As Object = My.Application.DBA.AmbilIdPesanan()

        If IsDBNull(IdHPesanan) Then
            IdHPesanan = 1
        Else
            IdHPesanan += 1
        End If

        NomorInvoice = Now.Day.ToString("d2") & Now.Month.ToString("d2") & Now.Year Mod 100 & DirectCast(IdHPesanan, Integer).ToString("d3")
        tbNoNota.Text = NomorInvoice

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Close()
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If dgvProduk.SelectedRows.Count > 0 Then
            Dim row As DataRow = DTPesanan.NewRow()

            row("IdProduk") = dgvProduk.SelectedRows(0).Cells("IdProdukCol").Value
            row("NamaProduk") = dgvProduk.SelectedRows(0).Cells("NamaProdukCol").Value
            row("Harga") = dgvProduk.SelectedRows(0).Cells("HargaCol").Value
            If dgvProduk.SelectedRows(0).Cells("JumlahProdukCol").Value < nupJumlah.Value Or dgvProduk.SelectedRows(0).Cells("JumlahProdukCol").Value = 0 Then
                MessageBox.Show("Stock tidak mencukupi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            ElseIf nupJumlah.Value <= 0 Then
                MessageBox.Show("Jumlah pemesanan tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                row("Jumlah") = nupJumlah.Value
            End If
            row("Subtotal") = row("Jumlah") * row("Harga")

            ''mengurangi stock di dgvProduk jika produk dipilih
            Dim mengurangi = dgvProduk.SelectedRows(0).Cells("JumlahProdukCol").Value
            dgvProduk.SelectedRows(0).Cells("JumlahProdukCol").Value = mengurangi - nupJumlah.Value

            DTPesanan.Rows.Add(row)

            ''menampilkan total pesanan
            Dim total As Integer = 0
            For Each rows As DataRow In DTPesanan.Rows
                total += rows("Subtotal")
            Next

            tbTotal.Text = total.ToString()

        Else
            MessageBox.Show("Pilih produk terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        If dgvPesanan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih item yang ingin dikembalikan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim indeks As Integer = dgvPesanan.SelectedRows(0).Index
        Dim row As DataRow = DTPesanan.Rows(indeks)

        Dim jumlahPesanan As Integer = row("Jumlah")
        Dim jumlahKembali As Integer = nupJumlah.Value

        If jumlahKembali <= 0 Then
            MessageBox.Show("Jumlah pengembalian tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If jumlahKembali > jumlahPesanan Then
            MessageBox.Show("Jumlah pengembalian lebih banyak dari jumlah pemesanan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ''menambah stock di dgvProduk jika produk dipilih
        'Dim menambah = dgvProduk.SelectedRows(0).Cells("JumlahProdukCol").Value
        'dgvProduk.SelectedRows(0).Cells("JumlahProdukCol").Value = menambah + nupJumlah.Value
        Dim idProdukKembali As Integer = row("IdProduk")

        For Each produkRow As DataGridViewRow In dgvProduk.Rows
            If produkRow.Cells("IdProdukCol").Value = idProdukKembali Then

                Dim stokSekarang As Integer = CInt(produkRow.Cells("JumlahProdukCol").Value)
                produkRow.Cells("JumlahProdukCol").Value = stokSekarang + jumlahKembali

                Exit For
            End If
        Next


        'Jika jumlah yang dikembalikan sama dengan jumlah pesanan maka hapus baris
        If jumlahKembali = jumlahPesanan Then
            DTPesanan.Rows.RemoveAt(indeks)
        Else
            'Kurangi jumlah
            row("Jumlah") = jumlahPesanan - jumlahKembali

            'Update subtotal baru
            row("Subtotal") = row("Jumlah") * row("Harga")
        End If

        Dim total As Integer = 0
        For Each rows As DataRow In DTPesanan.Rows
            total += rows("Subtotal")
        Next

        tbTotal.Text = total.ToString()

        ''reset pembayaran dan kembalian
        tbPembayaran.Text = "0"
        tbKembalian.Text = "0"
    End Sub

    Private Sub tbPembayaran_KeyUp(sender As Object, e As KeyEventArgs) Handles tbPembayaran.KeyUp
        Dim uangdibayar As Integer = 0
        Dim total As Integer = 0

        Integer.TryParse(tbPembayaran.Text, uangdibayar)
        Integer.TryParse(tbTotal.Text, total)

        Dim kembalian As Integer = uangdibayar - total
        tbKembalian.Text = kembalian.ToString()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim JumlahItem As Integer = dgvPesanan.RowCount

        If JumlahItem = 0 Then
            MessageBox.Show("Tidak ada item pesanan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim DataDProduk As New ArrayList()

        Dim Total As Integer = 0

        ''mengambil semua item dari dgvPesanan
        For Each row As DataGridViewRow In dgvPesanan.Rows
            If Not row.IsNewRow Then
                Dim IdProduk As Integer = CInt(row.Cells("IdProduk").Value)
                Dim Jumlah As Integer = CInt(row.Cells("Jumlah").Value)
                Dim Subtotal As Integer = CInt(row.Cells("Subtotal").Value)

                DataDProduk.Add(IdProduk)
                Total += Subtotal
            End If
        Next

        Dim TglTransaksi As Date = Now
        'Dim UangDibayar As Integer = CInt(tbPembayaran.Text)

        Dim UangDibayar As Integer = 0
        If String.IsNullOrWhiteSpace(tbPembayaran.Text) OrElse Not Integer.TryParse(tbPembayaran.Text, UangDibayar) Then
            MessageBox.Show("Harap masukkan nominal pembayaran yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPembayaran.Focus()
            Return
        End If
        Dim UangKembalian As Integer = UangDibayar - Total

        'Validasi uang dibayar
        If UangDibayar < Total Then
            MessageBox.Show("Uang dibayar kurang!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Insert ke database
        Dim hasil As Integer = My.Application.DBA.PesananInsert(
        TglTransaksi,
        Total,
        NomorInvoice,
        UangDibayar,
        UangKembalian,
        DTPesanan
    )

        If hasil > 0 Then
            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Cash As String = tbPembayaran.Text
            Dim Kembalian As String = tbKembalian.Text
            Dim NamaKasir As String = "Christian Patrick"
            CetakNota(NomorInvoice, NamaKasir, Now.ToString("dd/MM/yyyy"), Cash, Kembalian, DTPesanan)
        Else
            MessageBox.Show("Gagal menyimpan pesanan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub CetakNota(NomorStruk As String, NamaKasir As String, TanggalPesanan As String, Cash As String, Kembalian As String, DTPesanan As DataTable)
        Try
            Dim Param As New List(Of ReportParameter)
            Param.Add(New ReportParameter("NOMORSTRUK", NomorStruk))
            Param.Add(New ReportParameter("TGLPESANAN", TanggalPesanan))
            Param.Add(New ReportParameter("CASH", Cash))
            Param.Add(New ReportParameter("NAMAKASIR", NamaKasir))
            Param.Add(New ReportParameter("KEMBALIAN", Kembalian))

            Dim ReportPath As String = Application.StartupPath & "\Laporan\Invoice.rdlc"

            Dim ReportFile As New StreamReader(ReportPath)

            Dim InvoiceReport As New LocalReport

            InvoiceReport.ReportPath = ReportPath
            InvoiceReport.LoadReportDefinition(ReportFile)
            InvoiceReport.SetParameters(Param)

            Dim ReportDataSet As New ReportDataSet
            ReportDataSet.Tables("ProdukPesanan").Merge(DTPesanan)

            Dim NotaSewaDataSource As New ReportDataSource("Invoice", ReportDataSet.Tables("ProdukPesanan"))

            InvoiceReport.DataSources.Add(NotaSewaDataSource)

            Dim RP As New ReportPrinting(InvoiceReport)
            RP.Print()

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mbtnLog_Click(sender As Object, e As EventArgs) Handles mbtnLog.Click
        Dim fLogPesanan As New frmLogPesanan()
        fLogPesanan.ShowDialog()
    End Sub
End Class
