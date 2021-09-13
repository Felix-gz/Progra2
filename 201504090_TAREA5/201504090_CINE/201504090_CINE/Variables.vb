Module Variables
    'Precio entradas'
    Public Const A1 = 30, A2 = 35, A3 = 40, A4 = 40
    Public Const B1 = 24, B2 = 34, B3 = 44, B4 = 44
    Public Const C1 = 35, C2 = 40, C3 = 50, C4 = 50

    Public Precio As Decimal
    Public desc1 As Decimal
    Public desc2 As Decimal
    Public Ptotal As Decimal

    'vectores'
    Public Registro = 0
    Public Funcion(8) As String
    Public Cine(8) As String
    Public Entradas(8) As String
    Public Subtotal(8) As String
    Public Descuento1(8) As String
    Public Descuento2(8) As String
    Public Total(8) As String

    Public Sub MostrarVectores()
        Form1.LFun.Items.Add(Funcion(Registro))
        Form1.Lcine.Items.Add(Cine(Registro))
        Form1.Lentrada.Items.Add(Entradas(Registro))
        Form1.Lsub.Items.Add(Subtotal(Registro))
        Form1.Ldesc1.Items.Add(Descuento1(Registro))
        Form1.Ldesc2.Items.Add(Descuento2(Registro))
        Form1.Ltotal.Items.Add(Total(Registro))
    End Sub

    Public Sub Limpiarentradas()
        Form1.txtentrada.Clear()
        Form1.CBfuncion.Text = "Funcion"
        Form1.CBcine.Text = "Cine"
        Form1.CBfuncion.Focus()
    End Sub

    Public Sub limpiarvectores()
        ReDim Funcion(Funcion.Length - 1)
        ReDim Cine(Cine.Length - 1)
        ReDim Entradas(Entradas.Length - 1)
        ReDim Subtotal(Subtotal.Length - 1)
        ReDim Descuento1(Descuento1.Length - 1)
        ReDim Descuento2(Descuento2.Length - 1)
        ReDim Total(Total.Length - 1)
    End Sub

    Public Sub limpiarlista()
        Form1.LFun.Items.Clear()
        Form1.Lcine.Items.Clear()
        Form1.Lentrada.Items.Clear()
        Form1.Lsub.Items.Clear()
        Form1.Ldesc1.Items.Clear()
        Form1.Ldesc2.Items.Clear()
        Form1.Ltotal.Items.Clear()
    End Sub
End Module
