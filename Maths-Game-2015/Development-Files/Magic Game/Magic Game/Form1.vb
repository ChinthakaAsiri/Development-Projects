Public Class Form1

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        lblProceed.Visible = True
        lblClickNext.Visible = True
        lblNext1.Visible = True
        btnNext1.Visible = True
    End Sub


    Private Sub btnNext1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext1.Click
        lblNext1.Visible = False
        lblNext2.Visible = True
        btnNext1.Visible = False
        btnNext2.Visible = True
    End Sub

    Private Sub btnNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        lblNext2.Visible = False
        lblNext3.Visible = True
        btnNext2.Visible = False
        btnNext3.Visible = True
    End Sub

    Private Sub btnNext3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext3.Click
        lblNext3.Visible = False
        lblNext4.Visible = True
        btnNext3.Visible = False
        btnNext4.Visible = True
    End Sub

    Private Sub btnNext4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext4.Click
        lblNext4.Visible = False
        lblNext5.Visible = True
        btnNext4.Visible = False
        btnOk.Visible = True
        txtAns.Visible = True
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim y As Integer
        y = Convert.ToInt32(txtAns.Text)
        btnExit.Visible = True
        lblOk1.Visible = True
        lblOk2.Visible = True
        lblOk2.Text = y - 15
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
