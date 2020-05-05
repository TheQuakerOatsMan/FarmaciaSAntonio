Imports System.Data.SqlClient

Public Class ProxCad
    Private Sub salircapt_Click(sender As Object, e As EventArgs) Handles salircapt.Click
        menuprin.Enabled = True
        Close()
    End Sub

    Private Sub ProxCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta2 = New ADODB.Recordset
        consulta2.Open("SELECT FECHACAD, NOMED, NOMP FROM MEDICAMENTOS, PRODUCTOS, CADUCIDAD WHERE CVEMED IN (SELECT CVEMED FROM DETCADMED WHERE CVECAD IN (SELECT CVECAD FROM CADUCIDAD WHERE CVECAD IN (SELECT CVECAD FROM DETCADPRO WHERE CVEPROD IN (SELECT CVEPROD FROM PRODUCTOS))))")
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As New DataSet
        ODA.Fill(ds, modulo.consulta2, "Table1")
        DataGridView1.DataSource = ds.Tables("Table1").DefaultView
    End Sub
End Class