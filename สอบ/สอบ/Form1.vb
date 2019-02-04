Public Class Form1
    Dim netpm As Double
    Dim total, water, pm, gk, air, netwater, totalpm As Integer
    Private Sub radbt67_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbt67.CheckedChanged
        radbt67.Enabled = True
        water = lblwater1.Text
        pm = lblpm1.Text
    End Sub

    Private Sub radbt75_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbt75.CheckedChanged
        radbt75.Enabled = True
        water = lblwater2.Text
        pm = lblpm2.Text
    End Sub

    Private Sub radbt90_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbt90.CheckedChanged
        radbt90.Enabled = True
        water = lblwater3.Text
        pm = lblpm3.Text
    End Sub

    Private Sub radbis19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbis19.CheckedChanged
        radbis19.Enabled = True
        water = lblwater4.Text
        pm = lblpm4.Text

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        gk = txt1.Text * txt2.Text
        lblgk.Text = gk
        air = txtair.Text
        netwater = air * water
        lblwater.Text = netwater
        totalpm = pm
        totalpm = pm * air
        netpm = totalpm / 60
        lblpm.Text = FormatNumber(totalpm, 2)
    End Sub
End Class