<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fund_transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fund_transfer))
        Me.txtspeed = New System.Windows.Forms.NumericUpDown()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.account_num = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvol = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dis = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Label()
        Me.nnn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtspeed
        '
        Me.txtspeed.Location = New System.Drawing.Point(55, 19)
        Me.txtspeed.Name = "txtspeed"
        Me.txtspeed.Size = New System.Drawing.Size(61, 20)
        Me.txtspeed.TabIndex = 62
        Me.txtspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(237, 186)
        Me.amount.MaxLength = 35535
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(192, 20)
        Me.amount.TabIndex = 115
        '
        'account_num
        '
        Me.account_num.Location = New System.Drawing.Point(237, 146)
        Me.account_num.Name = "account_num"
        Me.account_num.Size = New System.Drawing.Size(192, 20)
        Me.account_num.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "SPEED"
        '
        'txtvol
        '
        Me.txtvol.Location = New System.Drawing.Point(55, 51)
        Me.txtvol.Name = "txtvol"
        Me.txtvol.Size = New System.Drawing.Size(61, 20)
        Me.txtvol.TabIndex = 61
        Me.txtvol.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "REPORT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "VOL."
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(3, 187)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(208, 16)
        Me.label5.TabIndex = 107
        Me.label5.Text = "AMOUNT TO BE TRANSFER"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(3, 146)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(234, 16)
        Me.label6.TabIndex = 106
        Me.label6.Text = "RECIPIENT ACCOUNT NUMBER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.txtspeed)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 54)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atm Voice Setting"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(120, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 18)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "FUND TRANSFER FORM"
        '
        'dis
        '
        Me.dis.AutoSize = True
        Me.dis.Location = New System.Drawing.Point(21, 116)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(39, 13)
        Me.dis.TabIndex = 122
        Me.dis.Text = "Label2"
        Me.dis.Visible = False
        '
        'btndisplay
        '
        Me.btndisplay.AutoSize = True
        Me.btndisplay.Location = New System.Drawing.Point(128, 245)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(28, 13)
        Me.btndisplay.TabIndex = 123
        Me.btndisplay.Text = "-------"
        '
        'nnn
        '
        Me.nnn.AutoSize = True
        Me.nnn.Location = New System.Drawing.Point(388, 292)
        Me.nnn.Name = "nnn"
        Me.nnn.Size = New System.Drawing.Size(39, 13)
        Me.nnn.TabIndex = 124
        Me.nnn.Text = "Label2"
        Me.nnn.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Your New Balance is"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.simulating_atm.My.Resources.Resources.atm5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 96)
        Me.Panel1.TabIndex = 109
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Image = Global.simulating_atm.My.Resources.Resources.close1
        Me.button2.Location = New System.Drawing.Point(277, 275)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(94, 46)
        Me.button2.TabIndex = 108
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.simulating_atm.My.Resources.Resources.correct
        Me.button1.Location = New System.Drawing.Point(131, 275)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(91, 46)
        Me.button1.TabIndex = 105
        Me.button1.UseVisualStyleBackColor = True
        '
        'fund_transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(439, 331)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nnn)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.account_num)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fund_transfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fund_transfer"
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtspeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents account_num As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtvol As System.Windows.Forms.NumericUpDown
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dis As System.Windows.Forms.Label
    Friend WithEvents btndisplay As System.Windows.Forms.Label
    Friend WithEvents nnn As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
