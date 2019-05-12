<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCasesForm
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
        Me.TestCasesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableTableAdapter = New UserStoryApplication.group32DataSetTableAdapters.TestCasesTableTableAdapter()
        Me.TestCaseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestCaseDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group32DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TestCaseNoDataGridViewTextBoxColumn, Me.UserStoryNoDataGridViewTextBoxColumn, Me.TestCaseDetailsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TestCasesTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(922, 514)
        Me.DataGridView1.TabIndex = 0
        '
        'Group32DataSet
        '
        Me.Group32DataSet.DataSetName = "group32DataSet"
        Me.Group32DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestCasesTableBindingSource
        '
        Me.TestCasesTableBindingSource.DataMember = "TestCasesTable"
        Me.TestCasesTableBindingSource.DataSource = Me.Group32DataSet
        '
        'TestCasesTableTableAdapter
        '
        Me.TestCasesTableTableAdapter.ClearBeforeFill = True
        '
        'TestCaseNoDataGridViewTextBoxColumn
        '
        Me.TestCaseNoDataGridViewTextBoxColumn.DataPropertyName = "TestCaseNo"
        Me.TestCaseNoDataGridViewTextBoxColumn.HeaderText = "TestCaseNo"
        Me.TestCaseNoDataGridViewTextBoxColumn.Name = "TestCaseNoDataGridViewTextBoxColumn"
        Me.TestCaseNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserStoryNoDataGridViewTextBoxColumn
        '
        Me.UserStoryNoDataGridViewTextBoxColumn.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.HeaderText = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.Name = "UserStoryNoDataGridViewTextBoxColumn"
        Me.UserStoryNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestCaseDetailsDataGridViewTextBoxColumn
        '
        Me.TestCaseDetailsDataGridViewTextBoxColumn.DataPropertyName = "TestCaseDetails"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.HeaderText = "TestCaseDetails"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.Name = "TestCaseDetailsDataGridViewTextBoxColumn"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.ReadOnly = True
        Me.TestCaseDetailsDataGridViewTextBoxColumn.Width = 600
        '
        'TestCasesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 539)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TestCasesForm"
        Me.Text = "TestCasesForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group32DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group32DataSet As group32DataSet
    Friend WithEvents TestCasesTableBindingSource As BindingSource
    Friend WithEvents TestCasesTableTableAdapter As group32DataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents TestCaseNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestCaseDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
