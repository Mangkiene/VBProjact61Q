Public Class frmJob6
    Dim Z As DialogResult
    Dim Price As Integer
    Private Sub chkCarForMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.Click
        If chkCarForMe.Checked = False Then
            Z = MessageBox.Show("ท่านต้องการยกเลิกการซื้อหรือไม่", "คำเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Z = Windows.Forms.DialogResult.Yes Then

                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkFree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""

            Else
                chkCarForMe.Checked = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True

            End If


        Else
            Price = Val(lblPaidPrice.Text)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = 1250000 + 25000 + 15000 + 35000

        End If
    End Sub


    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 40000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 40000
        End If
    End Sub


    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 50000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 50000
        End If
    End Sub


    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 20000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 20000
        End If
    End Sub


    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 30000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 30000
        End If
    End Sub


    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 25000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 25000
        End If
    End Sub


    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 15000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 15000
        End If
    End Sub


    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 35000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 35000
        End If
    End Sub
End Class