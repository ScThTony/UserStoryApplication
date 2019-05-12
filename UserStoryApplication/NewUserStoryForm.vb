Option Infer On

Imports Microsoft.VisualBasic.Logging


Public Class NewUserStoryForm
    Private Sub NewUserStoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TA_MemberTable.Fill(DS_Group321.MemberTable)

        With UserRoleComboBox.Items
            .Add("Sales Rep")
            .Add("CFO")
            .Add("General Manager")
            .Add("System Developer")
        End With

        With PriorityComboBox.Items
            .Add("High")
            .Add("Medium")
            .Add("Low")
        End With

        With StatusComboBox.Items
            .Add("Complete")
            .Add("In Progress")
            .Add("To Start")
            .Add("Delayed")
            .Add("On Time")
        End With


    End Sub

    Private Sub RecordUserStoryButton_Click(sender As Object, e As EventArgs) Handles RecordUserStoryButton.Click
        Dim usTitle = UserStoryTitle.Text
        Dim uRole = UserRoleComboBox.SelectedItem
        Dim sDate = StartDateTimePicker.Value.Date
        Dim eDate = EndDateTimePicker.Value.Date
        Dim cbPriority = PriorityComboBox.SelectedItem
        Dim cbStatus = StatusComboBox.SelectedItem
        Dim usDescription = UserStoryDescription.Text

        #Region "Record User Story + associated test cases + associated programmers, each to their own respective tables"
        Dim userStoryPk As Integer
        Try
            'Me.Validate()
            userStoryPk = TA_UserStoryTable.InsertUserStory(usTitle, uRole, usDescription,sDate, eDate, cbStatus, cbPriority)
        
        
            'Insert new entries into UserStory_MemberTable
            TA_UserStory_MemberTable.Insert(userStoryPk, cbProgrammer1.SelectedValue, cbResponsibility1.SelectedItem )
            TA_UserStory_MemberTable.Insert(userStoryPk, cbProgrammer2.SelectedValue, cbResponsibility2.SelectedItem )
            
            'Insert associated test cases into db
            For i As Integer = 0 To lboxTestCase.Items.Count - 1
                TA_TestCasesTable.Insert(lboxTestCase.Items(i), userStoryPk)
            Next

        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "DB insert failed")
        End Try
        #End Region


    End Sub

    Private Sub AddNewTestCaseButton_Click(sender As Object, e As EventArgs) Handles btnAddNewTestCase.Click
        If Not String.IsNullOrWhiteSpace(tbNewTestCase.Text)
            lboxTestCase.Items.Add(tbNewTestCase.Text)
        End If
    End Sub

    Private Sub btnRemoveTestCase_Click(sender As Object, e As EventArgs) Handles btnRemoveTestCase.Click
        If Not lboxTestCase.SelectedItems.Count = 0
            lboxTestCase.Items.Remove(lboxTestCase.SelectedItem)

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        USA_Parent.Show()
        Me.Close()
    End Sub
End Class