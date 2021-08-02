Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to Exit ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit") = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel11_Click(sender As Object, e As EventArgs) Handles Panel11.Click

        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next


    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Are you sure you want to log-out?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit") = MsgBoxResult.Yes Then
            Me.Hide()
            Dim obj = New Login
            obj.Show()
        Else
        End If

    End Sub

    Private Sub MedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicineToolStripMenuItem.Click
        Dim frmNProject As New Medicine
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub


    Private Sub ManufacturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManufacturerToolStripMenuItem.Click
        Dim frmNProject As New Manufacturer
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click
        Dim frmNProject As New Biling
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Dim frmNProject As New Dashbord
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLB.Text = Date.Now.ToLongTimeString
        DateLB.Text = Date.Now.ToLongDateString

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim frmNProject As New Employee
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub

    Private Sub GrgrgrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrgrgrToolStripMenuItem.Click
        Dim frmNProject As New About
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub

    Private Sub HomeMS_Click(sender As Object, e As EventArgs) Handles HomeMS.Click
        Dim frmNProject As New Dashbord
        frmNProject.MdiParent = Me
        frmNProject.Show()
    End Sub
End Class