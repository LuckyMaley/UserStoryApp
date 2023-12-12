Public Class TestCaseNew

    Private Sub TestCaseNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'User_Story_ApplicationDataSet.TestCasesTable' table. You can move, or remove it, as needed.
            Me.TestCasesTableTableAdapter.Fill(Me.User_Story_ApplicationDataSet.TestCasesTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TestCasesTableBindingSource.MoveFirst()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestCasesTableBindingSource.MoveNext()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestCasesTableBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TestCasesTableBindingSource.MoveLast()

    End Sub

    'When add button is clicked a new row is inserted into the database table and the add button is disabled
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            TestCasesTableBindingSource.AddNew()
            Button4.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'When add button is clicked a new row is updated into the database table and the add button is enabled again
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            TestCasesTableBindingSource.EndEdit()
            TestCasesTableTableAdapter.Update(User_Story_ApplicationDataSet)
            Button4.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Enables the Test case view toolstrip when the form closes
    Private Sub TestCaseNew_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.NewToolStripMenuItem.Enabled = True
    End Sub
End Class