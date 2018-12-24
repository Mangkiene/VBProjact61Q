Public Class frmLab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vistra, frista, sum, com1, com2, total As Long
        vistra = txtvis.Text
        frista = txtvri.Text

        com1 = vistra * 0.05
        com2 = frista * 0.1
        lblvis.Text = com1
        lblfri.Text = com2

        sum = Val(txtvis.Text) + Val(txtvri.Text)
        total = Val(lblvis.Text) + Val(lblfri.Text)
        lbltotal.Text = sum
        lblcom.Text = total

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
