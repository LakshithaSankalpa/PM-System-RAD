Public Class Loading
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        ProgIncrement.Text = ProgressBar1.Value & ("%")
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Dim obj = New Login
            obj.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(ProgressBar1.Handle, 1040, 2, 0)
        Timer1.Start()

    End Sub

End Class
