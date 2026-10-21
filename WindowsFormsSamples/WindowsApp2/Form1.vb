Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Dim brojPrelaza As Integer = 0
    Private Sub BrojiPrelaske(sender As Object, e As EventArgs) Handles btnPrelasci.MouseHover
        brojPrelaza += 1
        TextBox1.Text = $"{brojPrelaza}"
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        brojPrelaza = 0
        TextBox1.Text = $"{brojPrelaza}"
    End Sub

    Private Sub btnPrelasci_Click(sender As Object, e As EventArgs) Handles btnPrelasci.Click

    End Sub
End Class
