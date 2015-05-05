Public Class SearchInterface

    Dim rand As New Random
    Dim searchClass As New GenericLinearSearch()
    Dim integerArray(10) As Integer
    Dim doubleArray(10) As Double

    Private Sub createIntegersButton_Click(sender As Object, e As EventArgs) Handles createIntegersButton.Click
        dataListBox.Items.Clear()
        resultLabel.Text = ""
        Array.Clear(doubleArray, 0, doubleArray.Count)
        dataListBox.Items.Add("Index" & vbTab & "Value")

        For i As Integer = 0 To 10 Step 1
            integerArray(i) = rand.Next(100, 1000)
            dataListBox.Items.Add(i & vbTab & integerArray(i))
        Next

    End Sub

    Private Sub createDoublesButton_Click(sender As Object, e As EventArgs) Handles createDoublesButton.Click
        dataListBox.Items.Clear()
        resultLabel.Text = ""
        Array.Clear(integerArray, 0, integerArray.Count)
        dataListBox.Items.Add("Index" & vbTab & "Value")

        For i As Integer = 0 To 10 Step 1
            doubleArray(i) = Math.Round(rand.NextDouble() * 100, 2, MidpointRounding.AwayFromZero)
            dataListBox.Items.Add(i & vbTab & doubleArray(i))
        Next

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click

        Dim resultValue As Integer

        If (searchKeyTextbox.Text.Contains(".")) Then
            resultValue = searchClass.Search(searchKeyTextbox.Text, doubleArray)
        Else
            resultValue = searchClass.Search(searchKeyTextbox.Text, integerArray)
        End If

        If resultValue >= 0 Then
            resultLabel.Text = "Found value in index " & resultValue
        Else
            resultLabel.Text = "Value not found"
        End If
    End Sub
End Class
