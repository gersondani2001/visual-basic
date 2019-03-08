Public Class Form4
    Private Sub MercaderiaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MercaderiaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MercaderiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._4_WalmartDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_4_WalmartDataSet.Mercaderia' Puede moverla o quitarla según sea necesario.
        Me.MercaderiaTableAdapter.Fill(Me._4_WalmartDataSet.Mercaderia) ''base de datos en algunos formulario para la validacion de registros''


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim button5 As New Form1
        button5.Show()
        Me.Hide() ''ejemplo 1    10101001010''
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class