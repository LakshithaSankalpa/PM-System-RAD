<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Biling
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Biling))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SelectMedicine = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AvailableStockLB = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintBT = New System.Windows.Forms.Button()
        Me.AddtoBillBT = New System.Windows.Forms.Button()
        Me.DataGridViewBill = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TotAmountLB = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Text = "Billing Form"
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
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(18, 19)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(180, 26)
        Me.Quantity.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Quantity)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 62)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quantity"
        '
        'SelectMedicine
        '
        Me.SelectMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectMedicine.FormattingEnabled = True
        Me.SelectMedicine.Location = New System.Drawing.Point(18, 20)
        Me.SelectMedicine.Name = "SelectMedicine"
        Me.SelectMedicine.Size = New System.Drawing.Size(180, 28)
        Me.SelectMedicine.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.AvailableStockLB)
        Me.GroupBox5.Controls.Add(Me.SelectMedicine)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 88)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Medicine"
        '
        'AvailableStockLB
        '
        Me.AvailableStockLB.AutoSize = True
        Me.AvailableStockLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AvailableStockLB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.AvailableStockLB.ForeColor = System.Drawing.Color.White
        Me.AvailableStockLB.Location = New System.Drawing.Point(18, 51)
        Me.AvailableStockLB.Name = "AvailableStockLB"
        Me.AvailableStockLB.Size = New System.Drawing.Size(154, 18)
        Me.AvailableStockLB.TabIndex = 1
        Me.AvailableStockLB.Text = "Available Stock : --"
        Me.AvailableStockLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PrintBT)
        Me.Panel1.Controls.Add(Me.AddtoBillBT)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 500)
        Me.Panel1.TabIndex = 4
        '
        'PrintBT
        '
        Me.PrintBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PrintBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.PrintBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.PrintBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PrintBT.ForeColor = System.Drawing.Color.White
        Me.PrintBT.Image = Global.PM_System_RAD.My.Resources.Resources.print_40px
        Me.PrintBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBT.Location = New System.Drawing.Point(59, 301)
        Me.PrintBT.Name = "PrintBT"
        Me.PrintBT.Size = New System.Drawing.Size(125, 44)
        Me.PrintBT.TabIndex = 10
        Me.PrintBT.Text = "Print"
        Me.PrintBT.UseVisualStyleBackColor = False
        '
        'AddtoBillBT
        '
        Me.AddtoBillBT.BackColor = System.Drawing.Color.Red
        Me.AddtoBillBT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddtoBillBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.AddtoBillBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.AddtoBillBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddtoBillBT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.AddtoBillBT.ForeColor = System.Drawing.Color.White
        Me.AddtoBillBT.Image = Global.PM_System_RAD.My.Resources.Resources.add_dollar_24px
        Me.AddtoBillBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddtoBillBT.Location = New System.Drawing.Point(30, 225)
        Me.AddtoBillBT.Name = "AddtoBillBT"
        Me.AddtoBillBT.Size = New System.Drawing.Size(180, 40)
        Me.AddtoBillBT.TabIndex = 8
        Me.AddtoBillBT.Text = "Add To Bill"
        Me.AddtoBillBT.UseVisualStyleBackColor = False
        '
        'DataGridViewBill
        '
        Me.DataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBill.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBill.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewBill.GridColor = System.Drawing.Color.Brown
        Me.DataGridViewBill.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewBill.Name = "DataGridViewBill"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBill.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewBill.RowHeadersWidth = 35
        Me.DataGridViewBill.Size = New System.Drawing.Size(846, 410)
        Me.DataGridViewBill.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = " ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Medi_Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit_Price"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total_Price"
        Me.Column5.Name = "Column5"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TotAmountLB)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(234, 444)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(846, 56)
        Me.Panel3.TabIndex = 8
        '
        'TotAmountLB
        '
        Me.TotAmountLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotAmountLB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TotAmountLB.ForeColor = System.Drawing.Color.Red
        Me.TotAmountLB.Location = New System.Drawing.Point(0, 0)
        Me.TotAmountLB.Name = "TotAmountLB"
        Me.TotAmountLB.Size = New System.Drawing.Size(846, 56)
        Me.TotAmountLB.TabIndex = 0
        Me.TotAmountLB.Text = "Total Amount : Rs.0.00"
        Me.TotAmountLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.DataGridViewBill)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(234, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(846, 410)
        Me.Panel4.TabIndex = 9
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Biling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1080, 500)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Biling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Biling"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Quantity As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SelectMedicine As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AvailableStockLB As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddtoBillBT As Button
    Friend WithEvents DataGridViewBill As DataGridView
    Friend WithEvents PrintBT As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TotAmountLB As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
