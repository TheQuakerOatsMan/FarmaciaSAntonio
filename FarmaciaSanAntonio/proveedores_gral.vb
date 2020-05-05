Public Class proveedores_gral
    Private Sub proveedores_gral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioDataSet.PROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORESTableAdapter.Fill(Me.FarmSAntonioDataSet.PROVEEDORES)
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioDataSet6.PROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORESTableAdapter2.Fill(Me.FarmSAntonioDataSet6.PROVEEDORES)
        menuprin.Enabled = False
    End Sub

    Private Sub salirprovt_Click(sender As Object, e As EventArgs) Handles salirprovt.Click
        menuprin.Enabled = True
        Close()
    End Sub
End Class