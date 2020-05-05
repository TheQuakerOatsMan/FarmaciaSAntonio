Public Class detcompro
    Friend cvecomp As Integer
    Dim fechac As String

    Private Sub aniadirm_Click(sender As Object, e As EventArgs) Handles aniadirm.Click
        Dim fecha As DateTime = fechacadProd.Value
        Convert.ToDateTime(fecha)
        fechac = Format(fecha, "yyyy/MM/dd")
        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "DETCPROD"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , cvecomp))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cveprod.Text)))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , cantP.Text))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adDBDate, ParameterDirectionEnum.adParamInput, , fechac))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , precomprod.Text))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 10, loteprod.Text))
            .Parameters.Append(.CreateParameter("6", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , Val(gananciaProd.Text)))
            .Parameters.Append(.CreateParameter("7", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(4).Value

        End With
        If ban.Value = 1 Then
            MsgBox("LA CLAVE DE COMPRA NO DEBE DE ESTAR VACIA")
        Else
            If ban.Value = 2 Then
                MsgBox("LA CLAVE DE COMPRA NO EXISTE")
            Else
                If ban.Value = 3 Then
                    MsgBox("LA CLAVE DEL PRODUCTO ESTA VACIA")
                Else
                    If ban.Value = 4 Then
                        MsgBox("LA CLAVE DEL PRODUCTO NO EXISTE")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("LA CANTIDAD COMPRADA ESTA VACIA O ES INFERIOR A 1")
                        Else
                            If ban.Value = 6 Then
                                MsgBox("LA FECHA DE CAD DEL PRODUCTO NO DEBE DE ESTAR VACIA")
                            Else
                                If ban.Value = 7 Then
                                    MsgBox("LA FECHA DE CAD DEL PRODUCTO YA CADUCO O ESTA PROXIMO A CADUCAR")
                                Else
                                    If ban.Value = 8 Then
                                        MsgBox("EL PRECIO DE COMPRA NO DEBE DE ESTAR VACIO NI CERO")
                                    Else
                                        If ban.Value = 9 Then
                                            MsgBox("LA GANANCIA ESTA VACIA O ES INFERIOR A 1.1")
                                        Else
                                            If ban.Value = 10 Then
                                                MsgBox("EL LOTE NO DEBE DE ESTAR VACIO")
                                            Else
                                                If ban.Value = 11 Then
                                                    MsgBox("EL LOTE EXCEDE LOS 10 CARACTERES")
                                                Else
                                                    MsgBox("DETALLE EXITOSO")
                                                    'AÑADIR LOS CAMPOS QUE FALTAN'
                                                    NewVenta.actualizardatos()
                                                    NewVenta.cargadatos()
                                                    NewVenta.Panel3.Enabled = True
                                                    NewVenta.btnCoVta.Enabled = True
                                                    cantP.Text = ""
                                                    Close()
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        fechac = ""
    End Sub
    Private Sub btnre10_Click(sender As Object, e As EventArgs) Handles btnre10.Click
        NewCompra.habilita()
        Close()
    End Sub

    Private Sub detcompro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class