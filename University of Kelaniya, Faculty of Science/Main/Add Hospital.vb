Imports System.Data.SqlClient
Imports System
Imports System.Text

Public Class formAdd_Hospital

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim row1 As DShos.HospitalRow
        row1 = DShos1.Hospital.NewHospitalRow
        row1.Hospital_ID = txtHosid.Text
        row1.Hospital_Name = txtHosname.Text
        row1.District = txtDis.Text
        row1.Province = txtProvince.Text

        Try
            DShos1.Hospital.AddHospitalRow(row1)
            DAhos.Update(DShos1)


        Catch ex As Exception
            MsgBox("Error" & ex.Message)

        End Try
    End Sub

    Private Sub formAdd_Hospital_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        DAhos.Fill(DShos1)
        lblUser.Text = user
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtHosid.Text = DataGridView1.Item(0, i).Value
        txtHosname.Text = DataGridView1.Item(1, i).Value
        txtDis.Text = DataGridView1.Item(2, i).Value
        txtProvince.Text = DataGridView1.Item(3, i).Value

    End Sub


   
    
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim sql As String = "Update Hospital set Hospital_Name='" & txtHosname.Text & "' where Hospital_ID='" & txtHosid.Text & " ' "
        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"
            'you need to provide password for sql server
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            If MessageBox.Show("Do you want to  ", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation cancel")
            End If

            myConnection.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtDis.Clear()
        txtHosid.Clear()
        txtHosname.Clear()
        txtProvince.Clear()

    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim sql As String = "Delete from Hospital where Hospital_ID='" & txtHosid.Text & " ' "
        Try
            myConnection.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=True"
            'you need to provide password for sql server
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            If MessageBox.Show("do you want to delete ", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation cancel")
            End If

            myConnection.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUser.Click

    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        formSelect_Category.Show()
        Me.Hide()
    End Sub
End Class