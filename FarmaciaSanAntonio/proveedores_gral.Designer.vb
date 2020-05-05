<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores_gral
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salirprovt = New System.Windows.Forms.Button()
        Me.CVEPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIREMPSADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREOPROVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDORESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet6 = New FarmaciaSanAntonio.FarmSAntonioDataSet6()
        Me.PROVEEDORESTableAdapter2 = New FarmaciaSanAntonio.FarmSAntonioDataSet6TableAdapters.PROVEEDORESTableAdapter()
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet1 = New FarmaciaSanAntonio.FarmSAntonioDataSet1()
        Me.PROVEEDORESTableAdapter1 = New FarmaciaSanAntonio.FarmSAntonioDataSet1TableAdapters.PROVEEDORESTableAdapter()
        Me.FarmSAntonioDataSet = New FarmaciaSanAntonio.FarmSAntonioDataSet()
        Me.PROVEEDORESBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROVEEDORESTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSetTableAdapters.PROVEEDORESTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVEPROVDataGridViewTextBoxColumn, Me.NOMPROVDataGridViewTextBoxColumn, Me.EMPRESADataGridViewTextBoxColumn, Me.DIRPROVDataGridViewTextBoxColumn, Me.DIREMPSADataGridViewTextBoxColumn, Me.TELPROVDataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.CODIGOPDataGridViewTextBoxColumn, Me.LOCALIDADDataGridViewTextBoxColumn, Me.CORREOPROVDataGridViewTextBoxColumn, Me.ACTIVO})
        Me.DataGridView1.DataSource = Me.PROVEEDORESBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(784, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'ACTIVO
        '
        Me.ACTIVO.DataPropertyName = "ACTIVO"
        Me.ACTIVO.HeaderText = "ACTIVO"
        Me.ACTIVO.MinimumWidth = 8
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.Width = 150
        '
        'salirprovt
        '
        Me.salirprovt.BackColor = System.Drawing.Color.DarkCyan
        Me.salirprovt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salirprovt.ForeColor = System.Drawing.Color.White
        Me.salirprovt.Location = New System.Drawing.Point(659, 361)
        Me.salirprovt.Name = "salirprovt"
        Me.salirprovt.Size = New System.Drawing.Size(98, 38)
        Me.salirprovt.TabIndex = 1
        Me.salirprovt.Text = "SALIR"
        Me.salirprovt.UseVisualStyleBackColor = False
        '
        'CVEPROVDataGridViewTextBoxColumn
        '
        Me.CVEPROVDataGridViewTextBoxColumn.DataPropertyName = "CVEPROV"
        Me.CVEPROVDataGridViewTextBoxColumn.HeaderText = "CVEPROV"
        Me.CVEPROVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CVEPROVDataGridViewTextBoxColumn.Name = "CVEPROVDataGridViewTextBoxColumn"
        Me.CVEPROVDataGridViewTextBoxColumn.Width = 150
        '
        'NOMPROVDataGridViewTextBoxColumn
        '
        Me.NOMPROVDataGridViewTextBoxColumn.DataPropertyName = "NOMPROV"
        Me.NOMPROVDataGridViewTextBoxColumn.HeaderText = "NOMPROV"
        Me.NOMPROVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NOMPROVDataGridViewTextBoxColumn.Name = "NOMPROVDataGridViewTextBoxColumn"
        Me.NOMPROVDataGridViewTextBoxColumn.Width = 150
        '
        'EMPRESADataGridViewTextBoxColumn
        '
        Me.EMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA"
        Me.EMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA"
        Me.EMPRESADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EMPRESADataGridViewTextBoxColumn.Name = "EMPRESADataGridViewTextBoxColumn"
        Me.EMPRESADataGridViewTextBoxColumn.Width = 150
        '
        'DIRPROVDataGridViewTextBoxColumn
        '
        Me.DIRPROVDataGridViewTextBoxColumn.DataPropertyName = "DIRPROV"
        Me.DIRPROVDataGridViewTextBoxColumn.HeaderText = "DIRPROV"
        Me.DIRPROVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DIRPROVDataGridViewTextBoxColumn.Name = "DIRPROVDataGridViewTextBoxColumn"
        Me.DIRPROVDataGridViewTextBoxColumn.Width = 150
        '
        'DIREMPSADataGridViewTextBoxColumn
        '
        Me.DIREMPSADataGridViewTextBoxColumn.DataPropertyName = "DIREMPSA"
        Me.DIREMPSADataGridViewTextBoxColumn.HeaderText = "DIREMPSA"
        Me.DIREMPSADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DIREMPSADataGridViewTextBoxColumn.Name = "DIREMPSADataGridViewTextBoxColumn"
        Me.DIREMPSADataGridViewTextBoxColumn.Width = 150
        '
        'TELPROVDataGridViewTextBoxColumn
        '
        Me.TELPROVDataGridViewTextBoxColumn.DataPropertyName = "TELPROV"
        Me.TELPROVDataGridViewTextBoxColumn.HeaderText = "TELPROV"
        Me.TELPROVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TELPROVDataGridViewTextBoxColumn.Name = "TELPROVDataGridViewTextBoxColumn"
        Me.TELPROVDataGridViewTextBoxColumn.Width = 150
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.Width = 150
        '
        'CODIGOPDataGridViewTextBoxColumn
        '
        Me.CODIGOPDataGridViewTextBoxColumn.DataPropertyName = "CODIGOP"
        Me.CODIGOPDataGridViewTextBoxColumn.HeaderText = "CODIGOP"
        Me.CODIGOPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CODIGOPDataGridViewTextBoxColumn.Name = "CODIGOPDataGridViewTextBoxColumn"
        Me.CODIGOPDataGridViewTextBoxColumn.Width = 150
        '
        'LOCALIDADDataGridViewTextBoxColumn
        '
        Me.LOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "LOCALIDAD"
        Me.LOCALIDADDataGridViewTextBoxColumn.HeaderText = "LOCALIDAD"
        Me.LOCALIDADDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LOCALIDADDataGridViewTextBoxColumn.Name = "LOCALIDADDataGridViewTextBoxColumn"
        Me.LOCALIDADDataGridViewTextBoxColumn.Width = 150
        '
        'CORREOPROVDataGridViewTextBoxColumn
        '
        Me.CORREOPROVDataGridViewTextBoxColumn.DataPropertyName = "CORREOPROV"
        Me.CORREOPROVDataGridViewTextBoxColumn.HeaderText = "CORREOPROV"
        Me.CORREOPROVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CORREOPROVDataGridViewTextBoxColumn.Name = "CORREOPROVDataGridViewTextBoxColumn"
        Me.CORREOPROVDataGridViewTextBoxColumn.Width = 150
        '
        'PROVEEDORESBindingSource1
        '
        Me.PROVEEDORESBindingSource1.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource1.DataSource = Me.FarmSAntonioDataSet6
        '
        'FarmSAntonioDataSet6
        '
        Me.FarmSAntonioDataSet6.DataSetName = "FarmSAntonioDataSet6"
        Me.FarmSAntonioDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROVEEDORESTableAdapter2
        '
        Me.PROVEEDORESTableAdapter2.ClearBeforeFill = True
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.FarmSAntonioDataSet1
        '
        'FarmSAntonioDataSet1
        '
        Me.FarmSAntonioDataSet1.DataSetName = "FarmSAntonioDataSet1"
        Me.FarmSAntonioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROVEEDORESTableAdapter1
        '
        Me.PROVEEDORESTableAdapter1.ClearBeforeFill = True
        '
        'FarmSAntonioDataSet
        '
        Me.FarmSAntonioDataSet.DataSetName = "FarmSAntonioDataSet"
        Me.FarmSAntonioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROVEEDORESBindingSource2
        '
        Me.PROVEEDORESBindingSource2.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource2.DataSource = Me.FarmSAntonioDataSet
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'proveedores_gral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salirprovt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "proveedores_gral"
        Me.Text = "proveedores_gral"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROVEEDORESBindingSource As BindingSource
    Friend WithEvents salirprovt As Button
    Friend WithEvents FarmSAntonioDataSet1 As FarmSAntonioDataSet1
    Friend WithEvents PROVEEDORESTableAdapter1 As FarmSAntonioDataSet1TableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents CVEPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPRESADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIRPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIREMPSADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CORREOPROVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO As DataGridViewTextBoxColumn
    Friend WithEvents FarmSAntonioDataSet6 As FarmSAntonioDataSet6
    Friend WithEvents PROVEEDORESBindingSource1 As BindingSource
    Friend WithEvents PROVEEDORESTableAdapter2 As FarmSAntonioDataSet6TableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents FarmSAntonioDataSet As FarmSAntonioDataSet
    Friend WithEvents PROVEEDORESBindingSource2 As BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As FarmSAntonioDataSetTableAdapters.PROVEEDORESTableAdapter
End Class
