Public Class Derivada_A
    Inherits Base

    Overloads Function F() As String
        Return "F en Derivada_A"
    End Function

    Sub erf()

    End Sub

End Class

Public Class Derivada_C
    Inherits Base

    Shadows Function F() As String
        Return "F en Derivada_B"
    End Function

    Sub erf()

    End Sub

End Class