Public Class FrmNewStory
    Private Sub FrmNewStory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fills the User Story form with data as the form loads
        MemberTableTableAdapter1.Fill(User_Story_ApplicationDataSet1.MemberTable)
    End Sub

    Private Sub RecordUSbtn_Click(sender As Object, e As EventArgs) Handles RecordUSbtn.Click
        'updates the user story table
        Dim UserStoryNumber As Integer
        UserStoryNumber = UserStoryTableTableAdapter1.InsertUserStory(USTtb.Text, URCB.SelectedItem, USDtb.Text, DateTimePicker1.Value, DateTimePicker2.Value, StatusCB.SelectedItem, PriorityCB.SelectedItem)
        'Updates the user story member table
        UserStory_MemberTableTableAdapter1.Insert(UserStoryNumber, Name1CB.SelectedValue, Resp1CB.SelectedItem)
        UserStory_MemberTableTableAdapter1.Insert(UserStoryNumber, Name2CB.SelectedValue, Resp2CB.SelectedItem)
        'updates the test cases table
        Dim i As Integer = 0
        For i = 0 To TClbox.Items.Count - 1
            TestCasesTableTableAdapter1.Insert(TClbox.Items(i), UserStoryNumber)
        Next
    End Sub

    Private Sub AddTC_Click(sender As Object, e As EventArgs) Handles AddTC.Click
        'adds the test case details to the test cases listboxes
        TClbox.Items.Add(TCDtb)
    End Sub

    Private Sub RemTClbl_Click(sender As Object, e As EventArgs) Handles RemTClbl.Click
        'removes at the selected index 
        TClbox.Items.RemoveAt(TClbox.SelectedIndex)
    End Sub
End Class