<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCaseView
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
        Dim TestCasesLabel As System.Windows.Forms.Label
        Dim UserStoryNoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.User_Story_ApplicationDataSet = New UserStoryApp.User_Story_ApplicationDataSet()
        Me.TestCasesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableTableAdapter = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter()
        Me.TableAdapterManager = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TableAdapterManager()
        Me.TestCasesTextBox = New System.Windows.Forms.TextBox()
        Me.TestCaseDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.UserStoryNoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TestCasesTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        TestCasesLabel = New System.Windows.Forms.Label()
        UserStoryNoLabel = New System.Windows.Forms.Label()
        CType(Me.User_Story_ApplicationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TestCasesTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestCasesLabel
        '
        TestCasesLabel.AutoSize = True
        TestCasesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TestCasesLabel.Location = New System.Drawing.Point(6, 31)
        TestCasesLabel.Name = "TestCasesLabel"
        TestCasesLabel.Size = New System.Drawing.Size(83, 16)
        TestCasesLabel.TabIndex = 1
        TestCasesLabel.Text = "Test Case:"
        '
        'UserStoryNoLabel
        '
        UserStoryNoLabel.AutoSize = True
        UserStoryNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserStoryNoLabel.Location = New System.Drawing.Point(6, 65)
        UserStoryNoLabel.Name = "UserStoryNoLabel"
        UserStoryNoLabel.Size = New System.Drawing.Size(85, 16)
        UserStoryNoLabel.TabIndex = 5
        UserStoryNoLabel.Text = "User Story:"
        '
        'User_Story_ApplicationDataSet
        '
        Me.User_Story_ApplicationDataSet.DataSetName = "User_Story_ApplicationDataSet"
        Me.User_Story_ApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestCasesTableBindingSource
        '
        Me.TestCasesTableBindingSource.DataMember = "TestCasesTable"
        Me.TestCasesTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet
        '
        'TestCasesTableTableAdapter
        '
        Me.TestCasesTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MemberTableTableAdapter = Nothing
        Me.TableAdapterManager.TestCasesTableTableAdapter = Me.TestCasesTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableTableAdapter = Nothing
        Me.TableAdapterManager.UserStoryTableTableAdapter = Nothing
        '
        'TestCasesTextBox
        '
        Me.TestCasesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "TestCases", True))
        Me.TestCasesTextBox.Location = New System.Drawing.Point(116, 23)
        Me.TestCasesTextBox.Name = "TestCasesTextBox"
        Me.TestCasesTextBox.ReadOnly = True
        Me.TestCasesTextBox.Size = New System.Drawing.Size(163, 24)
        Me.TestCasesTextBox.TabIndex = 2
        '
        'TestCaseDetailsTextBox
        '
        Me.TestCaseDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "TestCaseDetails", True))
        Me.TestCaseDetailsTextBox.Location = New System.Drawing.Point(6, 19)
        Me.TestCaseDetailsTextBox.Multiline = True
        Me.TestCaseDetailsTextBox.Name = "TestCaseDetailsTextBox"
        Me.TestCaseDetailsTextBox.ReadOnly = True
        Me.TestCaseDetailsTextBox.Size = New System.Drawing.Size(541, 239)
        Me.TestCaseDetailsTextBox.TabIndex = 4
        '
        'UserStoryNoTextBox
        '
        Me.UserStoryNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "UserStoryNo", True))
        Me.UserStoryNoTextBox.Location = New System.Drawing.Point(116, 57)
        Me.UserStoryNoTextBox.Name = "UserStoryNoTextBox"
        Me.UserStoryNoTextBox.ReadOnly = True
        Me.UserStoryNoTextBox.Size = New System.Drawing.Size(163, 24)
        Me.UserStoryNoTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(UserStoryNoLabel)
        Me.GroupBox1.Controls.Add(Me.UserStoryNoTextBox)
        Me.GroupBox1.Controls.Add(Me.TestCasesTextBox)
        Me.GroupBox1.Controls.Add(TestCasesLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 91)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'TestCasesTableDataGridView
        '
        Me.TestCasesTableDataGridView.AllowUserToAddRows = False
        Me.TestCasesTableDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestCasesTableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TestCasesTableDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TestCasesTableDataGridView.AutoGenerateColumns = False
        Me.TestCasesTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TestCasesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestCasesTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TestCasesTableDataGridView.DataSource = Me.TestCasesTableBindingSource
        Me.TestCasesTableDataGridView.Location = New System.Drawing.Point(655, 27)
        Me.TestCasesTableDataGridView.Name = "TestCasesTableDataGridView"
        Me.TestCasesTableDataGridView.ReadOnly = True
        Me.TestCasesTableDataGridView.RowTemplate.Height = 44
        Me.TestCasesTableDataGridView.Size = New System.Drawing.Size(593, 439)
        Me.TestCasesTableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TestCases"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TestCases"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TestCaseDetails"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TestCaseDetails"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserStoryNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserStoryNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.TestCaseDetailsTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(62, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 264)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Test Case Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(62, 394)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(553, 72)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Navigation"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(417, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 43)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Last"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 43)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "First"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TestCaseView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 581)
        Me.Controls.Add(Me.TestCasesTableDataGridView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "TestCaseView"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Test Cases"
        CType(Me.User_Story_ApplicationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TestCasesTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_Story_ApplicationDataSet As User_Story_ApplicationDataSet
    Friend WithEvents TestCasesTableBindingSource As BindingSource
    Friend WithEvents TestCasesTableTableAdapter As User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents TableAdapterManager As User_Story_ApplicationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TestCasesTextBox As TextBox
    Friend WithEvents TestCaseDetailsTextBox As TextBox
    Friend WithEvents UserStoryNoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TestCasesTableDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
