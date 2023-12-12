﻿Public Class UserstoryEdit
    Private Sub UserStoryEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.TestCasesTable' table. You can move, or remove it, as needed.
            Me.TestCasesTableTableAdapter1.Fill(Me.User_Story_ApplicationDataSet1.TestCasesTable)
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.UserStoryTable' table. You can move, or remove it, as needed.
            Me.UserStoryTableTableAdapter1.Fill(Me.User_Story_ApplicationDataSet1.UserStoryTable)
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.UserStory_MemberTable' table. You can move, or remove it, as needed.
            Me.UserStory_MemberTableTableAdapter1.Fill(Me.User_Story_ApplicationDataSet1.UserStory_MemberTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'When the user story view form is closed, the view tool strip under User Story on the main form is Enabled
    Private Sub UserStoryView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.EditToolStripMenuItem3.Enabled = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Edits the user story selected row when the save button is pressed
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to save your edit to the User Story?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If Result = DialogResult.Yes Then
                UserStoryTableBindingSource.EndEdit()
                UserStoryTableTableAdapter1.Update(User_Story_ApplicationDataSet1.UserStoryTable)
                MessageBox.Show("UserStory is Edited!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class