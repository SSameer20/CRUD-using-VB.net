Imports System.Data.SqlClient

Public Class Form1
    Dim selectedRowId = 0
    Dim brandId = 0
    Dim categoryId = 0
    Dim connectionString As String = "Data Source=ZENX\SQLEXPRESS04; Initial Catalog=BikeStores; Integrated Security = True"
    Dim con As SqlConnection
    Dim cmd As New SqlCommand
    Dim sda As SqlDataAdapter
    Dim sdaCat As SqlDataAdapter
    Dim dt As DataTable
    Dim dtBrand As DataTable
    Dim dtCat As DataTable
    Dim drc As DataGridViewRowCollection
    Dim dr As DataGridViewRow
    Dim dlgResult As DialogResult

    Dim query = ""
    ''' <summary>
    ''' Fill grid view with Products Data
    ''' </summary>
    Private Sub FillGrid()
        con = New SqlConnection(connectionString)
        cmd = New SqlCommand("Select * from production.products ORDER BY product_id DESC", con)
        con.Open()
        sda = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sda.Fill(dt)

        productsGV.DataSource = dt
        con.Close()

    End Sub


    '<summary>
    ' To fill Brand And Category dropdowns
    ' </summary>
    Private Sub FillData()
        cmd = New SqlCommand("Select * from production.brands", con)
        con.Open()
        sda = New SqlDataAdapter(cmd)
        dtBrand = New DataTable()
        sda.Fill(dtBrand)

        ddlBrand.DataSource = dtBrand
        ddlBrand.DisplayMember = "brand_name"
        ddlBrand.ValueMember = "brand_id"

        cmd = New SqlCommand("Select * from production.categories", con)
        sdaCat = New SqlDataAdapter(cmd)
        dtCat = New DataTable()
        sdaCat.Fill(dtCat)

        ddlCategory.DataSource = dtCat
        ddlCategory.DisplayMember = "category_name"
        ddlCategory.ValueMember = "category_id"

        con.Close()
    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged
        ValidateForm()
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        ValidateForm()
    End Sub

    Private Sub txtModel_TextChanged(sender As Object, e As EventArgs)
        ValidateForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con.Open()
        cmd = New SqlCommand("sp_addUpdateProductData", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@productName", txtProduct.Text)
        cmd.Parameters.AddWithValue("@brandId", ddlBrand.SelectedValue)
        cmd.Parameters.AddWithValue("@categoryId", ddlCategory.SelectedValue)
        cmd.Parameters.AddWithValue("@model", txtModel.Text)
        cmd.Parameters.AddWithValue("@unitPrice", txtPrice.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Product added successfully.", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        Clear()
        FillGrid()
    End Sub

    Private Sub Clear()
        txtProduct.Clear()
        txtModel.Clear()
        txtPrice.Clear()
        ddlBrand.SelectedIndex = -1
        ddlCategory.SelectedIndex = -1
        selectedRowId = brandId = categoryId = 0
        ValidateForm()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedRowId > 0 Then
            con.Open()
            cmd = New SqlCommand("sp_addUpdateProductData", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@productId", selectedRowId)
            cmd.Parameters.AddWithValue("@productName", txtProduct.Text)
            cmd.Parameters.AddWithValue("@brandId", ddlBrand.SelectedValue)
            cmd.Parameters.AddWithValue("@categoryId", ddlCategory.SelectedValue)
            cmd.Parameters.AddWithValue("@model", txtModel.Text)
            cmd.Parameters.AddWithValue("@unitPrice", txtPrice.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product added successfully.", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Clear()
            FillGrid()
        Else
            MessageBox.Show("Please select a grid row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dlgResult = MessageBox.Show("Are you sure you want to delete this record ? ", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If (dlgResult.ToString() Is "Yes") Then
            query = "delete from production.products where product_id = " + selectedRowId

            con.Open()
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            FillGrid()
            Clear()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub ValidateForm()
        If (txtProduct.Text IsNot "" And
        txtModel.Text IsNot "" And
        txtPrice.Text IsNot "" And
        ddlBrand.SelectedValue IsNot Nothing And
        ddlCategory.SelectedValue IsNot Nothing) Then
            If selectedRowId > 0 Then
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
            Else
                btnSave.Enabled = True
            End If
        Else
            btnSave.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub productsGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productsGV.CellContentClick
        drc = productsGV.Rows
        dr = drc(e.RowIndex)
        selectedRowId = Convert.ToInt32(dr.Cells(0).Value)
        brandId = Convert.ToInt32(dr.Cells(2).Value) - 1
        categoryId = Convert.ToInt32(dr.Cells(3).Value) - 1

        ddlBrand.SelectedIndex = brandId
        ddlCategory.SelectedIndex = categoryId
        txtProduct.Text = dr.Cells(1).Value.ToString()
        txtModel.Text = dr.Cells(4).Value.ToString()
        txtPrice.Text = dr.Cells(5).Value.ToString()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
        FillData()
    End Sub

    Private Sub ddlBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlBrand.SelectedIndexChanged
        ValidateForm()
    End Sub

    Private Sub ddlCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCategory.SelectedIndexChanged
        ValidateForm()
    End Sub
End Class





'// Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs)

' End Sub

