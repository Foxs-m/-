Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False ' скрыть картинку
        Label1.Text = CStr(Int(Rnd() * 10)) ' выбрать числа
        Label2.Text = CStr(Int(Rnd() * 10)) ' выбрать числа
        Label3.Text = CStr(Int(Rnd() * 10)) ' выбрать числа

        'если одна из цифр-7, то отобразить картинку и издать звук
        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
