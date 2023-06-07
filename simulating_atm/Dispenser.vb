Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Speech
Imports System.Speech.Synthesis
Imports System.IO
Imports System.Data.OleDb
Public Class Dispenser
    Dim speaker As New SpeechSynthesizer()
    Dim withdraw, balance, newbalance, response As Integer
    Private Function NewConnection() As OleDb.OleDbConnection
        Dim ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\atm.mdb"
        Dim conn As New OleDb.OleDbConnection(ConnectionString)
        Return conn
    End Function
    Private Sub btnchk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchk.Click
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("check your balance")

        Try
            Dim conn As OleDbConnection = NewConnection()
            ' create a new command object
            Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                btndisplay.Text = (sdr(0).ToString())
            End While
            sdr.Close()
            conn = Nothing
        Catch ex As Exception
        End Try
        Label3.Visible = True
    End Sub
    Private Sub Dispenser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        wait.Visible = False
        pixloading.Visible = False
        take_money.Visible = False
        pixmoney.Visible = False
        Timer1.Interval = 4500
        Timer1.Enabled = False
        Label3.Visible = False
    End Sub
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        btndisplay.Text += Btn1.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn1.Text)
    End Sub
    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        btndisplay.Text += Btn2.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn2.Text)
    End Sub
    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        btndisplay.Text += Btn3.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn3.Text)
    End Sub
    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        btndisplay.Text += Btn4.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn4.Text)
    End Sub
    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        btndisplay.Text += Btn5.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn5.Text)
    End Sub
    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        btndisplay.Text += Btn6.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn6.Text)
    End Sub
    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        btndisplay.Text += Btn7.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn7.Text)
    End Sub
    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        btndisplay.Text += Btn8.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn8.Text)
    End Sub
    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        btndisplay.Text += Btn9.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn9.Text)
    End Sub
    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        btndisplay.Text += Btn0.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn0.Text)
    End Sub
    Private Sub btnwithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwithdraw.Click
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
        If balance > withdraw Then
            wait.Visible = True
            pixloading.Visible = True
            Timer1.Enabled = True
        Else
            wait.Visible = False
            pixloading.Visible = False
            Timer1.Enabled = False
            Button15.Visible = False
        End If
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pixmoney.Visible = True
        take_money.Visible = True
        wait.Visible = False
        pixloading.Visible = False
    End Sub
    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        Try
            Dim loc As Integer
            'Get the length of the string
            loc = btndisplay.Text.Length
            'Remove the last character, incrementing by 1
            btndisplay.Text = btndisplay.Text.Remove(loc - 1)
            If btndisplay.Text = "" Then
                speaker.Rate = Convert.ToInt32(txtspeed.Value)
                speaker.Volume = Convert.ToInt32(txtvol.Value)
                speaker.SpeakAsync("screen is empty")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        If balance > withdraw Then
            wait.Visible = True
            pixloading.Visible = True
            Timer1.Enabled = True
        Else
            wait.Visible = False
            pixloading.Visible = False
            Timer1.Enabled = False
        End If
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("Your balance is" & " " & btndisplay.Text & "  " & "Rupees")
    End Sub
End Class