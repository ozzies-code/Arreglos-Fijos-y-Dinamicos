# Arreglos Fijos y Dinamicos

 Este proyecto busca demostrar las diferencias entre trabajar 
 con un arreglo dimensionado de forma fija y un Arreglo 
 dimensionado de forma dinamica durante la fase de ejecucion 
 del proyecto usando las palabras reservadas Redim y Preserve.

# Descripcion

 Este proyecto consiste en una aplicacion que maneja temperaturas
 a traves de un array que es dimensionado de manera dinamica por el 
 usuario con la palabra reservada Redim a traves de un InputBox.
 Seguidamente se recorre el Arreglo con un Ciclo For empleando el 
 metodo Ubond: Una Funcion que devuelve el limite superior de un 
 Arreglo. La idea es determinar varias temperaturas para despues 
 mostrarlas poir pantalla pero que sea el usuario quien defina cuantas
 veces se llevara a cabo este proceso a traves de la redimension del 
 Arreglo a traves de la palabra resevada Redim. Tambien se emplea 
 la palabra reservada Preserve que conserva los datos del arreglo 
 aunque cambien sus dimensiones. Despues se muestra por pantalla
 un promedio de las temperaturas introducidas por el usuario.
 
 # Actualizacion: 08/01/2025
 # Hora: 05:36

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# Fixed and Dynamic Arrays

This project seeks to demonstrate the differences between working
with a fixed-sized array and a dynamically sized array during the
execution phase of the project using the Redim and Preserve keywords.

# Description

This project consists of an application that handles temperatures
through an array that is dynamically sized by the user with the Redim
reserved word through an InputBox.
The Array is then traversed with a For Loop using the
Ubond method: A Function that returns the upper limit of an Array. 
The idea is to determine several temperatures to later display them on 
the screen, but the user is the one who defines how many times this 
process will be carried out through the resizing of the Array through 
the Redim reserved word. The reserved word Preserve is also used, 
which preserves the array data even if its dimensions change. 
An average of the temperatures entered by the user is then displayed
on the screen.

# Update: 01/08/2025
# Time: 05:36

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/eeb525f5-0803-4529-9ac3-b8c791911312)

Code of the Project:

Public Class Form1

    Dim Temperatura() As Single 'Arreglo Dinamico
    Dim Dias As Integer

    Private Sub btnItrTemp_Click(sender As Object, e As EventArgs) Handles btnItrTemp.Click
        Dim Prompt, Title As String
        Dim i As Short
        Prompt = "Escriba la temperatura mas alta del dia"

        Dias = InputBox("Cuantos dias?", "Crear Arreglo")
        If Dias > 0 Then ReDim Temperatura(Dias - 1)

        For i = 0 To UBound(Temperatura) 'Ubond: Funcion que devuelve el limite superior de un Arreglo
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
