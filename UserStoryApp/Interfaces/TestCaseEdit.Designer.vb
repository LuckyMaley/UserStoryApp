<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCaseEdit
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEditLat = New System.Windows.Forms.Button()
        Me.btnCaseEditNext = New System.Windows.Forms.Button()
        Me.btnEditFirst = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TestCasesTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        TestCasesLabel = New System.Windows.Forms.Label()
        UserStoryNoLabel = New System.Windows.Forms.Label()
        CType(Me.User_Story_ApplicationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TestCasesTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestCasesLabel
        '
        TestCasesLabel.AutoSize = True
        TestCasesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TestCasesLabel.Location = New System.Drawing.Point(9, 31)
        TestCasesLabel.Name = "TestCasesLabel"
        TestCasesLabel.Size = New System.Drawing.Size(83, 16)
        TestCasesLabel.TabIndex = 1
        TestCasesLabel.Text = "Test Case:"
        '
        'UserStoryNoLabel
        '
        UserStoryNoLabel.AutoSize = True
        UserStoryNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserStoryNoLabel.Location = New System.Drawing.Point(9, 70)
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
        Me.TestCasesTextBox.Location = New System.Drawing.Point(124, 23)
        Me.TestCasesTextBox.Name = "TestCasesTextBox"
        Me.TestCasesTextBox.Size = New System.Drawing.Size(190, 24)
        Me.TestCasesTextBox.TabIndex = 2
        '
        'TestCaseDetailsTextBox
        '
        Me.TestCaseDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "TestCaseDetails", True))
        Me.TestCaseDetailsTextBox.Location = New System.Drawing.Point(6, 19)
        Me.TestCaseDetailsTextBox.Multiline = True
        Me.TestCaseDetailsTextBox.Name = "TestCaseDetailsTextBox"
        Me.TestCaseDetailsTextBox.Size = New System.Drawing.Size(541, 202)
        Me.TestCaseDetailsTextBox.TabIndex = 4
        '
        'UserStoryNoTextBox
        '
        Me.UserStoryNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "UserStoryNo", True))
        Me.UserStoryNoTextBox.Location = New System.Drawing.Point(124, 62)
        Me.UserStoryNoTextBox.Name = "UserStoryNoTextBox"
        Me.UserStoryNoTextBox.Size = New System.Drawing.Size(190, 24)
        Me.UserStoryNoTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.UserStoryNoTextBox)
        Me.GroupBox1.Controls.Add(UserStoryNoLabel)
        Me.GroupBox1.Controls.Add(TestCasesLabel)
        Me.GroupBox1.Controls.Add(Me.TestCasesTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 116)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.TestCaseDetailsTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(62, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 227)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test Case Details"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.btnEditLat)
        Me.GroupBox3.Controls.Add(Me.btnCaseEditNext)
        Me.GroupBox3.Controls.Add(Me.btnEditFirst)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(62, 452)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 75)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'btnEditLat
        '
        Me.btnEditLat.Location = New System.Drawing.Point(417, 19)
        Me.btnEditLat.Name = "btnEditLat"
        Me.btnEditLat.Size = New System.Drawing.Size(131, 43)
        Me.btnEditLat.TabIndex = 4
        Me.btnEditLat.Text = "Last"
        Me.btnEditLat.UseVisualStyleBackColor = True
        '
        'btnCaseEditNext
        '
        Me.btnCaseEditNext.Location = New System.Drawing.Point(143, 19)
        Me.btnCaseEditNext.Name = "btnCaseEditNext"
        Me.btnCaseEditNext.Size = New System.Drawing.Size(131, 43)
        Me.btnCaseEditNext.TabIndex = 0
        Me.btnCaseEditNext.Text = "Next"
        Me.btnCaseEditNext.UseVisualStyleBackColor = True
        '
        'btnEditFirst
        '
        Me.btnEditFirst.Location = New System.Drawing.Point(6, 19)
        Me.btnEditFirst.Name = "btnEditFirst"
        Me.btnEditFirst.Size = New System.Drawing.Size(131, 43)
        Me.btnEditFirst.TabIndex = 3
        Me.btnEditFirst.Text = "First"
        Me.btnEditFirst.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TestCasesTableDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestCasesTableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TestCasesTableDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TestCasesTableDataGridView.AutoGenerateColumns = False
        Me.TestCasesTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TestCasesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestCasesTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TestCasesTableDataGridView.DataSource = Me.TestCasesTableBindingSource
        Me.TestCasesTableDataGridView.Location = New System.Drawing.Point(670, 28)
        Me.TestCasesTableDataGridView.Name = "TestCasesTableDataGridView"
        Me.TestCasesTableDataGridView.RowTemplate.Height = 44
        Me.TestCasesTableDataGridView.Size = New System.Drawing.Size(593, 499)
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
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserStoryNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserStoryNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(62, 383)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 43)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TestCaseEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 581)
        Me.Controls.Add(Me.TestCasesTableDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "TestCaseEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Test Cases"
        CType(Me.User_Story_ApplicationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TestCasesTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TestCasesTableDataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCaseEditNext As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnEditLat As Button
    Friend WithEvents btnEditFirst As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
