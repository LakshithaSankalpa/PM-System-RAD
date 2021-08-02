Imports System.Data.SqlClient

Public Class Manufacturer
    Dim Con As New SqlConnection("Data Source=ITHTHA-SATELLIT;Initial Catalog=PM System;Integrated Security=True")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from CompanyTB"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewCompny.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Public Sub Clear()
        CompanyIDTB.Text = ""
        CompanyNameTB.Text = ""
        PhoneNumberTB.Text = ""
        Address.Text = ""
        populate()
    End Sub

    Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
        Clear()
    End Sub

    Private Sub Manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub AddBT_Click(sender As Object, e As EventArgs) Handles AddBT.Click
        If CompanyIDTB.Text = "" Then
            MsgBox("No Company ID Selected")
        ElseIf CompanyNameTB.Text = "" Or PhoneNumberTB.Text = "" Or Address.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("insert into CompanyTB values('" & CompanyIDTB.Text & "','" & CompanyNameTB.Text & "','" & PhoneNumberTB.Text & "','" & Address.Text & "')", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Company Successfully Added")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If CompanyIDTB.Text = "" Then
            MsgBox("No Company ID Selected")
        Else
            Con.Open()
            Dim query As String
            query = "delete from CompanyTB where CompID='" & CompanyIDTB.Text & "' or CompName='" & CompanyNameTB.Text & "' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Company Successfully Deleted")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub UpdateBT_Click(sender As Object, e As EventArgs) Handles UpdateBT.Click
        If CompanyIDTB.Text = "" Then
            MsgBox("No Company ID Selected")
        ElseIf CompanyNameTB.Text = "" Or PhoneNumberTB.Text = "" Or Address.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("Update CompanyTB where CompID='" & CompanyIDTB.Text & "', CompName='" & CompanyNameTB.Text & "',CompPhone='" & PhoneNumberTB.Text & "',CompAddress='" & Address.Text & "' ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Company Successfully Updated")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub ViewBT_Click(sender As Object, e As EventArgs) Handles ViewBT.Click
        Con.Open()
        Dim cmd2 As New SqlCommand
        cmd2 = New SqlCommand("select * from CompanyTB  where CompID='" & CompanyIDTB.Text & "' or CompName='" & CompanyNameTB.Text & "' ", Con)
        Dim adpt As SqlDataAdapter
        adpt = New SqlDataAdapter(cmd2)
        Dim ds2 As DataSet
        ds2 = New DataSet()
        adpt.Fill(ds2)
        Con.Close()

        Dim count As Integer = ds2.Tables(0).Rows.Count
        If (count = 1) Then
            Con.Open()
            Dim sql = "select * from CompanyTB  where CompID='" & CompanyIDTB.Text & "' Or CompName='" & CompanyNameTB.Text & "' "
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sql, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            DataGridViewCompny.DataSource = ds.Tables(0)

            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select * from CompanyTB  where  CompID='" & CompanyIDTB.Text & "' Or CompName='" & CompanyNameTB.Text & "'", Con)
            Dim myReader As SqlDataReader
            myReader = cmd.ExecuteReader()
            myReader.Read()

            CompanyIDTB.Text = myReader("CompID")
            CompanyNameTB.Text = myReader("CompName")
            PhoneNumberTB.Text = myReader("CompPhone")
            Address.Text = myReader("CompAddress")
            myReader.Close()
            Con.Close()
        Else
            MsgBox("Incomplete Data")
            Clear()
        End If
    End Sub



    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PhoneNumberTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumberTB.KeyPress
        NumberOnly(e)
    End Sub
End Class