Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Preço, Consumo, Distancia, res1, res2 As Double
        Preço = CDbl(TextBox1.Text)
        Consumo = TextBox2.Text
        Distancia = TextBox3.Text

        res1 = Consumo * Distancia / 100
        res2 = res1 * Preço

        TextBox4.Text = res1
        TextBox5.Text = res2
    End Sub
End Class
