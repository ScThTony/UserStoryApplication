<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUserStoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbResponsibility2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProgrammer2 = New System.Windows.Forms.ComboBox()
        Me.BSProg2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Group321 = New UserStoryApplication.DS_Group32()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbResponsibility1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbProgrammer1 = New System.Windows.Forms.ComboBox()
        Me.BSProg1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecordUserStoryButton = New System.Windows.Forms.Button()
        Me.Programmer2Box = New System.Windows.Forms.GroupBox()
        Me.Programmer1Box = New System.Windows.Forms.GroupBox()
        Me.btnRemoveTestCase = New System.Windows.Forms.Button()
        Me.btnAddNewTestCase = New System.Windows.Forms.Button()
        Me.lboxTestCase = New System.Windows.Forms.ListBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.tbNewTestCase = New System.Windows.Forms.TextBox()
        Me.UserStoryDescription = New System.Windows.Forms.TextBox()
        Me.PriorityComboBox = New System.Windows.Forms.ComboBox()
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UserRoleComboBox = New System.Windows.Forms.ComboBox()
        Me.UserStoryTitle = New System.Windows.Forms.TextBox()
        Me.MemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_MemberTable = New UserStoryApplication.DS_Group32TableAdapters.MemberTableTableAdapter()
        Me.TA_UserStoryTable = New UserStoryApplication.DS_Group32TableAdapters.UserStoryTableTableAdapter()
        Me.TA_UserStory_MemberTable = New UserStoryApplication.DS_Group32TableAdapters.UserStory_MemberTableTableAdapter()
        Me.TA_TestCasesTable = New UserStoryApplication.DS_Group32TableAdapters.TestCasesTableTableAdapter()
        CType(Me.BSProg2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DS_Group321,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BSProg1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Programmer2Box.SuspendLayout
        Me.Programmer1Box.SuspendLayout
        CType(Me.MemberTableBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(75, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 20)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "User Story Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(170, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Responsibility"
        '
        'cbResponsibility2
        '
        Me.cbResponsibility2.FormattingEnabled = true
        Me.cbResponsibility2.Location = New System.Drawing.Point(174, 88)
        Me.cbResponsibility2.Name = "cbResponsibility2"
        Me.cbResponsibility2.Size = New System.Drawing.Size(121, 28)
        Me.cbResponsibility2.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.Location = New System.Drawing.Point(82, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 20)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "User Story Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(403, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "New Test Case Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'cbProgrammer2
        '
        Me.cbProgrammer2.DataSource = Me.BSProg2
        Me.cbProgrammer2.DisplayMember = "FirstName"
        Me.cbProgrammer2.FormattingEnabled = true
        Me.cbProgrammer2.Location = New System.Drawing.Point(7, 88)
        Me.cbProgrammer2.Name = "cbProgrammer2"
        Me.cbProgrammer2.Size = New System.Drawing.Size(121, 28)
        Me.cbProgrammer2.TabIndex = 0
        Me.cbProgrammer2.ValueMember = "GroupMemberNo"
        '
        'BSProg2
        '
        Me.BSProg2.AllowNew = true
        Me.BSProg2.DataMember = "MemberTable"
        Me.BSProg2.DataSource = Me.DS_Group321
        '
        'DS_Group321
        '
        Me.DS_Group321.DataSetName = "DS_Group32"
        Me.DS_Group321.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(380, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "User Role"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(569, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(170, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Responsibility"
        '
        'cbResponsibility1
        '
        Me.cbResponsibility1.FormattingEnabled = true
        Me.cbResponsibility1.Location = New System.Drawing.Point(174, 88)
        Me.cbResponsibility1.Name = "cbResponsibility1"
        Me.cbResponsibility1.Size = New System.Drawing.Size(121, 28)
        Me.cbResponsibility1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(789, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "End Date"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = true
        Me.lblPriority.BackColor = System.Drawing.SystemColors.Control
        Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPriority.Location = New System.Drawing.Point(1025, 39)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(56, 20)
        Me.lblPriority.TabIndex = 43
        Me.lblPriority.Text = "Priority"
        '
        'Label
        '
        Me.Label.AutoSize = true
        Me.Label.Location = New System.Drawing.Point(6, 62)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(51, 20)
        Me.Label.TabIndex = 2
        Me.Label.Text = "Name"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = true
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStatus.Location = New System.Drawing.Point(1025, 173)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 20)
        Me.lblStatus.TabIndex = 42
        Me.lblStatus.Text = "Status"
        '
        'cbProgrammer1
        '
        Me.cbProgrammer1.DataSource = Me.BSProg1
        Me.cbProgrammer1.DisplayMember = "FirstName"
        Me.cbProgrammer1.FormattingEnabled = true
        Me.cbProgrammer1.Location = New System.Drawing.Point(7, 88)
        Me.cbProgrammer1.Name = "cbProgrammer1"
        Me.cbProgrammer1.Size = New System.Drawing.Size(121, 28)
        Me.cbProgrammer1.TabIndex = 0
        Me.cbProgrammer1.ValueMember = "GroupMemberNo"
        '
        'BSProg1
        '
        Me.BSProg1.AllowNew = true
        Me.BSProg1.DataMember = "MemberTable"
        Me.BSProg1.DataSource = Me.DS_Group321
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(509, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Finalised Test Cases"
        '
        'RecordUserStoryButton
        '
        Me.RecordUserStoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RecordUserStoryButton.Location = New System.Drawing.Point(921, 502)
        Me.RecordUserStoryButton.Name = "RecordUserStoryButton"
        Me.RecordUserStoryButton.Size = New System.Drawing.Size(241, 144)
        Me.RecordUserStoryButton.TabIndex = 39
        Me.RecordUserStoryButton.Text = "Record User Story"
        Me.RecordUserStoryButton.UseVisualStyleBackColor = true
        '
        'Programmer2Box
        '
        Me.Programmer2Box.Controls.Add(Me.Label3)
        Me.Programmer2Box.Controls.Add(Me.Label1)
        Me.Programmer2Box.Controls.Add(Me.cbResponsibility2)
        Me.Programmer2Box.Controls.Add(Me.cbProgrammer2)
        Me.Programmer2Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Programmer2Box.Location = New System.Drawing.Point(458, 502)
        Me.Programmer2Box.Name = "Programmer2Box"
        Me.Programmer2Box.Size = New System.Drawing.Size(301, 144)
        Me.Programmer2Box.TabIndex = 38
        Me.Programmer2Box.TabStop = false
        Me.Programmer2Box.Text = "Programmer 2"
        '
        'Programmer1Box
        '
        Me.Programmer1Box.Controls.Add(Me.Label2)
        Me.Programmer1Box.Controls.Add(Me.Label)
        Me.Programmer1Box.Controls.Add(Me.cbResponsibility1)
        Me.Programmer1Box.Controls.Add(Me.cbProgrammer1)
        Me.Programmer1Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Programmer1Box.Location = New System.Drawing.Point(79, 502)
        Me.Programmer1Box.Name = "Programmer1Box"
        Me.Programmer1Box.Size = New System.Drawing.Size(301, 144)
        Me.Programmer1Box.TabIndex = 37
        Me.Programmer1Box.TabStop = false
        Me.Programmer1Box.Text = "Programmer 1"
        '
        'btnRemoveTestCase
        '
        Me.btnRemoveTestCase.Location = New System.Drawing.Point(754, 278)
        Me.btnRemoveTestCase.Name = "btnRemoveTestCase"
        Me.btnRemoveTestCase.Size = New System.Drawing.Size(186, 23)
        Me.btnRemoveTestCase.TabIndex = 36
        Me.btnRemoveTestCase.Text = "Remove Test Case"
        Me.btnRemoveTestCase.UseVisualStyleBackColor = true
        '
        'btnAddNewTestCase
        '
        Me.btnAddNewTestCase.Location = New System.Drawing.Point(458, 278)
        Me.btnAddNewTestCase.Name = "btnAddNewTestCase"
        Me.btnAddNewTestCase.Size = New System.Drawing.Size(186, 23)
        Me.btnAddNewTestCase.TabIndex = 35
        Me.btnAddNewTestCase.Text = "Add New Test Case"
        Me.btnAddNewTestCase.UseVisualStyleBackColor = true
        '
        'lboxTestCase
        '
        Me.lboxTestCase.FormattingEnabled = true
        Me.lboxTestCase.Location = New System.Drawing.Point(407, 313)
        Me.lboxTestCase.Name = "lboxTestCase"
        Me.lboxTestCase.Size = New System.Drawing.Size(586, 95)
        Me.lboxTestCase.TabIndex = 34
        '
        'StatusComboBox
        '
        Me.StatusComboBox.FormattingEnabled = true
        Me.StatusComboBox.Location = New System.Drawing.Point(1029, 196)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(133, 21)
        Me.StatusComboBox.TabIndex = 33
        '
        'tbNewTestCase
        '
        Me.tbNewTestCase.Location = New System.Drawing.Point(407, 196)
        Me.tbNewTestCase.Multiline = true
        Me.tbNewTestCase.Name = "tbNewTestCase"
        Me.tbNewTestCase.Size = New System.Drawing.Size(586, 76)
        Me.tbNewTestCase.TabIndex = 32
        '
        'UserStoryDescription
        '
        Me.UserStoryDescription.Location = New System.Drawing.Point(79, 196)
        Me.UserStoryDescription.Multiline = true
        Me.UserStoryDescription.Name = "UserStoryDescription"
        Me.UserStoryDescription.Size = New System.Drawing.Size(265, 212)
        Me.UserStoryDescription.TabIndex = 31
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.FormattingEnabled = true
        Me.PriorityComboBox.Location = New System.Drawing.Point(1029, 62)
        Me.PriorityComboBox.Name = "PriorityComboBox"
        Me.PriorityComboBox.Size = New System.Drawing.Size(133, 21)
        Me.PriorityComboBox.TabIndex = 30
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.Location = New System.Drawing.Point(793, 62)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EndDateTimePicker.TabIndex = 29
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Location = New System.Drawing.Point(573, 63)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.StartDateTimePicker.TabIndex = 28
        '
        'UserRoleComboBox
        '
        Me.UserRoleComboBox.FormattingEnabled = true
        Me.UserRoleComboBox.Location = New System.Drawing.Point(384, 63)
        Me.UserRoleComboBox.Name = "UserRoleComboBox"
        Me.UserRoleComboBox.Size = New System.Drawing.Size(157, 21)
        Me.UserRoleComboBox.TabIndex = 27
        '
        'UserStoryTitle
        '
        Me.UserStoryTitle.Location = New System.Drawing.Point(79, 63)
        Me.UserStoryTitle.Multiline = true
        Me.UserStoryTitle.Name = "UserStoryTitle"
        Me.UserStoryTitle.Size = New System.Drawing.Size(265, 54)
        Me.UserStoryTitle.TabIndex = 26
        '
        'MemberTableBindingSource
        '
        Me.MemberTableBindingSource.DataSource = Me.BSProg2
        '
        'TA_MemberTable
        '
        Me.TA_MemberTable.ClearBeforeFill = true
        '
        'TA_UserStoryTable
        '
        Me.TA_UserStoryTable.ClearBeforeFill = true
        '
        'TA_UserStory_MemberTable
        '
        Me.TA_UserStory_MemberTable.ClearBeforeFill = true
        '
        'TA_TestCasesTable
        '
        Me.TA_TestCasesTable.ClearBeforeFill = true
        '
        'NewUserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 684)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RecordUserStoryButton)
        Me.Controls.Add(Me.Programmer2Box)
        Me.Controls.Add(Me.Programmer1Box)
        Me.Controls.Add(Me.btnRemoveTestCase)
        Me.Controls.Add(Me.btnAddNewTestCase)
        Me.Controls.Add(Me.lboxTestCase)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.tbNewTestCase)
        Me.Controls.Add(Me.UserStoryDescription)
        Me.Controls.Add(Me.PriorityComboBox)
        Me.Controls.Add(Me.EndDateTimePicker)
        Me.Controls.Add(Me.StartDateTimePicker)
        Me.Controls.Add(Me.UserRoleComboBox)
        Me.Controls.Add(Me.UserStoryTitle)
        Me.Name = "NewUserStoryForm"
        Me.Text = "NewUserStoryForm"
        CType(Me.BSProg2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DS_Group321,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BSProg1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Programmer2Box.ResumeLayout(false)
        Me.Programmer2Box.PerformLayout
        Me.Programmer1Box.ResumeLayout(false)
        Me.Programmer1Box.PerformLayout
        CType(Me.MemberTableBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbResponsibility2 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProgrammer2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbResponsibility1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPriority As Label
    Friend WithEvents Label As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbProgrammer1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RecordUserStoryButton As Button
    Friend WithEvents Programmer2Box As GroupBox
    Friend WithEvents Programmer1Box As GroupBox
    Friend WithEvents btnRemoveTestCase As Button
    Friend WithEvents btnAddNewTestCase As Button
    Friend WithEvents lboxTestCase As ListBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents tbNewTestCase As TextBox
    Friend WithEvents UserStoryDescription As TextBox
    Friend WithEvents PriorityComboBox As ComboBox
    Friend WithEvents EndDateTimePicker As DateTimePicker
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents UserRoleComboBox As ComboBox
    Friend WithEvents UserStoryTitle As TextBox
    Friend WithEvents DS_Group321 As DS_Group32
    Friend WithEvents TA_MemberTable As DS_Group32TableAdapters.MemberTableTableAdapter
    Friend WithEvents MemberTableBindingSource As BindingSource
    Friend WithEvents BSProg2 As BindingSource
    Friend WithEvents BSProg1 As BindingSource
    Friend WithEvents TA_UserStoryTable As DS_Group32TableAdapters.UserStoryTableTableAdapter
    Friend WithEvents TA_UserStory_MemberTable As DS_Group32TableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents TA_TestCasesTable As DS_Group32TableAdapters.TestCasesTableTableAdapter
End Class
