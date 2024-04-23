<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblProduct = New Label()
        lblModel = New Label()
        lblUnitPrice = New Label()
        lblBrand = New Label()
        lblCategory = New Label()
        txtProduct = New TextBox()
        txtModel = New TextBox()
        txtPrice = New TextBox()
        ddlBrand = New ComboBox()
        ddlCategory = New ComboBox()
        productsGV = New DataGridView()
        btnSave = New Button()
        btnClear = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnShow = New Button()
        CType(productsGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblProduct
        ' 
        lblProduct.AutoSize = True
        lblProduct.Location = New Point(64, 53)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(104, 20)
        lblProduct.TabIndex = 0
        lblProduct.Text = "Product Name"
        ' 
        ' lblModel
        ' 
        lblModel.AutoSize = True
        lblModel.Location = New Point(64, 101)
        lblModel.Name = "lblModel"
        lblModel.Size = New Size(84, 20)
        lblModel.TabIndex = 1
        lblModel.Text = "Model Year"
        ' 
        ' lblUnitPrice
        ' 
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Location = New Point(66, 148)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(72, 20)
        lblUnitPrice.TabIndex = 2
        lblUnitPrice.Text = "Unit Price"
        lblUnitPrice.TextAlign = ContentAlignment.TopRight
        lblUnitPrice.UseMnemonic = False
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Location = New Point(67, 198)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(65, 20)
        lblBrand.TabIndex = 3
        lblBrand.Text = "Brand Id"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(70, 243)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(91, 20)
        lblCategory.TabIndex = 4
        lblCategory.Text = "ddlCategory"
        ' 
        ' txtProduct
        ' 
        txtProduct.Location = New Point(176, 52)
        txtProduct.Name = "txtProduct"
        txtProduct.Size = New Size(125, 27)
        txtProduct.TabIndex = 5
        ' 
        ' txtModel
        ' 
        txtModel.Location = New Point(174, 100)
        txtModel.Name = "txtModel"
        txtModel.Size = New Size(125, 27)
        txtModel.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(176, 144)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 27)
        txtPrice.TabIndex = 7
        ' 
        ' ddlBrand
        ' 
        ddlBrand.FormattingEnabled = True
        ddlBrand.Location = New Point(178, 194)
        ddlBrand.Name = "ddlBrand"
        ddlBrand.Size = New Size(151, 28)
        ddlBrand.TabIndex = 8
        ' 
        ' ddlCategory
        ' 
        ddlCategory.FormattingEnabled = True
        ddlCategory.Location = New Point(181, 240)
        ddlCategory.Name = "ddlCategory"
        ddlCategory.Size = New Size(151, 28)
        ddlCategory.TabIndex = 9
        ' 
        ' productsGV
        ' 
        productsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productsGV.Location = New Point(373, 69)
        productsGV.Name = "productsGV"
        productsGV.RowHeadersWidth = 51
        productsGV.Size = New Size(566, 319)
        productsGV.TabIndex = 10
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(64, 299)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(196, 300)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(65, 342)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(197, 342)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(67, 392)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(224, 29)
        btnShow.TabIndex = 15
        btnShow.Text = "Show All"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(971, 450)
        Controls.Add(btnShow)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(productsGV)
        Controls.Add(ddlCategory)
        Controls.Add(ddlBrand)
        Controls.Add(txtPrice)
        Controls.Add(txtModel)
        Controls.Add(txtProduct)
        Controls.Add(lblCategory)
        Controls.Add(lblBrand)
        Controls.Add(lblUnitPrice)
        Controls.Add(lblModel)
        Controls.Add(lblProduct)
        Name = "Form1"
        Text = "Form1"
        CType(productsGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProduct As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents ddlBrand As ComboBox
    Friend WithEvents ddlCategory As ComboBox
    Friend WithEvents productsGV As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnShow As Button

End Class
