Imports System.Speech.Synthesis
Public Class Main_atm
    Dim speaker As New SpeechSynthesizer()
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        Withdrawal.dis.Text = accountContents
        Withdrawal.Show()
    End Sub
    Private Sub Main_atm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("Welcome to our Voice aided atm, This project is brought to you by code-projects.org")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pin.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        balance.dis.Text = accountContents
        balance.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        fund_transfer.dis.Text = accountContents

        speaker.Rate = Convert.ToInt32(txtspeed.Value)
        speaker.Volume = Convert.ToInt32(txtvol.Value)
        speaker.SpeakAsync("Your Fund transfer")
        fund_transfer.Show()
    End Sub
End Class