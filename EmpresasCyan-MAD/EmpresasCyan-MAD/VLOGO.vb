Public Class ID_VLOGO
    Dim y As Integer
    Private Sub ID_VLOGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1000
        y = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If y = 2 Then
            ID_VINISES.Show()
            Me.Close()
        Else
            y = y + 1
        End If
    End Sub
End Class