Public Class USA_Parent
    Private Sub USA_Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With LoginForm1
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
        End Try
        With LoginForm1
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

   

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
        End Try
        With UserStories
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
End Class
