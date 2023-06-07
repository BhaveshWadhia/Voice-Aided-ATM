Imports System.Speech.Synthesis
Imports System.Data.OleDb

Public Class Withdrawal
    Dim speaker As New SpeechSynthesizer()
    Dim withdraw, balance, newbalance, response As Integer
    Private Sub Withdrawal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GroupBox1.Hide()
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        wait.Visible = False
        pixloading.Visible = False
        take_money.Visible = False
        pixmoney.Visible = False
        Timer1.Interval = 4000
        Timer1.Enabled = False
        Label3.Visible = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_500.Click
        btndisplay.Text = btn_500.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(btn_500.Text & "Rupees")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim accountContents As String
        accountContents = Me.dis.Text
        Dispenser.dis.Text = accountContents
        Dispenser.Show()
    End Sub
    Private Sub btn_1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1000.Click
        btndisplay.Text = btn_1000.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(btn_1000.Text & "Rupees")
    End Sub
    Private Sub btn_5000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5000.Click
        btndisplay.Text = btn_5000.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(btn_5000.Text & "Rupees")
    End Sub
    Private Sub btn_10000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_10000.Click
        btndisplay.Text = btn_10000.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(btn_10000.Text & "Rupees")
    End Sub
    Private Sub btn_20000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_20000.Click
        btndisplay.Text = btn_20000.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(btn_20000.Text & "Rupees")
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("withdraw your money")
        Try
            Dim conn As OleDbConnection = NewConnection()
            ' create a new command object
            'get last balance from customer Db
            Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                balance = (sdr(0).ToString())
            End While
            sdr.Close()
            conn = Nothing

            'CHECK IF THERE IS SUFFICIENT AMOUNT
            withdraw = btndisplay.Text
            If balance > withdraw And balance > 1000 Then
                'transaction
                newbalance = (balance) - (withdraw)
                btndisplay.Text = newbalance

                'update New Balance
                Dim connn As OleDbConnection = NewConnection()
                Dim DBUpdate As New OleDbCommand
                DBUpdate.CommandText = "UPDATE [cust_data] SET " & _
                                "[balance] = '" & btndisplay.Text & "'" & _
                                "WHERE account_num = '" & dis.Text & "'"

                DBUpdate.Connection = connn
                DBUpdate.Connection.Open()
                DBUpdate.ExecuteNonQuery()

                connn.Close()
                connn.Dispose()
            Else : MsgBox("Dear customer you have insufficient Balance OR balance is less than N1000 ")
            End If

        Catch ex As Exception
        End Try
        If balance > withdraw And balance > 1000 Then
            wait.Visible = True
            pixloading.Visible = True
            Timer1.Enabled = True
        Else
            wait.Visible = False
            pixloading.Visible = False
            Timer1.Enabled = False
            'Button15.Visible = False
        End If
    End Sub
    Private Function NewConnection() As OleDb.OleDbConnection
        Dim ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\atm.mdb"
        Dim conn As New OleDb.OleDbConnection(ConnectionString)
        Return conn
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pixmoney.Visible = True
        take_money.Visible = True
        wait.Visible = False
        pixloading.Visible = False
    End Sub
End Class