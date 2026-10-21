Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSinus_Click(sender As Object, e As EventArgs) Handles btnSinus.Click
        Dim ugao As Double = Val(TextBox1.Text)
        Dim radijani As Double = ugao * Math.PI / 180
        TextBox2.Text = Math.Sin(radijani)
    End Sub

    Private Sub btnCosinus_Click(sender As Object, e As EventArgs) Handles btnCosinus.Click
        Dim ugao As Double = Val(TextBox1.Text)
        Dim radijani As Double = ugao * Math.PI / 180
        TextBox2.Text = Math.Cos(radijani)
    End Sub
End Class
