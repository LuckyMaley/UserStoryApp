﻿Public Class MainForm
    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetUp(LoginForm1)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
