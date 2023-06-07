<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdrawal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdrawal))
        Me.btn_500 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_1000 = New System.Windows.Forms.Button()
        Me.btn_5000 = New System.Windows.Forms.Button()
        Me.btn_20000 = New System.Windows.Forms.Button()
        Me.btn_10000 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dis = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtvol = New System.Windows.Forms.NumericUpDown()
        Me.txtspeed = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.take_money = New System.Windows.Forms.Label()
        Me.wait = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pixmoney = New System.Windows.Forms.PictureBox()
        Me.pixloading = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixmoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_500
        '
        Me.btn_500.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_500.ForeColor = System.Drawing.Color.Blue
        Me.btn_500.Location = New System.Drawing.Point(12, 145)
        Me.btn_500.Name = "btn_500"
        Me.btn_500.Size = New System.Drawing.Size(103, 49)
        Me.btn_500.TabIndex = 0
        Me.btn_500.Text = "500"
        Me.btn_500.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(334, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Others"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_1000
        '
        Me.btn_1000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1000.ForeColor = System.Drawing.Color.Blue
        Me.btn_1000.Location = New System.Drawing.Point(12, 208)
        Me.btn_1000.Name = "btn_1000"
        Me.btn_1000.Size = New System.Drawing.Size(103, 49)
        Me.btn_1000.TabIndex = 5
        Me.btn_1000.Text = "1000"
        Me.btn_1000.UseVisualStyleBackColor = True
        '
        'btn_5000
        '
        Me.btn_5000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5000.ForeColor = System.Drawing.Color.Blue
        Me.btn_5000.Location = New System.Drawing.Point(12, 277)
        Me.btn_5000.Name = "btn_5000"
        Me.btn_5000.Size = New System.Drawing.Size(103, 49)
        Me.btn_5000.TabIndex = 9
        Me.btn_5000.Text = "5000"
        Me.btn_5000.UseVisualStyleBackColor = True
        '
        'btn_20000
        '
        Me.btn_20000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_20000.ForeColor = System.Drawing.Color.Blue
        Me.btn_20000.Location = New System.Drawing.Point(334, 208)
        Me.btn_20000.Name = "btn_20000"
        Me.btn_20000.Size = New System.Drawing.Size(103, 49)
        Me.btn_20000.TabIndex = 13
        Me.btn_20000.Text = "20000"
        Me.btn_20000.UseVisualStyleBackColor = True
        '
        'btn_10000
        '
        Me.btn_10000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_10000.ForeColor = System.Drawing.Color.Blue
        Me.btn_10000.Location = New System.Drawing.Point(334, 145)
        Me.btn_10000.Name = "btn_10000"
        Me.btn_10000.Size = New System.Drawing.Size(103, 49)
        Me.btn_10000.TabIndex = 12
        Me.btn_10000.Text = "10000"
        Me.btn_10000.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(312, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Rupees"
        '
        'dis
        '
        Me.dis.AutoSize = True
        Me.dis.Location = New System.Drawing.Point(21, 110)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(39, 13)
        Me.dis.TabIndex = 105
        Me.dis.Text = "Label4"
        Me.dis.Visible = False
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(131, 94)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(180, 54)
        Me.btndisplay.TabIndex = 104
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.txtspeed)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 82)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atm Voice Setting"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 63
        Me.label1.Text = "SPEED"
        '
        'txtvol
        '
        Me.txtvol.Location = New System.Drawing.Point(55, 51)
        Me.txtvol.Name = "txtvol"
        Me.txtvol.Size = New System.Drawing.Size(61, 20)
        Me.txtvol.TabIndex = 61
        Me.txtvol.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'txtspeed
        '
        Me.txtspeed.Location = New System.Drawing.Point(55, 16)
        Me.txtspeed.Name = "txtspeed"
        Me.txtspeed.Size = New System.Drawing.Size(61, 20)
        Me.txtspeed.TabIndex = 62
        Me.txtspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 53)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 64
        Me.label2.Text = "VOL."
        '
        'take_money
        '
        Me.take_money.AutoSize = True
        Me.take_money.Location = New System.Drawing.Point(85, 396)
        Me.take_money.Name = "take_money"
        Me.take_money.Size = New System.Drawing.Size(89, 13)
        Me.take_money.TabIndex = 112
        Me.take_money.Text = "Take your money"
        '
        'wait
        '
        Me.wait.AutoSize = True
        Me.wait.Location = New System.Drawing.Point(59, 364)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(61, 13)
        Me.wait.TabIndex = 111
        Me.wait.Text = "Please wait"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'pixmoney
        '
        Me.pixmoney.Image = Global.simulating_atm.My.Resources.Resources.bth_naira
        Me.pixmoney.Location = New System.Drawing.Point(180, 336)
        Me.pixmoney.Name = "pixmoney"
        Me.pixmoney.Size = New System.Drawing.Size(131, 96)
        Me.pixmoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixmoney.TabIndex = 110
        Me.pixmoney.TabStop = False
        '
        'pixloading
        '
        Me.pixloading.Image = Global.simulating_atm.My.Resources.Resources.loading
        Me.pixloading.Location = New System.Drawing.Point(122, 349)
        Me.pixloading.Name = "pixloading"
        Me.pixloading.Size = New System.Drawing.Size(52, 42)
        Me.pixloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixloading.TabIndex = 109
        Me.pixloading.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Image = Global.simulating_atm.My.Resources.Resources.correct
        Me.Button1.Location = New System.Drawing.Point(122, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 108
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Image = Global.simulating_atm.My.Resources.Resources.close
        Me.Button5.Location = New System.Drawing.Point(228, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 35)
        Me.Button5.TabIndex = 11
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.simulating_atm.My.Resources.Resources.atm5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-1, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 84)
        Me.Panel1.TabIndex = 8
        '
        'Withdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(445, 444)
        Me.Controls.Add(Me.take_money)
        Me.Controls.Add(Me.wait)
        Me.Controls.Add(Me.pixmoney)
        Me.Controls.Add(Me.pixloading)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btn_20000)
        Me.Controls.Add(Me.btn_10000)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_5000)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_1000)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_500)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Withdrawal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Withdrawal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixmoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_500 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_1000 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_5000 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btn_20000 As System.Windows.Forms.Button
    Friend WithEvents btn_10000 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dis As System.Windows.Forms.Label
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtvol As System.Windows.Forms.NumericUpDown
    Private WithEvents txtspeed As System.Windows.Forms.NumericUpDown
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents take_money As System.Windows.Forms.Label
    Friend WithEvents wait As System.Windows.Forms.Label
    Friend WithEvents pixmoney As System.Windows.Forms.PictureBox
    Friend WithEvents pixloading As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
