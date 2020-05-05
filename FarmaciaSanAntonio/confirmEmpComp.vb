Public Class confirmEmpComp

    Dim cveemp As Integer
    Dim ccomp As Integer
    Dim name2 As String

    Private Sub confirmEmpComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        consulta = New ADODB.Recordset
        consulta = conexion.Execute("select cvemp from empleados order by cvemp")
        name2 = ""
        While Not consulta.EOF
            cvemp.Items.Add(consulta.Fields(0).Value) 'si no jala fijate en referencias y en propiedades, y le ponemos la opcion 5 en false'
            consulta.MoveNext()
        End While

        consulta2 = New ADODB.Recordset
        consulta2 = conexion.Execute("select cveprov from proveedores order by cveprov")
        name2 = ""
        While Not consulta2.EOF
            procombox.Items.Add(consulta2.Fields(0).Value) 'si no jala fijate en referencias y en propiedades, y le ponemos la opcion 5 en false'
            consulta2.MoveNext()
        End While
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        menuprin.Enabled = True
        Close()
    End Sub

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        consulta3 = New ADODB.Recordset
        consulta3 = conexion.Execute("select * from empleados where cvemp=" & cvemp.Text)
        If Not consulta3.EOF Then
            cveemp = consulta3.Fields(0).Value
            Name = consulta3.Fields(1).Value
        Else
            MsgBox("La cve del empleado esta vacia o el empleado esta dado de baja")
        End If

        ban = New ADODB.Parameter
        Dim clave As Integer
        clave = 0
        comando = New ADODB.Command
        With comando
            .CommandText = "COMAUTO"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , procombox.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(1).Value

        End With
        If ban.Value = 1 Then
            MsgBox("LA CLAVE NO DEBE ESTAR VACÍA O SER 0")
        Else
            If ban.Value = 2 Then
                MsgBox("LA CLAVE DEL PROVEEDOR NO EXISTE")
            Else
                If ban.Value = 3 Then
                    MsgBox("ESTE PROVEEDOR ESTA INACTIVO O DADO DE BAJA")
                Else
                    consql = ("select max(cvecomp) from compras")
                    consulta = New ADODB.Recordset
                    consulta = conexion.Execute(consql)
                    If Not consulta.EOF Then
                        clave = consulta.Fields(0).Value
                    End If
                    MsgBox("La cve del la compra es: " & clave & " INSERCIÓN CORRECTA")
                    'AÑADIR LOS CAMPOS QUE FALTAN'

                    menuprin.Visible = False

                    NewCompra.cvcomp.Text = clave
                    NewCompra.ctNEmp.Text = Name
                    NewCompra.ctemp.Text = cvemp.Text

                    NewCompra.cvcomp.Enabled = False
                    NewCompra.ctNEmp.Enabled = False
                    NewCompra.ctemp.Enabled = False
                    clave = 0
                    NewCompra.Show()
                    Close()
                End If
            End If
        End If
    End Sub


End Class