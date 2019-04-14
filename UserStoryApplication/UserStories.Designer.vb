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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserStories))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UserStoryTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Group32 = New UserStoryApplication.DS_Group32()
        Me.UserStoryTableTableAdapter = New UserStoryApplication.DS_Group32TableAdapters.UserStoryTableTableAdapter()
        Me.TableAdapterManager = New UserStoryApplication.DS_Group32TableAdapters.TableAdapterManager()
        Me.gbUserStories = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserStoryTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserStoryTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.gbTestCaseDetails = New System.Windows.Forms.GroupBox()
        Me.lboxTestCaseDetails = New System.Windows.Forms.ListBox()
        Me.TestCasesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbAssociatedProgrammers = New System.Windows.Forms.GroupBox()
        Me.UserStory_MemberTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammerSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStory_MemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableTableAdapter = New UserStoryApplication.DS_Group32TableAdapters.TestCasesTableTableAdapter()
        Me.UserStory_MemberTableTableAdapter = New UserStoryApplication.DS_Group32TableAdapters.UserStory_MemberTableTableAdapter()
        Me.MemberTableTableAdapter1 = New UserStoryApplication.DS_Group32TableAdapters.MemberTableTableAdapter()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.UserStoryTableBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DS_Group32,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbUserStories.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.UserStoryTableDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UserStoryTableBindingNavigator,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UserStoryTableBindingNavigator.SuspendLayout
        Me.gbTestCaseDetails.SuspendLayout
        CType(Me.TestCasesTableBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbAssociatedProgrammers.SuspendLayout
        CType(Me.UserStory_MemberTableDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UserStory_MemberTableBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UserStoryTableBindingSource
        '
        Me.UserStoryTableBindingSource.DataMember = "UserStoryTable"
        Me.UserStoryTableBindingSource.DataSource = Me.DS_Group32
        '
        'DS_Group32
        '
        Me.DS_Group32.DataSetName = "DS_Group32"
        Me.DS_Group32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryTableTableAdapter
        '
        Me.UserStoryTableTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.MemberTableTableAdapter = Nothing
        Me.TableAdapterManager.TestCasesTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UserStoryApplication.DS_Group32TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableTableAdapter = Nothing
        Me.TableAdapterManager.UserStoryTableTableAdapter = Me.UserStoryTableTableAdapter
        '
        'gbUserStories
        '
        Me.gbUserStories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbUserStories.Controls.Add(Me.Panel1)
        Me.gbUserStories.Location = New System.Drawing.Point(24, 12)
        Me.gbUserStories.Margin = New System.Windows.Forms.Padding(10)
        Me.gbUserStories.Name = "gbUserStories"
        Me.gbUserStories.Padding = New System.Windows.Forms.Padding(0)
        Me.gbUserStories.Size = New System.Drawing.Size(994, 347)
        Me.gbUserStories.TabIndex = 2
        Me.gbUserStories.TabStop = false
        Me.gbUserStories.Text = "gbUserStories"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.UserStoryTableDataGridView)
        Me.Panel1.Controls.Add(Me.UserStoryTableBindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(30, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(30, 30, 30, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 296)
        Me.Panel1.TabIndex = 4
        '
        'UserStoryTableDataGridView
        '
        Me.UserStoryTableDataGridView.AutoGenerateColumns = false
        Me.UserStoryTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.UserStoryTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStoryTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.UserStoryTableDataGridView.DataSource = Me.UserStoryTableBindingSource
        Me.UserStoryTableDataGridView.Location = New System.Drawing.Point(0, 34)
        Me.UserStoryTableDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.UserStoryTableDataGridView.MultiSelect = false
        Me.UserStoryTableDataGridView.Name = "UserStoryTableDataGridView"
        Me.UserStoryTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserStoryTableDataGridView.Size = New System.Drawing.Size(934, 262)
        Me.UserStoryTableDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserStoryNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserStoryNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = true
        Me.DataGridViewTextBoxColumn1.Width = 92
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserStoryTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserStoryTitle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 98
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserRole"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserRole"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 76
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserStoryDescription"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserStoryDescription"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 131
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserStoryStartDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserStoryStartDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 123
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UserStoryEndDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UserStoryEndDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UserSToryStatus"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UserSToryStatus"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 112
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserStoryPriority"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UserStoryPriority"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 109
        '
        'UserStoryTableBindingNavigator
        '
        Me.UserStoryTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserStoryTableBindingNavigator.BindingSource = Me.UserStoryTableBindingSource
        Me.UserStoryTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserStoryTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserStoryTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.UserStoryTableBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.UserStoryTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserStoryTableBindingNavigatorSaveItem})
        Me.UserStoryTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserStoryTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserStoryTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserStoryTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserStoryTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserStoryTableBindingNavigator.Name = "UserStoryTableBindingNavigator"
        Me.UserStoryTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserStoryTableBindingNavigator.Size = New System.Drawing.Size(313, 31)
        Me.UserStoryTableBindingNavigator.TabIndex = 3
        Me.UserStoryTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = false
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'UserStoryTableBindingNavigatorSaveItem
        '
        Me.UserStoryTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserStoryTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserStoryTableBindingNavigatorSaveItem.Image"),System.Drawing.Image)
        Me.UserStoryTableBindingNavigatorSaveItem.Name = "UserStoryTableBindingNavigatorSaveItem"
        Me.UserStoryTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.UserStoryTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'gbTestCaseDetails
        '
        Me.gbTestCaseDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbTestCaseDetails.Controls.Add(Me.lboxTestCaseDetails)
        Me.gbTestCaseDetails.Location = New System.Drawing.Point(24, 361)
        Me.gbTestCaseDetails.Name = "gbTestCaseDetails"
        Me.gbTestCaseDetails.Size = New System.Drawing.Size(994, 254)
        Me.gbTestCaseDetails.TabIndex = 3
        Me.gbTestCaseDetails.TabStop = false
        Me.gbTestCaseDetails.Text = "Associated Test Cases"
        '
        'lboxTestCaseDetails
        '
        Me.lboxTestCaseDetails.DataSource = Me.TestCasesTableBindingSource
        Me.lboxTestCaseDetails.DisplayMember = "TestCaseDetails"
        Me.lboxTestCaseDetails.FormattingEnabled = true
        Me.lboxTestCaseDetails.Location = New System.Drawing.Point(30, 31)
        Me.lboxTestCaseDetails.Margin = New System.Windows.Forms.Padding(15)
        Me.lboxTestCaseDetails.Name = "lboxTestCaseDetails"
        Me.lboxTestCaseDetails.Size = New System.Drawing.Size(934, 212)
        Me.lboxTestCaseDetails.TabIndex = 0
        Me.lboxTestCaseDetails.ValueMember = "TestCaseNo"
        '
        'TestCasesTableBindingSource
        '
        Me.TestCasesTableBindingSource.DataMember = "FK_TestCasesTable_UserStoryTable"
        Me.TestCasesTableBindingSource.DataSource = Me.UserStoryTableBindingSource
        '
        'gbAssociatedProgrammers
        '
        Me.gbAssociatedProgrammers.Controls.Add(Me.UserStory_MemberTableDataGridView)
        Me.gbAssociatedProgrammers.Location = New System.Drawing.Point(24, 622)
        Me.gbAssociatedProgrammers.Name = "gbAssociatedProgrammers"
        Me.gbAssociatedProgrammers.Size = New System.Drawing.Size(746, 174)
        Me.gbAssociatedProgrammers.TabIndex = 4
        Me.gbAssociatedProgrammers.TabStop = false
        Me.gbAssociatedProgrammers.Text = "Associated Programmers"
        '
        'UserStory_MemberTableDataGridView
        '
        Me.UserStory_MemberTableDataGridView.AutoGenerateColumns = false
        Me.UserStory_MemberTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserStory_MemberTableDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.UserStory_MemberTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStory_MemberTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.ProgrammerName, Me.ProgrammerSurname, Me.DataGridViewTextBoxColumn11})
        Me.UserStory_MemberTableDataGridView.DataSource = Me.UserStory_MemberTableBindingSource
        Me.UserStory_MemberTableDataGridView.Location = New System.Drawing.Point(30, 29)
        Me.UserStory_MemberTableDataGridView.Name = "UserStory_MemberTableDataGridView"
        Me.UserStory_MemberTableDataGridView.Size = New System.Drawing.Size(692, 132)
        Me.UserStory_MemberTableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UserStoryNo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UserStoryNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GroupMemberNo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "GroupMemberNo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ProgrammerName
        '
        Me.ProgrammerName.HeaderText = "First Name"
        Me.ProgrammerName.Name = "ProgrammerName"
        '
        'ProgrammerSurname
        '
        Me.ProgrammerSurname.HeaderText = "Surname"
        Me.ProgrammerSurname.Name = "ProgrammerSurname"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Responsibility"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Responsibility"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'UserStory_MemberTableBindingSource
        '
        Me.UserStory_MemberTableBindingSource.DataMember = "FK_UserStory_MemberTable_UserStoryTable"
        Me.UserStory_MemberTableBindingSource.DataSource = Me.UserStoryTableBindingSource
        '
        'TestCasesTableTableAdapter
        '
        Me.TestCasesTableTableAdapter.ClearBeforeFill = true
        '
        'UserStory_MemberTableTableAdapter
        '
        Me.UserStory_MemberTableTableAdapter.ClearBeforeFill = true
        '
        'MemberTableTableAdapter1
        '
        Me.MemberTableTableAdapter1.ClearBeforeFill = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(854, 651)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 132)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Done"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'UserStories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.ClientSize = New System.Drawing.Size(1042, 807)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbAssociatedProgrammers)
        Me.Controls.Add(Me.gbTestCaseDetails)
        Me.Controls.Add(Me.gbUserStories)
        Me.Name = "UserStories"
        Me.Text = "User Stories"
        CType(Me.UserStoryTableBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DS_Group32,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbUserStories.ResumeLayout(false)
        Me.gbUserStories.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.UserStoryTableDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UserStoryTableBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.UserStoryTableBindingNavigator.ResumeLayout(false)
        Me.UserStoryTableBindingNavigator.PerformLayout
        Me.gbTestCaseDetails.ResumeLayout(false)
        CType(Me.TestCasesTableBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbAssociatedProgrammers.ResumeLayout(false)
        CType(Me.UserStory_MemberTableDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UserStory_MemberTableBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DS_Group32 As DS_Group32
    Friend WithEvents UserStoryTableBindingSource As BindingSource
    Friend WithEvents UserStoryTableTableAdapter As DS_Group32TableAdapters.UserStoryTableTableAdapter
    Friend WithEvents TableAdapterManager As DS_Group32TableAdapters.TableAdapterManager
    Friend WithEvents gbUserStories As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserStoryTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserStoryTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents gbTestCaseDetails As GroupBox
    Friend WithEvents lboxTestCaseDetails As ListBox
    Friend WithEvents gbAssociatedProgrammers As GroupBox
    Friend WithEvents TestCasesTableBindingSource As BindingSource
    Friend WithEvents TestCasesTableTableAdapter As DS_Group32TableAdapters.TestCasesTableTableAdapter
    Friend WithEvents UserStory_MemberTableBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableTableAdapter As DS_Group32TableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents UserStory_MemberTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ProgrammerName As DataGridViewTextBoxColumn
    Friend WithEvents ProgrammerSurname As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents MemberTableTableAdapter1 As DS_Group32TableAdapters.MemberTableTableAdapter
    Friend WithEvents btnExit As Button
End Class
