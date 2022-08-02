Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System
Imports System.Text

Public Class Drug_Distribute

    Private Sub Drug_Distribute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        SqlDataAdapter1.Fill(DsClient1)
    End Sub

    Private Sub btnDistribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistribute.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim total, oldQty, sentQty As Integer
        oldQty = CInt(lblQtyinHos.Text)
        sentQty = CInt(txtAmount.Text)
        total = oldQty - sentQty
        Dim sql As String = "Update Minimum_Requirmrnt set [Qty in Hospital]='" & total & "' where Drug_ID='" & lblDrugID.Text & " ' "

        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()

            If MessageBox.Show("Do you want to Distribute ", "Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MsgBox("Operation cancel")
            End If
            myConnection.Close()
        Catch ex As Exception
        End Try

        SqlDataAdapter1.Fill(DsClient1)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        lblQtyinHos.Text = DataGridView1.Item(2, i).Value
        lblDrugID.Text = DataGridView1.Item(0, i).Value
    End Sub
End Class