Module Module1
    Public InteresAcomulado As Double
    Public SaldoAnterior
    Public Saldonuevo As Double
    Public interes

    Sub Limpiar()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.TextBox4.Focus()

    End Sub
End Module
