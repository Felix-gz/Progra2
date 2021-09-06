<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconsumidor = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtsaldoanterior = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtconsumo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBtarifa = New System.Windows.Forms.ComboBox()
        Me.CBservicio = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ltotal = New System.Windows.Forms.ListBox()
        Me.Ldescuento = New System.Windows.Forms.ListBox()
        Me.Lmora = New System.Windows.Forms.ListBox()
        Me.Lpagoinicial = New System.Windows.Forms.ListBox()
        Me.Lsaldo = New System.Windows.Forms.ListBox()
        Me.Ltarifa = New System.Windows.Forms.ListBox()
        Me.Lservicio = New System.Windows.Forms.ListBox()
        Me.Lnit = New System.Windows.Forms.ListBox()
        Me.Lconsumidor = New System.Windows.Forms.ListBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consumidor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo anterior"
        '
        'txtconsumidor
        '
        Me.txtconsumidor.Location = New System.Drawing.Point(88, 9)
        Me.txtconsumidor.Name = "txtconsumidor"
        Me.txtconsumidor.Size = New System.Drawing.Size(169, 23)
        Me.txtconsumidor.TabIndex = 3
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(88, 38)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(100, 23)
        Me.txtnit.TabIndex = 4
        '
        'txtsaldoanterior
        '
        Me.txtsaldoanterior.Location = New System.Drawing.Point(88, 67)
        Me.txtsaldoanterior.Name = "txtsaldoanterior"
        Me.txtsaldoanterior.Size = New System.Drawing.Size(100, 23)
        Me.txtsaldoanterior.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Consumo KWH"
        '
        'txtconsumo
        '
        Me.txtconsumo.Location = New System.Drawing.Point(88, 96)
        Me.txtconsumo.Name = "txtconsumo"
        Me.txtconsumo.Size = New System.Drawing.Size(100, 23)
        Me.txtconsumo.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBtarifa)
        Me.GroupBox1.Controls.Add(Me.CBservicio)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 99)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de servicio"
        '
        'CBtarifa
        '
        Me.CBtarifa.FormattingEnabled = True
        Me.CBtarifa.Location = New System.Drawing.Point(6, 51)
        Me.CBtarifa.Name = "CBtarifa"
        Me.CBtarifa.Size = New System.Drawing.Size(121, 23)
        Me.CBtarifa.TabIndex = 1
        Me.CBtarifa.Text = "Tarifa"
        '
        'CBservicio
        '
        Me.CBservicio.FormattingEnabled = True
        Me.CBservicio.Location = New System.Drawing.Point(6, 22)
        Me.CBservicio.Name = "CBservicio"
        Me.CBservicio.Size = New System.Drawing.Size(121, 23)
        Me.CBservicio.TabIndex = 0
        Me.CBservicio.Text = "Servicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Ltotal)
        Me.GroupBox2.Controls.Add(Me.Ldescuento)
        Me.GroupBox2.Controls.Add(Me.Lmora)
        Me.GroupBox2.Controls.Add(Me.Lpagoinicial)
        Me.GroupBox2.Controls.Add(Me.Lsaldo)
        Me.GroupBox2.Controls.Add(Me.Ltarifa)
        Me.GroupBox2.Controls.Add(Me.Lservicio)
        Me.GroupBox2.Controls.Add(Me.Lnit)
        Me.GroupBox2.Controls.Add(Me.Lconsumidor)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 194)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(657, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Total a pagar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(588, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(530, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Mora"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Pago Inicial"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Saldo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tarifa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Servicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Consumidor"
        '
        'Ltotal
        '
        Me.Ltotal.FormattingEnabled = True
        Me.Ltotal.ItemHeight = 15
        Me.Ltotal.Location = New System.Drawing.Point(657, 40)
        Me.Ltotal.Name = "Ltotal"
        Me.Ltotal.Size = New System.Drawing.Size(74, 139)
        Me.Ltotal.TabIndex = 8
        '
        'Ldescuento
        '
        Me.Ldescuento.FormattingEnabled = True
        Me.Ldescuento.ItemHeight = 15
        Me.Ldescuento.Location = New System.Drawing.Point(588, 40)
        Me.Ldescuento.Name = "Ldescuento"
        Me.Ldescuento.Size = New System.Drawing.Size(63, 139)
        Me.Ldescuento.TabIndex = 7
        '
        'Lmora
        '
        Me.Lmora.FormattingEnabled = True
        Me.Lmora.ItemHeight = 15
        Me.Lmora.Location = New System.Drawing.Point(530, 40)
        Me.Lmora.Name = "Lmora"
        Me.Lmora.Size = New System.Drawing.Size(52, 139)
        Me.Lmora.TabIndex = 6
        '
        'Lpagoinicial
        '
        Me.Lpagoinicial.FormattingEnabled = True
        Me.Lpagoinicial.ItemHeight = 15
        Me.Lpagoinicial.Location = New System.Drawing.Point(456, 40)
        Me.Lpagoinicial.Name = "Lpagoinicial"
        Me.Lpagoinicial.Size = New System.Drawing.Size(68, 139)
        Me.Lpagoinicial.TabIndex = 5
        '
        'Lsaldo
        '
        Me.Lsaldo.FormattingEnabled = True
        Me.Lsaldo.ItemHeight = 15
        Me.Lsaldo.Location = New System.Drawing.Point(396, 40)
        Me.Lsaldo.Name = "Lsaldo"
        Me.Lsaldo.Size = New System.Drawing.Size(54, 139)
        Me.Lsaldo.TabIndex = 4
        '
        'Ltarifa
        '
        Me.Ltarifa.FormattingEnabled = True
        Me.Ltarifa.ItemHeight = 15
        Me.Ltarifa.Location = New System.Drawing.Point(311, 40)
        Me.Ltarifa.Name = "Ltarifa"
        Me.Ltarifa.Size = New System.Drawing.Size(79, 139)
        Me.Ltarifa.TabIndex = 3
        '
        'Lservicio
        '
        Me.Lservicio.FormattingEnabled = True
        Me.Lservicio.ItemHeight = 15
        Me.Lservicio.Location = New System.Drawing.Point(226, 40)
        Me.Lservicio.Name = "Lservicio"
        Me.Lservicio.Size = New System.Drawing.Size(79, 139)
        Me.Lservicio.TabIndex = 2
        '
        'Lnit
        '
        Me.Lnit.FormattingEnabled = True
        Me.Lnit.ItemHeight = 15
        Me.Lnit.Location = New System.Drawing.Point(132, 40)
        Me.Lnit.Name = "Lnit"
        Me.Lnit.Size = New System.Drawing.Size(88, 139)
        Me.Lnit.TabIndex = 1
        '
        'Lconsumidor
        '
        Me.Lconsumidor.FormattingEnabled = True
        Me.Lconsumidor.ItemHeight = 15
        Me.Lconsumidor.Location = New System.Drawing.Point(6, 40)
        Me.Lconsumidor.Name = "Lconsumidor"
        Me.Lconsumidor.Size = New System.Drawing.Size(120, 139)
        Me.Lconsumidor.TabIndex = 0
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(519, 17)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 10
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(519, 46)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 11
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(519, 75)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 12
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 341)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtconsumo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsaldoanterior)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.txtconsumidor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtconsumidor As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents txtsaldoanterior As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtconsumo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBtarifa As ComboBox
    Friend WithEvents CBservicio As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Ltotal As ListBox
    Friend WithEvents Ldescuento As ListBox
    Friend WithEvents Lmora As ListBox
    Friend WithEvents Lpagoinicial As ListBox
    Friend WithEvents Lsaldo As ListBox
    Friend WithEvents Ltarifa As ListBox
    Friend WithEvents Lservicio As ListBox
    Friend WithEvents Lnit As ListBox
    Friend WithEvents Lconsumidor As ListBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
End Class
