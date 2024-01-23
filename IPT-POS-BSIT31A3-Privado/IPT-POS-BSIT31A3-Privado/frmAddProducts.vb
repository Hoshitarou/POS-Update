Imports System.Data.OleDb

Public Class frmAddProducts
    Private Sub frmAddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call products()
    End Sub

    Private Sub products()
        sql = "Select * from qryProducts"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("ProductCode").ToString)
            x.SubItems.Add(dr("ProductName").ToString)
            x.SubItems.Add(dr("ProdDesc").ToString)
            x.SubItems.Add(dr("Category").ToString)
            x.SubItems.Add(dr("Amount").ToString)
            x.SubItems.Add(dr("Quantity").ToString)
            x.SubItems.Add(dr("Criticallevel").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then

            txtProdCode.Text = ListView1.SelectedItems(0).SubItems(0).Text

            Dim sql As String = $"SELECT * FROM qryProducts WHERE ProductCode='{txtProdCode.Text}'"
            Dim cmd As New OleDbCommand(sql, cn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            If dr.Read() Then


                txtProdCode.Text = dr.Item("ProductCode").ToString
                txtProdName.Text = dr.Item("ProductName").ToString
                txtProdDesc.Text = dr.Item("ProdDesc").ToString
                tctCate.Text = dr.Item("Category").ToString
                txtAmount.Text = dr.Item("Amount").ToString
                txtQuantity.Text = dr.Item("Quantity").ToString
                txtCritlevel.Text = dr.Item("Criticallevel").ToString
                txtstatus.Text = dr.Item("Status").ToString

            End If

        End If

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        sql = "insert into tblProducts(ProductCode,ProductName,ProdDesc,Category,Amount,Quantity,Criticallevel,status)values(@ProductCode,@ProductName,@ProdDesc,@Category,@Amount,@Quantity,@Criticallevel,@status)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@ProductCode", txtProdCode.Text)
            .Parameters.AddWithValue("@ProductName", txtProdName.Text)
            .Parameters.AddWithValue("@ProdDesc", txtProdDesc.Text)
            .Parameters.AddWithValue("@Category", tctCate.Text)
            .Parameters.AddWithValue("@Amount", txtAmount.Text)
            .Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            .Parameters.AddWithValue("@Criticallevel", txtCritlevel.Text)
            .Parameters.AddWithValue("@status", txtstatus.Text)
            .ExecuteNonQuery()
        End With
        Call clearall
    End Sub

    Private Sub clearall()
        txtProdCode.Text = " "
        txtProdName.Text = " "
        txtProdDesc.Text = " "
        tctCate.Text = " "
        txtAmount.Text = " "
        txtQuantity.Text = " "
        txtCritlevel.Text = " "
        txtstatus.Text = " "
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class