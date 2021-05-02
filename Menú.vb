Public Class Menú
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("Está seguro que desea salir?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim cli As New Clientes
        cli.BackColor = Color.Red
        cli.ShowDialog()
    End Sub

    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        Dim prv As New Proveedores
        prv.BackColor = Color.Green
        prv.ShowDialog()
    End Sub

    Private Sub bListados_Click(sender As Object, e As EventArgs) Handles bListados.Click
        Dim lst As New Listados
        lst.BackColor = Color.Blue
        lst.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("Está seguro que desea Salir?") Then End

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cli As New Clientes
        cli.BackColor = Color.Red
        cli.ShowDialog()
    End Sub

    Private Sub ListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosToolStripMenuItem.Click
        Dim lst As New Listados
        lst.BackColor = Color.Blue
        lst.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim prv As New Proveedores
        prv.BackColor = Color.Green
        prv.ShowDialog()
    End Sub
End Class
