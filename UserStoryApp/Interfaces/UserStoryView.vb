Public Class UserStoryView

    Private Sub UserStoryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.TestCasesTable' table. You can move, or remove it, as needed.
            Me.TestCasesTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet1.TestCasesTable)
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.UserStoryTable' table. You can move, or remove it, as needed.
            Me.UserStoryTableTableAdapter1.Fill(Me.User_Story_ApplicationDataSet1.UserStoryTable)
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.UserStory_MemberTable' table. You can move, or remove it, as needed.
            Me.UserStory_MemberTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet1.UserStory_MemberTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'When the user story view form is closed, the view tool strip under User Story on the main form is Enabled
    Private Sub UserStoryView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.ViewToolStripMenuItem1.Enabled = True
    End Sub

    'When the user presses a different row the sytstem on the user story grid, the User story member table also updates the rows of group member number and responsibility 
    Private Sub UserStory_MemberTableDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UserStory_MemberTableDataGridView.SelectionChanged
        Try
            If UserStory_MemberTableDataGridView.Rows.Count > 0 Then
                MemberTableTableAdapter1.FillBy1(User_Story_ApplicationDataSet1.MemberTable, UserStory_MemberTableDataGridView.Rows(UserStory_MemberTableDataGridView.CurrentRow.Index).Cells(0).Value)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Fills the user story data grid by the priority (high, medium, low or by all use stories)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = "" Then
                Me.UserStoryTableTableAdapter1.Fill(Me.User_Story_ApplicationDataSet1.UserStoryTable)
            Else
                UserStoryTableTableAdapter1.FillByPriority(User_Story_ApplicationDataSet1.UserStoryTable, ComboBox1.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class