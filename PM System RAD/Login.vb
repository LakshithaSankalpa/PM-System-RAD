Imports System.Data.SqlClient

Public Class Login
    Dim Con As New SqlConnection("Data Source=ITHTHA-SATELLIT;Initial Catalog=PM System;Integrated Security=True")


    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Con.Open()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("select * from EmployeeTB  where  EmpID=@UsName and EmpPassword=@Pw ", Con)
        cmd.Parameters.Add("@UsName", SqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@Pw", SqlDbType.VarChar).Value = TextBox2.Text
        Dim myAdapter As SqlDataAdapter
        myAdapter = New SqlDataAdapter(cmd)
        Dim myTable As DataTable
        myTable = New DataTable()
        myAdapter.Fill(myTable)


        If myTable.Rows.Count() <= 0 Then
            MessageBox.Show("Username OR Password Are Invalid", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clear()
        Else
            MessageBox.Show("Login Success..!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim obj = New Home
            obj.Show()
        End If

        Con.Close()

    End Sub
    Public Sub Clear()
        TextBox1.ResetText()
        TextBox2.ResetText()
    End Sub

    Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
        Clear()
    End Sub
End Class