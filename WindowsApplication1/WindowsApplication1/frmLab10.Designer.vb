<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab10
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboindex = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายจากอาร์เรย์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รายการข้อมูล"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(12, 77)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(131, 147)
        Me.lstData.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "รวมยอดขายสินค้า A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "รวมยอดขายสินค้า B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "รวมยอดขายสินค้า C"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ผู้ที่ทำยอดขายสูงสุด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "พนักงานขายคนที่"
        '
        'cboindex
        '
        Me.cboindex.FormattingEnabled = True
        Me.cboindex.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboindex.Location = New System.Drawing.Point(12, 263)
        Me.cboindex.Name = "cboindex"
        Me.cboindex.Size = New System.Drawing.Size(131, 21)
        Me.cboindex.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(149, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "เป็นเงิน"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "ชื่อพนักงานขาย"
        '
        'txtSaleName
        '
        Me.txtSaleName.Location = New System.Drawing.Point(12, 331)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(131, 20)
        Me.txtSaleName.TabIndex = 11
        '
        'txtSaleA
        '
        Me.txtSaleA.Location = New System.Drawing.Point(153, 331)
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(86, 20)
        Me.txtSaleA.TabIndex = 12
        '
        'txtSaleB
        '
        Me.txtSaleB.Location = New System.Drawing.Point(245, 331)
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(86, 20)
        Me.txtSaleB.TabIndex = 13
        '
        'txtSaleC
        '
        Me.txtSaleC.Location = New System.Drawing.Point(337, 331)
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(86, 20)
        Me.txtSaleC.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(169, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ยอดขาย A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(260, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "ยอดขาย B"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "ยอดขาย C"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(374, 357)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 33)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblSumA
        '
        Me.lblSumA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumA.Location = New System.Drawing.Point(285, 77)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.Size = New System.Drawing.Size(138, 20)
        Me.lblSumA.TabIndex = 19
        '
        'lblSumB
        '
        Me.lblSumB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumB.Location = New System.Drawing.Point(285, 124)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.Size = New System.Drawing.Size(138, 20)
        Me.lblSumB.TabIndex = 20
        '
        'lblSumC
        '
        Me.lblSumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumC.Location = New System.Drawing.Point(285, 175)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.Size = New System.Drawing.Size(138, 20)
        Me.lblSumC.TabIndex = 21
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleName.Location = New System.Drawing.Point(285, 226)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(138, 20)
        Me.lblMaxSaleName.TabIndex = 22
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(285, 264)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(138, 20)
        Me.lblMaxSaleAmount.TabIndex = 23
        '
        'frmLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 388)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboindex)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboindex As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSaleName As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleA As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleB As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblSumA As System.Windows.Forms.Label
    Friend WithEvents lblSumB As System.Windows.Forms.Label
    Friend WithEvents lblSumC As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleName As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleAmount As System.Windows.Forms.Label
End Class
