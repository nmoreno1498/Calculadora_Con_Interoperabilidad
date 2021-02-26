Imports operaciones_CSharp 'importo mi biblioteca

Public Class frmCalculadoraInterop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'creo las variables
        Dim numero1 = TextBox1.Text
        Dim numero2 = TextBox2.Text

        'creo una clase c#
        Dim obj As New Clase_CSharp()
        lblResultS.Text = "Suma " + obj.operacionSuma(numero1, numero2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero1 = TextBox1.Text
        Dim numero2 = TextBox2.Text

        'creo una clase c#
        Dim obj As New Clase_CSharp()
        lblResultR.Text = "Resta " + obj.operacionResta(numero1, numero2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numero1 = TextBox1.Text
        Dim numero2 = TextBox2.Text

        'llamada a f#
        Dim obj As New Clase_CSharp()

        lblResultM.Text = FuncionesFSharp.operacionMultiplicacion(numero1, numero2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numero1 = TextBox1.Text
        Dim numero2 = TextBox2.Text

        'llamada a f#
        Dim obj As New Clase_CSharp()

        lblResultD.Text = FuncionesFSharp.operacionDivision(numero1, numero2)
    End Sub
End Class
