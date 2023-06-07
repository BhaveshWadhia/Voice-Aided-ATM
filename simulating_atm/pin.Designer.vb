<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pin))
        Me.button2 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oldpin = New System.Windows.Forms.TextBox()
        Me.newpin = New System.Windows.Forms.TextBox()
        Me.confirmpin = New System.Windows.Forms.TextBox()
        Me.custname = New System.Windows.Forms.TextBox()
        Me.accountnum = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvol = New System.Windows.Forms.NumericUpDown()
        Me.txtspeed = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Image = Global.simulating_atm.My.Resources.Resources.close1
        Me.button2.Location = New System.Drawing.Point(285, 281)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(94, 46)
        Me.button2.TabIndex = 27
        Me.button2.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(27, 125)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(146, 16)
        Me.label5.TabIndex = 26
        Me.label5.Text = "NEW PIN- NUMBER"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(27, 94)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(127, 16)
        Me.label6.TabIndex = 24
        Me.label6.Text = "ENTER OLD  PIN"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.simulating_atm.My.Resources.Resources.correct
        Me.button1.Location = New System.Drawing.Point(82, 281)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(91, 46)
        Me.button1.TabIndex = 16
        Me.button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.simulating_atm.My.Resources.Resources.atm5
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 87)
        Me.Panel1.TabIndex = 28
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(27, 229)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(150, 16)
        Me.label2.TabIndex = 32
        Me.label2.Text = "ACCOUNT NUMBER"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(27, 194)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(176, 16)
        Me.label1.TabIndex = 30
        Me.label1.Text = "CUSTOMER FULLNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "REPORT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "CONFIRM PIN- NUMBER"
        '
        'oldpin
        '
        Me.oldpin.Location = New System.Drawing.Point(214, 94)
        Me.oldpin.Name = "oldpin"
        Me.oldpin.Size = New System.Drawing.Size(192, 20)
        Me.oldpin.TabIndex = 36
        '
        'newpin
        '
        Me.newpin.Location = New System.Drawing.Point(214, 124)
        Me.newpin.MaxLength = 4
        Me.newpin.Name = "newpin"
        Me.newpin.Size = New System.Drawing.Size(192, 20)
        Me.newpin.TabIndex = 37
        '
        'confirmpin
        '
        Me.confirmpin.Location = New System.Drawing.Point(214, 156)
        Me.confirmpin.MaxLength = 4
        Me.confirmpin.Name = "confirmpin"
        Me.confirmpin.Size = New System.Drawing.Size(192, 20)
        Me.confirmpin.TabIndex = 38
        '
        'custname
        '
        Me.custname.Location = New System.Drawing.Point(214, 194)
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Size = New System.Drawing.Size(192, 20)
        Me.custname.TabIndex = 39
        '
        'accountnum
        '
        Me.accountnum.Location = New System.Drawing.Point(214, 227)
        Me.accountnum.Name = "accountnum"
        Me.accountnum.ReadOnly = True
        Me.accountnum.Size = New System.Drawing.Size(192, 20)
        Me.accountnum.TabIndex = 40
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.simulating_atm.My.Resources.Resources.btnPrevious
        Me.Button3.Location = New System.Drawing.Point(190, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 46)
        Me.Button3.TabIndex = 41
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.txtspeed)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 54)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atm Voice Setting"
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
        'txtspeed
        '
        Me.txtspeed.Location = New System.Drawing.Point(55, 19)
        Me.txtspeed.Name = "txtspeed"
        Me.txtspeed.Size = New System.Drawing.Size(61, 20)
        Me.txtspeed.TabIndex = 62
        Me.txtspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'pin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 333)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.accountnum)
        Me.Controls.Add(Me.custname)
        Me.Controls.Add(Me.confirmpin)
        Me.Controls.Add(Me.newpin)
        Me.Controls.Add(Me.oldpin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "pin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change PIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents oldpin As System.Windows.Forms.TextBox
    Friend WithEvents newpin As System.Windows.Forms.TextBox
    Friend WithEvents confirmpin As System.Windows.Forms.TextBox
    Friend WithEvents custname As System.Windows.Forms.TextBox
    Friend WithEvents accountnum As System.Windows.Forms.TextBox
    Private WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtvol As System.Windows.Forms.NumericUpDown
    Private WithEvents txtspeed As System.Windows.Forms.NumericUpDown
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
