﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detvtam
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aniadirp = New System.Windows.Forms.Button()
        Me.btnre8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cveprod = New System.Windows.Forms.TextBox()
        Me.nompro = New System.Windows.Forms.TextBox()
        Me.cantvp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prevtaprod = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AÑADIR PRODUCTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CVEPROD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CANTIDAD:"
        '
        'aniadirp
        '
        Me.aniadirp.Location = New System.Drawing.Point(24, 167)
        Me.aniadirp.Name = "aniadirp"
        Me.aniadirp.Size = New System.Drawing.Size(104, 23)
        Me.aniadirp.TabIndex = 3
        Me.aniadirp.Text = "AÑADIR PROD."
        Me.aniadirp.UseVisualStyleBackColor = True
        '
        'btnre8
        '
        Me.btnre8.Location = New System.Drawing.Point(155, 167)
        Me.btnre8.Name = "btnre8"
        Me.btnre8.Size = New System.Drawing.Size(75, 23)
        Me.btnre8.TabIndex = 4
        Me.btnre8.Text = "REGRESAR"
        Me.btnre8.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NOMBREPROD:"
        '
        'cveprod
        '
        Me.cveprod.Enabled = False
        Me.cveprod.Location = New System.Drawing.Point(137, 34)
        Me.cveprod.Name = "cveprod"
        Me.cveprod.Size = New System.Drawing.Size(47, 20)
        Me.cveprod.TabIndex = 6
        '
        'nompro
        '
        Me.nompro.Enabled = False
        Me.nompro.Location = New System.Drawing.Point(137, 69)
        Me.nompro.Name = "nompro"
        Me.nompro.Size = New System.Drawing.Size(142, 20)
        Me.nompro.TabIndex = 7
        '
        'cantvp
        '
        Me.cantvp.FormattingEnabled = True
        Me.cantvp.Location = New System.Drawing.Point(140, 130)
        Me.cantvp.Name = "cantvp"
        Me.cantvp.Size = New System.Drawing.Size(59, 21)
        Me.cantvp.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PRECIOVTAPROD:"
        '
        'prevtaprod
        '
        Me.prevtaprod.Enabled = False
        Me.prevtaprod.Location = New System.Drawing.Point(140, 103)
        Me.prevtaprod.Name = "prevtaprod"
        Me.prevtaprod.Size = New System.Drawing.Size(73, 20)
        Me.prevtaprod.TabIndex = 10
        '
        'detvtam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 218)
        Me.Controls.Add(Me.prevtaprod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cantvp)
        Me.Controls.Add(Me.nompro)
        Me.Controls.Add(Me.cveprod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnre8)
        Me.Controls.Add(Me.aniadirp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detvtam"
        Me.Text = "detvtprod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents aniadirp As Button
    Friend WithEvents btnre8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cveprod As TextBox
    Friend WithEvents nompro As TextBox
    Friend WithEvents cantvp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents prevtaprod As TextBox
End Class
