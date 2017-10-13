Imports System.Text


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mesBytes() As Byte = Encoding.UTF8.GetBytes(TextBox1.Text)
        TextBox2.Text = Convert.ToBase64String(mesBytes)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim mesBytes() As Byte = Convert.FromBase64String(TextBox1.Text)
            TextBox2.Text = Encoding.UTF8.GetString(mesBytes)
        Catch ex As Exception
            MessageBox.Show("Erreur de cryptage!")
        End Try
    End Sub
End Class
