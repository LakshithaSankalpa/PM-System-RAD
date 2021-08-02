Imports System.Data.SqlClient

Public Class Dashbord
    Dim Con As New SqlConnection("Data Source=ITHTHA-SATELLIT;Initial Catalog=PM System;Integrated Security=True")

    Private Sub Dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MediFillLables()
        CompFillLables()
        EmpFillLables()
    End Sub

    Private Sub MediFillLables()
        Con.Open()
        Dim query = "select Count(*) from MedicineTB "
        Dim cmd As SqlCommand

        cmd = New SqlCommand(query, Con)
        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        MediLB.Text = count.ToString()

        Con.Close()
    End Sub
    Private Sub CompFillLables()
        Con.Open()
        Dim query = "select Count(*) from CompanyTB "
        Dim cmd As SqlCommand

        cmd = New SqlCommand(query, Con)
        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        CompLB.Text = count.ToString()

        Con.Close()
    End Sub
    Private Sub EmpFillLables()
        Con.Open()
        Dim query = "select Count(*) from EmployeeTB "
        Dim cmd As SqlCommand

        cmd = New SqlCommand(query, Con)
        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        EmpLB.Text = count.ToString()

        Con.Close()
    End Sub

End Class