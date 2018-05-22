Public Class AlumnoGrid

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        AlumnoForm.operacion = "Nuevo"
        AlumnoForm.Text = "Nuevo de Alumno"
        AlumnoForm.Show()

    End Sub

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        AlumnoForm.operacion = "Elimina"
        AlumnoForm.Text = "Elimina Alumno"
        AlumnoForm.indice = DataGridView1.CurrentRow.Index
        LlenarForm()
        AlumnoForm.Show()
    End Sub

    Private Sub Llenarform()
        AlumnoForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AlumnoForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AlumnoForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AlumnoForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AlumnoForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifica.Click
        AlumnoForm.operacion = "Modifica"
        AlumnoForm.Text = "Modifica Alumno"
        AlumnoForm.indice = DataGridView1.CurrentRow.Index
        Llenarform()
        AlumnoForm.Show()
    End Sub

    Private Sub AlumnoGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.DataSource = lst

    End Sub
End Class