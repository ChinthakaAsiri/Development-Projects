Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System
Imports System.Text

Public Class formAdd_Drug




    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim row As DSdrug.DrugRow
        row = DSdrug1.Drug.NewDrugRow
        row.Drug_ID = txtDrugid.Text
        row.DrugName = txtDrugname.Text
        row.BrandName = txtBrand.Text
        row.Qty_in_Stock = txtQtyinStock.Text
        row.Total_Qty_Ordered = txtQtyoreder.Text
        row.ManufaDate = txtMdate.Text
        row.ExpDate = txtEdate.Text
        row.ReceiveDate = txtReceive.Text
        row.Orderdate = txtOrderdate.Text

        Try
            DSdrug1.Drug.AddDrugRow(row)
            DAdrug.Update(DSdrug1)
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub formAdd_Drug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        DAdrug.Fill(DSdrug1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim sql As String = "Delete from Drug where Drug_ID='" & txtDrugid.Text & " ' "
        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"
            'you need to provide password for sql server
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            If MessageBox.Show("Do you want to delete ", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MsgBox("Operation cancel")
            End If

            myConnection.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim sql As String = "Update Drug set ExpDate='" & txtEdate.Text & "', [Total Qty Ordered]='" & txtQtyinStock.Text & "' , ManufaDate='" & txtMdate.Text & "', [Qty in Stock]='" & txtQtyinStock.Text & "', Orderdate='" & txtOrderdate.Text & "', ReceiveDate='" & txtReceive.Text & "' where Drug_ID='" & txtDrugid.Text & " ' "
        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"
            'you need to provide password for sql server
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            If MessageBox.Show("Do you want to Update ", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MsgBox("Operation cancel")
            End If

            myConnection.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtBrand.Clear()
        txtDrugid.Clear()
        txtDrugname.Clear()
        txtEdate.Clear()
        txtMdate.Clear()
        txtOrderdate.Clear()
        txtQtyinStock.Clear()
        txtQtyoreder.Clear()
        txtReceive.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtBrand.Text = DataGridView1.Item(8, i).Value
        txtDrugid.Text = DataGridView1.Item(0, i).Value
        txtDrugname.Text = DataGridView1.Item(1, i).Value
        txtEdate.Text = DataGridView1.Item(6, i).Value
        txtMdate.Text = DataGridView1.Item(5, i).Value
        txtOrderdate.Text = DataGridView1.Item(3, i).Value
        txtQtyinStock.Text = DataGridView1.Item(7, i).Value
        txtQtyoreder.Text = DataGridView1.Item(2, i).Value
        txtReceive.Text = DataGridView1.Item(4, i).Value
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        formSelect_Category.Show()
        Me.Hide()
    End Sub
End Class