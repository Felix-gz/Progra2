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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtentrada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBcine = New System.Windows.Forms.ComboBox()
        Me.CBfuncion = New System.Windows.Forms.ComboBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.LimpiarE = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.LimpiarV = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ltotal = New System.Windows.Forms.ListBox()
        Me.Ldesc2 = New System.Windows.Forms.ListBox()
        Me.Ldesc1 = New System.Windows.Forms.ListBox()
        Me.Lsub = New System.Windows.Forms.ListBox()
        Me.Lentrada = New System.Windows.Forms.ListBox()
        Me.Lcine = New System.Windows.Forms.ListBox()
        Me.LFun = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtentrada)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBcine)
        Me.GroupBox1.Controls.Add(Me.CBfuncion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtentrada
        '
        Me.txtentrada.Location = New System.Drawing.Point(80, 51)
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.Size = New System.Drawing.Size(62, 23)
        Me.txtentrada.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "# Entradas"
        '
        'CBcine
        '
        Me.CBcine.FormattingEnabled = True
        Me.CBcine.Location = New System.Drawing.Point(6, 51)
        Me.CBcine.Name = "CBcine"
        Me.CBcine.Size = New System.Drawing.Size(68, 23)
        Me.CBcine.TabIndex = 1
        Me.CBcine.Text = "Cine"
        '
        'CBfuncion
        '
        Me.CBfuncion.FormattingEnabled = True
        Me.CBfuncion.Location = New System.Drawing.Point(6, 22)
        Me.CBfuncion.Name = "CBfuncion"
        Me.CBfuncion.Size = New System.Drawing.Size(68, 23)
        Me.CBfuncion.TabIndex = 0
        Me.CBfuncion.Text = "Funcion"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(170, 34)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 1
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'LimpiarE
        '
        Me.LimpiarE.Location = New System.Drawing.Point(170, 63)
        Me.LimpiarE.Name = "LimpiarE"
        Me.LimpiarE.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarE.TabIndex = 2
        Me.LimpiarE.Text = "Limpiar L"
        Me.LimpiarE.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(251, 62)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'LimpiarV
        '
        Me.LimpiarV.Location = New System.Drawing.Point(251, 33)
        Me.LimpiarV.Name = "LimpiarV"
        Me.LimpiarV.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarV.TabIndex = 4
        Me.LimpiarV.Text = "Limpiar V"
        Me.LimpiarV.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ltotal)
        Me.GroupBox2.Controls.Add(Me.Ldesc2)
        Me.GroupBox2.Controls.Add(Me.Ldesc1)
        Me.GroupBox2.Controls.Add(Me.Lsub)
        Me.GroupBox2.Controls.Add(Me.Lentrada)
        Me.GroupBox2.Controls.Add(Me.Lcine)
        Me.GroupBox2.Controls.Add(Me.LFun)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 203)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'Ltotal
        '
        Me.Ltotal.BackColor = System.Drawing.Color.LightCoral
        Me.Ltotal.FormattingEnabled = True
        Me.Ltotal.ItemHeight = 15
        Me.Ltotal.Location = New System.Drawing.Point(302, 37)
        Me.Ltotal.Name = "Ltotal"
        Me.Ltotal.Size = New System.Drawing.Size(45, 154)
        Me.Ltotal.TabIndex = 13
        '
        'Ldesc2
        '
        Me.Ldesc2.FormattingEnabled = True
        Me.Ldesc2.ItemHeight = 15
        Me.Ldesc2.Location = New System.Drawing.Point(258, 37)
        Me.Ldesc2.Name = "Ldesc2"
        Me.Ldesc2.Size = New System.Drawing.Size(38, 154)
        Me.Ldesc2.TabIndex = 12
        '
        'Ldesc1
        '
        Me.Ldesc1.FormattingEnabled = True
        Me.Ldesc1.ItemHeight = 15
        Me.Ldesc1.Location = New System.Drawing.Point(214, 37)
        Me.Ldesc1.Name = "Ldesc1"
        Me.Ldesc1.Size = New System.Drawing.Size(38, 154)
        Me.Ldesc1.TabIndex = 11
        '
        'Lsub
        '
        Me.Lsub.FormattingEnabled = True
        Me.Lsub.ItemHeight = 15
        Me.Lsub.Location = New System.Drawing.Point(157, 37)
        Me.Lsub.Name = "Lsub"
        Me.Lsub.Size = New System.Drawing.Size(51, 154)
        Me.Lsub.TabIndex = 10
        '
        'Lentrada
        '
        Me.Lentrada.FormattingEnabled = True
        Me.Lentrada.ItemHeight = 15
        Me.Lentrada.Location = New System.Drawing.Point(99, 37)
        Me.Lentrada.Name = "Lentrada"
        Me.Lentrada.Size = New System.Drawing.Size(52, 154)
        Me.Lentrada.TabIndex = 9
        '
        'Lcine
        '
        Me.Lcine.FormattingEnabled = True
        Me.Lcine.ItemHeight = 15
        Me.Lcine.Location = New System.Drawing.Point(62, 37)
        Me.Lcine.Name = "Lcine"
        Me.Lcine.Size = New System.Drawing.Size(31, 154)
        Me.Lcine.TabIndex = 8
        '
        'LFun
        '
        Me.LFun.FormattingEnabled = True
        Me.LFun.ItemHeight = 15
        Me.LFun.Location = New System.Drawing.Point(6, 37)
        Me.LFun.Name = "LFun"
        Me.LFun.Size = New System.Drawing.Size(50, 154)
        Me.LFun.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Desc2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Desc1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Entradas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Funcion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 320)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LimpiarV)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.LimpiarE)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtentrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBcine As ComboBox
    Friend WithEvents CBfuncion As ComboBox
    Friend WithEvents Calcular As Button
    Friend WithEvents LimpiarE As Button
    Friend WithEvents Salir As Button
    Friend WithEvents LimpiarV As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Ltotal As ListBox
    Friend WithEvents Ldesc2 As ListBox
    Friend WithEvents Ldesc1 As ListBox
    Friend WithEvents Lsub As ListBox
    Friend WithEvents Lentrada As ListBox
    Friend WithEvents Lcine As ListBox
    Friend WithEvents LFun As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
