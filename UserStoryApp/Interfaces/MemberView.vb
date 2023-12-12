Public Class MemberView

    Private Sub MemberView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet.MemberTable' table. You can move, or remove it, as needed.
        Try
            MemberTableTableAdapter.Fill(User_Story_ApplicationDataSet.MemberTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MemberTableBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MemberTableBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MemberTableBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MemberTableBindingSource.MoveLast()
    End Sub

    'When the member view form closes the view toolstrip is enabled under member control 
    Private Sub MemberView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.ViewToolStripMenuItem.Enabled = True
    End Sub
End Class