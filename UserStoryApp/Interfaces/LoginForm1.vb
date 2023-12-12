Public Class LoginForm1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Check login details are correct or not, if they are then log in
        Dim user As String = UsernameTextBox.Text
        Try
            MemberTableTableAdapter1.FillBy(User_Story_ApplicationDataSet1.MemberTable, UsernameTextBox.Text, Password.Text)
            If User_Story_ApplicationDataSet1.MemberTable.Rows.Count > 0 Then
                MsgBox("Welcome You will now be directed to the system")
                Me.Close()
                With MainForm
                    .MemberControlToolStripMenuItem.Enabled = True
                    .UserStoryToolStripMenuItem.Enabled = True
                    .TestCasesToolStripMenuItem.Enabled = True
                    .ToolStripStatusLabel1.Text = "[Logged in - " & user & "]"
                    .LoginToolStripMenuItem.Enabled = False
                    .LogoutToolStripMenuItem.Enabled = True
                End With
                Me.Close()
            Else
                MsgBox("Invalid User Details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Hides and Hides the password in characters
        If CheckBox1.Checked Then
            Password.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
            MainForm.Close()
        End If
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class