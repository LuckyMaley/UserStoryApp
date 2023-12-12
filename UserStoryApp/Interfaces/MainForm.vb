Public Class MainForm
    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()

        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .WindowState = FormWindowState.Maximized
            .Show()
            End With

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetUp1(LoginForm1)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        FormSetUp(UserStoryView)
        ViewToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        FormSetUp(FrmNewStory)
        EditToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'Disables buttons when the user logs out
        With Me
            .MemberControlToolStripMenuItem.Enabled = False
            .UserStoryToolStripMenuItem.Enabled = False
            .TestCasesToolStripMenuItem.Enabled = False
            .ToolStripStatusLabel1.Text = "[Not Logged in]"
            .LoginToolStripMenuItem.Enabled = True
        End With
        FormSetUp1(LoginForm1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToString("hh:mm tt") & "  " & DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        FormSetUp(MemberView)
        ViewToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
        FormSetUp(TestCaseView)
        ViewToolStripMenuItem2.Enabled = False
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        FormSetUp(TestCaseEdit)
        EditToolStripMenuItem2.Enabled = False
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FormSetUp(TestCaseNew)
        NewToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        FormSetUp(TestCaseDelete)
        DeleteToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        FormSetUp(MemberEdit)
        EditToolStripMenuItem.Enabled = False
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        FormSetUp(MemberSearch)
        SearchToolStripMenuItem.Enabled = False

    End Sub

    Private Sub DeleteToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem3.Click
        FormSetUp(DeleteUserStory)
        DeleteToolStripMenuItem3.Enabled = False
    End Sub

    Private Sub EditToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem3.Click
        FormSetUp(UserstoryEdit)
        EditToolStripMenuItem3.Enabled = False
    End Sub

    Private Sub SearchToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem2.Click
        FormSetUp(UserStorySearch)
        SearchToolStripMenuItem2.Enabled = False
    End Sub

    Friend Sub FormSetUp1(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()

        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .Show()
        End With

    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FormSetUp1(AboutBox1)
        AboutToolStripMenuItem.Enabled = False
    End Sub
End Class
