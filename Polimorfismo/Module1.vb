Class Derived
    Inherits Base
    Shadows Function F() As String
        Return "Func in derived class"
    End Function
    'Shadows Sub S()
    '    Console.WriteLine("S() in Derived Class")
    'End Sub
End Class



Module Module1
    Sub Main()
        Dim parent As Base = New Base()
        Dim child As Derived = New Derived()

        Console.WriteLine(parent.F())
        Console.WriteLine(parent.F(1))
        Console.WriteLine("------------")

        Console.WriteLine(child.F())
        Console.WriteLine(child.F(1)) 'this should not compile, due to the shadow keyword.

        Console.Read()
    End Sub
End Module
'Dim Bb As Base = New Base()
'Dim Ba As Base = New Derivada_A()
'Dim Bc As Base = New Derivada_C()
''Dim Ab As Derivada_A = New Base() Error (si option strict On)
'Dim Aa As Derivada_A = New Derivada_A()
''Dim Ab As Derivada_A = New Base() Error (si option strict On)
'Dim Cc As Derivada_C = New Derivada_C()

'Console.WriteLine("Bb.F()   = " + Bb.F())
'Console.WriteLine("Bb.F(2)  = " + Bb.F(2))
'Console.WriteLine("Ba.F()   = " + Ba.F())
'Console.WriteLine("Ba.F(2)  = " + Ba.F(2))
'Console.WriteLine("Bc.F()   = " + Bc.F())
'Console.WriteLine("Bc.F(2)  = " + Bc.F(2))
'Console.WriteLine()
'Console.WriteLine("Aa.F()   = " + Aa.F())
'Console.WriteLine("Aa.F(1)  = " + Aa.F(1))
'Console.WriteLine()
'Console.WriteLine("Cc.F()   = " + Cc.F())
'Console.WriteLine("Cc.F(1)  = " + Cc.F(888))
'Cc.F()
'Cc.F(888)


'Console.Read()