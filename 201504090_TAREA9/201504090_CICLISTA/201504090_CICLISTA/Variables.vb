Module Variables
    'vectores
    Public Etapa(11) As Integer
    Public Equipo(11) As String
    Public Distanncia(11) As Integer
    Public Tiempo(11) As Integer
    Public Nacionalidad(11) As String
    Public Penalizacion(11) As Integer
    Public TiempoFinal(11) As Integer
    Public fila As Byte = 0

    Sub limpiarentradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
    End Sub
    Sub mostrarvectores()
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 10
            If (Equipo(i) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Etapa(i), Equipo(i), Distanncia(i), Tiempo(i), Nacionalidad(i), Penalizacion(i), TiempoFinal(i))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub limpiarvectores()
        Form1.DataGridView1.Rows.Clear()
        fila = 0
        For i = 0 To 10
            Etapa(i) = Nothing
            Equipo(i) = Nothing
            Distanncia(i) = Nothing
            Tiempo(i) = Nothing
            Nacionalidad(i) = Nothing
            Penalizacion(i) = Nothing
            TiempoFinal(i) = Nothing
        Next
    End Sub

    Sub salir()
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Form1.Close()
        Else
            limpiarentradas()
        End If
    End Sub

    Sub limparestadistica()
        Form1.txt1.Clear()
        Form1.txt2.Clear()
        Form1.txt3.Clear()
        Form1.txt4.Clear()
        Form1.txtsky.Clear()
        Form1.txtcycling.Clear()
        Form1.txtmovistar.Clear()
        Form1.txtpro.Clear()
        Form1.TextBox3.Clear()
    End Sub

End Module
