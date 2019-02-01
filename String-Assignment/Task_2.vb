Module Module1

    Sub Main()
        Dim Input_string As String = ""
        Dim Left_string As String = ""
        Dim Right_string As String = ""

        Console.Write("Enter String : ")
        Input_String = Console.ReadLine

        Left_string = Left(Input_string, 2)
        Right_string = Right(Input_string, 2)

        If Len(Input_string) < 2 Then
            Console.Write("The Length of string is less than 2")
        Else
            Console.Write("The new string is : " & Left_string & Right_string)
        End If
        Console.ReadKey()
    End Sub

End Module
