Public Class frmAssign3

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtDigis.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtDigis.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtDigis.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtDigis.ForeColor = Color.Pink
    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        txtDigis.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtDigis.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtDigis.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtDigis.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        txtDigis.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        txtDigis.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBRed.Click
        txtDigis.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlue.Click
        txtDigis.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGreen.Click
        txtDigis.BackColor = Color.Green
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBViolet.Click
        txtDigis.BackColor = Color.Pink
    End Sub

    Private Sub lblBBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlack.Click
        txtDigis.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBOrange.Click
        txtDigis.BackColor = Color.Orange

    End Sub

    Private Sub lblByellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblByellow.Click
        txtDigis.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBrown.Click
        txtDigis.BackColor = Color.Brown
    End Sub

    Private Sub lblBWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBWhite.Click
        txtDigis.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBSky.Click
        txtDigis.BackColor = Color.SkyBlue
    End Sub

    Private Sub btnHigh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        Dim nb As Long

        nb = txtDigis.Text

        nb = Val(nb) + 3

        txtDigis.Text = nb
    End Sub

    Private Sub btnLow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLow.Click
        Dim nb As Long

        nb = txtDigis.Text

        nb = Val(nb) - 3

        txtDigis.Text = nb
    End Sub

    Private Sub cboSelect_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Integer = Val(cboSelect.Text)
        txtDigis.Font = New Font(txtDigis.Font.Name, size, FontStyle.Regular)
        txtDigis.Text = FormatNumber(txtDigis.Text, 0)
    End Sub
End Class