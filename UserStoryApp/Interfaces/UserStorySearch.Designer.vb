<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserStorySearch
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MemberTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.MemberTableTableAdapter()
        Me.TestCasesTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter()
        Me.UserStory_MemberTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.UserStory_MemberTableTableAdapter()
        Me.UserStoryTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.UserStoryTableTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.UserStory_MemberTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableUserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Story_ApplicationDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableTestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserStory_MemberTableDataGridView
        '
        Me.UserStory_MemberTableDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UserStory_MemberTableDataGridView.AutoGenerateColumns = False
        Me.UserStory_MemberTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.UserStory_MemberTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStory_MemberTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GroupMemberNoDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn})
        Me.UserStory_MemberTableDataGridView.DataSource = Me.UserStoryTableUserStoryMemberTableBindingSource
        Me.UserStory_MemberTableDataGridView.Location = New System.Drawing.Point(920, 485)
        Me.UserStory_MemberTableDataGridView.Name = "UserStory_MemberTableDataGridView"
        Me.UserStory_MemberTableDataGridView.Size = New System.Drawing.Size(243, 104)
        Me.UserStory_MemberTableDataGridView.TabIndex = 43
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
        Me.GroupBox3.Location = New System.Drawing.Point(920, 595)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(243, 80)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Programmer Details"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberTableBindingSource, "Surname", True))
        Me.TextBox2.Location = New System.Drawing.Point(100, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(137, 24)
        Me.TextBox2.TabIndex = 1
        '
        'MemberTableBindingSource
        '
        Me.MemberTableBindingSource.DataMember = "MemberTable"
        Me.MemberTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberTableBindingSource, "FirstName", True))
        Me.TextBox1.Location = New System.Drawing.Point(100, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(137, 24)
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
        Me.UserStoryTableDataGridView.TabIndex = 45
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
        Me.ListBox1.Location = New System.Drawing.Point(59, 485)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(843, 184)
        Me.ListBox1.TabIndex = 42
        '
        'UserStoryTableTestCasesTableBindingSource
        '
        Me.UserStoryTableTestCasesTableBindingSource.DataMember = "UserStoryTable_TestCasesTable"
        Me.UserStoryTableTestCasesTableBindingSource.DataSource = Me.UserStoryTableBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Search by user story title"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(208, 34)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(221, 24)
        Me.TextBox3.TabIndex = 47
        '
        'MemberTableTableAdapter1
        '
        Me.MemberTableTableAdapter1.ClearBeforeFill = True
        '
        'TestCasesTableTableAdapter1
        '
        Me.TestCasesTableTableAdapter1.ClearBeforeFill = True
        '
        'UserStory_MemberTableTableAdapter1
        '
        Me.UserStory_MemberTableTableAdapter1.ClearBeforeFill = True
        '
        'UserStoryTableTableAdapter1
        '
        Me.UserStoryTableTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1170, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 57)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(435, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(162, 22)
        Me.CheckBox1.TabIndex = 49
        Me.CheckBox1.Text = "List by Completed"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(434, 46)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(188, 22)
        Me.CheckBox2.TabIndex = 50
        Me.CheckBox2.Text = "List by not completed"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 402)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 77)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'UserStorySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserStory_MemberTableDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.UserStoryTableDataGridView)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "UserStorySearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search User Story "
        CType(Me.UserStory_MemberTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableUserStoryMemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Story_ApplicationDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableTestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserStory_MemberTableDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UserStoryTableDataGridView As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStorydescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTableBindingSource As BindingSource
    Friend WithEvents User_Story_ApplicationDataSet1 As User_Story_ApplicationDataSet
    Friend WithEvents MemberTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.MemberTableTableAdapter
    Friend WithEvents TestCasesTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents UserStory_MemberTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents UserStoryTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.UserStoryTableTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents UserStoryTableUserStoryMemberTableBindingSource As BindingSource
    Friend WithEvents MemberTableBindingSource As BindingSource
    Friend WithEvents UserStoryTableTestCasesTableBindingSource As BindingSource
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupMemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
