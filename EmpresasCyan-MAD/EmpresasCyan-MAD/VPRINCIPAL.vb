Public Class ID_VPRINCIPAL
    Private Sub ID_MNREGEMPL_Click(sender As Object, e As EventArgs) Handles ID_MNREGEMPL.Click
        ID_VREGEMPLEADO.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGEMPR_Click(sender As Object, e As EventArgs) Handles ID_MNREGEMPR.Click
        ID_VREGEMPRESA.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGDEP_Click(sender As Object, e As EventArgs) Handles ID_MNREGDEP.Click
        ID_VREGDEP.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGPUE_Click(sender As Object, e As EventArgs) Handles ID_MNREGPUE.Click
        ID_VREGPUE.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNCERSESGER_Click(sender As Object, e As EventArgs) Handles ID_MNCERSESGER.Click
        MessageBox.Show("¿Seguro de que sea salir?", "Salir", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation)
        'IF YES CLOSE
        Me.Close()
    End Sub
    Private Sub ID_MNREGINCGEN_Click(sender As Object, e As EventArgs) Handles ID_MNREGINCGEN.Click
        ID_VREGCON.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGINCEMPL_Click(sender As Object, e As EventArgs) Handles ID_MNREGINCEMPL.Click
        ID_VREGPERDED.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGPERGEN_Click(sender As Object, e As EventArgs) Handles ID_MNREGPERGEN.Click
        ID_VREGCON.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGPERGENEMPL_Click(sender As Object, e As EventArgs) Handles ID_MNREGPERGENEMPL.Click
        ID_VREGPERDED.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGDEDGEN_Click(sender As Object, e As EventArgs) Handles ID_MNREGDEDGEN.Click
        ID_VREGCON.Show()
        Me.Close()
    End Sub
    Private Sub ID_MNREGDEDEMPL_Click(sender As Object, e As EventArgs) Handles ID_MNREGDEDEMPL.Click
        ID_VREGPERDED.Show()
        Me.Close()
    End Sub
End Class
