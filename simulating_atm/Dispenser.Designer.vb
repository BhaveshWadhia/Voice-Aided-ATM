<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispenser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispenser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtvol = New System.Windows.Forms.NumericUpDown()
        Me.txtspeed = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.take_money = New System.Windows.Forms.Label()
        Me.wait = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dis = New System.Windows.Forms.Label()
        Me.btnwithdraw = New System.Windows.Forms.Button()
        Me.btnchk = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pixmoney = New System.Windows.Forms.PictureBox()
        Me.pixloading = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixmoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixloading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.txtspeed)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 82)
        Me.GroupBox1.TabIndex = 102
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
        Me.take_money.Location = New System.Drawing.Point(85, 412)
        Me.take_money.Name = "take_money"
        Me.take_money.Size = New System.Drawing.Size(89, 13)
        Me.take_money.TabIndex = 101
        Me.take_money.Text = "Take your money"
        '
        'wait
        '
        Me.wait.AutoSize = True
        Me.wait.Location = New System.Drawing.Point(59, 380)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(61, 13)
        Me.wait.TabIndex = 100
        Me.wait.Text = "Please wait"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'dis
        '
        Me.dis.AutoSize = True
        Me.dis.Location = New System.Drawing.Point(12, 111)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(39, 13)
        Me.dis.TabIndex = 97
        Me.dis.Text = "Label4"
        Me.dis.Visible = False
        '
        'btnwithdraw
        '
        Me.btnwithdraw.Location = New System.Drawing.Point(308, 305)
        Me.btnwithdraw.Name = "btnwithdraw"
        Me.btnwithdraw.Size = New System.Drawing.Size(101, 41)
        Me.btnwithdraw.TabIndex = 96
        Me.btnwithdraw.Text = "&Withdrawal"
        Me.btnwithdraw.UseVisualStyleBackColor = True
        '
        'btnchk
        '
        Me.btnchk.Location = New System.Drawing.Point(303, 170)
        Me.btnchk.Name = "btnchk"
        Me.btnchk.Size = New System.Drawing.Size(106, 41)
        Me.btnchk.TabIndex = 95
        Me.btnchk.Text = "&Check Balance"
        Me.btnchk.UseVisualStyleBackColor = True
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(122, 91)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(180, 54)
        Me.btndisplay.TabIndex = 94
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Image = Global.simulating_atm.My.Resources.Resources.close
        Me.button1.Location = New System.Drawing.Point(237, 268)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(65, 80)
        Me.button1.TabIndex = 92
        Me.button1.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(18, 256)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(48, 36)
        Me.Btn3.TabIndex = 91
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(180, 170)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(48, 80)
        Me.Button12.TabIndex = 90
        Me.Button12.Text = "E&nter"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(237, 170)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(65, 80)
        Me.Button15.TabIndex = 89
        Me.Button15.Text = "&Read balance"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Location = New System.Drawing.Point(126, 170)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(48, 36)
        Me.Btn7.TabIndex = 88
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Location = New System.Drawing.Point(18, 170)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(48, 36)
        Me.Btn9.TabIndex = 87
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(18, 214)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(48, 36)
        Me.Btn6.TabIndex = 86
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(72, 214)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(48, 36)
        Me.Btn5.TabIndex = 85
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(72, 256)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(48, 36)
        Me.Btn2.TabIndex = 84
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(126, 256)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(48, 36)
        Me.Btn1.TabIndex = 83
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Location = New System.Drawing.Point(72, 170)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(48, 36)
        Me.Btn8.TabIndex = 82
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Location = New System.Drawing.Point(180, 256)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(48, 36)
        Me.Btn0.TabIndex = 81
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(126, 214)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(48, 36)
        Me.Btn4.TabIndex = 80
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(18, 310)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(210, 36)
        Me.Btnclear.TabIndex = 79
        Me.Btnclear.Text = "&Backspace"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(303, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Rupees"
        '
        'pixmoney
        '
        Me.pixmoney.Image = Global.simulating_atm.My.Resources.Resources.bth_naira
        Me.pixmoney.Location = New System.Drawing.Point(180, 352)
        Me.pixmoney.Name = "pixmoney"
        Me.pixmoney.Size = New System.Drawing.Size(131, 96)
        Me.pixmoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixmoney.TabIndex = 99
        Me.pixmoney.TabStop = False
        '
        'pixloading
        '
        Me.pixloading.Image = Global.simulating_atm.My.Resources.Resources.loading
        Me.pixloading.Location = New System.Drawing.Point(122, 365)
        Me.pixloading.Name = "pixloading"
        Me.pixloading.Size = New System.Drawing.Size(52, 42)
        Me.pixloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixloading.TabIndex = 98
        Me.pixloading.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.simulating_atm.My.Resources.Resources.atm5
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Dispenser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.simulating_atm.My.Resources.Resources.mglass
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(449, 447)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.take_money)
        Me.Controls.Add(Me.wait)
        Me.Controls.Add(Me.pixmoney)
        Me.Controls.Add(Me.pixloading)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.btnwithdraw)
        Me.Controls.Add(Me.btnchk)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btnclear)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dispenser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispenser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixmoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixloading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtvol As System.Windows.Forms.NumericUpDown
    Private WithEvents txtspeed As System.Windows.Forms.NumericUpDown
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents take_money As System.Windows.Forms.Label
    Friend WithEvents wait As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pixmoney As System.Windows.Forms.PictureBox
    Friend WithEvents pixloading As System.Windows.Forms.PictureBox
    Friend WithEvents dis As System.Windows.Forms.Label
    Friend WithEvents btnwithdraw As System.Windows.Forms.Button
    Friend WithEvents btnchk As System.Windows.Forms.Button
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents Btn0 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
