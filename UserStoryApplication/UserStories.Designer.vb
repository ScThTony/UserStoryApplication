<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserStories
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbUserStories = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserStoryTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserSToryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group32DataSet = New UserStoryApplication.group32DataSet()
        Me.gbTestCaseDetails = New System.Windows.Forms.GroupBox()
        Me.TCDGV = New System.Windows.Forms.DataGridView()
        Me.TestCasesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbAssociatedProgrammers = New System.Windows.Forms.GroupBox()
        Me.UserStory_MemberTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserStoryNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupMemberNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryMemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.UserStoryTableTableAdapter = New UserStoryApplication.group32DataSetTableAdapters.UserStoryTableTableAdapter()
        Me.TestCasesTableTableAdapter = New UserStoryApplication.group32DataSetTableAdapters.TestCasesTableTableAdapter()
        Me.UserStory_MemberTableTableAdapter = New UserStoryApplication.group32DataSetTableAdapters.UserStory_MemberTableTableAdapter()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.searchbox = New System.Windows.Forms.MaskedTextBox()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.UserStoryNoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestCaseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestCaseDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbUserStories.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UserStoryTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group32DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTestCaseDetails.SuspendLayout()
        CType(Me.TCDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAssociatedProgrammers.SuspendLayout()
        CType(Me.UserStory_MemberTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbUserStories
        '
        Me.gbUserStories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbUserStories.Controls.Add(Me.Panel1)
        Me.gbUserStories.Location = New System.Drawing.Point(24, 71)
        Me.gbUserStories.Margin = New System.Windows.Forms.Padding(10)
        Me.gbUserStories.Name = "gbUserStories"
        Me.gbUserStories.Padding = New System.Windows.Forms.Padding(0)
        Me.gbUserStories.Size = New System.Drawing.Size(994, 288)
        Me.gbUserStories.TabIndex = 2
        Me.gbUserStories.TabStop = False
        Me.gbUserStories.Text = "UserStories"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.UserStoryTableDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(7, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(30, 30, 30, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 272)
        Me.Panel1.TabIndex = 4
        '
        'UserStoryTableDataGridView
        '
        Me.UserStoryTableDataGridView.AllowUserToAddRows = False
        Me.UserStoryTableDataGridView.AllowUserToDeleteRows = False
        Me.UserStoryTableDataGridView.AutoGenerateColumns = False
        Me.UserStoryTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.UserStoryTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStoryTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn, Me.UserStoryTitleDataGridViewTextBoxColumn, Me.UserRoleDataGridViewTextBoxColumn, Me.UserStoryDescriptionDataGridViewTextBoxColumn, Me.UserStoryStartDateDataGridViewTextBoxColumn, Me.UserStoryEndDateDataGridViewTextBoxColumn, Me.UserSToryStatusDataGridViewTextBoxColumn, Me.UserStoryPriorityDataGridViewTextBoxColumn})
        Me.UserStoryTableDataGridView.DataSource = Me.UserStoryTableBindingSource
        Me.UserStoryTableDataGridView.Location = New System.Drawing.Point(0, -3)
        Me.UserStoryTableDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.UserStoryTableDataGridView.MultiSelect = False
        Me.UserStoryTableDataGridView.Name = "UserStoryTableDataGridView"
        Me.UserStoryTableDataGridView.ReadOnly = True
        Me.UserStoryTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserStoryTableDataGridView.Size = New System.Drawing.Size(981, 275)
        Me.UserStoryTableDataGridView.TabIndex = 4
        '
        'UserStoryNoDataGridViewTextBoxColumn
        '
        Me.UserStoryNoDataGridViewTextBoxColumn.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.HeaderText = "User Story No"
        Me.UserStoryNoDataGridViewTextBoxColumn.Name = "UserStoryNoDataGridViewTextBoxColumn"
        Me.UserStoryNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserStoryNoDataGridViewTextBoxColumn.Width = 78
        '
        'UserStoryTitleDataGridViewTextBoxColumn
        '
        Me.UserStoryTitleDataGridViewTextBoxColumn.DataPropertyName = "UserStoryTitle"
        Me.UserStoryTitleDataGridViewTextBoxColumn.HeaderText = "User Story Title"
        Me.UserStoryTitleDataGridViewTextBoxColumn.Name = "UserStoryTitleDataGridViewTextBoxColumn"
        Me.UserStoryTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserStoryTitleDataGridViewTextBoxColumn.Width = 96
        '
        'UserRoleDataGridViewTextBoxColumn
        '
        Me.UserRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole"
        Me.UserRoleDataGridViewTextBoxColumn.HeaderText = "User Role"
        Me.UserRoleDataGridViewTextBoxColumn.Name = "UserRoleDataGridViewTextBoxColumn"
        Me.UserRoleDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserRoleDataGridViewTextBoxColumn.Width = 73
        '
        'UserStoryDescriptionDataGridViewTextBoxColumn
        '
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "UserStoryDescription"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.HeaderText = "User Story Description"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.Name = "UserStoryDescriptionDataGridViewTextBoxColumn"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'UserStoryStartDateDataGridViewTextBoxColumn
        '
        Me.UserStoryStartDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStartDate"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.HeaderText = "User Story Start Date"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.Name = "UserStoryStartDateDataGridViewTextBoxColumn"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserStoryEndDateDataGridViewTextBoxColumn
        '
        Me.UserStoryEndDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryEndDate"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.HeaderText = "User Story End Date"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.Name = "UserStoryEndDateDataGridViewTextBoxColumn"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserStoryEndDateDataGridViewTextBoxColumn.Width = 97
        '
        'UserSToryStatusDataGridViewTextBoxColumn
        '
        Me.UserSToryStatusDataGridViewTextBoxColumn.DataPropertyName = "UserSToryStatus"
        Me.UserSToryStatusDataGridViewTextBoxColumn.HeaderText = "User Story Status"
        Me.UserSToryStatusDataGridViewTextBoxColumn.Name = "UserSToryStatusDataGridViewTextBoxColumn"
        Me.UserSToryStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserSToryStatusDataGridViewTextBoxColumn.Width = 105
        '
        'UserStoryPriorityDataGridViewTextBoxColumn
        '
        Me.UserStoryPriorityDataGridViewTextBoxColumn.DataPropertyName = "UserStoryPriority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.HeaderText = "User Story Priority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.Name = "UserStoryPriorityDataGridViewTextBoxColumn"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserStoryPriorityDataGridViewTextBoxColumn.Width = 105
        '
        'UserStoryTableBindingSource
        '
        Me.UserStoryTableBindingSource.DataMember = "UserStoryTable"
        Me.UserStoryTableBindingSource.DataSource = Me.Group32DataSet
        '
        'Group32DataSet
        '
        Me.Group32DataSet.DataSetName = "group32DataSet"
        Me.Group32DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbTestCaseDetails
        '
        Me.gbTestCaseDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbTestCaseDetails.Controls.Add(Me.TCDGV)
        Me.gbTestCaseDetails.Location = New System.Drawing.Point(24, 361)
        Me.gbTestCaseDetails.Name = "gbTestCaseDetails"
        Me.gbTestCaseDetails.Size = New System.Drawing.Size(994, 254)
        Me.gbTestCaseDetails.TabIndex = 3
        Me.gbTestCaseDetails.TabStop = False
        Me.gbTestCaseDetails.Text = "Associated Test Cases"
        '
        'TCDGV
        '
        Me.TCDGV.AllowUserToAddRows = False
        Me.TCDGV.AllowUserToDeleteRows = False
        Me.TCDGV.AutoGenerateColumns = False
        Me.TCDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TCDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn2, Me.TestCaseNoDataGridViewTextBoxColumn, Me.TestCaseDetailsDataGridViewTextBoxColumn})
        Me.TCDGV.DataSource = Me.TestCasesTableBindingSource
        Me.TCDGV.Location = New System.Drawing.Point(7, 20)
        Me.TCDGV.Name = "TCDGV"
        Me.TCDGV.ReadOnly = True
        Me.TCDGV.Size = New System.Drawing.Size(981, 228)
        Me.TCDGV.TabIndex = 0
        '
        'TestCasesTableBindingSource
        '
        Me.TestCasesTableBindingSource.DataMember = "TestCasesTable"
        Me.TestCasesTableBindingSource.DataSource = Me.Group32DataSet
        '
        'gbAssociatedProgrammers
        '
        Me.gbAssociatedProgrammers.Controls.Add(Me.UserStory_MemberTableDataGridView)
        Me.gbAssociatedProgrammers.Location = New System.Drawing.Point(24, 622)
        Me.gbAssociatedProgrammers.Name = "gbAssociatedProgrammers"
        Me.gbAssociatedProgrammers.Size = New System.Drawing.Size(746, 174)
        Me.gbAssociatedProgrammers.TabIndex = 4
        Me.gbAssociatedProgrammers.TabStop = False
        Me.gbAssociatedProgrammers.Text = "Associated Programmers"
        '
        'UserStory_MemberTableDataGridView
        '
        Me.UserStory_MemberTableDataGridView.AllowUserToDeleteRows = False
        Me.UserStory_MemberTableDataGridView.AutoGenerateColumns = False
        Me.UserStory_MemberTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserStory_MemberTableDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.UserStory_MemberTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStory_MemberTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn1, Me.GroupMemberNoDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn})
        Me.UserStory_MemberTableDataGridView.DataSource = Me.UserStoryMemberTableBindingSource
        Me.UserStory_MemberTableDataGridView.Location = New System.Drawing.Point(7, 29)
        Me.UserStory_MemberTableDataGridView.Name = "UserStory_MemberTableDataGridView"
        Me.UserStory_MemberTableDataGridView.ReadOnly = True
        Me.UserStory_MemberTableDataGridView.Size = New System.Drawing.Size(715, 132)
        Me.UserStory_MemberTableDataGridView.TabIndex = 0
        '
        'UserStoryNoDataGridViewTextBoxColumn1
        '
        Me.UserStoryNoDataGridViewTextBoxColumn1.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn1.HeaderText = "User Story No"
        Me.UserStoryNoDataGridViewTextBoxColumn1.Name = "UserStoryNoDataGridViewTextBoxColumn1"
        Me.UserStoryNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'GroupMemberNoDataGridViewTextBoxColumn
        '
        Me.GroupMemberNoDataGridViewTextBoxColumn.DataPropertyName = "GroupMemberNo"
        Me.GroupMemberNoDataGridViewTextBoxColumn.HeaderText = "Group Member No"
        Me.GroupMemberNoDataGridViewTextBoxColumn.Name = "GroupMemberNoDataGridViewTextBoxColumn"
        Me.GroupMemberNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResponsibilityDataGridViewTextBoxColumn
        '
        Me.ResponsibilityDataGridViewTextBoxColumn.DataPropertyName = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.HeaderText = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.Name = "ResponsibilityDataGridViewTextBoxColumn"
        Me.ResponsibilityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserStoryMemberTableBindingSource
        '
        Me.UserStoryMemberTableBindingSource.DataMember = "UserStory_MemberTable"
        Me.UserStoryMemberTableBindingSource.DataSource = Me.Group32DataSet
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(854, 651)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 132)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Done"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'UserStoryTableTableAdapter
        '
        Me.UserStoryTableTableAdapter.ClearBeforeFill = True
        '
        'TestCasesTableTableAdapter
        '
        Me.TestCasesTableTableAdapter.ClearBeforeFill = True
        '
        'UserStory_MemberTableTableAdapter
        '
        Me.UserStory_MemberTableTableAdapter.ClearBeforeFill = True
        '
        'Searchbtn
        '
        Me.Searchbtn.Location = New System.Drawing.Point(752, 51)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(113, 23)
        Me.Searchbtn.TabIndex = 7
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'searchbox
        '
        Me.searchbox.Location = New System.Drawing.Point(872, 51)
        Me.searchbox.Mask = "00"
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(146, 20)
        Me.searchbox.TabIndex = 8
        Me.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Editbtn
        '
        Me.Editbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editbtn.Location = New System.Drawing.Point(31, 13)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(109, 45)
        Me.Editbtn.TabIndex = 9
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Savebtn
        '
        Me.Savebtn.Enabled = False
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.Location = New System.Drawing.Point(146, 13)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(109, 45)
        Me.Savebtn.TabIndex = 10
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'UserStoryNoDataGridViewTextBoxColumn2
        '
        Me.UserStoryNoDataGridViewTextBoxColumn2.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn2.HeaderText = "User Story No"
        Me.UserStoryNoDataGridViewTextBoxColumn2.Name = "UserStoryNoDataGridViewTextBoxColumn2"
        Me.UserStoryNoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TestCaseNoDataGridViewTextBoxColumn
        '
        Me.TestCaseNoDataGridViewTextBoxColumn.DataPropertyName = "TestCaseNo"
        Me.TestCaseNoDataGridViewTextBoxColumn.HeaderText = "Test Case No"
        Me.TestCaseNoDataGridViewTextBoxColumn.Name = "TestCaseNoDataGridViewTextBoxColumn"
        Me.TestCaseNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestCaseDetailsDataGridViewTextBoxColumn
        '
        Me.TestCaseDetailsDataGridViewTextBoxColumn.DataPropertyName = "TestCaseDetails"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.HeaderText = "Test Case Details"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.Name = "TestCaseDetailsDataGridViewTextBoxColumn"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.ReadOnly = True
        Me.TestCaseDetailsDataGridViewTextBoxColumn.Width = 600
        '
        'UserStories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1042, 807)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbAssociatedProgrammers)
        Me.Controls.Add(Me.gbTestCaseDetails)
        Me.Controls.Add(Me.gbUserStories)
        Me.Name = "UserStories"
        Me.Text = "User Stories"
        Me.gbUserStories.ResumeLayout(False)
        Me.gbUserStories.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UserStoryTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group32DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTestCaseDetails.ResumeLayout(False)
        CType(Me.TCDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAssociatedProgrammers.ResumeLayout(False)
        CType(Me.UserStory_MemberTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbUserStories As GroupBox
    Friend WithEvents gbTestCaseDetails As GroupBox
    Friend WithEvents gbAssociatedProgrammers As GroupBox
    Friend WithEvents UserStory_MemberTableDataGridView As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents Group32DataSet As group32DataSet
    Friend WithEvents UserStoryTableBindingSource As BindingSource
    Friend WithEvents UserStoryTableTableAdapter As group32DataSetTableAdapters.UserStoryTableTableAdapter
    Friend WithEvents TestCasesTableBindingSource As BindingSource
    Friend WithEvents TestCasesTableTableAdapter As group32DataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents UserStoryMemberTableBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableTableAdapter As group32DataSetTableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserStoryTableDataGridView As DataGridView
    Friend WithEvents TCDGV As DataGridView
    Friend WithEvents Searchbtn As Button
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserSToryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupMemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents searchbox As MaskedTextBox
    Friend WithEvents Editbtn As Button
    Friend WithEvents Savebtn As Button
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TestCaseNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestCaseDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
