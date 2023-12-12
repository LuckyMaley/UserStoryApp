<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCaseDelete
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
        Me.TestCasesTextBox = New System.Windows.Forms.TextBox()
        Me.TestCaseDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.UserStoryNoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteTestCase = New System.Windows.Forms.Button()
        Me.TestCasesTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCasePrevious = New System.Windows.Forms.Button()
        Me.btnCaseNext = New System.Windows.Forms.Button()
        Me.btnCaseDeleteFirst = New System.Windows.Forms.Button()
        Me.btnCaseDeleteLast = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        TestCasesLabel = New System.Windows.Forms.Label()
        UserStoryNoLabel = New System.Windows.Forms.Label()
        CType(Me.User_Story_ApplicationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TestCasesTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestCasesLabel
        '
        TestCasesLabel.AutoSize = True
        TestCasesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TestCasesLabel.Location = New System.Drawing.Point(16, 28)
        TestCasesLabel.Name = "TestCasesLabel"
        TestCasesLabel.Size = New System.Drawing.Size(83, 16)
        TestCasesLabel.TabIndex = 1
        TestCasesLabel.Text = "Test Case:"
        '
        'UserStoryNoLabel
        '
        UserStoryNoLabel.AutoSize = True
        UserStoryNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserStoryNoLabel.Location = New System.Drawing.Point(16, 61)
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
        'TestCasesTextBox
        '
        Me.TestCasesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TestCasesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "TestCases", True))
        Me.TestCasesTextBox.Location = New System.Drawing.Point(131, 22)
        Me.TestCasesTextBox.Name = "TestCasesTextBox"
        Me.TestCasesTextBox.ReadOnly = True
        Me.TestCasesTextBox.Size = New System.Drawing.Size(171, 24)
        Me.TestCasesTextBox.TabIndex = 2
        '
        'TestCaseDetailsTextBox
        '
        Me.TestCaseDetailsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TestCaseDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "TestCaseDetails", True))
        Me.TestCaseDetailsTextBox.Location = New System.Drawing.Point(6, 17)
        Me.TestCaseDetailsTextBox.Multiline = True
        Me.TestCaseDetailsTextBox.Name = "TestCaseDetailsTextBox"
        Me.TestCaseDetailsTextBox.ReadOnly = True
        Me.TestCaseDetailsTextBox.Size = New System.Drawing.Size(541, 215)
        Me.TestCaseDetailsTextBox.TabIndex = 4
        '
        'UserStoryNoTextBox
        '
        Me.UserStoryNoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.UserStoryNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestCasesTableBindingSource, "UserStoryNo", True))
        Me.UserStoryNoTextBox.Location = New System.Drawing.Point(131, 58)
        Me.UserStoryNoTextBox.Name = "UserStoryNoTextBox"
        Me.UserStoryNoTextBox.ReadOnly = True
        Me.UserStoryNoTextBox.Size = New System.Drawing.Size(171, 24)
        Me.UserStoryNoTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(TestCasesLabel)
        Me.GroupBox1.Controls.Add(Me.UserStoryNoTextBox)
        Me.GroupBox1.Controls.Add(Me.TestCasesTextBox)
        Me.GroupBox1.Controls.Add(UserStoryNoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 117)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnDeleteTestCase
        '
        Me.btnDeleteTestCase.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteTestCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteTestCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTestCase.Location = New System.Drawing.Point(62, 384)
        Me.btnDeleteTestCase.Name = "btnDeleteTestCase"
        Me.btnDeleteTestCase.Size = New System.Drawing.Size(131, 43)
        Me.btnDeleteTestCase.TabIndex = 7
        Me.btnDeleteTestCase.Text = "Delete"
        Me.btnDeleteTestCase.UseVisualStyleBackColor = True
        '
        'TestCasesTableDataGridView
        '
        Me.TestCasesTableDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestCasesTableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TestCasesTableDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TestCasesTableDataGridView.AutoGenerateColumns = False
        Me.TestCasesTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TestCasesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestCasesTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TestCasesTableDataGridView.DataSource = Me.TestCasesTableBindingSource
        Me.TestCasesTableDataGridView.Location = New System.Drawing.Point(660, 34)
        Me.TestCasesTableDataGridView.Name = "TestCasesTableDataGridView"
        Me.TestCasesTableDataGridView.ReadOnly = True
        Me.TestCasesTableDataGridView.RowTemplate.Height = 44
        Me.TestCasesTableDataGridView.Size = New System.Drawing.Size(593, 483)
        Me.TestCasesTableDataGridView.TabIndex = 8
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
        Me.GroupBox3.Location = New System.Drawing.Point(56, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 238)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Test Case Details"
        '
        'btnCasePrevious
        '
        Me.btnCasePrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCasePrevious.Location = New System.Drawing.Point(280, 21)
        Me.btnCasePrevious.Name = "btnCasePrevious"
        Me.btnCasePrevious.Size = New System.Drawing.Size(131, 43)
        Me.btnCasePrevious.TabIndex = 8
        Me.btnCasePrevious.Text = "Previous"
        Me.btnCasePrevious.UseVisualStyleBackColor = True
        '
        'btnCaseNext
        '
        Me.btnCaseNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaseNext.Location = New System.Drawing.Point(143, 21)
        Me.btnCaseNext.Name = "btnCaseNext"
        Me.btnCaseNext.Size = New System.Drawing.Size(131, 43)
        Me.btnCaseNext.TabIndex = 9
        Me.btnCaseNext.Text = "Next"
        Me.btnCaseNext.UseVisualStyleBackColor = True
        '
        'btnCaseDeleteFirst
        '
        Me.btnCaseDeleteFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaseDeleteFirst.Location = New System.Drawing.Point(6, 21)
        Me.btnCaseDeleteFirst.Name = "btnCaseDeleteFirst"
        Me.btnCaseDeleteFirst.Size = New System.Drawing.Size(131, 43)
        Me.btnCaseDeleteFirst.TabIndex = 10
        Me.btnCaseDeleteFirst.Text = "First"
        Me.btnCaseDeleteFirst.UseVisualStyleBackColor = True
        '
        'btnCaseDeleteLast
        '
        Me.btnCaseDeleteLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaseDeleteLast.Location = New System.Drawing.Point(417, 21)
        Me.btnCaseDeleteLast.Name = "btnCaseDeleteLast"
        Me.btnCaseDeleteLast.Size = New System.Drawing.Size(131, 43)
        Me.btnCaseDeleteLast.TabIndex = 11
        Me.btnCaseDeleteLast.Text = "Last"
        Me.btnCaseDeleteLast.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.btnCaseDeleteLast)
        Me.GroupBox2.Controls.Add(Me.btnCaseDeleteFirst)
        Me.GroupBox2.Controls.Add(Me.btnCaseNext)
        Me.GroupBox2.Controls.Add(Me.btnCasePrevious)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(56, 440)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 77)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Navigation"
        '
        'TestCaseDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnDeleteTestCase)
        Me.Controls.Add(Me.TestCasesTableDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "TestCaseDelete"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Test Cases"
        CType(Me.User_Story_ApplicationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TestCasesTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_Story_ApplicationDataSet As User_Story_ApplicationDataSet
    Friend WithEvents TestCasesTableBindingSource As BindingSource
    Friend WithEvents TestCasesTableTableAdapter As User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents TestCasesTextBox As TextBox
    Friend WithEvents TestCaseDetailsTextBox As TextBox
    Friend WithEvents UserStoryNoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDeleteTestCase As Button
    Friend WithEvents TestCasesTableDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCasePrevious As Button
    Friend WithEvents btnCaseNext As Button
    Friend WithEvents btnCaseDeleteFirst As Button
    Friend WithEvents btnCaseDeleteLast As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
