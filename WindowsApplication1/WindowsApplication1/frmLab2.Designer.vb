<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.txtvis = New System.Windows.Forms.TextBox()
        Me.txtvri = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblvis = New System.Windows.Forms.Label()
        Me.lblfri = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblcom = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขาย"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Vistra Gluta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Lime
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Frista Glota"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtvis
        '
        Me.txtvis.Location = New System.Drawing.Point(166, 70)
        Me.txtvis.Multiline = True
        Me.txtvis.Name = "txtvis"
        Me.txtvis.Size = New System.Drawing.Size(146, 33)
        Me.txtvis.TabIndex = 0
        Me.txtvis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvri
        '
        Me.txtvri.Location = New System.Drawing.Point(166, 125)
        Me.txtvri.Multiline = True
        Me.txtvri.Name = "txtvri"
        Me.txtvri.Size = New System.Drawing.Size(146, 33)
        Me.txtvri.TabIndex = 1
        Me.txtvri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Fuchsia
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(336, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 38)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ค่าคอมมิชชั่น"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblvis
        '
        Me.lblvis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblvis.Location = New System.Drawing.Point(338, 70)
        Me.lblvis.Name = "lblvis"
        Me.lblvis.Size = New System.Drawing.Size(128, 33)
        Me.lblvis.TabIndex = 2
        Me.lblvis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfri
        '
        Me.lblfri.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblfri.Location = New System.Drawing.Point(338, 125)
        Me.lblfri.Name = "lblfri"
        Me.lblfri.Size = New System.Drawing.Size(128, 33)
        Me.lblfri.TabIndex = 2
        Me.lblfri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 38)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ยอดขายรวม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Fuchsia
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ค่าคอมมิชชั่นรวม"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbltotal.Location = New System.Drawing.Point(143, 273)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(152, 33)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcom
        '
        Me.lblcom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblcom.Location = New System.Drawing.Point(306, 273)
        Me.lblcom.Name = "lblcom"
        Me.lblcom.Size = New System.Drawing.Size(160, 33)
        Me.lblcom.TabIndex = 2
        Me.lblcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(223, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ปิดโปรแกรม"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 373)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblfri)
        Me.Controls.Add(Me.lblcom)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblvis)
        Me.Controls.Add(Me.txtvri)
        Me.Controls.Add(Me.txtvis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab2"
        Me.Text = "frmLab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtvis As System.Windows.Forms.TextBox
    Friend WithEvents txtvri As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblvis As System.Windows.Forms.Label
    Friend WithEvents lblfri As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblcom As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
