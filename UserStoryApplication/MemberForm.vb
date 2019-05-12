Public Class MemberForm
    Private Sub MemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group32DataSet.UserStory_MemberTable' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableTableAdapter.Fill(Me.Group32DataSet.UserStory_MemberTable)

    End Sub
End Class