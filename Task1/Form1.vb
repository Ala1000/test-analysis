Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Word

Public Class Form1

    Private filereader As StreamReader
    Private input As FileStream
    Private dectionary As New Dictionary(Of String, Integer)
    Private asc As Boolean = False
    Dim text As String
    Dim filename As String
    Dim line_count As Integer
    Dim wdCount As Integer
    Dim char_count As Integer
    Dim count_two_vowels = 0

    Private Sub open_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_btn.Click

        Dim result As DialogResult
        


        Using fileChooser As New OpenFileDialog()
            result = fileChooser.ShowDialog()
            filename = fileChooser.FileName
        End Using

        If result <> DialogResult.Cancel And filename <> String.Empty Then
            disp_clk.Enabled = True
            statistics_clk.Enabled = True
            view_txt.Clear()
            statistics.Items.Clear()
            view_txt.Text = String.Empty
            last_lines.Enabled = True


            input = New FileStream(filename, FileMode.Open, FileAccess.Read)
            filereader = New StreamReader(input)

            
            Dim expression As New Regex("\b\w*[aeiou][aeiou]\w*\b")

            text = File.ReadAllText(filename)
            char_count = text.Length
            wdCount = Regex.Matches(text, "\S+").Count
            line_count = text.Split(vbCrLf).Length
            view_txt.Text = text

            Try
                Dim currentPos = 0

                For Each regexMatches In expression.Matches(text)
                    Dim res = regexMatches.ToString()
                    If dectionary.ContainsKey(res) Then
                        dectionary(res) += 1
                    Else
                        dectionary.Add(res, 1)
                    End If
                    Dim start = view_txt.Text.IndexOf(res, currentPos)
                    currentPos = start
                    view_txt.Select(start, res.Length)
                    view_txt.SelectionColor = Color.Green
                    view_txt.Select(view_txt.TextLength, 0)
                    view_txt.SelectionColor = view_txt.ForeColor
                    count_two_vowels += 1
                Next
                
            Catch ex As ArgumentOutOfRangeException
                MessageBox.Show("Limit of text length was exceeded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                filereader.Close()
            End Try
        End If
    End Sub

    Private Sub statistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statistics_clk.Click
        If filename <> String.Empty And view_txt.Text <> String.Empty Then
            DisplayStatistics()
        End If
    End Sub

    Private Sub DisplayStatistics()
        statistics.Items.Add("Found in this text:")
        statistics.Items.Add(" ")
        statistics.Items.Add("Number of lines: " & line_count & vbCrLf)
        statistics.Items.Add("Number of words: " & wdCount & vbCrLf)
        statistics.Items.Add("Number of charachters: " & char_count & vbCrLf)
        statistics.Items.Add("Number of words with 2 vowels: " & count_two_vowels & vbCrLf)
        statistics.Items.Add(" ")
        statistics.Items.Add(" ")
        statistics.Items.Add("************ ")
        statistics.Items.Add("The occcurances for each word with  2 vowels: ")
        statistics.Items.Add("Word" & vbTab & vbTab & "occurances")
        For Each item In dectionary.Keys
            If item.Length < 10 Then
                statistics.Items.Add(item & vbTab & vbTab & dectionary(item))
            Else
                statistics.Items.Add(item & vbTab & dectionary(item))
            End If

        Next

    End Sub


    Private Sub disp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disp_clk.Click
        last.Text = String.Empty
        DisplayLastLines()
    End Sub


    Sub DisplayLastLines()
        Try
            If filename <> String.Empty Then
                Dim num_of_lines As Integer = Convert.ToInt32(last_lines.Text)
                Dim lines_read As String() = IO.File.ReadAllLines(filename)
                If num_of_lines > 0 AndAlso num_of_lines <= lines_read.Length Then

                    If Asce.Checked Then
                        For i = num_of_lines To 1 Step -1
                            last.Text &= lines_read(lines_read.Length - i) & vbCrLf
                        Next
                    End If

                    If dec.Checked Then
                        For i = 1 To num_of_lines
                            last.Text &= lines_read(lines_read.Length - i) & vbCrLf
                        Next
                    End If

                    last.ScrollBars = ScrollBars.Vertical
                Else
                    MessageBox.Show("Please enter a number between 0 and the num of lines in text", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If


        Catch ex As FormatException
            MessageBox.Show("Please enter a number between 0 and the num of lines in text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex2 As InvalidCastException
            MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_clk.Enabled = False
        statistics_clk.Enabled = False
        last_lines.Enabled = False
    End Sub
End Class
