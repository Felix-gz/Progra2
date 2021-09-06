Module Module1
    'tarifas'
    Public Const Residencial1 = 0.99
    Public Const Residencial101 = 1.2
    Public Const Residencial301 = 3
    Public Const Industrial1 = 1.99
    Public Const Industrial101 = 22.2
    Public Const Industrial301 = 4
    'varibales '
    Public PrecioS As Decimal
    Public Desc As Decimal
    Public Morapagar As Decimal
    Public PagoT As Decimal
    Public SaldoAnt As Decimal

    Public Registro As Integer = 0
    Public Consumidor(11) As String
    Public Nit(11) As String
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public Saldo(11) As Double
    Public Pinicial(11) As Double
    Public Mora(11) As Double
    Public Descuento(11) As Double
    Public Total(11) As Double

    Public Sub MostarVerctores()
        Form1.Lconsumidor.Items.Add(Consumidor(Registro))
        Form1.Lnit.Items.Add(Nit(Registro))
        Form1.Lservicio.Items.Add(Servicio(Registro))
        Form1.Ltarifa.Items.Add(Tarifa(Registro))
        Form1.Lsaldo.Items.Add(Saldo(Registro))
        Form1.Lpagoinicial.Items.Add(Pinicial(Registro))
        Form1.Lmora.Items.Add(Mora(Registro))
        Form1.Ldescuento.Items.Add(Descuento(Registro))
        Form1.Ltotal.Items.Add(Total(Registro))
    End Sub

    Public Sub Limpiartodo()
        Form1.txtconsumidor.Clear()
        Form1.txtnit.Clear()
        Form1.txtsaldoanterior.Clear()
        Form1.txtconsumo.Clear()
        Form1.CBservicio.Text = "Servicio"
        Form1.CBtarifa.Text = "Tarifa"
        Form1.Lconsumidor.Items.Clear()
        Form1.Lnit.Items.Clear()
        Form1.Lservicio.Items.Clear()
        Form1.Ltarifa.Items.Clear()
        Form1.Lsaldo.Items.Clear()
        Form1.Lpagoinicial.Items.Clear()
        Form1.Lmora.Items.Clear()
        Form1.Ldescuento.Items.Clear()
        Form1.Ltotal.Items.Clear()
        Form1.txtconsumidor.Focus()

    End Sub

    Public Sub Borrarregistro()
        Form1.txtconsumidor.Clear()
        Form1.txtnit.Clear()
        Form1.txtsaldoanterior.Clear()
        Form1.txtconsumo.Clear()
        Form1.CBservicio.Text = "Servicio"
        Form1.CBtarifa.Text = "Tarifa"
        Form1.txtconsumidor.Focus()
    End Sub


End Module
