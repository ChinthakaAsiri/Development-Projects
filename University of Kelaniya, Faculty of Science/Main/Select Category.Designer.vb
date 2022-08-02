<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSelect_Category
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnAddHospital = New System.Windows.Forms.Button()
        Me.btnAddDrug = New System.Windows.Forms.Button()
        Me.btnDrugAvalability = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time :"
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(73, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(94, 22)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Admin1"
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(73, 48)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(94, 23)
        Me.lblTime.TabIndex = 3
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddHospital
        '
        Me.btnAddHospital.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddHospital.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHospital.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddHospital.Location = New System.Drawing.Point(239, 118)
        Me.btnAddHospital.Name = "btnAddHospital"
        Me.btnAddHospital.Size = New System.Drawing.Size(299, 78)
        Me.btnAddHospital.TabIndex = 4
        Me.btnAddHospital.Text = "Add Hospital"
        Me.btnAddHospital.UseVisualStyleBackColor = False
        '
        'btnAddDrug
        '
        Me.btnAddDrug.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddDrug.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDrug.Location = New System.Drawing.Point(239, 230)
        Me.btnAddDrug.Name = "btnAddDrug"
        Me.btnAddDrug.Size = New System.Drawing.Size(299, 78)
        Me.btnAddDrug.TabIndex = 5
        Me.btnAddDrug.Text = "Add Drug"
        Me.btnAddDrug.UseVisualStyleBackColor = False
        '
        'btnDrugAvalability
        '
        Me.btnDrugAvalability.BackColor = System.Drawing.Color.Tomato
        Me.btnDrugAvalability.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrugAvalability.Location = New System.Drawing.Point(239, 347)
        Me.btnDrugAvalability.Name = "btnDrugAvalability"
        Me.btnDrugAvalability.Size = New System.Drawing.Size(299, 78)
        Me.btnDrugAvalability.TabIndex = 6
        Me.btnDrugAvalability.Text = "Drug Avalability"
        Me.btnDrugAvalability.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(584, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formSelect_Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(730, 524)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDrugAvalability)
        Me.Controls.Add(Me.btnAddDrug)
        Me.Controls.Add(Me.btnAddHospital)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formSelect_Category"
        Me.Text = "Select Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnAddHospital As System.Windows.Forms.Button
    Friend WithEvents btnAddDrug As System.Windows.Forms.Button
    Friend WithEvents btnDrugAvalability As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
