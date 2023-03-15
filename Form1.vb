Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ListBox1.Items.Clear()
        lblAverage.Text = ""
        BtnSpeed.Enabled = True
    End Sub

    Private Sub BtnSpeed_Click(sender As Object, e As EventArgs) Handles BtnSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsg As String = "Enter the number of Mbps of your home Internet speed user #"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - Enter the speed of your home Internet connection"
        Dim strNegErrMsg As String = "Error - Enter a valid speed user #"

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed >= 0 Then
                    ListBox1.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                strIBoxMsg = strNotNumericErrMsg
            End If
            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

            End If
        Loop

        lblAverage.Visible = True
        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAverage.Text = "Average Internet Speed: " &
                decAverage.ToString("F2") & " Mbps "
        Else
            lblAverage.Text = "No Speed Values Entered"
        End If

        BtnSpeed.Enabled = False
    End Sub
End Class
