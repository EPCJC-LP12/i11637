Public Class Form1

    Private Sub Jogar()
        Dim r1 As Random = New Random()
        Dim n1, n2, n3, i As Integer

        i = 0
        While i < 3
            n1 = r1.Next(1, 9)
            i += 1
            n2 = r1.Next(1, 9)
            i += 1
            n3 = r1.Next(1, 9)
            i += 1
        End While

        TextBox1.Text = n1
        TextBox2.Text = n2
        TextBox3.Text = n3

        If n1 = 7 And n2 = 7 Or n1 = 7 And n3 = 7 Or n3 = 7 And n2 = 7 Then

            PictureBox1.Visible = True
            Label1.Hide()
        Else
            PictureBox1.Visible = False
            Label1.Show()

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Jogar()
    End Sub
End Class
