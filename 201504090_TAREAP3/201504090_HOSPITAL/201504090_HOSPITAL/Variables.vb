Module Variables
    'matriz(filas,columnas)'
    Public matriz(6, 9) As String

    Public index = 0

    'limpiar 
    Sub limpiarentradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub


End Module
