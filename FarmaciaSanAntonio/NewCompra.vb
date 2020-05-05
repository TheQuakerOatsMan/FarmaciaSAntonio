Public Class NewCompra
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "BAJACOMPRAS"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cvcomp.Text)))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(1).Value

        End With
        If ban.Value = 1 Then
            MsgBox("LA CLAVE DE LA COMPRA NO PUEDE ESTAR VACIA")
        Else
            If ban.Value = 2 Then
                MsgBox("DETALLES EXISTENTES")
            Else
                If ban.Value = 4 Then
                    MsgBox("NO SE PUEDE BORRAR LA COMPRA")
                Else
                    MsgBox("COMPRA CANCELADA")
                    menuprin.Enabled = True
                    menuprin.Visible = True
                    Close()
                    'AÑADIR LOS CAMPOS QUE FALTAN'
                End If
            End If
        End If
    End Sub


    Private Sub btnadd_Click(sender As Object, e As EventArgs)
        Productos.Enabled = True
        Productos.Visible = True
        btnAgreProd.Enabled = True
        btnAgreProd.Visible = True
        btnRegProd.Enabled = True
        btnRegProd.Visible = True

        deshabilita()
    End Sub

    Public Sub habilita()
        Label1.Enabled = True
        Label2.Enabled = True
        Label5.Enabled = True
        panelTotal.Enabled = True
        addm.Enabled = True
        btnadd.Enabled = True
        btnCancel.Enabled = True
        data1.Enabled = True
        data2.Enabled = True


        Productos.Enabled = False
        Productos.Visible = False
        btnAgreProd.Enabled = False
        btnAgreProd.Visible = False
        btnRegProd.Enabled = False
        btnRegProd.Visible = False

        Medicamentos.Enabled = False
        Medicamentos.Visible = False
        btnAgrMed.Enabled = False
        btnAgrMed.Visible = False
        btnRegMed.Enabled = False
        btnRegMed.Visible = False
    End Sub
    Public Sub deshabilita()
        Label1.Enabled = False
        Label2.Enabled = False
        Label5.Enabled = False
        panelTotal.Enabled = False
        addm.Enabled = False
        btnadd.Enabled = False
        btnCancel.Enabled = False
        data1.Enabled = False
        data2.Enabled = False
    End Sub

    Private Sub NewCompra_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioDataSet3.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.FarmSAntonioDataSet3.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioDataSet2.MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
        Me.MEDICAMENTOSTableAdapter.Fill(Me.FarmSAntonioDataSet2.MEDICAMENTOS)


        Productos.Enabled = False
        Productos.Visible = False
        btnAgreProd.Enabled = False
        btnAgreProd.Visible = False
        btnRegProd.Enabled = False
        btnRegProd.Visible = False

        Medicamentos.Enabled = False
        Medicamentos.Visible = False
        btnAgrMed.Enabled = False
        btnAgrMed.Visible = False
        btnRegMed.Enabled = False
        btnRegMed.Visible = False

        confirmEmp.Enabled = False
        confirmEmp.Visible = False

        consulta2 = New ADODB.Recordset
        consulta2 = conexion.Execute("select * from COMPRAS where CVECOMP=" & cvcomp.Text)
        If Not consulta2.EOF Then
            subt.Text = FormatCurrency(consulta2.Fields(1).Value)
            fechaCom.Text = consulta2.Fields(2).Value
        Else
            MsgBox("La cve de la compra esta vacia o no se encuentra")
        End If
        subt.Enabled = False
        fechaCom.Enabled = False
        cargadatos()
    End Sub

    Public Sub cargadatos()
        consulta2 = New ADODB.Recordset
        consulta2.Open("select medicamentos.cvemed, medicamentos.nomed, medicamentos.preciovtam, detcommed.cantcompm from medicamentos inner join detcommed on detcommed.cvemed=medicamentos.cvemed where cvecomp=" & cvcomp.Text, modulo.conexion)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As New DataSet
        ODA.Fill(ds, modulo.consulta2, "Table1")
        data1.DataSource = ds.Tables("Table1").DefaultView
        consulta3 = New ADODB.Recordset
        consulta3.Open("select productos.cveprod, productos.nomp, productos.PRECIOCOMP, DETCOMPRO.CANTCOMP from productos inner join DETCOMPRO on DETCOMPRO.cveprod=productos.cveprod where cvecomp=" & cvcomp.Text, modulo.conexion)
        Dim ODA2 As New OleDb.OleDbDataAdapter
        Dim tb2 As New DataTable
        Dim ds2 As New DataSet
        ODA.Fill(ds2, modulo.consulta3, "Table1")
        data2.DataSource = ds2.Tables("Table1").DefaultView
    End Sub



    Private Sub addm_Click(sender As Object, e As EventArgs)
        Medicamentos.Enabled = True
        Medicamentos.Visible = True
        btnAgrMed.Enabled = True
        btnAgrMed.Visible = True
        btnRegMed.Enabled = True
        btnRegMed.Visible = True

        deshabilita()
    End Sub

    Private Sub btnRegMed_Click(sender As Object, e As EventArgs) Handles btnRegMed.Click
        habilita()
    End Sub

    Private Sub btnRegProd_Click(sender As Object, e As EventArgs) Handles btnRegProd.Click
        habilita()
    End Sub



    Private Sub btnReComp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgreProd_Click(sender As Object, e As EventArgs) Handles btnAgreProd.Click

    End Sub

    Private Sub btnAgrMed_Click(sender As Object, e As EventArgs) Handles btnAgrMed.Click

    End Sub

    Private Sub btnReComp_Click_1(sender As Object, e As EventArgs) Handles btnReComp.Click
        MessageBox.Show("COMPRA REALIZADA CON EXITO")
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub
End Class