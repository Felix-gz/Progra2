Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBservicio.Items.Add("Residencial")
        CBservicio.Items.Add("Industrial")
        CBtarifa.Items.Add("Social")
        CBtarifa.Items.Add("No social")
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If (Registro <= 10) Then
            'Advertencias usuario'
            If txtconsumidor.Text = "" Then
                MsgBox("Ingrese un nombre") : Exit Sub
                txtconsumidor.Focus()
            End If
            If txtnit.Text = "" Then
                txtnit.Text = "C/F"
            ElseIf IsNumeric(txtnit.Text) = False And txtnit.Text <> "C/F" Then
                MsgBox("Numero invalido") : Exit Sub
                txtnit.Focus()
            End If
            If txtsaldoanterior.Text = "" Then
                txtnit.Text = 0
            ElseIf IsNumeric(txtsaldoanterior.Text) = False Then
                MsgBox("Saldo invalido") : Exit Sub
                txtsaldoanterior.Focus()
            End If
            If txtconsumo.Text = "" Then
                txtnit.Text = 0
            ElseIf IsNumeric(txtconsumo.Text) = False Then
                MsgBox("KWH invalido") : Exit Sub
                txtconsumo.Focus()
            End If
            'Condicones de descuento'
            Select Case (CBservicio.Text)
                Case "Residencial"
                    Select Case Val(txtconsumo.Text)
                        Case 1 To 100.99
                            PrecioS = Val(txtconsumo.Text) * Residencial1
                        Case 101 To 300.99
                            PrecioS = Val(txtconsumo.Text) * Residencial101
                        Case Is > 301
                            PrecioS = Val(txtconsumo.Text) * Residencial301
                        Case Else
                            MsgBox("Ingrese los KWH") : Exit Sub
                    End Select
                Case "Industrial"
                    Select Case (Val(txtconsumo.Text))
                        Case 1 To 100.99
                            PrecioS = Val(txtconsumo.Text) * Industrial1
                        Case 101 To 300.99
                            PrecioS = Val(txtconsumo.Text) * Industrial101
                        Case Is > 301
                            PrecioS = Val(txtconsumo.Text) * Industrial301
                        Case Else
                            MsgBox("Ingrese los KWH") : Exit Sub
                    End Select
                Case Else
                    MsgBox("Seleccione un tipo de servicio") : Exit Sub
            End Select
            Select Case (CBtarifa.Text)
                Case "Social"
                    Desc = PrecioS * 0.2
                Case "No social"
                    Desc = PrecioS * 0.1
                Case Else
                    MsgBox("Seleccione una tarifa") : Exit Sub
            End Select
            If Val(txtsaldoanterior.Text) > 0 Then
                Morapagar = Val(txtsaldoanterior.Text) * 0.02
            ElseIf Val(txtsaldoanterior.Text) = 0 Then
                Morapagar = 0
            End If

            SaldoAnt = Val(txtsaldoanterior.Text)
            Consumidor(Registro) += txtconsumidor.Text
            Nit(Registro) += txtnit.Text
            Servicio(Registro) += CBservicio.Text
            Tarifa(Registro) += CBtarifa.Text
            Saldo(Registro) = Round(SaldoAnt, 2)
            Pinicial(Registro) = Round(PrecioS, 2)
            Mora(Registro) = Round(Morapagar, 2)
            Descuento(Registro) = Round(Desc, 2)
            Total(Registro) = Round(Pinicial(Registro) + Saldo(Registro) + Mora(Registro) - Descuento(Registro), 2)

            MostarVerctores()
            Registro = Registro + 1
        End If

        If (Registro = 11) Then
            MsgBox("Registros llenos")
        End If
        Borrarregistro()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Limpiartodo()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If (MsgBox("Desea salir", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            End
        Else
            Limpiartodo()
        End If
    End Sub
End Class
