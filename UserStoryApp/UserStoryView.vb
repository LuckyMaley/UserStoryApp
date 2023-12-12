Public Class UserStoryView
    Private Sub UserStoryTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserStoryTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserStoryTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User_Story_ApplicationDataSet1)

    End Sub

    Private Sub UserStoryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.UserStory_MemberTable' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet1.UserStory_MemberTable)
        'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.TestCasesTable' table. You can move, or remove it, as needed.
        Me.TestCasesTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet1.TestCasesTable)

    End Sub

    Private Sub UserStory_MemberTableDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UserStory_MemberTableDataGridView.SelectionChanged
        If UserStory_MemberTableDataGridView.Rows.Count > 0 Then
            MemberTableTableAdapter1.FillBy1(User_Story_ApplicationDataSet1.MemberTable, UserStory_MemberTableDataGridView.Rows(UserStory_MemberTableDataGridView.CurrentRow.Index).Cells(0).Value)
        End If
    End Sub
End Class