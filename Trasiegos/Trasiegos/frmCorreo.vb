Public Class frmCorreo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmEnviado
        frm.Show()
        Me.Close()

    End Sub
End Class