<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserstoryEdit
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserStory_MemberTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupMemberNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTableUserStoryMemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_Story_ApplicationDataSet1 = New UserStoryApp.User_Story_ApplicationDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UserStoryTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStorydescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.UserStoryTableTestCasesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.UserStoryTableTableAdapter()
        Me.UserStory_MemberTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.UserStory_MemberTableTableAdapter()
        Me.MemberTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.MemberTableTableAdapter()
        Me.TestCasesTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter()
        CType(Me.UserStory_MemberTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableUserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Story_ApplicationDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableTestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1170, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 57)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserStory_MemberTableDataGridView
        '
        Me.UserStory_MemberTableDataGridView.AllowUserToAddRows = False
        Me.UserStory_MemberTableDataGridView.AllowUserToDeleteRows = False
        Me.UserStory_MemberTableDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UserStory_MemberTableDataGridView.AutoGenerateColumns = False
        Me.UserStory_MemberTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.UserStory_MemberTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStory_MemberTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GroupMemberNoDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn})
        Me.UserStory_MemberTableDataGridView.DataSource = Me.UserStoryTableUserStoryMemberTableBindingSource
        Me.UserStory_MemberTableDataGridView.Location = New System.Drawing.Point(921, 422)
        Me.UserStory_MemberTableDataGridView.Name = "UserStory_MemberTableDataGridView"
        Me.UserStory_MemberTableDataGridView.ReadOnly = True
        Me.UserStory_MemberTableDataGridView.Size = New System.Drawing.Size(243, 122)
        Me.UserStory_MemberTableDataGridView.TabIndex = 38
        '
        'GroupMemberNoDataGridViewTextBoxColumn
        '
        Me.GroupMemberNoDataGridViewTextBoxColumn.DataPropertyName = "GroupMemberNo"
        Me.GroupMemberNoDataGridViewTextBoxColumn.HeaderText = "GroupMemberNo"
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
        'UserStoryTableUserStoryMemberTableBindingSource
        '
        Me.UserStoryTableUserStoryMemberTableBindingSource.DataMember = "UserStoryTable_UserStory_MemberTable"
        Me.UserStoryTableUserStoryMemberTableBindingSource.DataSource = Me.UserStoryTableBindingSource
        '
        'UserStoryTableBindingSource
        '
        Me.UserStoryTableBindingSource.DataMember = "UserStoryTable"
        Me.UserStoryTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        '
        'User_Story_ApplicationDataSet1
        '
        Me.User_Story_ApplicationDataSet1.DataSetName = "User_Story_ApplicationDataSet"
        Me.User_Story_ApplicationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(921, 550)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(243, 96)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Programmer Details"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberTableBindingSource, "Surname", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(134, 24)
        Me.TextBox2.TabIndex = 1
        '
        'MemberTableBindingSource
        '
        Me.MemberTableBindingSource.DataMember = "MemberTable"
        Me.MemberTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberTableBindingSource, "FirstName", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(103, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(134, 24)
        Me.TextBox1.TabIndex = 0
        '
        'UserStoryTableDataGridView
        '
        Me.UserStoryTableDataGridView.AllowUserToAddRows = False
        Me.UserStoryTableDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserStoryTableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.UserStoryTableDataGridView.AutoGenerateColumns = False
        Me.UserStoryTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.UserStoryTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStoryTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn, Me.UserStoryTitleDataGridViewTextBoxColumn, Me.UserRoleDataGridViewTextBoxColumn, Me.UserStorydescriptionDataGridViewTextBoxColumn, Me.UserStoryStartDateDataGridViewTextBoxColumn, Me.UserStoryEndDateDataGridViewTextBoxColumn, Me.UserStoryStatusDataGridViewTextBoxColumn, Me.UserStoryPriorityDataGridViewTextBoxColumn})
        Me.UserStoryTableDataGridView.DataSource = Me.UserStoryTableBindingSource
        Me.UserStoryTableDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserStoryTableDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.UserStoryTableDataGridView.Name = "UserStoryTableDataGridView"
        Me.UserStoryTableDataGridView.RowTemplate.Height = 55
        Me.UserStoryTableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserStoryTableDataGridView.Size = New System.Drawing.Size(1284, 396)
        Me.UserStoryTableDataGridView.TabIndex = 40
        '
        'UserStoryNoDataGridViewTextBoxColumn
        '
        Me.UserStoryNoDataGridViewTextBoxColumn.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.HeaderText = "User Story"
        Me.UserStoryNoDataGridViewTextBoxColumn.Name = "UserStoryNoDataGridViewTextBoxColumn"
        Me.UserStoryNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserStoryNoDataGridViewTextBoxColumn.Width = 50
        '
        'UserStoryTitleDataGridViewTextBoxColumn
        '
        Me.UserStoryTitleDataGridViewTextBoxColumn.DataPropertyName = "UserStoryTitle"
        Me.UserStoryTitleDataGridViewTextBoxColumn.HeaderText = "User Story Title"
        Me.UserStoryTitleDataGridViewTextBoxColumn.Name = "UserStoryTitleDataGridViewTextBoxColumn"
        '
        'UserRoleDataGridViewTextBoxColumn
        '
        Me.UserRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole"
        Me.UserRoleDataGridViewTextBoxColumn.HeaderText = "User Role"
        Me.UserRoleDataGridViewTextBoxColumn.Name = "UserRoleDataGridViewTextBoxColumn"
        '
        'UserStorydescriptionDataGridViewTextBoxColumn
        '
        Me.UserStorydescriptionDataGridViewTextBoxColumn.DataPropertyName = "UserStorydescription"
        Me.UserStorydescriptionDataGridViewTextBoxColumn.HeaderText = "User Story Description"
        Me.UserStorydescriptionDataGridViewTextBoxColumn.Name = "UserStorydescriptionDataGridViewTextBoxColumn"
        Me.UserStorydescriptionDataGridViewTextBoxColumn.Width = 550
        '
        'UserStoryStartDateDataGridViewTextBoxColumn
        '
        Me.UserStoryStartDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStartDate"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.HeaderText = "User Story Start Date"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.Name = "UserStoryStartDateDataGridViewTextBoxColumn"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.Width = 150
        '
        'UserStoryEndDateDataGridViewTextBoxColumn
        '
        Me.UserStoryEndDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryEndDate"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.HeaderText = "User Story End Date"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.Name = "UserStoryEndDateDataGridViewTextBoxColumn"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.Width = 150
        '
        'UserStoryStatusDataGridViewTextBoxColumn
        '
        Me.UserStoryStatusDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStatus"
        Me.UserStoryStatusDataGridViewTextBoxColumn.HeaderText = "User Story Status"
        Me.UserStoryStatusDataGridViewTextBoxColumn.Name = "UserStoryStatusDataGridViewTextBoxColumn"
        '
        'UserStoryPriorityDataGridViewTextBoxColumn
        '
        Me.UserStoryPriorityDataGridViewTextBoxColumn.DataPropertyName = "UserStoryPriority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.HeaderText = "User Story Priority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.Name = "UserStoryPriorityDataGridViewTextBoxColumn"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ListBox1.DataSource = Me.UserStoryTableTestCasesTableBindingSource
        Me.ListBox1.DisplayMember = "TestCaseDetails"
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 422)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(903, 224)
        Me.ListBox1.TabIndex = 37
        '
        'UserStoryTableTestCasesTableBindingSource
        '
        Me.UserStoryTableTestCasesTableBindingSource.DataMember = "UserStoryTable_TestCasesTable"
        Me.UserStoryTableTestCasesTableBindingSource.DataSource = Me.UserStoryTableBindingSource
        '
        'UserStoryTableTableAdapter1
        '
        Me.UserStoryTableTableAdapter1.ClearBeforeFill = True
        '
        'UserStory_MemberTableTableAdapter1
        '
        Me.UserStory_MemberTableTableAdapter1.ClearBeforeFill = True
        '
        'MemberTableTableAdapter1
        '
        Me.MemberTableTableAdapter1.ClearBeforeFill = True
        '
        'TestCasesTableTableAdapter1
        '
        Me.TestCasesTableTableAdapter1.ClearBeforeFill = True
        '
        'UserstoryEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserStory_MemberTableDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.UserStoryTableDataGridView)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "UserstoryEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User Story "
        CType(Me.UserStory_MemberTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableUserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Story_ApplicationDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableTestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents UserStory_MemberTableDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UserStoryTableDataGridView As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents User_Story_ApplicationDataSet1 As User_Story_ApplicationDataSet
    Friend WithEvents UserStoryTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.UserStoryTableTableAdapter
    Friend WithEvents UserStory_MemberTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents MemberTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.MemberTableTableAdapter
    Friend WithEvents TestCasesTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents GroupMemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTableUserStoryMemberTableBindingSource As BindingSource
    Friend WithEvents UserStoryTableBindingSource As BindingSource
    Friend WithEvents MemberTableBindingSource As BindingSource
    Friend WithEvents UserStoryTableTestCasesTableBindingSource As BindingSource
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStorydescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
