Public Class TestCaseView

    Private Sub TestCaseView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet.TestCasesTable' table. You can move, or remove it, as needed.
            Me.TestCasesTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet.TestCasesTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TestCasesTableBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestCasesTableBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestCasesTableBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TestCasesTableBindingSource.MoveLast()
    End Sub

    'When the test case view form is closed the view toolstrip is enabled under test cases
    Private Sub TestCaseView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.ViewToolStripMenuItem2.Enabled = True
    End Sub

End Class