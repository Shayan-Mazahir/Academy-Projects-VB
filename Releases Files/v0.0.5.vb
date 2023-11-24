Imports System.Console
Module Module1
' by importing system.console we dont have to write console.writeline again and again
    Sub Main()
        Dim n As Integer
        write("Enter a number: ")
        n = ReadLine() 'ReadLine() is the input statement
        WriteLine("Your number is " & n)
        WriteLine("Square of number is " & n * n)
        WriteLine("Hello AS")
        WriteLine("Welcome to programming")
    End Sub
End Module