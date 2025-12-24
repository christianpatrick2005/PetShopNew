Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class LaporanExcel
    Dim path As String

    Sub New()
        path = My.Application.Info.DirectoryPath
    End Sub

    Public Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub DaftarProduk(DataProduk As Data.DataTable)
        Dim XLApp As New Application
        Dim XLWorkbook As Workbook
        Dim sheet1 As Worksheet

        Try
            XLWorkbook = XLApp.Workbooks.Open(path & "\Laporan\DaftarProduk.xltx")
            sheet1 = XLWorkbook.Sheets("Sheet1")

            Dim i As Integer = 2
            For Each row As DataRow In DataProduk.Rows
                sheet1.Range("A" & i).Value = row.Item("IdProduk")
                sheet1.Range("B" & i).Value = row.Item("NamaProduk")
                sheet1.Range("C" & i).Value = row.Item("KategoriProduk")
                sheet1.Range("D" & i).Value = row.Item("SupplierProduk")
                sheet1.Range("E" & i).Value = row.Item("NoRakProduk")
                sheet1.Range("F" & i).Value = row.Item("JumlahProduk")
                sheet1.Range("G" & i).Value = row.Item("Harga")


                ''untuk styling excel
                'sheet1.Range("A" & i & ":G" & i).Borders(Color:=Color.Black, Weight:=XlBorderWeight.xlMedium, LineStyle:=XlLineStyle.xlContinuous)
                Dim rng As Excel.Range = sheet1.Range("A" & i & ":G" & i)

                With rng.Borders
                    ' Mengatur jenis garis menjadi solid (bersambung)
                    .LineStyle = Excel.XlLineStyle.xlContinuous

                    ' Mengatur ketebalan garis (biasanya xlThin untuk All Borders standar)
                    .Weight = Excel.XlBorderWeight.xlThin

                    ' Mengatur warna
                    .Color = Color.Black
                End With

                i = i + 1
            Next
            XLApp.WindowState = XlWindowState.xlMaximized
            XLApp.Visible = True

            ReleaseObject(sheet1)
            ReleaseObject(XLWorkbook)
            ReleaseObject(XLApp)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
