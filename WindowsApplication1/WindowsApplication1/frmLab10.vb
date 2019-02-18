Public Class frmLab10
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale As Integer
    Dim sumA, sumB, sumC, max, total(4) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim i As Integer
        If cboIndex.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกจำนวนพนักงาน")
            Exit Sub
        End If
        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("ข้อมูลไม่ถูกต้อง กรุณาป้อนตัวเลข")
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleName.Clear()
            cboIndex.Text = ""
            Exit Sub
        Else
            i = Val(cboIndex.SelectedItem) - 1
            saleName(i) = txtSaleName.Text
            decSale(i, 0) = Val(txtSaleA.Text)
            decSale(i, 1) = Val(txtSaleB.Text)
            decSale(i, 2) = Val(txtSaleC.Text)
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleName.Clear()
            cboIndex.Text = ""


            Call showData()
            sumA = decSale(0, 0) + decSale(1, 0) + decSale(2, 0) + decSale(3, 0) + decSale(4, 0)
            sumB = decSale(0, 1) + decSale(1, 1) + decSale(2, 1) + decSale(3, 1) + decSale(4, 1)
            sumC = decSale(0, 2) + decSale(2, 2) + decSale(2, 2) + decSale(3, 2) + decSale(4, 2)

            lblSumA.Text = sumA
            lblSumB.Text = sumB
            lblSumC.Text = sumC

            Call totalMax()
            lblMaxSaleAmount.Text = max
            lblMaxSaleName.Text = Name
        End If




    End Sub
    Private Sub showData()
        lstData.Items.Clear()
        For i = 0 To 4
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2) & ",")
            total(i) = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

        Next


    End Sub
    Private Sub totalMax()
        For i = 0 To 4
            If total(i) > max Then
                max = total(i)
                Name = saleName(i)
            Else
                max = max
                Name = Name
            End If
        Next
    End Sub

End Class