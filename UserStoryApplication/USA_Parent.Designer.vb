﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class USA_Parent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccessControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserStoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DS_Group32 = New UserStoryApplication.DS_Group32()
        Me.MemberTableTableAdapter1 = New UserStoryApplication.DS_Group32TableAdapters.MemberTableTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DS_Group32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessControlToolStripMenuItem, Me.UserStoryToolStripMenuItem, Me.TestCasesToolStripMenuItem, Me.MemberControlToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1155, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "Status"
        '
        'AccessControlToolStripMenuItem
        '
        Me.AccessControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AccessControlToolStripMenuItem.Name = "AccessControlToolStripMenuItem"
        Me.AccessControlToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AccessControlToolStripMenuItem.Text = "Access Control"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MemberControlToolStripMenuItem
        '
        Me.MemberControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.MemberControlToolStripMenuItem.Enabled = False
        Me.MemberControlToolStripMenuItem.Name = "MemberControlToolStripMenuItem"
        Me.MemberControlToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.MemberControlToolStripMenuItem.Text = "Member Control"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'UserStoryToolStripMenuItem
        '
        Me.UserStoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem1, Me.EditToolStripMenuItem1})
        Me.UserStoryToolStripMenuItem.Enabled = False
        Me.UserStoryToolStripMenuItem.Name = "UserStoryToolStripMenuItem"
        Me.UserStoryToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UserStoryToolStripMenuItem.Text = "User Story"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ViewToolStripMenuItem1.Text = "View/Edit/Search"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem1.Text = "Add"
        '
        'TestCasesToolStripMenuItem
        '
        Me.TestCasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem2})
        Me.TestCasesToolStripMenuItem.Enabled = False
        Me.TestCasesToolStripMenuItem.Name = "TestCasesToolStripMenuItem"
        Me.TestCasesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.TestCasesToolStripMenuItem.Text = "Test Cases"
        '
        'ViewToolStripMenuItem2
        '
        Me.ViewToolStripMenuItem2.Name = "ViewToolStripMenuItem2"
        Me.ViewToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem2.Text = "View"
        '
        'DS_Group32
        '
        Me.DS_Group32.DataSetName = "DS_Group32"
        Me.DS_Group32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableTableAdapter1
        '
        Me.MemberTableTableAdapter1.ClearBeforeFill = true
        '
        'USA_Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 697)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "USA_Parent"
        Me.Text = "USA_Parent"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.DS_Group32,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccessControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemberControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserStoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TestCasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DS_Group32 As DS_Group32
    Friend WithEvents MemberTableTableAdapter1 As DS_Group32TableAdapters.MemberTableTableAdapter
End Class
