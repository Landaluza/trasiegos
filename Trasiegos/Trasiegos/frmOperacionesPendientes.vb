Public Class frmOperacionesPendientes

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim frm As New frmCantidad
        frm.Show()
        Me.Close()

    End Sub
End Class