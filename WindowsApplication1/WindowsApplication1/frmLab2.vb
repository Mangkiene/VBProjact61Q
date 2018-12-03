Public Class frmLab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vistra, frusta, sum, com1, com2, total As Long
        vistra = txt1.Text
        frusta = txt2.Text

        com1 = vistra * 0.05
        com2 = frusta * 0.1
        lbl1.Text = com1
        lbl2.Text = com2

        sum = Val(txt1.Text) + Val(txt2.Text)
        total = Val(lbl1.Text) + Val(lbl2.Text)
        lbl3.Text = sum
        lbl4.Text = total

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
