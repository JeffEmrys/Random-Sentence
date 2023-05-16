Public Class Form1

    Private strArticles() As String = {"the", "a"}
    Private strAdjectives() As String = {"shiny", "huge", "red", "blue", "fierce", "lazy", "smart", "crazy"}
    Private strNouns() As String = {"computer", "mosquito", "dog", "cat", "tree", "book", "cup", "chair"}
    Private strVerbs() As String = {"flew", "ran", "jumped", "slept", "ate", "talked", "wrote", "swam"}
    Private strPrepositions() As String = {"over", "under", "around", "through", "on", "in", "beside", "behind"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNextsentence_Click(sender As Object, e As EventArgs) Handles btnNextsentence.Click
        Dim sentence As String = ""
        For i As Integer = 0 To 7
            Select Case i
                Case 0, 5 ' article
                    sentence &= strArticles(GetRandomIndex(strArticles)) & " "
                Case 1, 6 ' adjective
                    sentence &= strAdjectives(GetRandomIndex(strAdjectives)) & " "
                Case 2, 7 ' noun
                    sentence &= strNouns(GetRandomIndex(strNouns)) & " "
                Case 3 ' verb
                    sentence &= strVerbs(GetRandomIndex(strVerbs)) & " "
                Case 4 ' preposition
                    sentence &= strPrepositions(GetRandomIndex(strPrepositions)) & " "
            End Select
        Next
        sentence = Char.ToUpper(sentence(0)) & sentence.Substring(1) ' capitalize first letter
        sentence &= "." ' add period at the end
        lstSentences.Items.Add(sentence)
    End Sub

    Private Function GetRandomIndex(array() As String) As Integer
        Return CInt(Math.Floor(Rnd() * array.Length))
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSentences.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
