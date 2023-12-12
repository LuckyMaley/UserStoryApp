Public Class LoginForm1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MemberTableTableAdapter1.FillBy(User_Story_ApplicationDataSet1.MemberTable, UsernameTextBox.Text, Password.Text)
        If User_Story_ApplicationDataSet1.MemberTable.Rows.Count > 0 Then
            MsgBox("Welcome You will now be directed to the system")
            Me.Close()
            With MainForm
                .MemberControlToolStripMenuItem.Enabled = True
                .UserStoryToolStripMenuItem.Enabled = True
                .TestCasesToolStripMenuItem.Enabled = True
            End With
            Me.Close()
        Else
            MsgBox("Invalid User Details")
        End If
    End Sub
End Class