Option Infer On


Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MemberTableTableAdapter1.FillBy(DS_Group32.MemberTable, UsernameTextBox.Text, PasswordTextBox.Text)

        If DS_Group32.MemberTable.Rows.Count > 0 Then
            MsgBox("Welcome. You will now be directed to the system.")
            Me.Close()
            With USA_Parent
                .MemberControlToolStripMenuItem.Enabled = True
                .UserStoryToolStripMenuItem.Enabled = True
                .TestCasesToolStripMenuItem.Enabled = True
            End With
            Me.Close()
        Else
            MsgBox("Invalid User Details")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub




End Class
