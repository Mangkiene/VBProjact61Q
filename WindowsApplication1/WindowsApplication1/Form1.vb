Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim salary, total As Integer
        name = TextBox1.Text
        salary = TextBox2.Text
        Label6.Text = name
        Label7.Text = salary
        Label8.Text = salary * 12
    End Sub
End Class
