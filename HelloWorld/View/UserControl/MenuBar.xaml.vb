Public Class MenuBar

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As RoutedEventArgs)
        Dim parentWindow As Window = Window.GetWindow(Me)

        If parentWindow IsNot Nothing Then
            parentWindow.WindowState = WindowState.Minimized
        End If
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As RoutedEventArgs)
        Dim parentWindow As Window = Window.GetWindow(Me)

        If parentWindow IsNot Nothing Then
            If parentWindow.WindowState = WindowState.Maximized Then
                parentWindow.WindowState = WindowState.Normal
                btnMaximize.Content = "🗖"
            Else
                parentWindow.WindowState = WindowState.Maximized
                btnMaximize.Content = "🗗"
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs)
        Application.Current.Shutdown()
    End Sub
End Class
