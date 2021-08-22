Public Class Form1

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        limpar()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Clino.Visible = True
            Clino.Clear()
            Clino.Focus()
        Else
            Clino.Clear()
            Clino.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Calgodon.Visible = True
            Calgodon.Clear()
            Calgodon.Focus()
        Else
            Calgodon.Clear()
            Calgodon.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Cseda.Visible = True
            Cseda.Clear()
            Cseda.Focus()
        Else
            Cseda.Clear()
            Cseda.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Chilo.Visible = True
            Chilo.Clear()
            Chilo.Focus()
        Else
            Chilo.Clear()
            Chilo.Visible = False
        End If
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        MatUsar = Val(Clino.Text) + Val(Calgodon.Text) + Val(Cseda.Text) + Val(Chilo.Text)

        If RadioButton1.Checked Then
            If MatUsar = LimImp Then
                Costos = imperial + Val(Clino.Text) * lino + Val(Calgodon.Text) * algodon + Val(Cseda.Text) * seda + Val(Chilo.Text) * hilo
            ElseIf MatUsar < LimImp Then
                MsgBox("Le falta " & LimImp - MatUsar & " de material")
            ElseIf MatUsar > LimImp Then
                MsgBox("Quite " & MatUsar - LimImp & " de material")
            End If
        End If

        If RadioButton2.Checked Then
            If MatUsar = LimMat Then
                Costos = matrimonial + Val(Clino.Text) * lino + Val(Calgodon.Text) * algodon + Val(Cseda.Text) * seda + Val(Chilo.Text) * hilo
            ElseIf MatUsar < LimMat Then
                MsgBox("Le falta " & LimMat - MatUsar & " de material")
            ElseIf MatUsar > LimMat Then
                MsgBox("Quite " & MatUsar - LimMat & " de material")
            End If
        End If

        If RadioButton3.Checked Then
            If MatUsar = LimQueen Then
                Costos = queen + Val(Clino.Text) * lino + Val(Calgodon.Text) * algodon + Val(Cseda.Text) * seda + Val(Chilo.Text) * hilo
            ElseIf MatUsar < LimQueen Then
                MsgBox("Le falta " & LimQueen - MatUsar & " de material")
            ElseIf MatUsar > LimImp Then
                MsgBox("Quite " & MatUsar - LimQueen & " de material")
            End If
        End If

        If RadioButton4.Checked Then
            If MatUsar = LimKing Then
                Costos = king + Val(Clino.Text) * lino + Val(Calgodon.Text) * algodon + Val(Cseda.Text) * seda + Val(Chilo.Text) * hilo
            ElseIf MatUsar < LimKing Then
                MsgBox("Le falta " & LimKing - MatUsar & " de material")
            ElseIf MatUsar > LimImp Then
                MsgBox("Quite " & MatUsar - LimKing & " de material")
            End If
        End If

        CostoTotal.Text = Str(Costos)
        CostoMaterial = Val(Clino.Text) * lino + Val(Calgodon.Text) * algodon + Val(Cseda.Text) * seda + Val(Chilo.Text) * hilo
        CostoMa.Text = Str(CostoMaterial)
        PVenta = Costos + (Costos * 0.65)
        PrecioV.Text = Str(PVenta)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class