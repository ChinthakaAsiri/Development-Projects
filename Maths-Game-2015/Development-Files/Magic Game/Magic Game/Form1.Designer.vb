<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProceed = New System.Windows.Forms.Label()
        Me.lblClickNext = New System.Windows.Forms.Label()
        Me.lblNext1 = New System.Windows.Forms.Label()
        Me.lblNext2 = New System.Windows.Forms.Label()
        Me.lblNext3 = New System.Windows.Forms.Label()
        Me.lblNext4 = New System.Windows.Forms.Label()
        Me.lblNext5 = New System.Windows.Forms.Label()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnNext3 = New System.Windows.Forms.Button()
        Me.btnNext4 = New System.Windows.Forms.Button()
        Me.lblOk1 = New System.Windows.Forms.Label()
        Me.lblOk2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Majic_Game.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(458, 52)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nadejda", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Math Magic"
        '
        'btnProceed
        '
        Me.btnProceed.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.Location = New System.Drawing.Point(248, 127)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(98, 35)
        Me.btnProceed.TabIndex = 2
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'btnNext1
        '
        Me.btnNext1.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext1.Location = New System.Drawing.Point(458, 283)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(98, 35)
        Me.btnNext1.TabIndex = 3
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = True
        Me.btnNext1.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(235, 340)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(98, 35)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        Me.btnOk.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(458, 435)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 35)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'lblProceed
        '
        Me.lblProceed.AutoSize = True
        Me.lblProceed.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceed.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblProceed.Location = New System.Drawing.Point(67, 181)
        Me.lblProceed.Name = "lblProceed"
        Me.lblProceed.Size = New System.Drawing.Size(469, 23)
        Me.lblProceed.TabIndex = 6
        Me.lblProceed.Text = "Think of any integer number (Example: -4, -1, 0, 5, 41 )"
        Me.lblProceed.Visible = False
        '
        'lblClickNext
        '
        Me.lblClickNext.AutoSize = True
        Me.lblClickNext.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickNext.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblClickNext.Location = New System.Drawing.Point(231, 204)
        Me.lblClickNext.Name = "lblClickNext"
        Me.lblClickNext.Size = New System.Drawing.Size(258, 23)
        Me.lblClickNext.TabIndex = 7
        Me.lblClickNext.Text = "Click Next and Follow the steps"
        Me.lblClickNext.Visible = False
        '
        'lblNext1
        '
        Me.lblNext1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext1.Location = New System.Drawing.Point(67, 272)
        Me.lblNext1.Name = "lblNext1"
        Me.lblNext1.Size = New System.Drawing.Size(347, 46)
        Me.lblNext1.TabIndex = 8
        Me.lblNext1.Text = "Multiply your imaginary number by 2 (Exampal :  8 x 2 = 16)"
        Me.lblNext1.Visible = False
        '
        'lblNext2
        '
        Me.lblNext2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext2.Location = New System.Drawing.Point(67, 272)
        Me.lblNext2.Name = "lblNext2"
        Me.lblNext2.Size = New System.Drawing.Size(347, 46)
        Me.lblNext2.TabIndex = 9
        Me.lblNext2.Text = "Add 80 (Example :  5 + 80)"
        Me.lblNext2.Visible = False
        '
        'lblNext3
        '
        Me.lblNext3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext3.Location = New System.Drawing.Point(67, 272)
        Me.lblNext3.Name = "lblNext3"
        Me.lblNext3.Size = New System.Drawing.Size(347, 46)
        Me.lblNext3.TabIndex = 10
        Me.lblNext3.Text = "Divide answer by 2"
        Me.lblNext3.Visible = False
        '
        'lblNext4
        '
        Me.lblNext4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext4.Location = New System.Drawing.Point(67, 272)
        Me.lblNext4.Name = "lblNext4"
        Me.lblNext4.Size = New System.Drawing.Size(347, 46)
        Me.lblNext4.TabIndex = 11
        Me.lblNext4.Text = "Subtract by 25"
        Me.lblNext4.Visible = False
        '
        'lblNext5
        '
        Me.lblNext5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNext5.Location = New System.Drawing.Point(67, 272)
        Me.lblNext5.Name = "lblNext5"
        Me.lblNext5.Size = New System.Drawing.Size(347, 46)
        Me.lblNext5.TabIndex = 12
        Me.lblNext5.Text = "Mention Your answer bellow "
        Me.lblNext5.Visible = False
        '
        'txtAns
        '
        Me.txtAns.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns.Location = New System.Drawing.Point(120, 337)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(86, 37)
        Me.txtAns.TabIndex = 13
        Me.txtAns.Visible = False
        '
        'btnNext2
        '
        Me.btnNext2.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext2.Location = New System.Drawing.Point(458, 283)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(98, 35)
        Me.btnNext2.TabIndex = 14
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        Me.btnNext2.Visible = False
        '
        'btnNext3
        '
        Me.btnNext3.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext3.Location = New System.Drawing.Point(458, 283)
        Me.btnNext3.Name = "btnNext3"
        Me.btnNext3.Size = New System.Drawing.Size(98, 35)
        Me.btnNext3.TabIndex = 15
        Me.btnNext3.Text = "Next"
        Me.btnNext3.UseVisualStyleBackColor = True
        Me.btnNext3.Visible = False
        '
        'btnNext4
        '
        Me.btnNext4.Font = New System.Drawing.Font("Calligraph421 BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext4.Location = New System.Drawing.Point(458, 283)
        Me.btnNext4.Name = "btnNext4"
        Me.btnNext4.Size = New System.Drawing.Size(98, 35)
        Me.btnNext4.TabIndex = 16
        Me.btnNext4.Text = "Next"
        Me.btnNext4.UseVisualStyleBackColor = True
        Me.btnNext4.Visible = False
        '
        'lblOk1
        '
        Me.lblOk1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOk1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblOk1.Location = New System.Drawing.Point(56, 398)
        Me.lblOk1.Name = "lblOk1"
        Me.lblOk1.Size = New System.Drawing.Size(241, 46)
        Me.lblOk1.TabIndex = 17
        Me.lblOk1.Text = "Your imaginary number was :"
        Me.lblOk1.Visible = False
        '
        'lblOk2
        '
        Me.lblOk2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOk2.ForeColor = System.Drawing.Color.Crimson
        Me.lblOk2.Location = New System.Drawing.Point(290, 393)
        Me.lblOk2.Name = "lblOk2"
        Me.lblOk2.Size = New System.Drawing.Size(124, 45)
        Me.lblOk2.TabIndex = 18
        Me.lblOk2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 500)
        Me.Controls.Add(Me.lblOk2)
        Me.Controls.Add(Me.lblOk1)
        Me.Controls.Add(Me.btnNext4)
        Me.Controls.Add(Me.btnNext3)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.lblNext5)
        Me.Controls.Add(Me.lblNext4)
        Me.Controls.Add(Me.lblNext3)
        Me.Controls.Add(Me.lblNext2)
        Me.Controls.Add(Me.lblNext1)
        Me.Controls.Add(Me.lblClickNext)
        Me.Controls.Add(Me.lblProceed)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnNext1)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Nadejda", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents btnNext1 As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblProceed As System.Windows.Forms.Label
    Friend WithEvents lblClickNext As System.Windows.Forms.Label
    Friend WithEvents lblNext1 As System.Windows.Forms.Label
    Friend WithEvents lblNext2 As System.Windows.Forms.Label
    Friend WithEvents lblNext3 As System.Windows.Forms.Label
    Friend WithEvents lblNext4 As System.Windows.Forms.Label
    Friend WithEvents lblNext5 As System.Windows.Forms.Label
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnNext3 As System.Windows.Forms.Button
    Friend WithEvents btnNext4 As System.Windows.Forms.Button
    Friend WithEvents lblOk1 As System.Windows.Forms.Label
    Friend WithEvents lblOk2 As System.Windows.Forms.Label

End Class
