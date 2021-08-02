Imports System.Data.SqlClient

Public Class Medicine
    Dim Con As New SqlConnection("Data Source=ITHTHA-SATELLIT;Initial Catalog=PM System;Integrated Security=True")


    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from CompanyTB", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim TB As New DataTable()
        adapter.Fill(TB)
        CompanyCB.DataSource = TB
        CompanyCB.DisplayMember = "CompName"
        CompanyCB.ValueMember = "CompName"
        Con.Close()
    End Sub

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from MedicineTB"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewMedi.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub AddBT_Click(sender As Object, e As EventArgs) Handles AddBT.Click
        If MedicineNameTB.Text = "" Then
            MsgBox("No Medicine Selected")
        ElseIf BuyingPriceTB.Text = "" Or SellingPriceTB.Text = "" Or Quantity.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("insert into MedicineTB values('" & MedicineNameTB.Text & "','" & BuyingPriceTB.Text & "','" & SellingPriceTB.Text & "','" & Quantity.Text & "','" & ExpDatePicker.Text & "','" & CompanyCB.SelectedValue.ToString() & "')", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Added")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If MedicineNameTB.Text = "" Then
            MsgBox("No Medicine Selected")
        Else
            Con.Open()
            Dim query As String
            query = "delete from MedicineTB where MediName='" & MedicineNameTB.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Deleted")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub UpdateBT_Click(sender As Object, e As EventArgs) Handles UpdateBT.Click
        If MedicineNameTB.Text = "" Then
            MsgBox("No Medicine Selected")
        ElseIf BuyingPriceTB.Text = "" Or SellingPriceTB.Text = "" Or Quantity.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("Update MedicineTB set MediName='" & MedicineNameTB.Text & "',BPrice='" & BuyingPriceTB.Text & "',SPrice='" & SellingPriceTB.Text & "',MedQty='" & Quantity.Text & "',ExpDate ='" & ExpDatePicker.Text & "',Company='" & CompanyCB.SelectedValue.ToString() & "' where MediName ='" & MedicineNameTB.Text & "' ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Updated")
            Con.Close()
            populate()
            Clear()
        End If
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        FillCombo()
        CompanyCB.SelectedValue = ""
    End Sub

    Private Sub Quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Quantity.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub BuyingPriceTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BuyingPriceTB.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub SellingPriceTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SellingPriceTB.KeyPress
        NumberOnly(e)
    End Sub

    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8) Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ViewBT_Click(sender As Object, e As EventArgs) Handles ViewBT.Click
        '//////////
        Con.Open()
        Dim cmd2 As New SqlCommand
        cmd2 = New SqlCommand("select * from MedicineTB  where MediName='" & MedicineNameTB.Text & "'", Con)
        Dim adpt As SqlDataAdapter
        adpt = New SqlDataAdapter(cmd2)
        Dim ds2 As DataSet
        ds2 = New DataSet()
        adpt.Fill(ds2)
        Con.Close()

        Dim count As Integer = ds2.Tables(0).Rows.Count
        If (count = 1) Then
            Con.Open()
            Dim sql = "select * from MedicineTB  where MediName='" & MedicineNameTB.Text & "'"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sql, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            DataGridViewMedi.DataSource = ds.Tables(0)

            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select * from MedicineTB  where MediName='" & MedicineNameTB.Text & "'", Con)
            Dim myReader As SqlDataReader
            myReader = cmd.ExecuteReader()
            myReader.Read()

            BuyingPriceTB.Text = myReader("BPrice")
            SellingPriceTB.Text = myReader("SPrice")
            Quantity.Text = myReader("MedQty")
            ExpDatePicker.Text = myReader("ExpDate")
            CompanyCB.SelectedValue = myReader("Company")

            myReader.Close()
            Con.Close()
        Else
            MsgBox("Incomplete Data")
            Clear()
        End If

    End Sub

    Public Sub Clear()
        MedicineNameTB.Text = ""
        BuyingPriceTB.Text = ""
        SellingPriceTB.Text = ""
        Quantity.Text = ""
        ExpDatePicker.Text = ""
        CompanyCB.SelectedValue = ""
        populate()
    End Sub

    Private Sub ClearBT_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
        Clear()
    End Sub
End Class

