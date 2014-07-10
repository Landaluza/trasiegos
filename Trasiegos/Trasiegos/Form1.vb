Public Class Form1
    Public Sub New()

        InitializeComponent()

        BasesParaCompatibilidad.Config.Server = BasesParaCompatibilidad.DataBase.LOCAL

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New frmtrasiegos
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As New frmOperacionesPendientes
        frm.Show()
        Me.Close()

    End Sub
End Class
