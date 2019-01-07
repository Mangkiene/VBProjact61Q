Public Class frmfrist

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim salary As Integer
        name = TextBox1.Text
        salary = TextBox2.Text
        lblname.Text = name
        lblsaraly.Text = salary
        lbltex.Text = salary * 12
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
