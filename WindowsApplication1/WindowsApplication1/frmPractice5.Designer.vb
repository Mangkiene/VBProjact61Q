<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice5
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ราคาสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "จำนวน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เป็นเงิน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ส่วนลด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ราคาสุธิ"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Silver
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.ForeColor = System.Drawing.Color.Transparent
        Me.lblTotal.Location = New System.Drawing.Point(167, 172)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(152, 25)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(170, 48)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(149, 25)
        Me.txtPrice.TabIndex = 6
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(170, 111)
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(149, 25)
        Me.txtUnit.TabIndex = 7
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.Silver
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.ForeColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Location = New System.Drawing.Point(167, 237)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(152, 25)
        Me.lblDiscount.TabIndex = 8
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.Color.Silver
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.ForeColor = System.Drawing.Color.Transparent
        Me.lblNet.Location = New System.Drawing.Point(167, 305)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(152, 25)
        Me.lblNet.TabIndex = 9
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.Location = New System.Drawing.Point(170, 373)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 55)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmPractice5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 481)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice5"
        Me.Text = """โปรแกรมคำนวณส่วนลด"""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
