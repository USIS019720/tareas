<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxsalida = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(326, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblr
        '
        Me.lblr.Location = New System.Drawing.Point(336, 158)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(100, 20)
        Me.lblr.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Resultado:"
        '
        'cbxsalida
        '
        Me.cbxsalida.FormattingEnabled = True
        Me.cbxsalida.Items.AddRange(New Object() {"Bit", "Kilobit", "Megabit", "Gigabit", "Terabit", "Petabit", "Megabyte", "Gigabyte", "Terabyte", "Petabyte"})
        Me.cbxsalida.Location = New System.Drawing.Point(415, 111)
        Me.cbxsalida.Name = "cbxsalida"
        Me.cbxsalida.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalida.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "A:"
        '
        'cbxentrada
        '
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"Bit", "Kilobit", "Megabit", "Gigabit", "Terabit", "Petabit", "Megabyte", "Gigabyte", "Terabyte", "Petabyte"})
        Me.cbxentrada.Location = New System.Drawing.Point(189, 111)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "De:"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(303, 51)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese una Cantidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxsalida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxsalida As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxentrada As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label1 As Label
End Class
