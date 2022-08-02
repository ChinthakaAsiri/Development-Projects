<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDrug_Avalability
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDrug_Avalability))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HospitalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HospitalNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyInHospitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtySentToHospitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimumRequirmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalQtyOrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsageOfTheDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMinReq12 = New Main.DsMinReq12()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtStockSend = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMedName = New System.Windows.Forms.Label()
        Me.lblMedID = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.lblHos_ID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQtyInHos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblQtyInStock = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMinReq12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Time :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(68, 45)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(94, 23)
        Me.lblTime.TabIndex = 10
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(68, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(94, 22)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "Admin1"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Colombo", "Gampaha", "Kaluthara", "Rathnapura", "Gall", "Mathara", "Hambanthota", "Monaragala", "Ampara", "Anuradhapuraya", "Badulla" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboBox1.Location = New System.Drawing.Point(407, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Select District"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Alert List"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(34, 376)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 15
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugIDDataGridViewTextBoxColumn, Me.HospitalIDDataGridViewTextBoxColumn, Me.HospitalNameDataGridViewTextBoxColumn, Me.QtyInHospitalDataGridViewTextBoxColumn, Me.QtySentToHospitalDataGridViewTextBoxColumn, Me.MinimumRequirmentDataGridViewTextBoxColumn, Me.QtyInStockDataGridViewTextBoxColumn, Me.TotalQtyOrderedDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.UsageOfTheDayDataGridViewTextBoxColumn, Me.DistrictDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Drug"
        Me.DataGridView1.DataSource = Me.DsMinReq12
        Me.DataGridView1.Location = New System.Drawing.Point(27, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(891, 294)
        Me.DataGridView1.TabIndex = 17
        '
        'DrugIDDataGridViewTextBoxColumn
        '
        Me.DrugIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.HeaderText = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.Name = "DrugIDDataGridViewTextBoxColumn"
        Me.DrugIDDataGridViewTextBoxColumn.Width = 70
        '
        'HospitalIDDataGridViewTextBoxColumn
        '
        Me.HospitalIDDataGridViewTextBoxColumn.DataPropertyName = "Hospital_ID"
        Me.HospitalIDDataGridViewTextBoxColumn.HeaderText = "Hospital_ID"
        Me.HospitalIDDataGridViewTextBoxColumn.Name = "HospitalIDDataGridViewTextBoxColumn"
        Me.HospitalIDDataGridViewTextBoxColumn.Width = 70
        '
        'HospitalNameDataGridViewTextBoxColumn
        '
        Me.HospitalNameDataGridViewTextBoxColumn.DataPropertyName = "Hospital_Name"
        Me.HospitalNameDataGridViewTextBoxColumn.HeaderText = "Hospital_Name"
        Me.HospitalNameDataGridViewTextBoxColumn.Name = "HospitalNameDataGridViewTextBoxColumn"
        Me.HospitalNameDataGridViewTextBoxColumn.Width = 200
        '
        'QtyInHospitalDataGridViewTextBoxColumn
        '
        Me.QtyInHospitalDataGridViewTextBoxColumn.DataPropertyName = "Qty in Hospital"
        Me.QtyInHospitalDataGridViewTextBoxColumn.HeaderText = "Qty in Hospital"
        Me.QtyInHospitalDataGridViewTextBoxColumn.Name = "QtyInHospitalDataGridViewTextBoxColumn"
        Me.QtyInHospitalDataGridViewTextBoxColumn.Width = 70
        '
        'QtySentToHospitalDataGridViewTextBoxColumn
        '
        Me.QtySentToHospitalDataGridViewTextBoxColumn.DataPropertyName = "Qty sent to hospital"
        Me.QtySentToHospitalDataGridViewTextBoxColumn.HeaderText = "Qty sent to hospital"
        Me.QtySentToHospitalDataGridViewTextBoxColumn.Name = "QtySentToHospitalDataGridViewTextBoxColumn"
        Me.QtySentToHospitalDataGridViewTextBoxColumn.Width = 70
        '
        'MinimumRequirmentDataGridViewTextBoxColumn
        '
        Me.MinimumRequirmentDataGridViewTextBoxColumn.DataPropertyName = "Minimum Requirment"
        Me.MinimumRequirmentDataGridViewTextBoxColumn.HeaderText = "Minimum Requirment"
        Me.MinimumRequirmentDataGridViewTextBoxColumn.Name = "MinimumRequirmentDataGridViewTextBoxColumn"
        Me.MinimumRequirmentDataGridViewTextBoxColumn.Width = 70
        '
        'QtyInStockDataGridViewTextBoxColumn
        '
        Me.QtyInStockDataGridViewTextBoxColumn.DataPropertyName = "Qty in Stock"
        Me.QtyInStockDataGridViewTextBoxColumn.HeaderText = "Qty in Stock"
        Me.QtyInStockDataGridViewTextBoxColumn.Name = "QtyInStockDataGridViewTextBoxColumn"
        Me.QtyInStockDataGridViewTextBoxColumn.Width = 70
        '
        'TotalQtyOrderedDataGridViewTextBoxColumn
        '
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.DataPropertyName = "Total Qty Ordered"
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.HeaderText = "Total Qty Ordered"
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.Name = "TotalQtyOrderedDataGridViewTextBoxColumn"
        Me.TotalQtyOrderedDataGridViewTextBoxColumn.Width = 70
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 80
        '
        'UsageOfTheDayDataGridViewTextBoxColumn
        '
        Me.UsageOfTheDayDataGridViewTextBoxColumn.DataPropertyName = "Usage of the Day"
        Me.UsageOfTheDayDataGridViewTextBoxColumn.HeaderText = "Usage of the Day"
        Me.UsageOfTheDayDataGridViewTextBoxColumn.Name = "UsageOfTheDayDataGridViewTextBoxColumn"
        Me.UsageOfTheDayDataGridViewTextBoxColumn.Width = 70
        '
        'DistrictDataGridViewTextBoxColumn
        '
        Me.DistrictDataGridViewTextBoxColumn.DataPropertyName = "District"
        Me.DistrictDataGridViewTextBoxColumn.HeaderText = "District"
        Me.DistrictDataGridViewTextBoxColumn.Name = "DistrictDataGridViewTextBoxColumn"
        Me.DistrictDataGridViewTextBoxColumn.Width = 75
        '
        'DsMinReq12
        '
        Me.DsMinReq12.DataSetName = "DsMinReq12"
        Me.DsMinReq12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSend.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSend.Location = New System.Drawing.Point(341, 519)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 31)
        Me.btnSend.TabIndex = 31
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtStockSend
        '
        Me.txtStockSend.Location = New System.Drawing.Point(172, 521)
        Me.txtStockSend.Name = "txtStockSend"
        Me.txtStockSend.Size = New System.Drawing.Size(135, 20)
        Me.txtStockSend.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 528)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Stock to Send"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Hospital Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Drug ID"
        '
        'lblMedName
        '
        Me.lblMedName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMedName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedName.Location = New System.Drawing.Point(302, 466)
        Me.lblMedName.Name = "lblMedName"
        Me.lblMedName.Size = New System.Drawing.Size(324, 22)
        Me.lblMedName.TabIndex = 26
        Me.lblMedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMedID
        '
        Me.lblMedID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMedID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedID.Location = New System.Drawing.Point(27, 467)
        Me.lblMedID.Name = "lblMedID"
        Me.lblMedID.Size = New System.Drawing.Size(96, 23)
        Me.lblMedID.TabIndex = 25
        Me.lblMedID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=Drug_Management_System;Integrated Security=Tr" & _
            "ue"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Drug", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Qty in Stock", "Qty in Stock"), New System.Data.Common.DataColumnMapping("Total Qty Ordered", "Total Qty Ordered"), New System.Data.Common.DataColumnMapping("Hospital_Name", "Hospital_Name"), New System.Data.Common.DataColumnMapping("District", "District"), New System.Data.Common.DataColumnMapping("Drug_ID", "Drug_ID"), New System.Data.Common.DataColumnMapping("Hospital_ID", "Hospital_ID"), New System.Data.Common.DataColumnMapping("Qty sent to hospital", "Qty sent to hospital"), New System.Data.Common.DataColumnMapping("Qty in Hospital", "Qty in Hospital"), New System.Data.Common.DataColumnMapping("Minimum Requirment", "Minimum Requirment"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("Usage of the Day", "Usage of the Day")})})
        '
        'lblHos_ID
        '
        Me.lblHos_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHos_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHos_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHos_ID.Location = New System.Drawing.Point(158, 466)
        Me.lblHos_ID.Name = "lblHos_ID"
        Me.lblHos_ID.Size = New System.Drawing.Size(108, 22)
        Me.lblHos_ID.TabIndex = 32
        Me.lblHos_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Hospital ID"
        '
        'lblQtyInHos
        '
        Me.lblQtyInHos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQtyInHos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQtyInHos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyInHos.Location = New System.Drawing.Point(669, 467)
        Me.lblQtyInHos.Name = "lblQtyInHos"
        Me.lblQtyInHos.Size = New System.Drawing.Size(110, 22)
        Me.lblQtyInHos.TabIndex = 35
        Me.lblQtyInHos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(666, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Qty in Hospital"
        '
        'lblQtyInStock
        '
        Me.lblQtyInStock.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQtyInStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQtyInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyInStock.Location = New System.Drawing.Point(808, 468)
        Me.lblQtyInStock.Name = "lblQtyInStock"
        Me.lblQtyInStock.Size = New System.Drawing.Size(110, 22)
        Me.lblQtyInStock.TabIndex = 37
        Me.lblQtyInStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(815, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Qty in Stock"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(818, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Info
        Me.btnBack.Image = Global.Main.My.Resources.Resources.back
        Me.btnBack.Location = New System.Drawing.Point(745, 510)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(57, 57)
        Me.btnBack.TabIndex = 40
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'formDrug_Avalability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(940, 579)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblQtyInStock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblQtyInHos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblHos_ID)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtStockSend)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblMedName)
        Me.Controls.Add(Me.lblMedID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formDrug_Avalability"
        Me.Text = "Drug Avalability"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMinReq12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtStockSend As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMedName As System.Windows.Forms.Label
    Friend WithEvents lblMedID As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents lblHos_ID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblQtyInHos As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DsMinReq12 As Main.DsMinReq12
    Friend WithEvents lblQtyInStock As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HospitalIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HospitalNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyInHospitalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtySentToHospitalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinimumRequirmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalQtyOrderedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsageOfTheDayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistrictDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
