﻿Public Class menuprin
    Private Sub menuprin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Close()
        If (depa = "COMPRAS") Then
            VENTASToolStripMenuItem.Visible = False
            EMPLEADOSToolStripMenuItem.Visible = False
            Call DMyP()
        End If
        If (depa = "VENTAS") Then
            PROVEEDORESToolStripMenuItem.Visible = False
            COMPRASToolStripMenuItem.Visible = False
            CADUCIDADToolStripMenuItem.Visible = False
            Call DMyP()
            Ventas_Gnral.btnmodImg.Visible = False
            Ventas_Gnral.modV.Visible = False
            Ventas_Gnral.elimM.Visible = False
            Ventas_Gnral.elimP.Visible = False
            Ventas_Gnral.ELIMINA.Visible = False
            ALTASToolStripMenuItem1.Visible = False
            MODEMPLEADOSToolStripMenuItem.Visible = False
            empleados.btninsertar.Enabled = False
            empleados.btnEEmp.Enabled = False
            empleados.btnBajaTP.Enabled = False
            empleados.btnModP.Enabled = False
            empleados.btnRP.Enabled = False

        End If
    End Sub
    Public Sub DMyP()
        AltasToolStripMenuItem2.Visible = False
        AltasToolStripMenuItem3.Visible = False
        Medicamentos_gnral.btnEM.Visible = False
        Medicamentos_gnral.btnBajaTM.Visible = False
        Medicamentos_gnral.btnInsM.Visible = False
        Medicamentos_gnral.btnRM.Visible = False
        Medicamentos_gnral.btnModM.Visible = False
        ProductosGral.btnInsP.Visible = False
        ProductosGral.btnBajaTP.Visible = False
        ProductosGral.btnEP.Visible = False
        ProductosGral.btnModP.Visible = False
        ProductosGral.btnRP.Visible = False
    End Sub
    Private Sub ALTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTASToolStripMenuItem.Click
        proveedores.Show()
        proveedores.CVEPROV.Enabled = False
        proveedores.NOMPROV.Enabled = True
        proveedores.EMPRESA.Enabled = True
        proveedores.DIRPROV.Enabled = True
        proveedores.DIREMPSA.Enabled = True
        proveedores.TELPROV.Enabled = True
        proveedores.ESTADO.Enabled = True
        proveedores.CODIGOP.Enabled = True
        proveedores.LOCALIDAD.Enabled = True
        proveedores.CORREOPROV.Enabled = True
        proveedores.binserta.Enabled = True
        proveedores.bconsult.Enabled = False
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        ban = New ADODB.Parameter
        comando = New ADODB.Command
        If (depa = "COMPRAS") Then
            Call conectavta()

            With comando
                .CommandText = "FINALIZASESION"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 10, nusuario))
                .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
                .ActiveConnection = conexionv
                .Execute()
                ban.Value = .Parameters(1).Value
            End With
            If ban.Value = 1 Then
                MsgBox("NO PUEDE ESTAR VACIO EL NOMBRE DEL USUARIO")
            Else
                If ban.Value = 2 Then
                    MsgBox("EL USUARIO NO EXISTE, VERIFICA")
                Else
                    MsgBox("SESIÓN FINALIZADA")
                    depa = ""
                    conexionv.Close()
                    conexionc.Close()

                    inicio.Enabled = True
                    Close()
                End If
            End If
        Else
            With comando
                .CommandText = "FINALIZASESION"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 10, nusuario))
                .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
                .ActiveConnection = conexionv
                .Execute()
                ban.Value = .Parameters(1).Value
            End With
            If ban.Value = 1 Then
                MsgBox("NO PUEDE ESTAR VACIO EL NOMBRE DEL USUARIO")
            Else
                If ban.Value = 2 Then
                    MsgBox("EL USUARIO NO EXISTE, VERIFICA")
                Else
                    MsgBox("SESIÓN FINALIZADA")
                    If (depa = "VENTAS") Then
                        conexionv.Close()
                        depa = ""
                    End If
                    If (depa = "GERENCIA") Then
                        conexionc.Close()
                        conexionv.Close()
                        depa = ""
                    End If

                    inicio.Enabled = True
                    Close()
                End If
            End If
        End If


    End Sub

    Private Sub CONSULTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTASToolStripMenuItem.Click
        proveedores.Show()
        proveedores.CVEPROV.Enabled = True
        proveedores.NOMPROV.Enabled = False
        proveedores.EMPRESA.Enabled = False
        proveedores.DIRPROV.Enabled = False
        proveedores.DIREMPSA.Enabled = False
        proveedores.TELPROV.Enabled = False
        proveedores.ESTADO.Enabled = False
        proveedores.CODIGOP.Enabled = False
        proveedores.LOCALIDAD.Enabled = False
        proveedores.CORREOPROV.Enabled = False
        proveedores.ACTIVO.Enabled = False
        proveedores.binserta.Enabled = False
        proveedores.bconsult.Enabled = True
    End Sub

    Private Sub ALTASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ALTASToolStripMenuItem1.Click
        empleados.Show()
        empleados.CVEMP.Enabled = False
        empleados.NOMEMP.Enabled = True
        empleados.DIREMP.Enabled = True
        empleados.TELEMP.Enabled = True
        empleados.CORREOEMP.Enabled = True
        empleados.EDADEMP.Enabled = True
        empleados.PUESTO.Enabled = True
        empleados.ACTIVO.Visible = False
        empleados.Label9.Visible = False
        empleados.btninsertar.Enabled = True
        empleados.consultae.Enabled = False
        empleados.btnModP.Visible = False
        empleados.btnRP.Visible = False
        empleados.btnBajaTP.Visible = False
        empleados.btnEEmp.Visible = False
    End Sub

    Private Sub CONSULTASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONSULTASToolStripMenuItem1.Click

        empleados.Show()
        empleados.CVEMP.Enabled = True
        empleados.NOMEMP.Enabled = False
        empleados.DIREMP.Enabled = False
        empleados.TELEMP.Enabled = False
        empleados.CORREOEMP.Enabled = False
        empleados.EDADEMP.Enabled = False
        empleados.PUESTO.Enabled = False
        empleados.ACTIVO.Enabled = False
        empleados.DEPTO.Enabled = False
        empleados.USER.Enabled = False
        empleados.PASS.Enabled = False
        empleados.btninsertar.Enabled = False
        empleados.consultae.Enabled = True
        empleados.btnModP.Visible = True
        empleados.btnRP.Visible = True
        empleados.btnBajaTP.Visible = True
        empleados.btnEEmp.Visible = True
    End Sub

    Private Sub CONSULTAGRALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAGRALToolStripMenuItem.Click
        proveedores_gral.Show()
    End Sub

    Private Sub ConsultaDeMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeMedicamentosToolStripMenuItem.Click
        Medicamentos_gnral.Show()
        Medicamentos_gnral.CVEMED.Enabled = True
        Medicamentos_gnral.NOMED.Enabled = False
        Medicamentos_gnral.DESCRIPCIONM.Enabled = False
        Medicamentos_gnral.PRECIOCOMPM.Enabled = False
        Medicamentos_gnral.PRECIOVTAM.Enabled = False
        Medicamentos_gnral.ESTADO.Enabled = False
        Medicamentos_gnral.EXISTENCIASM.Enabled = False
        Medicamentos_gnral.btnInsM.Enabled = False
        Medicamentos_gnral.btnConsulta.Enabled = True
        Medicamentos_gnral.btnEM.Enabled = True
        Medicamentos_gnral.btnBajaTM.Enabled = True
    End Sub

    Private Sub AltasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem2.Click
        Medicamentos_gnral.Show()
        Medicamentos_gnral.CVEMED.Enabled = False
        Medicamentos_gnral.NOMED.Enabled = True
        Medicamentos_gnral.DESCRIPCIONM.Enabled = True
        Medicamentos_gnral.PRECIOCOMPM.Enabled = False
        Medicamentos_gnral.PRECIOVTAM.Enabled = False
        Medicamentos_gnral.ESTADO.Enabled = False
        Medicamentos_gnral.EXISTENCIASM.Enabled = False
        Medicamentos_gnral.btnInsM.Enabled = True
        Medicamentos_gnral.btnConsulta.Enabled = False
        Medicamentos_gnral.btnEM.Enabled = False
        Medicamentos_gnral.btnBajaTM.Enabled = False
        Medicamentos_gnral.btnModM.Enabled = False
        Medicamentos_gnral.btnRM.Enabled = False

    End Sub

    Private Sub ConsultaDeProdcutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeProdcutosToolStripMenuItem.Click
        ProductosGral.Show()
        ProductosGral.CVEPROD.Enabled = True
        ProductosGral.NOMPROD.Enabled = False
        ProductosGral.DESCRIP.Enabled = False
        ProductosGral.PRECIOCOMP.Enabled = False
        ProductosGral.PRECIOVTAP.Enabled = False
        ProductosGral.ESTADO.Enabled = False
        ProductosGral.EXISTENCIASP.Enabled = False
        ProductosGral.btnInsP.Enabled = False
        ProductosGral.btnConsultaP.Enabled = True
        ProductosGral.btnEP.Enabled = True
        ProductosGral.btnBajaTP.Enabled = True
        ProductosGral.btnModP.Enabled = True
        ProductosGral.btnRP.Enabled = True
    End Sub

    Private Sub AltasToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem3.Click
        ProductosGral.Show()
        ProductosGral.CVEPROD.Enabled = False
        ProductosGral.NOMPROD.Enabled = True
        ProductosGral.DESCRIP.Enabled = True
        ProductosGral.PRECIOCOMP.Enabled = False
        ProductosGral.PRECIOVTAP.Enabled = False
        ProductosGral.ESTADO.Enabled = False
        ProductosGral.EXISTENCIASP.Enabled = False
        ProductosGral.btnInsP.Enabled = True
        ProductosGral.btnConsultaP.Enabled = False
        ProductosGral.btnEP.Enabled = False
        ProductosGral.btnBajaTP.Enabled = False
        ProductosGral.btnModP.Enabled = False
        ProductosGral.btnRP.Enabled = False
    End Sub

    Private Sub TodasLasVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasLasVentasToolStripMenuItem.Click
        Ventas_Gnral.Show()
        Ventas_Gnral.CVEVTA.Enabled = True
        Ventas_Gnral.SUBTOTAL.Enabled = False
        Ventas_Gnral.TIPOP.Enabled = False
        Ventas_Gnral.IVA.Enabled = False
        Ventas_Gnral.FECHA.Enabled = False
        Ventas_Gnral.modV.Enabled = False
        Ventas_Gnral.elimM.Enabled = False
        Ventas_Gnral.elimP.Enabled = False
    End Sub

    Private Sub AgregarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarVentaToolStripMenuItem.Click
        confirmEmp.Show()
    End Sub

    Private Sub CONSULTASGRALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTASGRALToolStripMenuItem.Click
        empleados_gnral.Show()
    End Sub

    Private Sub MODEMPLEADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODEMPLEADOSToolStripMenuItem.Click
        modEmpleados.Show()
        modEmpleados.CVEMP.Enabled = True
        modEmpleados.btnApli.Enabled = False
        modEmpleados.btncan.Enabled = False
        modEmpleados.salirME.Visible = True
        modEmpleados.btnre2.Visible = False
        modEmpleados.valor = 2
        modEmpleados.moT.Enabled = True
        modEmpleados.btncan.Enabled = False
        modEmpleados.btnApli.Enabled = False
        modEmpleados.modN.Enabled = False
        modEmpleados.modP.Enabled = False
        modEmpleados.modE.Enabled = False
        modEmpleados.modEGral.Enabled = False
    End Sub

    Private Sub TodosLoProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLoProductosToolStripMenuItem.Click
        TodosProd.Show()
    End Sub

    Private Sub TodasLasVentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodasLasVentasToolStripMenuItem1.Click
        TodasVentas.Show()
    End Sub

    Private Sub TodosLosMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosMedicamentosToolStripMenuItem.Click
        TodosMed.Show()
    End Sub

    Private Sub TodasLasComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasLasComprasToolStripMenuItem.Click
        TodasCompras.Show()
    End Sub

    Private Sub PróximosACaducarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PróximosACaducarToolStripMenuItem.Click
        ProxCad.Show()
    End Sub

    Private Sub AgregarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCompraToolStripMenuItem.Click
        confirmEmpComp.Show()
    End Sub

    Private Sub ConsultarComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarComprasToolStripMenuItem.Click
        Compras_Gnral.Show()
        Compras_Gnral.FECHA.Enabled = False
        Compras_Gnral.DETALLEMED.Enabled = False
        Compras_Gnral.elimP.Enabled = False
    End Sub
End Class