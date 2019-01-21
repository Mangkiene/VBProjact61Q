Public Class frmLab10
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale As Integer
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim a As Integer
        If cboindex.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลำดับพนักงาน")
            Exit Sub
        End If
        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("กรุณาป้อนตัวเลข")
            txtSaleName.Text = ""
            txtSaleA.Text = ""
            txtSaleB.Text = ""
            txtSaleC.Text = ""
        End If

    End Sub
End Class