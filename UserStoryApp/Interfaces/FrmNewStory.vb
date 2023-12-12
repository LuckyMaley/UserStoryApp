Public Class FrmNewStory
    Private Sub FrmNewStory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fills the User Story form with data as the form loads
        MemberTableTableAdapter1.Fill(User_Story_ApplicationDataSet1.MemberTable)
    End Sub

    Private Sub RecordUSbtn_Click(sender As Object, e As EventArgs) Handles RecordUSbtn.Click
        Dim UserStoryNumber As Integer

        Dim NewResult As DialogResult = MessageBox.Show(ParentForm, "Are you sure you want to record user story?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If NewResult = DialogResult.Yes Then
                If USTtb.Text <> "" And URCB.Text <> "" And PriorityCB.Text <> "" And USDtb.Text <> "" And USDtb.Text <> "" And TClbox.Items.Count <> 0 And StatusCB.Text <> "" And Name1CB.Text <> Name2CB.Text And Resp1CB.Text <> Resp2CB.Text Then
                    'updates the user story table
                    UserStoryTableTableAdapter1.InsertUserStory(USTtb.Text, URCB.SelectedItem, USDtb.Text, DateTimePicker1.Value, DateTimePicker2.Value, StatusCB.SelectedItem, PriorityCB.SelectedItem)
                    UserStoryNumber = UserStoryTableTableAdapter1.ScalarQuery()

                    'Updates the user story member table
                    UserStory_MemberTableTableAdapter1.Insert(UserStoryNumber, Name1CB.SelectedValue, Resp1CB.SelectedItem)
                    UserStory_MemberTableTableAdapter1.Insert(UserStoryNumber, Name2CB.SelectedValue, Resp2CB.SelectedItem)
                    'updates the test cases table
                    For i As Integer = 0 To TClbox.Items.Count - 1
                        TestCasesTableTableAdapter1.Insert(TClbox.Items(i), UserStoryNumber)
                    Next
                    MessageBox.Show("The User Story has been Recorded!", "Confirmation")
                Else
                    MessageBox.Show("Please enter all required fields and make sure that programmers names and responsibilities are not the same")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddTC_Click(sender As Object, e As EventArgs) Handles AddTC.Click
        'adds the test case details to the test cases listboxes
        TClbox.Items.Add(TCDtb.Text)
    End Sub

    Private Sub RemTClbl_Click(sender As Object, e As EventArgs) Handles RemTClbl.Click
        'removes at the selected index 
        Try
            TClbox.Items.RemoveAt(TClbox.SelectedIndex)
        Catch ex1 As Exception
            MessageBox.Show(ex1.Message)
        End Try
    End Sub

    Private Sub FrmNewStory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.EditToolStripMenuItem1.Enabled = True
    End Sub

End Class