Public Class lab1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblIncome.Text = Val(txtSalary.Text) * 12
        lblTax.Text = lblIncome.Text * 5 / 100
        lblBalance.Text = lblIncome.Text - lblTax.Text
    End Sub
End Class