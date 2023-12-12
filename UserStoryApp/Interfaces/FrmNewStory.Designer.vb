<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewStory
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
        Me.USTtb = New System.Windows.Forms.TextBox()
        Me.PriorityCB = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.StatusCB = New System.Windows.Forms.ComboBox()
        Me.URCB = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.USDtb = New System.Windows.Forms.TextBox()
        Me.TCDtb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.USDlbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NewTCDlbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddTC = New System.Windows.Forms.Button()
        Me.RemTClbl = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Resp1lbl = New System.Windows.Forms.Label()
        Me.name1lbl = New System.Windows.Forms.Label()
        Me.Resp1CB = New System.Windows.Forms.ComboBox()
        Me.Name1CB = New System.Windows.Forms.ComboBox()
        Me.UserStoryApplicationDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_Story_ApplicationDataSet1 = New UserStoryApp.User_Story_ApplicationDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Resp2lbl = New System.Windows.Forms.Label()
        Me.Name2lbl = New System.Windows.Forms.Label()
        Me.Resp2CB = New System.Windows.Forms.ComboBox()
        Me.Name2CB = New System.Windows.Forms.ComboBox()
        Me.UserStoryApplicationDataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordUSbtn = New System.Windows.Forms.Button()
        Me.TClbox = New System.Windows.Forms.ListBox()
        Me.TestCasesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.MemberTableTableAdapter()
        Me.UserStory_MemberTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.UserStory_MemberTableTableAdapter()
        Me.TestCasesTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter()
        Me.UserStoryTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStory_MemberTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableTableAdapter1 = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.UserStoryTableTableAdapter()
        Me.TableAdapterManager = New UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UserStoryApplicationDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Story_ApplicationDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UserStoryApplicationDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStory_MemberTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USTtb
        '
        Me.USTtb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.USTtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USTtb.Location = New System.Drawing.Point(52, 54)
        Me.USTtb.Multiline = True
        Me.USTtb.Name = "USTtb"
        Me.USTtb.Size = New System.Drawing.Size(350, 77)
        Me.USTtb.TabIndex = 0
        '
        'PriorityCB
        '
        Me.PriorityCB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PriorityCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityCB.FormattingEnabled = True
        Me.PriorityCB.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.PriorityCB.Location = New System.Drawing.Point(1039, 54)
        Me.PriorityCB.Name = "PriorityCB"
        Me.PriorityCB.Size = New System.Drawing.Size(121, 26)
        Me.PriorityCB.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Location = New System.Drawing.Point(599, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'StatusCB
        '
        Me.StatusCB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.StatusCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusCB.FormattingEnabled = True
        Me.StatusCB.Items.AddRange(New Object() {"In Progress", "Complete"})
        Me.StatusCB.Location = New System.Drawing.Point(1069, 184)
        Me.StatusCB.Name = "StatusCB"
        Me.StatusCB.Size = New System.Drawing.Size(121, 26)
        Me.StatusCB.TabIndex = 3
        '
        'URCB
        '
        Me.URCB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.URCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URCB.FormattingEnabled = True
        Me.URCB.Items.AddRange(New Object() {"Manager", "Customer", "Instructor"})
        Me.URCB.Location = New System.Drawing.Point(444, 54)
        Me.URCB.Name = "URCB"
        Me.URCB.Size = New System.Drawing.Size(121, 26)
        Me.URCB.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker2.Location = New System.Drawing.Point(805, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'USDtb
        '
        Me.USDtb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.USDtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USDtb.Location = New System.Drawing.Point(52, 184)
        Me.USDtb.Multiline = True
        Me.USDtb.Name = "USDtb"
        Me.USDtb.Size = New System.Drawing.Size(350, 278)
        Me.USDtb.TabIndex = 6
        '
        'TCDtb
        '
        Me.TCDtb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TCDtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCDtb.Location = New System.Drawing.Point(477, 184)
        Me.TCDtb.Multiline = True
        Me.TCDtb.Name = "TCDtb"
        Me.TCDtb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TCDtb.Size = New System.Drawing.Size(528, 98)
        Me.TCDtb.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User Story Title"
        '
        'USDlbl
        '
        Me.USDlbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.USDlbl.AutoSize = True
        Me.USDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USDlbl.Location = New System.Drawing.Point(96, 142)
        Me.USDlbl.Name = "USDlbl"
        Me.USDlbl.Size = New System.Drawing.Size(253, 29)
        Me.USDlbl.TabIndex = 11
        Me.USDlbl.Text = "User Story Description"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "User Role"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(649, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(849, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "End Date"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1034, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Priority"
        '
        'NewTCDlbl
        '
        Me.NewTCDlbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewTCDlbl.AutoSize = True
        Me.NewTCDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTCDlbl.Location = New System.Drawing.Point(472, 142)
        Me.NewTCDlbl.Name = "NewTCDlbl"
        Me.NewTCDlbl.Size = New System.Drawing.Size(247, 29)
        Me.NewTCDlbl.TabIndex = 16
        Me.NewTCDlbl.Text = "New Test Case Detail"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1064, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 29)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Status"
        '
        'AddTC
        '
        Me.AddTC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTC.Location = New System.Drawing.Point(477, 288)
        Me.AddTC.Name = "AddTC"
        Me.AddTC.Size = New System.Drawing.Size(188, 23)
        Me.AddTC.TabIndex = 18
        Me.AddTC.Text = "Add New Test Case"
        Me.AddTC.UseVisualStyleBackColor = True
        '
        'RemTClbl
        '
        Me.RemTClbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RemTClbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemTClbl.Location = New System.Drawing.Point(698, 288)
        Me.RemTClbl.Name = "RemTClbl"
        Me.RemTClbl.Size = New System.Drawing.Size(188, 23)
        Me.RemTClbl.TabIndex = 19
        Me.RemTClbl.Text = "Remove Test Case"
        Me.RemTClbl.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(610, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Finalised Test Cases"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Resp1lbl)
        Me.GroupBox1.Controls.Add(Me.name1lbl)
        Me.GroupBox1.Controls.Add(Me.Resp1CB)
        Me.GroupBox1.Controls.Add(Me.Name1CB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(96, 509)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 126)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programmer 1"
        '
        'Resp1lbl
        '
        Me.Resp1lbl.AutoSize = True
        Me.Resp1lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resp1lbl.Location = New System.Drawing.Point(190, 49)
        Me.Resp1lbl.Name = "Resp1lbl"
        Me.Resp1lbl.Size = New System.Drawing.Size(113, 18)
        Me.Resp1lbl.TabIndex = 25
        Me.Resp1lbl.Text = "Responsibility"
        '
        'name1lbl
        '
        Me.name1lbl.AutoSize = True
        Me.name1lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1lbl.Location = New System.Drawing.Point(72, 49)
        Me.name1lbl.Name = "name1lbl"
        Me.name1lbl.Size = New System.Drawing.Size(52, 18)
        Me.name1lbl.TabIndex = 23
        Me.name1lbl.Text = "Name"
        '
        'Resp1CB
        '
        Me.Resp1CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resp1CB.FormattingEnabled = True
        Me.Resp1CB.Items.AddRange(New Object() {"Main", "Sub"})
        Me.Resp1CB.Location = New System.Drawing.Point(193, 68)
        Me.Resp1CB.Name = "Resp1CB"
        Me.Resp1CB.Size = New System.Drawing.Size(121, 26)
        Me.Resp1CB.TabIndex = 24
        '
        'Name1CB
        '
        Me.Name1CB.DataSource = Me.UserStoryApplicationDataSet1BindingSource
        Me.Name1CB.DisplayMember = "MemberTable.FirstName"
        Me.Name1CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1CB.FormattingEnabled = True
        Me.Name1CB.Location = New System.Drawing.Point(24, 68)
        Me.Name1CB.Name = "Name1CB"
        Me.Name1CB.Size = New System.Drawing.Size(139, 26)
        Me.Name1CB.TabIndex = 23
        Me.Name1CB.ValueMember = "GroupMemberNo"
        '
        'UserStoryApplicationDataSet1BindingSource
        '
        Me.UserStoryApplicationDataSet1BindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        Me.UserStoryApplicationDataSet1BindingSource.Position = 0
        '
        'User_Story_ApplicationDataSet1
        '
        Me.User_Story_ApplicationDataSet1.DataSetName = "User_Story_ApplicationDataSet"
        Me.User_Story_ApplicationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.Resp2lbl)
        Me.GroupBox2.Controls.Add(Me.Name2lbl)
        Me.GroupBox2.Controls.Add(Me.Resp2CB)
        Me.GroupBox2.Controls.Add(Me.Name2CB)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(477, 509)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 126)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Programmer 2"
        '
        'Resp2lbl
        '
        Me.Resp2lbl.AutoSize = True
        Me.Resp2lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resp2lbl.Location = New System.Drawing.Point(190, 49)
        Me.Resp2lbl.Name = "Resp2lbl"
        Me.Resp2lbl.Size = New System.Drawing.Size(113, 18)
        Me.Resp2lbl.TabIndex = 25
        Me.Resp2lbl.Text = "Responsibility"
        '
        'Name2lbl
        '
        Me.Name2lbl.AutoSize = True
        Me.Name2lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2lbl.Location = New System.Drawing.Point(72, 49)
        Me.Name2lbl.Name = "Name2lbl"
        Me.Name2lbl.Size = New System.Drawing.Size(52, 18)
        Me.Name2lbl.TabIndex = 23
        Me.Name2lbl.Text = "Name"
        '
        'Resp2CB
        '
        Me.Resp2CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resp2CB.FormattingEnabled = True
        Me.Resp2CB.Items.AddRange(New Object() {"Main", "Sub"})
        Me.Resp2CB.Location = New System.Drawing.Point(193, 68)
        Me.Resp2CB.Name = "Resp2CB"
        Me.Resp2CB.Size = New System.Drawing.Size(121, 26)
        Me.Resp2CB.TabIndex = 24
        '
        'Name2CB
        '
        Me.Name2CB.DataSource = Me.UserStoryApplicationDataSet1BindingSource1
        Me.Name2CB.DisplayMember = "MemberTable.FirstName"
        Me.Name2CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2CB.FormattingEnabled = True
        Me.Name2CB.Location = New System.Drawing.Point(34, 68)
        Me.Name2CB.Name = "Name2CB"
        Me.Name2CB.Size = New System.Drawing.Size(121, 26)
        Me.Name2CB.TabIndex = 23
        Me.Name2CB.ValueMember = "GroupMemberNo"
        '
        'UserStoryApplicationDataSet1BindingSource1
        '
        Me.UserStoryApplicationDataSet1BindingSource1.DataSource = Me.User_Story_ApplicationDataSet1
        Me.UserStoryApplicationDataSet1BindingSource1.Position = 0
        '
        'RecordUSbtn
        '
        Me.RecordUSbtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecordUSbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordUSbtn.Location = New System.Drawing.Point(1039, 509)
        Me.RecordUSbtn.Name = "RecordUSbtn"
        Me.RecordUSbtn.Size = New System.Drawing.Size(196, 126)
        Me.RecordUSbtn.TabIndex = 27
        Me.RecordUSbtn.Text = "Record User Story"
        Me.RecordUSbtn.UseVisualStyleBackColor = True
        '
        'TClbox
        '
        Me.TClbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TClbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TClbox.FormattingEnabled = True
        Me.TClbox.HorizontalScrollbar = True
        Me.TClbox.ItemHeight = 18
        Me.TClbox.Location = New System.Drawing.Point(477, 317)
        Me.TClbox.Name = "TClbox"
        Me.TClbox.ScrollAlwaysVisible = True
        Me.TClbox.Size = New System.Drawing.Size(528, 148)
        Me.TClbox.TabIndex = 28
        '
        'MemberTableTableAdapter1
        '
        Me.MemberTableTableAdapter1.ClearBeforeFill = True
        '
        'UserStory_MemberTableTableAdapter1
        '
        Me.UserStory_MemberTableTableAdapter1.ClearBeforeFill = True
        '
        'TestCasesTableTableAdapter1
        '
        Me.TestCasesTableTableAdapter1.ClearBeforeFill = True
        '
        'UserStoryTableBindingSource
        '
        Me.UserStoryTableBindingSource.DataMember = "UserStoryTable"
        Me.UserStoryTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        '
        'MemberTableBindingSource
        '
        Me.MemberTableBindingSource.DataMember = "MemberTable"
        Me.MemberTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        '
        'UserStory_MemberTableBindingSource
        '
        Me.UserStory_MemberTableBindingSource.DataMember = "UserStory_MemberTable"
        Me.UserStory_MemberTableBindingSource.DataSource = Me.User_Story_ApplicationDataSet1
        '
        'UserStoryTableTableAdapter1
        '
        Me.UserStoryTableTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MemberTableTableAdapter = Me.MemberTableTableAdapter1
        Me.TableAdapterManager.TestCasesTableTableAdapter = Me.TestCasesTableTableAdapter1
        Me.TableAdapterManager.UpdateOrder = UserStoryApp.User_Story_ApplicationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableTableAdapter = Me.UserStory_MemberTableTableAdapter1
        Me.TableAdapterManager.UserStoryTableTableAdapter = Me.UserStoryTableTableAdapter1
        '
        'FrmNewStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1272, 710)
        Me.Controls.Add(Me.TClbox)
        Me.Controls.Add(Me.RecordUSbtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RemTClbl)
        Me.Controls.Add(Me.AddTC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NewTCDlbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.USDlbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TCDtb)
        Me.Controls.Add(Me.USDtb)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.URCB)
        Me.Controls.Add(Me.StatusCB)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PriorityCB)
        Me.Controls.Add(Me.USTtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "FrmNewStory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record User Story"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UserStoryApplicationDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Story_ApplicationDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UserStoryApplicationDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStory_MemberTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents USTtb As TextBox
    Friend WithEvents PriorityCB As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents StatusCB As ComboBox
    Friend WithEvents URCB As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents USDtb As TextBox
    Friend WithEvents TCDtb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents USDlbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NewTCDlbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AddTC As Button
    Friend WithEvents RemTClbl As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Resp1lbl As Label
    Friend WithEvents name1lbl As Label
    Friend WithEvents Resp1CB As ComboBox
    Friend WithEvents Name1CB As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Resp2lbl As Label
    Friend WithEvents Name2lbl As Label
    Friend WithEvents Resp2CB As ComboBox
    Friend WithEvents Name2CB As ComboBox
    Friend WithEvents RecordUSbtn As Button
    Friend WithEvents User_Story_ApplicationDataSet1 As User_Story_ApplicationDataSet
    Friend WithEvents MemberTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.MemberTableTableAdapter
    Friend WithEvents UserStoryApplicationDataSet1BindingSource As BindingSource
    Friend WithEvents UserStoryApplicationDataSet1BindingSource1 As BindingSource
    Friend WithEvents UserStory_MemberTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.UserStory_MemberTableTableAdapter
    Friend WithEvents TClbox As ListBox
    Friend WithEvents TestCasesTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.TestCasesTableTableAdapter
    Friend WithEvents UserStoryTableBindingSource As BindingSource
    Friend WithEvents TestCasesTableBindingSource As BindingSource
    Friend WithEvents MemberTableBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableBindingSource As BindingSource
    Friend WithEvents UserStoryTableTableAdapter1 As User_Story_ApplicationDataSetTableAdapters.UserStoryTableTableAdapter
    Friend WithEvents TableAdapterManager As User_Story_ApplicationDataSetTableAdapters.TableAdapterManager
End Class
