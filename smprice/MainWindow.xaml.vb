Imports System.ComponentModel

Class MainWindow
    Dim pricebath As Double
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
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If price.Text.Trim = "" Or textBox.Text.Trim = "" Or textBox1.Text.Trim = "" Then
            MessageBox.Show("ยังไม่กรอกราคา ความกว้าง หรือ ความยาว")
            Exit Sub
        End If
        If radioButton.IsChecked = True Then
            pricebath = ((textBox.Text / 100) * (textBox1.Text / 100)) * Val(price.Text)
        ElseIf radioButton1.IsChecked = True Then
            pricebath = (textBox.Text * textBox1.Text) * Val(price.Text)
        Else
            pricebath = ((textBox.Text / 39.37) * (textBox1.Text / 39.37)) * Val(price.Text)
        End If
        label.Content = CStr(pricebath)
        label.Content += " บาท"
    End Sub

    Private Sub price_KeyDown(sender As Object, e As KeyEventArgs) Handles price.KeyDown
        If e.Key = Key.Enter Then
            Call Button_Click(sender, e)
        End If
    End Sub

    Private Sub remo_KeyDown(sender As Object, e As KeyEventArgs) Handles remo.KeyDown
        If e.Key = Key.Enter Then
            labelresu.Content = Val(remo.Text) - pricebath
        End If
    End Sub
End Class
