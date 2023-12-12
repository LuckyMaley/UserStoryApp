Public Class TestCaseDelete
    Private Sub TestCaseDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet.TestCasesTable' table. You can move, or remove it, as needed.
            Me.TestCasesTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet.TestCasesTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Deletes the Test case
    Private Sub btnDeleteTestCase_Click(sender As Object, e As EventArgs) Handles btnDeleteTestCase.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete test case?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If Result = DialogResult.Yes Then
                TestCasesTableBindingSource.RemoveCurrent()
                TestCasesTableTableAdapter.Update(User_Story_ApplicationDataSet.TestCasesTable)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCaseDeleteFirst_Click(sender As Object, e As EventArgs) Handles btnCaseDeleteFirst.Click
        TestCasesTableBindingSource.MoveFirst()

    End Sub

    Private Sub btnCaseNext_Click(sender As Object, e As EventArgs) Handles btnCaseNext.Click
        TestCasesTableBindingSource.MoveNext()
    End Sub

    Private Sub btnCasePrevious_Click(sender As Object, e As EventArgs) Handles btnCasePrevious.Click
        TestCasesTableBindingSource.MovePrevious()

    End Sub

    Private Sub btnCaseDeleteLast_Click(sender As Object, e As EventArgs) Handles btnCaseDeleteLast.Click
        TestCasesTableBindingSource.MoveLast()
    End Sub

    'When the form closes the Test case delete toolstrip is enabled
    Private Sub TestCaseDelete_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.DeleteToolStripMenuItem1.Enabled = True
    End Sub
End Class