Option Compare Text

Module Module1

    Sub Main()
        Dim Member_Name As String = ""
        Dim Member_ID As Integer = 0
        Dim Search_Name As String = ""
        Dim IsFound As Boolean = False

        FileOpen(1, "E:\StudentRecord\MembershipData.txt", OpenMode.Input)

        Console.Write("Enter the name you want to search for : ")
        Search_Name = Console.ReadLine

        While Not EOF(1) And IsFound = False
            Input(1, Member_Name)
            Input(1, Member_ID)

            If Search_Name = Member_Name Then
                IsFound = True
                Console.WriteLine("Member Name : " & Member_Name)
                Console.WriteLine("Member ID : " & Member_ID)
            End If

        End While

        If IsFound = False Then
            Console.WriteLine("Record Not Found...!")
        End If

        FileClose(1)

        Console.ReadKey()
    End Sub

End Module
