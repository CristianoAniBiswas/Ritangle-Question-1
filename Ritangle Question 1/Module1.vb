Module Module1

    Sub Main()
        Dim leftCog() As Integer = {1, 2, 3, 4, 5, 6, 7, 8}
        Dim middleCog() As Integer = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
        Dim rightCog() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

        Dim leftIndex As Integer = 0
        Dim middleIndex As Integer = 0
        Dim rightIndex As Integer = 0

        Dim S As Integer = 0
        Dim T As Double = 0

        For x = 1 To 792
            Dim leftNum As Integer = leftCog(leftIndex)
            Dim middleNum As Integer = middleCog(middleIndex)
            Dim rightNum As Integer = rightCog(rightIndex)

            Dim num As Integer = (leftNum * 1000) + (middleNum * 10) + (rightNum)

            S += num
            T += leftNum * middleNum * rightNum

            middleIndex = (middleIndex + 1) Mod middleCog.Length
            leftIndex = (leftIndex - 1 + leftCog.Length) Mod leftCog.Length
            rightIndex = (rightIndex - 1 + rightCog.Length) Mod rightCog.Length
        Next

        Console.WriteLine(S / T)
    End Sub

End Module
