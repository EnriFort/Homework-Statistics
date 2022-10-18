Imports System.Runtime.CompilerServices

Public Class Form1

    Public r As New Random
    Public sum As Integer = 0
    Public count As Integer = 0
    Public C(10) As Integer 'number of categories'

    'when i click button 1 timer starts'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Timer1.Interval = 500
        Me.Timer1.Start()
    End Sub

    'every 1 timer's tick do this:'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        count += 1
        Dim rand As Double = r.NextDouble 'compute next random number'
        sum += rand
        Me.RichTextBox1.AppendText("Current random number: " & rand & Environment.NewLine)
        Me.RichTextBox1.AppendText("Current average: " & sum / count & Environment.NewLine)

        'computing Distribution'
        Dim _step As Double = 0.1
        For i As Integer = 0 To 9
            'grouping'
            If rand >= (i * _step) AndAlso rand < ((i + 1) * _step) Then
                C(i) = C(i) + 1 'counting'
            End If
        Next

        For i As Integer = 0 To 9
            Me.RichTextBox1.AppendText((i * 10) & "-" & (i + 1) * 10 & " | " &
                 "" & C(i) & Environment.NewLine)
        Next

        Me.RichTextBox1.AppendText(Environment.NewLine)
        Me.RichTextBox1.ScrollToCaret()
    End Sub

    'when i click button 2 timer stops'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Timer1.Stop()
    End Sub

    'clear RichTextBox'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Clear()
    End Sub
End Class
