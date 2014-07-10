Public Class frmtrasiegos

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim frm As New frmDeposityoDestino
        frm.Show()
        Me.Close()

    End Sub
End Class