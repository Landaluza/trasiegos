Public Class frmFinSeleccion

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmCorrecto
        frm.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmCorreo
        Me.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmniveles
        frm.Show()
        Me.Close()

    End Sub
End Class