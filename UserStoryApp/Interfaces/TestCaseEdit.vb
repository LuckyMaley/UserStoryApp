Public Class TestCaseEdit

    Private Sub TestCaseEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet.TestCasesTable' table. You can move, or remove it, as needed.
            Me.TestCasesTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet.TestCasesTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditFirst_Click(sender As Object, e As EventArgs) Handles btnEditFirst.Click
        TestCasesTableBindingSource.MoveFirst()
    End Sub

    Private Sub btnCaseEditNext_Click(sender As Object, e As EventArgs) Handles btnCaseEditNext.Click
        TestCasesTableBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestCasesTableBindingSource.MovePrevious()
    End Sub

    Private Sub btnEditLat_Click(sender As Object, e As EventArgs) Handles btnEditLat.Click
        TestCasesTableBindingSource.MoveLast()
    End Sub

    'When the save button is clicked the database is updated
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update this test case", "Confirmation", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then
                TestCasesTableBindingSource.EndEdit()
                TestCasesTableTableAdapter.Update(User_Story_ApplicationDataSet.TestCasesTable)
                MessageBox.Show("Updated!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TestCaseEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.EditToolStripMenuItem2.Enabled = True
    End Sub
End Class