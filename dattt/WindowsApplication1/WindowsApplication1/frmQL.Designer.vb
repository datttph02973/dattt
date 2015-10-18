<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQL
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
        Me.dgvQL = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvQL
        '
        Me.dgvQL.AllowUserToAddRows = False
        Me.dgvQL.AllowUserToDeleteRows = False
        Me.dgvQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQL.Location = New System.Drawing.Point(13, 67)
        Me.dgvQL.MultiSelect = False
        Me.dgvQL.Name = "dgvQL"
        Me.dgvQL.ReadOnly = True
        Me.dgvQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQL.Size = New System.Drawing.Size(427, 287)
        Me.dgvQL.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(481, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(481, 109)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(114, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(481, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Detele"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(81, 35)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(247, 20)
        Me.txtSearch.TabIndex = 2
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"MaKH", "TenKH"})
        Me.cmbSearch.Location = New System.Drawing.Point(348, 35)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(92, 21)
        Me.cmbSearch.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbClass)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 90)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Class"
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(22, 51)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(92, 21)
        Me.cmbClass.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search"
        '
        'FrmQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 381)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvQL)
        Me.Name = "FrmQL"
        Me.Text = "Quan Ly Khach Hang"
        CType(Me.dgvQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvQL As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
