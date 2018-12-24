<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(37, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(37, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ราคาขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(37, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(37, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(37, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(37, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "จำนวนเงินต้องชำระ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(37, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(196, 49)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(183, 20)
        Me.txtProduct.TabIndex = 8
        Me.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(196, 88)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(183, 20)
        Me.txtPrice.TabIndex = 9
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(196, 125)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(183, 20)
        Me.txtUnit.TabIndex = 10
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(196, 164)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(183, 20)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(196, 281)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(183, 20)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaid
        '
        Me.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaid.Location = New System.Drawing.Point(196, 313)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(183, 20)
        Me.lblPaid.TabIndex = 13
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCredit
        '
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCredit.Location = New System.Drawing.Point(196, 347)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(183, 20)
        Me.lblCredit.TabIndex = 14
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radMember)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(41, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 55)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'gpbPaid
        '
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radPaid)
        Me.gpbPaid.ForeColor = System.Drawing.Color.Blue
        Me.gpbPaid.Location = New System.Drawing.Point(225, 203)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(154, 55)
        Me.gpbPaid.TabIndex = 16
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.ForeColor = System.Drawing.Color.Red
        Me.radMember.Location = New System.Drawing.Point(6, 19)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(57, 17)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "สมาชิก"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.ForeColor = System.Drawing.Color.Red
        Me.radOther.Location = New System.Drawing.Point(64, 19)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(76, 17)
        Me.radOther.TabIndex = 1
        Me.radOther.TabStop = True
        Me.radOther.Text = "ลูกค้าทั่วไป"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.ForeColor = System.Drawing.Color.Red
        Me.radPaid.Location = New System.Drawing.Point(6, 19)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(56, 17)
        Me.radPaid.TabIndex = 2
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "เงินสด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.ForeColor = System.Drawing.Color.Red
        Me.radCredit.Location = New System.Drawing.Point(82, 19)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(61, 17)
        Me.radCredit.TabIndex = 3
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เงินเชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(196, 377)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(183, 39)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 428)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab5"
        Me.Text = "frmLab5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radMember As System.Windows.Forms.RadioButton
    Friend WithEvents gpbPaid As System.Windows.Forms.GroupBox
    Friend WithEvents radCredit As System.Windows.Forms.RadioButton
    Friend WithEvents radPaid As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
