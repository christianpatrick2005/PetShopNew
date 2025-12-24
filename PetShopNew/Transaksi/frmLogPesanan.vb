Public Class frmLogPesanan
    Dim DTPesanan As New DataTable
    Dim IdHPesanan As Integer
    Sub New()
        InitializeComponent()

        DTPesanan = My.Application.DBA.PesananList
        dgvLog.DataSource = DTPesanan

    End Sub

    Private Sub DetailPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailPesananToolStripMenuItem.Click
        If IdHPesanan = 0 Then
            MessageBox.Show("Warning", "Silahkan pilih baris pada tabel terlebih dahulu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fdetailpesanan As New frmDetailLogPesanan(IdHPesanan)

        fdetailpesanan.ShowDialog()
    End Sub

    Private Sub dgvLog_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvLog.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = dgvLog.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then

                IdHPesanan = dgvLog.Item("IdPesanan", HT.RowIndex).Value

                dgvLog.Rows(HT.RowIndex).Selected = True
                dgvLog.ContextMenuStrip = ContextMenuStrip1
            Else
                dgvLog.ContextMenuStrip = Nothing
            End If
        Else
            dgvLog.ContextMenuStrip = Nothing
        End If
    End Sub
End Class