﻿Public Class detcommed
    Friend cvecomp As Integer
    Dim fechac As String

    Private Sub aniadirm_Click(sender As Object, e As EventArgs) Handles aniadirm.Click
        Dim fecha As DateTime = fechacadMed.Value
        Convert.ToDateTime(fecha)
        fechac = Format(fecha, "yyyy/MM/dd")
        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "DETCMED"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , cvecomp))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cvemed.Text)))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cantidadm.Text)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 30, tipoMed.Text))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adDBDate, ParameterDirectionEnum.adParamInput, , fechac))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , precommed.Text))
            .Parameters.Append(.CreateParameter("6", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 10, lotemed.Text))
            .Parameters.Append(.CreateParameter("7", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , gananciaMed.Text))
            .Parameters.Append(.CreateParameter("8", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
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
                    MsgBox("LA CLAVE DEL MEDICAMENTO ESTA VACIA")
                Else
                    If ban.Value = 4 Then
                        MsgBox("LA CLAVE DEL MEDICAMENTO NO EXISTE")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("LA CANTIDAD COMPRADA ESTA VACIA O ES INFERIOR A 1")
                        Else
                            If ban.Value = 6 Then
                                MsgBox("LA GANANCIA ESTA VACIA O ES INFERIOR A 1.1")
                            Else
                                If ban.Value = 7 Then
                                    MsgBox("EL TIPO DE MEDICAMENTO ESTA VACIO")
                                Else
                                    If ban.Value = 8 Then
                                        MsgBox("EL TIPO DE MEDICAMENTO DEBE DE SER 1, 2 O 3")
                                    Else
                                        If ban.Value = 9 Then
                                            MsgBox("LA FECHA DE CAD DEL MEDICAMENTO NO DEBE DE ESTAR VACIA")
                                        Else
                                            If ban.Value = 10 Then
                                                MsgBox("LA FECHA DE CAD DEL MEDICAMENTO YA CADUCO O ESTA PROXIMO A CADUCA")
                                            Else
                                                If ban.Value = 11 Then
                                                    MsgBox("EL PRECIO DE COMPRA NO DEBE DE ESTAR VACIO NI CEROO")
                                                Else
                                                    If ban.Value = 12 Then
                                                        MsgBox("EL LOTE DEL MEDICAMENTO NO DEBE DE ESTAR VACIO")
                                                    Else
                                                        If ban.Value = 13 Then
                                                            MsgBox("EL LOTE EXCEDE LOS 10 CARACTERES")
                                                        Else
                                                            MsgBox("DETALLE EXITOSO")
                                                            'AÑADIR LOS CAMPOS QUE FALTAN'
                                                            cantidadm.Text = ""
                                                            NewVenta.actualizardatos()
                                                            NewVenta.cargadatos()
                                                            NewVenta.Panel3.Enabled = True
                                                            NewVenta.btnCoVta.Enabled = True
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
            End If
        End If
        fechac = ""
    End Sub

    Private Sub btnre10_Click(sender As Object, e As EventArgs) Handles btnre10.Click
        NewCompra.habilita()
        Close()
    End Sub

    Private Sub detcommed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class