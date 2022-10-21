Public MustInherit Class Shape

    Public MustOverride Function Draw() As String

    'Virtual method : use "Ovverridable"
    Public Overridable Sub Display()
        Console.WriteLine("Vb is like English!!")
    End Sub

End Class

Public Class Rectangle
    Inherits Shape

    Public Overrides Function Draw() As String
        Return "Rectangle Drawn"
    End Function

    Public Overrides Sub Display()
        Console.WriteLine("Rectangle is a class that inherits shape")
    End Sub
End Class