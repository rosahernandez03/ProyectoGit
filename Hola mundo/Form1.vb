Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btntexto_Click(sender As Object, e As EventArgs) Handles Btntexto.Click
        txttexto.Text += "Hola mundo"


    End Sub

    Private Sub Borrartexto_Click(sender As Object, e As EventArgs) Handles Borrartexto.Click
        txttexto.Clear()

    End Sub
End Class
