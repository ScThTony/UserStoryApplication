Public Class UserStories
    Private Sub UserStoryTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate
        Me.UserStoryTableBindingSource.EndEdit
        Me.TableAdapterManager.UpdateAll(Me.DS_Group32)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Group32.UserStory_MemberTable' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableTableAdapter.Fill(Me.DS_Group32.UserStory_MemberTable)
        'TODO: This line of code loads data into the 'DS_Group32.UserStory_MemberTable' table. You can move, or remove it, as needed.
        Me.UserStory_MemberTableTableAdapter.Fill(Me.DS_Group32.UserStory_MemberTable)
        'TODO: This line of code loads data into the 'DS_Group32.TestCasesTable' table. You can move, or remove it, as needed.
        Me.TestCasesTableTableAdapter.Fill(Me.DS_Group32.TestCasesTable)
        'TODO: This line of code loads data into the 'DS_Group32.UserStoryTable' table. You can move, or remove it, as needed.
        Me.UserStoryTableTableAdapter.Fill(Me.DS_Group32.UserStoryTable)

       ' Me.MemberTableTableAdapter1.Fill(Me.DS_Group32.MemberTable)


    End Sub

    Private Sub UserStoryTableDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UserStoryTableDataGridView.SelectionChanged
       MemberTableTableAdapter1.Fill(DS_Group32.MemberTable)

        For i As Integer = 0 To 1
            For j As Integer = 0 To 4

                If Me.UserStory_MemberTableDataGridView.Rows.Item(i).Cells(1).Value = DS_Group32.MemberTable.Rows(j).Item(0)Then
                   
                    Me.UserStory_MemberTableDataGridView.Rows.Item(i).Cells(2).Value = DS_Group32.MemberTable.Rows(j).Item(1)
                   Me.UserStory_MemberTableDataGridView.Rows.Item(i).Cells(3).Value = DS_Group32.MemberTable.Rows(j).Item(2)
                End If
                
                
            Next

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class