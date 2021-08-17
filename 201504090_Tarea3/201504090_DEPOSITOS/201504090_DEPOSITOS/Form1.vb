Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Visible = True
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            TextBox1.Clear()
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox2.Visible = True
            TextBox2.Clear()
            TextBox2.Focus()
        Else
            TextBox2.Clear()
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox3.Visible = True
            TextBox3.Clear()
            TextBox3.Focus()
        Else
            TextBox3.Clear()
            TextBox3.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case Saldonuevo
            Case 1.01 To 1000.99
                interes = 1.5 / 100
            Case 1001 To 5000.99
                interes = 2.5 / 100
            Case 5001 To 15000.99
                interes = 7.5 / 100
            Case Is >= 15001
                interes = 10 / 100
        End Select
        Saldonuevo = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
        Saldonuevo = Saldonuevo + (Saldonuevo * interes)
        TextBox5.Text = Str(Saldonuevo)

        If RadioButton2.Checked = True Then
            Select Case Val(TextBox4.Text)
                Case 1.01 To 10000.99
                    interes = 2.5 / 100
                Case 10001 To 15000.99
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100
            End Select
            Saldonuevo = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) * interes
            TextBox5.Text = Str(Saldonuevo)
        End If

        If RadioButton1.Checked = True Then
            Saldonuevo = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
            TextBox5.Text = Str(Saldonuevo)
        End If

        TextBox6.Text = Str(interes * 100) + "%"
    End Sub
End Class
