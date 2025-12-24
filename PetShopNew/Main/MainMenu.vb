Public Class MainMenu
    Dim DTProduk As New DataTable
    Dim DTKategori As New DataTable

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim fMainProduk As New frmMainProduk
        fMainProduk.ShowDialog()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Dim fMainSupplier As New frmMainSupplier
        fMainSupplier.ShowDialog()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        Dim fSistemKasir As New frmKasir
        fSistemKasir.ShowDialog()
    End Sub


End Class
