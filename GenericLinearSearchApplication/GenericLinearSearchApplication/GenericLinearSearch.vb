Public Class GenericLinearSearch

    Public Function Search(Of T As IComparable(Of T))(x As T, y As T())

        For i As Integer = 0 To y.Length - 1 Step 1
            If x.CompareTo(y(i)) = 0 Then
                Return i
            End If
        Next
        Return -1
    End Function

End Class
