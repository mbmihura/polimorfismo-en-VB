Public Class Base
    Function F() As String
        Return "F() in Base Class"
    End Function

    Function F(ByVal n As Integer) As String
        Return "F(" + n.ToString() + ") in Base Class"
    End Function

    'Sub S()
    '    Console.WriteLine("S() in Base class")
    'End Sub
    'Sub S(ByVal n As Integer)
    '    Console.WriteLine("S(" + n.ToString() + ") in Base class")
    'End Sub
End Class
