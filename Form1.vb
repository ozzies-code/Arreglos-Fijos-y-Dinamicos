Public Class Form1

    Dim Temperatura() As Single 'Arreglo Dinamico
    Dim Dias As Integer

    Private Sub btnItrTemp_Click(sender As Object, e As EventArgs) Handles btnItrTemp.Click
        Dim Prompt, Title As String
        Dim i As Short
        Prompt = "Escriba la temperatura mas alta del dia"

        Dias = InputBox("Cuantos dias?", "Crear Arreglo")
        If Dias > 0 Then ReDim Temperatura(Dias - 1)

        For i = 0 To UBound(Temperatura) 'Ubond: Funcion que devuelve el indice superior de un Arreglo
            Title = "Dia " & (i + 1)
            Temperatura(i) = InputBox(Prompt, Title)
        Next
        'la palabra reservada Preserve conserva los datos del arreglo aunque cambien sus dimensiones
        'Dim filosofos(200)
        'filosofos(200) = "Alfonso Reyes"
        'Redim Preserve filosofos(300)
    End Sub

    Private Sub btnMostrarTemp_Click(sender As Object, e As EventArgs) Handles btnMostrarTemp.Click

        Dim Resultado As String
        Dim i As Short
        Dim Total As Single = 0
        Resultado = "Temperaturas altas:" & vbCrLf & vbCrLf

        For i = 0 To UBound(Temperatura) 'Ubond: Funcion que devuelve el indice superior de un Arreglo
            Resultado = Resultado & "Dia " & (i + 1) & vbTab & Temperatura(i) & vbCrLf
            Total = Total + Temperatura(i)
        Next
        'vbCrLf: Retorno de Carro./n
        'vbTab: Tabulador
        Resultado = Resultado & vbCrLf & "Temperatura Promedio: " & Format(Total / Dias, "0.0")
        txtTemp.Text = Resultado
    End Sub
End Class
