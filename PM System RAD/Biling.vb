Imports System.Data.SqlClient

Public Class Biling
    Dim Con As New SqlConnection("Data Source=ITHTHA-SATELLIT;Initial Catalog=PM System;Integrated Security=True")

    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from MedicineTB", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim TB As New DataTable()
        adapter.Fill(TB)
        SelectMedicine.DataSource = TB
        SelectMedicine.DisplayMember = "MediName"
        SelectMedicine.ValueMember = "MediName"
        Con.Close()
    End Sub
    Dim Stock, UPrice
    Private Sub FetchQty()
        Con.Open()
        Dim cmd As New SqlCommand("select * from MedicineTB where MediName='" & SelectMedicine.SelectedValue.ToString() & "'", Con)
        Dim dt As New DataTable
        Dim myReader As SqlDataReader
        myReader = cmd.ExecuteReader()
        While myReader.Read
            Stock = myReader(3).ToString()
            UPrice = myReader(2)
            AvailableStockLB.Text = "Available Stock :" + myReader(3).ToString()
        End While

        Con.Close()
    End Sub

    Private Sub Biling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        FetchQty()
    End Sub

    Private Sub SelectMedicine_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SelectMedicine.SelectionChangeCommitted
        FetchQty()
    End Sub
    Dim i = 0, totPrice
    Dim TotAmount = 0
    Dim GTot As String

    Private Sub AddtoBillBT_Click(sender As Object, e As EventArgs) Handles AddtoBillBT.Click
        If Quantity.Text > Stock Then
            MsgBox("No Enough in Stock")
        ElseIf Quantity.Text = "" Then
            MsgBox("Enter a Quantity")
        Else
            Dim rnum As Integer = DataGridViewBill.Rows.Add()
            i = i + 1
            totPrice = UPrice * Quantity.Text
            DataGridViewBill.Rows.Item(rnum).Cells("Column1").Value = i
            DataGridViewBill.Rows.Item(rnum).Cells("Column2").Value = SelectMedicine.SelectedValue.ToString()
            DataGridViewBill.Rows.Item(rnum).Cells("Column3").Value = Quantity.Text
            DataGridViewBill.Rows.Item(rnum).Cells("Column4").Value = UPrice
            DataGridViewBill.Rows.Item(rnum).Cells("Column5").Value = totPrice
            TotAmount = TotAmount + totPrice
            GTot = TotAmount.ToString()
            TotAmountLB.Text = ("Total Amount : Rs." + GTot)
        End If
    End Sub


    Private Sub PrintBT_Click(sender As Object, e As EventArgs) Handles PrintBT.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.DataGridViewBill.Width, Me.DataGridViewBill.Height)
        DataGridViewBill.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridViewBill.Width, Me.DataGridViewBill.Height))
        e.Graphics.DrawImage(bm, 0, 50)
    End Sub

End Class