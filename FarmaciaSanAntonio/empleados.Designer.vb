﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empleados
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
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.consultae = New System.Windows.Forms.Button()
        Me.salire = New System.Windows.Forms.Button()
        Me.btnRP = New System.Windows.Forms.Button()
        Me.btnBajaTP = New System.Windows.Forms.Button()
        Me.btnModP = New System.Windows.Forms.Button()
        Me.PanelEmp = New System.Windows.Forms.Panel()
        Me.ACTIVO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PUESTO = New System.Windows.Forms.ComboBox()
        Me.TELEMP = New System.Windows.Forms.TextBox()
        Me.CORREOEMP = New System.Windows.Forms.TextBox()
        Me.DIREMP = New System.Windows.Forms.TextBox()
        Me.NOMEMP = New System.Windows.Forms.TextBox()
        Me.EDADEMP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CVEMP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRE = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnre4 = New System.Windows.Forms.Button()
        Me.comboreac = New System.Windows.Forms.ComboBox()
        Me.btnReac = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelTE = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnre3 = New System.Windows.Forms.Button()
        Me.combotemporal = New System.Windows.Forms.ComboBox()
        Me.btnBajaTemp = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PanelEE = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnre2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ElimMed = New System.Windows.Forms.Button()
        Me.comboeliminar = New System.Windows.Forms.ComboBox()
        Me.btnEEmp = New System.Windows.Forms.Button()
        Me.DEPTO = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.USER = New System.Windows.Forms.TextBox()
        Me.PASS = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PanelEmp.SuspendLayout()
        Me.PanelRE.SuspendLayout()
        Me.PanelTE.SuspendLayout()
        Me.PanelEE.SuspendLayout()
        Me.SuspendLayout()
        '
        'btninsertar
        '
        Me.btninsertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btninsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsertar.ForeColor = System.Drawing.Color.DarkCyan
        Me.btninsertar.Location = New System.Drawing.Point(490, 342)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(119, 36)
        Me.btninsertar.TabIndex = 28
        Me.btninsertar.Text = "INSERTAR"
        Me.btninsertar.UseVisualStyleBackColor = False
        '
        'consultae
        '
        Me.consultae.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.consultae.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultae.ForeColor = System.Drawing.Color.DarkCyan
        Me.consultae.Location = New System.Drawing.Point(490, 384)
        Me.consultae.Name = "consultae"
        Me.consultae.Size = New System.Drawing.Size(119, 36)
        Me.consultae.TabIndex = 29
        Me.consultae.Text = "CONSULTAR"
        Me.consultae.UseVisualStyleBackColor = False
        '
        'salire
        '
        Me.salire.BackColor = System.Drawing.Color.DarkCyan
        Me.salire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salire.ForeColor = System.Drawing.Color.White
        Me.salire.Location = New System.Drawing.Point(655, 384)
        Me.salire.Name = "salire"
        Me.salire.Size = New System.Drawing.Size(119, 36)
        Me.salire.TabIndex = 30
        Me.salire.Text = "SALIR"
        Me.salire.UseVisualStyleBackColor = False
        '
        'btnRP
        '
        Me.btnRP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRP.Location = New System.Drawing.Point(548, 212)
        Me.btnRP.Name = "btnRP"
        Me.btnRP.Size = New System.Drawing.Size(184, 32)
        Me.btnRP.TabIndex = 50
        Me.btnRP.Text = "REAC. EMPLEADO"
        Me.btnRP.UseVisualStyleBackColor = False
        '
        'btnBajaTP
        '
        Me.btnBajaTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBajaTP.Location = New System.Drawing.Point(548, 176)
        Me.btnBajaTP.Name = "btnBajaTP"
        Me.btnBajaTP.Size = New System.Drawing.Size(184, 32)
        Me.btnBajaTP.TabIndex = 49
        Me.btnBajaTP.Text = "BAJA TEMP EMPLEADOS"
        Me.btnBajaTP.UseVisualStyleBackColor = False
        '
        'btnModP
        '
        Me.btnModP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnModP.Location = New System.Drawing.Point(559, 304)
        Me.btnModP.Name = "btnModP"
        Me.btnModP.Size = New System.Drawing.Size(164, 32)
        Me.btnModP.TabIndex = 46
        Me.btnModP.Text = "MOD. EMPLEADO"
        Me.btnModP.UseVisualStyleBackColor = False
        '
        'PanelEmp
        '
        Me.PanelEmp.BackColor = System.Drawing.Color.Lavender
        Me.PanelEmp.Controls.Add(Me.Label18)
        Me.PanelEmp.Controls.Add(Me.Label17)
        Me.PanelEmp.Controls.Add(Me.PASS)
        Me.PanelEmp.Controls.Add(Me.USER)
        Me.PanelEmp.Controls.Add(Me.DEPTO)
        Me.PanelEmp.Controls.Add(Me.Label12)
        Me.PanelEmp.Controls.Add(Me.ACTIVO)
        Me.PanelEmp.Controls.Add(Me.Label9)
        Me.PanelEmp.Controls.Add(Me.Label8)
        Me.PanelEmp.Controls.Add(Me.PUESTO)
        Me.PanelEmp.Controls.Add(Me.TELEMP)
        Me.PanelEmp.Controls.Add(Me.CORREOEMP)
        Me.PanelEmp.Controls.Add(Me.DIREMP)
        Me.PanelEmp.Controls.Add(Me.NOMEMP)
        Me.PanelEmp.Controls.Add(Me.EDADEMP)
        Me.PanelEmp.Controls.Add(Me.Label7)
        Me.PanelEmp.Controls.Add(Me.Label6)
        Me.PanelEmp.Controls.Add(Me.Label5)
        Me.PanelEmp.Controls.Add(Me.Label4)
        Me.PanelEmp.Controls.Add(Me.Label3)
        Me.PanelEmp.Controls.Add(Me.Label2)
        Me.PanelEmp.Controls.Add(Me.CVEMP)
        Me.PanelEmp.Controls.Add(Me.Label1)
        Me.PanelEmp.Location = New System.Drawing.Point(2, 12)
        Me.PanelEmp.Name = "PanelEmp"
        Me.PanelEmp.Size = New System.Drawing.Size(457, 426)
        Me.PanelEmp.TabIndex = 51
        '
        'ACTIVO
        '
        Me.ACTIVO.Location = New System.Drawing.Point(142, 289)
        Me.ACTIVO.MaxLength = 15
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.Size = New System.Drawing.Size(121, 20)
        Me.ACTIVO.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "ACTIVO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MetroDF", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "EMPLEADOS"
        '
        'PUESTO
        '
        Me.PUESTO.AutoCompleteCustomSource.AddRange(New String() {"CAJERO(A)", "MOSTRADOR", "ADMINISTRADOR(A)", "ENC. DE TIENDA", "CONTADOR(A)", "AUX. CONTABLE"})
        Me.PUESTO.FormattingEnabled = True
        Me.PUESTO.Items.AddRange(New Object() {"CAJERO(A)", "MOSTRADOR"})
        Me.PUESTO.Location = New System.Drawing.Point(142, 235)
        Me.PUESTO.Name = "PUESTO"
        Me.PUESTO.Size = New System.Drawing.Size(121, 21)
        Me.PUESTO.TabIndex = 45
        '
        'TELEMP
        '
        Me.TELEMP.Location = New System.Drawing.Point(142, 176)
        Me.TELEMP.MaxLength = 15
        Me.TELEMP.Name = "TELEMP"
        Me.TELEMP.Size = New System.Drawing.Size(162, 20)
        Me.TELEMP.TabIndex = 44
        '
        'CORREOEMP
        '
        Me.CORREOEMP.Location = New System.Drawing.Point(142, 150)
        Me.CORREOEMP.MaxLength = 30
        Me.CORREOEMP.Name = "CORREOEMP"
        Me.CORREOEMP.Size = New System.Drawing.Size(312, 20)
        Me.CORREOEMP.TabIndex = 43
        '
        'DIREMP
        '
        Me.DIREMP.Location = New System.Drawing.Point(142, 117)
        Me.DIREMP.MaxLength = 20
        Me.DIREMP.Name = "DIREMP"
        Me.DIREMP.Size = New System.Drawing.Size(312, 20)
        Me.DIREMP.TabIndex = 42
        '
        'NOMEMP
        '
        Me.NOMEMP.Location = New System.Drawing.Point(142, 91)
        Me.NOMEMP.MaxLength = 50
        Me.NOMEMP.Name = "NOMEMP"
        Me.NOMEMP.Size = New System.Drawing.Size(312, 20)
        Me.NOMEMP.TabIndex = 41
        '
        'EDADEMP
        '
        Me.EDADEMP.FormattingEnabled = True
        Me.EDADEMP.Location = New System.Drawing.Point(142, 202)
        Me.EDADEMP.Name = "EDADEMP"
        Me.EDADEMP.Size = New System.Drawing.Size(121, 21)
        Me.EDADEMP.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "PUESTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "EDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "TELEFONO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "CORREO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "DIRECCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "NOMBRE EMPLEADO"
        '
        'CVEMP
        '
        Me.CVEMP.FormattingEnabled = True
        Me.CVEMP.Location = New System.Drawing.Point(142, 59)
        Me.CVEMP.Name = "CVEMP"
        Me.CVEMP.Size = New System.Drawing.Size(121, 21)
        Me.CVEMP.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "CVEMP"
        '
        'PanelRE
        '
        Me.PanelRE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelRE.Controls.Add(Me.Label15)
        Me.PanelRE.Controls.Add(Me.btnre4)
        Me.PanelRE.Controls.Add(Me.comboreac)
        Me.PanelRE.Controls.Add(Me.btnReac)
        Me.PanelRE.Controls.Add(Me.Label16)
        Me.PanelRE.Location = New System.Drawing.Point(471, 10)
        Me.PanelRE.Name = "PanelRE"
        Me.PanelRE.Size = New System.Drawing.Size(326, 120)
        Me.PanelRE.TabIndex = 53
        Me.PanelRE.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "CVEMP:"
        '
        'btnre4
        '
        Me.btnre4.Location = New System.Drawing.Point(186, 77)
        Me.btnre4.Name = "btnre4"
        Me.btnre4.Size = New System.Drawing.Size(120, 32)
        Me.btnre4.TabIndex = 42
        Me.btnre4.Text = "REGRESAR"
        Me.btnre4.UseVisualStyleBackColor = True
        '
        'comboreac
        '
        Me.comboreac.FormattingEnabled = True
        Me.comboreac.Location = New System.Drawing.Point(94, 44)
        Me.comboreac.Name = "comboreac"
        Me.comboreac.Size = New System.Drawing.Size(70, 21)
        Me.comboreac.TabIndex = 41
        '
        'btnReac
        '
        Me.btnReac.Location = New System.Drawing.Point(16, 77)
        Me.btnReac.Name = "btnReac"
        Me.btnReac.Size = New System.Drawing.Size(164, 32)
        Me.btnReac.TabIndex = 40
        Me.btnReac.Text = "REACTIVAR "
        Me.btnReac.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(173, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "REACTIVACION DE EMPLEADOS"
        '
        'PanelTE
        '
        Me.PanelTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelTE.Controls.Add(Me.Label14)
        Me.PanelTE.Controls.Add(Me.btnre3)
        Me.PanelTE.Controls.Add(Me.combotemporal)
        Me.PanelTE.Controls.Add(Me.btnBajaTemp)
        Me.PanelTE.Controls.Add(Me.Label11)
        Me.PanelTE.Location = New System.Drawing.Point(465, 23)
        Me.PanelTE.Name = "PanelTE"
        Me.PanelTE.Size = New System.Drawing.Size(326, 120)
        Me.PanelTE.TabIndex = 52
        Me.PanelTE.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "CVEMP:"
        '
        'btnre3
        '
        Me.btnre3.Location = New System.Drawing.Point(186, 77)
        Me.btnre3.Name = "btnre3"
        Me.btnre3.Size = New System.Drawing.Size(120, 32)
        Me.btnre3.TabIndex = 42
        Me.btnre3.Text = "REGRESAR"
        Me.btnre3.UseVisualStyleBackColor = True
        '
        'combotemporal
        '
        Me.combotemporal.FormattingEnabled = True
        Me.combotemporal.Location = New System.Drawing.Point(94, 44)
        Me.combotemporal.Name = "combotemporal"
        Me.combotemporal.Size = New System.Drawing.Size(70, 21)
        Me.combotemporal.TabIndex = 41
        '
        'btnBajaTemp
        '
        Me.btnBajaTemp.Location = New System.Drawing.Point(16, 77)
        Me.btnBajaTemp.Name = "btnBajaTemp"
        Me.btnBajaTemp.Size = New System.Drawing.Size(164, 32)
        Me.btnBajaTemp.TabIndex = 40
        Me.btnBajaTemp.Text = "DAR DE BAJA TEMP"
        Me.btnBajaTemp.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "BAJA TEMPORAL DE EMPLEADOS"
        '
        'PanelEE
        '
        Me.PanelEE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelEE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelEE.Controls.Add(Me.Label13)
        Me.PanelEE.Controls.Add(Me.btnre2)
        Me.PanelEE.Controls.Add(Me.Label10)
        Me.PanelEE.Controls.Add(Me.ElimMed)
        Me.PanelEE.Controls.Add(Me.comboeliminar)
        Me.PanelEE.Location = New System.Drawing.Point(474, 6)
        Me.PanelEE.Name = "PanelEE"
        Me.PanelEE.Size = New System.Drawing.Size(326, 121)
        Me.PanelEE.TabIndex = 54
        Me.PanelEE.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "CVEMP:"
        '
        'btnre2
        '
        Me.btnre2.Location = New System.Drawing.Point(186, 64)
        Me.btnre2.Name = "btnre2"
        Me.btnre2.Size = New System.Drawing.Size(120, 32)
        Me.btnre2.TabIndex = 41
        Me.btnre2.Text = "REGRESAR"
        Me.btnre2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "ELIMINACION DE EMPLEADOS"
        '
        'ElimMed
        '
        Me.ElimMed.Location = New System.Drawing.Point(16, 64)
        Me.ElimMed.Name = "ElimMed"
        Me.ElimMed.Size = New System.Drawing.Size(164, 32)
        Me.ElimMed.TabIndex = 38
        Me.ElimMed.Text = "ELIMINAR EMPLEADO"
        Me.ElimMed.UseVisualStyleBackColor = True
        '
        'comboeliminar
        '
        Me.comboeliminar.DisplayMember = "uno"
        Me.comboeliminar.FormattingEnabled = True
        Me.comboeliminar.Location = New System.Drawing.Point(74, 37)
        Me.comboeliminar.Name = "comboeliminar"
        Me.comboeliminar.Size = New System.Drawing.Size(70, 21)
        Me.comboeliminar.TabIndex = 39
        '
        'btnEEmp
        '
        Me.btnEEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEEmp.Location = New System.Drawing.Point(548, 258)
        Me.btnEEmp.Name = "btnEEmp"
        Me.btnEEmp.Size = New System.Drawing.Size(184, 32)
        Me.btnEEmp.TabIndex = 55
        Me.btnEEmp.Text = "ELIM. EMPLEADO"
        Me.btnEEmp.UseVisualStyleBackColor = False
        '
        'DEPTO
        '
        Me.DEPTO.AutoCompleteCustomSource.AddRange(New String() {"COMPRAS", "VENTAS", "GERENCIA"})
        Me.DEPTO.FormattingEnabled = True
        Me.DEPTO.Items.AddRange(New Object() {"COMPRAS", "VENTAS ", "GERENCIA"})
        Me.DEPTO.Location = New System.Drawing.Point(142, 262)
        Me.DEPTO.Name = "DEPTO"
        Me.DEPTO.Size = New System.Drawing.Size(121, 21)
        Me.DEPTO.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "DEPTO"
        '
        'USER
        '
        Me.USER.Location = New System.Drawing.Point(172, 319)
        Me.USER.MaxLength = 10
        Me.USER.Name = "USER"
        Me.USER.Size = New System.Drawing.Size(161, 20)
        Me.USER.TabIndex = 51
        '
        'PASS
        '
        Me.PASS.Location = New System.Drawing.Point(172, 346)
        Me.PASS.MaxLength = 12
        Me.PASS.Name = "PASS"
        Me.PASS.Size = New System.Drawing.Size(161, 20)
        Me.PASS.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 322)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "USUARIO (OBLIGATORIO)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 349)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "CONTRASEÑA (OBLIGATORIA)"
        '
        'empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.farmaemp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEEmp)
        Me.Controls.Add(Me.PanelEE)
        Me.Controls.Add(Me.PanelRE)
        Me.Controls.Add(Me.PanelTE)
        Me.Controls.Add(Me.PanelEmp)
        Me.Controls.Add(Me.btnRP)
        Me.Controls.Add(Me.btnBajaTP)
        Me.Controls.Add(Me.btnModP)
        Me.Controls.Add(Me.salire)
        Me.Controls.Add(Me.consultae)
        Me.Controls.Add(Me.btninsertar)
        Me.Name = "empleados"
        Me.Text = "empleados"
        Me.PanelEmp.ResumeLayout(False)
        Me.PanelEmp.PerformLayout()
        Me.PanelRE.ResumeLayout(False)
        Me.PanelRE.PerformLayout()
        Me.PanelTE.ResumeLayout(False)
        Me.PanelTE.PerformLayout()
        Me.PanelEE.ResumeLayout(False)
        Me.PanelEE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btninsertar As Button
    Friend WithEvents consultae As Button
    Friend WithEvents salire As Button
    Friend WithEvents btnRP As Button
    Friend WithEvents btnBajaTP As Button
    Friend WithEvents btnModP As Button
    Friend WithEvents PanelEmp As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PUESTO As ComboBox
    Friend WithEvents TELEMP As TextBox
    Friend WithEvents CORREOEMP As TextBox
    Friend WithEvents DIREMP As TextBox
    Friend WithEvents NOMEMP As TextBox
    Friend WithEvents EDADEMP As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CVEMP As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelRE As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents btnre4 As Button
    Public WithEvents comboreac As ComboBox
    Friend WithEvents btnReac As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents PanelTE As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents btnre3 As Button
    Public WithEvents combotemporal As ComboBox
    Friend WithEvents btnBajaTemp As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PanelEE As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents btnre2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ElimMed As Button
    Public WithEvents comboeliminar As ComboBox
    Friend WithEvents btnEEmp As Button
    Friend WithEvents ACTIVO As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DEPTO As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PASS As TextBox
    Friend WithEvents USER As TextBox
End Class
