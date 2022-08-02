Public Class formSelect_Category

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub formSelect_Category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblUser.Text = user
    End Sub

    Private Sub btnAddHospital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHospital.Click
        formAdd_Hospital.Show()
        Me.Hide()
    End Sub

    Private Sub lblUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUser.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnAddDrug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDrug.Click
        formAdd_Drug.Show()
        Me.Hide()
    End Sub

    Private Sub btnDrugAvalability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrugAvalability.Click
        formDrug_Avalability.Show()
        Me.Hide()
    End Sub
End Class