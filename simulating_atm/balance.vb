Imports System.Speech.Synthesis
Imports System.Data.OleDb

Public Class balance
    Dim speaker As New SpeechSynthesizer()
    Private Sub balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        btndisplay.Text += Btn0.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn0.Text)
    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        btndisplay.Text += Btn1.Text
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(Btn1.Text)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
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
    Private Function NewConnection() As OleDb.OleDbConnection
        Dim ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\atm.mdb"
        Dim conn As New OleDb.OleDbConnection(ConnectionString)
        Return conn
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync(btndisplay.Text & "Rupees")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click

    End Sub
End Class