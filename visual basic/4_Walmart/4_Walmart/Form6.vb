Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim button1 As New Form1
        button1.Show()
        Me.Hide() ''ejemplo 1    10101001010''

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._4_WalmartDataSet) ''validacion de base de datos''

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._4_WalmartDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_4_WalmartDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._4_WalmartDataSet.Clientes)


        ''compruebo que los textbox esten vasios sin ningun dato pasa entre veces que al momento de querer obtener el dato de base de datos falla''
        '' ""comillas es = textbox sin texto ahora textbox.text = que todo sera = a un texto ''
        Usuario_walmartTextBox.Text = ""
        Pass_walmartTextBox.Text = ""


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ''lo mas confuso validacion de datos por medio de una consulta a la base de datos ''
        ''dirigirse a 4_walmartdataset.xsd para pedir la sonculta y tomar medias de =? para conseguir el dato''
        ''se origina una base de datos con una funcion creada y la funcion es buscardatos para buscar usuario y pass''
        If Me.ClientesTableAdapter.BuscarDATOS(Me._4_WalmartDataSet.Clientes, Usuario_walmartTextBox.Text, Pass_walmartTextBox.Text) Then
            Form7.Show() ''ejemplo 1    10101001010''
            Me.Close() ''ejemplo 1    10101001010 esta en form1 info''
        Else
            MsgBox("Datos incorrectos !!! Vuelva a intentar.") ''mensaje de error si llega a suceder algo  malo en el ingreso de datos''
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class