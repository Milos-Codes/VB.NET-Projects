Public Class Form1


    Private Sub Izracunajpovrsinu(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        Dim a As Double = Val(TextBox1.Text)
        Dim b As Double = Val(TextBox2.Text)
        Dim povrsina As Double = a * b
        TextBox3.Text = $"{povrsina}"


    End Sub
End Class
