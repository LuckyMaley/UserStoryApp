Public Class MemberEdit

    Private Sub MemberEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet1.UserStory_MemberTable' table. You can move, or remove it, as needed.
            Me.UserStory_MemberTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet1.UserStory_MemberTable)
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet.MemberTable' table. You can move, or remove it, as needed.
            MemberTableTableAdapter1.Fill(User_Story_ApplicationDataSet1.MemberTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MemberTableBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MemberTableBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MemberTableBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MemberTableBindingSource.MoveLast()
    End Sub

    'When the form member edit is closed the edit toolstrip is enabled
    Private Sub MemberEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to save your edit to members?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If Result = DialogResult.Yes Then
                MemberTableBindingSource.EndEdit()
                MemberTableTableAdapter1.Update(User_Story_ApplicationDataSet1.MemberTable)
                MessageBox.Show("Edit Saved!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class