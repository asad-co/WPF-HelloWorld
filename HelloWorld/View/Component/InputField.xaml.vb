Public Class InputField

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As TextChangedEventArgs)
        If String.IsNullOrEmpty(txtInput.Text) Then
            tbPlaceHolder.Visibility = Visibility.Visible
        Else
            tbPlaceHolder.Visibility = Visibility.Hidden
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs)

        txtInput.Clear()
        txtInput.Focus()
        tbPlaceHolder.Visibility = Visibility.Visible
    End Sub
End Class
