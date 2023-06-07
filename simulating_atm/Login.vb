Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class Login
    Dim speaker As New SpeechSynthesizer()
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim conn As OleDbConnection = NewConnection()
            Dim command As New OleDbCommand("SELECT [account_num] FROM [cust_data] WHERE [account_num] = '" & Trim(account_num.Text) & "'  AND  [pin] = '" & Trim(pin.Text) & "'", conn)

            Dim usernameParam As New OleDbParameter("username", Me.account_num.Text)
            Dim passwordParam As New OleDbParameter("password", Me.pin.Text)

            command.Parameters.Add(usernameParam)
            command.Parameters.Add(passwordParam)

            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("You are authenticated", "Login Successful")
                Me.Hide()
                Main_atm.Show()
            Else
                MessageBox.Show("Your Account Number of Pin number is not correct,Try again", "Login error")
                Me.Show()
            End If
            command.Connection.Close()
            welcome.Timer1.Enabled = False
        Catch ex As Exception
        End Try

        'transfer account Number
        Dim accountContents As String
        accountContents = Me.account_num.Text
        Main_atm.dis1.Text = accountContents
    End Sub
    Private Sub account_num_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles account_num.TextChanged
        Try
            Dim conn As OleDbConnection = NewConnection()
            ' create a new command object
            Dim cmd As OleDbCommand = New OleDbCommand(("select fullname FROM cust_data WHERE account_num  ='" & Trim(account_num.Text) & " '"), conn)
            conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                Label3.Text = (sdr(0).ToString())
            End While
            sdr.Close()
            conn = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Function NewConnection() As OleDb.OleDbConnection
        Dim ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\atm.mdb"
        Dim conn As New OleDb.OleDbConnection(ConnectionString)
        Return conn
    End Function
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("Welcome, Login here to Continue")
    End Sub
End Class