Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBfuncion.Items.Add("1")
        CBfuncion.Items.Add("2")
        CBfuncion.Items.Add("3")
        CBfuncion.Items.Add("4")
        CBcine.Items.Add("A")
        CBcine.Items.Add("B")
        CBcine.Items.Add("C")
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If (Registro < 9) Then
            If txtentrada.Text = "" Then
                MsgBox("Ingrese # entradas")
                txtentrada.Focus()
            ElseIf IsNumeric(txtentrada.Text) = False Then
                MsgBox("Ingrese un numero valido")
                txtentrada.Clear()
                txtentrada.Focus()
            End If

            'Descuentos'
            Select Case (CBcine.Text)
                Case "A"
                    Select Case (CBfuncion.Text)
                        Case "1"
                            Precio = Val(txtentrada.Text) * A1
                        Case "2"
                            Precio = Val(txtentrada.Text) * A2
                        Case "3"
                            Precio = Val(txtentrada.Text) * A3
                        Case "4"
                            Precio = Val(txtentrada.Text) * A4
                        Case Else
                            MsgBox("Selecione una funcion")
                            CBfuncion.Focus()
                    End Select
                Case "B"
                    Select Case (CBfuncion.Text)
                        Case "1"
                            Precio = Val(txtentrada.Text) * B1
                        Case "2"
                            Precio = Val(txtentrada.Text) * B2
                        Case "3"
                            Precio = Val(txtentrada.Text) * B3
                        Case "4"
                            Precio = Val(txtentrada.Text) * B4
                        Case Else
                            MsgBox("Selecione una funcion")
                            CBfuncion.Focus()
                    End Select
                Case "C"
                    Select Case (CBfuncion.Text)
                        Case "1"
                            Precio = Val(txtentrada.Text) * C1
                        Case "2"
                            Precio = Val(txtentrada.Text) * C2
                        Case "3"
                            Precio = Val(txtentrada.Text) * C3
                        Case "4"
                            Precio = Val(txtentrada.Text) * C4
                        Case Else
                            MsgBox("Selecione una funcion")
                            CBfuncion.Focus()
                    End Select
                Case Else
                    MsgBox("Seleccione un cine")
                    CBcine.Focus()
            End Select
            'Descuento1'
            If (CBfuncion.Text = "3" Or CBfuncion.Text = "4") And (CBcine.Text = "C" Or CBcine.Text = "B") Then
                desc1 = Precio * (5.5 / 100)
            ElseIf (CBfuncion.Text = "1") And (CBcine.Text = "C" Or CBcine.Text = "B") Then
                desc1 = Precio * (3 / 100)
            ElseIf (CBfuncion.Text = "2") And (CBcine.Text = "A") Then
                desc1 = Precio * (1.5 / 100)
            Else
                desc1 = 0
            End If
            'Descuento2'
            Select Case (Precio)
                Case 100 To 299.99
                    desc2 = Precio * (2 / 100)
                Case 300 To 499.99
                    desc2 = Precio * (4 / 100)
                Case 500 To 1000
                    desc2 = Precio * (6 / 100)
                Case Else
                    desc2 = 0
            End Select
            Funcion(Registro) = CBfuncion.Text
            Cine(Registro) = CBcine.Text
            Entradas(Registro) = txtentrada.Text
            Subtotal(Registro) = Round(Precio, 2)
            Descuento1(Registro) = Round(desc1, 2)
            Descuento2(Registro) = Round(desc2, 2)
            Total(Registro) = Round(Precio - desc1 - desc2, 2)
            MostrarVectores()
            Registro = Registro + 1
        End If

        If (Registro = 9) Then
            MsgBox("Lista llena")
        End If
        Limpiarentradas()

    End Sub

    Private Sub LimpiarV_Click(sender As Object, e As EventArgs) Handles LimpiarV.Click
        limpiarvectores()
    End Sub

    Private Sub LimpiarE_Click(sender As Object, e As EventArgs) Handles LimpiarE.Click
        limpiarlista()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If (MsgBox("Desea salir", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            End
        Else
            Limpiarentradas()
        End If
    End Sub
End Class
