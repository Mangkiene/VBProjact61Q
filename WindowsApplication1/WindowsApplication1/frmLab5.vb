Public Class frmLab5
    Public decTotal, decDiscount, decNet, decCradit As Double

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text)
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        gpbPaid.Enabled = True
        radPaid.Checked = True
        radCredit.Checked = False
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        radPaid.Checked = True
        gpbPaid.Enabled = False
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radOther.Checked = True
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        decTotal = lblTotal.Text
        If txtProduct.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            txtProduct.Clear()
        End If

        If Not IsNumeric(txtPrice.Text) Or Not IsNumeric(txtUnit.Text) Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            txtPrice.Clear()
            txtUnit.Clear()
        End If

        If radMember.Checked = True Then
            If decTotal >= 10000 Then
                decDiscount = decTotal * 0.15
            ElseIf decTotal >= 5000 Then
                decDiscount = decTotal * 0.1
            ElseIf decTotal >= 1000 Then
                decDiscount = decTotal * 0.05
            Else
                decDiscount = 0
            End If
        ElseIf radOther.Checked = True Then
            decDiscount = 0
        End If

        decNet = decTotal - decDiscount
        If radPaid.Checked = True Then
            decCradit = 0
        ElseIf radCredit.Checked = True Then
            decCradit = decTotal
        End If

        lblDiscount.Text = decDiscount
        lblPaid.Text = decNet
        lblCredit.Text = decCradit

        If radCredit.Checked = True Then
            lblDiscount.Text = 0
            lblPaid.Text = decTotal
            lblCredit.Text = decCradit
        End If
    End Sub

    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub lblDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDiscount.Click

    End Sub
End Class