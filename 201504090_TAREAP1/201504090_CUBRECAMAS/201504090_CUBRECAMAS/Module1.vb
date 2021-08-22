Module Module1
    'mano de obra'
    Public Const imperial = 65.5
    Public Const matrimonial = 85.99
    Public Const queen = 99.99
    Public Const king = 105.99

    'material'
    Public Const lino = 15
    Public Const algodon = 23.99
    Public Const seda = 30.99
    Public Const hilo = 39.99
    Public Const LimImp = 3
    Public Const LimMat = 5
    Public Const LimQueen = 6
    Public Const LimKing = 7

    'variables'
    Public MatUsar As Double
    Public Costos As Double
    Public PVenta As Double
    Public CostoMaterial As Double


    'limpiar'
    Sub limpar()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.CheckBox4.Checked = False
        Form1.CostoMa.Clear()
        Form1.PrecioV.Clear()
        Form1.CostoTotal.Clear()
        Form1.Clino.Clear()
        Form1.Calgodon.Clear()
        Form1.Cseda.Clear()
        Form1.Chilo.Clear()


    End Sub
End Module
