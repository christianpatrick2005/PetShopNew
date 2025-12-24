Imports System.IO
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class frmProdukGambar

    ReadOnly IdProduk As Integer

    Sub New(ByVal IdProduk As Integer, ByVal Nama As String, ByVal Harga As Integer, ByVal NoRak As Integer)
        InitializeComponent()

        Me.IdProduk = IdProduk
        mtbNama.Text = Nama
        mtbHarga.Text = Harga
        mtbNoRak.Text = NoRak

        Dim DataFoto As Byte() = My.Application.DBA.ProdukGambar(IdProduk)
        If Not DataFoto Is Nothing Then
            Using MemoryStream As New MemoryStream(DataFoto, 0, DataFoto.Length)
                MemoryStream.Write(DataFoto, 0, DataFoto.Length)
                pbProduk.Image = Image.FromStream(MemoryStream)
            End Using
        End If
    End Sub

    Private Sub mbElipsis_Click(sender As Object, e As EventArgs) Handles mbElipsis.Click
        Try
            Dim OFD As New OpenFileDialog
            OFD.Multiselect = False
            OFD.Title = "Pilih Gambar"
            OFD.InitialDirectory = Environment.SpecialFolder.MyPictures
            OFD.Filter = "Berkas Gambar|*.bmp;*.gif;*.jpg;*.jpeg;*.png;"
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                mtbGambar.Text = OFD.FileName
                pbProduk.Image = Image.FromFile(OFD.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mbSimpan_Click(sender As Object, e As EventArgs) Handles mbSimpan.Click
        Dim hasil As String
        If Not String.IsNullOrEmpty(mtbGambar.Text) And
            Not String.IsNullOrWhiteSpace(mtbGambar.Text) Then
            Try
                Dim MemoryStream As New MemoryStream()
                pbProduk.Image.Save(MemoryStream, pbProduk.Image.RawFormat)
                Dim DataFoto As Byte() = MemoryStream.GetBuffer()
                hasil = My.Application.DBA.ProdukGambarInsert(IdProduk, DataFoto)
                If hasil = "Sukses" Then
                    Me.Close()
                Else
                    MessageBox.Show("Gambar Gagal Disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub mbClose_Click(sender As Object, e As EventArgs) Handles mbClose.Click
        Close()
    End Sub
End Class