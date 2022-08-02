Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System
Imports System.Text
Public Class formDrug_Avalability

    Private Sub formDrug_Avalability_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand

        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"
            Dim min As SqlCommand = New SqlCommand("select distinct from Hospital.District ")
            'you need to provide password for sql server
            myConnection.Open()
            myCommand.Connection = myConnection
            'myCommand.CommandText = min

            Dim dataSet As DataSet = New DataSet()
            Dim dataAdapter As New SqlDataAdapter()
            dataAdapter.SelectCommand = min
            dataAdapter.Fill(dataSet, "District")
            Dim datTable As DataTable = dataSet.Tables("District")
            For x = 0 To datTable.Rows.Count - 1
                ComboBox1.Items.Add(datTable.Rows(x).Item("District"))
            Next

            myCommand.ExecuteNonQuery()


            myConnection.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        lblMedID.Text = DataGridView1.Item(0, i).Value
        lblMedName.Text = DataGridView1.Item(2, i).Value
        lblHos_ID.Text = DataGridView1.Item(1, i).Value
        lblQtyInHos.Text = DataGridView1.Item(3, i).Value
        lblQtyInStock.Text = DataGridView1.Item(6, i).Value
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        SqlDataAdapter1.Fill(DsMinReq12)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand

        Dim sql As String = "Update Minimum_Requirmrnt set [Qty sent to hospital]='" & txtStockSend.Text & "' where Drug_ID='" & lblMedID.Text & " '  and Hospital_ID='" & lblHos_ID.Text & "'"

        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"

            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch ex As Exception
        End Try

        Dim myConnection1 As New SqlConnection
        Dim myCommand1 As New SqlCommand
        Dim total, inHand, sent As Integer

        inHand = CInt(lblQtyInHos.Text)
        sent = CInt(txtStockSend.Text)
        total = inHand + sent
        Dim sql1 As String = "Update Minimum_Requirmrnt set [Qty in hospital]='" & total & "' where Drug_ID='" & lblMedID.Text & " '  and Hospital_ID='" & lblHos_ID.Text & "'"

        Try
            myConnection1.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"

            myConnection1.Open()
            myCommand1.Connection = myConnection1
            myCommand1.CommandText = sql1
            myCommand1.ExecuteNonQuery()
            myConnection1.Close()
        Catch ex As Exception
        End Try


        Dim myConnection2 As New SqlConnection
        Dim myCommand2 As New SqlCommand
        Dim total2, inStock, sent2 As Integer

        inStock = CInt(lblQtyInStock.Text)
        sent2 = CInt(txtStockSend.Text)
        total2 = inStock - sent2

        Dim sql2 As String = "Update Drug set [Qty in Stock]='" & total2 & "' where Drug_ID='" & lblMedID.Text & " '"

        Try
            myConnection2.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"

            myConnection2.Open()
            myCommand2.Connection = myConnection2
            myCommand2.CommandText = sql2
            myCommand2.ExecuteNonQuery()

            If MessageBox.Show("Do you want to Send the Stock ", "Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MsgBox("Operation cancel")
            End If
            myConnection2.Close()
        Catch ex As Exception
        End Try

        SqlDataAdapter1.Fill(DsMinReq12)
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

   

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        formSelect_Category.Show()
        Me.Hide()
    End Sub
End Class