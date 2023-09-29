Imports System

Module Program
    Public BirthYear As Integer
    Public Answer As Integer
    Sub Main(args As String())
        Console.WriteLine(vbCrLf + "What's your name? ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Hello, {name}! Today is {currentDate:d}, time {currentDate:t}")
        Console.WriteLine(vbCrLf + "What year were you born? State the year and press Enter")
        BirthYear = Console.ReadLine()
        Answer = Now.Year - BirthYear
        Console.WriteLine("You are " & Answer & " years old!")
        Console.Write(vbCrLf + "Press any key to exit... ")
        Console.ReadKey(True)
    End Sub
End Module