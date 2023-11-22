# This file contains custom DOCS which I made for my self

# Why the import statement?
```vb
Imports System.Console
Module Module1
' by importing system.console we dont have to write console.writeline again and again
    Sub Main()
        WriteLine("Hello World")
    End Sub
End Module
```
# ReadLine()
> ReadLine() is basically the input statement for Visual Basic
```vb
Imports System.Console
Module Module1
    Sub Main()
        Dim n1 As Integer
        Dim n2 As Integer
        Dim total As Integer
        write("Enter first number: ")
        n1 = ReadLine() ' input the number asked above
        write("Enter second number: ")        
        n2= ReadLine() ' input the number asked above
        total = n1 + n2
        WriteLine("Your total is " & total)
    End Sub
End Module
```
# WriteLine()
> WriteLine() is basically the output statement for Visual Basic
```vb
Imports System.Console
Module Module1
    Sub Main()
        Dim n1 As Integer
        Dim n2 As Integer
        Dim total As Integer
        write("Enter first number: ")
        n1 = ReadLine() ' input the number asked above
        write("Enter second number: ")        
        n2= ReadLine() ' input the number asked above
        total = n1 + n2
        WriteLine("Your total is " & total) ' output the answer
    End Sub
End Module
```
# write() / Write()
>Write() / write() is basically the input statement in VB
```vb
Imports System.Console
Module Module1
    Sub Main()
        Dim n1 As Integer
        Dim n2 As Integer
        Dim total As Integer
        write("Enter first number: ") ' asking user to input the stuff  
        n1 = ReadLine() ' input the number asked above
        write("Enter second number: ")  ' asking user to input the stuff      
        n2= ReadLine() ' input the number asked above
        total = n1 + n2
        WriteLine("Your total is " & total) ' output the answer
    End Sub
End Module
```