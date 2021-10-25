Public Class Form1
    Private Sub CalculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoToolStripMenuItem.Click
        'Validaciones'
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Ingrese datos")
            Exit Sub
        ElseIf IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox4.Text) = False Or IsNumeric(TextBox3.Text) = False Then
            MsgBox("Ingrese un valor valido")
        End If
        If (ComboBox1.Text = "") Or (ComboBox2.Text = "") Then
            MsgBox("Seleccione tipo de habitacion o pago")
        End If

        'Verificar nit repedito'
        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    MsgBox("NIT ya existe")
                    Exit Sub
                End If
            End If
        Next

        If index < 6 Then
            'columna nit'
            matriz(index, 0) = TextBox1.Text
            'columna nombre'
            matriz(index, 1) = TextBox2.Text
            'columna dias'
            matriz(index, 2) = TextBox3.Text
            'columna honorarios'
            matriz(index, 3) = TextBox4.Text
            'columna habitacion
            matriz(index, 4) = ComboBox1.Text
            'tipo de pago
            matriz(index, 5) = ComboBox2.Text

            'dias*habitacion 
            Select Case ComboBox1.Text
                Case "Privada"
                    matriz(index, 6) = Val(TextBox3.Text) * 350
                Case "Semiprivada"
                    matriz(index, 6) = Val(TextBox3.Text) * 250
                Case "No Privada"
                    matriz(index, 6) = Val(TextBox3.Text) * 150
            End Select

            'descuento/recargo
            Select Case ComboBox2.Text
                Case "Efectivo"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.1 * -1
                Case "Transferencia ACH"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.08 * -1
                Case "Tarjeta"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.015
                Case "Deposito"
                    matriz(index, 7) = Val(matriz(index, 6)) * 0.1 * -1

            End Select

            matriz(index, 8) = Val(matriz(index, 6)) + Val(matriz(index, 7))
            index = index + 1

            limpiarentradas()

        Else
            MsgBox("Registros llenos")
        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("Desea salir", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            End
        Else
            'Limpiarentradas()
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        DataGridView1.Rows.Clear()

        Dim filas As Integer
        While filas < 6
            If (matriz(filas, 0) <> Nothing) Then
                DataGridView1.Rows.Add(matriz(filas, 0), matriz(filas, 1), matriz(filas, 2), matriz(filas, 3), matriz(filas, 4), matriz(filas, 5), matriz(filas, 6), matriz(filas, 7), matriz(filas, 8))
            End If
            filas = filas + 1
        End While
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        For fila As Integer = 0 To 5
            For columna As Integer = 0 To 8
                matriz(fila, columna) = Nothing
                index = 0
            Next
        Next
        limpiarentradas()
        TextBox1.Focus()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim consulta = False
        If TextBox1.Text = "" Then
            MsgBox("Ingrese Nit a consultar")
            Exit Sub
            TextBox1.Focus()
        End If

        For fila As Integer = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If (matriz(fila, 0) = TextBox1.Text) Then
                    TextBox2.Text = matriz(fila, 1)
                    TextBox3.Text = matriz(fila, 2)
                    TextBox4.Text = matriz(fila, 3)
                    ComboBox1.Text = matriz(fila, 4)
                    ComboBox2.Text = matriz(fila, 5)
                    consulta = True
                End If
            End If
        Next
        If (consulta = False) Then
            MsgBox("No existe registros")
            Exit Sub
        End If

    End Sub

    Private Sub EstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaToolStripMenuItem.Click
        Dim filas As Integer
        Dim esta1 = 0
        Dim esta2 = 0
        Dim esta3 = 0

        While filas < 6
            If (matriz(filas, 0) <> Nothing) Then

                'habitacion privada
                If matriz(filas, 4) = "Privada" Then
                    esta1 = esta1 + 1
                End If

                'total recaudado tranferencia
                If matriz(filas, 5) = "Transferencia ACH" Then
                    esta2 = esta2 + Val(matriz(filas, 8))
                End If

                'dias habitacion no privida
                If matriz(filas, 4) = "No Privada" Then
                    esta3 = esta3 + Val(matriz(filas, 2))
                End If

            End If
                filas = filas + 1
        End While

        TextBox5.Text = esta1
        TextBox6.Text = esta2
        TextBox7.Text = esta3

    End Sub

    Private Sub LimpiarEstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticaToolStripMenuItem.Click

    End Sub
End Class
