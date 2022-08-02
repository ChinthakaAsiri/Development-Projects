<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdd_Drug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdd_Drug))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtyoreder = New System.Windows.Forms.TextBox()
        Me.txtQtyinStock = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtDrugname = New System.Windows.Forms.TextBox()
        Me.txtDrugid = New System.Windows.Forms.TextBox()
        Me.txtMdate = New System.Windows.Forms.TextBox()
        Me.txtEdate = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.txtOrderdate = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DAdrug = New System.Data.SqlClient.SqlDataAdapter()
        Me.DSdrug1 = New Main.DSdrug()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalQtyOrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiveDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DSdrug1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.lblTime.Location = New System.Drawing.Point(77, 50)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(110, 27)
        Me.lblTime.TabIndex = 7
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.lblUser.Location = New System.Drawing.Point(77, 10)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(110, 25)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "Admin1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(17, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Time :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Drug_ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Drug_Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Brand Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Qty in Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total Qty Ordered"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(324, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Manufacture Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(622, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Exp Date"
        '
        'txtQtyoreder
        '
        Me.txtQtyoreder.Location = New System.Drawing.Point(452, 166)
        Me.txtQtyoreder.Name = "txtQtyoreder"
        Me.txtQtyoreder.Size = New System.Drawing.Size(116, 21)
        Me.txtQtyoreder.TabIndex = 5
        '
        'txtQtyinStock
        '
        Me.txtQtyinStock.Location = New System.Drawing.Point(452, 115)
        Me.txtQtyinStock.Name = "txtQtyinStock"
        Me.txtQtyinStock.Size = New System.Drawing.Size(116, 21)
        Me.txtQtyinStock.TabIndex = 4
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(124, 216)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(116, 21)
        Me.txtBrand.TabIndex = 3
        '
        'txtDrugname
        '
        Me.txtDrugname.Location = New System.Drawing.Point(124, 166)
        Me.txtDrugname.Name = "txtDrugname"
        Me.txtDrugname.Size = New System.Drawing.Size(116, 21)
        Me.txtDrugname.TabIndex = 2
        '
        'txtDrugid
        '
        Me.txtDrugid.Location = New System.Drawing.Point(124, 118)
        Me.txtDrugid.Name = "txtDrugid"
        Me.txtDrugid.Size = New System.Drawing.Size(116, 21)
        Me.txtDrugid.TabIndex = 1
        '
        'txtMdate
        '
        Me.txtMdate.Location = New System.Drawing.Point(452, 216)
        Me.txtMdate.Name = "txtMdate"
        Me.txtMdate.Size = New System.Drawing.Size(116, 21)
        Me.txtMdate.TabIndex = 6
        '
        'txtEdate
        '
        Me.txtEdate.Location = New System.Drawing.Point(721, 112)
        Me.txtEdate.Name = "txtEdate"
        Me.txtEdate.Size = New System.Drawing.Size(116, 21)
        Me.txtEdate.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Location = New System.Drawing.Point(33, 572)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 31)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.Location = New System.Drawing.Point(316, 572)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 31)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "UpDate"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Purple
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(170, 572)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 31)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(622, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Order Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(622, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Received Date"
        '
        'Timer1
        '
        '
        'txtReceive
        '
        Me.txtReceive.Location = New System.Drawing.Point(721, 216)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(116, 21)
        Me.txtReceive.TabIndex = 9
        '
        'txtOrderdate
        '
        Me.txtOrderdate.Location = New System.Drawing.Point(721, 163)
        Me.txtOrderdate.Name = "txtOrderdate"
        Me.txtOrderdate.Size = New System.Drawing.Size(116, 21)
        Me.txtOrderdate.TabIndex = 8
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Drug.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Drug"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=Tr" & _
            "ue"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Drug_ID", System.Data.SqlDbType.VarChar, 0, "Drug_ID"), New System.Data.SqlClient.SqlParameter("@DrugName", System.Data.SqlDbType.VarChar, 0, "DrugName"), New System.Data.SqlClient.SqlParameter("@Total_Qty_Ordered", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Total Qty Ordered", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Orderdate", System.Data.SqlDbType.VarChar, 0, "Orderdate"), New System.Data.SqlClient.SqlParameter("@ReceiveDate", System.Data.SqlDbType.VarChar, 0, "ReceiveDate"), New System.Data.SqlClient.SqlParameter("@ManufaDate", System.Data.SqlDbType.VarChar, 0, "ManufaDate"), New System.Data.SqlClient.SqlParameter("@ExpDate", System.Data.SqlDbType.VarChar, 0, "ExpDate"), New System.Data.SqlClient.SqlParameter("@Qty_in_Stock", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Qty in Stock", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@BrandName", System.Data.SqlDbType.VarChar, 0, "BrandName")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Drug_ID", System.Data.SqlDbType.VarChar, 0, "Drug_ID"), New System.Data.SqlClient.SqlParameter("@DrugName", System.Data.SqlDbType.VarChar, 0, "DrugName"), New System.Data.SqlClient.SqlParameter("@Total_Qty_Ordered", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Total Qty Ordered", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Orderdate", System.Data.SqlDbType.VarChar, 0, "Orderdate"), New System.Data.SqlClient.SqlParameter("@ReceiveDate", System.Data.SqlDbType.VarChar, 0, "ReceiveDate"), New System.Data.SqlClient.SqlParameter("@ManufaDate", System.Data.SqlDbType.VarChar, 0, "ManufaDate"), New System.Data.SqlClient.SqlParameter("@ExpDate", System.Data.SqlDbType.VarChar, 0, "ExpDate"), New System.Data.SqlClient.SqlParameter("@Qty_in_Stock", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Qty in Stock", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@BrandName", System.Data.SqlDbType.VarChar, 0, "BrandName"), New System.Data.SqlClient.SqlParameter("@Original_Drug_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drug_ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DrugName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrugName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total_Qty_Ordered", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Total Qty Ordered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Orderdate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orderdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReceiveDate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReceiveDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ManufaDate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManufaDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ExpDate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExpDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Qty_in_Stock", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Qty in Stock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_BrandName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrandName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Drug_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Drug_ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DrugName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrugName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total_Qty_Ordered", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Total Qty Ordered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Orderdate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orderdate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReceiveDate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReceiveDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ManufaDate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ManufaDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ExpDate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExpDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Qty_in_Stock", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Qty in Stock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_BrandName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BrandName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DAdrug
        '
        Me.DAdrug.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAdrug.InsertCommand = Me.SqlInsertCommand1
        Me.DAdrug.SelectCommand = Me.SqlSelectCommand1
        Me.DAdrug.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Drug", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Drug_ID", "Drug_ID"), New System.Data.Common.DataColumnMapping("DrugName", "DrugName"), New System.Data.Common.DataColumnMapping("Total Qty Ordered", "Total Qty Ordered"), New System.Data.Common.DataColumnMapping("Orderdate", "Orderdate"), New System.Data.Common.DataColumnMapping("ReceiveDate", "ReceiveDate"), New System.Data.Common.DataColumnMapping("ManufaDate", "ManufaDate"), New System.Data.Common.DataColumnMapping("ExpDate", "ExpDate"), New System.Data.Common.DataColumnMapping("Qty in Stock", "Qty in Stock"), New System.Data.Common.DataColumnMapping("BrandName", "BrandName")})})
        Me.DAdrug.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DSdrug1
        '
        Me.DSdrug1.DataSetName = "DSdrug"
        Me.DSdrug1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.TotalQtyOrderedDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.ReceiveDateDataGridViewTextBoxColumn, Me.ManufaDateDataGridViewTextBoxColumn, Me.ExpDateDataGridViewTextBoxColumn, Me.QtyInStockDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Drug"
        Me.DataGridView1.DataSource = Me.DSdrug1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 267)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(944, 254)
        Me.DataGridView1.TabIndex = 32
        '
        'DrugIDDataGridViewTextBoxColumn
        '
        Me.DrugIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.HeaderText = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.Name = "DrugIDDataGridViewTextBoxColumn"
        '
        'DrugNameDataGridViewTextBoxColumn
        '
        Me.DrugNameDataGridViewTextBoxColumn.DataPropertyName = "DrugName"
        Me.DrugNameDataGridViewTextBoxColumn.HeaderText = "DrugName"
        Me.DrugNameDataGridViewTextBoxColumn.Name = "DrugNameDataGridViewTextBoxColumn"
        '
        'TotalQtyOrderedDataGridViewTextBoxColumn
        '
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.DataPropertyName = "Total Qty Ordered"
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.HeaderText = "Total Qty Ordered"
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.Name = "TotalQtyOrderedDataGridViewTextBoxColumn"
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "Orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        '
        'ReceiveDateDataGridViewTextBoxColumn
        '
        Me.ReceiveDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiveDate"
        Me.ReceiveDateDataGridViewTextBoxColumn.HeaderText = "ReceiveDate"
        Me.ReceiveDateDataGridViewTextBoxColumn.Name = "ReceiveDateDataGridViewTextBoxColumn"
        '
        'ManufaDateDataGridViewTextBoxColumn
        '
        Me.ManufaDateDataGridViewTextBoxColumn.DataPropertyName = "ManufaDate"
        Me.ManufaDateDataGridViewTextBoxColumn.HeaderText = "ManufaDate"
        Me.ManufaDateDataGridViewTextBoxColumn.Name = "ManufaDateDataGridViewTextBoxColumn"
        '
        'ExpDateDataGridViewTextBoxColumn
        '
        Me.ExpDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate"
        Me.ExpDateDataGridViewTextBoxColumn.HeaderText = "ExpDate"
        Me.ExpDateDataGridViewTextBoxColumn.Name = "ExpDateDataGridViewTextBoxColumn"
        '
        'QtyInStockDataGridViewTextBoxColumn
        '
        Me.QtyInStockDataGridViewTextBoxColumn.DataPropertyName = "Qty in Stock"
        Me.QtyInStockDataGridViewTextBoxColumn.HeaderText = "Qty in Stock"
        Me.QtyInStockDataGridViewTextBoxColumn.Name = "QtyInStockDataGridViewTextBoxColumn"
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Olive
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(452, 573)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 31)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(841, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Info
        Me.btnBack.Image = Global.Main.My.Resources.Resources.back
        Me.btnBack.Location = New System.Drawing.Point(763, 569)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(57, 57)
        Me.btnBack.TabIndex = 35
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'formAdd_Drug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(979, 650)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtOrderdate)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtEdate)
        Me.Controls.Add(Me.txtMdate)
        Me.Controls.Add(Me.txtDrugid)
        Me.Controls.Add(Me.txtDrugname)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtQtyinStock)
        Me.Controls.Add(Me.txtQtyoreder)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formAdd_Drug"
        Me.Text = "Add Drug"
        CType(Me.DSdrug1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQtyoreder As System.Windows.Forms.TextBox
    Friend WithEvents txtQtyinStock As System.Windows.Forms.TextBox
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtDrugname As System.Windows.Forms.TextBox
    Friend WithEvents txtDrugid As System.Windows.Forms.TextBox
    Friend WithEvents txtMdate As System.Windows.Forms.TextBox
    Friend WithEvents txtEdate As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtReceive As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderdate As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAdrug As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DSdrug1 As Main.DSdrug
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalQtyOrderedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiveDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufaDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
