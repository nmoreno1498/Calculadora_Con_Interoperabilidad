﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadoraInterop
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultS = New System.Windows.Forms.Label()
        Me.lblResultR = New System.Windows.Forms.Label()
        Me.lblResultD = New System.Windows.Forms.Label()
        Me.lblResultM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(118, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 26)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(118, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 26)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular Suma"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(118, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(256, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Calcular Resta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(118, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(256, 34)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Calcular Multiplicacion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(118, 474)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(256, 34)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Calcular Division"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(115, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Operaciones Realizadas con CSharp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(115, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Operaciones Realizadas con FSharp"
        '
        'lblResultS
        '
        Me.lblResultS.AutoSize = True
        Me.lblResultS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultS.Location = New System.Drawing.Point(407, 249)
        Me.lblResultS.Name = "lblResultS"
        Me.lblResultS.Size = New System.Drawing.Size(75, 18)
        Me.lblResultS.TabIndex = 8
        Me.lblResultS.Text = "Resultado"
        '
        'lblResultR
        '
        Me.lblResultR.AutoSize = True
        Me.lblResultR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultR.Location = New System.Drawing.Point(407, 318)
        Me.lblResultR.Name = "lblResultR"
        Me.lblResultR.Size = New System.Drawing.Size(75, 18)
        Me.lblResultR.TabIndex = 9
        Me.lblResultR.Text = "Resultado"
        '
        'lblResultD
        '
        Me.lblResultD.AutoSize = True
        Me.lblResultD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultD.Location = New System.Drawing.Point(407, 490)
        Me.lblResultD.Name = "lblResultD"
        Me.lblResultD.Size = New System.Drawing.Size(75, 18)
        Me.lblResultD.TabIndex = 11
        Me.lblResultD.Text = "Resultado"
        '
        'lblResultM
        '
        Me.lblResultM.AutoSize = True
        Me.lblResultM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultM.Location = New System.Drawing.Point(407, 421)
        Me.lblResultM.Name = "lblResultM"
        Me.lblResultM.Size = New System.Drawing.Size(75, 18)
        Me.lblResultM.TabIndex = 10
        Me.lblResultM.Text = "Resultado"
        '
        'frmCalculadoraInterop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 580)
        Me.Controls.Add(Me.lblResultD)
        Me.Controls.Add(Me.lblResultM)
        Me.Controls.Add(Me.lblResultR)
        Me.Controls.Add(Me.lblResultS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmCalculadoraInterop"
        Me.Text = "Calculadora Con Interoperabilidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResultS As Label
    Friend WithEvents lblResultR As Label
    Friend WithEvents lblResultD As Label
    Friend WithEvents lblResultM As Label
End Class
