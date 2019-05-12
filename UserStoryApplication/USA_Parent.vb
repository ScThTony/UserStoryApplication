Public Class USA_Parent


    Private Sub USA_Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.CenterToScreen()

        With LoginForm1
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
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

        If MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) = DialogResult.OK Then
            Application.Exit()
        End If

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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
