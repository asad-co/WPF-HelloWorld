Class MainWindow

    Dim running As Boolean = False
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        DragMove()
    End Sub

    'Private Sub ChangeText_Click(sender As Object, e As RoutedEventArgs)
    '    helloWorldText.Text = "Hello, WPF in Vb.Net"
    '    helloWorldText.FontSize = 50
    'End Sub

    'Private Sub btnRun_Click(sender As Object, e As RoutedEventArgs)
    '    If Not running Then
    '        helloWorldText.Text = "Hello, WPF in Vb.Net"
    '        helloWorldText.FontSize = 50
    '        running = True
    '    Else
    '        helloWorldText.Text = "Stopped running!"
    '        helloWorldText.FontSize = 30
    '        running = False
    '    End If
    'End Sub
End Class
