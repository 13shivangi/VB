Imports System

Module Program
    Sub Main(args As String())
        Dim objSample As New sample()
        objSample.StringProperty = "Vb is alike english!!"
        objSample.PrintSomeValue()
        Dim value As String = objSample.GetSomeValue()
        Console.WriteLine("Value = " + value)

        Dim objrectangle As New Rectangle()
        Dim drawn As String = objrectangle.Draw()
        objrectangle.Display()
        Console.WriteLine(drawn)


        'CallingFunction()
        'subtract(100, 45)
        'Addition()
        'Multiplication(10, 20)
        'Division(10, 5)

    End Sub

    Private Sub CallingFunction()
        Dim names As List(Of String) = returnNames()
        For index = 0 To names.Count - 1
            Console.WriteLine(names(index))
        Next
    End Sub
    'known as function when it returns a value
    Private Function returnNames() As List(Of String)
        Dim strNames As New List(Of String)
        strNames.Add("Eena")
        strNames.Add("Mena")
        strNames.Add("Tena")
        Return strNames
    End Function
    'known as subroutine when it does not return
    Private Sub Division(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 / v2)
    End Sub

    Private Sub Multiplication(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 * v2)
    End Sub

    Private Sub subtract(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 - v2)
    End Sub

    Private Sub Addition()
        Dim n1 As Integer = 100
        Dim n2 As Integer = 100
        Dim result As Integer = n1 + n2
        Console.WriteLine(result)
    End Sub
End Module
