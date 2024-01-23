Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmsales
    Private Sub frmsales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadsales()
        Call listotal()

    End Sub

    Private Sub listotal()
        Dim result As Double = 0
        For j As Integer = 0 To ListView1.Items.Count - 1 Step +1
            result += CInt(ListView1.Items(j).SubItems(4).Text)
        Next
        lblgrandtotal.Text = result.ToString("0.00")


    End Sub



    Private Sub loadsales()

        sql = "Select * from qrySales"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("TransNo").ToString)
            x.SubItems.Add(dr("Transdate").ToString)
            x.SubItems.Add(dr("Transtime").ToString)
            x.SubItems.Add(dr("Totalamount").ToString)
            x.SubItems.Add(dr("VAT").ToString)
            x.SubItems.Add(dr("VatableSale").ToString)
            x.SubItems.Add(dr("Discount").ToString)
            x.SubItems.Add(dr("Discounttype").ToString)
            x.SubItems.Add(dr("AmountPaid").ToString)
            x.SubItems.Add(dr("AmountChange").ToString)
            x.SubItems.Add(dr("MOP").ToString)
            x.SubItems.Add(dr("RefNo").ToString)
            x.SubItems.Add(dr("Cashiername").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class