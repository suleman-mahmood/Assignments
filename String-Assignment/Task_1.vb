Module Module1

    Sub Main()
        Dim No_of_donuts As Integer = 0

        Console.Write("Enter the No.of Donuts : ")
        No_of_donuts = Console.ReadLine

        If No_of_donuts < 10 Then Console.Write("Number of Donuts : " & No_of_donuts)
        If No_of_donuts >= 10 Then Console.Write("Number of Donuts : Many")

        Console.ReadKey()
    End Sub

End Module
