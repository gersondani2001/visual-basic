Public Class Form3
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._4_WalmartDataSet) ''base de datos en algunos formulario para la validacion de registros''


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_4_WalmartDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me._4_WalmartDataSet.Empleados)

    End Sub

    Private Sub IdEmpleadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdEmpleadoTextBox.TextChanged

    End Sub

    Private Sub IdEmpleadoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub ApellidoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ApellidoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ApellidoTextBox.TextChanged

    End Sub

    Private Sub SueldoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SueldoTextBox_TextChanged(sender As Object, e As EventArgs) Handles SueldoTextBox.TextChanged

    End Sub

    Private Sub PuestoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PuestoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PuestoTextBox.TextChanged

    End Sub

    Private Sub AguinaldoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AguinaldoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AguinaldoTextBox.TextChanged

    End Sub

    Private Sub Bono14Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bono14TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bono14TextBox.TextChanged

    End Sub

    Private Sub BonosLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BonosTextBox_TextChanged(sender As Object, e As EventArgs) Handles BonosTextBox.TextChanged

    End Sub

    Private Sub BonificacionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BonificacionTextBox_TextChanged(sender As Object, e As EventArgs) Handles BonificacionTextBox.TextChanged

    End Sub

    Private Sub ISRLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ISRTextBox_TextChanged(sender As Object, e As EventArgs) Handles ISRTextBox.TextChanged

    End Sub

    Private Sub IGSSLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IGSSTextBox_TextChanged(sender As Object, e As EventArgs) Handles IGSSTextBox.TextChanged

    End Sub

    Private Sub IRTRALabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IRTRATextBox_TextChanged(sender As Object, e As EventArgs) Handles IRTRATextBox.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim button5 As New Form1
        button5.Show()
        Me.Hide() ''ejemplo 1    10101001010''
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick

    End Sub
End Class