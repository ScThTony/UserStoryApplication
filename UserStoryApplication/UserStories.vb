Public Class UserStories
    Private Sub UserStoryTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate
        Me.UserStoryTableBindingSource.EndEdit
        'Me.TableAdapterManager.UpdateAll(Me.DS_Group32)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group32DataSet.UserStory_MemberTable' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableTableAdapter.Fill(Me.Group32DataSet.UserStory_MemberTable)
        'TODO: This line of code loads data into the 'Group32DataSet.TestCasesTable' table. You can move, or remove it, as needed.
        Me.TestCasesTableTableAdapter.Fill(Me.Group32DataSet.TestCasesTable)
        'TODO: This line of code loads data into the 'Group32DataSet.UserStoryTable' table. You can move, or remove it, as needed.
        Me.UserStoryTableTableAdapter.Fill(Me.Group32DataSet.UserStoryTable)


    End Sub

    Private Sub UserStoryTableDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UserStoryTableDataGridView.SelectionChanged
        'MemberTableTableAdapter1.Fill(DS_Group32.MemberTable)

        'For i As Integer = 0 To 1
        '    For j As Integer = 0 To 4

        '        If Me.UserStory_MemberTableDataGridView.Rows.Item(i).Cells(1).Value = DS_Group32.MemberTable.Rows(j).Item(0)Then

        '            Me.UserStory_MemberTableDataGridView.Rows.Item(i).Cells(2).Value = DS_Group32.MemberTable.Rows(j).Item(1)
        '           Me.UserStory_MemberTableDataGridView.Rows.Item(i).Cells(3).Value = DS_Group32.MemberTable.Rows(j).Item(2)
        '        End If


        '    Next

        'Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click, searchbox.TextChanged
        Dim query As String

        query = "CONVERT(UserStoryNo, System.String) LIKE '%" + searchbox.Text + "%'"

        If query.Length = 0 Then
            UserStoryTableBindingSource.RemoveFilter()
        Else
            UserStoryTableBindingSource.Filter = query
            TestCasesTableBindingSource.Filter = query
            UserStoryMemberTableBindingSource.Filter = query
        End If
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Editbtn.Enabled = False
        UserStoryTableDataGridView.ReadOnly = False
        TCDGV.ReadOnly = False
        UserStoryTableDataGridView.ReadOnly = False
        UserStoryTableDataGridView.GridColor = Color.Crimson
        TCDGV.GridColor = Color.Crimson
        UserStoryTableDataGridView.GridColor = Color.Crimson
        Savebtn.Enabled = True
        MsgBox("Edit User Stories, Test Cases, Or User Members! Click Save when done!")
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        UserStoryTableBindingSource.EndEdit()
        TestCasesTableBindingSource.EndEdit()
        UserStoryMemberTableBindingSource.EndEdit()
        Try
            UserStoryTableTableAdapter.Update(Group32DataSet.UserStoryTable)
            TestCasesTableTableAdapter.Update(Group32DataSet.TestCasesTable)
            UserStory_MemberTableTableAdapter.Update(Group32DataSet.UserStory_MemberTable)
            MsgBox("Information saved!")
        Catch ex As DataException
            MsgBox(ex.StackTrace)
        End Try
        Editbtn.Enabled = True
        UserStoryTableDataGridView.ReadOnly = True
        TCDGV.ReadOnly = True
        UserStoryTableDataGridView.ReadOnly = True
        UserStoryTableDataGridView.GridColor = Color.Gray
        TCDGV.GridColor = Color.Gray
        UserStoryTableDataGridView.GridColor = Color.Gray
        Savebtn.Enabled = False
        Me.UserStoryTableTableAdapter.Fill(Me.Group32DataSet.UserStoryTable)
        Me.TestCasesTableTableAdapter.Fill(Me.Group32DataSet.TestCasesTable)
        Me.UserStory_MemberTableTableAdapter.Fill(Me.Group32DataSet.UserStory_MemberTable)
    End Sub
End Class