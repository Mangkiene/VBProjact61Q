Public Class Frmjob4

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.ShortDate)
    End Sub
    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.GeneralDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub
    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim salary, sale, ysalary, bonus, allncome, allowance, tax As Double
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07

        salary = txtSalary.Text
        sale = txtSale.Text

        ysalary = salary * 12
        bonus = sale * decR_BONUS
        allncome = ysalary + bonus
        allowance = allncome * decR_ALLOW
        tax = (allncome - allowance) * decR_TAX

        lblYearSalary.Text = ysalary
        lblBonus.Text = bonus
        lblAllIncome.Text = allncome
        lblAllowance.Text = allowance
        lblTax.Text = tax
    End Sub
End Class