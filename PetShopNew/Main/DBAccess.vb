Imports System.Data.SqlClient
Public Class DBAccess
    Private SqlConn As SqlConnection
    Dim ServerAddress As String
    Dim DBInstance As String
    Dim DBName As String
    Dim UserDB As String
    Dim PassDB As String

    Public Sub New(serverAddress As String, dBInstance As String, dBName As String, userDB As String, passDB As String)
        Me.ServerAddress = serverAddress
        Me.DBInstance = dBInstance
        Me.DBName = dBName
        Me.UserDB = userDB
        Me.PassDB = passDB
    End Sub

    Public Sub OpenSQLConn()
        SqlConn = New SqlConnection($"Server={ServerAddress};Database={DBName};Integrated Security=True;")

        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.Open()
        ElseIf SqlConn.State = ConnectionState.Broken Then
            SqlConn.Close()
            SqlConn.Open()
        End If
    End Sub

    Public Sub CloseSQLConn()
        If SqlConn.State = ConnectionState.Open Then
            SqlConn.Close()
        ElseIf SqlConn.State = ConnectionState.Connecting Then
            SqlConn.Close()
        ElseIf SqlConn.State = ConnectionState.Broken Then
            SqlConn.Close()
        End If
    End Sub

    Public Function KategoriList() As DataTable
        Dim DT As New DataTable
        Try
            OpenSQLConn()
            Dim DA As New SqlDataAdapter("usp_KategoriList", SqlConn)
            DA.SelectCommand.CommandType =
                CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.KategoriList()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DT
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function ProdukListDetil() As DataTable
        Dim DT As New DataTable
        Try
            OpenSQLConn()
            Dim DA As New SqlDataAdapter("usp_ProdukListDetil", SqlConn)
            DA.SelectCommand.CommandType =
                CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.ProdukListDetil()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DT
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function ProdukInsert(produk As Produk) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_ProdukInsert", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@NamaProduk", SqlDbType.NVarChar, 200).Value = produk.NamaProduk
            SQLCmd.Parameters.Add("@KategoriProduk", SqlDbType.Int).Value = produk.KategoriProduk
            SQLCmd.Parameters.Add("@SupplierProduk", SqlDbType.Int).Value = produk.SupplierProduk
            SQLCmd.Parameters.Add("@JumlahProduk", SqlDbType.Int).Value = produk.JumlahProduk
            SQLCmd.Parameters.Add("@NoRakProduk", SqlDbType.Int).Value = produk.NoRakProduk
            SQLCmd.Parameters.Add("@Harga", SqlDbType.Int).Value = produk.Harga

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.ProdukInsert()",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function ProdukUpdate(produk As Produk) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_UpdateProduk", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = produk.IdProduk
            SQLCmd.Parameters.Add("@NamaProduk", SqlDbType.NVarChar, 200).Value = produk.NamaProduk
            SQLCmd.Parameters.Add("@KategoriProduk", SqlDbType.Int).Value = produk.KategoriProduk
            SQLCmd.Parameters.Add("@SupplierProduk", SqlDbType.Int).Value = produk.SupplierProduk
            SQLCmd.Parameters.Add("@JumlahProduk", SqlDbType.Int).Value = produk.JumlahProduk
            SQLCmd.Parameters.Add("@NoRakProduk", SqlDbType.Int).Value = produk.NoRakProduk
            SQLCmd.Parameters.Add("@Harga", SqlDbType.Int).Value = produk.Harga

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.ProdukUpdate()",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function ProdukDelete(IdProduk As Integer) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_DeleteProduk", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@IdProduk", SqlDbType.Int)
            SQLCmd.Parameters("@IdProduk").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@IdProduk").Value = IdProduk

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.ProdukDelete()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function ProdukGambar(IdProduk As Integer) As Byte()

        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_GambarDetil", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@IdProduk", SqlDbType.Int)
            SQLCmd.Parameters("@IdProduk").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@IdProduk").Value = IdProduk

            Dim DataFoto As Byte() =
                DirectCast(SQLCmd.ExecuteScalar(), Byte())
            Return DataFoto

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.ProdukGambar()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return {0}
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function ProdukGambarInsert(IdProduk As Integer,
                                     DataFoto As Byte()) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_ProdukGambarInsert", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@IdProduk", SqlDbType.Int)
            SQLCmd.Parameters("@IdProduk").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@IdProduk").Value = IdProduk

            SQLCmd.Parameters.Add("@Gambar", SqlDbType.Image)
            SQLCmd.Parameters("@Gambar").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Gambar").Value = DataFoto

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.ProdukGambarInsert()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function SupplierList() As DataTable
        Dim DT As New DataTable
        Try
            OpenSQLConn()
            Dim DA As New SqlDataAdapter("usp_SupplierList", SqlConn)
            DA.SelectCommand.CommandType =
                CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.SupplierList()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DT
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function SupplierInsert(supplier As Supplier) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_SupplierInsert", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@NamaSupplier", SqlDbType.NVarChar, 50).Value = supplier.NamaSupplier
            SQLCmd.Parameters.Add("@EmailSupplier", SqlDbType.NVarChar, 50).Value = supplier.EmailSupplier

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.SupplierInsert()",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function SupplierUpdate(supplier As Supplier) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_UpdateSupplier", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@IdSupplier", SqlDbType.Int).Value = supplier.IdSupplier
            SQLCmd.Parameters.Add("@NamaSupplier", SqlDbType.NVarChar, 50).Value = supplier.NamaSupplier
            SQLCmd.Parameters.Add("@EmailSupplier", SqlDbType.NVarChar, 50).Value = supplier.EmailSupplier

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.SupplierInsert()",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function SupplierDelete(IdProduk As Integer) As String
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_DeleteSupplier", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@IdSupplier", SqlDbType.Int)
            SQLCmd.Parameters("@IdSupplier").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@IdSupplier").Value = IdProduk

            SQLCmd.ExecuteNonQuery()

            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.SupplierDelete()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try

    End Function

    Public Function PesananInsert(TglTransaksi As Date, Total As Integer, NomorInvoice As String, UangDibayar As Integer, UangKembalian As Integer, DetailPesanan As DataTable) As Integer
        Try
            OpenSQLConn()
            Dim IdHPesanan As Integer
            Dim SQLCmd As New SqlCommand("usp_HPesananInsert", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@TglTransaksi", SqlDbType.Date)
            SQLCmd.Parameters("@TglTransaksi").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@TglTransaksi").Value = TglTransaksi

            SQLCmd.Parameters.Add("@Total", SqlDbType.Int)
            SQLCmd.Parameters("@Total").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Total").Value = Total

            SQLCmd.Parameters.Add("@NomorInvoice", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@NomorInvoice").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@NomorInvoice").Value = NomorInvoice

            SQLCmd.Parameters.Add("@UangDibayar", SqlDbType.Int)
            SQLCmd.Parameters("@UangDibayar").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@UangDibayar").Value = UangDibayar

            SQLCmd.Parameters.Add("@UangKembalian", SqlDbType.Int)
            SQLCmd.Parameters("@UangKembalian").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@UangKembalian").Value = UangKembalian

            IdHPesanan = SQLCmd.ExecuteScalar()

            If IdHPesanan > 0 Then
                For Each row As DataRow In DetailPesanan.Rows
                    SQLCmd = New SqlCommand("usp_DPesananInsert", SqlConn)
                    SQLCmd.CommandType = CommandType.StoredProcedure

                    SQLCmd.Parameters.Add("@IdHPesanan", SqlDbType.Int).Value = IdHPesanan

                    SQLCmd.Parameters.Add("@IdProduk", SqlDbType.Int).Value = row("IdProduk")

                    SQLCmd.Parameters.Add("@Jumlah", SqlDbType.Int).Value = row("Jumlah")

                    SQLCmd.ExecuteNonQuery()
                    'For Each IdDProduk In DataProduk
                    '    SQLCmd = New SqlCommand("usp_DPesananInsert", SqlConn)
                    '    SQLCmd.CommandType = CommandType.StoredProcedure

                    '    SQLCmd.Parameters.Add("@IdHPesanan", SqlDbType.Int)
                    '    SQLCmd.Parameters("@IdHPesanan").Direction = ParameterDirection.Input
                    '    SQLCmd.Parameters("@IdHPesanan").Value = IdHPesanan

                    '    SQLCmd.Parameters.Add("@IdProduk", SqlDbType.Int)
                    '    SQLCmd.Parameters("@IdProduk").Direction = ParameterDirection.Input
                    '    SQLCmd.Parameters("@IdProduk").Value = IdDProduk

                    '    SQLCmd.Parameters.Add("@Jumlah", SqlDbType.Int)
                    '    SQLCmd.Parameters("@Jumlah").Direction = ParameterDirection.Input
                    '    SQLCmd.Parameters("@Jumlah").Value = jumlah

                    '    SQLCmd.ExecuteNonQuery()

                Next
                Return IdHPesanan
            Else
                Return 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.PesananInsert()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            CloseSQLConn()
        End Try
    End Function



    Public Function AmbilIdPesanan()
        Try
            OpenSQLConn()

            Dim SQLCmd = New SqlCommand("usp_AmbilIdPesanan", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            Return SQLCmd.ExecuteScalar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.AmbilIdPesanan()",
                MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return -1
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function PesananList() As DataTable
        Dim DT As New DataTable
        Try
            OpenSQLConn()
            Dim DA As New SqlDataAdapter("usp_PesananList", SqlConn)
            DA.SelectCommand.CommandType =
                CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.PesananList()",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DT
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function DetailPesananList(IDH As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            OpenSQLConn()

            Dim SQLCmd As New SqlCommand("usp_DetailPesananList", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@IDH", SqlDbType.Int).Value = IDH

            Dim adapter As New SqlDataAdapter(SQLCmd)
            adapter.Fill(dt)

            Return dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error DBAccess.DetailPesananList()",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            CloseSQLConn()
        End Try
    End Function

End Class