Imports System.ComponentModel

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        If radioButton.IsChecked = True Then
            label.Content = CStr(((textBox.Text / 100) * (textBox1.Text / 100)) * 100)
            label.Content += " บาท"
        Else
            label.Content = CStr((textBox.Text * textBox1.Text) * 100)
            label.Content += " บาท"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        If radioButton.IsChecked = True Then
            label.Content = CStr(((textBox.Text / 100) * (textBox1.Text / 100)) * 400)
            label.Content += " บาท"
        Else
            label.Content = CStr((textBox.Text * textBox1.Text) * 400)
            label.Content += " บาท"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        If radioButton.IsChecked = True Then
            label.Content = CStr(((textBox.Text / 100) * (textBox1.Text / 100)) * 500)
            label.Content += " บาท"
        Else
            label.Content = CStr((textBox.Text * textBox1.Text) * 500)
            label.Content += " บาท"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As RoutedEventArgs) Handles button3.Click
        textBox.Text = ""
        textBox1.Text = ""
        label.Content = ""
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case MsgBox("คุณต้องการที่จะออกจากโปรแกรม", MsgBoxStyle.YesNo, "ใช่ หรือ ไม่")
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As RoutedEventArgs) Handles button4.Click
        button.Visibility = Visibility.Hidden
        button1.Visibility = Visibility.Hidden
        button2.Visibility = Visibility.Hidden
        textBox2.Visibility = Visibility.Visible
        button5.Visibility = Visibility.Visible
    End Sub
End Class
