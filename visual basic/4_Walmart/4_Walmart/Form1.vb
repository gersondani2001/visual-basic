Public Class Form1

    '' este codigo ''


    ''''Dim button2 As New Form2
    '' button2.Show()''
    ''Me.Hide() ''''

    ''este codigo anterio va a estar en todas los formulario para vincular o entrar a otro formulario''

    ''ejemplo 1    10101001010''



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim button2 As New Form2
        button2.Show()
        Me.Hide() ''ejemplo 1    10101001010''

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim button1 As New Form3
        button1.Show()
        Me.Hide() ''ejemplo 1    10101001010''
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim button3 As New Form4
        button3.Show()
        Me.Hide() ''ejemplo 1    10101001010''
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim button4 As New Form5
        button4.Show()
        Me.Hide()
    End Sub ''ejemplo 1    10101001010''

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim button5 As New Form6
        button5.Show()
        Me.Hide() ''ejemplo 1    10101001010''
    End Sub
End Class
