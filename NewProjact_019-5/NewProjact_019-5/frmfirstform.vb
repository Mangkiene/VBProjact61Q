Public Class frmfirstform

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        'ค่าจ้าง = ชั่วโมงการทำงาน * อัตราค่าจ้างต่อชั่วโมง
        'ภาษี = ค่าจ้าง*0.03
        'ชั่วโมงการทำงาน => tst1.text
        'อัตราค่าจ้างต่อชั่วโมง => txt.text

        'lbl1.Text = Val(txt1.Text) * Val(txt2.Text)
        'lbl2.Text = lbl1.Text * 0.03
        'int hours 
        Dim Hours As Integer
        Dim Payreat As Long
        Dim Resuit, Tax As Long
        Hours = Val(txt1.Text)
        Payreat = Val(txt2.Text)

        Resuit = Hours * Payreat
        Tax = Resuit * 0.03

        lbl1.Text = Resuit
        lbl2.Text = Tax
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Me.Close()
    End Sub
End Class
