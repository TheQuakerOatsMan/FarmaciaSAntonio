﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras_Gnral
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
        Me.panDetProd = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dataDetcompro = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.panelEP = New System.Windows.Forms.Panel()
        Me.panFechaProd = New System.Windows.Forms.Panel()
        Me.timepprod = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.regprodF = New System.Windows.Forms.Button()
        Me.acpFechaProd = New System.Windows.Forms.Button()
        Me.panGanProd = New System.Windows.Forms.Panel()
        Me.txtgananprod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.regfechProd = New System.Windows.Forms.Button()
        Me.acepFechaProd = New System.Windows.Forms.Button()
        Me.panelGanMed = New System.Windows.Forms.Panel()
        Me.txtganancia = New System.Windows.Forms.TextBox()
        Me.panFechaMed = New System.Windows.Forms.Panel()
        Me.timepmed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnAcep = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dataDetComed = New System.Windows.Forms.DataGridView()
        Me.btnre11 = New System.Windows.Forms.Button()
        Me.btnEDP = New System.Windows.Forms.Button()
        Me.panelET = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnre16 = New System.Windows.Forms.Button()
        Me.btneTodo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combocomp = New System.Windows.Forms.ComboBox()
        Me.panelP = New System.Windows.Forms.Panel()
        Me.ELIMINA = New System.Windows.Forms.Button()
        Me.elimP = New System.Windows.Forms.Button()
        Me.DETALLEMED = New System.Windows.Forms.Button()
        Me.salirV = New System.Windows.Forms.Button()
        Me.consultav = New System.Windows.Forms.Button()
        Me.FECHA = New System.Windows.Forms.TextBox()
        Me.TOTALCOMP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CVECOMP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panDetProd.SuspendLayout()
        CType(Me.dataDetcompro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEP.SuspendLayout()
        Me.panFechaProd.SuspendLayout()
        Me.panGanProd.SuspendLayout()
        Me.panelGanMed.SuspendLayout()
        Me.panFechaMed.SuspendLayout()
        CType(Me.dataDetComed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelET.SuspendLayout()
        Me.panelP.SuspendLayout()
        Me.SuspendLayout()
        '
        'panDetProd
        '
        Me.panDetProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panDetProd.BackColor = System.Drawing.Color.Lavender
        Me.panDetProd.Controls.Add(Me.Button6)
        Me.panDetProd.Controls.Add(Me.Label8)
        Me.panDetProd.Controls.Add(Me.dataDetcompro)
        Me.panDetProd.Controls.Add(Me.Button7)
        Me.panDetProd.Controls.Add(Me.Button8)
        Me.panDetProd.Location = New System.Drawing.Point(279, 3)
        Me.panDetProd.Name = "panDetProd"
        Me.panDetProd.Size = New System.Drawing.Size(513, 329)
        Me.panDetProd.TabIndex = 78
        Me.panDetProd.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button6.Location = New System.Drawing.Point(31, 227)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(192, 36)
        Me.Button6.TabIndex = 51
        Me.Button6.Text = "MOD FECHA CAD"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "DETALLE DE COMPRA DE PRODUCTOS:"
        '
        'dataDetcompro
        '
        Me.dataDetcompro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDetcompro.Location = New System.Drawing.Point(30, 35)
        Me.dataDetcompro.Name = "dataDetcompro"
        Me.dataDetcompro.RowHeadersWidth = 62
        Me.dataDetcompro.Size = New System.Drawing.Size(452, 144)
        Me.dataDetcompro.TabIndex = 49
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkCyan
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(30, 269)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(192, 36)
        Me.Button7.TabIndex = 48
        Me.Button7.Text = "REGRESAR"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button8.Location = New System.Drawing.Point(31, 185)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(192, 36)
        Me.Button8.TabIndex = 47
        Me.Button8.Text = "MOD GANANCIA"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'panelEP
        '
        Me.panelEP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelEP.BackColor = System.Drawing.Color.Lavender
        Me.panelEP.Controls.Add(Me.panFechaProd)
        Me.panelEP.Controls.Add(Me.panGanProd)
        Me.panelEP.Controls.Add(Me.panelGanMed)
        Me.panelEP.Controls.Add(Me.Button1)
        Me.panelEP.Controls.Add(Me.Label10)
        Me.panelEP.Controls.Add(Me.dataDetComed)
        Me.panelEP.Controls.Add(Me.btnre11)
        Me.panelEP.Controls.Add(Me.btnEDP)
        Me.panelEP.Location = New System.Drawing.Point(279, 3)
        Me.panelEP.Name = "panelEP"
        Me.panelEP.Size = New System.Drawing.Size(513, 329)
        Me.panelEP.TabIndex = 77
        Me.panelEP.Visible = False
        '
        'panFechaProd
        '
        Me.panFechaProd.BackColor = System.Drawing.Color.Lavender
        Me.panFechaProd.Controls.Add(Me.timepprod)
        Me.panFechaProd.Controls.Add(Me.Label7)
        Me.panFechaProd.Controls.Add(Me.regprodF)
        Me.panFechaProd.Controls.Add(Me.acpFechaProd)
        Me.panFechaProd.Location = New System.Drawing.Point(125, 66)
        Me.panFechaProd.Name = "panFechaProd"
        Me.panFechaProd.Size = New System.Drawing.Size(276, 193)
        Me.panFechaProd.TabIndex = 72
        Me.panFechaProd.Visible = False
        '
        'timepprod
        '
        Me.timepprod.Location = New System.Drawing.Point(40, 39)
        Me.timepprod.Name = "timepprod"
        Me.timepprod.Size = New System.Drawing.Size(200, 20)
        Me.timepprod.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "NUEVA FECHA DE CADUCIDAD:"
        '
        'regprodF
        '
        Me.regprodF.BackColor = System.Drawing.Color.DarkCyan
        Me.regprodF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regprodF.ForeColor = System.Drawing.Color.White
        Me.regprodF.Location = New System.Drawing.Point(44, 121)
        Me.regprodF.Name = "regprodF"
        Me.regprodF.Size = New System.Drawing.Size(192, 36)
        Me.regprodF.TabIndex = 58
        Me.regprodF.Text = "REGRESAR"
        Me.regprodF.UseVisualStyleBackColor = False
        '
        'acpFechaProd
        '
        Me.acpFechaProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.acpFechaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acpFechaProd.ForeColor = System.Drawing.Color.DarkCyan
        Me.acpFechaProd.Location = New System.Drawing.Point(44, 79)
        Me.acpFechaProd.Name = "acpFechaProd"
        Me.acpFechaProd.Size = New System.Drawing.Size(192, 36)
        Me.acpFechaProd.TabIndex = 57
        Me.acpFechaProd.Text = "ACEPTAR"
        Me.acpFechaProd.UseVisualStyleBackColor = False
        '
        'panGanProd
        '
        Me.panGanProd.BackColor = System.Drawing.Color.Lavender
        Me.panGanProd.Controls.Add(Me.txtgananprod)
        Me.panGanProd.Controls.Add(Me.Label4)
        Me.panGanProd.Controls.Add(Me.regfechProd)
        Me.panGanProd.Controls.Add(Me.acepFechaProd)
        Me.panGanProd.Location = New System.Drawing.Point(123, 66)
        Me.panGanProd.Name = "panGanProd"
        Me.panGanProd.Size = New System.Drawing.Size(276, 193)
        Me.panGanProd.TabIndex = 70
        Me.panGanProd.Visible = False
        '
        'txtgananprod
        '
        Me.txtgananprod.Location = New System.Drawing.Point(89, 45)
        Me.txtgananprod.Name = "txtgananprod"
        Me.txtgananprod.Size = New System.Drawing.Size(100, 20)
        Me.txtgananprod.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "NUEVA GANANCIA:"
        '
        'regfechProd
        '
        Me.regfechProd.BackColor = System.Drawing.Color.DarkCyan
        Me.regfechProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regfechProd.ForeColor = System.Drawing.Color.White
        Me.regfechProd.Location = New System.Drawing.Point(44, 121)
        Me.regfechProd.Name = "regfechProd"
        Me.regfechProd.Size = New System.Drawing.Size(192, 36)
        Me.regfechProd.TabIndex = 58
        Me.regfechProd.Text = "REGRESAR"
        Me.regfechProd.UseVisualStyleBackColor = False
        '
        'acepFechaProd
        '
        Me.acepFechaProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.acepFechaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acepFechaProd.ForeColor = System.Drawing.Color.DarkCyan
        Me.acepFechaProd.Location = New System.Drawing.Point(44, 79)
        Me.acepFechaProd.Name = "acepFechaProd"
        Me.acepFechaProd.Size = New System.Drawing.Size(192, 36)
        Me.acepFechaProd.TabIndex = 57
        Me.acepFechaProd.Text = "ACEPTAR"
        Me.acepFechaProd.UseVisualStyleBackColor = False
        '
        'panelGanMed
        '
        Me.panelGanMed.BackColor = System.Drawing.Color.Lavender
        Me.panelGanMed.Controls.Add(Me.txtganancia)
        Me.panelGanMed.Controls.Add(Me.panFechaMed)
        Me.panelGanMed.Controls.Add(Me.Label3)
        Me.panelGanMed.Controls.Add(Me.btnRegresar)
        Me.panelGanMed.Controls.Add(Me.btnAcep)
        Me.panelGanMed.Location = New System.Drawing.Point(125, 66)
        Me.panelGanMed.Name = "panelGanMed"
        Me.panelGanMed.Size = New System.Drawing.Size(276, 193)
        Me.panelGanMed.TabIndex = 69
        Me.panelGanMed.Visible = False
        '
        'txtganancia
        '
        Me.txtganancia.Location = New System.Drawing.Point(89, 45)
        Me.txtganancia.Name = "txtganancia"
        Me.txtganancia.Size = New System.Drawing.Size(100, 20)
        Me.txtganancia.TabIndex = 60
        '
        'panFechaMed
        '
        Me.panFechaMed.BackColor = System.Drawing.Color.Lavender
        Me.panFechaMed.Controls.Add(Me.timepmed)
        Me.panFechaMed.Controls.Add(Me.Label6)
        Me.panFechaMed.Controls.Add(Me.Button2)
        Me.panFechaMed.Controls.Add(Me.Button3)
        Me.panFechaMed.Location = New System.Drawing.Point(3, 93)
        Me.panFechaMed.Name = "panFechaMed"
        Me.panFechaMed.Size = New System.Drawing.Size(276, 193)
        Me.panFechaMed.TabIndex = 71
        Me.panFechaMed.Visible = False
        '
        'timepmed
        '
        Me.timepmed.Location = New System.Drawing.Point(40, 39)
        Me.timepmed.Name = "timepmed"
        Me.timepmed.Size = New System.Drawing.Size(200, 20)
        Me.timepmed.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "NUEVA FECHA DE CADUCIDAD:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(44, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 36)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "REGRESAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button3.Location = New System.Drawing.Point(44, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 36)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "ACEPTAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "NUEVA GANANCIA:"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(44, 121)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(192, 36)
        Me.btnRegresar.TabIndex = 58
        Me.btnRegresar.Text = "REGRESAR"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnAcep
        '
        Me.btnAcep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcep.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnAcep.Location = New System.Drawing.Point(44, 79)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(192, 36)
        Me.btnAcep.TabIndex = 57
        Me.btnAcep.Text = "ACEPTAR"
        Me.btnAcep.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Location = New System.Drawing.Point(31, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 36)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "MOD FECHA CAD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(233, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "DETALLE DE COMPRA DE MEDICAMENTOS:"
        '
        'dataDetComed
        '
        Me.dataDetComed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDetComed.Location = New System.Drawing.Point(30, 35)
        Me.dataDetComed.Name = "dataDetComed"
        Me.dataDetComed.RowHeadersWidth = 62
        Me.dataDetComed.Size = New System.Drawing.Size(452, 144)
        Me.dataDetComed.TabIndex = 49
        '
        'btnre11
        '
        Me.btnre11.BackColor = System.Drawing.Color.DarkCyan
        Me.btnre11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre11.ForeColor = System.Drawing.Color.White
        Me.btnre11.Location = New System.Drawing.Point(30, 269)
        Me.btnre11.Name = "btnre11"
        Me.btnre11.Size = New System.Drawing.Size(192, 36)
        Me.btnre11.TabIndex = 48
        Me.btnre11.Text = "REGRESAR"
        Me.btnre11.UseVisualStyleBackColor = False
        '
        'btnEDP
        '
        Me.btnEDP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEDP.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnEDP.Location = New System.Drawing.Point(31, 185)
        Me.btnEDP.Name = "btnEDP"
        Me.btnEDP.Size = New System.Drawing.Size(192, 36)
        Me.btnEDP.TabIndex = 47
        Me.btnEDP.Text = "MOD GANANCIA"
        Me.btnEDP.UseVisualStyleBackColor = False
        '
        'panelET
        '
        Me.panelET.BackColor = System.Drawing.Color.Lavender
        Me.panelET.Controls.Add(Me.Label12)
        Me.panelET.Controls.Add(Me.btnre16)
        Me.panelET.Controls.Add(Me.btneTodo)
        Me.panelET.Controls.Add(Me.Label11)
        Me.panelET.Controls.Add(Me.combocomp)
        Me.panelET.Location = New System.Drawing.Point(516, 3)
        Me.panelET.Name = "panelET"
        Me.panelET.Size = New System.Drawing.Size(276, 212)
        Me.panelET.TabIndex = 76
        Me.panelET.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(87, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "ELIMINAR COMPRAS"
        '
        'btnre16
        '
        Me.btnre16.BackColor = System.Drawing.Color.DarkCyan
        Me.btnre16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre16.ForeColor = System.Drawing.Color.White
        Me.btnre16.Location = New System.Drawing.Point(61, 149)
        Me.btnre16.Name = "btnre16"
        Me.btnre16.Size = New System.Drawing.Size(172, 36)
        Me.btnre16.TabIndex = 58
        Me.btnre16.Text = "REGRESAR"
        Me.btnre16.UseVisualStyleBackColor = False
        '
        'btneTodo
        '
        Me.btneTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btneTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneTodo.ForeColor = System.Drawing.Color.DarkCyan
        Me.btneTodo.Location = New System.Drawing.Point(44, 99)
        Me.btneTodo.Name = "btneTodo"
        Me.btneTodo.Size = New System.Drawing.Size(192, 36)
        Me.btneTodo.TabIndex = 57
        Me.btneTodo.Text = "ELIMINAR"
        Me.btneTodo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "CVECOMP:"
        '
        'combocomp
        '
        Me.combocomp.FormattingEnabled = True
        Me.combocomp.Location = New System.Drawing.Point(112, 63)
        Me.combocomp.Name = "combocomp"
        Me.combocomp.Size = New System.Drawing.Size(121, 21)
        Me.combocomp.TabIndex = 55
        '
        'panelP
        '
        Me.panelP.BackColor = System.Drawing.Color.Transparent
        Me.panelP.Controls.Add(Me.ELIMINA)
        Me.panelP.Controls.Add(Me.elimP)
        Me.panelP.Controls.Add(Me.DETALLEMED)
        Me.panelP.Controls.Add(Me.salirV)
        Me.panelP.Controls.Add(Me.consultav)
        Me.panelP.Controls.Add(Me.FECHA)
        Me.panelP.Controls.Add(Me.TOTALCOMP)
        Me.panelP.Controls.Add(Me.Label5)
        Me.panelP.Controls.Add(Me.Label2)
        Me.panelP.Controls.Add(Me.CVECOMP)
        Me.panelP.Controls.Add(Me.Label1)
        Me.panelP.Location = New System.Drawing.Point(9, 3)
        Me.panelP.Name = "panelP"
        Me.panelP.Size = New System.Drawing.Size(253, 329)
        Me.panelP.TabIndex = 75
        '
        'ELIMINA
        '
        Me.ELIMINA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ELIMINA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINA.ForeColor = System.Drawing.Color.DarkCyan
        Me.ELIMINA.Location = New System.Drawing.Point(6, 227)
        Me.ELIMINA.Name = "ELIMINA"
        Me.ELIMINA.Size = New System.Drawing.Size(244, 36)
        Me.ELIMINA.TabIndex = 68
        Me.ELIMINA.Text = "ELIMINAR COMPRA"
        Me.ELIMINA.UseVisualStyleBackColor = False
        '
        'elimP
        '
        Me.elimP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.elimP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimP.ForeColor = System.Drawing.Color.DarkCyan
        Me.elimP.Location = New System.Drawing.Point(6, 185)
        Me.elimP.Name = "elimP"
        Me.elimP.Size = New System.Drawing.Size(244, 36)
        Me.elimP.TabIndex = 66
        Me.elimP.Text = "DETALLE PROD"
        Me.elimP.UseVisualStyleBackColor = False
        '
        'DETALLEMED
        '
        Me.DETALLEMED.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DETALLEMED.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DETALLEMED.ForeColor = System.Drawing.Color.DarkCyan
        Me.DETALLEMED.Location = New System.Drawing.Point(6, 143)
        Me.DETALLEMED.Name = "DETALLEMED"
        Me.DETALLEMED.Size = New System.Drawing.Size(244, 36)
        Me.DETALLEMED.TabIndex = 65
        Me.DETALLEMED.Text = "DETALLE MED"
        Me.DETALLEMED.UseVisualStyleBackColor = False
        '
        'salirV
        '
        Me.salirV.BackColor = System.Drawing.Color.DarkCyan
        Me.salirV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirV.ForeColor = System.Drawing.Color.White
        Me.salirV.Location = New System.Drawing.Point(57, 269)
        Me.salirV.Name = "salirV"
        Me.salirV.Size = New System.Drawing.Size(119, 36)
        Me.salirV.TabIndex = 64
        Me.salirV.Text = "SALIR"
        Me.salirV.UseVisualStyleBackColor = False
        '
        'consultav
        '
        Me.consultav.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.consultav.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultav.ForeColor = System.Drawing.Color.DarkCyan
        Me.consultav.Location = New System.Drawing.Point(6, 101)
        Me.consultav.Name = "consultav"
        Me.consultav.Size = New System.Drawing.Size(244, 36)
        Me.consultav.TabIndex = 63
        Me.consultav.Text = "CONSULTAR"
        Me.consultav.UseVisualStyleBackColor = False
        '
        'FECHA
        '
        Me.FECHA.Location = New System.Drawing.Point(115, 66)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(135, 20)
        Me.FECHA.TabIndex = 62
        '
        'TOTALCOMP
        '
        Me.TOTALCOMP.Location = New System.Drawing.Point(115, 40)
        Me.TOTALCOMP.Name = "TOTALCOMP"
        Me.TOTALCOMP.Size = New System.Drawing.Size(135, 20)
        Me.TOTALCOMP.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "FECHA DE COMPRA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "TOTAL COMPRA ($)"
        '
        'CVECOMP
        '
        Me.CVECOMP.FormattingEnabled = True
        Me.CVECOMP.Location = New System.Drawing.Point(115, 14)
        Me.CVECOMP.Name = "CVECOMP"
        Me.CVECOMP.Size = New System.Drawing.Size(135, 21)
        Me.CVECOMP.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "CVECOMPRA:"
        '
        'Compras_Gnral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 335)
        Me.Controls.Add(Me.panDetProd)
        Me.Controls.Add(Me.panelEP)
        Me.Controls.Add(Me.panelET)
        Me.Controls.Add(Me.panelP)
        Me.Name = "Compras_Gnral"
        Me.Text = "Compras"
        Me.panDetProd.ResumeLayout(False)
        Me.panDetProd.PerformLayout()
        CType(Me.dataDetcompro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEP.ResumeLayout(False)
        Me.panelEP.PerformLayout()
        Me.panFechaProd.ResumeLayout(False)
        Me.panFechaProd.PerformLayout()
        Me.panGanProd.ResumeLayout(False)
        Me.panGanProd.PerformLayout()
        Me.panelGanMed.ResumeLayout(False)
        Me.panelGanMed.PerformLayout()
        Me.panFechaMed.ResumeLayout(False)
        Me.panFechaMed.PerformLayout()
        CType(Me.dataDetComed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelET.ResumeLayout(False)
        Me.panelET.PerformLayout()
        Me.panelP.ResumeLayout(False)
        Me.panelP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panDetProd As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dataDetcompro As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents panelEP As Panel
    Friend WithEvents panFechaProd As Panel
    Friend WithEvents timepprod As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents regprodF As Button
    Friend WithEvents acpFechaProd As Button
    Friend WithEvents panGanProd As Panel
    Friend WithEvents txtgananprod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents regfechProd As Button
    Friend WithEvents acepFechaProd As Button
    Friend WithEvents panelGanMed As Panel
    Friend WithEvents txtganancia As TextBox
    Friend WithEvents panFechaMed As Panel
    Friend WithEvents timepmed As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnAcep As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dataDetComed As DataGridView
    Friend WithEvents btnre11 As Button
    Friend WithEvents btnEDP As Button
    Friend WithEvents panelET As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnre16 As Button
    Friend WithEvents btneTodo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents combocomp As ComboBox
    Friend WithEvents panelP As Panel
    Friend WithEvents ELIMINA As Button
    Friend WithEvents elimP As Button
    Friend WithEvents DETALLEMED As Button
    Friend WithEvents salirV As Button
    Friend WithEvents consultav As Button
    Friend WithEvents FECHA As TextBox
    Friend WithEvents TOTALCOMP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CVECOMP As ComboBox
    Friend WithEvents Label1 As Label
End Class
