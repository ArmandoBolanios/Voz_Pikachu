<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InterfazPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txRecibe = New System.Windows.Forms.TextBox()
        Me.txEnviar = New System.Windows.Forms.TextBox()
        Me.cbPuertos = New System.Windows.Forms.ComboBox()
        Me.btEnviar = New System.Windows.Forms.Button()
        Me.btConectar = New System.Windows.Forms.Button()
        Me.btDeterminar = New System.Windows.Forms.Button()
        Me.txTextoRec = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.USBConex = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Hola = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txRecibe
        '
        Me.txRecibe.Location = New System.Drawing.Point(12, 19)
        Me.txRecibe.Multiline = True
        Me.txRecibe.Name = "txRecibe"
        Me.txRecibe.Size = New System.Drawing.Size(217, 93)
        Me.txRecibe.TabIndex = 17
        '
        'txEnviar
        '
        Me.txEnviar.Location = New System.Drawing.Point(6, 19)
        Me.txEnviar.Name = "txEnviar"
        Me.txEnviar.Size = New System.Drawing.Size(169, 20)
        Me.txEnviar.TabIndex = 16
        '
        'cbPuertos
        '
        Me.cbPuertos.FormattingEnabled = True
        Me.cbPuertos.Location = New System.Drawing.Point(6, 20)
        Me.cbPuertos.Name = "cbPuertos"
        Me.cbPuertos.Size = New System.Drawing.Size(157, 21)
        Me.cbPuertos.TabIndex = 15
        '
        'btEnviar
        '
        Me.btEnviar.Location = New System.Drawing.Point(6, 45)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(169, 23)
        Me.btEnviar.TabIndex = 14
        Me.btEnviar.Text = "Enviar"
        Me.btEnviar.UseVisualStyleBackColor = True
        '
        'btConectar
        '
        Me.btConectar.Location = New System.Drawing.Point(6, 47)
        Me.btConectar.Name = "btConectar"
        Me.btConectar.Size = New System.Drawing.Size(157, 23)
        Me.btConectar.TabIndex = 13
        Me.btConectar.Text = "Conectar"
        Me.btConectar.UseVisualStyleBackColor = True
        '
        'btDeterminar
        '
        Me.btDeterminar.Location = New System.Drawing.Point(6, 16)
        Me.btDeterminar.Name = "btDeterminar"
        Me.btDeterminar.Size = New System.Drawing.Size(169, 23)
        Me.btDeterminar.TabIndex = 12
        Me.btDeterminar.Text = "Determinar Conexión"
        Me.btDeterminar.UseVisualStyleBackColor = True
        '
        'txTextoRec
        '
        Me.txTextoRec.Location = New System.Drawing.Point(6, 19)
        Me.txTextoRec.Name = "txTextoRec"
        Me.txTextoRec.Size = New System.Drawing.Size(169, 20)
        Me.txTextoRec.TabIndex = 11
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btDeterminar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 130)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bluettoth"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbPuertos)
        Me.GroupBox4.Controls.Add(Me.btConectar)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(169, 76)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lista de Puertos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txTextoRec)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 50)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Texto Reconocido Mediante Voz"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txEnviar)
        Me.GroupBox3.Controls.Add(Me.btEnviar)
        Me.GroupBox3.Location = New System.Drawing.Point(202, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 74)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos a Enviar"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Hola)
        Me.GroupBox5.Controls.Add(Me.txRecibe)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 118)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos Recibidos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 281)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = ""
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "(Arduino + Bluetooth) + (Visual Basic en Visual Studio)"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = ""
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Inteligencia Artificial - Reconocimiento de Voz"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(27, 246)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(368, 71)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tema - Información"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Voz.My.Resources.Resources.Logo003
        Me.PictureBox4.Location = New System.Drawing.Point(311, 93)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(103, 65)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Voz.My.Resources.Resources.logo002
        Me.PictureBox2.Location = New System.Drawing.Point(311, 175)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Voz.My.Resources.Resources.Logo001
        Me.PictureBox3.Location = New System.Drawing.Point(311, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Voz.My.Resources.Resources.Pikachu002
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(402, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Hola
        '
        Me.Hola.Location = New System.Drawing.Point(249, 20)
        Me.Hola.Name = "Hola"
        Me.Hola.Size = New System.Drawing.Size(75, 23)
        Me.Hola.TabIndex = 18
        Me.Hola.Text = "Hola"
        Me.Hola.UseVisualStyleBackColor = True
        '
        'InterfazPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 605)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InterfazPrincipal"
        Me.Text = "Control por Voz de Pikachu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txRecibe As TextBox
    Friend WithEvents txEnviar As TextBox
    Friend WithEvents cbPuertos As ComboBox
    Friend WithEvents btEnviar As Button
    Friend WithEvents btConectar As Button
    Friend WithEvents btDeterminar As Button
    Friend WithEvents txTextoRec As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents USBConex As IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Hola As Button
End Class
