Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class pin
    Dim response As Integer
    Dim speaker As New SpeechSynthesizer()
    Private Sub oldpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oldpin.TextChanged
        Try
            Dim conn As OleDbConnection = NewConnection()
            ' create a new command object
            Dim cmd As OleDbCommand = New OleDbCommand(("select fullname,account_num FROM cust_data WHERE pin ='" & Trim(oldpin.Text) & " '"), conn)
            conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                custname.Text = (sdr(0).ToString())
                accountnum.Text = (sdr(1).ToString())
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
    Private Sub pin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        newpin.Enabled = False
        confirmpin.Enabled = False
    End Sub
    Private Sub accountnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountnum.TextChanged
        If accountnum.Text <> "" Then
            newpin.Enabled = True
            confirmpin.Enabled = True
        End If
    End Sub
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If newpin.Text <> confirmpin.Text Then
            speaker.Rate = Convert.ToInt32(txtspeed.Value)
            speaker.Volume = Convert.ToInt32(txtvol.Value)
            speaker.SpeakAsync("Your Pin Numbers are not compatible")
            Label3.Text = ("Your Pin Numbers are not compatible")
        ElseIf newpin.Text = confirmpin.Text Then

            Dim DBUpdate As New OleDbCommand
            Dim connection As OleDbConnection = NewConnection()
            DBUpdate.CommandText = "UPDATE [cust_data] SET " & _
                    "[pin] = '" & confirmpin.Text & "'" & _
                    "WHERE account_num = '" & accountnum.Text & "' AND pin = '" & oldpin.Text & "'"

            DBUpdate.Connection = connection
            DBUpdate.Connection.Open()
            response = DBUpdate.ExecuteNonQuery()

            connection.Close()
            connection.Dispose()
        End If
        If (response >= 1) Then
            Label3.Text = "Dear Customer,Your ATM pin has been Successfully Changed"
            speaker.Rate = Convert.ToInt32(txtspeed.Value)
            speaker.Volume = Convert.ToInt32(txtvol.Value)
            speaker.SpeakAsync("Dear Customer,Your ATM pin has been Successfully Changed")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Main_atm.Show()
    End Sub
    Private Sub confirmpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmpin.TextChanged
    End Sub
End Class