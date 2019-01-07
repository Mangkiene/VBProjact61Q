Public Class frmLed7

    Private Sub btnEnterPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        txtAdd.Focus()
        Dim n As String
        n = lstAdd.Items.Count
        lstAdd.SelectedIndex = n - 1
    End Sub

    Private Sub bntClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cboOutput.Items.Clear()
        lstAdd.Items.Clear()
        txtAdd.Clear()
        lblOutput.Text = ""
        cboOutput.Text = ""

    End Sub

    Private Sub btnToRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim R As Integer
        If lstAdd.SelectedIndex < 0 Then
            MessageBox.Show("ไม่มีข้อมูล")
            Exit Sub
        End If
        R = lstAdd.SelectedIndex
        cboOutput.Items.Add(lstAdd.SelectedItem)
        If lstAdd.SelectedIndex = lstAdd.Items.Count - 1 Then
            lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        Else
            lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
            lstAdd.SelectedIndex = R

        End If
        cboOutput.SelectedIndex = cboOutput.Items.Count - 1

    End Sub

    Private Sub btnToRightAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")
        End If
        For Each item As Object In lstAdd.Items
            cboOutput.Items.Add(item)
        Next
        lstAdd.Items.Clear()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAdd.Text = ""
        lblOutput.Text = ""
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()

    End Sub

    Private Sub btnToLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim n As Integer
        If cboOutput.SelectedIndex < 0 Then
            MessageBox.Show("ไม่มีข้อมูล")
            Exit Sub
        End If

        n = cboOutput.SelectedIndex
        lstAdd.Items.Add(cboOutput.SelectedItem)

        If cboOutput.SelectedIndex = cboOutput.Items.Count - 1 Then
            cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        Else
            cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
            cboOutput.SelectedIndex = n

        End If
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1

        If cboOutput.Items.Count = 0 Then
            cboOutput.Text = ""

        End If
    End Sub

    Private Sub btnToLeftAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ไม่มีข้อมูล")
        Else
            Dim list As New List(Of Object)
            For Each item As Object In cboOutput.Items
                list.Add(item)
                On Error Resume Next
            Next
            For Each item As String In list
                lstAdd.Items.Add(item)
                cboOutput.Items.Remove(item)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next
        End If
        cboOutput.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub lblSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.Text
    End Sub

    Private Sub txtEnterPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text.Trim() = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub frmAction7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class