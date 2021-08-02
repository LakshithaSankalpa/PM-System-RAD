<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewEMP = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.UpdateBT = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.AddBT = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ViewBT = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmployeeNameTB = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTB = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmployeeAgeTB = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EmployeeSalaryTB = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.UserNameLB = New System.Windows.Forms.Label()
        Me.ClearBT = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.DataGridViewEMP)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(234, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(846, 422)
        Me.Panel4.TabIndex = 7
        '
        'DataGridViewEMP
        '
        Me.DataGridViewEMP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewEMP.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEMP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEMP.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewEMP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewEMP.GridColor = System.Drawing.Color.Brown
        Me.DataGridViewEMP.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewEMP.Name = "DataGridViewEMP"
        Me.DataGridViewEMP.ReadOnly = True
        Me.DataGridViewEMP.Size = New System.Drawing.Size(846, 422)
        Me.DataGridViewEMP.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.UpdateBT)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(346, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(125, 44)
        Me.Panel8.TabIndex = 12
        '
        'UpdateBT
        '
        Me.UpdateBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.UpdateBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.UpdateBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.UpdateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.UpdateBT.ForeColor = System.Drawing.Color.White
        Me.UpdateBT.Image = Global.PM_System_RAD.My.Resources.Resources.refresh_shield_64px
        Me.UpdateBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateBT.Location = New System.Drawing.Point(0, 0)
        Me.UpdateBT.Name = "UpdateBT"
        Me.UpdateBT.Size = New System.Drawing.Size(125, 44)
        Me.UpdateBT.TabIndex = 8
        Me.UpdateBT.Text = "Update"
        Me.UpdateBT.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.AddBT)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(471, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(125, 44)
        Me.Panel7.TabIndex = 12
        '
        'AddBT
        '
        Me.AddBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.AddBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.AddBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.AddBT.ForeColor = System.Drawing.Color.White
        Me.AddBT.Image = Global.PM_System_RAD.My.Resources.Resources.add_tag_40px1
        Me.AddBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBT.Location = New System.Drawing.Point(0, 0)
        Me.AddBT.Name = "AddBT"
        Me.AddBT.Size = New System.Drawing.Size(125, 44)
        Me.AddBT.TabIndex = 7
        Me.AddBT.Text = "Add"
        Me.AddBT.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DeleteBT)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(596, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(125, 44)
        Me.Panel6.TabIndex = 12
        '
        'DeleteBT
        '
        Me.DeleteBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DeleteBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.DeleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.DeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DeleteBT.ForeColor = System.Drawing.Color.White
        Me.DeleteBT.Image = Global.PM_System_RAD.My.Resources.Resources.delete_database_48px
        Me.DeleteBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBT.Location = New System.Drawing.Point(0, 0)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(125, 44)
        Me.DeleteBT.TabIndex = 9
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ViewBT)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(721, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(125, 44)
        Me.Panel5.TabIndex = 11
        '
        'ViewBT
        '
        Me.ViewBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ViewBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.ViewBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ViewBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ViewBT.ForeColor = System.Drawing.Color.White
        Me.ViewBT.Image = Global.PM_System_RAD.My.Resources.Resources.preview_pane_64px
        Me.ViewBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ViewBT.Location = New System.Drawing.Point(0, 0)
        Me.ViewBT.Name = "ViewBT"
        Me.ViewBT.Size = New System.Drawing.Size(125, 44)
        Me.ViewBT.TabIndex = 10
        Me.ViewBT.Text = "View"
        Me.ViewBT.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(234, 456)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(846, 44)
        Me.Panel3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMP Account List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(234, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 34)
        Me.Panel2.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.EmployeeNameTB)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Name"
        '
        'EmployeeNameTB
        '
        Me.EmployeeNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTB.Location = New System.Drawing.Point(18, 19)
        Me.EmployeeNameTB.Name = "EmployeeNameTB"
        Me.EmployeeNameTB.Size = New System.Drawing.Size(180, 26)
        Me.EmployeeNameTB.TabIndex = 0
        Me.EmployeeNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmployeeIDTB
        '
        Me.EmployeeIDTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTB.Location = New System.Drawing.Point(18, 19)
        Me.EmployeeIDTB.Name = "EmployeeIDTB"
        Me.EmployeeIDTB.Size = New System.Drawing.Size(180, 26)
        Me.EmployeeIDTB.TabIndex = 0
        Me.EmployeeIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.EmployeeIDTB)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee ID"
        '
        'EmployeeAgeTB
        '
        Me.EmployeeAgeTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeAgeTB.Location = New System.Drawing.Point(18, 19)
        Me.EmployeeAgeTB.Name = "EmployeeAgeTB"
        Me.EmployeeAgeTB.Size = New System.Drawing.Size(180, 26)
        Me.EmployeeAgeTB.TabIndex = 0
        Me.EmployeeAgeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.EmployeeAgeTB)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee Age"
        '
        'EmployeeSalaryTB
        '
        Me.EmployeeSalaryTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeSalaryTB.Location = New System.Drawing.Point(50, 19)
        Me.EmployeeSalaryTB.Name = "EmployeeSalaryTB"
        Me.EmployeeSalaryTB.Size = New System.Drawing.Size(148, 26)
        Me.EmployeeSalaryTB.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.EmployeeSalaryTB)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Employee Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rs."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.ClearBT)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 500)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.UserNameLB)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(12, 329)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(216, 44)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "User Name"
        '
        'UserNameLB
        '
        Me.UserNameLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.UserNameLB.Location = New System.Drawing.Point(18, 16)
        Me.UserNameLB.Name = "UserNameLB"
        Me.UserNameLB.Size = New System.Drawing.Size(180, 20)
        Me.UserNameLB.TabIndex = 4
        Me.UserNameLB.Text = "------"
        Me.UserNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearBT
        '
        Me.ClearBT.BackColor = System.Drawing.Color.Red
        Me.ClearBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.ClearBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClearBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ClearBT.ForeColor = System.Drawing.Color.White
        Me.ClearBT.Image = Global.PM_System_RAD.My.Resources.Resources.back_24px1
        Me.ClearBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearBT.Location = New System.Drawing.Point(48, 445)
        Me.ClearBT.Name = "ClearBT"
        Me.ClearBT.Size = New System.Drawing.Size(140, 43)
        Me.ClearBT.TabIndex = 10
        Me.ClearBT.Text = "Clear"
        Me.ClearBT.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Password)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(12, 379)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Password"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(18, 19)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(180, 26)
        Me.Password.TabIndex = 0
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Phone)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Phone"
        '
        'Phone
        '
        Me.Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(18, 19)
        Me.Phone.MaxLength = 10
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(180, 26)
        Me.Phone.TabIndex = 0
        Me.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1080, 500)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Employee"
        Me.Text = "Employee"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridViewEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewBT As Button
    Friend WithEvents AddBT As Button
    Friend WithEvents UpdateBT As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DeleteBT As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmployeeNameTB As TextBox
    Friend WithEvents EmployeeIDTB As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EmployeeAgeTB As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EmployeeSalaryTB As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Password As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents DataGridViewEMP As DataGridView
    Friend WithEvents ClearBT As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents UserNameLB As Label
End Class
