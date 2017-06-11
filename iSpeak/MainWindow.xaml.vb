

Class MainWindow

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click

        Dim speech = CreateObject("sapi.spvoice")
        speech.speak(text.Text)

    End Sub
End Class
