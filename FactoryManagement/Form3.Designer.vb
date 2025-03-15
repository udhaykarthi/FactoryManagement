<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RawMaterialSupplierBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactoryManagementDataSet = New FactoryManagement.FactoryManagementDataSet()
        Me.RawMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RawMaterialTableAdapter = New FactoryManagement.FactoryManagementDataSetTableAdapters.RawMaterialTableAdapter()
        Me.RawMaterialSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RawMaterialSupplierTableAdapter = New FactoryManagement.FactoryManagementDataSetTableAdapters.RawMaterialSupplierTableAdapter()
        Me.RawMaterialSupplierBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RawMaterialSupplierBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RawMaterialSupplierBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactoryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RawMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RawMaterialSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RawMaterialSupplierBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RawMaterialSupplierBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 126)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(167, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(266, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(167, 274)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(265, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(165, 362)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(263, 20)
        Me.TextBox4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Material Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quality"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Raw Material Supplier"
        '
        'RawMaterialSupplierBindingSource2
        '
        Me.RawMaterialSupplierBindingSource2.DataMember = "RawMaterialSupplier"
        Me.RawMaterialSupplierBindingSource2.DataSource = Me.FactoryManagementDataSet
        '
        'FactoryManagementDataSet
        '
        Me.FactoryManagementDataSet.DataSetName = "FactoryManagementDataSet"
        Me.FactoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RawMaterialBindingSource
        '
        Me.RawMaterialBindingSource.DataMember = "RawMaterial"
        Me.RawMaterialBindingSource.DataSource = Me.FactoryManagementDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(591, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(779, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 37)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(974, 513)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 38)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(782, 594)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 36)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(974, 589)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 41)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RawMaterialTableAdapter
        '
        Me.RawMaterialTableAdapter.ClearBeforeFill = True
        '
        'RawMaterialSupplierBindingSource
        '
        Me.RawMaterialSupplierBindingSource.DataMember = "RawMaterialSupplier"
        Me.RawMaterialSupplierBindingSource.DataSource = Me.FactoryManagementDataSet
        '
        'RawMaterialSupplierTableAdapter
        '
        Me.RawMaterialSupplierTableAdapter.ClearBeforeFill = True
        '
        'RawMaterialSupplierBindingSource1
        '
        Me.RawMaterialSupplierBindingSource1.DataMember = "RawMaterialSupplier"
        Me.RawMaterialSupplierBindingSource1.DataSource = Me.FactoryManagementDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductidDataGridViewTextBoxColumn, Me.MaterialTypeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RawMaterialSupplierBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(641, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 347)
        Me.DataGridView1.TabIndex = 15
        '
        'RawMaterialSupplierBindingSource3
        '
        Me.RawMaterialSupplierBindingSource3.DataMember = "RawMaterialSupplier"
        Me.RawMaterialSupplierBindingSource3.DataSource = Me.FactoryManagementDataSet
        '
        'ProductidDataGridViewTextBoxColumn
        '
        Me.ProductidDataGridViewTextBoxColumn.DataPropertyName = "Product_id"
        Me.ProductidDataGridViewTextBoxColumn.HeaderText = "Product_id"
        Me.ProductidDataGridViewTextBoxColumn.Name = "ProductidDataGridViewTextBoxColumn"
        Me.ProductidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialTypeDataGridViewTextBoxColumn
        '
        Me.MaterialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType"
        Me.MaterialTypeDataGridViewTextBoxColumn.HeaderText = "MaterialType"
        Me.MaterialTypeDataGridViewTextBoxColumn.Name = "MaterialTypeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 716)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form3"
        Me.Text = "Raw Material Supplier"
        CType(Me.RawMaterialSupplierBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactoryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RawMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RawMaterialSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RawMaterialSupplierBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RawMaterialSupplierBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents FactoryManagementDataSet As FactoryManagementDataSet
    Friend WithEvents RawMaterialBindingSource As BindingSource
    Friend WithEvents RawMaterialTableAdapter As FactoryManagementDataSetTableAdapters.RawMaterialTableAdapter
    Friend WithEvents RawMaterialSupplierBindingSource As BindingSource
    Friend WithEvents RawMaterialSupplierTableAdapter As FactoryManagementDataSetTableAdapters.RawMaterialSupplierTableAdapter
    Friend WithEvents RawMaterialSupplierBindingSource1 As BindingSource
    Friend WithEvents RawMaterialSupplierBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RawMaterialSupplierBindingSource3 As BindingSource
End Class
