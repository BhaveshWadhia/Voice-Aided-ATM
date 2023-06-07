Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class fund_transfer
    Dim speaker As New SpeechSynthesizer()
    Dim amount_transfer, balance, transfer, newbalance, newtransfer, response As Integer
    Private Sub fund_transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
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

            Dim conn1 As OleDbConnection = NewConnection()
            ' create a new command object
            'get last balance from customer Db
            Dim cmd1 As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(account_num.Text) & " '"), conn1)
            conn1.Open()
            Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader()
            While sdr1.Read = True
                transfer = (sdr1(0).ToString())
            End While
            sdr1.Close()
            conn1 = Nothing

            'CHECK IF THERE IS SUFFICIENT AMOUNT
            amount_transfer = amount.Text
            If balance > amount_transfer And balance > 1000 Then
                'transaction
                newbalance = (balance) - (amount_transfer)
                btndisplay.Text = newbalance
                newtransfer = (amount_transfer) + (transfer)
                nnn.Text = newtransfer

                'update New your Balance
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
                'update recipent Balance
                Dim connn1 As OleDbConnection = NewConnection()
                Dim DBUpdate1 As New OleDbCommand
                DBUpdate1.CommandText = "UPDATE [cust_data] SET " & _
                                "[balance] = '" & nnn.Text & "'" & _
                                "WHERE account_num = '" & account_num.Text & "'"

                DBUpdate1.Connection = connn1
                DBUpdate1.Connection.Open()
                response = DBUpdate1.ExecuteNonQuery()

                connn1.Close()
                connn1.Dispose()
            Else : MsgBox("Dear customer you have insufficient Balance OR balance is less than N1000 ")
            End If

        Catch ex As Exception
        End Try
        If (response >= 1) Then
            Label3.Text = "Dear Customer,Your Fund transfer was Successfully"
            speaker.Rate = Convert.ToInt32(txtspeed.Value)
            speaker.Volume = Convert.ToInt32(txtvol.Value)
            speaker.SpeakAsync("Dear Customer,Your Fund transfer was Successfully")
        End If
    End Sub
    Private Function NewConnection() As OleDb.OleDbConnection
        Dim ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\atm.mdb"
        Dim conn As New OleDb.OleDbConnection(ConnectionString)
        Return conn
    End Function
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()
    End Sub
    Private Sub account_num_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles account_num.TextChanged
        Dim s As String
        s = account_num.Text.Substring(Len(account_num.Text) - 1, 1)
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(s)
    End Sub
    Private Sub amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amount.TextChanged
        Dim ls As String
        ls = amount.Text.Substring(Len(amount.Text) - 1, 1)
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(ls)
    End Sub
End Class