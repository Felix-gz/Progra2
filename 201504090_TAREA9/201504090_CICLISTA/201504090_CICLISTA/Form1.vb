Public Class Form1
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Ingrese etapa valido")
            Exit Sub
        End If
        If (fila <= 10) Then
            Etapa(fila) = Val(TextBox4.Text)
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
        Dim Dsky As Integer = 0
        Dim Dmov As Integer = 0
        Dim Dcy As Integer = 0
        Dim Dpro As Integer = 0
        Dim Tsky As Integer = 0
        Dim Tmov As Integer = 0
        Dim Tcy As Integer = 0
        Dim Tpro As Integer = 0

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
                        Dsky = Dsky + Val(Distanncia(i))
                        txtsky.Text = Dsky
                    Case "Movistar"
                        Dmov = Dmov + Val(Distanncia(i))
                        txtmovistar.Text = Dmov
                    Case "Pro Cycling"
                        Dcy = Dcy + Val(Distanncia(i))
                        txtcycling.Text = Dcy
                    Case "Pro Team"
                        Dpro = Dpro + Val(Distanncia(i))
                        txtpro.Text = Dpro
                End Select
            End If

            'tiempo total
            If (TiempoFinal(i) <> Nothing) Then
                Select Case Equipo(i)
                    Case "Sky"
                        Tsky = Tsky + Val(TiempoFinal(i))
                        txt1.Text = Tsky
                    Case "Movistar"
                        Tmov = Tmov + Val(TiempoFinal(i))
                        txt2.Text = (Tmov)
                    Case "Pro Cycling"
                        Tcy = Tcy + Val(TiempoFinal(i))
                        txt3.Text = Tcy
                    Case "Pro Team"
                        Tpro = Tpro + Val(TiempoFinal(i))
                        txt4.Text = Tpro
                End Select
            End If
        Next i
        TextBox3.Text = estadistica1


    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim consulta = False
        If TextBox4.Text = "" Then
            MsgBox("Ingrese el No. etapa")
            Exit Sub
        ElseIf IsNumeric(TextBox4.Text) = False Then
            MsgBox("Ingrese en No. valido")
            Exit Sub
        End If

        For fila As Integer = 0 To 10
            If (Etapa(fila) <> Nothing) Then
                If (Etapa(fila) = TextBox4.Text) Then
                    ComboBox1.Text = Equipo(fila)
                    TextBox1.Text = Distanncia(fila)
                    TextBox2.Text = Tiempo(fila)
                    ComboBox2.Text = Nacionalidad(fila)
                    consulta = True
                End If
            End If
        Next
        If (consulta = False) Then
            MsgBox("No existe registros de la etapa")
        End If

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        DataGridView1.Update()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        If TextBox4.Text = "" Then
            MsgBox("Ingrese el No. etapa que desee eliminar")
            Exit Sub
        ElseIf IsNumeric(TextBox4.Text) = False Then
            MsgBox("Ingrese un No. valido")
            Exit Sub
        End If

        For fila As Integer = 0 To 10
            If (Etapa(fila) <> Nothing) Then
                If (Etapa(fila) = TextBox4.Text) Then
                    Etapa(fila) = Nothing
                    Equipo(fila) = Nothing
                    Distanncia(fila) = Nothing
                    Tiempo(fila) = Nothing
                    Nacionalidad(fila) = Nothing
                End If
            End If
            MsgBox("Etapa eliminada")
            Exit Sub
        Next
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click

    End Sub

    Private Sub EstadisticaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadisticaToolStripMenuItem1.Click
        limparestadistica()
    End Sub
End Class
