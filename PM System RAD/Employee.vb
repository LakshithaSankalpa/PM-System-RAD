Imports System.Data.SqlClient

Public Class Employee
    Dim Con As New SqlConnection("Data Source=ITHTHA-SATELLIT;Initial Catalog=PM System;Integrated Security=True")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from EmployeeTB"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewEMP.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Public Sub Clear()
        EmployeeIDTB.Text = ""
        EmployeeNameTB.Text = ""
        EmployeeAgeTB.Text = ""
        EmployeeSalaryTB.Text = ""
        Phone.Text = ""
        Password.Text = ""
        UserNameLB.Text = "------"
        populate()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub AddBT_Click(sender As Object, e As EventArgs) Handles AddBT.Click
        If EmployeeIDTB.Text = "" Then
            MsgBox("No Employee ID Selected")
        ElseIf EmployeeNameTB.Text = "" Or EmployeeAgeTB.Text = "" Or EmployeeSalaryTB.Text = "" Or Phone.Text = "" Or Password.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("insert into EmployeeTB values('" & EmployeeIDTB.Text & "','" & EmployeeNameTB.Text & "','" & EmployeeSalaryTB.Text & "','" & EmployeeAgeTB.Text & "','" & Phone.Text & "','" & Password.Text & "')", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Successfully Added")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If EmployeeIDTB.Text = "" Then
            MsgBox("No Employee Selected")
        Else
            Con.Open()
            Dim query As String
            query = "delete from EmployeeTB where MediName='" & EmployeeIDTB.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Successfully Deleted")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub UpdateBT_Click(sender As Object, e As EventArgs) Handles UpdateBT.Click
        If EmployeeIDTB.Text = "" Then
            MsgBox("No Employee Selected")
        ElseIf EmployeeNameTB.Text = "" Or EmployeeAgeTB.Text = "" Or EmployeeSalaryTB.Text = "" Or Phone.Text = "" Or Password.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("Update EmployeeTB set EmpID='" & EmployeeIDTB.Text & "',EmpName='" & EmployeeNameTB.Text & "',EmpSal='" & EmployeeSalaryTB.Text & "',EmpAge ='" & EmployeeAgeTB.Text & "',EmpPhone='" & Phone.Text & "',EmpPassword='" & Password.Text & "' where EmpID='" & EmployeeIDTB.Text & "' ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Successfully Updated")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub ViewBT_Click(sender As Object, e As EventArgs) Handles ViewBT.Click
        Con.Open()
        Dim cmd2 As New SqlCommand
        cmd2 = New SqlCommand("select * from EmployeeTB  where EmpID='" & EmployeeIDTB.Text & "' Or EmpName='" & EmployeeNameTB.Text & "'", Con)
        Dim adpt As SqlDataAdapter
        adpt = New SqlDataAdapter(cmd2)
        Dim ds2 As DataSet
        ds2 = New DataSet()
        adpt.Fill(ds2)
        Con.Close()

        Dim count As Integer = ds2.Tables(0).Rows.Count
        If (count = 1) Then
            Con.Open()
            Dim sql = "select * from EmployeeTB  where EmpID='" & EmployeeIDTB.Text & "' Or EmpName='" & EmployeeNameTB.Text & "' "
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sql, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            DataGridViewEMP.DataSource = ds.Tables(0)

            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select * from EmployeeTB  where  EmpID='" & EmployeeIDTB.Text & "' Or EmpName='" & EmployeeNameTB.Text & "'", Con)
            Dim myReader As SqlDataReader
            myReader = cmd.ExecuteReader()
            myReader.Read()

            EmployeeIDTB.Text = myReader("EmpID")
            EmployeeNameTB.Text = myReader("EmpName")
            EmployeeSalaryTB.Text = myReader("EmpSal")
            EmployeeAgeTB.Text = myReader("EmpAge")
            Phone.Text = myReader("EmpPhone")
            Password.Text = myReader("EmpPassword")
            myReader.Close()
            Con.Close()
        Else
            MsgBox("Incomplete Data")
            Clear()
        End If
    End Sub

    Public Sub alphabetOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32) Then

        Else
            e.Handled = True
        End If
    End Sub

    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8) Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
        Clear()
    End Sub

    Private Sub EmployeeNameTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeNameTB.KeyPress
        alphabetOnly(e)
    End Sub

    Private Sub EmployeeAgeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeAgeTB.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub EmployeeSalaryTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeSalaryTB.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub EmployeeIDTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeIDTB.KeyPress
        UserNameLB.Text = EmployeeIDTB.Text
    End Sub

    Private Sub EmployeeIDTB_Leave(sender As Object, e As EventArgs) Handles EmployeeIDTB.Leave
        UserNameLB.Text = EmployeeIDTB.Text
    End Sub
End Class