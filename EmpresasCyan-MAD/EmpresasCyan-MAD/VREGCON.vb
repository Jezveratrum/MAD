Public Class ID_VREGCON
    Private Sub ID_BNREGINC_Click(sender As Object, e As EventArgs) Handles ID_BNREGINC.Click

        MessageBox.Show("Su información ha sido registrada exitosamente")

        MessageBox.Show("Verifique que los datos hayan sido capturados correctamente")

    End Sub

    Private Sub ID_BNCANINC_Click(sender As Object, e As EventArgs) Handles ID_BNCANINC.Click
        ID_VPRINCIPAL.Show()
        Me.Close()
    End Sub
End Class