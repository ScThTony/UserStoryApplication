<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Group32DataSet = New UserStoryApplication.group32DataSet()
        Me.UserStoryMemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStory_MemberTableTableAdapter = New UserStoryApplication.group32DataSetTableAdapters.UserStory_MemberTableTableAdapter()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupMemberNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group32DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn, Me.GroupMemberNoDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserStoryMemberTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(975, 499)
        Me.DataGridView1.TabIndex = 0
        '
        'Group32DataSet
        '
        Me.Group32DataSet.DataSetName = "group32DataSet"
        Me.Group32DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryMemberTableBindingSource
        '
        Me.UserStoryMemberTableBindingSource.DataMember = "UserStory_MemberTable"
        Me.UserStoryMemberTableBindingSource.DataSource = Me.Group32DataSet
        '
        'UserStory_MemberTableTableAdapter
        '
        Me.UserStory_MemberTableTableAdapter.ClearBeforeFill = True
        '
        'UserStoryNoDataGridViewTextBoxColumn
        '
        Me.UserStoryNoDataGridViewTextBoxColumn.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.HeaderText = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.Name = "UserStoryNoDataGridViewTextBoxColumn"
        '
        'GroupMemberNoDataGridViewTextBoxColumn
        '
        Me.GroupMemberNoDataGridViewTextBoxColumn.DataPropertyName = "GroupMemberNo"
        Me.GroupMemberNoDataGridViewTextBoxColumn.HeaderText = "GroupMemberNo"
        Me.GroupMemberNoDataGridViewTextBoxColumn.Name = "GroupMemberNoDataGridViewTextBoxColumn"
        '
        'ResponsibilityDataGridViewTextBoxColumn
        '
        Me.ResponsibilityDataGridViewTextBoxColumn.DataPropertyName = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.HeaderText = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.Name = "ResponsibilityDataGridViewTextBoxColumn"
        '
        'MemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 577)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MemberForm"
        Me.Text = "MemberForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group32DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group32DataSet As group32DataSet
    Friend WithEvents UserStoryMemberTableBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableTableAdapter As group32DataSetTableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupMemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
