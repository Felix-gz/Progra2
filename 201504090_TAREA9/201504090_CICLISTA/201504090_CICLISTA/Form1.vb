Public Class Form1
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If (fila <= 10) Then
            Equipo(fila) = ComboBox1.Text
            Distanncia(fila) = Val(TextBox1.Text)
            Tiempo(fila) = Val(TextBox2.Text)
            Nacionalidad(fila) = ComboBox2.Text

            'calcular penalizacion
            Select Case Tiempo(fila)
                Case 120 To 139.99
                    Penalizacion(fila) = 30
                Case 140 To 159.99
                    Penalizacion(fila) = 40
                Case > 160
                    Penalizacion(fila) = 50
            End Select
            Select Case Equipo(fila)
                Case "Movistar"
                    Select Case Tiempo(fila)
                        Case < 85
                            Penalizacion(fila) = 15 * -1
                    End Select
                Case "Pro Team"
                    Select Case Tiempo(fila)
                        Case < 85
                            Penalizacion(fila) = 10 * -1
                    End Select
            End Select

            TiempoFinal(fila) = Val(Tiempo(fila)) + Val(Penalizacion(fila))

            fila = fila + 1

            limpiarentradas()
        End If
        If (fila = 11) Then
            MsgBox("Datos llenos")
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrarvectores()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiarvectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub EstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaToolStripMenuItem.Click
        Dim estadistica1 As Byte = 0
        Dim estadistica2 As Byte = 0
        Dim estadistica3 As Byte = 0
        For i = 0 To 10
            'nacionales
            If (Nacionalidad(i) <> Nothing) Then
                Select Case Nacionalidad(i)
                    Case "Guatemalteco"
                        estadistica1 = estadistica1 + 1
                End Select
            End If

            'recorrido total
            If (Distanncia(i) <> Nothing) Then
                Select Case Equipo(i)
                    Case "Sky"
                        estadistica2 = estadistica2 + Val(Distanncia(i))
                        txtsky.Text = estadistica2
                    Case "Movistar"
                        estadistica2 = estadistica2 + Val(Distanncia(i))
                        txtmovistar.Text = estadistica2
                    Case "Pro Cycling"
                        estadistica2 = estadistica2 + Val(Distanncia(i))
                        txtcycling.Text = estadistica2
                    Case "Pro Team"
                        estadistica2 = estadistica2 + Val(Distanncia(i))
                        txtpro.Text = estadistica2
                End Select
            End If

            'tiempo total
            If (TiempoFinal(i) <> Nothing) Then
                Select Case Equipo(i)
                    Case "Sky"
                        estadistica3 = estadistica3 + Val(TiempoFinal(i))
                        txt1.Text = estadistica3
                    Case "Movistar"
                        estadistica3 = estadistica3 + Val(TiempoFinal(i))
                        txt2.Text = estadistica3
                    Case "Pro Cycling"
                        estadistica3 = estadistica3 + Val(TiempoFinal(i))
                        txt3.Text = estadistica2
                    Case "Pro Team"
                        estadistica3 = estadistica3 + Val(TiempoFinal(i))
                        txt4.Text = estadistica3
                End Select
            End If
        Next i
        TextBox3.Text = estadistica1


    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click

    End Sub
End Class
