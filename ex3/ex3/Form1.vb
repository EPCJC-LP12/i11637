Public Class Form1



    Private Sub Jogo7()
        Dim numero As Random = New Random
        Dim n As Integer
        n = numero.Next(1, 9)
        TextBox1.Text = n
        If n = 7 Then
            PictureBox1.Visible = True
            Label1.Hide()
        Else
            PictureBox1.Visible = False
            Label1.Show()

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Jogo7()


        
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
